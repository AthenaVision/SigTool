using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using MaterialSkin;
using Microsoft.Win32;
using System.IO;

namespace SigTool
{
    public partial class Form1 : MaterialSkin.Controls.MaterialForm
    {




        public Form1(string FileToOpen)
        {
            MaterialSkinManager.Instance.ColorScheme = MaterialSkinManager.Colors.Blue;
             MaterialSkinManager.Instance.Theme = MaterialSkinManager.Themes.DARK;

            InitializeComponent();
            PreUnknown.Visible = false;
            proclistview.BackColor = MaterialSkinManager.Instance.GetApplicationBackgroundColor();

            UIUpdate();
            ProdUpdate();

            proclistview.Columns.Add("Process", 200, HorizontalAlignment.Left);
            proclistview.Columns.Add("Title", -2, HorizontalAlignment.Center);


            sigEditListView.BackColor = MaterialSkinManager.Instance.GetApplicationBackgroundColor();
            sigEditListView.Columns.Add("Name", 200, HorizontalAlignment.Left);
            sigEditListView.Columns.Add("Sig", 100, HorizontalAlignment.Center);
            sigEditListView.Columns.Add("Function", 100, HorizontalAlignment.Right);
            sigEditListView.Columns.Add("Address ", -2, HorizontalAlignment.Right);

            refreshprocesses();
            System.Threading.Thread bgthread = new System.Threading.Thread(bgshit);
            bgthread.Start();

            if (FileToOpen != "none")
            {
                LoadFile(FileToOpen);
            }
        }

        void refreshprocesses()
        {
            Process[] processlist = Process.GetProcesses();
            proclistview.Items.Clear();
            for (int i = 0; i < processlist.Length; i++)
            {
                try
                {
                    if ((processlist[i].ProcessName.IndexOf(this.searchbox.Text, StringComparison.OrdinalIgnoreCase) >= 0) ||
                        (processlist[i].MainWindowTitle.IndexOf(this.searchbox.Text, StringComparison.OrdinalIgnoreCase) >= 0))
                    {
                        // if (processlist[i].IsWin64Emulator())
                        {
                            ListViewItem item1 = new ListViewItem(new string[] { processlist[i].ProcessName, processlist[i].MainWindowTitle });

                            proclistview.Items.Add(item1);
                        }
                    }
                }
                catch (Exception) { }
            }
        }
        SigStyle GetAutoID(string data)
        {
            //  if (Regex.Matches(data, @"\\x[0-9a-f]{2}{ 2}").Count * 4 == data.Length) return SigStyle.Code;
            // if (Regex.Matches(data, @"0x[0-9a-f]{2},?\s?").Count * 6 == data.Length - 2) return SigStyle.Byte;
            //  if ((Regex.Matches(data, @"[0-9a-f]{2}\s?").Count * 3) + (Regex.Matches(data, @"\?\s").Count * 2) == data.Length) return SigStyle.IDA;
            //  if (Regex.Matches(data, @"[0-9a-f\?]{2}\s?").Count * 3 == data.Length - 1) return SigStyle.PEiD;

            if (Regex.Matches(data, @"\\x[0-9a-f]{2}").Count * 4 == data.Length) return SigStyle.Code;
            if (Regex.Matches(data + ", ", @"0x[0-9a-f]{2},\s").Count * 6 == data.Length + 2) return SigStyle.Byte;
            if (CheckIDA(data)) return SigStyle.IDA;
            if (CheckPEiD(data)) return SigStyle.PEiD;



            return SigStyle.Error;
        }



        void UIUpdate()
        {
            PreRadio_Code.AutoCheck = PreRadio_IDA.AutoCheck = PreRadio_PEiD.AutoCheck = PreRadio_Byte.AutoCheck = PreCheck_Auto.Enabled;

            SigStyle ID = SigStyle.Error;
            if (PreCheck_Auto.Checked)
            {
                ID = GetAutoID(PreData.Text);
                switch (ID)
                {
                    case SigStyle.Byte: PreRadio_Byte.Checked = true; break;
                    case SigStyle.Code: PreRadio_Code.Checked = true; break;
                    case SigStyle.IDA: PreRadio_IDA.Checked = true; break;
                    case SigStyle.PEiD: PreRadio_PEiD.Checked = true; break;
                    case SigStyle.Error: PreUnknown.Visible = PreUnknown.Checked = true; break;
                }
            }
            else
            {
                PreUnknown.Visible = PreUnknown.Checked = false;
                if (PreRadio_Byte.Checked) ID = SigStyle.Byte;
                if (PreRadio_Code.Checked) ID = SigStyle.Code;
                if (PreRadio_IDA.Checked) ID = SigStyle.IDA;
                if (PreRadio_PEiD.Checked) ID = SigStyle.PEiD;
            }

            if (ID == SigStyle.Error)
            {
                PreUnknown.Visible = PreUnknown.Checked = true;
            }
            else
            {
                PreUnknown.Visible = false;
            }



            PreMask.Enabled = !(PreRadio_IDA.Checked || PreRadio_PEiD.Checked);
            PostMask.Enabled = !(PostRadio_IDA.Checked || PostRadio_PEiD.Checked);


            bool? preDataGood = true;
            if (PreRadio_Byte.Checked) preDataGood = CheckByte(PreData.Text, PreMask.Text);
            if (PreRadio_Code.Checked) preDataGood = CheckCode(PreData.Text, PreMask.Text);
            if (PreRadio_PEiD.Checked) preDataGood = CheckPEiD(PreData.Text);
            if (PreRadio_IDA.Checked) preDataGood = CheckIDA(PreData.Text);


            SigStyle PostStyle = SigStyle.Byte;
            if (PostRadio_Code.Checked) PostStyle = SigStyle.Code;
            if (PostRadio_IDA.Checked) PostStyle = SigStyle.IDA;
            if (PostRadio_PEiD.Checked) PostStyle = SigStyle.PEiD;




            switch (preDataGood)
            {
                case (true):
                    PostData.Enabled = true;
                    string[] result = ConvertSig(ID, PostStyle, PreData.Text, PreMask.Text);
                    PostData.Text = result[0];
                    if (result[1] != "")
                    {
                        PostMask.Text = result[1];
                        PostMask.Enabled = true;
                    }
                    else
                    {
                        PostMask.Enabled = false;
                    }
                    break;
                case (false):
                    PostData.Text = "Bad Sig";
                    PostData.Enabled = false;
                    PostMask.Text = "Bad Sig";
                    PostMask.Enabled = false;
                    break;
                case (null):
                    PostData.Text = "Good Sig";
                    PostData.Enabled = true;
                    PostMask.Text = "Bad Mask";
                    PostMask.Enabled = false;
                    break;
            }






        }


        string SigToSave = "";
        string SigToComp = "";
        string MaskToComp = "";
        Process targetproc;
        void ProdUpdate()
        {
            ProdData.Text = ProdData.Text.ToLower();



            ProdRadio_Code.AutoCheck = ProdRadio_IDA.AutoCheck = ProdRadio_PEiD.AutoCheck = ProdRadio_Byte.AutoCheck = ProdAutoDetect.Enabled;

            foreach (Signature sig in Signature.list)
            {
                if (sig.name == ProdSigName.Text)
                {
                    savesigbutton.Enabled = validsigbox.Checked = false;
                    return;
                }
            }


            SigStyle ID = SigStyle.Error;
            if (ProdAutoDetect.Checked)
            {
                ID = GetAutoID(ProdData.Text);
                switch (ID)
                {
                    case SigStyle.Byte: ProdRadio_Byte.Checked = true; ProdMask.Enabled = true; break;
                    case SigStyle.Code: ProdRadio_Code.Checked = true; ProdMask.Enabled = true; break;
                    case SigStyle.IDA: ProdRadio_IDA.Checked = true; ProdMask.Enabled = false; break;
                    case SigStyle.PEiD: ProdRadio_PEiD.Checked = true; ProdMask.Enabled = false; break;
                    case SigStyle.Error: ProdUnknown.Visible = ProdUnknown.Checked = true; break;
                }
            }
            else
            {
                ProdUnknown.Visible = ProdUnknown.Checked = false;
                if (ProdRadio_Byte.Checked) { ID = SigStyle.Byte; }
                if (ProdRadio_Code.Checked) { ID = SigStyle.Code; }
                if (ProdRadio_IDA.Checked) { ID = SigStyle.IDA; }
                if (ProdRadio_PEiD.Checked) { ID = SigStyle.PEiD; }
            }

            if (ID == SigStyle.Error)
            {
                ProdUnknown.Visible = ProdUnknown.Checked = true;
            }
            else
            {
                ProdUnknown.Visible = false;
            }


            bool? ProdDataGood = true;
            if (ProdRadio_Byte.Checked) ProdDataGood = CheckByte(ProdData.Text, ProdMask.Text);
            if (ProdRadio_Code.Checked) ProdDataGood = CheckCode(ProdData.Text, ProdMask.Text);
            if (ProdRadio_PEiD.Checked) ProdDataGood = CheckPEiD(ProdData.Text);
            if (ProdRadio_IDA.Checked) ProdDataGood = CheckIDA(ProdData.Text);




            switch (ProdDataGood)
            {
                case (true):
                    savesigbutton.Enabled = validsigbox.Checked = true;
                    SigToSave = ConvertPEiD(ID, ProdData.Text, ProdMask.Text);
                    SigToComp = ConvertSig(ID, SigStyle.Byte, ProdData.Text, ProdMask.Text)[0];
                    MaskToComp = ConvertSig(ID, SigStyle.Code, ProdData.Text, ProdMask.Text)[1];

                    break;
                case (false):
                    savesigbutton.Enabled = validsigbox.Checked = false;
                    break;
                case (null):
                    savesigbutton.Enabled = validsigbox.Checked = false;

                    break;
            }






        }


        enum SigStyle
        {
            Code, IDA, PEiD, Byte, Error
        }

        bool CheckIDA(string data)
        {
            bool toret = ((((Regex.Matches(data + " ", @"[0-9a-f]{2}\s").Count * 3) + (Regex.Matches(data + " ", @"[\?]\s").Count) * 2)) == data.Length + 1);
            if (toret != true) return false;
            return true;
        }

        bool CheckPEiD(string data)
        {
            bool toret = (Regex.Matches(data + " ", @"[0-9a-f\?]{2}\s").Count * 3 == data.Length + 1);
            if (toret != true) return false;
            return true;
        }


        bool? CheckByte(string data, string mask)
        {
            //check syntax
            bool toret = (Regex.Matches(data + ", ", @"0x[0-9a-f]{2},\s").Count * 6 == data.Length + 2);
            if (toret != true) return false;
            //check mask
            toret = (Regex.Matches(data + ", ", @"0x[0-9a-f]{2},\s").Count == mask.Length);
            if (toret != true) return null;
            toret = (Regex.Matches(mask, @"[x?]").Count == mask.Length);
            if (toret != true) return null;
            return true;
        }

        bool? CheckCode(string data, string mask)
        {
            //check syntax
            bool toret = (Regex.Matches(data, @"\\x[0-9a-f]{2}").Count * 4 == data.Length);
            if (toret != true) return false;
            //check mask
            toret = (Regex.Matches(data, @"\\x[0-9a-f]{2}").Count == mask.Length);
            if (toret != true) return null;
            toret = (Regex.Matches(mask, @"[x?]").Count == mask.Length);
            if (toret != true) return null;
            return true;
        }



        string ConvertPEiD(SigStyle fromsigstyle, string data, string mask)
        {
            string outstr = data;
            if ((fromsigstyle == SigStyle.IDA) && CheckIDA(data)) outstr = data.Replace("?", "??");
            if ((fromsigstyle == SigStyle.PEiD) && CheckPEiD(data)) outstr = data;
            if ((fromsigstyle == SigStyle.Code) && CheckCode(data, mask) == true)
            {
                for (int i = 0; i < mask.Length; i++)
                {
                    if (mask[i] == '?')
                    {
                        outstr = outstr.Remove(((i * 4) + 2), 2).Insert(((i * 4) + 2), "??");
                    }
                }
                outstr = Regex.Replace(outstr, @"\\x", " ").TrimStart(' ');
            }
            if ((fromsigstyle == SigStyle.Byte) && CheckByte(data, mask) == true)
            {
                for (int i = 0; i < mask.Length; i++)
                {
                    if (mask[i] == '?')
                    {
                        outstr = outstr.Remove(((i * 6) + 2), 2).Insert(((i * 6) + 2), "??");
                    }
                }
                outstr = Regex.Replace(outstr, @",?\s?0x", " ").TrimStart(' ');
            }

            return outstr;
        }




        string[] ConvertSig(SigStyle fromstyle, SigStyle tostyle, string data, string mask)
        {
            data = ConvertPEiD(fromstyle, data, mask);
            string[] outstr = new string[] { "", "" };
            if ((tostyle == SigStyle.PEiD) && CheckPEiD(data)) outstr[0] = data;
            if ((tostyle == SigStyle.IDA) && CheckPEiD(data))
            {
                outstr[0] = Regex.Replace(data, @"\?{2}", "?");
            }
            if ((tostyle == SigStyle.Code) && CheckPEiD(data) == true)
            {

                string tmpstr = " " + data;
                string tmpmask = data;

                tmpmask = Regex.Replace(tmpmask, @"[0-9a-f]{2}\s?", "x");
                tmpmask = Regex.Replace(tmpmask, @"[\?]{2}\s?", "?");

                tmpstr = Regex.Replace(tmpstr, @"[\s]", "\\x");
                tmpstr = Regex.Replace(tmpstr, @"[\?]{2}\s?", "00");
                outstr[0] = tmpstr;
                outstr[1] = tmpmask;
            }
            if ((tostyle == SigStyle.Byte) && CheckPEiD(data) == true)
            {
                string tmpstr = " " + data;
                string tmpmask = data;

                tmpmask = Regex.Replace(tmpmask, @"[0-9a-f]{2}\s?", "x");
                tmpmask = Regex.Replace(tmpmask, @"[\?]{2}\s?", "?");

                tmpstr = Regex.Replace(tmpstr, @"[\s]", ", 0x");
                tmpstr = Regex.Replace(tmpstr, @"[\?]{2}\s?", "00");
                outstr[0] = tmpstr.TrimStart(' ', ',');
                outstr[1] = tmpmask;


            }

            return outstr;

        }




        private void PreData_TextChanged(object sender, EventArgs e)
        {
            PreData.Text = PreData.Text.ToLower();
            UIUpdate();

        }
        private void PreRadio_Code_CheckedChanged(object sender, EventArgs e)
        {
            PreData.Text = PreData.Text.ToLower();

            UIUpdate();

        }
        private void PostRadio_Code_CheckedChanged(object sender, EventArgs e)
        {
            UIUpdate();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            UIUpdate();
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            refreshprocesses();
        }

        private void ProdRadio_Code_CheckedChanged(object sender, EventArgs e)
        {
            ProdUpdate();
        }

        private void proclistview_ItemActivate(object sender, EventArgs e)
        {
            ProcessBox.Text = proclistview.SelectedItems[0].Text;
            tabcontrol.SelectedIndex = 0;
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            tabcontrol.SelectedIndex = 1;
        }

        private void savesigbutton_Click(object sender, EventArgs e)
        {
            ListViewItem item1 = new ListViewItem(new string[] { ProdSigName.Text, SigToComp, ProdFuncBox.Checked.ToString(), "" });

            Signature sig = new Signature(ProdSigName.Text, SigToComp, MaskToComp, ProdFuncBox.Checked);
            sigEditListView.Items.Add(item1);
            tabcontrol.SelectedIndex = 0;
            ProdUpdate();
            //  if (materialCheckBox1.Checked) isscanning = true;
        }

        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {
            if (!readyToScan.Checked) return;
            RPM.OpenProcess(targetproc.Id);
            foreach (Signature sig in Signature.list)
            {
                sig.address = 0;
            }


                isscanning = true;


        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (isscanning)
            {
                ScanButton.Location = new Point(578, ScanButton.Location.Y);
                readyToScan.Location = new Point(549, readyToScan.Location.Y);
                ScanButton.Text = "Scanning";
            }
            else
            {
                ScanButton.Location = new Point(611, ScanButton.Location.Y);
                readyToScan.Location = new Point(568, readyToScan.Location.Y);
                ScanButton.Text = "Scan";
            }
            bool toen = false;
            Process[] processlist = Process.GetProcesses();
            for (int i = 0; i < processlist.Length; i++)
            {
                try
                {
                    if (processlist[i].ProcessName == ProcessBox.Text)
                    {
                        targetproc = processlist[i];
                        toen = true;
                        break;
                    }


                }
                catch (Exception) { }
            }
            materialCheckBox1.Checked = toen;
            ScanButton.Enabled = readyToScan.Checked = (sigEditListView.Items.Count > 0 && materialCheckBox1.Checked);


            foreach (Signature sig in Signature.list)
            {
                foreach (ListViewItem item in sigEditListView.Items)
                {
                    if (item.SubItems[0].Text == sig.name)
                    {
                        item.SubItems[3].Text = sig.address.ToString("X");
                        
                    }
                }
                if (sig.address != 0 && isscanning)
                {
                    materialProgressBar1.Value = (int)(((float)Signature.list.IndexOf(sig) /(float)Signature.list.Count)*100);
                }
                if (!isscanning)
                {
                    materialProgressBar1.Value = 0;
                }
            }

        }

        private void materialRaisedButton4_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in sigEditListView.SelectedItems)
            {
                int indexer = sigEditListView.Items.IndexOf(item);
                sigEditListView.Items.Remove(item);
                Signature.list.RemoveAt(indexer);
            }
        }
        public static bool isscanning = false;


        public void bgshit()
        {
            for (; ; )
            {
                if (isscanning)
                {
                    foreach (Signature sig in Signature.list)
                    {
                        List<byte> bytearra = new List<byte>();
                        string[] tmpstr = sig.data.Split(',');
                        foreach (string str in tmpstr)
                        {
                            string parsedstr = str.TrimStart(' ').TrimEnd(' ').Substring(2, 2);
                            bytearra.Add(byte.Parse(parsedstr, NumberStyles.HexNumber));
                        }
                        byte[] data = bytearra.ToArray();
                        foreach (byte b in data)
                        {
                            Console.WriteLine(b.ToString("X"));
                        }
                        sig.address = SigScanner.SigScan(data, sig.mask, sig.function);
                    }
                    isscanning = false;
                }
                Thread.Sleep(50);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
            Application.Exit();
        }

        private void materialRaisedButton3_Click_1(object sender, EventArgs e) // copy output
        {
            List<string> tocpy = new List<string>();
            foreach (Signature sig in Signature.list)
            {
                tocpy.Add("#define " + sig.name + " 0x" + sig.address.ToString("X"));
            }
            string[] strara = tocpy.ToArray();
            Clipboard.SetText(string.Join(Environment.NewLine, strara));

        }

        private void materialRaisedButton6_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "SigTool files |*.st";
            if (op.ShowDialog() == DialogResult.OK)
            {
                LoadFile(op.FileName);

            }
        }


        private void LoadFile(string fileloc)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(fileloc);

            XmlNodeList xml_process = xmlDoc.GetElementsByTagName("process");
            XmlNodeList xml_sig_name = xmlDoc.GetElementsByTagName("name");
            XmlNodeList xml_sig_data = xmlDoc.GetElementsByTagName("data");
            XmlNodeList xml_sig_mask = xmlDoc.GetElementsByTagName("mask");

            XmlNodeList xml_sig_function = xmlDoc.GetElementsByTagName("func");

            sigEditListView.Items.Clear();
            Signature.list.Clear();
            ProcessBox.Text = xml_process[0].InnerText;
            for (int i = 0; i < xml_sig_name.Count; i++)
            {
                string[] CodeSig = ConvertSig(SigStyle.Code, SigStyle.Byte, xml_sig_data[i].InnerText, xml_sig_mask[i].InnerText);
                ListViewItem item1 = new ListViewItem(new string[] { xml_sig_name[i].InnerText, CodeSig[0], xml_sig_function[i].InnerText, "" });
                Signature sig = new Signature(xml_sig_name[i].InnerText, CodeSig[0], CodeSig[1], bool.Parse(xml_sig_function[i].InnerText));
                sigEditListView.Items.Add(item1);
            }
        }


        private void materialRaisedButton5_Click(object sender, EventArgs e)
        {
            // save sigs

            XmlDocument doc = new XmlDocument();
            XmlElement root = doc.DocumentElement;

            XmlElement elem_SigScan = doc.CreateElement(string.Empty, "SigScan", string.Empty);
            doc.AppendChild(elem_SigScan);


            foreach (Signature sig in Signature.list)
            {
                XmlElement elem_sig = doc.CreateElement(string.Empty, "Sig", string.Empty);
                elem_SigScan.AppendChild(elem_sig);

                XmlElement elem_proc = doc.CreateElement(string.Empty, "process", string.Empty);
                XmlText elem_proc_text = doc.CreateTextNode(ProcessBox.Text);
                elem_proc.AppendChild(elem_proc_text);
                elem_SigScan.AppendChild(elem_proc);

                string[] sigshit = ConvertSig(SigStyle.Byte, SigStyle.Code, sig.data, sig.mask);

                XmlElement elem_name = doc.CreateElement(string.Empty, "name", string.Empty);
                XmlText elem_text_name = doc.CreateTextNode(sig.name);
                elem_name.AppendChild(elem_text_name);
                elem_sig.AppendChild(elem_name);

                XmlElement elem_data = doc.CreateElement(string.Empty, "data", string.Empty);
                XmlText elem_text_data = doc.CreateTextNode(sigshit[0]);
                elem_data.AppendChild(elem_text_data);
                elem_sig.AppendChild(elem_data);

                XmlElement elem_mask = doc.CreateElement(string.Empty, "mask", string.Empty);
                XmlText elem_text_mask = doc.CreateTextNode(sigshit[1]);
                elem_mask.AppendChild(elem_text_mask);
                elem_sig.AppendChild(elem_mask);

                XmlElement elem_func = doc.CreateElement(string.Empty, "func", string.Empty);
                XmlText elem_text_func = doc.CreateTextNode(sig.function.ToString());
                elem_func.AppendChild(elem_text_func);
                elem_sig.AppendChild(elem_func);

            }
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "SigTool Files |*.st";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                doc.Save(saveFileDialog.FileName);
            }

        }








    }





    public static class shit
    {
        [DllImport("kernel32.dll", SetLastError = true, CallingConvention = CallingConvention.Winapi)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsWow64Process([In] IntPtr process, [Out] out bool wow64Process);

        public static bool IsWin64Emulator(this Process process)
        {
            if ((Environment.OSVersion.Version.Major > 5)
                || ((Environment.OSVersion.Version.Major == 5) && (Environment.OSVersion.Version.Minor >= 1)))
            {
                bool retVal;

                return shit.IsWow64Process(process.Handle, out retVal) && retVal;
            }

            return false; // not on 64-bit Windows Emulator
        }
    }



    public class Signature
    {
        public static List<Signature> list = new List<Signature>();
        public string name;
        public string data;
        public string mask;
        public bool function;
        public long address;
        public Signature(string _name, string _data, string _mask, bool _function)
        {
            this.name = _name;
            this.data = _data;
            this.mask = _mask;
            this.function = _function;
            list.Add(this);
        }
    }
    
}

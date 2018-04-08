namespace SigTool
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabcontrol = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.materialRaisedButton6 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton5 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton4 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton3 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.readyToScan = new MaterialSkin.Controls.MaterialCheckBox();
            this.ScanButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.sigEditListView = new MaterialSkin.Controls.MaterialListView();
            this.materialCheckBox1 = new MaterialSkin.Controls.MaterialCheckBox();
            this.materialRaisedButton2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.ProcessBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.searchbox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.proclistview = new MaterialSkin.Controls.MaterialListView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.validsigbox = new MaterialSkin.Controls.MaterialCheckBox();
            this.ProdSigName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.savesigbutton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.ProdFuncBox = new MaterialSkin.Controls.MaterialCheckBox();
            this.ProdUnknown = new MaterialSkin.Controls.MaterialRadioButton();
            this.ProdAutoDetect = new MaterialSkin.Controls.MaterialCheckBox();
            this.ProdRadio_Byte = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.ProdRadio_PEiD = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.ProdRadio_IDA = new MaterialSkin.Controls.MaterialRadioButton();
            this.ProdData = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.ProdRadio_Code = new MaterialSkin.Controls.MaterialRadioButton();
            this.ProdMask = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PostRadio_Byte = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.PostRadio_PEiD = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.PostRadio_IDA = new MaterialSkin.Controls.MaterialRadioButton();
            this.PostData = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.PostRadio_Code = new MaterialSkin.Controls.MaterialRadioButton();
            this.PostMask = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PreUnknown = new MaterialSkin.Controls.MaterialRadioButton();
            this.PreCheck_Auto = new MaterialSkin.Controls.MaterialCheckBox();
            this.PreRadio_Byte = new MaterialSkin.Controls.MaterialRadioButton();
            this.PreMaskLabel = new MaterialSkin.Controls.MaterialLabel();
            this.PreRadio_PEiD = new MaterialSkin.Controls.MaterialRadioButton();
            this.PreDataLabel = new MaterialSkin.Controls.MaterialLabel();
            this.PreRadio_IDA = new MaterialSkin.Controls.MaterialRadioButton();
            this.PreData = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.PreRadio_Code = new MaterialSkin.Controls.MaterialRadioButton();
            this.PreMask = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialProgressBar1 = new MaterialSkin.Controls.MaterialProgressBar();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabcontrol.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabcontrol
            // 
            this.tabcontrol.Controls.Add(this.tabPage1);
            this.tabcontrol.Controls.Add(this.tabPage2);
            this.tabcontrol.Controls.Add(this.tabPage3);
            this.tabcontrol.Controls.Add(this.tabPage4);
            this.tabcontrol.Depth = 0;
            this.tabcontrol.Location = new System.Drawing.Point(12, 116);
            this.tabcontrol.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabcontrol.Name = "tabcontrol";
            this.tabcontrol.SelectedIndex = 0;
            this.tabcontrol.Size = new System.Drawing.Size(682, 383);
            this.tabcontrol.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.tabPage1.Controls.Add(this.materialRaisedButton6);
            this.tabPage1.Controls.Add(this.materialRaisedButton5);
            this.tabPage1.Controls.Add(this.materialRaisedButton4);
            this.tabPage1.Controls.Add(this.materialRaisedButton3);
            this.tabPage1.Controls.Add(this.readyToScan);
            this.tabPage1.Controls.Add(this.ScanButton);
            this.tabPage1.Controls.Add(this.sigEditListView);
            this.tabPage1.Controls.Add(this.materialCheckBox1);
            this.tabPage1.Controls.Add(this.materialRaisedButton2);
            this.tabPage1.Controls.Add(this.ProcessBox);
            this.tabPage1.Controls.Add(this.materialLabel9);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(674, 357);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Scanner";
            // 
            // materialRaisedButton6
            // 
            this.materialRaisedButton6.AutoSize = true;
            this.materialRaisedButton6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton6.Depth = 0;
            this.materialRaisedButton6.Icon = null;
            this.materialRaisedButton6.Location = new System.Drawing.Point(579, 171);
            this.materialRaisedButton6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton6.Name = "materialRaisedButton6";
            this.materialRaisedButton6.Primary = true;
            this.materialRaisedButton6.Size = new System.Drawing.Size(89, 36);
            this.materialRaisedButton6.TabIndex = 17;
            this.materialRaisedButton6.Text = "Load Sigs";
            this.materialRaisedButton6.UseVisualStyleBackColor = true;
            this.materialRaisedButton6.Click += new System.EventHandler(this.materialRaisedButton6_Click);
            // 
            // materialRaisedButton5
            // 
            this.materialRaisedButton5.AutoSize = true;
            this.materialRaisedButton5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton5.Depth = 0;
            this.materialRaisedButton5.Icon = null;
            this.materialRaisedButton5.Location = new System.Drawing.Point(580, 129);
            this.materialRaisedButton5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton5.Name = "materialRaisedButton5";
            this.materialRaisedButton5.Primary = true;
            this.materialRaisedButton5.Size = new System.Drawing.Size(88, 36);
            this.materialRaisedButton5.TabIndex = 16;
            this.materialRaisedButton5.Text = "Save Sigs";
            this.materialRaisedButton5.UseVisualStyleBackColor = true;
            this.materialRaisedButton5.Click += new System.EventHandler(this.materialRaisedButton5_Click);
            // 
            // materialRaisedButton4
            // 
            this.materialRaisedButton4.AutoSize = true;
            this.materialRaisedButton4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton4.Depth = 0;
            this.materialRaisedButton4.Icon = null;
            this.materialRaisedButton4.Location = new System.Drawing.Point(599, 279);
            this.materialRaisedButton4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton4.Name = "materialRaisedButton4";
            this.materialRaisedButton4.Primary = true;
            this.materialRaisedButton4.Size = new System.Drawing.Size(69, 36);
            this.materialRaisedButton4.TabIndex = 15;
            this.materialRaisedButton4.Text = "Delete";
            this.materialRaisedButton4.UseVisualStyleBackColor = true;
            this.materialRaisedButton4.Click += new System.EventHandler(this.materialRaisedButton4_Click);
            // 
            // materialRaisedButton3
            // 
            this.materialRaisedButton3.AutoSize = true;
            this.materialRaisedButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton3.Depth = 0;
            this.materialRaisedButton3.Icon = null;
            this.materialRaisedButton3.Location = new System.Drawing.Point(555, 321);
            this.materialRaisedButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton3.Name = "materialRaisedButton3";
            this.materialRaisedButton3.Primary = true;
            this.materialRaisedButton3.Size = new System.Drawing.Size(113, 36);
            this.materialRaisedButton3.TabIndex = 14;
            this.materialRaisedButton3.Text = "Copy Output";
            this.materialRaisedButton3.UseVisualStyleBackColor = true;
            this.materialRaisedButton3.Click += new System.EventHandler(this.materialRaisedButton3_Click_1);
            // 
            // readyToScan
            // 
            this.readyToScan.AutoCheck = false;
            this.readyToScan.AutoSize = true;
            this.readyToScan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(234)))), ((int)(((byte)(253)))));
            this.readyToScan.Depth = 0;
            this.readyToScan.Font = new System.Drawing.Font("Roboto", 10F);
            this.readyToScan.Location = new System.Drawing.Point(568, 49);
            this.readyToScan.Margin = new System.Windows.Forms.Padding(0);
            this.readyToScan.MouseLocation = new System.Drawing.Point(-1, -1);
            this.readyToScan.MouseState = MaterialSkin.MouseState.HOVER;
            this.readyToScan.Name = "readyToScan";
            this.readyToScan.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.readyToScan.Ripple = true;
            this.readyToScan.Size = new System.Drawing.Size(26, 30);
            this.readyToScan.TabIndex = 13;
            this.readyToScan.UseVisualStyleBackColor = false;
            // 
            // ScanButton
            // 
            this.ScanButton.AutoSize = true;
            this.ScanButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ScanButton.Depth = 0;
            this.ScanButton.Icon = null;
            this.ScanButton.Location = new System.Drawing.Point(611, 45);
            this.ScanButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.ScanButton.Name = "ScanButton";
            this.ScanButton.Primary = true;
            this.ScanButton.Size = new System.Drawing.Size(57, 36);
            this.ScanButton.TabIndex = 12;
            this.ScanButton.Text = "Scan";
            this.ScanButton.UseVisualStyleBackColor = true;
            this.ScanButton.Click += new System.EventHandler(this.materialRaisedButton3_Click);
            // 
            // sigEditListView
            // 
            this.sigEditListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sigEditListView.Depth = 0;
            this.sigEditListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.sigEditListView.FullRowSelect = true;
            this.sigEditListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.sigEditListView.Location = new System.Drawing.Point(7, 49);
            this.sigEditListView.MouseLocation = new System.Drawing.Point(-1, -1);
            this.sigEditListView.MouseState = MaterialSkin.MouseState.OUT;
            this.sigEditListView.Name = "sigEditListView";
            this.sigEditListView.OwnerDraw = true;
            this.sigEditListView.Size = new System.Drawing.Size(537, 301);
            this.sigEditListView.TabIndex = 11;
            this.sigEditListView.UseCompatibleStateImageBehavior = false;
            this.sigEditListView.View = System.Windows.Forms.View.Details;
            // 
            // materialCheckBox1
            // 
            this.materialCheckBox1.AutoCheck = false;
            this.materialCheckBox1.AutoSize = true;
            this.materialCheckBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(234)))), ((int)(((byte)(253)))));
            this.materialCheckBox1.Depth = 0;
            this.materialCheckBox1.Font = new System.Drawing.Font("Roboto", 10F);
            this.materialCheckBox1.Location = new System.Drawing.Point(568, 7);
            this.materialCheckBox1.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckBox1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckBox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckBox1.Name = "materialCheckBox1";
            this.materialCheckBox1.Ripple = true;
            this.materialCheckBox1.Size = new System.Drawing.Size(26, 30);
            this.materialCheckBox1.TabIndex = 3;
            this.materialCheckBox1.UseVisualStyleBackColor = false;
            // 
            // materialRaisedButton2
            // 
            this.materialRaisedButton2.AutoSize = true;
            this.materialRaisedButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton2.Depth = 0;
            this.materialRaisedButton2.Icon = null;
            this.materialRaisedButton2.Location = new System.Drawing.Point(599, 3);
            this.materialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton2.Name = "materialRaisedButton2";
            this.materialRaisedButton2.Primary = true;
            this.materialRaisedButton2.Size = new System.Drawing.Size(69, 36);
            this.materialRaisedButton2.TabIndex = 2;
            this.materialRaisedButton2.Text = "Select";
            this.materialRaisedButton2.UseVisualStyleBackColor = true;
            this.materialRaisedButton2.Click += new System.EventHandler(this.materialRaisedButton2_Click);
            // 
            // ProcessBox
            // 
            this.ProcessBox.Depth = 0;
            this.ProcessBox.Hint = "";
            this.ProcessBox.Location = new System.Drawing.Point(81, 10);
            this.ProcessBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.ProcessBox.MultiLine = false;
            this.ProcessBox.Name = "ProcessBox";
            this.ProcessBox.PasswordChar = '\0';
            this.ProcessBox.SelectedText = "";
            this.ProcessBox.SelectionLength = 0;
            this.ProcessBox.SelectionStart = 0;
            this.ProcessBox.Size = new System.Drawing.Size(484, 23);
            this.ProcessBox.TabIndex = 1;
            this.ProcessBox.TabStop = false;
            this.ProcessBox.Text = "process";
            this.ProcessBox.UseSystemPasswordChar = false;
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel9.Location = new System.Drawing.Point(3, 11);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(68, 19);
            this.materialLabel9.TabIndex = 0;
            this.materialLabel9.Text = "Process:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.tabPage2.Controls.Add(this.materialLabel2);
            this.tabPage2.Controls.Add(this.searchbox);
            this.tabPage2.Controls.Add(this.materialRaisedButton1);
            this.tabPage2.Controls.Add(this.proclistview);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(674, 357);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Process";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(6, 23);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(59, 19);
            this.materialLabel2.TabIndex = 3;
            this.materialLabel2.Text = "Search:";
            // 
            // searchbox
            // 
            this.searchbox.Depth = 0;
            this.searchbox.Hint = "";
            this.searchbox.Location = new System.Drawing.Point(96, 19);
            this.searchbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.searchbox.MultiLine = false;
            this.searchbox.Name = "searchbox";
            this.searchbox.PasswordChar = '\0';
            this.searchbox.SelectedText = "";
            this.searchbox.SelectionLength = 0;
            this.searchbox.SelectionStart = 0;
            this.searchbox.Size = new System.Drawing.Size(485, 23);
            this.searchbox.TabIndex = 2;
            this.searchbox.TabStop = false;
            this.searchbox.UseSystemPasswordChar = false;
            this.searchbox.TextChanged += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.AutoSize = true;
            this.materialRaisedButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Icon = null;
            this.materialRaisedButton1.Location = new System.Drawing.Point(587, 7);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(79, 36);
            this.materialRaisedButton1.TabIndex = 1;
            this.materialRaisedButton1.Text = "Refresh";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // proclistview
            // 
            this.proclistview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.proclistview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.proclistview.CheckBoxes = true;
            this.proclistview.Depth = 0;
            this.proclistview.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.proclistview.FullRowSelect = true;
            this.proclistview.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.proclistview.Location = new System.Drawing.Point(7, 49);
            this.proclistview.MouseLocation = new System.Drawing.Point(-1, -1);
            this.proclistview.MouseState = MaterialSkin.MouseState.OUT;
            this.proclistview.Name = "proclistview";
            this.proclistview.OwnerDraw = true;
            this.proclistview.Size = new System.Drawing.Size(659, 291);
            this.proclistview.TabIndex = 0;
            this.proclistview.UseCompatibleStateImageBehavior = false;
            this.proclistview.View = System.Windows.Forms.View.Details;
            this.proclistview.ItemActivate += new System.EventHandler(this.proclistview_ItemActivate);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.tabPage3.Controls.Add(this.panel3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(674, 357);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Sigs";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.validsigbox);
            this.panel3.Controls.Add(this.ProdSigName);
            this.panel3.Controls.Add(this.savesigbutton);
            this.panel3.Controls.Add(this.ProdFuncBox);
            this.panel3.Controls.Add(this.ProdUnknown);
            this.panel3.Controls.Add(this.ProdAutoDetect);
            this.panel3.Controls.Add(this.ProdRadio_Byte);
            this.panel3.Controls.Add(this.materialLabel3);
            this.panel3.Controls.Add(this.ProdRadio_PEiD);
            this.panel3.Controls.Add(this.materialLabel8);
            this.panel3.Controls.Add(this.ProdRadio_IDA);
            this.panel3.Controls.Add(this.ProdData);
            this.panel3.Controls.Add(this.ProdRadio_Code);
            this.panel3.Controls.Add(this.ProdMask);
            this.panel3.Location = new System.Drawing.Point(6, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(647, 197);
            this.panel3.TabIndex = 9;
            // 
            // validsigbox
            // 
            this.validsigbox.AutoCheck = false;
            this.validsigbox.AutoSize = true;
            this.validsigbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(234)))), ((int)(((byte)(253)))));
            this.validsigbox.Depth = 0;
            this.validsigbox.Font = new System.Drawing.Font("Roboto", 10F);
            this.validsigbox.Location = new System.Drawing.Point(483, 157);
            this.validsigbox.Margin = new System.Windows.Forms.Padding(0);
            this.validsigbox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.validsigbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.validsigbox.Name = "validsigbox";
            this.validsigbox.Ripple = true;
            this.validsigbox.Size = new System.Drawing.Size(26, 30);
            this.validsigbox.TabIndex = 12;
            this.validsigbox.UseVisualStyleBackColor = false;
            // 
            // ProdSigName
            // 
            this.ProdSigName.Depth = 0;
            this.ProdSigName.Hint = "";
            this.ProdSigName.Location = new System.Drawing.Point(7, 163);
            this.ProdSigName.MouseState = MaterialSkin.MouseState.HOVER;
            this.ProdSigName.MultiLine = false;
            this.ProdSigName.Name = "ProdSigName";
            this.ProdSigName.PasswordChar = '\0';
            this.ProdSigName.SelectedText = "";
            this.ProdSigName.SelectionLength = 0;
            this.ProdSigName.SelectionStart = 0;
            this.ProdSigName.Size = new System.Drawing.Size(473, 23);
            this.ProdSigName.TabIndex = 11;
            this.ProdSigName.TabStop = false;
            this.ProdSigName.Text = "OFFSET_RENAMEME";
            this.ProdSigName.UseSystemPasswordChar = false;
            this.ProdSigName.TextChanged += new System.EventHandler(this.ProdRadio_Code_CheckedChanged);
            // 
            // savesigbutton
            // 
            this.savesigbutton.AutoSize = true;
            this.savesigbutton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.savesigbutton.Depth = 0;
            this.savesigbutton.Icon = null;
            this.savesigbutton.Location = new System.Drawing.Point(512, 153);
            this.savesigbutton.MouseState = MaterialSkin.MouseState.HOVER;
            this.savesigbutton.Name = "savesigbutton";
            this.savesigbutton.Primary = true;
            this.savesigbutton.Size = new System.Drawing.Size(132, 36);
            this.savesigbutton.TabIndex = 10;
            this.savesigbutton.Text = "Save Signature";
            this.savesigbutton.UseVisualStyleBackColor = true;
            this.savesigbutton.Click += new System.EventHandler(this.savesigbutton_Click);
            // 
            // ProdFuncBox
            // 
            this.ProdFuncBox.AutoSize = true;
            this.ProdFuncBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(234)))), ((int)(((byte)(253)))));
            this.ProdFuncBox.Depth = 0;
            this.ProdFuncBox.Font = new System.Drawing.Font("Roboto", 10F);
            this.ProdFuncBox.Location = new System.Drawing.Point(7, 130);
            this.ProdFuncBox.Margin = new System.Windows.Forms.Padding(0);
            this.ProdFuncBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ProdFuncBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.ProdFuncBox.Name = "ProdFuncBox";
            this.ProdFuncBox.Ripple = true;
            this.ProdFuncBox.Size = new System.Drawing.Size(109, 30);
            this.ProdFuncBox.TabIndex = 9;
            this.ProdFuncBox.Text = "Is a Function";
            this.ProdFuncBox.UseVisualStyleBackColor = false;
            this.ProdFuncBox.CheckedChanged += new System.EventHandler(this.ProdRadio_Code_CheckedChanged);
            // 
            // ProdUnknown
            // 
            this.ProdUnknown.AutoCheck = false;
            this.ProdUnknown.AutoSize = true;
            this.ProdUnknown.Depth = 0;
            this.ProdUnknown.Font = new System.Drawing.Font("Roboto", 10F);
            this.ProdUnknown.Location = new System.Drawing.Point(414, 99);
            this.ProdUnknown.Margin = new System.Windows.Forms.Padding(0);
            this.ProdUnknown.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ProdUnknown.MouseState = MaterialSkin.MouseState.HOVER;
            this.ProdUnknown.Name = "ProdUnknown";
            this.ProdUnknown.Ripple = true;
            this.ProdUnknown.Size = new System.Drawing.Size(86, 30);
            this.ProdUnknown.TabIndex = 8;
            this.ProdUnknown.TabStop = true;
            this.ProdUnknown.Text = "Unknown";
            this.ProdUnknown.UseVisualStyleBackColor = true;
            this.ProdUnknown.CheckedChanged += new System.EventHandler(this.ProdRadio_Code_CheckedChanged);
            // 
            // ProdAutoDetect
            // 
            this.ProdAutoDetect.AutoSize = true;
            this.ProdAutoDetect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(234)))), ((int)(((byte)(253)))));
            this.ProdAutoDetect.Checked = true;
            this.ProdAutoDetect.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ProdAutoDetect.Depth = 0;
            this.ProdAutoDetect.Font = new System.Drawing.Font("Roboto", 10F);
            this.ProdAutoDetect.Location = new System.Drawing.Point(7, 100);
            this.ProdAutoDetect.Margin = new System.Windows.Forms.Padding(0);
            this.ProdAutoDetect.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ProdAutoDetect.MouseState = MaterialSkin.MouseState.HOVER;
            this.ProdAutoDetect.Name = "ProdAutoDetect";
            this.ProdAutoDetect.Ripple = true;
            this.ProdAutoDetect.Size = new System.Drawing.Size(104, 30);
            this.ProdAutoDetect.TabIndex = 3;
            this.ProdAutoDetect.Text = "Auto-Detect";
            this.ProdAutoDetect.UseVisualStyleBackColor = false;
            this.ProdAutoDetect.CheckedChanged += new System.EventHandler(this.ProdRadio_Code_CheckedChanged);
            // 
            // ProdRadio_Byte
            // 
            this.ProdRadio_Byte.AutoSize = true;
            this.ProdRadio_Byte.Depth = 0;
            this.ProdRadio_Byte.Font = new System.Drawing.Font("Roboto", 10F);
            this.ProdRadio_Byte.Location = new System.Drawing.Point(316, 99);
            this.ProdRadio_Byte.Margin = new System.Windows.Forms.Padding(0);
            this.ProdRadio_Byte.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ProdRadio_Byte.MouseState = MaterialSkin.MouseState.HOVER;
            this.ProdRadio_Byte.Name = "ProdRadio_Byte";
            this.ProdRadio_Byte.Ripple = true;
            this.ProdRadio_Byte.Size = new System.Drawing.Size(93, 30);
            this.ProdRadio_Byte.TabIndex = 7;
            this.ProdRadio_Byte.TabStop = true;
            this.ProdRadio_Byte.Text = "Byte Array";
            this.ProdRadio_Byte.UseVisualStyleBackColor = true;
            this.ProdRadio_Byte.CheckedChanged += new System.EventHandler(this.ProdRadio_Code_CheckedChanged);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(3, 52);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(46, 19);
            this.materialLabel3.TabIndex = 2;
            this.materialLabel3.Text = "Mask";
            // 
            // ProdRadio_PEiD
            // 
            this.ProdRadio_PEiD.AutoSize = true;
            this.ProdRadio_PEiD.Depth = 0;
            this.ProdRadio_PEiD.Font = new System.Drawing.Font("Roboto", 10F);
            this.ProdRadio_PEiD.Location = new System.Drawing.Point(248, 99);
            this.ProdRadio_PEiD.Margin = new System.Windows.Forms.Padding(0);
            this.ProdRadio_PEiD.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ProdRadio_PEiD.MouseState = MaterialSkin.MouseState.HOVER;
            this.ProdRadio_PEiD.Name = "ProdRadio_PEiD";
            this.ProdRadio_PEiD.Ripple = true;
            this.ProdRadio_PEiD.Size = new System.Drawing.Size(58, 30);
            this.ProdRadio_PEiD.TabIndex = 6;
            this.ProdRadio_PEiD.TabStop = true;
            this.ProdRadio_PEiD.Text = "PEiD";
            this.ProdRadio_PEiD.UseVisualStyleBackColor = true;
            this.ProdRadio_PEiD.CheckedChanged += new System.EventHandler(this.ProdRadio_Code_CheckedChanged);
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(3, 4);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(40, 19);
            this.materialLabel8.TabIndex = 1;
            this.materialLabel8.Text = "Data";
            // 
            // ProdRadio_IDA
            // 
            this.ProdRadio_IDA.AutoSize = true;
            this.ProdRadio_IDA.Depth = 0;
            this.ProdRadio_IDA.Font = new System.Drawing.Font("Roboto", 10F);
            this.ProdRadio_IDA.Location = new System.Drawing.Point(187, 99);
            this.ProdRadio_IDA.Margin = new System.Windows.Forms.Padding(0);
            this.ProdRadio_IDA.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ProdRadio_IDA.MouseState = MaterialSkin.MouseState.HOVER;
            this.ProdRadio_IDA.Name = "ProdRadio_IDA";
            this.ProdRadio_IDA.Ripple = true;
            this.ProdRadio_IDA.Size = new System.Drawing.Size(51, 30);
            this.ProdRadio_IDA.TabIndex = 5;
            this.ProdRadio_IDA.TabStop = true;
            this.ProdRadio_IDA.Text = "IDA";
            this.ProdRadio_IDA.UseVisualStyleBackColor = true;
            this.ProdRadio_IDA.CheckedChanged += new System.EventHandler(this.ProdRadio_Code_CheckedChanged);
            // 
            // ProdData
            // 
            this.ProdData.Depth = 0;
            this.ProdData.Hint = "";
            this.ProdData.Location = new System.Drawing.Point(7, 26);
            this.ProdData.MouseState = MaterialSkin.MouseState.HOVER;
            this.ProdData.MultiLine = false;
            this.ProdData.Name = "ProdData";
            this.ProdData.PasswordChar = '\0';
            this.ProdData.SelectedText = "";
            this.ProdData.SelectionLength = 0;
            this.ProdData.SelectionStart = 0;
            this.ProdData.Size = new System.Drawing.Size(637, 23);
            this.ProdData.TabIndex = 0;
            this.ProdData.TabStop = false;
            this.ProdData.Text = "48 89 15 ?? ?? ?? ?? 48 89 cb";
            this.ProdData.UseSystemPasswordChar = false;
            this.ProdData.TextChanged += new System.EventHandler(this.ProdRadio_Code_CheckedChanged);
            // 
            // ProdRadio_Code
            // 
            this.ProdRadio_Code.AutoSize = true;
            this.ProdRadio_Code.Depth = 0;
            this.ProdRadio_Code.Font = new System.Drawing.Font("Roboto", 10F);
            this.ProdRadio_Code.Location = new System.Drawing.Point(116, 99);
            this.ProdRadio_Code.Margin = new System.Windows.Forms.Padding(0);
            this.ProdRadio_Code.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ProdRadio_Code.MouseState = MaterialSkin.MouseState.HOVER;
            this.ProdRadio_Code.Name = "ProdRadio_Code";
            this.ProdRadio_Code.Ripple = true;
            this.ProdRadio_Code.Size = new System.Drawing.Size(61, 30);
            this.ProdRadio_Code.TabIndex = 4;
            this.ProdRadio_Code.TabStop = true;
            this.ProdRadio_Code.Text = "Code";
            this.ProdRadio_Code.UseVisualStyleBackColor = true;
            this.ProdRadio_Code.CheckedChanged += new System.EventHandler(this.ProdRadio_Code_CheckedChanged);
            // 
            // ProdMask
            // 
            this.ProdMask.Depth = 0;
            this.ProdMask.Hint = "";
            this.ProdMask.Location = new System.Drawing.Point(7, 74);
            this.ProdMask.MouseState = MaterialSkin.MouseState.HOVER;
            this.ProdMask.MultiLine = false;
            this.ProdMask.Name = "ProdMask";
            this.ProdMask.PasswordChar = '\0';
            this.ProdMask.SelectedText = "";
            this.ProdMask.SelectionLength = 0;
            this.ProdMask.SelectionStart = 0;
            this.ProdMask.Size = new System.Drawing.Size(637, 23);
            this.ProdMask.TabIndex = 2;
            this.ProdMask.TabStop = false;
            this.ProdMask.Text = "xx??x";
            this.ProdMask.UseSystemPasswordChar = false;
            this.ProdMask.TextChanged += new System.EventHandler(this.ProdRadio_Code_CheckedChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.tabPage4.Controls.Add(this.materialLabel7);
            this.tabPage4.Controls.Add(this.panel2);
            this.tabPage4.Controls.Add(this.materialLabel4);
            this.tabPage4.Controls.Add(this.panel1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(674, 357);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Converter";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(6, 171);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(46, 19);
            this.materialLabel7.TabIndex = 10;
            this.materialLabel7.Text = "After:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.PostRadio_Byte);
            this.panel2.Controls.Add(this.materialLabel5);
            this.panel2.Controls.Add(this.PostRadio_PEiD);
            this.panel2.Controls.Add(this.materialLabel6);
            this.panel2.Controls.Add(this.PostRadio_IDA);
            this.panel2.Controls.Add(this.PostData);
            this.panel2.Controls.Add(this.PostRadio_Code);
            this.panel2.Controls.Add(this.PostMask);
            this.panel2.Location = new System.Drawing.Point(10, 197);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(647, 143);
            this.panel2.TabIndex = 9;
            // 
            // PostRadio_Byte
            // 
            this.PostRadio_Byte.AutoSize = true;
            this.PostRadio_Byte.Depth = 0;
            this.PostRadio_Byte.Font = new System.Drawing.Font("Roboto", 10F);
            this.PostRadio_Byte.Location = new System.Drawing.Point(207, 100);
            this.PostRadio_Byte.Margin = new System.Windows.Forms.Padding(0);
            this.PostRadio_Byte.MouseLocation = new System.Drawing.Point(-1, -1);
            this.PostRadio_Byte.MouseState = MaterialSkin.MouseState.HOVER;
            this.PostRadio_Byte.Name = "PostRadio_Byte";
            this.PostRadio_Byte.Ripple = true;
            this.PostRadio_Byte.Size = new System.Drawing.Size(93, 30);
            this.PostRadio_Byte.TabIndex = 7;
            this.PostRadio_Byte.Text = "Byte Array";
            this.PostRadio_Byte.UseVisualStyleBackColor = true;
            this.PostRadio_Byte.CheckedChanged += new System.EventHandler(this.PostRadio_Code_CheckedChanged);
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(3, 52);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(46, 19);
            this.materialLabel5.TabIndex = 2;
            this.materialLabel5.Text = "Mask";
            // 
            // PostRadio_PEiD
            // 
            this.PostRadio_PEiD.AutoSize = true;
            this.PostRadio_PEiD.Depth = 0;
            this.PostRadio_PEiD.Font = new System.Drawing.Font("Roboto", 10F);
            this.PostRadio_PEiD.Location = new System.Drawing.Point(139, 100);
            this.PostRadio_PEiD.Margin = new System.Windows.Forms.Padding(0);
            this.PostRadio_PEiD.MouseLocation = new System.Drawing.Point(-1, -1);
            this.PostRadio_PEiD.MouseState = MaterialSkin.MouseState.HOVER;
            this.PostRadio_PEiD.Name = "PostRadio_PEiD";
            this.PostRadio_PEiD.Ripple = true;
            this.PostRadio_PEiD.Size = new System.Drawing.Size(58, 30);
            this.PostRadio_PEiD.TabIndex = 6;
            this.PostRadio_PEiD.Text = "PEiD";
            this.PostRadio_PEiD.UseVisualStyleBackColor = true;
            this.PostRadio_PEiD.CheckedChanged += new System.EventHandler(this.PostRadio_Code_CheckedChanged);
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(3, 4);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(40, 19);
            this.materialLabel6.TabIndex = 1;
            this.materialLabel6.Text = "Data";
            // 
            // PostRadio_IDA
            // 
            this.PostRadio_IDA.AutoSize = true;
            this.PostRadio_IDA.Depth = 0;
            this.PostRadio_IDA.Font = new System.Drawing.Font("Roboto", 10F);
            this.PostRadio_IDA.Location = new System.Drawing.Point(78, 101);
            this.PostRadio_IDA.Margin = new System.Windows.Forms.Padding(0);
            this.PostRadio_IDA.MouseLocation = new System.Drawing.Point(-1, -1);
            this.PostRadio_IDA.MouseState = MaterialSkin.MouseState.HOVER;
            this.PostRadio_IDA.Name = "PostRadio_IDA";
            this.PostRadio_IDA.Ripple = true;
            this.PostRadio_IDA.Size = new System.Drawing.Size(51, 30);
            this.PostRadio_IDA.TabIndex = 5;
            this.PostRadio_IDA.Text = "IDA";
            this.PostRadio_IDA.UseVisualStyleBackColor = true;
            this.PostRadio_IDA.CheckedChanged += new System.EventHandler(this.PostRadio_Code_CheckedChanged);
            // 
            // PostData
            // 
            this.PostData.Depth = 0;
            this.PostData.Hint = "";
            this.PostData.Location = new System.Drawing.Point(7, 26);
            this.PostData.MouseState = MaterialSkin.MouseState.HOVER;
            this.PostData.MultiLine = false;
            this.PostData.Name = "PostData";
            this.PostData.PasswordChar = '\0';
            this.PostData.SelectedText = "";
            this.PostData.SelectionLength = 0;
            this.PostData.SelectionStart = 0;
            this.PostData.Size = new System.Drawing.Size(637, 23);
            this.PostData.TabIndex = 0;
            this.PostData.TabStop = false;
            this.PostData.Text = "\\x90\\x90\\x00\\x00\\x90";
            this.PostData.UseSystemPasswordChar = false;
            // 
            // PostRadio_Code
            // 
            this.PostRadio_Code.AutoSize = true;
            this.PostRadio_Code.Checked = true;
            this.PostRadio_Code.Depth = 0;
            this.PostRadio_Code.Font = new System.Drawing.Font("Roboto", 10F);
            this.PostRadio_Code.Location = new System.Drawing.Point(7, 100);
            this.PostRadio_Code.Margin = new System.Windows.Forms.Padding(0);
            this.PostRadio_Code.MouseLocation = new System.Drawing.Point(-1, -1);
            this.PostRadio_Code.MouseState = MaterialSkin.MouseState.HOVER;
            this.PostRadio_Code.Name = "PostRadio_Code";
            this.PostRadio_Code.Ripple = true;
            this.PostRadio_Code.Size = new System.Drawing.Size(61, 30);
            this.PostRadio_Code.TabIndex = 4;
            this.PostRadio_Code.TabStop = true;
            this.PostRadio_Code.Text = "Code";
            this.PostRadio_Code.UseVisualStyleBackColor = true;
            this.PostRadio_Code.CheckedChanged += new System.EventHandler(this.PostRadio_Code_CheckedChanged);
            // 
            // PostMask
            // 
            this.PostMask.Depth = 0;
            this.PostMask.Hint = "";
            this.PostMask.Location = new System.Drawing.Point(7, 74);
            this.PostMask.MouseState = MaterialSkin.MouseState.HOVER;
            this.PostMask.MultiLine = false;
            this.PostMask.Name = "PostMask";
            this.PostMask.PasswordChar = '\0';
            this.PostMask.SelectedText = "";
            this.PostMask.SelectionLength = 0;
            this.PostMask.SelectionStart = 0;
            this.PostMask.Size = new System.Drawing.Size(637, 23);
            this.PostMask.TabIndex = 2;
            this.PostMask.TabStop = false;
            this.PostMask.Text = "xx??x";
            this.PostMask.UseSystemPasswordChar = false;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(6, 3);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(57, 19);
            this.materialLabel4.TabIndex = 9;
            this.materialLabel4.Text = "Before:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PreUnknown);
            this.panel1.Controls.Add(this.PreCheck_Auto);
            this.panel1.Controls.Add(this.PreRadio_Byte);
            this.panel1.Controls.Add(this.PreMaskLabel);
            this.panel1.Controls.Add(this.PreRadio_PEiD);
            this.panel1.Controls.Add(this.PreDataLabel);
            this.panel1.Controls.Add(this.PreRadio_IDA);
            this.panel1.Controls.Add(this.PreData);
            this.panel1.Controls.Add(this.PreRadio_Code);
            this.panel1.Controls.Add(this.PreMask);
            this.panel1.Location = new System.Drawing.Point(10, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(647, 143);
            this.panel1.TabIndex = 8;
            // 
            // PreUnknown
            // 
            this.PreUnknown.AutoCheck = false;
            this.PreUnknown.AutoSize = true;
            this.PreUnknown.Depth = 0;
            this.PreUnknown.Font = new System.Drawing.Font("Roboto", 10F);
            this.PreUnknown.Location = new System.Drawing.Point(414, 99);
            this.PreUnknown.Margin = new System.Windows.Forms.Padding(0);
            this.PreUnknown.MouseLocation = new System.Drawing.Point(-1, -1);
            this.PreUnknown.MouseState = MaterialSkin.MouseState.HOVER;
            this.PreUnknown.Name = "PreUnknown";
            this.PreUnknown.Ripple = true;
            this.PreUnknown.Size = new System.Drawing.Size(86, 30);
            this.PreUnknown.TabIndex = 8;
            this.PreUnknown.TabStop = true;
            this.PreUnknown.Text = "Unknown";
            this.PreUnknown.UseVisualStyleBackColor = true;
            // 
            // PreCheck_Auto
            // 
            this.PreCheck_Auto.AutoSize = true;
            this.PreCheck_Auto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(234)))), ((int)(((byte)(253)))));
            this.PreCheck_Auto.Checked = true;
            this.PreCheck_Auto.CheckState = System.Windows.Forms.CheckState.Checked;
            this.PreCheck_Auto.Depth = 0;
            this.PreCheck_Auto.Font = new System.Drawing.Font("Roboto", 10F);
            this.PreCheck_Auto.Location = new System.Drawing.Point(7, 100);
            this.PreCheck_Auto.Margin = new System.Windows.Forms.Padding(0);
            this.PreCheck_Auto.MouseLocation = new System.Drawing.Point(-1, -1);
            this.PreCheck_Auto.MouseState = MaterialSkin.MouseState.HOVER;
            this.PreCheck_Auto.Name = "PreCheck_Auto";
            this.PreCheck_Auto.Ripple = true;
            this.PreCheck_Auto.Size = new System.Drawing.Size(104, 30);
            this.PreCheck_Auto.TabIndex = 3;
            this.PreCheck_Auto.Text = "Auto-Detect";
            this.PreCheck_Auto.UseVisualStyleBackColor = false;
            this.PreCheck_Auto.CheckedChanged += new System.EventHandler(this.PreRadio_Code_CheckedChanged);
            // 
            // PreRadio_Byte
            // 
            this.PreRadio_Byte.AutoSize = true;
            this.PreRadio_Byte.Depth = 0;
            this.PreRadio_Byte.Font = new System.Drawing.Font("Roboto", 10F);
            this.PreRadio_Byte.Location = new System.Drawing.Point(316, 99);
            this.PreRadio_Byte.Margin = new System.Windows.Forms.Padding(0);
            this.PreRadio_Byte.MouseLocation = new System.Drawing.Point(-1, -1);
            this.PreRadio_Byte.MouseState = MaterialSkin.MouseState.HOVER;
            this.PreRadio_Byte.Name = "PreRadio_Byte";
            this.PreRadio_Byte.Ripple = true;
            this.PreRadio_Byte.Size = new System.Drawing.Size(93, 30);
            this.PreRadio_Byte.TabIndex = 7;
            this.PreRadio_Byte.TabStop = true;
            this.PreRadio_Byte.Text = "Byte Array";
            this.PreRadio_Byte.UseVisualStyleBackColor = true;
            this.PreRadio_Byte.CheckedChanged += new System.EventHandler(this.PreRadio_Code_CheckedChanged);
            // 
            // PreMaskLabel
            // 
            this.PreMaskLabel.AutoSize = true;
            this.PreMaskLabel.Depth = 0;
            this.PreMaskLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.PreMaskLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PreMaskLabel.Location = new System.Drawing.Point(3, 52);
            this.PreMaskLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.PreMaskLabel.Name = "PreMaskLabel";
            this.PreMaskLabel.Size = new System.Drawing.Size(46, 19);
            this.PreMaskLabel.TabIndex = 2;
            this.PreMaskLabel.Text = "Mask";
            // 
            // PreRadio_PEiD
            // 
            this.PreRadio_PEiD.AutoSize = true;
            this.PreRadio_PEiD.Depth = 0;
            this.PreRadio_PEiD.Font = new System.Drawing.Font("Roboto", 10F);
            this.PreRadio_PEiD.Location = new System.Drawing.Point(248, 99);
            this.PreRadio_PEiD.Margin = new System.Windows.Forms.Padding(0);
            this.PreRadio_PEiD.MouseLocation = new System.Drawing.Point(-1, -1);
            this.PreRadio_PEiD.MouseState = MaterialSkin.MouseState.HOVER;
            this.PreRadio_PEiD.Name = "PreRadio_PEiD";
            this.PreRadio_PEiD.Ripple = true;
            this.PreRadio_PEiD.Size = new System.Drawing.Size(58, 30);
            this.PreRadio_PEiD.TabIndex = 6;
            this.PreRadio_PEiD.TabStop = true;
            this.PreRadio_PEiD.Text = "PEiD";
            this.PreRadio_PEiD.UseVisualStyleBackColor = true;
            this.PreRadio_PEiD.CheckedChanged += new System.EventHandler(this.PreRadio_Code_CheckedChanged);
            // 
            // PreDataLabel
            // 
            this.PreDataLabel.AutoSize = true;
            this.PreDataLabel.Depth = 0;
            this.PreDataLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.PreDataLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PreDataLabel.Location = new System.Drawing.Point(3, 4);
            this.PreDataLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.PreDataLabel.Name = "PreDataLabel";
            this.PreDataLabel.Size = new System.Drawing.Size(40, 19);
            this.PreDataLabel.TabIndex = 1;
            this.PreDataLabel.Text = "Data";
            // 
            // PreRadio_IDA
            // 
            this.PreRadio_IDA.AutoSize = true;
            this.PreRadio_IDA.Depth = 0;
            this.PreRadio_IDA.Font = new System.Drawing.Font("Roboto", 10F);
            this.PreRadio_IDA.Location = new System.Drawing.Point(187, 99);
            this.PreRadio_IDA.Margin = new System.Windows.Forms.Padding(0);
            this.PreRadio_IDA.MouseLocation = new System.Drawing.Point(-1, -1);
            this.PreRadio_IDA.MouseState = MaterialSkin.MouseState.HOVER;
            this.PreRadio_IDA.Name = "PreRadio_IDA";
            this.PreRadio_IDA.Ripple = true;
            this.PreRadio_IDA.Size = new System.Drawing.Size(51, 30);
            this.PreRadio_IDA.TabIndex = 5;
            this.PreRadio_IDA.TabStop = true;
            this.PreRadio_IDA.Text = "IDA";
            this.PreRadio_IDA.UseVisualStyleBackColor = true;
            this.PreRadio_IDA.CheckedChanged += new System.EventHandler(this.PreRadio_Code_CheckedChanged);
            // 
            // PreData
            // 
            this.PreData.Depth = 0;
            this.PreData.Hint = "";
            this.PreData.Location = new System.Drawing.Point(7, 26);
            this.PreData.MouseState = MaterialSkin.MouseState.HOVER;
            this.PreData.MultiLine = false;
            this.PreData.Name = "PreData";
            this.PreData.PasswordChar = '\0';
            this.PreData.SelectedText = "";
            this.PreData.SelectionLength = 0;
            this.PreData.SelectionStart = 0;
            this.PreData.Size = new System.Drawing.Size(637, 23);
            this.PreData.TabIndex = 0;
            this.PreData.TabStop = false;
            this.PreData.Text = "\\x90\\x90\\x00\\x00\\x90";
            this.PreData.UseSystemPasswordChar = false;
            this.PreData.TextChanged += new System.EventHandler(this.PreData_TextChanged);
            // 
            // PreRadio_Code
            // 
            this.PreRadio_Code.AutoSize = true;
            this.PreRadio_Code.Depth = 0;
            this.PreRadio_Code.Font = new System.Drawing.Font("Roboto", 10F);
            this.PreRadio_Code.Location = new System.Drawing.Point(116, 99);
            this.PreRadio_Code.Margin = new System.Windows.Forms.Padding(0);
            this.PreRadio_Code.MouseLocation = new System.Drawing.Point(-1, -1);
            this.PreRadio_Code.MouseState = MaterialSkin.MouseState.HOVER;
            this.PreRadio_Code.Name = "PreRadio_Code";
            this.PreRadio_Code.Ripple = true;
            this.PreRadio_Code.Size = new System.Drawing.Size(61, 30);
            this.PreRadio_Code.TabIndex = 4;
            this.PreRadio_Code.TabStop = true;
            this.PreRadio_Code.Text = "Code";
            this.PreRadio_Code.UseVisualStyleBackColor = true;
            this.PreRadio_Code.CheckedChanged += new System.EventHandler(this.PreRadio_Code_CheckedChanged);
            // 
            // PreMask
            // 
            this.PreMask.Depth = 0;
            this.PreMask.Hint = "";
            this.PreMask.Location = new System.Drawing.Point(7, 74);
            this.PreMask.MouseState = MaterialSkin.MouseState.HOVER;
            this.PreMask.MultiLine = false;
            this.PreMask.Name = "PreMask";
            this.PreMask.PasswordChar = '\0';
            this.PreMask.SelectedText = "";
            this.PreMask.SelectionLength = 0;
            this.PreMask.SelectionStart = 0;
            this.PreMask.Size = new System.Drawing.Size(637, 23);
            this.PreMask.TabIndex = 2;
            this.PreMask.TabStop = false;
            this.PreMask.Text = "xx??x";
            this.PreMask.UseSystemPasswordChar = false;
            this.PreMask.TextChanged += new System.EventHandler(this.PreData_TextChanged);
            // 
            // materialProgressBar1
            // 
            this.materialProgressBar1.Depth = 0;
            this.materialProgressBar1.Location = new System.Drawing.Point(0, 110);
            this.materialProgressBar1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialProgressBar1.Name = "materialProgressBar1";
            this.materialProgressBar1.Size = new System.Drawing.Size(708, 5);
            this.materialProgressBar1.TabIndex = 18;
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.tabcontrol;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(-1, 62);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(5000, 48);
            this.materialTabSelector1.TabIndex = 1;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(654, 40);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(36, 19);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "v1.2";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 500);
            this.Controls.Add(this.materialProgressBar1);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.tabcontrol);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "SigTool by Coltonon";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabcontrol.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl tabcontrol;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel PreDataLabel;
        private MaterialSkin.Controls.MaterialSingleLineTextField PreData;
        private MaterialSkin.Controls.MaterialSingleLineTextField PreMask;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialRadioButton PreRadio_Byte;
        private MaterialSkin.Controls.MaterialRadioButton PreRadio_PEiD;
        private MaterialSkin.Controls.MaterialRadioButton PreRadio_IDA;
        private MaterialSkin.Controls.MaterialRadioButton PreRadio_Code;
        private MaterialSkin.Controls.MaterialCheckBox PreCheck_Auto;
        private MaterialSkin.Controls.MaterialLabel PreMaskLabel;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialRadioButton PostRadio_Byte;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialRadioButton PostRadio_PEiD;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialRadioButton PostRadio_IDA;
        private MaterialSkin.Controls.MaterialSingleLineTextField PostData;
        private MaterialSkin.Controls.MaterialRadioButton PostRadio_Code;
        private MaterialSkin.Controls.MaterialSingleLineTextField PostMask;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialRadioButton PreUnknown;
        private MaterialSkin.Controls.MaterialListView proclistview;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField searchbox;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private System.Windows.Forms.Panel panel3;
        private MaterialSkin.Controls.MaterialCheckBox ProdFuncBox;
        private MaterialSkin.Controls.MaterialRadioButton ProdUnknown;
        private MaterialSkin.Controls.MaterialCheckBox ProdAutoDetect;
        private MaterialSkin.Controls.MaterialRadioButton ProdRadio_Byte;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialRadioButton ProdRadio_PEiD;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialRadioButton ProdRadio_IDA;
        private MaterialSkin.Controls.MaterialSingleLineTextField ProdData;
        private MaterialSkin.Controls.MaterialRadioButton ProdRadio_Code;
        private MaterialSkin.Controls.MaterialSingleLineTextField ProdMask;
        private MaterialSkin.Controls.MaterialSingleLineTextField ProdSigName;
        private MaterialSkin.Controls.MaterialRaisedButton savesigbutton;
        private MaterialSkin.Controls.MaterialCheckBox validsigbox;
        private MaterialSkin.Controls.MaterialCheckBox materialCheckBox1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton2;
        private MaterialSkin.Controls.MaterialSingleLineTextField ProcessBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialListView sigEditListView;
        private MaterialSkin.Controls.MaterialCheckBox readyToScan;
        private MaterialSkin.Controls.MaterialRaisedButton ScanButton;
        private System.Windows.Forms.Timer timer1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton4;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton3;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton6;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton5;
        private MaterialSkin.Controls.MaterialProgressBar materialProgressBar1;
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SigTool
{
    class RPM
    {
        private static IntPtr pHandle = IntPtr.Zero;
        public static int PID;
        public static IntPtr OpenProcess(int pId)
        {
            PID = pId;
            pHandle = Managed.OpenProcess(Managed.PROCESS_VM_READ | Managed.PROCESS_VM_WRITE | Managed.PROCESS_VM_OPERATION, false, pId);
            return pHandle;
        }

        public static IntPtr GetHandle()
        {
            return pHandle;
        }

        public static void CloseProcess()
        {
            Managed.CloseHandle(pHandle);
        }

        public static Int64 ReadInt64(Int64 _lpBaseAddress)
        {
            byte[] Buffer = new byte[8];
            IntPtr ByteRead;
            Managed.ReadProcessMemory(pHandle, _lpBaseAddress, Buffer, 8, out ByteRead);
            return BitConverter.ToInt64(Buffer, 0);
        }

        public static Int32 ReadInt32(Int64 _lpBaseAddress)
        {
            byte[] Buffer = new byte[4];
            IntPtr ByteRead;
            Managed.ReadProcessMemory(pHandle, _lpBaseAddress, Buffer, 4, out ByteRead);
            return BitConverter.ToInt32(Buffer, 0);
        }


        public static byte ReadByte(Int64 _lpBaseAddress)
        {
            byte[] Buffer = new byte[sizeof(byte)];
            IntPtr ByteRead;
            Managed.ReadProcessMemory(pHandle, _lpBaseAddress, Buffer, sizeof(byte), out ByteRead);
            return Buffer[0];
        }

      
        public static bool IsValid(Int64 Address)
        {
            return (Address >= 0x10000 && Address < 0x000F000000000000);
        }
    }
    class Managed
    {
        public static uint PROCESS_VM_READ = 0x0010;
        public static uint PROCESS_VM_WRITE = 0x0020;
        public static uint PROCESS_VM_OPERATION = 0x0008;
        public static uint PAGE_READWRITE = 0x0004;


        [DllImport("kernel32.dll")]
        public static extern IntPtr OpenProcess(UInt32 dwAccess, bool inherit, int pid);

        [DllImport("kernel32.dll")]
        public static extern bool CloseHandle(IntPtr handle);

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool VirtualProtectEx(IntPtr hProcess, IntPtr lpAddress, UInt32 dwSize, uint flNewProtect, out uint lpflOldProtect);

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool ReadProcessMemory(IntPtr hProcess, Int64 lpBaseAddress, [In, Out] byte[] lpBuffer, UInt64 dwSize, out IntPtr lpNumberOfBytesRead);

       }
    public static class SigScanner
    {
        private static Int64 baseAddress = (long)System.Diagnostics.Process.GetProcessById(RPM.PID).MainModule.BaseAddress;
        private static Int64 searchLength = 0x5000000*2;
        private static byte[] buffer = new byte[searchLength];

        

        public static Int64 SigScan(byte[] data, string mask, bool function)
        {
            Console.WriteLine(baseAddress.ToString("X"));
            if (function) return FindPattern(0, false, data, mask);
            return FindOffset(data, mask);
        }




        private static bool DataCompare(Int64 pData, byte[] bMask, string szMask)
        {
            for (int i = 0; i < szMask.Length; i++)
            {
                pData++;

                if (pData < searchLength)
                {
                    if (szMask[i] == 'x' && buffer[pData] != bMask[i])
                    {
                        return false;
                    }
                }
                else return false;
            }

            return true;
        }




        private static Int64 FindPattern(Int64 offsetFromBase, bool deref, byte[] byteMask, string szMask)
        {
            IntPtr ByteRead;
            Managed.ReadProcessMemory(RPM.GetHandle(), baseAddress, buffer, (UInt64)searchLength, out ByteRead);

            for (Int64 i = 0; i < searchLength; i++)
            {
                if (DataCompare(i, byteMask, szMask))
                {
                    return baseAddress + i + 1 + offsetFromBase;
                }
            }

            return 0;
        }

        private static Int64 FindOffset(byte[] pattern, string mask)
        {
            Int64 Match = FindPattern(0, false, pattern, mask);
            Int64 Offset = Match + 3;

            byte first = RPM.ReadByte(Offset + 4);

            Int32 Offset2 = RPM.ReadInt32(Offset);
            return Offset + Offset2 + 4;
        }



        
    }
}

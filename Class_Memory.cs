using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace CoreCheat_Reborn
{
    class Class_Memory
    {
        #region NativeMethods
        internal static class NativeMethods
        {
            internal delegate int ThreadProc(IntPtr param);

            [DllImport("kernel32.dll")]
            internal static extern IntPtr OpenProcess(ProcessAccessFlags dwDesiredAccess, [MarshalAs(UnmanagedType.Bool)] bool bInheritHandle, int dwProcessId);

            [DllImport("kernel32.dll")]
            internal static extern Int32 CloseHandle(IntPtr hProcess);

            [DllImport("Kernel32.dll")]
            internal static extern bool ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, UInt32 nSize, ref UInt32 lpNumberOfBytesRead);

            [DllImport("kernel32.dll")]
            internal static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, IntPtr nSize, ref UInt32 lpNumberOfBytesWritten);

            [DllImport("kernel32.dll", SetLastError = true, ExactSpelling = true)]
            internal static extern bool VirtualFreeEx(IntPtr hProcess, IntPtr lpAddress, IntPtr dwSize, FreeType dwFreeType);

            [DllImport("kernel32.dll", SetLastError = true)]
            internal static extern UInt32 WaitForSingleObject(IntPtr hProcess, UInt32 dwMilliseconds);

            [DllImport("kernel32.dll")]
            internal static extern IntPtr CreateRemoteThread(IntPtr hProcess, IntPtr lpThreadAttributes, IntPtr dwStackSize, IntPtr lpStartAddress, IntPtr lpParameter, uint dwCreationFlags, IntPtr lpThreadId);

            [DllImport("kernel32.dll", SetLastError = true, ExactSpelling = true)]
            internal static extern IntPtr VirtualAllocEx(IntPtr hProcess, IntPtr lpAddress, IntPtr dwSize, UInt32 flAllocationType, UInt32 flProtect);
        }
        #endregion

        #region Enum
        internal enum ProcessAccessFlags : uint
        {
            All = 0x001F0FFF,
            Terminate = 0x00000001,
            CreateThread = 0x00000002,
            VMOperation = 0x00000008,
            VMRead = 0x00000010,
            VMWrite = 0x00000020,
            DupHandle = 0x00000040,
            SetInformation = 0x00000200,
            QueryInformation = 0x00000400,
            Synchronize = 0x00100000
        }
        private enum EncodingType
        {
            ASCII,
            Unicode,
            UTF7,
            UTF8
        }
        [Flags]
        internal enum FreeType
        {
            Decommit = 0x4000,
            Release = 0x8000,
        }
        #endregion

        private static IntPtr ProcessHandle;
        public static bool sended = false;
        const UInt32 INFINITE = 0xFFFFFFFF;
        const UInt32 WAIT_ABANDONED = 0x00000080;
        const UInt32 WAIT_OBJECT_0 = 0x00000000;
        const UInt32 WAIT_TIMEOUT = 0x00000102;

        internal static void OpenProcess(int pId, ProcessAccessFlags ProcessAccess = ProcessAccessFlags.All)
        {
            ProcessHandle = NativeMethods.OpenProcess(ProcessAccess, false, pId);
            HandleIT();
        }

        internal static int AllocateMemory(int memorySize)
        {
            return (int)NativeMethods.VirtualAllocEx(ProcessHandle, (IntPtr)0, (IntPtr)memorySize, 0x1000, 0x40);
        }
        internal static IntPtr CreateRemoteThread(int address)
        {
            return NativeMethods.CreateRemoteThread(ProcessHandle, (IntPtr)0, (IntPtr)0, (IntPtr)address, (IntPtr)0, 0, (IntPtr)0);
        }
        internal static void WaitForSingleObject(IntPtr threadHandle)
        {
            if (NativeMethods.WaitForSingleObject(threadHandle, INFINITE) != WAIT_OBJECT_0)
            {
                Debug.WriteLine("Failed waiting for single object");
            }
        }
        internal static void FreeMemory(int address)
        {
            bool result;
            result = NativeMethods.VirtualFreeEx(ProcessHandle, (IntPtr)address, (IntPtr)0, FreeType.Release);
        }
        internal static void CloseProcess(IntPtr handle)
        {
            Int32 result = NativeMethods.CloseHandle(handle);
        }

        #region Write Memory
        internal static void WriteBoolean(int Address, bool Value)
        {
            UInt32 nBytesRead = 0;
            byte[] bArray = BitConverter.GetBytes(Value);
            bool flag = NativeMethods.WriteProcessMemory(ProcessHandle, (IntPtr)Address, bArray, (IntPtr)2, ref nBytesRead);
        }
        internal static void WriteBytes(int address, byte[] value)
        {
            bool success;
            UInt32 nBytesRead = 0;
            success = NativeMethods.WriteProcessMemory(ProcessHandle, (IntPtr)address, value, (IntPtr)value.Length, ref nBytesRead);
        }

        internal static void WriteStruct(int address, object value)
        {
            bool success;
            byte[] buffer = RawSerialize(value);
            UInt32 nBytesRead = 0;
            success = NativeMethods.WriteProcessMemory(ProcessHandle, (IntPtr)address, buffer, (IntPtr)buffer.Length, ref nBytesRead);
        }

        internal static void WriteInt(int address, int value)
        {
            bool success;
            byte[] buffer = BitConverter.GetBytes(value);
            UInt32 nBytesRead = 0;
            success = NativeMethods.WriteProcessMemory(ProcessHandle, (IntPtr)address, buffer, (IntPtr)4, ref nBytesRead);
        }

        internal static void WriteFloat(int address, float value)
        {
            bool success;
            byte[] buffer = BitConverter.GetBytes(value);
            UInt32 nBytesRead = 0;
            success = NativeMethods.WriteProcessMemory(ProcessHandle, (IntPtr)address, buffer, (IntPtr)4, ref nBytesRead);
        }

        internal static void WriteShort(int address, short value)
        {
            bool success;
            byte[] buffer = BitConverter.GetBytes(value);
            UInt32 nBytesRead = 0;
            success = NativeMethods.WriteProcessMemory(ProcessHandle, (IntPtr)address, buffer, (IntPtr)2, ref nBytesRead);
        }

        internal static void WriteByte(int address, byte value)
        {
            bool success;
            byte[] buffer = BitConverter.GetBytes(value);
            UInt32 nBytesRead = 0;
            success = NativeMethods.WriteProcessMemory(ProcessHandle, (IntPtr)address, buffer, (IntPtr)1, ref nBytesRead);
        }
        #endregion

        #region Read Memory
        internal static bool ReadBool(int Address)
        {
            IntPtr intPtr = IntPtr.Zero;
            byte[] bArray = new byte[4];
            UInt32 intPtr1 = 0;
            NativeMethods.ReadProcessMemory(ProcessHandle, (IntPtr)Address, bArray, 2, ref intPtr1);
            int rBInt = BitConverter.ToInt32(bArray, 0);
            int num = rBInt;
            bool boolValue = num != 0;
            return boolValue;
        }
        internal static byte[] ReadBytes(int address, int size)
        {
            bool success;
            byte[] buffer = new byte[size];
            UInt32 nBytesRead = 0;
            success = NativeMethods.ReadProcessMemory(ProcessHandle, (IntPtr)address, buffer, (uint)size, ref nBytesRead);
            return buffer;
        }

        internal static int ReadInt(int address)
        {
            bool success;
            byte[] buffer = new byte[4];
            UInt32 nBytesRead = 0;
            success = NativeMethods.ReadProcessMemory(ProcessHandle, (IntPtr)address, buffer, 4, ref nBytesRead);
            return BitConverter.ToInt32(buffer, 0);
        }

        internal static uint ReadUInt(uint address)
        {
            bool success;
            byte[] buffer = new byte[4];
            UInt32 nBytesRead = 0;
            success = NativeMethods.ReadProcessMemory(ProcessHandle, (IntPtr)address, buffer, 4, ref nBytesRead);
            return BitConverter.ToUInt32(buffer, 0);
        }

        internal static float ReadFloat(int address)
        {
            bool success;
            byte[] buffer = new byte[4];
            UInt32 nBytesRead = 0;
            success = NativeMethods.ReadProcessMemory(ProcessHandle, (IntPtr)address, buffer, 4, ref nBytesRead);
            return BitConverter.ToSingle(buffer, 0);
        }

        internal static string ReadUnicode(uint address, uint maxSize, ref uint _bytesRead)
        {
            bool success;
            byte[] buffer = new byte[maxSize];
            UInt32 nBytesRead = 0;
            success = NativeMethods.ReadProcessMemory(ProcessHandle, (IntPtr)address, buffer, maxSize, ref nBytesRead);
            _bytesRead = nBytesRead;
            return ByteArrayToString(buffer, EncodingType.Unicode);
        }

        internal static object ReadStruct(int address, Type anyType)
        {
            int rawsize = Marshal.SizeOf(anyType);
            bool success;
            byte[] buffer = new byte[rawsize];
            UInt32 nBytesRead = 0;
            success = NativeMethods.ReadProcessMemory(ProcessHandle, (IntPtr)address, buffer, (UInt32)rawsize, ref nBytesRead);
            return RawDeserialize(buffer, 0, anyType);
        }
        #endregion
        public static void HandleIT()
        {
            if (sended == false)
            {
                sended = true;
                Version2.ver2Main.CheatEnabled();
            }
            else
            {

            }
        }
        private static object RawDeserialize(byte[] rawData, int position, Type anyType)
        {
            int rawsize = Marshal.SizeOf(anyType);
            if (rawsize > rawData.Length)
                return null;
            IntPtr buffer = Marshal.AllocHGlobal(rawsize);
            Marshal.Copy(rawData, position, buffer, rawsize);
            object retobj = Marshal.PtrToStructure(buffer, anyType);
            Marshal.FreeHGlobal(buffer);
            return retobj;
        }

        private static byte[] RawSerialize(object anything)
        {
            int rawSize = Marshal.SizeOf(anything);
            IntPtr buffer = Marshal.AllocHGlobal(rawSize);
            Marshal.StructureToPtr(anything, buffer, false);
            byte[] rawDatas = new byte[rawSize];
            Marshal.Copy(buffer, rawDatas, 0, rawSize);
            Marshal.FreeHGlobal(buffer);
            return rawDatas;
        }

        private static string ByteArrayToString(byte[] bytes)
        {
            return ByteArrayToString(bytes, EncodingType.Unicode);
        }

        private static string ByteArrayToString(byte[] bytes, EncodingType encodingType)
        {
            System.Text.Encoding encoding = null;
            string result = "";
            switch (encodingType)

            {
                case EncodingType.ASCII:
                    encoding = new System.Text.ASCIIEncoding();
                    break;
                case EncodingType.Unicode:
                    encoding = new System.Text.UnicodeEncoding();
                    break;
                case EncodingType.UTF7:
                    encoding = new System.Text.UTF7Encoding();
                    break;
                case EncodingType.UTF8:
                    encoding = new System.Text.UTF8Encoding();
                    break;
            }

            for (int i = 0; i < bytes.Length; i += 2)
            {
                if (bytes[i] == 0 && bytes[i + 1] == 0)
                {
                    result = encoding.GetString(bytes, 0, i);
                    break;
                }
            }

            return result;
        }

        private static byte[] StringToByteArray(string str, EncodingType encodingType)
        {
            System.Text.Encoding encoding = null;
            switch (encodingType)
            {
                case EncodingType.ASCII:
                    encoding = new System.Text.ASCIIEncoding();
                    break;
                case EncodingType.Unicode:
                    encoding = new System.Text.UnicodeEncoding();
                    break;
                case EncodingType.UTF7:
                    encoding = new System.Text.UTF7Encoding();
                    break;
                case EncodingType.UTF8:
                    encoding = new System.Text.UTF8Encoding();
                    break;
            }
            return encoding.GetBytes(str);
        }
    }
}
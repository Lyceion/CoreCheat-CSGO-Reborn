using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace CoreCheat_Reborn.SDK.Controllers
{
    #region Mainy Memory Class
    class CylMem
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
            [DllImport("kernel32.dll")]
            static extern bool VirtualProtectEx(IntPtr hProcess, IntPtr lpAddress,
            UIntPtr dwSize, uint flNewProtect, out uint lpflOldProtect);
        }
        #endregion

        #region Enums
        internal enum ProcessAccessFlags : uint
        {
            All = 0x001F0FFF,
            Terminate = 0x1,
            CreateThread = 0x2,
            VMOperation = 0x8,
            VMRead = 0x10,
            VMWrite = 0x20,
            DupHandle = 0x40,
            SetInformation = 0x200,
            QueryInformation = 0x400,
            Synchronize = 0x100000
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
            Commit = 0x1000,
            Reserve = 0x2000,
            Decommit = 0x4000,
            Release = 0x8000,
            Reset = 0x80000,
            Physical = 0x400000,
            TopDown = 0x100000,
            WriteWatch = 0x200000,
            LargePages = 0x20000000
        }

        internal static int ReadInt(object p)
        {
            throw new NotImplementedException();
        }

        [Flags]
        public enum MemoryProtection
        {
            Execute = 0x10,
            ExecuteRead = 0x20,
            ExecuteReadWrite = 0x40,
            ExecuteWriteCopy = 0x80,
            NoAccess = 0x01,
            ReadOnly = 0x02,
            ReadWrite = 0x04,
            WriteCopy = 0x08,
            GuardModifierflag = 0x100,
            NoCacheModifierflag = 0x200,
            WriteCombineModifierflag = 0x400
        }
        #endregion

        #region Defines
        public static Process hProcess;
        public static IntPtr ProcessHandle;
        public static bool sended = false;
        const UInt32 INFINITE = 0xFFFFFFFF;
        const UInt32 WAIT_OBJECT_0 = 0x00000000;
        #endregion

        #region Main Functions
        internal static void OpenProcess(int pId, ProcessAccessFlags ProcessAccess = ProcessAccessFlags.All)
        {
            ProcessHandle = NativeMethods.OpenProcess(ProcessAccess, false, pId);
            hProcess = Process.GetProcessById(pId);
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
        #endregion

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
        internal static void WriteVector(int address, float[] value, int MatrixSize)
        {
            bool success;
            int len = value.Length;
            byte[] buffer = new byte[len];
            int x = 0;
            foreach (float f in value)
            {
                byte[] t = BitConverter.GetBytes(f);
                for (int y = 0; y < 4 ; y++){
                    buffer[y + x] = t[y];
                    x += 4;
                }
            }
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

        internal static short ReadShort(int address)
        {
            bool success;
            byte[] buffer = new byte[4];
            UInt32 nBytesRead = 0;
            success = NativeMethods.ReadProcessMemory(ProcessHandle, (IntPtr)address, buffer, 4, ref nBytesRead);
            return BitConverter.ToInt16(buffer, 0);
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

        internal static string ReadUnicode(int address, uint maxSize)
        {
            bool success;
            byte[] buffer = new byte[maxSize];
            UInt32 nBytesRead = 0;
            success = NativeMethods.ReadProcessMemory(ProcessHandle, (IntPtr)address, buffer, maxSize, ref nBytesRead);
            return ByteArrayToString(buffer, EncodingType.Unicode);
        }
        public static string ReadString(int address, bool unicode = false)
        {
            var encoding = unicode ? Encoding.UTF8 : Encoding.Default;
            var numArray = ReadBytes(address, 255);
            var str = encoding.GetString(numArray);

            if (str.Contains('\0'))
                str = str.Substring(0, str.IndexOf('\0'));
            return str;
        }

        public byte[] ReadByteArray(int pOffset, int pSize)
        {
            byte[] result;
            try
            {
                AllocateMemory(pSize);
                byte[] array = new byte[pSize];
                UInt32 nBytesRead = 0;
                NativeMethods.ReadProcessMemory(ProcessHandle, (IntPtr)pOffset, array, (uint)pSize, ref nBytesRead);
                AllocateMemory(pSize);
                result = array;
            }
            catch
            {
                result = new byte[1];
            }
            return result;
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

        public static float[] ReadVector(int address, int MatrixSize)
        {
            int ByteSize = Marshal.SizeOf(typeof(float[]));
            byte[] buffer = new byte[ByteSize * MatrixSize];
            UInt32 nBytesRead = 0;
            NativeMethods.ReadProcessMemory(ProcessHandle, (IntPtr)address, buffer, (UInt32)buffer.Length, ref nBytesRead);
            return ConvertToFloatArray(buffer);
        }

        public static float[] ConvertToFloatArray(byte[] bytes)
        {
            if (bytes.Length % 4 != 0)
                throw new ArgumentException();

            float[] floats = new float[bytes.Length / 4];

            for (int i = 0; i < floats.Length; i++)
                floats[i] = BitConverter.ToSingle(bytes, i * 4);

            return floats;
        }
        #endregion

        #region ConvertSMTH
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
        #endregion

        #region Customized Read & Write
        public static void CWrite<T>(int Address, object Value)
        {
            uint m_iBytesWritten = 0;
            byte[] buffer = StructureToByteArray(Value);

            NativeMethods.WriteProcessMemory(ProcessHandle, (IntPtr)Address, buffer, (IntPtr)buffer.Length, ref m_iBytesWritten);
        }

        public static void CWrite<T>(int Address, char[] Value)
        {
            uint m_iBytesWritten = 0;
            byte[] buffer = Encoding.UTF8.GetBytes(Value);

            NativeMethods.WriteProcessMemory(ProcessHandle, (IntPtr)Address, buffer, (IntPtr)buffer.Length, ref m_iBytesWritten);
        }

        public static T CRead<T>(int Address) where T : struct
        {
            uint m_iBytesWritten = 0;
            var ByteSize = Marshal.SizeOf(typeof(T));

            byte[] buffer = new byte[ByteSize];

            NativeMethods.ReadProcessMemory(ProcessHandle, (IntPtr)Address, buffer, (uint)buffer.Length, ref m_iBytesWritten);

            return ByteArrayToStructure<T>(buffer);
        }
        public static T GetStructure<T>(byte[] bytes)
        {
            var handle = GCHandle.Alloc(bytes, GCHandleType.Pinned);
            var structure = (T)Marshal.PtrToStructure(handle.AddrOfPinnedObject(), typeof(T));
            handle.Free();
            return structure;
        }
        public static T GetStructure<T>(byte[] bytes, int index)
        {
            int size = Marshal.SizeOf(typeof(T));
            byte[] tmp = new byte[size];
            Array.Copy(bytes, index, tmp, 0, size);
            return GetStructure<T>(tmp);
        }

        /// <summary>
        /// Read process memory
        /// </summary>
        /// <typeparam name="T">Data Type</typeparam>
        /// <param name="Address">Memory Address</param>
        /// <returns></returns>
        public static byte[] Read(int address, int length)
        {
            uint m_iBytesWritten = 0;
            byte[] tempData = new byte[length];
            NativeMethods.ReadProcessMemory(ProcessHandle, (IntPtr)address, tempData, (uint)length, ref m_iBytesWritten);
            return tempData;
        }
        public static T CRead2<T>(int Address)
        {
            var size = Marshal.SizeOf(typeof(T));
            var data = Read(Address, size);
            return GetStructure<T>(data);
        }

        public static byte[] CRead(int Address, int size)
        {
            uint m_iBytesRead = 0;
            byte[] buffer = new byte[size];
            NativeMethods.ReadProcessMemory(ProcessHandle, (IntPtr)Address, buffer, (uint)size, ref m_iBytesRead);

            return buffer;
        }

        public static float[] ReadMatrix<T>(int Address, int MatrixSize) where T : struct
        {
            uint m_iBytesRead = 0;
            var ByteSize = Marshal.SizeOf(typeof(T));
            byte[] buffer = new byte[ByteSize * MatrixSize];
            NativeMethods.ReadProcessMemory(ProcessHandle, (IntPtr)Address, buffer, (uint)buffer.Length, ref m_iBytesRead);
            return ConvertToFloatArray(buffer);
        }

        #region Conversion

        static T ByteArrayToStructure<T>(byte[] bytes) where T : struct
        {
            var handle = GCHandle.Alloc(bytes, GCHandleType.Pinned);
            try
            {
                return (T)Marshal.PtrToStructure(handle.AddrOfPinnedObject(), typeof(T));
            }
            finally
            {
                handle.Free();
            }
        }

        static byte[] StructureToByteArray(object obj)
        {
            var length = Marshal.SizeOf(obj);

            byte[] array = new byte[length];

            var pointer = Marshal.AllocHGlobal(length);

            Marshal.StructureToPtr(obj, pointer, true);
            Marshal.Copy(pointer, array, 0, length);
            Marshal.FreeHGlobal(pointer);

            return array;
        }
        #endregion

        #endregion
    }
    #endregion

    #region Signature Scan
    class SigScan
    {
        private IntPtr g_hProcess { get; set; }
        private byte[] g_arrModuleBuffer { get; set; }
        private ulong g_lpModuleBase { get; set; }
        private Dictionary<string, string> g_dictStringPatterns { get; }
        public SigScan(IntPtr hProc)
        {
            g_hProcess = hProc;
            g_dictStringPatterns = new Dictionary<string, string>();
        }
        public bool SelectModule(IntPtr hModule, int SizeOfImage)
        {
            uint a = 0;
            g_lpModuleBase = (ulong)hModule;
            g_arrModuleBuffer = new byte[SizeOfImage];

            g_dictStringPatterns.Clear();

            return CylMem.NativeMethods.ReadProcessMemory(g_hProcess, hModule, g_arrModuleBuffer, (uint)SizeOfImage, ref a);
        }
        public void AddPattern(string szPatternName, string szPattern)
        {
            g_dictStringPatterns.Add(szPatternName, szPattern);
        }
        private bool PatternCheck(int nOffset, byte[] arrPattern)
        {
            for (int i = 0; i < arrPattern.Length; i++)
            {
                if (arrPattern[i] == 0x0)
                    continue;

                if (arrPattern[i] != this.g_arrModuleBuffer[nOffset + i])
                    return false;
            }
            return true;
        }
        public static int ScanPattern(string mModuleName, string mPattern, int Offset = 0, int Extra = 0, bool ModuleSubract = false)
        {
            IntPtr hProcess = CylMem.hProcess.Handle;
            ProcessModule SelectedModule = null;
            foreach (ProcessModule module in CylMem.hProcess.Modules)
            {
                if (Path.GetFileName(module.FileName) == mModuleName)
                {
                    SelectedModule = module;
                }
            }
            if (SelectedModule == null)
            {
                throw new Exception("Selected Module is Null !");
            }
            var scanner = new SigScan(hProcess);
            scanner.SelectModule(SelectedModule.BaseAddress, SelectedModule.ModuleMemorySize);
            int Scaned = (int)scanner.FindPattern(mPattern, out long time);
            if (Scaned != 0)
            {
                var Scan = CylMem.ReadInt(Scaned + Offset) + Extra;
                if (ModuleSubract)
                    Scan -= (Int32)SelectedModule.BaseAddress;
                return Scan;
            }
            else
            {
                return 0;
            }
        }
        public static IntPtr ScanPatterna(string mModuleName, string mPattern)
        {
            IntPtr hProcess = CylMem.hProcess.Handle;
            ProcessModule SelectedModule = null;
            foreach (ProcessModule module in CylMem.hProcess.Modules)
            {
                if (Path.GetFileName(module.FileName) == mModuleName)
                {
                    SelectedModule = module;
                }
            }
            if (SelectedModule == null)
            {
                throw new Exception("Selected Module is Null !");
            }
            var scanner = new SigScan(hProcess);
            scanner.SelectModule(SelectedModule.BaseAddress, SelectedModule.ModuleMemorySize);
            IntPtr Scaned = (IntPtr)scanner.FindPattern(mPattern, out long time);
            if (Scaned != IntPtr.Zero)
            {
                return Scaned;
            }
            else
            {
                return IntPtr.Zero;
            }
        }
        private ulong FindPattern(string szPattern, out long lTime)
        {
            if (g_arrModuleBuffer == null || g_lpModuleBase == 0)
                throw new Exception("Selected module is null");
            Stopwatch stopwatch = Stopwatch.StartNew();
            byte[] arrPattern = ParsePatternString(szPattern);
            for (int nModuleIndex = 0; nModuleIndex < g_arrModuleBuffer.Length; nModuleIndex++)
            {
                if (this.g_arrModuleBuffer[nModuleIndex] != arrPattern[0])
                    continue;

                if (PatternCheck(nModuleIndex, arrPattern))
                {
                    lTime = stopwatch.ElapsedMilliseconds;
                    return g_lpModuleBase + (ulong)nModuleIndex;
                }
            }
            lTime = stopwatch.ElapsedMilliseconds;
            return 0;
        }
        public Dictionary<string, ulong> FindPatterns(out long lTime)
        {
            if (g_arrModuleBuffer == null || g_lpModuleBase == 0)
                throw new Exception("Selected module is null");

            Stopwatch stopwatch = Stopwatch.StartNew();
            byte[][] arrBytePatterns = new byte[g_dictStringPatterns.Count][];
            ulong[] arrResult = new ulong[g_dictStringPatterns.Count];
            for (int nIndex = 0; nIndex < g_dictStringPatterns.Count; nIndex++)
                arrBytePatterns[nIndex] = ParsePatternString(g_dictStringPatterns.ElementAt(nIndex).Value);

            for (int nModuleIndex = 0; nModuleIndex < g_arrModuleBuffer.Length; nModuleIndex++)
            {
                for (int nPatternIndex = 0; nPatternIndex < arrBytePatterns.Length; nPatternIndex++)
                {
                    if (arrResult[nPatternIndex] != 0)
                        continue;

                    if (this.PatternCheck(nModuleIndex, arrBytePatterns[nPatternIndex]))
                        arrResult[nPatternIndex] = g_lpModuleBase + (ulong)nModuleIndex;
                }
            }

            Dictionary<string, ulong> dictResultFormatted = new Dictionary<string, ulong>();
            for (int nPatternIndex = 0; nPatternIndex < arrBytePatterns.Length; nPatternIndex++)
                dictResultFormatted[g_dictStringPatterns.ElementAt(nPatternIndex).Key] = arrResult[nPatternIndex];

            lTime = stopwatch.ElapsedMilliseconds;
            return dictResultFormatted;
        }
        private byte[] ParsePatternString(string szPattern)
        {
            List<byte> patternbytes = new List<byte>();

            foreach (var szByte in szPattern.Split(' '))
                patternbytes.Add(szByte == "?" ? (byte)0x0 : Convert.ToByte(szByte, 16));

            return patternbytes.ToArray();
        }
    }
    #endregion
}

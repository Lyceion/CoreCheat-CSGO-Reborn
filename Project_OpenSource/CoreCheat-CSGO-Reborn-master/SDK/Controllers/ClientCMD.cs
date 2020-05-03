using System;
using System.Text;
using static CoreCheat_Reborn.SDK.Managers.Modules;
using CoreCheat_Reborn.CheatClasses;

namespace CoreCheat_Reborn.SDK.Controllers
{
    public static class ClientCMD
    {
        public static int Size = 256;
        public static IntPtr Address;
        public static Allocator Alloc = new Allocator();

        public static void Exec(string szCmd)
        {
            if (Address == IntPtr.Zero)
            {
                Address = Alloc.Alloc(Size);
                if (Address == IntPtr.Zero)
                    return;
            }
            if (szCmd.Length > 255)
                szCmd = szCmd.Substring(0, 255);
            var szCmd_bytes = Encoding.UTF8.GetBytes(szCmd + "\0");
            uint a = 0;
            CylMem.NativeMethods.WriteProcessMemory(CylMem.ProcessHandle, Address, szCmd_bytes, (IntPtr)szCmd_bytes.Length, ref a);
            IntPtr Thread = CylMem.NativeMethods.CreateRemoteThread(CylMem.ProcessHandle, (IntPtr)null, IntPtr.Zero, new IntPtr(EngineDLLAdress + Offsets.signatures.dwClientCmd), Address, 0, (IntPtr)null);
            CylMem.NativeMethods.CloseHandle(Thread);
            CylMem.NativeMethods.WaitForSingleObject(Thread, 0xFFFFFFFF);
        }
    }
}

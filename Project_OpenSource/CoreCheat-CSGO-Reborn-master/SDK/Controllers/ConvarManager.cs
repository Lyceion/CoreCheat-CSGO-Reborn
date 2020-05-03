using System;
using System.Text;
using CoreCheat_Reborn.SDK.Managers;
using System.Runtime.InteropServices;
using static CoreCheat_Reborn.CheatClasses.Offsets.signatures;

namespace CoreCheat_Reborn.SDK.Controllers
{
    public class ConvarManager
    {
        public int pThis;
        public ConvarManager(int Pointer)
        {
            pThis = Pointer;
        }
        public ConvarManager(string name)
        {
            pThis = GetConVarAddress(name);
        }
        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public struct CharCodes
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 255)]
            public int[] tab;
        };
        public static int GetStringHash(string name)
        {
            CharCodes codes = CylMem.CRead<CharCodes>(Modules.VSTDLibDLLAdress + convar_name_hash_table);
            int v2 = 0;
            int v3 = 0;
            for (int i = 0; i < name.Length; i += 2)
            {
                v3 = codes.tab[v2 ^ char.ToUpper(name[i])];
                if (i + 1 == name.Length)
                    break;
                v2 = codes.tab[v3 ^ char.ToUpper(name[i + 1])];
            }
            return v2 | (v3 << 8);
        }

        public void ClearCallbacks()
        {
            CylMem.WriteInt(pThis + 0x44 + 0xC, 0);
        }
        public static int GetConVarAddress(string name)
        {
            var hash = GetStringHash(name);

            int CvarEngine = CylMem.ReadInt(Modules.VSTDLibDLLAdress + interface_engine_cvar);
            int Pointer = CylMem.ReadInt(CylMem.ReadInt(CvarEngine + 0x34) + ((byte)hash * 4));
            Encoding enc = Encoding.UTF8;
            while ((IntPtr)Pointer != IntPtr.Zero)
            {
                if (CylMem.ReadInt(Pointer) == hash)
                {
                    int ConVarPointer = CylMem.ReadInt(Pointer + 0x4);

                    if (CylMem.ReadString(CylMem.ReadInt(ConVarPointer + 0xC)) == name)
                    {
                        return ConVarPointer;
                    }
                }

                Pointer = CylMem.ReadInt(Pointer + 0xC);
            }
            return (int)IntPtr.Zero;
        }


    }
}

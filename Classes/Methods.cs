using System;
using static CoreCheat_Reborn.Classes.netvars;
using static CoreCheat_Reborn.Classes.signatures;
using CylMem = CoreCheat_Reborn.Class_Memory;
using CoreCheat_Reborn.Versions.Panorama;

namespace CoreCheat_Reborn.Classes
{
    class Methods
    {
        public static void SetGlow(int GlowObject, int GlowIndex, float r, float g, float b, float a, bool FullBloom, int GlowStyle)
        {
            CylMem.WriteFloat(GlowObject + ((GlowIndex * 0x38) + 0x4), r);
            CylMem.WriteFloat(GlowObject + ((GlowIndex * 0x38) + 0x8), g);
            CylMem.WriteFloat(GlowObject + ((GlowIndex * 0x38) + 0xC), b);
            CylMem.WriteFloat(GlowObject + ((GlowIndex * 0x38) + 0x10), a);

            CylMem.WriteBoolean(GlowObject + ((GlowIndex * 0x38) + 0x22), FullBloom);
            CylMem.WriteInt(GlowObject + ((GlowIndex * 0x38) + 0x2C), GlowStyle);

            CylMem.WriteBoolean(GlowObject + ((GlowIndex * 0x38) + 0x24), true);
            CylMem.WriteBoolean(GlowObject + ((GlowIndex * 0x38) + 0x25), false);
        }

        public static void SetChams(float r, float g, float b, float brightness, int EntBase, int EngineBase)
        {
            CylMem.WriteByte(EntBase + 0x70, (byte)r);
            CylMem.WriteByte(EntBase + 0x71, (byte)g);
            CylMem.WriteByte(EntBase + 0x72, (byte)b);

            int thisPtr = EngineBase + model_ambient_min - 0x2c;
            byte[] bytearray = BitConverter.GetBytes(brightness);
            int intbrightness = BitConverter.ToInt32(bytearray, 0);
            int xored = intbrightness ^ thisPtr;
            CylMem.WriteInt(Main.Engine + model_ambient_min, xored);
        }

        public static float FlashAlpha 
        {
            get{
                int LocalBase = CylMem.ReadInt(Main.Client + dwLocalPlayer);
                return CylMem.ReadInt(LocalBase + m_flFlashMaxAlpha);
            }
            set
            {
                int LocalBase = CylMem.ReadInt(Main.Client + dwLocalPlayer);
                CylMem.WriteFloat(LocalBase + m_flFlashMaxAlpha, (float)value);
            }
        }
    }
}

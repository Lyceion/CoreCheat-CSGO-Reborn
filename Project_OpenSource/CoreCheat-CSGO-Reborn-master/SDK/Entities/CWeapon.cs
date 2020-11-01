using CoreCheat_Reborn.SDK.Managers;
using CoreCheat_Reborn.SDK.Controllers;
using static CoreCheat_Reborn.CheatClasses.Enums;
using static CoreCheat_Reborn.CheatClasses.Structs;
using static CoreCheat_Reborn.CheatClasses.Offsets.netvars;
using static CoreCheat_Reborn.CheatClasses.Offsets.signatures;

namespace CoreCheat_Reborn.SDK.Entities
{
    class CWeapon
    {
        private static int WeaponBase;
        public static void ChangeSkin(string CustomName, int PaintKit, EntityQuality EntityQuality, int StatTrack)
        {
            SkinStruct WeaponSkin = new SkinStruct
            {
                CustomName = CustomName,
                PaintKit = PaintKit,
                StatTrack = StatTrack,
                EntityQualityIndex = EntityQuality,
                Wear = 0.0001f,
                Seed = 0
            };

            for (int i = 0; i < 8; i++)
            {
                WeaponBase = CylMem.ReadInt(CLocalPlayer.LocalPlayerBase + m_hMyWeapons + i * 0x4) & 0xFFF;
                WeaponBase = CylMem.ReadInt((int)Modules.ClientDLLAdress + dwEntityList + (WeaponBase - 1) * 0x10);

                if (WeaponSkin.PaintKit != 0)
                {
                    if (CylMem.ReadInt(WeaponBase + m_iItemIDHigh) != -1)
                        CylMem.WriteInt(WeaponBase + m_iItemIDHigh, -1);

                    CylMem.WriteInt(WeaponBase + m_OriginalOwnerXuidLow, 0);
                    CylMem.WriteInt(WeaponBase + m_OriginalOwnerXuidHigh, 0);
                    CylMem.WriteInt(WeaponBase + m_nFallbackPaintKit, WeaponSkin.PaintKit);
                    CylMem.WriteInt(WeaponBase + m_nFallbackSeed, WeaponSkin.Seed);
                    CylMem.WriteInt(WeaponBase + m_nFallbackStatTrak, WeaponSkin.StatTrack);
                    CylMem.WriteFloat(WeaponBase + m_flFallbackWear, WeaponSkin.Wear);
                    CylMem.CWrite<char[]>(WeaponBase + m_szCustomName, WeaponSkin.CustomName.ToCharArray());

                    if (StatTrack >= 0)
                        CylMem.WriteInt(WeaponBase + m_iEntityQuality, (int)WeaponSkin.EntityQualityIndex);
                    else
                        CylMem.WriteInt(WeaponBase + m_iEntityQuality, 0);
                }
            }
        }
        public static void UpdateSkin()
        {
            if (CylMem.ReadInt(WeaponBase + m_iItemIDHigh) != -1)
                CylMem.WriteInt(WeaponBase + m_iItemIDHigh, -1);
        }
    }
}
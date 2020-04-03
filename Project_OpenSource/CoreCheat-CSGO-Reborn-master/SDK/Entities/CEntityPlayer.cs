using System;
using System.Numerics;
using CoreCheat_Reborn.CheatClasses;
using CoreCheat_Reborn.SDK.Managers;
using CoreCheat_Reborn.SDK.Controllers;
using static CoreCheat_Reborn.CheatClasses.Enums;
using static CoreCheat_Reborn.CheatClasses.Offsets.others;
using static CoreCheat_Reborn.CheatClasses.Offsets.netvars;
using static CoreCheat_Reborn.CheatClasses.Offsets.signatures;

namespace CoreCheat_Reborn.SDK.Entities
{
    class CEntityPlayer
    {
        private static readonly int ChamsPtr = EngineClient.ClientState + model_ambient_min - 0x2C;
        private static readonly int GlowObject = CylMem.ReadInt(Modules.ClientDLLAdress + dwGlowObjectManager);
        public static int GetEntity(int i)
        {
            return CylMem.ReadInt(Modules.ClientDLLAdress + dwEntityList + i * 0x10);
        }
        public static bool isDormant(int entB)
        {
            if (entB > 0)
                return CylMem.ReadBool(entB + m_bDormant);
            else
                return false;
        }
        public static int Health(int entB)
        {
            if(entB > 0)
                return CylMem.ReadInt(entB + m_iHealth);
            else
                return - 1;
        }
        public static Teams Team(int entB)
        {
            if (entB != 0)
            {
                if (CylMem.ReadInt(entB + m_iTeamNum) == (int)Teams.ANTI_TERRORIST)
                    return Teams.ANTI_TERRORIST;
                else if (CylMem.ReadInt(entB + m_iTeamNum) == (int)Teams.NONE)
                    return Teams.NONE;
                else if (CylMem.ReadInt(entB + m_iTeamNum) == (int)Teams.SPECTATOR)
                    return Teams.SPECTATOR;
                else if (CylMem.ReadInt(entB + m_iTeamNum) == (int)Teams.TERRORIST)
                    return Teams.TERRORIST;
                else
                    return Teams.NONE;
            }
            else
            {
                return Teams.NONE;
            }
        }
        public static bool IsScoped(int entB)
        {
            if (entB != 0)
            {
                if (CylMem.ReadInt(entB + m_bIsScoped) == 1)
                    return true;
                else
                    return false;
            }
            else
            {
                if (CylMem.ReadInt(entB + m_bIsScoped) == 1)
                    return true;
                else
                    return false;
            }
        }
        public static string WeaponName(int entB)
        {
            if (entB != 0)
            {
                int ActiveWeapon = CylMem.ReadInt(entB + m_hActiveWeapon) & 0xFFF;
                ActiveWeapon = CylMem.ReadInt(Modules.ClientDLLAdress + dwEntityList + (ActiveWeapon - 1) * 0x10);
                short ActiveWeaponID = CylMem.ReadShort(ActiveWeapon + m_iItemDefinitionIndex);
                return Managers.Parsers.ParseItemName(ActiveWeaponID);
            }
            else
                return Managers.Parsers.ParseItemName(0);
        }
        public static bool IsCloseRangeWeapon(int entB)
        {
            bool output = false;
            if (WeaponName(entB) == "Bump Mine" || WeaponName(entB) == "Bayonet" || WeaponName(entB) == "Flip Knife" || WeaponName(entB) == "Gut Knife" || WeaponName(entB) == "Karambit" || WeaponName(entB) == "M9 Bayonet" || WeaponName(entB) == "Huntsman Knife" || WeaponName(entB) == "Falchion Knife" || WeaponName(entB) == "Bowie Knife" || WeaponName(entB) == "Butterfly Knife" || WeaponName(entB) == "Shadow Daggers" || WeaponName(entB) == "Ursus Knife" || WeaponName(entB) == "Navaja Knife" || WeaponName(entB) == "Stiletto Knife" || WeaponName(entB) == "Talon Knife" || WeaponName(entB) == "Terrorist Knife" || WeaponName(entB) == "Knife" || WeaponName(entB) == "Meele" || WeaponName(entB) == "Axe" || WeaponName(entB) == "Hammer" || WeaponName(entB) == "Wrench" || WeaponName(entB) == "Breach Charge" || WeaponName(entB) == "Hands" || WeaponName(entB) == "Medi-Shot" || WeaponName(entB) == "Defuse Kit" || WeaponName(entB) == "Rescue Kit" || WeaponName(entB) == "Ballistick Shield" || WeaponName(entB) == "KnifeGG" || WeaponName(entB) == "C4 Explosive")
                output = true;
            return output;
        }
        public static bool IsSniperWeapon(int entB)
        {
            bool output = false;
            if (WeaponName(entB) == "AWP" || WeaponName(entB) == "SSG 08" || WeaponName(entB) == "G3SG1" || WeaponName(entB) == "SCAR-20")
                output = true;
            return output;
        }
        public static bool IsHeavyWeapon(int entB)
        {
            bool output = false;
            if (WeaponName(entB) == "M249" || WeaponName(entB) == "Negev")
                output = true;
            return output;
        }
        public static bool IsScopedWeapon(int entB)
        {
            bool output = false;
            if (IsSniperWeapon(entB) || WeaponName(entB) == "SG 553" || WeaponName(entB) == "AUG")
                output = true;
            return output;
        }
        public static bool IsPistolWeapon(int entB)
        {
            bool output = false;
            if (WeaponName(entB) == "Desert Eagle" || WeaponName(entB) == "Dual Barettas" || WeaponName(entB) == "Fives-SeveN" || WeaponName(entB) == "Glock-18" || WeaponName(entB) == "Tec-9" || WeaponName(entB) == "Zeus x27" || WeaponName(entB) == "P2000" || WeaponName(entB) == "P250" || WeaponName(entB) == "USP-S" || WeaponName(entB) == "CZ75-Auto" || WeaponName(entB) == "R8 Revolver" || WeaponName(entB) == "USP-S")
                output = true;
            return output;
        }
        public static bool IsThrowableWeapon(int entB)
        {
            bool output = false;
            if (WeaponName(entB) == "HE Granade" || WeaponName(entB) == "Flashbang" || WeaponName(entB) == "Smoke Granade" || WeaponName(entB) == "Molotov" || WeaponName(entB) == "Decoy Granade" || WeaponName(entB) == "Incendiary Granade" || WeaponName(entB) == "Fire Bomb" || WeaponName(entB) == "Frag Granade" || WeaponName(entB) == "Snowball")
                output = true;
            return output;
        }
        public  static Vector3 Position(int entB)
        {
              return CylMem.CRead<Vector3>(entB+m_vecOrigin);
        }
        public static string LastPlace(int entB)
        {
            if (entB != 0)
            {
                return CylMem.ReadStringASCII(entB + m_szLastPlaceName, 32);
            }
            else
            {
                return CylMem.ReadStringASCII(entB + m_szLastPlaceName, 32);
            }
        }
        public static int ArmorValue(int entB)
        {
            if (entB != 0)
                return CylMem.ReadInt(entB + m_ArmorValue);
            else
                return CylMem.ReadInt(entB + m_ArmorValue);
        }
        public static bool HasHelmet(int entB)
        {
            if (entB != 0)
                return CylMem.ReadBool(entB + m_bHasHelmet);
            else
                return CylMem.ReadBool(entB + m_bHasHelmet);
        }
        public static bool HasArmor(int entB)
        {
            bool temp = false;
            if (ArmorValue(entB) > 0)
                temp = true;
            return temp;
        }
        public static bool HasFullArmor(int entB)
        {
            bool temp = false;
            if (ArmorValue(entB) > 0 && HasHelmet(entB))
                temp = true;
            return temp;
        }
        public static bool isDead(int entB)
        {
            bool temp = false;
            if (entB != 0)
            {
                if (!(Health(entB) > 0))
                    temp = true;
                return temp;
            }
            else
            {
                if (!(Health(entB) > 0))
                    temp = true;
                return temp;
            }
        }
        public static bool isAlive(int entB)
        {
            bool temp = false;
            if (entB != 0)
            {
                if (Health(entB) > 0)
                    temp = true;
                return temp;
            }
            else
            {
                if (Health(entB) > 0)
                    temp = true;
                return temp;
            }
        }
        public static string GetModelName(int entB)
        {
            return CylMem.ReadStringASCII(GetModelIndex(entB) + 0x4, 128);
        }
        private static int GetModelIndex(int entB)
        {
            return CylMem.ReadInt(entB + m_nModelIndex);
        }
        public static void SpotPlayer(int entBase)
        {
            CylMem.WriteBoolean(entBase + m_bSpotted, true);
        }
        public static bool isPlayerSpotted(int entBase)
        {
            return CylMem.ReadBool(entBase+m_bSpottedByMask);
        }
        public static Vector3 GetBonePos(int entB, int bone)
        {
            float x = CylMem.ReadFloat(entB + m_dwBoneMatrix + 0x30 * bone + 0x0C);
            float y = CylMem.ReadFloat(entB + m_dwBoneMatrix + 0x30 * bone + 0x1C);
            float z = CylMem.ReadFloat(entB + m_dwBoneMatrix + 0x30 * bone + 0x2C);

            Vector3 BonePos = new Vector3(x,y,z);
            return BonePos;
        }
        public static void Glow(int GlowIndex, Structs.GlowStruct GlowColor, GlowStyle _GlowStyle, GlowType _GlowType)
        {
            CylMem.WriteFloat(GlowObject + ((GlowIndex * 0x38) + 0x4), GlowColor.r);
            CylMem.WriteFloat(GlowObject + ((GlowIndex * 0x38) + 0x8), GlowColor.g);
            CylMem.WriteFloat(GlowObject + ((GlowIndex * 0x38) + 0xC), GlowColor.b);
            CylMem.WriteFloat(GlowObject + ((GlowIndex * 0x38) + 0x10), GlowColor.a);
            CylMem.WriteInt(GlowObject + ((GlowIndex * 0x38) + 0x2C), (int)_GlowType);
            CylMem.WriteBoolean(GlowObject + ((GlowIndex * 0x38) + 0x24), true);
            CylMem.WriteBoolean(GlowObject + ((GlowIndex * 0x38) + 0x25), false);
            if(_GlowStyle == Enums.GlowStyle.BLOOM)
                CylMem.WriteBoolean(GlowObject + ((GlowIndex * 0x38) + 0x26), true);
        }
        public static void ApplyChams(Structs.ColorStruct ChamsColor, float brightness, int EntBase)
        {
            byte[] bytearray = BitConverter.GetBytes(brightness);
            int intbrightness = BitConverter.ToInt32(bytearray, 0);
            int xored = intbrightness ^ ChamsPtr;
            CylMem.WriteInt(Modules.EngineDLLAdress + model_ambient_min, xored);
            CylMem.WriteByte(EntBase + 0x70, (byte)ChamsColor.r);
            CylMem.WriteByte(EntBase + 0x71, (byte)ChamsColor.g);
            CylMem.WriteByte(EntBase + 0x72, (byte)ChamsColor.b);
        }
        public static void ClearChams(int EntBase)
        {
            byte[] bytearray = BitConverter.GetBytes((float)0);
            int intbrightness = BitConverter.ToInt32(bytearray, 0);
            int xored = intbrightness ^ ChamsPtr;
            CylMem.WriteInt(Modules.EngineDLLAdress + model_ambient_min, xored);
            CylMem.WriteByte(EntBase + 0x70, (byte)255);
            CylMem.WriteByte(EntBase + 0x71, (byte)255);
            CylMem.WriteByte(EntBase + 0x72, (byte)255);
        }
    }
}

using static CoreCheat_Reborn.CheatClasses.Offsets.netvars;
using static CoreCheat_Reborn.CheatClasses.Offsets.signatures;
using static CoreCheat_Reborn.CheatClasses.Offsets.others;
using static CoreCheat_Reborn.CheatClasses.Enums;
using CoreCheat_Reborn.CheatClasses;
using CoreCheat_Reborn.SDK.Controllers;
using CoreCheat_Reborn.SDK.Managers;
using System.Numerics;
using System.Text;
using System;
using CoreCheat_Reborn.Features;

namespace CoreCheat_Reborn.SDK.Entities
{
    class CLocalPlayer
    {
        private static bool IsModelGrabbed = false;
        private static int ViewModelId;
        private static int BaseAdress = 0;
        static void ConfigureLocalPlayer()
        {
            if (BaseAdress == 0)
                BaseAdress = CylMem.ReadInt(Modules.ClientDLLAdress + dwLocalPlayer);
        }
        public static int LocalPlayerBase
        {
            get
            {
                if (BaseAdress != 0)
                    return BaseAdress;
                else
                {
                    ConfigureLocalPlayer();
                    return BaseAdress;
                }
            }
        }
        public static int CrossID
        {
            get
            {
                if (BaseAdress != 0)
                {
                    int temp = CylMem.ReadInt(LocalPlayerBase + m_iCrosshairId);
                    if (temp <= 0 || temp > EngineClient.MaxPlayer)
                        return 0;
                    return temp;
                }
                else
                {
                    ConfigureLocalPlayer();
                    int temp = CylMem.ReadInt(LocalPlayerBase + m_iCrosshairId);
                    if (temp <= 0 || temp > EngineClient.MaxPlayer)
                        return 0;
                    return temp;
                }
            }
        }
        public static int ShootedBullets
        {
            get
            {
                if (BaseAdress != 0)
                    return CylMem.ReadInt(LocalPlayerBase + m_iShotsFired);
                else
                {
                    ConfigureLocalPlayer();
                    return CylMem.ReadInt(LocalPlayerBase + m_iShotsFired);
                }
            }
        }
        public static FlagState Flag
        {
            get
            {
                if (LocalPlayerBase != 0)
                {
                    if (CylMem.ReadInt(LocalPlayerBase + m_fFlags) == (int)FlagState.AIRCROUCH)
                        return FlagState.AIRCROUCH;
                    else if (CylMem.ReadInt(LocalPlayerBase + m_fFlags) == (int)FlagState.AIRMOVING)
                        return FlagState.AIRMOVING;
                    else if (CylMem.ReadInt(LocalPlayerBase + m_fFlags) == (int)FlagState.CROUCHING)
                        return FlagState.CROUCHING;
                    else if (CylMem.ReadInt(LocalPlayerBase + m_fFlags) == (int)FlagState.GROUNDMOVING)
                        return FlagState.GROUNDMOVING;
                    else if (CylMem.ReadInt(LocalPlayerBase + m_fFlags) == (int)FlagState.INPUDDLE)
                        return FlagState.INPUDDLE;
                    else if (CylMem.ReadInt(LocalPlayerBase + m_fFlags) == (int)FlagState.INWATER)
                        return FlagState.INWATER;
                    else if (CylMem.ReadInt(LocalPlayerBase + m_fFlags) == (int)FlagState.ONAIR)
                        return FlagState.ONAIR;
                    else if (CylMem.ReadInt(LocalPlayerBase + m_fFlags) == (int)FlagState.ONGROUND)
                        return FlagState.ONGROUND;
                    else if (CylMem.ReadInt(LocalPlayerBase + m_fFlags) == (int)FlagState.PUDDLECROUCH)
                        return FlagState.PUDDLECROUCH;
                    else if (CylMem.ReadInt(LocalPlayerBase + m_fFlags) == (int)FlagState.TOAIRCROUCH)
                        return FlagState.TOAIRCROUCH;
                    else if (CylMem.ReadInt(LocalPlayerBase + m_fFlags) == (int)FlagState.TOCROUCH)
                        return FlagState.AIRMOVING;
                    else if (CylMem.ReadInt(LocalPlayerBase + m_fFlags) == (int)FlagState.WATERCROUCH)
                        return FlagState.WATERCROUCH;
                    else
                        return FlagState.NULL;

                }
                else
                {
                    ConfigureLocalPlayer();
                    if (CylMem.ReadInt(LocalPlayerBase + m_fFlags) == (int)FlagState.AIRCROUCH)
                        return FlagState.AIRCROUCH;
                    else if (CylMem.ReadInt(LocalPlayerBase + m_fFlags) == (int)FlagState.AIRMOVING)
                        return FlagState.AIRMOVING;
                    else if (CylMem.ReadInt(LocalPlayerBase + m_fFlags) == (int)FlagState.CROUCHING)
                        return FlagState.CROUCHING;
                    else if (CylMem.ReadInt(LocalPlayerBase + m_fFlags) == (int)FlagState.GROUNDMOVING)
                        return FlagState.GROUNDMOVING;
                    else if (CylMem.ReadInt(LocalPlayerBase + m_fFlags) == (int)FlagState.INPUDDLE)
                        return FlagState.INPUDDLE;
                    else if (CylMem.ReadInt(LocalPlayerBase + m_fFlags) == (int)FlagState.INWATER)
                        return FlagState.INWATER;
                    else if (CylMem.ReadInt(LocalPlayerBase + m_fFlags) == (int)FlagState.ONAIR)
                        return FlagState.ONAIR;
                    else if (CylMem.ReadInt(LocalPlayerBase + m_fFlags) == (int)FlagState.ONGROUND)
                        return FlagState.ONGROUND;
                    else if (CylMem.ReadInt(LocalPlayerBase + m_fFlags) == (int)FlagState.PUDDLECROUCH)
                        return FlagState.PUDDLECROUCH;
                    else if (CylMem.ReadInt(LocalPlayerBase + m_fFlags) == (int)FlagState.TOAIRCROUCH)
                        return FlagState.TOAIRCROUCH;
                    else if (CylMem.ReadInt(LocalPlayerBase + m_fFlags) == (int)FlagState.TOCROUCH)
                        return FlagState.AIRMOVING;
                    else if (CylMem.ReadInt(LocalPlayerBase + m_fFlags) == (int)FlagState.WATERCROUCH)
                        return FlagState.WATERCROUCH;
                    else
                        return FlagState.NULL;
                }
            }
        }
        public static int Health
        {
            get
            {
                if (BaseAdress != 0)
                    return CylMem.ReadInt(LocalPlayerBase + m_iHealth);
                else
                {
                    ConfigureLocalPlayer();
                    return CylMem.ReadInt(LocalPlayerBase + m_iHealth);
                }
            }
        }
        public static Teams Team
        {
            get
            {
                if (BaseAdress != 0)
                {
                    if (CylMem.ReadInt(LocalPlayerBase + m_iTeamNum) == (int)Teams.ANTI_TERRORIST)
                        return Teams.ANTI_TERRORIST;
                    else if (CylMem.ReadInt(LocalPlayerBase + m_iTeamNum) == (int)Teams.NONE)
                        return Teams.NONE;
                    else if (CylMem.ReadInt(LocalPlayerBase + m_iTeamNum) == (int)Teams.SPECTATOR)
                        return Teams.SPECTATOR;
                    else if (CylMem.ReadInt(LocalPlayerBase + m_iTeamNum) == (int)Teams.TERRORIST)
                        return Teams.TERRORIST;
                    else
                        return Teams.NONE;
                }
                else
                {
                    ConfigureLocalPlayer();
                    if (CylMem.ReadInt(LocalPlayerBase + m_iTeamNum) == (int)Teams.ANTI_TERRORIST)
                        return Teams.ANTI_TERRORIST;
                    else if (CylMem.ReadInt(LocalPlayerBase + m_iTeamNum) == (int)Teams.NONE)
                        return Teams.NONE;
                    else if (CylMem.ReadInt(LocalPlayerBase + m_iTeamNum) == (int)Teams.SPECTATOR)
                        return Teams.SPECTATOR;
                    else if (CylMem.ReadInt(LocalPlayerBase + m_iTeamNum) == (int)Teams.TERRORIST)
                        return Teams.TERRORIST;
                    else
                        return Teams.NONE;
                }
            }
        }
        public static bool IsPlaying
        {
            get
            {
                bool output = false;
                if (EngineClient.ClientState != 0)
                    if (EngineClient.GameState == GameState.FULL)
                        output = true;
                    else
                    {
                        EngineClient.ConfigureClientState();
                        if (EngineClient.GameState == GameState.FULL)
                            output = true;
                    }
                return output;
            }
        }
        public static string Name
        {
            get
            {
                //var sexyInfo = CylMem.ReadInt(EngineClient.ClientState + dwClientState_PlayerInfo);
                //sexyInfo = CylMem.ReadInt(sexyInfo + 0x40);
                //sexyInfo = CylMem.ReadInt(sexyInfo + 0xC);
                //sexyInfo = CylMem.ReadInt(sexyInfo + 0x28 + ((1 - 1) * 0x34));
                //return CylMem.ReadString(sexyInfo);
                int radarBasePtr = 0x78;
                int radarStructSize = 0x174;
                int radarStructPos = 0x18;
                int radarBase = CylMem.ReadInt(Modules.ClientDLLAdress + dwRadarBase);
                int radarPtr = CylMem.ReadInt(radarBase + radarBasePtr);
                int a = CylMem.ReadInt(Modules.ClientDLLAdress + dwClientState);
                int ind = CylMem.ReadInt(a + dwClientState_GetLocalPlayer) + 1;
                var nameAddr = radarPtr + ind * radarStructSize + radarStructPos;
                return CylMem.ReadString(nameAddr);
            }
        }
        public static bool Scoped
        {
            get
            {
                return CylMem.ReadBool(LocalPlayerBase + m_bIsScoped);
            }
            set
            {
                for (int i = 0; i < 1000; i++)
                    CylMem.WriteBoolean(LocalPlayerBase + m_bIsScoped, value);
            }
        }
        public static ScopeLevels ScopeLevel
        {
            get
            {
                if (BaseAdress != 0)
                {
                    int ActiveWeapon = CylMem.ReadInt(LocalPlayerBase + m_hActiveWeapon) & 0xFFF;
                    ActiveWeapon = CylMem.ReadInt(Modules.ClientDLLAdress + dwEntityList + (ActiveWeapon - 1) * 0x10);
                    if (CylMem.ReadInt(ActiveWeapon + m_zoomLevel) != 256)
                        return (ScopeLevels)CylMem.ReadInt(ActiveWeapon + m_zoomLevel);
                    else
                        return ScopeLevels.NOTSCOPED;
                    
                }
                else
                {
                    ConfigureLocalPlayer();
                    int ActiveWeapon = CylMem.ReadInt(LocalPlayerBase + m_hActiveWeapon) & 0xFFF;
                    ActiveWeapon = CylMem.ReadInt(Modules.ClientDLLAdress + dwEntityList + (ActiveWeapon - 1) * 0x10);
                    if (CylMem.ReadInt(ActiveWeapon + m_zoomLevel) != 256)
                        return (ScopeLevels)CylMem.ReadInt(ActiveWeapon + m_zoomLevel);
                    else
                        return ScopeLevels.NOTSCOPED;
                }
            }
            set
            {
                if (BaseAdress != 0)
                {
                    int ActiveWeapon = CylMem.ReadInt(LocalPlayerBase + m_hActiveWeapon) & 0xFFF;
                    ActiveWeapon = CylMem.ReadInt(Modules.ClientDLLAdress + dwEntityList + (ActiveWeapon - 1) * 0x10);
                    CylMem.WriteInt(ActiveWeapon + m_zoomLevel, (int)value);
                }
                else
                {
                    ConfigureLocalPlayer();
                    int ActiveWeapon = CylMem.ReadInt(LocalPlayerBase + m_hActiveWeapon) & 0xFFF;
                    ActiveWeapon = CylMem.ReadInt(Modules.ClientDLLAdress + dwEntityList + (ActiveWeapon - 1) * 0x10);
                    CylMem.WriteInt(ActiveWeapon + m_zoomLevel, (int)value);
                }
            }
        }
        public static string WeaponName
        {
            get
            {
                if (BaseAdress != 0)
                {
                    int ActiveWeapon = CylMem.ReadInt(LocalPlayerBase + m_hActiveWeapon) & 0xFFF;
                    ActiveWeapon = CylMem.ReadInt(Modules.ClientDLLAdress + dwEntityList + (ActiveWeapon - 1) * 0x10);
                    short ActiveWeaponID = CylMem.ReadShort(ActiveWeapon + m_iItemDefinitionIndex);
                    return Managers.Parsers.ParseItemName(ActiveWeaponID);
                }
                else
                {
                    ConfigureLocalPlayer();
                    int ActiveWeapon = CylMem.ReadInt(LocalPlayerBase + m_hActiveWeapon) & 0xFFF;
                    ActiveWeapon = CylMem.ReadInt(Modules.ClientDLLAdress + dwEntityList + (ActiveWeapon - 1) * 0x10);
                    short ActiveWeaponID = CylMem.ReadShort(ActiveWeapon + m_iItemDefinitionIndex);
                    return Managers.Parsers.ParseItemName(ActiveWeaponID);
                }
            }
        }
        public static bool IsCloseRangeWeapon
        {
            get
            {
                bool output = false;
                if (WeaponName == "Bump Mine" || WeaponName == "Bayonet" || WeaponName == "Flip Knife" || WeaponName == "Gut Knife" || WeaponName == "Karambit" || WeaponName == "M9 Bayonet" || WeaponName == "Huntsman Knife" || WeaponName == "Falchion Knife" || WeaponName == "Bowie Knife" || WeaponName == "Butterfly Knife" || WeaponName == "Shadow Daggers" || WeaponName == "Ursus Knife" || WeaponName == "Navaja Knife" || WeaponName == "Stiletto Knife" || WeaponName == "Talon Knife" || WeaponName == "Terrorist Knife" || WeaponName == "Knife" || WeaponName == "Meele" || WeaponName == "Axe" || WeaponName == "Hammer" || WeaponName == "Wrench" || WeaponName == "Breach Charge" || WeaponName == "Hands" || WeaponName == "Medi-Shot" || WeaponName == "Defuse Kit" || WeaponName == "Rescue Kit" || WeaponName == "Ballistick Shield" || WeaponName == "KnifeGG" || WeaponName == "C4 Explosive")
                    output = true;
                return output;
            }
        }
        public static bool IsSniperWeapon
        {
            get
            {
                bool output = false;
                if (WeaponName == "AWP" || WeaponName == "SSG 08" || WeaponName == "G3SG1" || WeaponName == "SCAR-20")
                    output = true;
                return output;
            }
        }
        public static bool IsHeavyWeapon
        {
            get
            {
                bool output = false;
                if (WeaponName == "M249" || WeaponName == "Negev")
                    output = true;
                return output;
            }
        }
        public static bool IsScopedWeapon
        {
            get
            {
                bool output = false;
                if (IsSniperWeapon || WeaponName == "SG 553" || WeaponName == "AUG")
                    output = true;
                return output;
            }

        }
        public static bool IsPistolWeapon
        {
            get
            {
                bool output = false;
                if (WeaponName == "Desert Eagle" || WeaponName == "Dual Barettas" || WeaponName == "Fives-SeveN" || WeaponName == "Glock-18" || WeaponName == "Tec-9" || WeaponName == "Zeus x27" || WeaponName == "P2000" || WeaponName == "P250" || WeaponName == "USP-S" || WeaponName == "CZ75-Auto" || WeaponName == "R8 Revolver" || WeaponName == "USP-S")
                    output = true;
                return output;
            }
        }
        public static bool IsThrowableWeapon
        {
            get
            {
                bool output = false;
                if (WeaponName == "HE Granade" || WeaponName == "Flashbang" || WeaponName == "Smoke Granade" || WeaponName == "Molotov" || WeaponName == "Decoy Granade" || WeaponName == "Incendiary Granade" || WeaponName == "Fire Bomb" || WeaponName == "Frag Granade" || WeaponName == "Snowball")
                    output = true;
                return output;
            }
        }
        private static int ModelIndex
        {
            get
            {
                if (BaseAdress != 0)
                {
                    return CylMem.ReadInt(LocalPlayerBase + m_nModelIndex);
                }
                else
                {
                    ConfigureLocalPlayer();
                    return CylMem.ReadInt(LocalPlayerBase + m_nModelIndex);
                }
            }
        }
        public static void RemoveHands()
        {
            if (!IsModelGrabbed)
            {
                ViewModelId = ModelIndex;
                IsModelGrabbed = true;
            }
            if (ModelIndex != (int)ViewModel.NOMODEL)
                CylMem.WriteInt(LocalPlayerBase + m_nModelIndex, (int)ViewModel.NOMODEL);
        }
        public static void AddHands()
        {
            if (BaseAdress != 0)
                if (ModelIndex == (int)ViewModel.NOMODEL)
                {
                    CylMem.WriteInt(LocalPlayerBase + m_nModelIndex, ViewModelId);
                    IsModelGrabbed = false;
                }
                else
                {
                    ConfigureLocalPlayer();
                    if (ModelIndex == (int)ViewModel.NOMODEL)
                    {
                        CylMem.WriteInt(LocalPlayerBase + m_nModelIndex, ViewModelId);
                        IsModelGrabbed = false;
                    }
                }
        }
        public static SpectatorView ViewMode
        {
            get
            {
                if (BaseAdress != 0)
                {
                    return (SpectatorView)CylMem.ReadInt(LocalPlayerBase + m_iObserverMode);
                }
                else
                {
                    ConfigureLocalPlayer();
                    return (SpectatorView)CylMem.ReadInt(LocalPlayerBase + m_iObserverMode);
                }

            }
            set
            {
                if (BaseAdress != 0)
                    CylMem.WriteInt(LocalPlayerBase + m_iObserverMode, (int)value);
                else
                {
                    ConfigureLocalPlayer();
                    CylMem.WriteInt(LocalPlayerBase + m_iObserverMode, (int)value);
                }
            }
        }
        public static string LastPlace
        {
            get
            {
                if (BaseAdress != 0)
                    return CylMem.ReadString(LocalPlayerBase + m_szLastPlaceName);
                else
                {
                    ConfigureLocalPlayer();
                    return CylMem.ReadString(LocalPlayerBase + m_szLastPlaceName);
                }
            }
        }
        public static int TotalHits
        {
            get
            {
                if (BaseAdress != 0)
                    return CylMem.ReadInt(LocalPlayerBase + m_totalHitsOnServer);
                else
                {
                    ConfigureLocalPlayer();
                    return CylMem.ReadInt(LocalPlayerBase + m_totalHitsOnServer);
                }
            }
        }
        public static float HealthShotBoostTime
        {
            get
            {
                if (BaseAdress != 0)
                    return CylMem.ReadFloat(LocalPlayerBase + m_flHealthShotBoostExpirationTime);
                else
                {
                    ConfigureLocalPlayer();
                    return CylMem.ReadFloat(LocalPlayerBase + m_flHealthShotBoostExpirationTime);
                }
            }
            set
            {
                if (BaseAdress != 0)
                    CylMem.WriteFloat(LocalPlayerBase + m_flHealthShotBoostExpirationTime, EngineClient.GameTick + (float)value);
            }
        }
        public static int ArmorValue
        {
            get
            {
                if (BaseAdress != 0)
                    return CylMem.ReadInt(LocalPlayerBase + m_ArmorValue);
                else
                {
                    ConfigureLocalPlayer();
                    return CylMem.ReadInt(LocalPlayerBase + m_ArmorValue);
                }
            }
        }
        public static bool HasHelmet
        {
            get
            {
                if (BaseAdress != 0)
                    return CylMem.ReadBool(LocalPlayerBase + m_bHasHelmet);
                else
                {
                    ConfigureLocalPlayer();
                    return CylMem.ReadBool(LocalPlayerBase + m_bHasHelmet);
                }
            }
        }
        public static bool HasArmor
        {
            get
            {
                bool temp = false;
                if (ArmorValue > 0)
                    temp = true;
                return temp;
            }
        }
        public static bool HasFullArmor
        {
            get
            {
                bool temp = false;
                if (ArmorValue > 0 && HasHelmet)
                    temp = true;
                return temp;
            }
        }
        public static bool isDead
        {
            get
            {
                if (BaseAdress != 0)
                {
                    bool temp = false;
                    if (!(Health > 0))
                        temp = true;
                    return temp;
                }
                else
                {
                    ConfigureLocalPlayer();
                    bool temp = false;
                    if (!(Health > 0))
                        temp = true;
                    return temp;
                }
            }
        }
        public static bool isAlive
        {
            get
            {
                if (BaseAdress != 0)
                {
                    bool temp = false;
                    if (Health > 0)
                        temp = true;
                    return temp;
                }
                else
                {
                    ConfigureLocalPlayer();
                    bool temp = false;
                    if (Health > 0)
                        temp = true;
                    return temp;
                }
            }
        }
        public static Vector3 Position
        {
            get
            {
                if (BaseAdress != 0)
                    return CylMem.CRead<Vector3>(LocalPlayerBase + m_vecOrigin);
                else
                {
                    ConfigureLocalPlayer();
                    return CylMem.CRead<Vector3>(LocalPlayerBase + m_vecOrigin);
                }
            }
        }
        public static Vector3 ViewAngles
        {
            get
            {
                if (BaseAdress != 0)
                    return CylMem.CRead<Vector3>(EngineClient.ClientState + dwClientState_ViewAngles);
                else
                {
                    ConfigureLocalPlayer();
                    return CylMem.CRead<Vector3>(EngineClient.ClientState + dwClientState_ViewAngles);
                }
            }
            set
            {
                if (BaseAdress != 0)
                    CylMem.CWrite<Vector3>(EngineClient.ClientState + dwClientState_ViewAngles, value);
                else
                {
                    ConfigureLocalPlayer();
                    CylMem.CWrite<Vector3>(EngineClient.ClientState + dwClientState_ViewAngles, value);
                }
            }
        }
        public static Matrix4x4 ViewMatrix
        {
            get
            {
                if (BaseAdress != 0)
                    return CylMem.CRead<Matrix4x4>(Modules.ClientDLLAdress + dwViewMatrix);
                else
                {
                    ConfigureLocalPlayer();
                    return CylMem.CRead<Matrix4x4>(Modules.ClientDLLAdress + dwViewMatrix);
                }
            }
            set
            {
                if (BaseAdress != 0)
                    CylMem.CWrite<Matrix4x4>(Modules.ClientDLLAdress + dwViewMatrix, value);
                else
                {
                    ConfigureLocalPlayer();
                    CylMem.CWrite<Matrix4x4>(Modules.ClientDLLAdress + dwViewMatrix, value);
                }
            }
        }
        public static Vector3 VectorOrigin
        {
            get
            {
                if (BaseAdress != 0)
                    return CylMem.CRead<Vector3>(LocalPlayerBase + m_vecOrigin);
                else
                {
                    ConfigureLocalPlayer();
                    return CylMem.CRead<Vector3>(LocalPlayerBase + m_vecOrigin);
                }
            }
        }
        public static Vector3 VectorEyeLevel
        {
            get
            {
                if (BaseAdress != 0)
                    return VectorOrigin + CylMem.CRead<Vector3>(LocalPlayerBase + m_vecViewOffset);
                else
                {
                    ConfigureLocalPlayer();
                    return VectorOrigin + CylMem.CRead<Vector3>(LocalPlayerBase + m_vecViewOffset);
                }
            }
        }
        public static Vector3 AimPunchAngles
        {
            get
            {
                if (BaseAdress != 0)
                    return CylMem.CRead<Vector3>(CLocalPlayer.LocalPlayerBase + m_aimPunchAngle);
                else
                {
                    ConfigureLocalPlayer();
                    return CylMem.CRead<Vector3>(CLocalPlayer.LocalPlayerBase + m_aimPunchAngle);
                }
            }
            set
            {
                if (BaseAdress != 0)
                    CylMem.CWrite<Vector3>(EngineClient.ClientState + m_aimPunchAngle, value);
                else
                {
                    ConfigureLocalPlayer();
                    CylMem.CWrite<Vector3>(EngineClient.ClientState + m_aimPunchAngle, value);
                }
            }
        }
        private static float FlashMaxAlpha
        {
            get
            {
                if (BaseAdress != 0)
                    return CylMem.ReadInt(LocalPlayerBase + m_flFlashMaxAlpha);
                else
                {
                    ConfigureLocalPlayer();
                    return CylMem.ReadInt(LocalPlayerBase + m_flFlashMaxAlpha);
                }
            }
            set
            {
                if (BaseAdress != 0)
                    CylMem.WriteFloat(LocalPlayerBase + m_flFlashMaxAlpha, (float)value);
                else
                {
                    ConfigureLocalPlayer();
                    CylMem.WriteFloat(LocalPlayerBase + m_flFlashMaxAlpha, (float)value);
                }
            }
        }
        public static int FOV
        {
            get
            {
                if (BaseAdress != 0)
                    return CylMem.ReadInt(LocalPlayerBase + m_iDefaultFOV);
                else
                {
                    ConfigureLocalPlayer();
                    return CylMem.ReadInt(LocalPlayerBase + m_iDefaultFOV);
                }
            }
            set
            {
                if (BaseAdress != 0)
                    CylMem.WriteInt(LocalPlayerBase + m_iDefaultFOV, value);
                else
                {
                    ConfigureLocalPlayer();
                    CylMem.WriteInt(LocalPlayerBase + m_iDefaultFOV, value);
                }
            }
        }
        public static int ViewModelFOV
        {
            get
            {
                if (BaseAdress != 0)
                    return CylMem.ReadInt(LocalPlayerBase + m_iFOV);
                else
                {
                    ConfigureLocalPlayer();
                    return CylMem.ReadInt(LocalPlayerBase + m_iFOV);
                }
            }
            set
            {
                if(BaseAdress != 0)
                {
                    CylMem.WriteInt(LocalPlayerBase + m_iFOV, value);
                }
                else
                {
                    ConfigureLocalPlayer();
                    CylMem.WriteInt(LocalPlayerBase + m_iFOV, value);
                }
            }
        }
        public static void RemoveFlash()
        {
            if (FlashMaxAlpha > 0)
                FlashMaxAlpha = 0f;
        }
        public static void AddFlash()
        {
            if (FlashMaxAlpha <= 0)
                FlashMaxAlpha = 255.0f;
        }
        public static void Shoot(int time)
        {
            if (IsPlaying)
            {
                Methods.mouse_event((int)ShootState.SHOOT + 1, 0, 0, 0, 1);
                Methods.Wait(time);
                Methods.mouse_event((int)ShootState.STOP, 0, 0, 0, 1);
            }
        }
        public static void ShootWithPointer(int time)
        {
            if (IsPlaying)
            {
                CylMem.WriteInt(Modules.ClientDLLAdress + dwForceAttack, (int)ShootState.SHOOT);
                Methods.Wait(time);
                CylMem.WriteInt(Modules.ClientDLLAdress + dwForceAttack, (int)ShootState.STOP);
            }
        }
        public static void Jump()
        {
            if (IsPlaying)
                CylMem.WriteInt(Modules.ClientDLLAdress + dwForceJump, (int)MoveState.MAKEMOVE);
        }
        public static void GoLeft()
        {
            if (IsPlaying)
                CylMem.WriteInt(Modules.ClientDLLAdress + dwForceLeft, (int)MoveState.MAKEMOVE);
        }
        public static void GoRight()
        {
            if (IsPlaying)
                CylMem.WriteInt(Modules.ClientDLLAdress + dwForceRight, (int)MoveState.MAKEMOVE);
        }
        public static void SetClantag(string Tag, string Name)
        {
            uint a = 0;
            byte[] tagData = Encoding.UTF8.GetBytes(Tag),
                nameData = Encoding.UTF8.GetBytes(Name);
            int tagSize = Math.Min(tagData.Length, 15),
                nameSize = Math.Min(nameData.Length, 15),
                codeSize = ClanTagChanger.shellCode.Length - 32,
                allocateSize = codeSize + tagSize + nameSize + 2;
            IntPtr codeAddress = CylMem.NativeMethods.VirtualAllocEx(CylMem.ProcessHandle, IntPtr.Zero, (IntPtr)allocateSize, (uint)CylMem.FreeType.Commit | (uint)CylMem.FreeType.Reserve, (uint)CylMem.MemoryProtection.ExecuteReadWrite);
            int tagAddress = (int)codeAddress + codeSize;
            int nameAddress = tagAddress + tagSize + 1;
            Buffer.BlockCopy(BitConverter.GetBytes(dwSetClanTag + Modules.EngineDLLAdress), 0, ClanTagChanger.shellCode, 3 + 1, 4);
            Buffer.BlockCopy(BitConverter.GetBytes(tagAddress), 0, ClanTagChanger.shellCode, 3 + 5 + 1, 4);
            Buffer.BlockCopy(BitConverter.GetBytes(nameAddress), 0, ClanTagChanger.shellCode, 3 + 5 + 5 + 1, 4);
            Buffer.BlockCopy(tagData, 0, ClanTagChanger.shellCode, codeSize, tagSize);
            Buffer.BlockCopy(nameData, 0, ClanTagChanger.shellCode, codeSize + tagSize + 1, nameSize);
            CylMem.NativeMethods.WriteProcessMemory(CylMem.ProcessHandle, codeAddress, ClanTagChanger.shellCode, (IntPtr)allocateSize, ref a);
            IntPtr hThread = CylMem.NativeMethods.CreateRemoteThread(CylMem.ProcessHandle, IntPtr.Zero, IntPtr.Zero, codeAddress, IntPtr.Zero, 0, IntPtr.Zero);
            CylMem.NativeMethods.WaitForSingleObject(hThread, 0xFFFFFFFF);
            CylMem.NativeMethods.VirtualFreeEx(CylMem.ProcessHandle, codeAddress, IntPtr.Zero, CylMem.FreeType.Release);
        }
    }
}

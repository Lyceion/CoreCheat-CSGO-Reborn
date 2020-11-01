using CoreCheat_Reborn.SDK.Managers;
using CoreCheat_Reborn.SDK.Controllers;
using static CoreCheat_Reborn.CheatClasses.Offsets.signatures;
using static CoreCheat_Reborn.CheatClasses.Offsets.netvars;

namespace CoreCheat_Reborn.OffsetUpdater
{
    public partial class Updater : MetroFramework.Forms.MetroForm
    {
        public Updater()
        {
            InitializeComponent();
        }
        private void Updater_Load(object sender, System.EventArgs e)
        {
            ScanAllPatterns();
            GetNetvars();
        }
        public static void ScanAllPatterns()
        {
            dwClientCmd = SigScan.ScanPatterna(Modules.EngineDLLName, "55 8B EC 8B 0D ? ? ? ? 81 F9 ? ? ? ? 75 0C A1 ? ? ? ? 35 ? ? ? ? EB 05 8B 01 FF 50 34 50 A1").ToInt32() - Modules.EngineDLLAdress;
            dwClientState = SigScan.ScanPattern(Modules.EngineDLLName, "A1 ? ? ? ? 33 D2 6A 00 6A 00 33 C9 89 B0", 1, 0, true);
            dwClientState_GetLocalPlayer = SigScan.ScanPattern(Modules.EngineDLLName, "8B 80 ? ? ? ? 40 C3", 2, 0, false);
            dwClientState_IsHLTV = SigScan.ScanPattern(Modules.EngineDLLName, "80 BF ? ? ? ? ? 0F 84 ? ? ? ? 32 DB", 2, 0, false);
            dwClientState_Map = SigScan.ScanPattern(Modules.EngineDLLName, "05 ? ? ? ? C3 CC CC CC CC CC CC CC A1", 1, 0, false);
            dwClientState_MapDirectory = SigScan.ScanPattern(Modules.EngineDLLName, "05 ? ? ? ? C3 CC CC CC CC CC CC CC 80 3D", 1, 0, false);
            dwClientState_MaxPlayer = SigScan.ScanPattern(Modules.EngineDLLName, "A1 ? ? ? ? 8B 80 ? ? ? ? C3 CC CC CC CC 55 8B EC 8A 45 08", 7, 0, false);
            dwClientState_PlayerInfo = SigScan.ScanPattern(Modules.EngineDLLName, "8B 89 ? ? ? ? 85 C9 0F 84 ? ? ? ? 8B 01", 2, 0, false);
            dwClientState_State = SigScan.ScanPattern(Modules.EngineDLLName, "83 B8 ? ? ? ? ? 0F 94 C0 C3", 2, 0, false);
            dwClientState_ViewAngles = SigScan.ScanPattern(Modules.EngineDLLName, "F3 0F 11 80 ? ? ? ? D9 46 04 D9 05", 4, 0, false);
            clientstate_delta_ticks = SigScan.ScanPattern(Modules.EngineDLLName, "C7 87 ? ? ? ? ? ? ? ? FF 15 ? ? ? ? 83 C4 08", 2, 0, true);
            clientstate_last_outgoing_command = SigScan.ScanPattern(Modules.EngineDLLName, "8B 8F ? ? ? ? 8B 87 ? ? ? ? 41", 2, 0, true);
            clientstate_choked_commands = SigScan.ScanPattern(Modules.EngineDLLName, "8B 87 ? ? ? ? 41", 2, 0, true);
            clientstate_net_channel = SigScan.ScanPattern(Modules.EngineDLLName, "8B 8F ? ? ? ? 8B 01 8B 40 18", 2, 0, true);
            dwEntityList = SigScan.ScanPattern(Modules.ClientDLLName, "BB ? ? ? ? 83 FF 01 0F 8C ? ? ? ? 3B F8", 1, 0, true);
            dwForceAttack = SigScan.ScanPattern(Modules.ClientDLLName, "89 0D ? ? ? ? 8B 0D ? ? ? ? 8B F2 8B C1 83 CE 04", 2, 0, true);
            dwForceAttack2 = SigScan.ScanPattern(Modules.ClientDLLName, "89 0D ? ? ? ? 8B 0D ? ? ? ? 8B F2 8B C1 83 CE 04", 2, 12, true);
            dwForceBackward = SigScan.ScanPattern(Modules.ClientDLLName, "55 8B EC 51 53 8A 5D 08", 287, 0, true);
            dwForceForward = SigScan.ScanPattern(Modules.ClientDLLName, "55 8B EC 51 53 8A 5D 08", 245, 0, true);
            dwForceJump = SigScan.ScanPattern(Modules.ClientDLLName, "8B 0D ? ? ? ? 8B D6 8B C1 83 CA 02", 2, 0, true);
            dwForceLeft = SigScan.ScanPattern(Modules.ClientDLLName, "55 8B EC 51 53 8A 5D 08", 465, 0, true);
            dwForceRight = SigScan.ScanPattern(Modules.ClientDLLName, "55 8B EC 51 53 8A 5D 08", 512, 0, true);
            dwGameDir = SigScan.ScanPattern(Modules.EngineDLLName, "68 ? ? ? ? 8D 85 ? ? ? ? 50 68 ? ? ? ? 68", 1, 0, true);
            dwGameRulesProxy = SigScan.ScanPattern(Modules.ClientDLLName, "A1 ? ? ? ? 85 C0 0F 84 ? ? ? ? 80 B8 ? ? ? ? ? 74 7A", 1, 0, true);
            dwGetAllClasses = SigScan.ScanPattern(Modules.ClientDLLName, "A1 ? ? ? ? C3 CC CC CC CC CC CC CC CC CC CC A1 ? ? ? ? B9", 1 ,0 ,true);
            dwGlobalVars = SigScan.ScanPattern(Modules.EngineDLLName, "68 ? ? ? ? 68 ? ? ? ? FF 50 08 85 C0", 1, 0, true);
            dwGlowObjectManager = SigScan.ScanPattern(Modules.ClientDLLName, "A1 ? ? ? ? A8 01 75 4B", 1, 4, true);
            dwInput = SigScan.ScanPattern(Modules.ClientDLLName, "B9 ? ? ? ? F3 0F 11 04 24 FF 50 10", 1, 0, true);
            dwInterfaceLinkList = SigScan.ScanPattern(Modules.ClientDLLName, "8B 35 ? ? ? ? 57 85 F6 74 ? 8B 7D 08 8B 4E 04 8B C7 8A 11 3A 10");
            dwLocalPlayer = SigScan.ScanPattern(Modules.ClientDLLName, "8D 34 85 ? ? ? ? 89 15 ? ? ? ? 8B 41 08 8B 48 04 83 F9 FF", 3, 4, true); 
            dwMouseEnable = SigScan.ScanPattern(Modules.ClientDLLName, "B9 ? ? ? ? FF 50 34 85 C0 75 10", 1, 48, true);
            dwMouseEnablePtr = SigScan.ScanPattern(Modules.ClientDLLName, "B9 ? ? ? ? FF 50 34 85 C0 75 10", 1, 0, true);
            dwPlayerResource = SigScan.ScanPattern(Modules.ClientDLLName, "8B 3D ? ? ? ? 85 FF 0F 84 ? ? ? ? 81 C7", 2, 0, true);
            dwRadarBase = SigScan.ScanPattern(Modules.ClientDLLName, "A1 ? ? ? ? 8B 0C B0 8B 01 FF 50 ? 46 3B 35 ? ? ? ? 7C EA 8B 0D", 1, 0, true);
            dwSensitivity = SigScan.ScanPattern(Modules.ClientDLLName, "81 F9 ? ? ? ? 75 1D F3 0F 10 05 ? ? ? ? F3 0F 11 44 24 ? 8B 44 24 18 35 ? ? ? ? 89 44 24 0C EB 0B", 2, 44, true);
            dwSensitivityPtr = SigScan.ScanPattern(Modules.ClientDLLName, "81 F9 ? ? ? ? 75 1D F3 0F 10 05 ? ? ? ? F3 0F 11 44 24 ? 8B 44 24 18 35 ? ? ? ? 89 44 24 0C EB 0B", 2, 0, true);
            dwSetClanTag = SigScan.ScanPatterna(Modules.EngineDLLName, "53 56 57 8B DA 8B F9 FF 15").ToInt32() - Modules.EngineDLLAdress;
            dwViewMatrix = SigScan.ScanPattern(Modules.ClientDLLName, "0F 10 05 ? ? ? ? 8D 85 ? ? ? ? B9", 3, 176, false);
            dwWeaponTable = SigScan.ScanPattern(Modules.ClientDLLName, "B9 ? ? ? ? 6A 00 FF 50 08 C3", 1, 0, true);
            dwWeaponTableIndex = SigScan.ScanPattern(Modules.ClientDLLName, "39 86 ? ? ? ? 74 06 89 86 ? ? ? ? 8B 86", 2, 0, true);
            dwYawPtr = SigScan.ScanPattern(Modules.ClientDLLName, "81 F9 ? ? ? ? 75 1D F3 0F 10 05 ? ? ? ? F3 0F 11 44 24 ? 8B 44 24 1C 35 ? ? ? ? 89 44 24 18 EB 0B 8B 01 8B 40 30 FF D0 D9 5C 24 18 F3 0F 10 06", 2, 0, true);
            dwZoomSensitivityRatioPtr = SigScan.ScanPattern(Modules.ClientDLLName, "81 F9 ? ? ? ? 75 1A F3 0F 10 05 ? ? ? ? F3 0F 11 45 ? 8B 45 F4 35 ? ? ? ? 89 45 FC EB 0A 8B 01 8B 40 30 FF D0 D9 5D FC A1", 2, 0, true);
            dwbSendPackets = SigScan.ScanPattern(Modules.EngineDLLName, "B3 01 8B 01 8B 40 10 FF D0 84 C0 74 0F 80 BF ? ? ? ? ? 0F 84", 0, 1, true);
            dwppDirect3DDevice9 = SigScan.ScanPattern(Modules.ShaderAPIName, "8B 3D ? ? ? ? 85 FF 0F 84 ? ? ? ? 81 C7", 2, 0, true);
            m_pStudioHdr = SigScan.ScanPattern(Modules.ClientDLLName, "8B B6 ? ? ? ? 85 F6 74 05 83 3E 00 75 02 33 F6 F3 0F 10 44 24", 2, 0, true);
            m_yawClassPtr = SigScan.ScanPattern(Modules.ClientDLLName, "81 F9 ? ? ? ? 75 16 F3 0F 10 05 ? ? ? ? F3 0F 11 45 ? 81 75 ? ? ? ? ? EB 0A 8B 01 8B 40 30 FF D0 D9 5D 0C 8B 55 08", 2, 0, true);
            m_pitchClassPtr = SigScan.ScanPattern(Modules.ClientDLLName, "A1 ? ? ? ? 89 74 24 28", 1, 0, true);
            interface_engine_cvar = SigScan.ScanPattern(Modules.VSTDLibDLLName, "8B 0D ? ? ? ? C7 05", 2, 0, true);
            convar_name_hash_table = SigScan.ScanPattern(Modules.VSTDLibDLLName, "8B 3C 85", 3, 0, true);
            m_bDormant = SigScan.ScanPattern(Modules.ClientDLLName, "8A 81 ? ? ? ? C3 32 C0", 2, 8, false);
            model_ambient_min = SigScan.ScanPattern(Modules.EngineDLLName, "F3 0F 10 0D ? ? ? ? F3 0F 11 4C 24 ? 8B 44 24 20 35 ? ? ? ? 89 44 24 0C", 4, 0, true);
            set_abs_angles = SigScan.ScanPatterna(Modules.ClientDLLName, "55 8B EC 83 E4 F8 83 EC 64 53 56 57 8B F1 E8").ToInt32() - Modules.EngineDLLAdress;
            set_abs_origin = SigScan.ScanPatterna(Modules.ClientDLLName, "55 8B EC 83 E4 F8 51 53 56 57 8B F1 E8").ToInt32() - Modules.EngineDLLAdress;
            is_c4_owner = SigScan.ScanPatterna(Modules.ClientDLLName, "56 8B F1 85 F6 74 31").ToInt32() - Modules.EngineDLLAdress;
            force_update_spectator_glow = SigScan.ScanPatterna(Modules.ClientDLLName, "74 07 8B CB E8 ? ? ? ? 83 C7 10").ToInt32() - Modules.EngineDLLAdress;
            anim_overlays = SigScan.ScanPattern(Modules.ClientDLLName, "8B 89 ? ? ? ? 8D 0C D1", 2, 0, true);
            m_flSpawnTime = SigScan.ScanPattern(Modules.ClientDLLName, "89 86 ? ? ? ? E8 ? ? ? ? 80 BE ? ? ? ? ?", 2, 0, true);
            find_hud_element = SigScan.ScanPatterna(Modules.ClientDLLName, "8B 3D ? ? ? ? 85 FF 0F 84 ? ? ? ? 81 C7").ToInt32() - Modules.EngineDLLAdress;
        }
        public static void GetNetvars()
        {
            NetvarManager.Init();
            m_vecViewOffset = NetvarManager.Table["DT_CSPlayer"]["m_vecViewOffset[0]"];
            m_vecOrigin = NetvarManager.Table["DT_CSPlayer"]["m_vecOrigin"];
            m_szLastPlaceName = NetvarManager.Table["DT_CSPlayer"]["m_szLastPlaceName"];
            m_szCustomName = NetvarManager.Table["DT_WeaponCSBaseGun"]["m_szCustomName"];
            m_OriginalOwnerXuidHigh = NetvarManager.Table["DT_WeaponCSBaseGun"]["m_OriginalOwnerXuidHigh"];
            m_OriginalOwnerXuidLow = NetvarManager.Table["DT_WeaponCSBaseGun"]["m_OriginalOwnerXuidLow"];
            m_nFallbackStatTrak = NetvarManager.Table["DT_WeaponCSBaseGun"]["m_nFallbackStatTrak"];
            m_nFallbackSeed = NetvarManager.Table["DT_WeaponCSBaseGun"]["m_nFallbackSeed"];
            m_nFallbackPaintKit = NetvarManager.Table["DT_WeaponCSBaseGun"]["m_nFallbackPaintKit"];
            m_iTeamNum = NetvarManager.Table["DT_CSPlayer"]["m_iTeamNum"];
            m_iObserverMode = NetvarManager.Table["DT_CSPlayer"]["m_iObserverMode"];
            m_iItemIDHigh = NetvarManager.Table["DT_WeaponCSBaseGun"]["m_iItemIDHigh"];
            m_iItemDefinitionIndex = NetvarManager.Table["DT_WeaponCSBaseGun"]["m_iItemDefinitionIndex"];
            m_iHealth = NetvarManager.Table["DT_CSPlayer"]["m_iHealth"];
            m_iFOV = NetvarManager.Table["DT_CSPlayer"]["m_iFOV"];
            m_iEntityQuality = NetvarManager.Table["DT_WeaponCSBaseGun"]["m_iEntityQuality"];
            m_iCrosshairId = NetvarManager.Table["DT_CSPlayer"]["m_bHasDefuser"] + 92;
            m_hMyWeapons = NetvarManager.Table["DT_CSPlayer"]["m_hMyWeapons"];
            m_hActiveWeapon = NetvarManager.Table["DT_CSPlayer"]["m_hActiveWeapon"];
            m_flFallbackWear = NetvarManager.Table["DT_WeaponCSBaseGun"]["m_flFallbackWear"];
            m_fFlags = NetvarManager.Table["DT_CSPlayer"]["m_fFlags"];
            m_dwBoneMatrix = NetvarManager.Table["DT_BaseAnimating"]["m_nForceBone"] + 28;
            m_bSpottedByMask = NetvarManager.Table["DT_CSPlayer"]["m_bSpottedByMask"];
            m_bIsScoped = NetvarManager.Table["DT_CSPlayer"]["m_bIsScoped"];
            m_bHasHelmet = NetvarManager.Table["DT_CSPlayer"]["m_bHasHelmet"];
            m_ArmorValue = NetvarManager.Table["DT_CSPlayer"]["m_ArmorValue"];
            m_aimPunchAngle = NetvarManager.Table["DT_CSPlayer"]["m_aimPunchAngle"];
            m_iShotsFired = NetvarManager.Table["DT_CSPlayer"]["m_iShotsFired"];
            m_flFlashMaxAlpha = NetvarManager.Table["DT_CSPlayer"]["m_flFlashMaxAlpha"];
            m_bSpotted = NetvarManager.Table["DT_CSPlayer"]["m_bSpotted"];
            m_flHealthShotBoostExpirationTime = NetvarManager.Table["DT_CSPlayer"]["m_flHealthShotBoostExpirationTime"];
            m_iGlowIndex = NetvarManager.Table["DT_CSPlayer"]["m_flFlashDuration"] + 24;
            m_nViewModelIndex = NetvarManager.Table["DT_PredictedViewModel"]["m_nViewModelIndex"];
            m_nModelIndex = NetvarManager.Table["DT_CSPlayer"]["m_nModelIndex"];
            m_iDefaultFOV = NetvarManager.Table["DT_CSPlayer"]["m_iDefaultFOV"];
            m_zoomLevel = NetvarManager.Table["DT_WeaponCSBaseGun"]["m_zoomLevel"];
            m_totalHitsOnServer = NetvarManager.Table["DT_CSPlayer"]["m_totalHitsOnServer"];
        }
    }
}
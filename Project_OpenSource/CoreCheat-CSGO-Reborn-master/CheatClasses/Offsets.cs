using System;
namespace CoreCheat_Reborn.CheatClasses
{
    public static class Offsets
    {
        public static class others
        {
            public static Int32 sv_grenade_trajectory = 0xCFD7A0;
            
        }
        public static class netvars
        {
            public static Int32 m_vecOrigin;
            public static Int32 m_szLastPlaceName;
            public static Int32 m_szCustomName;
            public static Int32 m_OriginalOwnerXuidHigh;
            public static Int32 m_OriginalOwnerXuidLow;
            public static Int32 m_nFallbackStatTrak;
            public static Int32 m_nFallbackSeed;
            public static Int32 m_nFallbackPaintKit;
            public static Int32 m_iTeamNum;
            public static Int32 m_iObserverMode;
            public static Int32 m_iItemIDHigh;
            public static Int32 m_iItemDefinitionIndex;
            public static Int32 m_iHealth;
            public static Int32 m_iFOV;
            public static Int32 m_iEntityQuality;
            public static Int32 m_iCrosshairId;
            public static Int32 m_hMyWeapons;
            public static Int32 m_hActiveWeapon;
            public static Int32 m_flFallbackWear;
            public static Int32 m_fFlags;
            public static Int32 m_dwBoneMatrix;
            public static Int32 m_bSpottedByMask;
            public static Int32 m_bIsScoped;
            public static Int32 m_bHasHelmet;
            public static Int32 m_ArmorValue;
            public static Int32 m_aimPunchAngle;
            public static Int32 m_flHealthShotBoostExpirationTime;
            public static Int32 m_iGlowIndex;
            public static Int32 m_iShotsFired;
            public static Int32 m_flFlashMaxAlpha;
            public static Int32 m_bSpotted;
            public static Int32 m_nViewModelIndex;
            public static Int32 m_nModelIndex;
            public static Int32 m_iDefaultFOV;
            public static Int32 m_zoomLevel;
            public static Int32 m_totalHitsOnServer;
            public static Int32 m_vecViewOffset;
        }
        public static class signatures
        {
            public static Int32 anim_overlays;
            public static Int32 clientstate_choked_commands;
            public static Int32 clientstate_delta_ticks;
            public static Int32 clientstate_last_outgoing_command;
            public static Int32 clientstate_net_channel;
            public static Int32 convar_name_hash_table;
            public static Int32 dwClientState;
            public static Int32 dwClientState_GetLocalPlayer;
            public static Int32 dwClientState_IsHLTV;
            public static Int32 dwClientState_Map;
            public static Int32 dwClientState_MapDirectory;
            public static Int32 dwClientState_MaxPlayer;
            public static Int32 dwClientState_PlayerInfo;
            public static Int32 dwClientState_State;
            public static Int32 dwClientState_ViewAngles;
            public static Int32 dwEntityList;
            public static Int32 dwForceAttack;
            public static Int32 dwForceAttack2;
            public static Int32 dwForceBackward;
            public static Int32 dwForceForward;
            public static Int32 dwForceJump;
            public static Int32 dwForceLeft;
            public static Int32 dwForceRight;
            public static Int32 dwGameDir;
            public static Int32 dwGameRulesProxy;
            public static Int32 dwGetAllClasses;
            public static Int32 dwGlobalVars;
            public static Int32 dwGlowObjectManager;
            public static Int32 dwInput;
            public static Int32 dwInterfaceLinkList;
            public static Int32 dwLocalPlayer;
            public static Int32 dwMouseEnable;
            public static Int32 dwMouseEnablePtr;
            public static Int32 dwPlayerResource;
            public static Int32 dwRadarBase;
            public static Int32 dwSensitivity;
            public static Int32 dwSensitivityPtr;
            public static Int32 dwSetClanTag;
            public static Int32 dwViewMatrix;
            public static Int32 dwWeaponTable;
            public static Int32 dwWeaponTableIndex;
            public static Int32 dwYawPtr;
            public static Int32 dwZoomSensitivityRatioPtr;
            public static Int32 dwbSendPackets;
            public static Int32 dwppDirect3DDevice9;
            public static Int32 find_hud_element;
            public static Int32 force_update_spectator_glow;
            public static Int32 interface_engine_cvar;
            public static Int32 is_c4_owner;
            public static Int32 m_bDormant;
            public static Int32 m_flSpawnTime;
            public static Int32 m_pStudioHdr;
            public static Int32 m_pitchClassPtr;
            public static Int32 m_yawClassPtr;
            public static Int32 model_ambient_min;
            public static Int32 set_abs_angles;
            public static Int32 set_abs_origin;
                        public static Int32 dwClientCmd;
        }
    }
}

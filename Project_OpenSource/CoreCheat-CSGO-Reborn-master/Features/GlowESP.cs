using CoreCheat_Reborn.CheatClasses;
using CoreCheat_Reborn.SDK.Controllers;
using CoreCheat_Reborn.SDK.Entities;
using CoreCheat_Reborn.SDK.Managers;
using static CoreCheat_Reborn.CheatClasses.Enums;
using static CoreCheat_Reborn.CheatClasses.Offsets.netvars;
using static CoreCheat_Reborn.CheatClasses.Offsets.signatures;
using static CoreCheat_Reborn.CheatClasses.Structs;
using static CoreCheat_Reborn.Versions.Panorama.Settings;

namespace CoreCheat_Reborn.Features
{
    class GlowESP
    {
        public static void RunGlowESPPanorama(int EntBase)
        {
            int GlowIndex = CylMem.ReadInt(EntBase + m_iGlowIndex);
            if (CEntityPlayer.Team(EntBase) == Teams.TERRORIST && CheatStatus.WallActive && CEntityPlayer.isAlive(EntBase) && ((CLocalPlayer.Team != CEntityPlayer.Team(EntBase) && VisualConfig.glowEnemyTeam) || (CLocalPlayer.Team == CEntityPlayer.Team(EntBase) && VisualConfig.glowLocalTeam))) //T
            {
                if (VisualConfig.selectedGlowColor == VisualColor.ENGINE)
                    CEntityPlayer.Glow(GlowIndex, VisualConfig.GlowEngineTerrorist, VisualConfig.selectedGlowStyle, VisualConfig.selectedGlowType);
                else if (VisualConfig.selectedGlowColor == VisualColor.REDBLUE)
                    CEntityPlayer.Glow(GlowIndex, VisualConfig.GlowRed, VisualConfig.selectedGlowStyle, VisualConfig.selectedGlowType);
                else if (VisualConfig.selectedGlowColor == VisualColor.HEALTH)
                    CEntityPlayer.Glow(GlowIndex, Parsers.ParseEnemyGlowHealth(CEntityPlayer.Health(EntBase)), VisualConfig.selectedGlowStyle, VisualConfig.selectedGlowType);
            }
            if (CEntityPlayer.Team(EntBase) == Teams.ANTI_TERRORIST && CheatStatus.WallActive && CEntityPlayer.isAlive(EntBase) && ((CLocalPlayer.Team != CEntityPlayer.Team(EntBase) && VisualConfig.glowEnemyTeam) || (CLocalPlayer.Team == CEntityPlayer.Team(EntBase) && VisualConfig.glowLocalTeam))) //AT
            {
                if (VisualConfig.selectedGlowColor == VisualColor.ENGINE)
                    CEntityPlayer.Glow(GlowIndex, VisualConfig.GlowEngineATerrorist, VisualConfig.selectedGlowStyle, VisualConfig.selectedGlowType);
                else if (VisualConfig.selectedGlowColor == VisualColor.REDBLUE)
                    CEntityPlayer.Glow(GlowIndex, VisualConfig.GlowBlue, VisualConfig.selectedGlowStyle, VisualConfig.selectedGlowType);
                else if (VisualConfig.selectedGlowColor == VisualColor.HEALTH)
                    CEntityPlayer.Glow(GlowIndex, Parsers.ParseEnemyGlowHealth(CEntityPlayer.Health(EntBase)), VisualConfig.selectedGlowStyle, VisualConfig.selectedGlowType);
            }
        }
        public static void RunGlowESPOWALL(GlowStruct red, GlowStruct blue, bool Active)
        {
            for (int i = 0; i <= EngineClient.MaxPlayer; i++)
            {
                int EntBase = CylMem.ReadInt(Modules.ClientDLLAdress + dwEntityList + i * 0x10);
                if (EntBase == 0) continue;
                if (CEntityPlayer.isDormant(EntBase)) continue;
                if (CEntityPlayer.isDead(EntBase)) continue;
                if (CEntityPlayer.Team(EntBase) == Teams.NONE || CEntityPlayer.Team(EntBase) == Teams.SPECTATOR) continue;
                if (CEntityPlayer.WeaponName(EntBase) == "NONE") continue;
                int GlowIndex = CylMem.ReadInt(EntBase + m_iGlowIndex);
                if (CEntityPlayer.Team(EntBase) == Teams.TERRORIST && Active && CEntityPlayer.isAlive(EntBase)) //T
                    CEntityPlayer.Glow(GlowIndex, red, GlowStyle.NORMAL, GlowType.NORMAL);
                if (CEntityPlayer.Team(EntBase) == Teams.ANTI_TERRORIST && Active && CEntityPlayer.isAlive(EntBase)) //AT
                    CEntityPlayer.Glow(GlowIndex, blue, GlowStyle.NORMAL, GlowType.NORMAL);
            }
        }
        public static void RunGlowESPLegit(int EntBase, bool Active, GlowStruct TColor, GlowStruct ATColor)
        {
            int GlowIndex = CylMem.ReadInt(EntBase + m_iGlowIndex);
            if (Active)
            {
                if (CLocalPlayer.isDead)
                {
                    if (CLocalPlayer.Team != CEntityPlayer.Team(EntBase))
                    {
                        if (CEntityPlayer.Team(EntBase) == Teams.TERRORIST && CEntityPlayer.isAlive(EntBase)) //T
                            CEntityPlayer.Glow(GlowIndex, TColor, GlowStyle.NORMAL, GlowType.NORMAL);
                        if (CEntityPlayer.Team(EntBase) == Teams.ANTI_TERRORIST && CEntityPlayer.isAlive(EntBase)) //AT
                            CEntityPlayer.Glow(GlowIndex, ATColor, GlowStyle.NORMAL, GlowType.NORMAL);
                    }
                }
            }
        }
    }
}

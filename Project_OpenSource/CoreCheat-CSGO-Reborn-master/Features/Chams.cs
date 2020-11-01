using CoreCheat_Reborn.SDK.Controllers;
using CoreCheat_Reborn.SDK.Entities;
using CoreCheat_Reborn.SDK.Managers;
using static CoreCheat_Reborn.CheatClasses.Enums;
using static CoreCheat_Reborn.Versions.Panorama.Settings;
using static CoreCheat_Reborn.CheatClasses.Offsets.netvars;

namespace CoreCheat_Reborn.Features
{
    class Chams
    {
        public static void RunChamsPanorama(int EntBase)
        {
            if (CheatStatus.ChamsActive)
            {
                if (CEntityPlayer.Team(EntBase) == Teams.TERRORIST && CEntityPlayer.isAlive(EntBase)) //T
                {
                    if (VisualConfig.selectedChamsColor == VisualColor.ENGINE)
                        CEntityPlayer.ApplyChams(VisualConfig.EngineTerroristColor, VisualConfig.ChamsBrightness, EntBase);
                    else if (VisualConfig.selectedChamsColor == VisualColor.REDBLUE)
                        CEntityPlayer.ApplyChams(VisualConfig.Red, VisualConfig.ChamsBrightness, EntBase);
                    else if (VisualConfig.selectedChamsColor == VisualColor.HEALTH)
                        CEntityPlayer.ApplyChams(Parsers.ParseEnemyChamsHealth(CEntityPlayer.Health(EntBase)), VisualConfig.ChamsBrightness, EntBase);
                }
                if (CEntityPlayer.Team(EntBase) == Teams.ANTI_TERRORIST && CEntityPlayer.isAlive(EntBase)) //AT
                {
                    if (VisualConfig.selectedChamsColor == VisualColor.ENGINE)
                        CEntityPlayer.ApplyChams(VisualConfig.EngineATerroristColor, VisualConfig.ChamsBrightness, EntBase);
                    else if (VisualConfig.selectedChamsColor == VisualColor.REDBLUE)
                        CEntityPlayer.ApplyChams(VisualConfig.Blue, VisualConfig.ChamsBrightness, EntBase);
                    else if (VisualConfig.selectedChamsColor == VisualColor.HEALTH)
                        CEntityPlayer.ApplyChams(Parsers.ParseEnemyChamsHealth(CEntityPlayer.Health(EntBase)), VisualConfig.ChamsBrightness, EntBase);
                }
            }
            else
                CEntityPlayer.ClearChams(EntBase);
        }
        public static void RunChamsLegit(int EntBase, bool Active, bool dEspActive)
        {
            int GlowIndex = CylMem.ReadInt(EntBase + m_iGlowIndex);
            if (Active)
            {
                if (CLocalPlayer.Team != CEntityPlayer.Team(EntBase))
                {
                    if (CLocalPlayer.isAlive || !dEspActive)
                        CEntityPlayer.Glow(GlowIndex, Parsers.ParseEnemyGlowHealth(CEntityPlayer.Health(EntBase)), GlowStyle.NORMAL, GlowType.FROZEN);
                    CEntityPlayer.ApplyChams(Parsers.ParseEnemyChamsHealth(CEntityPlayer.Health(EntBase)), 90, EntBase);
                }
            }
            else if (!Active)
            {
                if (CLocalPlayer.Team != CEntityPlayer.Team(EntBase))
                    CEntityPlayer.ClearChams(EntBase);
            }
        }
    }
}

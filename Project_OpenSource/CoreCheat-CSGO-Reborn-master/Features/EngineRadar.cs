using CoreCheat_Reborn.SDK.Entities;
using static CoreCheat_Reborn.Versions.Panorama.Settings;

namespace CoreCheat_Reborn.Features
{
    class EngineRadar
    {
        public static void RunRadarPanorama(int EntBase)
        {
            if (CheatStatus.RadarActive && !CEntityPlayer.isDead(EntBase))
                CEntityPlayer.SpotPlayer(EntBase);
        }
        public static void RunRadarLegit(int EntBase, bool Active)
        {
            if (Active)
                CEntityPlayer.SpotPlayer(EntBase);
        }
    }
}

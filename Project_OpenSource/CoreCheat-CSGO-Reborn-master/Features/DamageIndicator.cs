using CoreCheat_Reborn.SDK.Entities;
using static CoreCheat_Reborn.Versions.Panorama.Settings;

namespace CoreCheat_Reborn.Features
{
    class DamageIndicator
    {
        public static void RunDamageIndicatorPanorama()
        {
            if (CheatStatus.DamageIndicatorActive)
            {
                if (CLocalPlayer.TotalHits > VisualConfig.Hits)
                {
                    VisualConfig.Hits = CLocalPlayer.TotalHits;
                    CLocalPlayer.HealthShotBoostTime = 0.5f;
                }
                if (CLocalPlayer.isDead)
                    VisualConfig.Hits = 0;
            }
            else
                VisualConfig.Hits = 0;
        }
    }
}

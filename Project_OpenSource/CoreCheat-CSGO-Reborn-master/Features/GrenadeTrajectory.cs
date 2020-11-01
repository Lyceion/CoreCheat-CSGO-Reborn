using CoreCheat_Reborn.CheatClasses;
using static CoreCheat_Reborn.Versions.Panorama.Settings;

namespace CoreCheat_Reborn.Features
{
    class GrenadeTrajectory
    {
        public static void RunGPRJPanorama()
        {
            if (CheatStatus.BombTrajectoryActive)
                EngineClient.ShowBombTrajectory();
            else if (!CheatStatus.BombTrajectoryActive)
                EngineClient.HideBombTrajectory();
        }
    }
}

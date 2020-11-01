using CoreCheat_Reborn.SDK.Entities;
using static CoreCheat_Reborn.Versions.Panorama.Settings;

namespace CoreCheat_Reborn.Features
{
    class NoHands
    {
        public static void RunNoHandsPanorama()
        {
            if (CheatStatus.NoHandsActive)
                CLocalPlayer.RemoveHands();
            if (!CheatStatus.NoHandsActive)
                CLocalPlayer.AddHands();
        }
    }
}

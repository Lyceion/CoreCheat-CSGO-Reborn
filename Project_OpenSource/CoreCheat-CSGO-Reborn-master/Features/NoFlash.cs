using CoreCheat_Reborn.SDK.Entities;
using static CoreCheat_Reborn.Versions.Panorama.Settings;

namespace CoreCheat_Reborn.Features
{
    class NoFlash
    {
        public static void RunNoFlashPanorama()
        {
            if (CheatStatus.FlashActive)
                CLocalPlayer.RemoveFlash();
            else if (!CheatStatus.FlashActive)
                CLocalPlayer.AddFlash();
        }
    }
}

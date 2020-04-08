using CoreCheat_Reborn.CheatClasses;
using CoreCheat_Reborn.SDK.Entities;
using System.Windows.Forms;
using static CoreCheat_Reborn.Versions.Panorama.Settings;

namespace CoreCheat_Reborn.Features
{
    class AutoPistol
    {
        public static void RunAutoPistolPanorama()
        {
            if (CheatStatus.AutoPistolActive)
                if (Methods.HoldingKey(Keys.LButton))
                    if (CLocalPlayer.IsPistolWeapon)
                        CLocalPlayer.ShootWithPointer(15);
        }
    }
}

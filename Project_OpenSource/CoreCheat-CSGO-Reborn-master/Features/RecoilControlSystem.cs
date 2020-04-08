using CoreCheat_Reborn.SDK.Entities;
using CoreCheat_Reborn.SDK.Managers;
using static CoreCheat_Reborn.Versions.Panorama.Settings;

namespace CoreCheat_Reborn.Features
{
    class RecoilControlSystem
    {
        public static void RunRCSPanorama()
        {
            if (CheatStatus.RCSActive)
            {
                if (CLocalPlayer.ShootedBullets >= WeaponSettings.RCSShootFired && !CLocalPlayer.IsPistolWeapon)
                {
                    AssistsConfig.NewViewAngles.X = ((CLocalPlayer.ViewAngles.X + AssistsConfig.OldAimPunch.X) - (CLocalPlayer.AimPunchAngles.X * 2f));
                    AssistsConfig.NewViewAngles.Y = ((CLocalPlayer.ViewAngles.Y + AssistsConfig.OldAimPunch.Y) - (CLocalPlayer.AimPunchAngles.Y * 2f));
                    AssistsConfig.NewViewAngles.Z = 0;
                    Parsers.ClampAngle(AssistsConfig.NewViewAngles);
                    AssistsConfig.OldAimPunch.X = CLocalPlayer.AimPunchAngles.X * 2f;
                    AssistsConfig.OldAimPunch.Y = CLocalPlayer.AimPunchAngles.Y * 2f;
                    AssistsConfig.OldAimPunch.Z = 0;
                    CLocalPlayer.ViewAngles = AssistsConfig.NewViewAngles;
                }
                else
                    AssistsConfig.OldAimPunch.X = AssistsConfig.OldAimPunch.Y = AssistsConfig.OldAimPunch.Z = 0;
            }
        }
    }
}

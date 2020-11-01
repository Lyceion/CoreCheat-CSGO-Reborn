using CoreCheat_Reborn.CheatClasses;
using CoreCheat_Reborn.SDK.Entities;
using System.Numerics;
using System.Windows.Forms;
using static CoreCheat_Reborn.CheatClasses.Enums;
using static CoreCheat_Reborn.Versions.Panorama.Settings;

namespace CoreCheat_Reborn.Features
{
    class BunnyHop
    {
        public static void RunBunnyHopPanorama()
        {
            if (CheatStatus.BunnyActive)
            {
                if (Methods.HoldingKey(Keys.Space))
                {
                    if (MiscConfig.SelectedBhopType == BunnyType.STRAFE)
                    {
                        Vector3 PrevAngles = new Vector3();
                        if (CLocalPlayer.Flag != FlagState.ONGROUND)
                        {
                            if (CLocalPlayer.ViewAngles.Y > PrevAngles.Y)
                                CLocalPlayer.GoLeft();
                            else if (CLocalPlayer.ViewAngles.Y < PrevAngles.Y)
                                CLocalPlayer.GoRight();
                            PrevAngles = CLocalPlayer.ViewAngles;
                        }
                    }
                    if ((CLocalPlayer.Flag == FlagState.ONGROUND || CLocalPlayer.Flag == FlagState.CROUCHING))
                        CLocalPlayer.Jump();
                }
            }
        }
    }
}

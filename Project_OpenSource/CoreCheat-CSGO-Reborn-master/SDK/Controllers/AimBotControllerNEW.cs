using System;
using System.Numerics;
using System.Windows.Forms;
using CoreCheat_Reborn.CheatClasses;
using CoreCheat_Reborn.SDK.Entities;
using CoreCheat_Reborn.SDK.Managers;
using static CoreCheat_Reborn.CheatClasses.Enums;

namespace CoreCheat_Reborn.SDK.Controllers
{
    class AimBotControllerNEW
    {
        public static int FindPlayer()
        {
            Vector3 W2SHead;
            int PlrToAim = 0;
            double LowestDistance = double.MaxValue;

            for (int i = 0; i < EngineClient.MaxPlayer; i++)
            {
                int Entity = CEntityPlayer.GetEntity(i);

                if (CEntityPlayer.Team(Entity) != CLocalPlayer.Team && CEntityPlayer.isAlive(Entity))
                {
                    W2SHead = Maths.WorldToScreen(Methods.GetBonePos(Entity, 8));
                    double Dist = Vector3.Distance(CEntityPlayer.Position(Entity), CLocalPlayer.Position);
                    //double Dist = Math.Sqrt(Math.Pow((Globals.ScreenWidth / 2) - W2SHead.X, 2) + Math.Pow((Globals.ScreenWidth / 2) - W2SHead.Y, 2));

                    if (Dist < LowestDistance)
                    {
                        LowestDistance = Dist;
                        PlrToAim = Entity;
                    }
                }
            }

            return PlrToAim;
        }

        public static void DoAimbot(int PlayerToAimbot)
        {
            if (PlayerToAimbot != 0)
            {
                if (PlayerToAimbot != 0 && CEntityPlayer.Health(PlayerToAimbot) <= 100 && CEntityPlayer.Health(PlayerToAimbot) > 0 && CEntityPlayer.WeaponName(PlayerToAimbot) != "NONE" && !(CEntityPlayer.Team(PlayerToAimbot) == Teams.NONE || CEntityPlayer.Team(PlayerToAimbot) == Teams.SPECTATOR) && CEntityPlayer.isAlive(PlayerToAimbot) && !CEntityPlayer.isDormant(PlayerToAimbot) && CEntityPlayer.isPlayerSpotted(PlayerToAimbot) && Methods.HoldingKey(Keys.Alt))
                {
                    Vector3 AimAngles = Maths.CalcAngle(CLocalPlayer.Position, CEntityPlayer.Position(PlayerToAimbot)/* - new Vector3(4, +4, 4)*/);
                    AimAngles -= CLocalPlayer.AimPunchAngles * 2.0f;
                    Vector3 CurrentAngles = CLocalPlayer.ViewAngles;

                    if (CurrentAngles.Y < 0)
                        CurrentAngles.Y += 360;

                    Vector3 Delta = AimAngles - CurrentAngles;
                    CLocalPlayer.ViewAngles = CurrentAngles + Delta / 5;
                }
            }
        }

        public static void AimAtPos(float x, float y, int AimSpeed, bool Smooth)
        {
            //By fredaikis
            float ScreenCenterX = (Screen.PrimaryScreen.Bounds.Width / 2);
            float ScreenCenterY = (Screen.PrimaryScreen.Bounds.Height / 2);
            float TargetX = 0;
            float TargetY = 0;
            if (x != 0)
            {
                if (x > ScreenCenterX)
                {
                    TargetX = -(ScreenCenterX - x);
                    TargetX /= AimSpeed;
                    if (TargetX + ScreenCenterX > ScreenCenterX * 2) TargetX = 0;
                }

                if (x < ScreenCenterX)
                {
                    TargetX = x - ScreenCenterX;
                    TargetX /= AimSpeed;
                    if (TargetX + ScreenCenterX < 0) TargetX = 0;
                }
            }
            if (y != 0)
            {
                if (y > ScreenCenterY)
                {
                    TargetY = -(ScreenCenterY - y);
                    TargetY /= AimSpeed;
                    if (TargetY + ScreenCenterY > ScreenCenterY * 2) TargetY = 0;
                }

                if (y < ScreenCenterY)
                {
                    TargetY = y - ScreenCenterY;
                    TargetY /= AimSpeed;
                    if (TargetY + ScreenCenterY < 0) TargetY = 0;
                }
            }
            if (!Smooth)
            {
                Methods.mouse_event(0x0001, (int)TargetX, (int)TargetY, 0, 0);
                return;
            }
            TargetX /= 10;
            TargetY /= 10;
            if (Math.Abs(TargetX) < 1)
            {
                if (TargetX > 0)
                {
                    TargetX = 1;
                }
                if (TargetX < 0)
                {
                    TargetX = -1;
                }
            }
            if (Math.Abs(TargetY) < 1)
            {
                if (TargetY > 0)
                {
                    TargetY = 1;
                }
                if (TargetY < 0)
                {
                    TargetY = -1;
                }
            }
            Methods.mouse_event(0x0001, (int)TargetX, (int)TargetY, 0, 0);
        }
    }
}

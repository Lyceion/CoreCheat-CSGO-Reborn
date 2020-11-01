using CoreCheat_Reborn.SDK.Entities;
using CoreCheat_Reborn.SDK.Controllers;
using CoreCheat_Reborn.CheatClasses;
using static CoreCheat_Reborn.Versions.Panorama.Settings;
using static CoreCheat_Reborn.CheatClasses.Enums;
using System.Numerics;
using System.Windows.Forms;
using CoreCheat_Reborn.SDK.Managers;

namespace CoreCheat_Reborn.Features
{
    class Aimbot
    {
        public static void ConfigureAimbot(int EntBase, AimBotController Aim)
        {
            if (CLocalPlayer.Team != CEntityPlayer.Team(EntBase) && (CEntityPlayer.Team(EntBase) == Teams.ANTI_TERRORIST || CEntityPlayer.Team(EntBase) == Teams.TERRORIST) && CEntityPlayer.Health(EntBase) <= 100 && CEntityPlayer.Health(EntBase) > 0 && CEntityPlayer.WeaponName(EntBase) != "NONE" && !(CEntityPlayer.Team(EntBase) == Teams.NONE || CEntityPlayer.Team(EntBase) == Teams.SPECTATOR) && CEntityPlayer.isAlive(EntBase) && !CEntityPlayer.isDormant(EntBase) && CEntityPlayer.isPlayerSpotted(EntBase))
                Aim.closestEngine(EntBase, Methods.GetBonePos(EntBase, AimBotConfig.SelectedBone));
        }
        public static void RunAimbotPanorama(AimBotController Aim)
        {
            Aim.setFrom(CLocalPlayer.Position);
            int target_aim_entbase = Aim.closestPlayerEntityBase;
            Vector3 target_aim_vector = Aim.closestPlayerVector;
            if (CEntityPlayer.isPlayerSpotted(target_aim_entbase) && CLocalPlayer.Team != CEntityPlayer.Team(target_aim_entbase) && (CEntityPlayer.Team(target_aim_entbase) == Teams.ANTI_TERRORIST || CEntityPlayer.Team(target_aim_entbase) == Teams.TERRORIST) && CEntityPlayer.Health(target_aim_entbase) <= 100 && CEntityPlayer.Health(target_aim_entbase) > 0 && CEntityPlayer.WeaponName(target_aim_entbase) != "NONE" && !(CEntityPlayer.Team(target_aim_entbase) == Teams.NONE || CEntityPlayer.Team(target_aim_entbase) == Teams.SPECTATOR) && CEntityPlayer.isAlive(target_aim_entbase) && !CEntityPlayer.isDormant(target_aim_entbase) && CEntityPlayer.isPlayerSpotted(target_aim_entbase) && CheatStatus.AimbotActive)
            {
                if (AimBotConfig.LockKey == KeysList.NOKEYS)
                {
                    if (Methods.HoldingKey(Keys.LButton))
                    {
                        Vector3 raw = Aim.CalcAngle(CLocalPlayer.VectorEyeLevel, target_aim_vector);
                        Vector3 raw_unp = Aim.RemovePunch(raw);
                        Vector3 target_angle = Parsers.ClampAngle(raw_unp);
                        CLocalPlayer.ViewAngles = target_angle;
                    }
                }
                else
                {
                    if (Methods.HoldingKey(Parsers.KeyListToRealKey(AimBotConfig.LockKey)))
                    {
                        Vector3 raw = Aim.CalcAngle(CLocalPlayer.VectorEyeLevel, target_aim_vector);
                        Vector3 raw_unp = Aim.RemovePunch(raw);
                        Vector3 target_angle = Parsers.ClampAngle(raw_unp);
                        CLocalPlayer.ViewAngles = target_angle;
                    }
                }
            }
        }
    }
}

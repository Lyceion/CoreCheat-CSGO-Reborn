using System.Numerics;
using static CoreCheat_Reborn.CheatClasses.Enums;
using static CoreCheat_Reborn.CheatClasses.Structs;

namespace CoreCheat_Reborn.Versions.Panorama
{
    class Settings
    {
        public static PerformanceTimes CheatPerf = PerformanceTimes.HIGH;
        public static class CheatStatus
        {
            public static bool WallActive = false;
            public static bool ChamsActive = false;
            public static bool FlashActive = false;
            public static bool NoSmokeActive = false;
            public static bool RadarActive = false;
            public static bool NoHandsActive = false;
            public static bool RemoveScopeActive = false;
            public static bool BombTrajectoryActive = false;

            public static bool BunnyActive = false;

            public static bool TriggerActive = false;
            public static bool AutoPistolActive = false;
            public static bool RCSActive = false;
            public static bool AimbotActive = false;
        }
        public static class VisualConfig
        {
            public static VisualColor selectedChamsColor = VisualColor.ENGINE;
            public static VisualColor selectedGlowColor = VisualColor.ENGINE;
            public static GlowStyle selectedGlowStyle = GlowStyle.NORMAL;
            public static GlowType selectedGlowType = GlowType.NORMAL;

            public static bool glowEnemyTeam = true;
            public static bool glowLocalTeam = true;

            public static GlowStruct GlowEngineTerrorist = new GlowStruct()
            {
                r = 0.254f,
                g = 0.236f,
                b = 0.124f,
                a = 2,
                rwo = true,
                rwuo = false
            };
            public static GlowStruct GlowEngineATerrorist = new GlowStruct()
            {
                r = 0.113f,
                g = 0.145f,
                b = 0.204f,
                a = 2,
                rwo = true,
                rwuo = false
            };
            public static GlowStruct GlowRed = new GlowStruct()
            {
                r = 255,
                g = 0f,
                b = 0f,
                a = 255
            };
            public static GlowStruct GlowBlue = new GlowStruct()
            {
                r = 0f,
                g = 0f,
                b = 255,
                a = 255
            };
            public static float ChamsBrightness = 10;
            public static ColorStruct EngineTerroristColor = new ColorStruct()
            {
                r = 254,
                g = 236,
                b = 124,
                a = 0
            };
            public static ColorStruct EngineATerroristColor = new ColorStruct()
            {
                r = 113,
                g = 145,
                b = 204,
                a = 0
            };
            public static ColorStruct Red = new ColorStruct()
            {
                r = 255,
                g = 0f,
                b = 0f,
                a = 0
            };
            public static ColorStruct Blue = new ColorStruct()
            {
                r = 0f,
                g = 0f,
                b = 255,
                a = 0
            };
        }
        public static class AssistsConfig
        {
            public static bool isNoScope = true;
            public static bool isFriendlyFire = false;
            public static bool isSprayRandom = true;
            public static KeysList TriggerKey = KeysList.NOKEYS;

            public static Vector3 NewViewAngles = new Vector3();
            public static Vector3 OldAimPunch = new Vector3();
        }
        public static class WeaponSettings
        {
            public static int RCSShootFired = 1;
            public static int TriggerSprayTime = 20;
        }
        public static class MiscConfig
        {
            public static BunnyType SelectedBhopType = BunnyType.NORMAL;
            public static string SelectedClanTag;

            public static int ViewModelFOVValue = 90;

            public static SpectatorView SelectedViewType = SpectatorView.FIRSTPERSON;
        }
        public static class AimBotConfig
        {

        }
    }
}

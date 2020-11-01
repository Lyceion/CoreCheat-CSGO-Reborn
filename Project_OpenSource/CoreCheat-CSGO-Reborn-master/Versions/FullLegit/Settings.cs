using static CoreCheat_Reborn.CheatClasses.Structs;

namespace CoreCheat_Reborn.Versions.FullLegit
{
    class Settings
    {
        public static bool deadESP = false;
        public static bool chams = false;
        public static bool trigger = false;
        public static bool radar = false;

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
    }
}

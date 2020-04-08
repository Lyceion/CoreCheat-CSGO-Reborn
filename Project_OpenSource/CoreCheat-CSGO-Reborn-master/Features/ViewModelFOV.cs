using CoreCheat_Reborn.SDK.Entities;
using static CoreCheat_Reborn.CheatClasses.Enums;
using static CoreCheat_Reborn.Versions.Panorama.Settings;

namespace CoreCheat_Reborn.Features
{
    class ViewModelFOV
    {
        public static void RunViewModelFOV()
        {
            if (CLocalPlayer.ScopeLevel == ScopeLevels.NOTSCOPED)
                CLocalPlayer.ViewModelFOV = MiscConfig.ViewModelFOVValue;
        }
    }
}

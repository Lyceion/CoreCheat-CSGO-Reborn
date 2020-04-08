using CoreCheat_Reborn.SDK.Entities;
using static CoreCheat_Reborn.CheatClasses.Enums;
using static CoreCheat_Reborn.Versions.Panorama.Settings;

namespace CoreCheat_Reborn.Features
{
    class RemoveScope
    {
        public static void RunRemoveScopePanorama()
        {
            if (CheatStatus.RemoveScopeActive)
                if (CLocalPlayer.ScopeLevel != ScopeLevels.NOTSCOPED)
                    CLocalPlayer.Scoped = false;
        }
    }
}

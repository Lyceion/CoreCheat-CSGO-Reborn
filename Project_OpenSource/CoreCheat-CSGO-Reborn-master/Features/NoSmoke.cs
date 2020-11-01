using CoreCheat_Reborn.SDK.Controllers;
using CoreCheat_Reborn.SDK.Managers;
using static CoreCheat_Reborn.CheatClasses.Offsets.signatures;
using static CoreCheat_Reborn.CheatClasses.Offsets.netvars;
using static CoreCheat_Reborn.Versions.Panorama.Settings;
using static CoreCheat_Reborn.CheatClasses.Enums;
using System.Numerics;
using CoreCheat_Reborn.CheatClasses;

namespace CoreCheat_Reborn.Features
{
    class NoSmoke
    {
        public static void RunNoSmokePanorama()
        {
            if (CheatStatus.NoSmokeActive)
            {
                for (int i = 0; i < 512; i++)
                {
                    int EntBase = CylMem.ReadInt(Modules.ClientDLLAdress + dwEntityList + i * 0x10);
                    if (EntBase == 0) continue;
                    if (EngineClient.GetClassId(EntBase) == ClassID.CSmokeGrenadeProjectile)
                        CylMem.CWrite<Vector3>(EntBase + m_vecOrigin, new Vector3(999, 999, 999));
                }
            }
        }
    }
}

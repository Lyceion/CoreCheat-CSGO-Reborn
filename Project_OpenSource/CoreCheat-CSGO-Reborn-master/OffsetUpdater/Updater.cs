using CoreCheat_Reborn.SDK.Managers;
using CoreCheat_Reborn.SDK.Controllers;
using static CoreCheat_Reborn.CheatClasses.Offsets.signatures;

namespace CoreCheat_Reborn.OffsetUpdater
{
    public partial class Updater : MetroFramework.Forms.MetroForm
    {
        public Updater()
        {
            InitializeComponent();
        }
        private void Updater_Load(object sender, System.EventArgs e)
        {
            ScanAllPatterns();
        }
        public static void ScanAllPatterns()
        {
            dwClientState = SigScan.ScanPattern(Modules.EngineDLLName, "A1 ? ? ? ? 33 D2 6A 00 6A 00 33 C9 89 B0", 1, 0, true);
            dwClientState_GetLocalPlayer = SigScan.ScanPattern(Modules.EngineDLLName, "8B 80 ? ? ? ? 40 C3", 2, 0, true);
            dwClientState_IsHLTV = SigScan.ScanPattern(Modules.EngineDLLName, "80 BF ? ? ? ? ? 0F 84 ? ? ? ? 32 DB", 2, 0, true);
            dwClientState_Map = SigScan.ScanPattern(Modules.EngineDLLName, "05 ? ? ? ? C3 CC CC CC CC CC CC CC A1", 1, 0, true);
            dwClientState_MapDirectory = SigScan.ScanPattern(Modules.EngineDLLName, "05 ? ? ? ? C3 CC CC CC CC CC CC CC 80 3D", 1, 0, true);
            dwClientState_MaxPlayer = SigScan.ScanPattern(Modules.EngineDLLName, "A1 ? ? ? ? 8B 80 ? ? ? ? C3 CC CC CC CC 55 8B EC 8A 45 08", 7, 0, true);
            dwClientState_PlayerInfo = SigScan.ScanPattern(Modules.EngineDLLName, "8B 89 ? ? ? ? 85 C9 0F 84 ? ? ? ? 8B 01", 2, 0, true);
            dwClientState_State = SigScan.ScanPattern(Modules.EngineDLLName, "83 B8 ? ? ? ? ? 0F 94 C0 C3", 2, 0, true);
            dwClientState_ViewAngles = SigScan.ScanPattern(Modules.EngineDLLName, "F3 0F 11 80 ? ? ? ? D9 46 04 D9 05", 4, 0, true);
            clientstate_delta_ticks = SigScan.ScanPattern(Modules.EngineDLLName, "C7 87 ? ? ? ? ? ? ? ? FF 15 ? ? ? ? 83 C4 08", 2, 0, true);
            clientstate_last_outgoing_command = SigScan.ScanPattern(Modules.EngineDLLName, "8B 8F ? ? ? ? 8B 87 ? ? ? ? 41", 2, 0, true);
            clientstate_choked_commands = SigScan.ScanPattern(Modules.EngineDLLName, "8B 87 ? ? ? ? 41", 2, 0, true);
            clientstate_net_channel = SigScan.ScanPattern(Modules.EngineDLLName, "8B 8F ? ? ? ? 8B 01 8B 40 18", 2, 0, true);
            dwEntityList = SigScan.ScanPattern(Modules.ClientDLLName, "BB ? ? ? ? 83 FF 01 0F 8C ? ? ? ? 3B F8", 1, 0, true);
            dwForceAttack = SigScan.ScanPattern(Modules.ClientDLLName, "89 0D ? ? ? ? 8B 0D ? ? ? ? 8B F2 8B C1 83 CE 04", 2, 0, true);
            dwForceAttack2 = SigScan.ScanPattern(Modules.ClientDLLName, "89 0D ? ? ? ? 8B 0D ? ? ? ? 8B F2 8B C1 83 CE 04", 2, 12, true);
            dwForceBackward = SigScan.ScanPattern(Modules.ClientDLLName, "55 8B EC 51 53 8A 5D 08", 287, 0, true);
            dwForceForward = SigScan.ScanPattern(Modules.ClientDLLName, "55 8B EC 51 53 8A 5D 08", 245, 0, true);
            dwForceJump = SigScan.ScanPattern(Modules.ClientDLLName, "8B 0D ? ? ? ? 8B D6 8B C1 83 CA 02", 2, 0, true);
            dwForceLeft = SigScan.ScanPattern(Modules.ClientDLLName, "55 8B EC 51 53 8A 5D 08", 465, 0, true);
            dwForceRight = SigScan.ScanPattern(Modules.ClientDLLName, "55 8B EC 51 53 8A 5D 08", 512, 0, true);
            dwGameDir = SigScan.ScanPattern(Modules.EngineDLLName, "68 ? ? ? ? 8D 85 ? ? ? ? 50 68 ? ? ? ? 68", 1, 0, true);
            dwGameRulesProxy = SigScan.ScanPattern(Modules.ClientDLLName, "A1 ? ? ? ? 85 C0 0F 84 ? ? ? ? 80 B8 ? ? ? ? ? 74 7A", 1, 0, true);
            dwGetAllClasses = SigScan.ScanPattern(Modules.ClientDLLName, "A1 ? ? ? ? C3 CC CC CC CC CC CC CC CC CC CC A1 ? ? ? ? B9", 1 ,0 ,true);
            dwGlobalVars = SigScan.ScanPattern(Modules.EngineDLLName, "68 ? ? ? ? 68 ? ? ? ? FF 50 08 85 C0") + 1;
            dwGlowObjectManager = SigScan.ScanPattern(Modules.ClientDLLName, "A1 ? ? ? ? A8 01 75 4B", 1, 4, true);
            dwInput = SigScan.ScanPattern(Modules.ClientDLLName, "B9 ? ? ? ? F3 0F 11 04 24 FF 50 10") + 1;
            dwInterfaceLinkList = SigScan.ScanPattern(Modules.ClientDLLName, "8B 35 ? ? ? ? 57 85 F6 74 ? 8B 7D 08 8B 4E 04 8B C7 8A 11 3A 10");
            dwLocalPlayer = SigScan.ScanPattern(Modules.ClientDLLName, "8D 34 85 ? ? ? ? 89 15 ? ? ? ? 8B 41 08 8B 48 04 83 F9 FF", 3, 4, true); 
            dwMouseEnable = SigScan.ScanPattern(Modules.ClientDLLName, "B9 ? ? ? ? FF 50 34 85 C0 75 10", 1, 48, true);
        }
    }
}
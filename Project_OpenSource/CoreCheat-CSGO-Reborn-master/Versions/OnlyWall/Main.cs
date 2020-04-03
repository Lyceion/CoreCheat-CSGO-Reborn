using System;
using System.Threading;
using System.Diagnostics;
using System.Windows.Forms;
using CoreCheat_Reborn.SDK.Entities;
using CoreCheat_Reborn.SDK.Managers;
using CoreCheat_Reborn.CheatClasses;
using CoreCheat_Reborn.SDK.Controllers;
using static CoreCheat_Reborn.CheatClasses.Enums;
using static CoreCheat_Reborn.CheatClasses.Structs;
using static CoreCheat_Reborn.CheatClasses.Offsets.netvars;
using static CoreCheat_Reborn.CheatClasses.Offsets.signatures;

namespace CoreCheat_Reborn.Versions.OnlyWall
{
    public partial class Main : Form
    {
        static bool CheatActive = false;

        static PerformanceTimes CheatPerf = PerformanceTimes.LOW;

        public Main()
        {
            InitializeComponent();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Process[] p = Process.GetProcessesByName("csgo");
            CylMem.OpenProcess(p[0].Id);
            Modules.ClientDLLAdress = Modules.GetModule("csgo", Modules.ClientDLLName);
            Modules.EngineDLLAdress = Modules.GetModule("csgo", Modules.EngineDLLName);
            Thread Cheats = new Thread(new ThreadStart(MainThread));
            Cheats.Start();
        }
        private static void MainThread()
        {
            GlowStruct GlowRed = new GlowStruct()
            {
                r = 255,
                g = 0f,
                b = 0f,
                a = 255
            };
            GlowStruct GlowBlue = new GlowStruct()
            {
                r = 0f,
                g = 0f,
                b = 255,
                a = 255
            };
            if (Modules.IsModuleRunning(Modules.ClientDLLName))
            {
                while (true)
                {
                    if (CLocalPlayer.IsPlaying)
                    {
                        for (int i = 0; i <= EngineClient.MaxPlayer; i++)
                        {
                            int EntBase = CylMem.ReadInt(Modules.ClientDLLAdress + dwEntityList + i * 0x10);
                            if (EntBase == 0) continue;
                            if (CEntityPlayer.isDormant(EntBase)) continue;
                            if (CEntityPlayer.isDead(EntBase)) continue;
                            if (CEntityPlayer.Team(EntBase) == Teams.NONE || CEntityPlayer.Team(EntBase) == Teams.SPECTATOR) continue;
                            if (CEntityPlayer.WeaponName(EntBase) == "NONE") continue;
                            int GlowIndex = CylMem.ReadInt(EntBase + m_iGlowIndex);
                            if (CEntityPlayer.Team(EntBase) == Teams.TERRORIST && CheatActive && CEntityPlayer.isAlive(EntBase)) //T
                                CEntityPlayer.Glow(GlowIndex, GlowRed, GlowStyle.NORMAL, GlowType.NORMAL);
                            if (CEntityPlayer.Team(EntBase) == Teams.ANTI_TERRORIST && CheatActive && CEntityPlayer.isAlive(EntBase)) //AT
                                CEntityPlayer.Glow(GlowIndex, GlowBlue, GlowStyle.NORMAL, GlowType.NORMAL);
                        }
                        Thread.Sleep((int)CheatPerf);
                    }
                }
            }
        }

        private void ActiveButton_CheckedChanged(object sender, EventArgs e)
        {
            CheatActive = activeButton.Checked;
        }

        private void HighPerf_CheckedChanged(object sender, EventArgs e)
        {
            CheatPerf = PerformanceTimes.HIGH;
        }

        private void MediumPerf_CheckedChanged(object sender, EventArgs e)
        {
            CheatPerf = PerformanceTimes.MEDIUM;
        }

        private void LowPerf_CheckedChanged(object sender, EventArgs e)
        {
            CheatPerf = PerformanceTimes.LOW;
        }

        private void TrashPerf_CheckedChanged(object sender, EventArgs e)
        {
            CheatPerf = PerformanceTimes.TRASH;
        }

        private void TitleTimer_Tick(object sender, EventArgs e)
        {
            Text = Methods.RandomString(30);
        }
    }
}

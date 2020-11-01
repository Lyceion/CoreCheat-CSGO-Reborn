using System;
using System.Threading;
using System.Diagnostics;
using System.Windows.Forms;
using CoreCheat_Reborn.CheatClasses;
using CoreCheat_Reborn.SDK.Managers;
using CoreCheat_Reborn.SDK.Entities;
using CoreCheat_Reborn.SDK.Controllers;
using static CoreCheat_Reborn.Versions.FullLegit.Settings;
using CoreCheat_Reborn.Features;

namespace CoreCheat_Reborn.Versions.FullLegit
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            InitializeCheat();
        }
        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            deadEspButton.Checked = false;
            chamsButton.Checked = false;
        }
        public void InitializeCheat()
        {
            Modules.ClientDLLAdress = Modules.GetModule("csgo", Modules.ClientDLLName);
            Modules.EngineDLLAdress = Modules.GetModule("csgo", Modules.EngineDLLName);
            Process[] p = Process.GetProcessesByName("csgo");
            CylMem.OpenProcess(p[0].Id);
            OffsetUpdater.Updater.GetNetvars();
            OffsetUpdater.Updater.ScanAllPatterns();
            Thread Cheats = new Thread(new ThreadStart(MainThread));
            Cheats.Start();
        }
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            deadEspButton.Checked = false;
            chamsButton.Checked = false;
            Environment.Exit(0);
        }
        private void DeadEspButton_CheckedChanged(object sender, EventArgs e)
        {
            deadESP = deadEspButton.Checked;
        }
        private void ChamsButton_CheckedChanged(object sender, EventArgs e)
        {
            chams = chamsButton.Checked;
        }
        private void TriggerButton_CheckedChanged(object sender, EventArgs e)
        {
            trigger = triggerButton.Checked;
        }
        public static void MainThread()
        {
            if (Modules.IsModuleRunning(Modules.ClientDLLName)) { }
            while (true)
            {
                if (CLocalPlayer.IsPlaying)
                {
                    for (int i = 0; i <= EngineClient.MaxPlayer; i++)
                    {
                        int EntBase = CylMem.ReadInt(Modules.ClientDLLAdress + CoreCheat_Reborn.CheatClasses.Offsets.signatures.dwEntityList + i * 0x10);
                        if (EntBase == 0) continue;
                        if (CEntityPlayer.isDormant(EntBase)) continue;
                        GlowESP.RunGlowESPLegit(EntBase, deadESP, GlowEngineTerrorist, GlowEngineATerrorist);
                        Chams.RunChamsLegit(EntBase, chams, deadESP);
                        EngineRadar.RunRadarLegit(EntBase, radar);
                    }
                    Thread.Sleep(1);
                }
            }
        }
        private void TitleChgr_Tick(object sender, EventArgs e)
        {
            Text = Methods.RandomString(32);
        }
    }
}

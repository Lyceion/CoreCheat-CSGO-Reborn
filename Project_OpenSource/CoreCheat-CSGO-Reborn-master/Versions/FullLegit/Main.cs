using System;
using System.Threading;
using System.Diagnostics;
using System.Windows.Forms;
using CoreCheat_Reborn.CheatClasses;
using CoreCheat_Reborn.SDK.Managers;
using CoreCheat_Reborn.SDK.Entities;
using CoreCheat_Reborn.SDK.Controllers;
using static CoreCheat_Reborn.Versions.FullLegit.Settings;
using static CoreCheat_Reborn.CheatClasses.Offsets.netvars;
using static CoreCheat_Reborn.CheatClasses.Offsets.signatures;
using static CoreCheat_Reborn.CheatClasses.Enums;

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
                        int EntBase = CylMem.ReadInt(Modules.ClientDLLAdress + dwEntityList + i * 0x10);
                        if (EntBase == 0) continue;
                        if (CEntityPlayer.isDormant(EntBase)) continue;
                        int GlowIndex = CylMem.ReadInt(EntBase + m_iGlowIndex);
                        if (deadESP)
                        {
                            if (CLocalPlayer.isDead)
                            {
                                if (CLocalPlayer.Team != CEntityPlayer.Team(EntBase))
                                {
                                    if (CEntityPlayer.Team(EntBase) == Teams.TERRORIST && CEntityPlayer.isAlive(EntBase)) //T
                                        CEntityPlayer.Glow(GlowIndex, GlowEngineTerrorist, GlowStyle.NORMAL, GlowType.NORMAL);
                                    if (CEntityPlayer.Team(EntBase) == Teams.ANTI_TERRORIST && CEntityPlayer.isAlive(EntBase)) //AT
                                        CEntityPlayer.Glow(GlowIndex, GlowEngineATerrorist, GlowStyle.NORMAL, GlowType.NORMAL);
                                }
                            }
                        }
                        if (chams)
                        {
                            if (CLocalPlayer.Team != CEntityPlayer.Team(EntBase))
                            {
                                if (CLocalPlayer.isAlive || !deadESP)
                                    CEntityPlayer.Glow(GlowIndex, Parsers.ParseEnemyGlowHealth(CEntityPlayer.Health(EntBase)), GlowStyle.NORMAL, GlowType.FROZEN);
                                CEntityPlayer.ApplyChams(Parsers.ParseEnemyChamsHealth(CEntityPlayer.Health(EntBase)), 90, EntBase);
                            }
                        }
                        else if(!chams)
                        {
                            if(CLocalPlayer.Team != CEntityPlayer.Team(EntBase))
                                CEntityPlayer.ClearChams(EntBase);
                        }
                        if (radar)
                            CEntityPlayer.SpotPlayer(EntBase);
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

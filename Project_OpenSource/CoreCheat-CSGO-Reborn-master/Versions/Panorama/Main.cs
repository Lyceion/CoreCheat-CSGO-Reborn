using System;
using System.Threading;
using System.Diagnostics;
using System.Windows.Forms;
using CoreCheat_Reborn.Classes;
using CoreCheat_Reborn.Features;
using CoreCheat_Reborn.SDK.Parsers;
using CoreCheat_Reborn.SDK.Entities;
using CoreCheat_Reborn.SDK.Managers;
using CoreCheat_Reborn.CheatClasses;
using CoreCheat_Reborn.SDK.Controllers;
using static CoreCheat_Reborn.CheatClasses.Enums;
using static CoreCheat_Reborn.Versions.Panorama.Settings;

namespace CoreCheat_Reborn.Versions.Panorama
{
    public partial class Main : MetroFramework.Forms.MetroForm
    {
        Dev devFrm = new Dev();
        private static string infoStr;
        public void Inject_FormClosing(object sender, FormClosingEventArgs e)
        {
            aimbotButton.Enabled = false;
            autoPistolButton.Enabled = false;
            bombTrajectButton.Enabled = false;
            bunnyButton.Enabled = false;
            chamsButton.Enabled = false;
            dIndicatorButton.Enabled = false;
            flashButton.Enabled = false;
            glowButton.Enabled = false;
            noHandsButton.Enabled = false;
            NoSmokeButton.Enabled = false;
            radarButton.Enabled = false;
            rcsButton.Enabled = false;
            removeScopeButton.Enabled = false;
            triggerButton.Enabled = false;
            MiscConfig.ViewModelFOVValue = 90;
            Methods.Wait(1500);
            CLocalPlayer.SetClantag(string.Empty, string.Empty);
            Environment.Exit(0);
        }
        public Main()
        {
            InitializeComponent();
        }
        private void Main_Load(object sender, EventArgs e)
        {
            GUIConfigration();
            InitializeCheat();
#if DEBUG
            AttachDevEssentials();
#endif
            Refresh();
        }
        public void CheatInfo()
        {
            infoStr = "Cheat Info:" + Environment.NewLine;
            AddInfo("Name", ProgramSettings.Globals.ProgramName);
            AddInfo("Cheat Version", ProgramSettings.Globals.ProgramVersion);
            AddInfo("Build Date", ProgramSettings.Globals.CompileDate);
            AddInfo("Owner", "Cylops");
            infoTXT.Text = infoStr;
        }
        public static void AddInfo(string name, object data)
        {
            infoStr += "[" + name + "] => " + data.ToString() + Environment.NewLine;
        }
        public void InitializeCheat()
        {
            Process[] p = Process.GetProcessesByName("csgo");
            CylMem.OpenProcess(p[0].Id);
            Modules.ClientDLLAdress = Modules.GetModule("csgo", Modules.ClientDLLName);
            Modules.EngineDLLAdress = Modules.GetModule("csgo", Modules.EngineDLLName);
            Modules.ShaderAPIAdress = Modules.GetModule("csgo", Modules.ShaderAPIName);
            Modules.VSTDLibDLLAdress = Modules.GetModule("csgo", Modules.VSTDLibDLLName);
            OffsetUpdater.Updater.GetNetvars();
            OffsetUpdater.Updater.ScanAllPatterns();
//#if DEBUG
//#endif
            Thread Cheats = new Thread(new ThreadStart(MainThread));
            Cheats.Start();
        }
        public void GUIConfigration()
        {
            viewFOVInfo.Text = "Value -> " + viewFOVTrack.Value.ToString();
            fovInfo.Text = "Value-> " + FOVTrack.Value.ToString();
            CheatSettings.ChamsSettings.chamsColorIndex = (int)VisualConfig.selectedChamsColor;
            CheatSettings.GlowSettings.glowTypeIndex = (int)VisualConfig.selectedGlowType;
            CheatSettings.GlowSettings.glowStyleIndex = (int)VisualConfig.selectedGlowStyle;
            CheatSettings.GlowSettings.glowColorIndex = (int)VisualConfig.selectedGlowColor;
            bhopType.SelectedIndex = (int)MiscConfig.SelectedBhopType;
            viewType.SelectedIndex = (int)MiscConfig.SelectedViewType;
            aimKeyCombo.SelectedIndex = (int)AimBotConfig.LockKey;
            realDotHider.Visible = true;
            mainTab.SelectedIndex = 0;
        }
        public void AttachDevEssentials()
        {
            CheatInfo();
            adminModeAlert.Visible = true;
            devFrm.Show();
            Width = 770;
            realDotHider.Visible = false;
            dotHider.Visible = true;
            devMenuButton.Visible = true;
        }
        private static void MainThread()
        {
            if (Modules.IsModuleRunning(Modules.ClientDLLName))
            {
                AimBotController Aim = new AimBotController();
                while (true)
                {
                    if (CLocalPlayer.IsPlaying)
                    {
                        for (int i = 0; i <= EngineClient.MaxPlayer; i++)
                        {
                            int EntBase = CylMem.ReadInt(Modules.ClientDLLAdress + Offsets.signatures.dwEntityList + i * 0x10);
                            if (EntBase == 0) continue;
                            if (CEntityPlayer.isDormant(EntBase)) continue;
                            if (CEntityPlayer.isDead(EntBase)) continue;
                            if (CEntityPlayer.Team(EntBase) == Teams.NONE || CEntityPlayer.Team(EntBase) == Teams.SPECTATOR) continue;
                            if (CEntityPlayer.WeaponName(EntBase) == "NONE") continue;
                            Aimbot.ConfigureAimbot(EntBase, Aim);
                            GlowESP.RunGlowESPPanorama(EntBase);
                            Chams.RunChamsPanorama(EntBase);
                            EngineRadar.RunRadarPanorama(EntBase);
                        }
                        BunnyHop.RunBunnyHopPanorama();
                        AutoPistol.RunAutoPistolPanorama();
                        Triggerbot.RunTriggerBotPanorama();
                        NoFlash.RunNoFlashPanorama();
                        NoHands.RunNoHandsPanorama();
                        DamageIndicator.RunDamageIndicatorPanorama();
                        RemoveScope.RunRemoveScopePanorama();
                        ViewModelFOV.RunViewModelFOV();
                        RecoilControlSystem.RunRCSPanorama();
                        GrenadeTrajectory.RunGPRJPanorama();
                        NoSmoke.RunNoSmokePanorama();
                        Aimbot.RunAimbotPanorama(Aim);

                        #region Performance Settings
                        if (CheatPerf == PerformanceTimes.VHIGH) { }
                        else
                            Thread.Sleep((int)CheatPerf);
                        #endregion
                    }
                }
            }
        }
        private void TitleTimer_Tick(object sender, EventArgs e)
        {
#if DEBUG
            Text = "☠️ Panorama [DEV]                                                                        " + Methods.RandomString(30);
            titleTimer.Enabled = false;
            Refresh();
#else
            Text = "☠️ Panorama Edition                                                                      " + Methods.RandomString(30);
            titleTimer.Enabled = false;
#endif
            //if (Focused)
            //    SDK.Overlay.CoreOverlay.pOverlayForm.TopMost = false;
        }

        #region Cheat Buttons

        #region VISUALS

        #region Glow ESP (Wallhack)
        private void GlowToggle_CheckedChanged(object sender, EventArgs e)
        {
            if (glowButton.Checked)
            {
                Console.Beep((int)BeepVoice.HIGHFREQ, (int)BeepVoice.DURATION);
                CheatStatus.WallActive = true;
            }
            else
            {
                Console.Beep((int)BeepVoice.LOWFREQ, (int)BeepVoice.DURATION);
                CheatStatus.WallActive = false;
            }
        }
        private void GlowSettingsButton_Click(object sender, EventArgs e)
        {
            CheatSettings.GlowSettings a = new CheatSettings.GlowSettings();
            a.Show();
        }

        #endregion

        #region Chams Buttons
        private void ChamsCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (chamsButton.Checked)
            {
                Console.Beep((int)BeepVoice.HIGHFREQ, (int)BeepVoice.DURATION);
                CheatStatus.ChamsActive = true;
            }
            else
            {
                Console.Beep((int)BeepVoice.LOWFREQ, (int)BeepVoice.DURATION);
                CheatStatus.ChamsActive = false;
            }
        }
        private void ChamsSettingsButton_Click(object sender, EventArgs e)
        {
            CheatSettings.ChamsSettings a = new CheatSettings.ChamsSettings();
            a.Show();
        }
        #endregion

        #region No Flash Buttons
        private void FlashButton_CheckedChanged(object sender, EventArgs e)
        {
            if (flashButton.Checked)
            {
                Console.Beep((int)BeepVoice.HIGHFREQ, (int)BeepVoice.DURATION);
                CheatStatus.FlashActive = true;
            }
            else
            {
                Console.Beep((int)BeepVoice.LOWFREQ, (int)BeepVoice.DURATION);
                CheatStatus.FlashActive = false;
            }
        }
        #endregion

        #region No Smoke Buttons
        private void NoSmokeButton_CheckedChanged(object sender, EventArgs e)
        {
            if (NoSmokeButton.Checked)
            {
                Console.Beep((int)BeepVoice.HIGHFREQ, (int)BeepVoice.DURATION);
                CheatStatus.NoSmokeActive = true;
            }
            else
            {
                Console.Beep((int)BeepVoice.LOWFREQ, (int)BeepVoice.DURATION);
                CheatStatus.NoSmokeActive = false;
            }
        }
        #endregion

        #region Engine Radar Buttons
        private void RadarCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (radarButton.Checked)
            {
                Console.Beep((int)BeepVoice.HIGHFREQ, (int)BeepVoice.DURATION);
                CheatStatus.RadarActive = true;
            }
            else
            {
                Console.Beep((int)BeepVoice.LOWFREQ, (int)BeepVoice.DURATION);
                CheatStatus.RadarActive = false;
            }
        }
        #endregion

        #region No Hands Buttons
        private void NoHandsButton_CheckedChanged(object sender, EventArgs e)
        {
            if (noHandsButton.Checked)
            {
                Console.Beep((int)BeepVoice.HIGHFREQ, (int)BeepVoice.DURATION);
                CheatStatus.NoHandsActive = true;
            }
            else
            {
                Console.Beep((int)BeepVoice.LOWFREQ, (int)BeepVoice.DURATION);
                CheatStatus.NoHandsActive = false;
            }
        }
        #endregion

        #region Remove Scope Buttons
        private void RemoveScope_CheckedChanged(object sender, EventArgs e)
        {
            if (removeScopeButton.Checked)
            {
                Console.Beep((int)BeepVoice.HIGHFREQ, (int)BeepVoice.DURATION);
                CheatStatus.RemoveScopeActive = true;
            }
            else
            {
                Console.Beep((int)BeepVoice.LOWFREQ, (int)BeepVoice.DURATION);
                CheatStatus.RemoveScopeActive = false;
            }
        }
        #endregion

        #region Bomb Trajectory Buttons
        private void BombTrajectBUTTON_CheckedChanged(object sender, EventArgs e)
        {
            if (bombTrajectButton.Checked)
            {
                DialogResult msg = MessageBox.Show("It doesn't work on Competitive Match & Valve servers. Do you agree to open it?", "BOMB TRAJECTORY ALERT!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (msg == DialogResult.OK)
                    bombTrajectButton.Checked = true;
                else if (msg == DialogResult.No)
                    bombTrajectButton.Checked = false;
            }
            if (bombTrajectButton.Checked)
            {
                Console.Beep((int)BeepVoice.HIGHFREQ, (int)BeepVoice.DURATION);
                CheatStatus.BombTrajectoryActive = true;
            }
            else
            {
                Console.Beep((int)BeepVoice.LOWFREQ, (int)BeepVoice.DURATION);
                CheatStatus.BombTrajectoryActive = false;
            }
        }
        #endregion

        #region Damage Indicator Buttons
        private void DIndicatorButton_CheckedChanged(object sender, EventArgs e)
        {
            if (dIndicatorButton.Checked)
            {
                Console.Beep((int)BeepVoice.HIGHFREQ, (int)BeepVoice.DURATION);
                CheatStatus.DamageIndicatorActive = true;
            }
            else
            {
                Console.Beep((int)BeepVoice.LOWFREQ, (int)BeepVoice.DURATION);
                CheatStatus.DamageIndicatorActive = false;
            }
        }
        #endregion

        #endregion

        #region Assists

        #region Trigger Buttons
        private void TriggerButton_CheckedChanged(object sender, EventArgs e)
        {
            if (triggerButton.Checked)
            {
                Console.Beep((int)BeepVoice.HIGHFREQ, (int)BeepVoice.DURATION);
                CheatStatus.TriggerActive = true;
            }
            else
            {
                Console.Beep((int)BeepVoice.LOWFREQ, (int)BeepVoice.DURATION);
                CheatStatus.TriggerActive = false;
            }
        }
        private void TriggerSettingsButton_Click(object sender, EventArgs e)
        {
            CheatSettings.TriggerSettings a = new CheatSettings.TriggerSettings();
            a.Show();
        }
        #endregion

        #region Auto Pistol Buttons
        private void AutoPistolButton_CheckedChanged(object sender, EventArgs e)
        {
            if (autoPistolButton.Checked)
            {
                Console.Beep((int)BeepVoice.HIGHFREQ, (int)BeepVoice.DURATION);
                CheatStatus.AutoPistolActive = true;
            }
            else
            {
                Console.Beep((int)BeepVoice.LOWFREQ, (int)BeepVoice.DURATION);
                CheatStatus.AutoPistolActive = false;
            }
        }
        #endregion

        #region Recoil Control System Buttons
        private void RcsButton_CheckedChanged(object sender, EventArgs e)
        {
            if (rcsButton.Checked)
            {
                Console.Beep((int)BeepVoice.HIGHFREQ, (int)BeepVoice.DURATION);
                CheatStatus.RCSActive = true;
            }
            else
            {
                Console.Beep((int)BeepVoice.LOWFREQ, (int)BeepVoice.DURATION);
                CheatStatus.RCSActive = false;
            }
        }
        private void RcsBulletCount_ValueChanged(object sender, EventArgs e)
        {
            WeaponSettings.RCSShootFired = (int)rcsBulletCount.Value;
        }
        #endregion

        #endregion

        #region Miscs

        #region BunnyHop Buttons
        private void BunnyButton_CheckedChanged(object sender, EventArgs e)
        {
            if (bunnyButton.Checked)
            {
                Console.Beep((int)BeepVoice.HIGHFREQ, (int)BeepVoice.DURATION);
                CheatStatus.BunnyActive = true;
            }
            else
            {
                Console.Beep((int)BeepVoice.LOWFREQ, (int)BeepVoice.DURATION);
                CheatStatus.BunnyActive = false;
            }
        }
        private void BhopType_SelectedIndexChanged(object sender, EventArgs e)
        {
            MiscConfig.SelectedBhopType = (BunnyType)bhopType.SelectedIndex;
        }
        #endregion

        #region View Mode Buttons
        private void ViewType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Console.Beep((int)BeepVoice.HIGHFREQ, (int)BeepVoice.DURATION);
            MiscConfig.SelectedViewType = (SpectatorView)viewType.SelectedIndex;
            CLocalPlayer.ViewMode = MiscConfig.SelectedViewType;
        }
        #endregion

        #region Fov Buttons
        private void ApplyViewFOV_Click(object sender, EventArgs e)
        {
            Console.Beep((int)BeepVoice.HIGHFREQ, (int)BeepVoice.DURATION);
            CLocalPlayer.FOV = viewFOVTrack.Value;
        }
        private void ViewFOVTrack_Scroll(object sender, ScrollEventArgs e)
        {
            viewFOVInfo.Text = "Value -> " + viewFOVTrack.Value.ToString();
        }
        private void FOVTrack_Scroll(object sender, ScrollEventArgs e)
        {
            fovInfo.Text = "Value-> " + FOVTrack.Value.ToString();
            MiscConfig.ViewModelFOVValue = FOVTrack.Value;
        }
        #endregion

        #region Clan Tag Buttons
        private void ApplyClantagBtn_Click(object sender, EventArgs e)
        {
            MiscConfig.SelectedClanTag = SelectedClantagText.Text;
            ClanTagChanger.ChangeClanTag(MiscConfig.SelectedClanTag);
        }
        #endregion

        #endregion

        #region Settings

        #region Performance Buttons
        private void PerfVHigh_CheckedChanged(object sender, EventArgs e)
        {
            CheatPerf = PerformanceTimes.VHIGH;
        }
        private void PerfHigh_CheckedChanged(object sender, EventArgs e)
        {
            CheatPerf = PerformanceTimes.HIGH;
        }
        private void PerfNormal_CheckedChanged(object sender, EventArgs e)
        {
            CheatPerf = PerformanceTimes.NORMAL;
        }
        private void PerMedium_CheckedChanged(object sender, EventArgs e)
        {
            CheatPerf = PerformanceTimes.MEDIUM;
        }
        private void PerfLow_CheckedChanged(object sender, EventArgs e)
        {
            CheatPerf = PerformanceTimes.LOW;
        }
        private void PerfVLow_CheckedChanged(object sender, EventArgs e)
        {
            CheatPerf = PerformanceTimes.VERYLOW;
        }
        private void PerfTrash_CheckedChanged(object sender, EventArgs e)
        {
            CheatPerf = PerformanceTimes.TRASH;
        }
        #endregion

        #region DEVBUTTON
        private void DevMenuButton_Click(object sender, EventArgs e)
        {
            devFrm.Show();
        }
        #endregion

        #endregion

        #region Aimbot
        private void AimbotButton_CheckedChanged(object sender, EventArgs e)
        {
            if (aimbotButton.Checked)
            {
                Console.Beep((int)BeepVoice.HIGHFREQ, (int)BeepVoice.DURATION);
                CheatStatus.AimbotActive = true;
            }
            else
            {
                Console.Beep((int)BeepVoice.LOWFREQ, (int)BeepVoice.DURATION);
                CheatStatus.AimbotActive = false;
            }
        }
        private void BoneHEAD_CheckedChanged(object sender, EventArgs e)
        {
            AimBotConfig.SelectedBone = Bones.HEAD;
        }
        private void BoneNECK_CheckedChanged(object sender, EventArgs e)
        {
            AimBotConfig.SelectedBone = Bones.NECK;
        }
        private void BoneBODY_CheckedChanged(object sender, EventArgs e)
        {
            AimBotConfig.SelectedBone = Bones.BODY;
        }
        private void BoneLLEG_CheckedChanged(object sender, EventArgs e)
        {
            AimBotConfig.SelectedBone = Bones.LEFT_LEG;
        }
        private void BoneRLEG_CheckedChanged(object sender, EventArgs e)
        {
            AimBotConfig.SelectedBone = Bones.RIGHT_LEG;
        }
        private void AimKeyCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            AimBotConfig.LockKey = (KeysList)aimKeyCombo.SelectedIndex;
        }
        #endregion

        #endregion

        private void MetroToggle1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

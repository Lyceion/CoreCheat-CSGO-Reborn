using System;
using System.Numerics;
using System.Threading;
using System.Diagnostics;
using System.Windows.Forms;
using CoreCheat_Reborn.Classes;
using CoreCheat_Reborn.SDK.Parsers;
using CoreCheat_Reborn.SDK.Entities;
using CoreCheat_Reborn.SDK.Managers;
using CoreCheat_Reborn.CheatClasses;
using CoreCheat_Reborn.SDK.Controllers;
using static CoreCheat_Reborn.CheatClasses.Enums;
using static CoreCheat_Reborn.Versions.Panorama.Settings;
using static CoreCheat_Reborn.CheatClasses.Offsets.others;
using static CoreCheat_Reborn.CheatClasses.Offsets.netvars;
using static CoreCheat_Reborn.CheatClasses.Offsets.signatures;

namespace CoreCheat_Reborn.Versions.Panorama
{
    public partial class Main : MetroFramework.Forms.MetroForm
    {
        private static string infoStr;
        public void Inject_FormClosing(object sender, FormClosingEventArgs e)
        {
            glowButton.Checked = false;
            flashButton.Checked = false;
            radarButton.Checked = false;
            bunnyButton.Checked = false;
            triggerButton.Checked = false;
            chamsButton.Checked = false;
            autoPistolButton.Checked = false;
            viewType.SelectedIndex = 0;
            noHandsButton.Checked = false;
            removeScopeButton.Checked = false;
            bombTrajectButton.Checked = false;
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
            AddInfo("Name", Global.ProgramName);
            AddInfo("Cheat Version", Global.ProgramVersion);
            AddInfo("Build Date", Global.CompileDate);
            AddInfo("Owner", "Cylops");
            infoTXT.Text = infoStr;
        }
        public static void AddInfo(string name, object data)
        {
            infoStr += "[" + name + "] => " + data.ToString() + Environment.NewLine;
        }
        public static void LoadConfig(string ConfigName, string key)
        {
            INIParser.Load(ConfigName);
            INIParser.Read(INIParser.Categorys.MISCS, "ClanTagName");
        }
        public void InitializeCheat()
        {
            Process[] p = Process.GetProcessesByName("csgo");
            CylMem.OpenProcess(p[0].Id);
            Modules.ClientDLLAdress = Modules.GetModule("csgo", Modules.ClientDLLName);
            Modules.EngineDLLAdress = Modules.GetModule("csgo", Modules.EngineDLLName);
#if DEBUG
            //var a = SigScan.ScanPattern(Modules.EngineDLLName, "53 56 57 8B DA 8B F9 FF 15", 0,0,false);
            //    MessageBox.Show(a.ToString() + "  " + dwSetClanTag.ToString());
            //dwClientCmd = SigScan.ScanPattern(Modules.EngineDLLName, "55 8B EC 8B 0D ? ? ? ? 81 F9 ? ? ? ? 75 0C A1 ? ? ? ? 35 ? ? ? ? EB 0B") - Modules.EngineDLLAdress;
#endif
            CLocalPlayer.SetClantag("Core-Project", "Core-Project");
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
            realDotHider.Visible = true;
            mainTab.SelectedIndex = 0;
        }
        public void AttachDevEssentials()
        {
            CheatInfo();
            adminModeAlert.Visible = true;
            Dev devFrm = new Dev();
            devFrm.Show();
            Width = 770;
            realDotHider.Visible = false;
            dotHider.Visible = true;
        }
        private static void MainThread()
        {
            if (Modules.IsModuleRunning(Modules.ClientDLLName))
            {
                while (true)
                {
                    if (CLocalPlayer.IsPlaying)
                    {
                        #region Cheats

                        #region PlayerLoop
                        for (int i = 0; i <= EngineClient.MaxPlayer; i++)
                        {
                            int EntBase = CylMem.ReadInt(Modules.ClientDLLAdress + dwEntityList + i * 0x10);
                            if (EntBase == 0) continue;
                            if (CEntityPlayer.isDormant(EntBase)) continue;
                            if (CEntityPlayer.isDead(EntBase)) continue;
                            if (CEntityPlayer.Team(EntBase) == Teams.NONE || CEntityPlayer.Team(EntBase) == Teams.SPECTATOR) continue;
                            if (CEntityPlayer.WeaponName(EntBase) == "NONE") continue;
                            #region Entity Cheats

                            #region Glow ESP (WallHack)
                            int GlowIndex = CylMem.ReadInt(EntBase + m_iGlowIndex);
                            if (CEntityPlayer.Team(EntBase) == Teams.TERRORIST && CheatStatus.WallActive && CEntityPlayer.isAlive(EntBase) && ((CLocalPlayer.Team != CEntityPlayer.Team(EntBase) && VisualConfig.glowEnemyTeam) || (CLocalPlayer.Team == CEntityPlayer.Team(EntBase) && VisualConfig.glowLocalTeam))) //T
                            {
                                if (VisualConfig.selectedGlowColor == VisualColor.ENGINE)
                                    CEntityPlayer.Glow(GlowIndex, VisualConfig.GlowEngineTerrorist, VisualConfig.selectedGlowStyle, VisualConfig.selectedGlowType);
                                else if (VisualConfig.selectedGlowColor == VisualColor.REDBLUE)
                                    CEntityPlayer.Glow(GlowIndex, VisualConfig.GlowRed, VisualConfig.selectedGlowStyle, VisualConfig.selectedGlowType);
                                else if (VisualConfig.selectedGlowColor == VisualColor.HEALTH)
                                    CEntityPlayer.Glow(GlowIndex, Parsers.ParseEnemyGlowHealth(CEntityPlayer.Health(EntBase)), VisualConfig.selectedGlowStyle, VisualConfig.selectedGlowType);
                            }
                            if (CEntityPlayer.Team(EntBase) == Teams.ANTI_TERRORIST && CheatStatus.WallActive && CEntityPlayer.isAlive(EntBase) && ((CLocalPlayer.Team != CEntityPlayer.Team(EntBase) && VisualConfig.glowEnemyTeam) || (CLocalPlayer.Team == CEntityPlayer.Team(EntBase) && VisualConfig.glowLocalTeam))) //AT
                            {
                                if (VisualConfig.selectedGlowColor == VisualColor.ENGINE)
                                    CEntityPlayer.Glow(GlowIndex, VisualConfig.GlowEngineATerrorist, VisualConfig.selectedGlowStyle, VisualConfig.selectedGlowType);
                                else if (VisualConfig.selectedGlowColor == VisualColor.REDBLUE)
                                    CEntityPlayer.Glow(GlowIndex, VisualConfig.GlowBlue, VisualConfig.selectedGlowStyle, VisualConfig.selectedGlowType);
                                else if (VisualConfig.selectedGlowColor == VisualColor.HEALTH)
                                    CEntityPlayer.Glow(GlowIndex, Parsers.ParseEnemyGlowHealth(CEntityPlayer.Health(EntBase)), VisualConfig.selectedGlowStyle, VisualConfig.selectedGlowType);
                            }
                            #endregion

                            #region Chams
                            if (CheatStatus.ChamsActive)
                            {
                                if (CEntityPlayer.Team(EntBase) == Teams.TERRORIST && CEntityPlayer.isAlive(EntBase)) //T
                                {
                                    if (VisualConfig.selectedChamsColor == VisualColor.ENGINE)
                                        CEntityPlayer.ApplyChams(VisualConfig.EngineTerroristColor, VisualConfig.ChamsBrightness ,EntBase);
                                    else if (VisualConfig.selectedChamsColor == VisualColor.REDBLUE)
                                        CEntityPlayer.ApplyChams(VisualConfig.Red, VisualConfig.ChamsBrightness, EntBase);
                                    else if (VisualConfig.selectedChamsColor == VisualColor.HEALTH)
                                        CEntityPlayer.ApplyChams(Parsers.ParseEnemyChamsHealth(CEntityPlayer.Health(EntBase)), VisualConfig.ChamsBrightness, EntBase);
                                }
                                if (CEntityPlayer.Team(EntBase) == Teams.ANTI_TERRORIST && CEntityPlayer.isAlive(EntBase)) //AT
                                {
                                    if (VisualConfig.selectedChamsColor == VisualColor.ENGINE)
                                        CEntityPlayer.ApplyChams(VisualConfig.EngineATerroristColor, VisualConfig.ChamsBrightness, EntBase);
                                    else if (VisualConfig.selectedChamsColor == VisualColor.REDBLUE)
                                        CEntityPlayer.ApplyChams(VisualConfig.Blue, VisualConfig.ChamsBrightness, EntBase);
                                    else if (VisualConfig.selectedChamsColor == VisualColor.HEALTH)
                                        CEntityPlayer.ApplyChams(Parsers.ParseEnemyChamsHealth(CEntityPlayer.Health(EntBase)), VisualConfig.ChamsBrightness, EntBase);
                                }
                            }
                            else
                                CEntityPlayer.ClearChams(EntBase);
                            #endregion

                            #region Engine Radar Hack
                            if (CheatStatus.RadarActive && !CEntityPlayer.isDead(EntBase))
                                CEntityPlayer.SpotPlayer(EntBase);
                            #endregion

                            #endregion

                        }
                        #endregion

                        #region BunnyHop
                        if (CheatStatus.BunnyActive)
                        {
                            if (Methods.HoldingKey(Keys.Space))
                            {
                                if (MiscConfig.SelectedBhopType == BunnyType.STRAFE)
                                {
                                    Vector3 PrevAngles = new Vector3();
                                    if (CLocalPlayer.Flag != FlagState.ONGROUND)
                                    {
                                        if (CLocalPlayer.ViewAngles.Y > PrevAngles.Y)
                                            CLocalPlayer.GoLeft();
                                        else if (CLocalPlayer.ViewAngles.Y < PrevAngles.Y)
                                            CLocalPlayer.GoRight();
                                        PrevAngles = CLocalPlayer.ViewAngles;
                                    }
                                }
                                if ((CLocalPlayer.Flag == FlagState.ONGROUND || CLocalPlayer.Flag == FlagState.CROUCHING))
                                    CLocalPlayer.Jump();
                            }
                        }
                        #endregion

                        #region AutoPistol
                        if (CheatStatus.AutoPistolActive)
                            if (Methods.HoldingKey(Keys.LButton))
                                if (CLocalPlayer.IsPistolWeapon)
                                    CLocalPlayer.ShootWithPointer(15);
                        #endregion

                        #region Trigger Bot
                        if (CheatStatus.TriggerActive)
                        {
                            if (AssistsConfig.TriggerKey == KeysList.NOKEYS || (AssistsConfig.TriggerKey != KeysList.NOKEYS && Methods.HoldingKey(Parsers.KeyListToRealKey(AssistsConfig.TriggerKey))))
                            {
                                if (CLocalPlayer.IsCloseRangeWeapon) continue;
                                if (CLocalPlayer.IsThrowableWeapon) continue;
                                else
                                {
                                    int CrossEntity;
                                    if (CylMem.ReadInt(Modules.ClientDLLAdress + dwEntityList + (CLocalPlayer.CrossID - 1) * 0x10) == -1)
                                        CrossEntity = 0;
                                    else
                                        CrossEntity = CylMem.ReadInt(Modules.ClientDLLAdress + dwEntityList + (CLocalPlayer.CrossID - 1) * 0x10);
                                    if (CrossEntity == 0) continue;
                                    if (CEntityPlayer.isDormant(CrossEntity)) continue;
                                    if (CEntityPlayer.isDead(CrossEntity)) continue;
                                    if (CEntityPlayer.Team(CrossEntity) == Teams.NONE || CEntityPlayer.Team(CrossEntity) == Teams.SPECTATOR) continue;
                                    if (CEntityPlayer.WeaponName(CrossEntity) == "NONE") continue;
                                    if (AssistsConfig.isNoScope)
                                    {
                                        if (CLocalPlayer.CrossID > 0 && CLocalPlayer.CrossID <= EngineClient.MaxPlayer && ((CEntityPlayer.Team(CrossEntity) == CLocalPlayer.Team && AssistsConfig.isFriendlyFire) || (CEntityPlayer.Team(CrossEntity) != CLocalPlayer.Team)))
                                        {
                                            if (CEntityPlayer.isAlive(CrossEntity) && CLocalPlayer.CrossID >= 0)
                                            {
                                                for (int i = 0; i < 2; i++)
                                                {
                                                    if (CLocalPlayer.IsPistolWeapon)
                                                    {
                                                        CLocalPlayer.ShootWithPointer(new Random().Next(7, 20));
                                                        continue;
                                                    }
                                                    else if (AssistsConfig.isSprayRandom)
                                                        CLocalPlayer.ShootWithPointer(new Random().Next(7, 20));
                                                    else
                                                        CLocalPlayer.ShootWithPointer(WeaponSettings.TriggerSprayTime);
                                                }
                                            }
                                        }
                                    }
                                    else if (!CLocalPlayer.Scoped)
                                    {
                                        if (CLocalPlayer.IsScopedWeapon)
                                            continue;
                                        else
                                        {
                                            if (CLocalPlayer.CrossID > 0 && CLocalPlayer.CrossID <= EngineClient.MaxPlayer && ((CEntityPlayer.Team(CrossEntity) == CLocalPlayer.Team && AssistsConfig.isFriendlyFire) || (CEntityPlayer.Team(CrossEntity) != CLocalPlayer.Team)))
                                            {
                                                if ((CEntityPlayer.Team(CrossEntity) != CLocalPlayer.Team) && CEntityPlayer.isAlive(CrossEntity) && CLocalPlayer.CrossID >= 0)
                                                {
                                                    for (int i = 0; i < 2; i++)
                                                    {
                                                        if (CLocalPlayer.IsPistolWeapon)
                                                        {
                                                            CLocalPlayer.ShootWithPointer(new Random().Next(7, 20));
                                                            continue;
                                                        }
                                                        else if (AssistsConfig.isSprayRandom)
                                                            CLocalPlayer.ShootWithPointer(new Random().Next(7, 20));
                                                        else
                                                            CLocalPlayer.ShootWithPointer(WeaponSettings.TriggerSprayTime);
                                                    }
                                                }
                                            }
                                        }
                                    }
                                    else
                                    {
                                        if (CLocalPlayer.CrossID > 0 && CLocalPlayer.CrossID <= EngineClient.MaxPlayer)
                                        {
                                            if (CLocalPlayer.CrossID > 0 && CLocalPlayer.CrossID <= EngineClient.MaxPlayer && ((CEntityPlayer.Team(CrossEntity) == CLocalPlayer.Team && AssistsConfig.isFriendlyFire) || (CEntityPlayer.Team(CrossEntity) != CLocalPlayer.Team)))
                                            {
                                                for (int i = 0; i < 2; i++)
                                                {
                                                    if (CLocalPlayer.IsPistolWeapon)
                                                    {
                                                        CLocalPlayer.ShootWithPointer(new Random().Next(7, 20));
                                                        continue;
                                                    }
                                                    else if (AssistsConfig.isSprayRandom)
                                                        CLocalPlayer.ShootWithPointer(new Random().Next(7, 20));
                                                    else
                                                        CLocalPlayer.ShootWithPointer(WeaponSettings.TriggerSprayTime);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                            
                        }
                        #endregion

                        #region No Flash
                        if (CheatStatus.FlashActive)
                            CLocalPlayer.RemoveFlash();
                        else if (!CheatStatus.FlashActive)
                            CLocalPlayer.AddFlash();
                        #endregion

                        #region No Hands
                        if (CheatStatus.NoHandsActive)
                            CLocalPlayer.RemoveHands();
                        if (!CheatStatus.NoHandsActive)
                            CLocalPlayer.AddHands();
                        #endregion

                        #region Remove Scope
                        if (CheatStatus.RemoveScopeActive)
                            if(CLocalPlayer.ScopeLevel != ScopeLevels.NOTSCOPED)
                                CLocalPlayer.Scoped = false;
                        #endregion

                        #region ViewModel FOV
                        if (CLocalPlayer.ScopeLevel == ScopeLevels.NOTSCOPED)
                            CLocalPlayer.ViewModelFOV = MiscConfig.ViewModelFOVValue;
                        #endregion

                        #region Recoil Control System
                        if (CheatStatus.RCSActive)
                        {
                            if (CLocalPlayer.ShootedBullets >= WeaponSettings.RCSShootFired && !CLocalPlayer.IsPistolWeapon)
                            {
                                AssistsConfig.NewViewAngles.X = ((CLocalPlayer.ViewAngles.X + AssistsConfig.OldAimPunch.X) - (CLocalPlayer.AimPunchAngles.X * 2f));
                                AssistsConfig.NewViewAngles.Y = ((CLocalPlayer.ViewAngles.Y + AssistsConfig.OldAimPunch.Y) - (CLocalPlayer.AimPunchAngles.Y * 2f));
                                AssistsConfig.NewViewAngles.Z = 0;
                                Parsers.ClampAngle(AssistsConfig.NewViewAngles);
                                AssistsConfig.OldAimPunch.X = CLocalPlayer.AimPunchAngles.X * 2f;
                                AssistsConfig.OldAimPunch.Y = CLocalPlayer.AimPunchAngles.Y * 2f;
                                AssistsConfig.OldAimPunch.Z = 0;
                                CLocalPlayer.ViewAngles = AssistsConfig.NewViewAngles;
                            }
                            else
                                AssistsConfig.OldAimPunch.X = AssistsConfig.OldAimPunch.Y = AssistsConfig.OldAimPunch.Z = 0;
                        }
                        #endregion

                        #region Bomb (Grenade) Trajectory
                        if (CheatStatus.BombTrajectoryActive)
                            EngineClient.ShowBombTrajectory();
                        else if (!CheatStatus.BombTrajectoryActive)
                            EngineClient.HideBombTrajectory();
                        #endregion

                        #region No Smoke
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
                        #endregion

                        #region Aimbot
                        if(CheatStatus.AimbotActive)
                            AimBotControllerNEW.DoAimbot(AimBotControllerNEW.FindPlayer());
                        #endregion

                        #endregion

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
            CLocalPlayer.SetClantag(MiscConfig.SelectedClanTag, MiscConfig.SelectedClanTag);
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

        #endregion

        #endregion
    }
}

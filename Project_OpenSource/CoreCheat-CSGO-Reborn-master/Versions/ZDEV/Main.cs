using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;
using System.Numerics;
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
namespace CoreCheat_Reborn.Versions.ZDEV
{
    public partial class Main : Form
    {
        public static bool aimbot = true,
                                wallhack = true;
        public static Main mn;
        public Main()
        {
            InitializeComponent();
            InitializeCheat();
            AttachDevEssentials();
            Main.mn = this;

        }
      
        public void AttachDevEssentials()
        {
            
        }
        public void InitializeCheat()
        {
            Process[] p = Process.GetProcessesByName("csgo");
            CylMem.OpenProcess(p[0].Id);
            Modules.ClientDLLAdress = Modules.GetModule("csgo", Modules.ClientDLLName);
            Modules.EngineDLLAdress = Modules.GetModule("csgo", Modules.EngineDLLName);
            Thread Cheats = new Thread(new ThreadStart(MainThread));
            Cheats.Start();
        }
        public void log(String message) {
                richTextBox1.Text += message + Environment.NewLine;
                }
        public void log(String message,String Tag)
        {
            
            log(String.Format("[{0}] {1}",message,Tag));
        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            // scroll it automatically
            richTextBox1.ScrollToCaret();
        }
        public static Main getInstance()
        {
            return mn;
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
;        }

        private static void MainThread()
        {
            Main m = Main.getInstance();
            m.log("Main Thread Started");
            m.log("A:" + aimbot.ToString());
            AimBotController aimbotController = new AimBotController();
            if (Modules.IsModuleRunning(Modules.ClientDLLName))
            {
                while (true)
                {
                    if (CLocalPlayer.IsPlaying)
                    {
                        #region Aimbot-Start
                        if (aimbot)
                            aimbotController.setFrom(CLocalPlayer.Position);
                        #endregion

                        #region PlayerLoop
                        for (int i = 0; i <= EngineClient.MaxPlayer; i++)
                        {
                            #region Entity Cheats
                            int EntBase = CylMem.ReadInt(Modules.ClientDLLAdress + dwEntityList + i * 0x10);
                            if (EntBase == 0) continue;
                            if (CEntityPlayer.isDormant(EntBase)) continue;
                            #region Aimbot-GetClosestPlayer
                            int health = CEntityPlayer.Health(EntBase);
                            Teams team = CEntityPlayer.Team(EntBase);
                            if (CheatStatus.AimbotActive &&
                                team != CLocalPlayer.Team &&
                                team != Teams.SPECTATOR &&
                                team != Teams.NONE &&
                                CEntityPlayer.isAlive(EntBase) &&
                                health > 0 && health <= 100
                                )
                            {
                                aimbotController.closestEngine(EntBase, CEntityPlayer.Position(EntBase));
                            }
                            #endregion
                            #endregion

                        }
                        #region Aimbot-Target
                        if (aimbot)
                        {
                            int target_aim_entbase = aimbotController.closestPlayerEntityBase;
                            Vector3 target_aim_vector = aimbotController.closestPlayerVector;
                            if (CEntityPlayer.isPlayerSpotted(target_aim_entbase) && Methods.HoldingKey(Keys.LButton))
                            {
                                Vector3 raw = aimbotController.CalcAngle(target_aim_vector);
                                Vector3 raw_unp = aimbotController.RemovePunch(raw) ;
                                Vector3 target_angle = Parsers.ClampAngle(raw_unp);
                                CLocalPlayer.ViewAngles = target_angle;

                                //m.log(
                                //    String.Format("Closest Player x:{0} y:{1} z:{2} Distance : {3}", target_aim_vector.X, target_aim_vector.Y, target_aim_vector.Z,aimbotController.target_distance),
                                //    "Aimbot Closest"
                                //    );
                                //m.log(
                                //    String.Format("Angle x:{0} y:{1} z:{2} Distance : {3}", raw_unp.X, raw_unp.Y, raw_unp.Z, aimbotController.target_distance),
                                //    "Aimbot Closest"
                                //    );
                            }
                        }

                        #endregion
                        #endregion
                    }
                }
            }
        }
    }
}

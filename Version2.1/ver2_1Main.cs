using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CylMem = CoreCheat_Reborn.Class_Memory;

namespace CoreCheat_Reborn.Version2._1
{
    public partial class ver2_1Main : MetroFramework.Forms.MetroForm
    {
        [DllImport("user32", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int GetAsyncKeyState(int vKey);
        public static int Client;
        public static Module clientModule = new Module("client.dll");
        public static Module engineModule = new Module("engine.dll");
        public static int performance = 180;
        public static int sprTime = 10;
        public ver2_1Main()
        {
            InitializeComponent();
        }
        public class HackStats
        {
            public static bool wallhack_use = false;
            public static bool bunnyhop_use = false;
            public static bool triggetbot_use = false;
            public static bool antiflash_use = false;
            public static bool fov_use = false;
            public static bool gui = false;
            public static bool enemyGlow = true;
            public static bool teamGlow = true;
            public static bool trigScope = true;
        }
        public struct Module
        {
            public string moduleName;
            public int moduleAddress;
            public bool fp;
            public Module(string moduleName_)
            {
                moduleName = moduleName_;
                moduleAddress = 0x000000;
                try
                {
                    Process[] p = Process.GetProcessesByName("csgo");

                    if (p.Length > 0)
                    {
                        foreach (ProcessModule m in p[0].Modules)
                        {
                            if (m.ModuleName == moduleName_)
                            {
                                moduleAddress = (Int32)m.BaseAddress;

                                fp = true;
                            }
                        }
                        fp = true;

                    }
                    else
                    {
                        fp = false;
                    }
                }
                catch
                {
                    fp = false;
                }
            }
        }
        public static string EnabledTXT = "Source By Cylops";
        private void ver2Main_Load(object sender, EventArgs e)
        {
            GetModuleAddress();
            Thread wall = new Thread(new ThreadStart(wallHack));
            wall.Start();
            Thread trigger = new Thread(new ThreadStart(dwTriggerBot));
            trigger.Start();
            Thread antiflash = new Thread(new ThreadStart(dwAntiFlash));
            antiflash.Start();
            Thread bunny = new Thread(new ThreadStart(bunnyHop));
            bunny.Start();
            spryTime.Text = Convert.ToString(sprTime);
            CheatMenu.SelectedIndex = 0;
        }
        private static string RandomString(int length)
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            string input = "#$!%&?}{][ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var chars = Enumerable.Range(0, length).Select(x => input[random.Next(0, input.Length)]);
            return new string(chars.ToArray());
        }

        public static bool GetModuleAddress()
        {

            try
            {
                Process[] p = Process.GetProcessesByName("csgo");

                if (p.Length > 0)
                {
                    foreach (ProcessModule m in p[0].Modules)
                    {
                        if (m.ModuleName == "client.dll")
                        {
                            Client = (int)m.BaseAddress;
                            return true;
                        }
                    }

                    return true;
                }
                else
                {
                    Console.WriteLine("not found.");
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }
        public struct GlowStruct
        {
            public float r;
            public float g;
            public float b;
            public float a;
            public bool rwo;
            public bool rwuo;
        }
        public class Offsets
        {
            public static int oLocalPlayer = 0xAB6D4C;
            public static int oTeam = 0xF0;
            public static int oEntityList = 0x4A92384;
            public static int oDormat = 0xE9;
            public static int oGlowIndex = 0xA320;
            public static int oGlowObject = 0x4FC1ED8;
            public static int oFlashMaxAlpha = 0xA304;
            public static int oFlashDuration = 0xA308;
            public static int oFlag = 0x100;
            public static int bClient = 0x586A74;
            public static int aJump = 0x4F2C870;
            public static int oAttack = 0x2ED4720;
            public static int aCross = 0xB2B8;
            public static int oHelth = 0xFC;
            public static int aActiveW = 0x2EE8;
            public static int oScope = 0x388E;
            public static int aGameChck = 0x108;
            public static int oMyWP = 0x2DE8;
            public static int aItemDef = 0x2F9A;
            public static int oDefaultFOV = 0x330C;
        }
        public static float flashMaxAlpha
        {
            get
            {
                int BaseAddress = CylMem.ReadInt((int)clientModule.moduleAddress + Offsets.oLocalPlayer);
                return CylMem.ReadFloat((int)BaseAddress + Offsets.oFlashMaxAlpha);
            }
            set
            {
                int BaseAddress = CylMem.ReadInt((int)clientModule.moduleAddress + Offsets.oLocalPlayer);
                CylMem.WriteFloat((int)BaseAddress + Offsets.oFlashDuration, (float)value);
                CylMem.WriteFloat((int)BaseAddress + Offsets.oFlashMaxAlpha, (float)value);
            }
        }
        private void MainFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
        public static void wallHack()
        {
            Process[] p = Process.GetProcessesByName("csgo");
            foreach (var proc in p)
                CylMem.OpenProcess(proc.Id);
            if (GetModuleAddress())
                while (true)
                {
                    int EngineBase = CylMem.ReadInt(engineModule.moduleAddress + Offsets.bClient);
                    int GameState = CylMem.ReadInt(EngineBase + Offsets.aGameChck);
                    if (GameState == 6)
                    {
                        Thread.Sleep(performance);
                        if (HackStats.wallhack_use)
                        {
                            GlowStruct Enemy = new GlowStruct()
                            {
                                r = 1f,
                                g = 0,
                                b = 0,
                                a = 0.8f,
                                rwo = true,
                                rwuo = false
                            };

                            GlowStruct Team = new GlowStruct()
                            {
                                r = 0,
                                g = 0.5f,
                                b = 255,
                                a = 0.5f,
                                rwo = true,
                                rwuo = false
                            };

                            int address;
                            int i = 1;

                            do
                            {
                                address = Client + Offsets.oLocalPlayer;
                                int Player = CylMem.ReadInt((int)address);

                                address = Player + Offsets.oTeam;
                                int MyTeam = CylMem.ReadInt((int)address);

                                address = Client + Offsets.oEntityList + (i - 1) * 0x10;
                                int EntityList = CylMem.ReadInt((int)address);

                                address = EntityList + Offsets.oTeam;
                                int HisTeam = CylMem.ReadInt((int)address);

                                address = EntityList + Offsets.oDormat;

                                if (!CylMem.ReadBool((int)address))
                                {
                                    address = EntityList + Offsets.oGlowIndex;

                                    int GlowIndex = CylMem.ReadInt((int)address);

                                    if (MyTeam != HisTeam)
                                    {
                                        if (HackStats.enemyGlow == true)
                                        {
                                            address = Client + Offsets.oGlowObject;
                                            int GlowObject = CylMem.ReadInt((int)address);

                                            int calculation = GlowIndex * 0x38 + 0x4;
                                            int current = GlowObject + calculation;
                                            CylMem.WriteFloat((int)current, Enemy.r);

                                            calculation = GlowIndex * 0x38 + 0x8;
                                            current = GlowObject + calculation;
                                            CylMem.WriteFloat((int)current, Enemy.g);

                                            calculation = GlowIndex * 0x38 + 0xC;
                                            current = GlowObject + calculation;
                                            CylMem.WriteFloat((int)current, Enemy.b);

                                            calculation = GlowIndex * 0x38 + 0x10;
                                            current = GlowObject + calculation;
                                            CylMem.WriteFloat((int)current, Enemy.a);

                                            calculation = GlowIndex * 0x38 + 0x24;
                                            current = GlowObject + calculation;
                                            CylMem.WriteBoolean((int)current, Enemy.rwo);

                                            calculation = GlowIndex * 0x38 + 0x25;
                                            current = GlowObject + calculation;
                                            CylMem.WriteBoolean((int)current, Enemy.rwuo);
                                        }
                                    }
                                    else
                                    {
                                        if (HackStats.teamGlow == true)
                                        {
                                            address = Client + Offsets.oGlowObject;
                                            int GlowObject = CylMem.ReadInt((int)address);

                                            int calculation = GlowIndex * 0x38 + 0x4;
                                            int current = GlowObject + calculation;
                                            CylMem.WriteFloat((int)current, Team.r);

                                            calculation = GlowIndex * 0x38 + 0x8;
                                            current = GlowObject + calculation;
                                            CylMem.WriteFloat((int)current, Team.g);

                                            calculation = GlowIndex * 0x38 + 0xC;
                                            current = GlowObject + calculation;
                                            CylMem.WriteFloat((int)current, Team.b);

                                            calculation = GlowIndex * 0x38 + 0x10;
                                            current = GlowObject + calculation;
                                            CylMem.WriteFloat((int)current, Team.a);

                                            calculation = GlowIndex * 0x38 + 0x24;
                                            current = GlowObject + calculation;
                                            CylMem.WriteBoolean((int)current, Team.rwo);

                                            calculation = GlowIndex * 0x38 + 0x25;
                                            current = GlowObject + calculation;
                                            CylMem.WriteBoolean((int)current, Team.rwuo);
                                        }
                                    }
                                }
                                i++;
                            } while (i < 65);
                        }
                    }
                }
        }

        private void perCounter_Tick(object sender, EventArgs e)
        {
            if (perfHigh.Checked == true)
            {
                performance = 0;
            }
            else if (perfNorm.Checked == true)
            {
                performance = 60;
            }
            else if (perfLess.Checked == true)
            {
                performance = 190;
            }
            else
            {
                performance = 190;
            }
        }

        private void titleChanger_Tick(object sender, EventArgs e)
        {
            this.Text = "CoreProject CS:GO v2.1                                                                            " + RandomString(30);
        }
        public static void dwTriggerBot()
        {
            if (GetModuleAddress())
            {
                int fAttack = Client + Offsets.oAttack;
                Random random = new Random();
                while (true)
                {
                    int EngineBase = CylMem.ReadInt(engineModule.moduleAddress + Offsets.bClient);
                    int GameState = CylMem.ReadInt(EngineBase + Offsets.aGameChck);
                    int a = 1;
                    if (GameState == 6)
                    {
                        if (HackStats.triggetbot_use)
                        {
                                int PlayerBase = CylMem.ReadInt(clientModule.moduleAddress + Offsets.oLocalPlayer);
                                int LocalBase = CylMem.ReadInt(clientModule.moduleAddress + Offsets.oLocalPlayer);
                                int WeaponHandle = CylMem.ReadInt(LocalBase + 0x2EE8);
                                WeaponHandle &= 0xFFF;
                                int WeaponEntity = CylMem.ReadInt(clientModule.moduleAddress + Offsets.oEntityList + (WeaponHandle - 1) * 0x10);
                                int IsScoped = CylMem.ReadInt(PlayerBase + Offsets.oScope);
                                int WeaponIndex = CylMem.ReadInt(WeaponEntity + 0x2F9A);
                                //Debug.Print("IsScoped: " + IsScoped);
                                if (HackStats.trigScope == true)
                                {
                                    int address = Client + Offsets.oLocalPlayer;
                                    int LocalPlayer = CylMem.ReadInt(address);

                                    address = LocalPlayer + Offsets.oTeam;
                                    int MyTeam = CylMem.ReadInt(address);

                                    address = LocalPlayer + Offsets.aCross;
                                    int PlayerInCross = CylMem.ReadInt(address);

                                    if (PlayerInCross > 0 && PlayerInCross < 65)
                                    {
                                        address = Client + Offsets.oEntityList + (PlayerInCross - 1) * 0x0000010;
                                        int PtrToPIC = CylMem.ReadInt(address);

                                        address = PtrToPIC + Offsets.oHelth;
                                        int PICHealth = CylMem.ReadInt(address);

                                        address = PtrToPIC + Offsets.oTeam;
                                        int PICTeam = CylMem.ReadInt(address);


                                        if ((PICTeam != MyTeam) && (PICTeam > 1) && (PICHealth > 0))
                                        {
                                            for (int i = 0; i < 2; i++)
                                            {
                                                CylMem.WriteInt(fAttack, 1);
                                                Thread.Sleep(sprTime);
                                                CylMem.WriteInt(fAttack, 4);
                                            }
                                        }

                                    }

                                    Thread.Sleep(10);
                                }
                                else
                                {
                                    if (IsScoped != 1)
                                    {
                                        //Debug.Print("Weapon ID: " + WeaponIndex);

                                        if (WeaponIndex == 9) //AWP
                                        {

                                        }
                                        else if (WeaponIndex == 11) //T AUTO
                                        {

                                        }
                                        else if (WeaponIndex == 40) //SSG
                                        {

                                        }
                                        else if (WeaponIndex == 38) //CT AUTO
                                        {

                                        }
                                        else
                                        {
                                            int address = Client + Offsets.oLocalPlayer;
                                            int LocalPlayer = CylMem.ReadInt(address);

                                            address = LocalPlayer + Offsets.oTeam;
                                            int MyTeam = CylMem.ReadInt(address);

                                            address = LocalPlayer + Offsets.aCross;
                                            int PlayerInCross = CylMem.ReadInt(address);

                                            if (PlayerInCross > 0 && PlayerInCross < 65)
                                            {
                                                address = Client + Offsets.oEntityList + (PlayerInCross - 1) * 0x0000010;
                                                int PtrToPIC = CylMem.ReadInt(address);

                                                address = PtrToPIC + Offsets.oHelth;
                                                int PICHealth = CylMem.ReadInt(address);

                                                address = PtrToPIC + Offsets.oTeam;
                                                int PICTeam = CylMem.ReadInt(address);


                                                if ((PICTeam != MyTeam) && (PICTeam > 1) && (PICHealth > 0))
                                                {
                                                    for (int i = 0; i < 2; i++)
                                                    {
                                                        CylMem.WriteInt(fAttack, 1);
                                                        Thread.Sleep(sprTime);
                                                        CylMem.WriteInt(fAttack, 4);
                                                    }
                                                }
                                            }
                                            Thread.Sleep(10);
                                        }
                                    }
                                    else
                                    {
                                        int address = Client + Offsets.oLocalPlayer;
                                        int LocalPlayer = CylMem.ReadInt(address);

                                        address = LocalPlayer + Offsets.oTeam;
                                        int MyTeam = CylMem.ReadInt(address);

                                        address = LocalPlayer + Offsets.aCross;
                                        int PlayerInCross = CylMem.ReadInt(address);

                                        if (PlayerInCross > 0 && PlayerInCross < 65)
                                        {
                                            address = Client + Offsets.oEntityList + (PlayerInCross - 1) * 0x0000010;
                                            int PtrToPIC = CylMem.ReadInt(address);

                                            address = PtrToPIC + Offsets.oHelth;
                                            int PICHealth = CylMem.ReadInt(address);

                                            address = PtrToPIC + Offsets.oTeam;
                                            int PICTeam = CylMem.ReadInt(address);


                                            if ((PICTeam != MyTeam) && (PICTeam > 1) && (PICHealth > 0))
                                            {
                                                for (int i = 0; i < 2; i++)
                                                {
                                                    CylMem.WriteInt(fAttack, 1);
                                                    Thread.Sleep(sprTime);
                                                    CylMem.WriteInt(fAttack, 4);
                                                }
                                            }
                                        }
                                        Thread.Sleep(10);
                                    }
                                }

                            };
                        }
                    }
                }
            }
        public static void dwAntiFlash()
        {
            if (GetModuleAddress())
            {
                int BaseAddress = CylMem.ReadInt((int)clientModule.moduleAddress + Offsets.oLocalPlayer);
                float flashVal = CylMem.ReadFloat((int)BaseAddress + Offsets.oFlashMaxAlpha);
                while (true)
                {
                    int EngineBase = CylMem.ReadInt(engineModule.moduleAddress + Offsets.bClient);
                    int GameState = CylMem.ReadInt(EngineBase + Offsets.aGameChck);
                    if (HackStats.antiflash_use == true)
                    {
                        if (GameState == 6)
                        {
                            flashMaxAlpha = 0f;
                            Thread.Sleep(350);
                        }
                    }
                    else
                    {
                        flashMaxAlpha = 255f;
                    }
                }
            }
        }
        public static void bunnyHop()
        {
            while (true)
            {
                int EngineBase = CylMem.ReadInt(engineModule.moduleAddress + Offsets.bClient);
                int GameState = CylMem.ReadInt(EngineBase + Offsets.aGameChck);
                if (GameState == 6)
                {
                    if (HackStats.bunnyhop_use == true)
                    {
                        int spacekey = GetAsyncKeyState(32);
                        if (spacekey <= -32768)
                        {
                            Process[] p = Process.GetProcessesByName("csgo");
                            foreach (var proc in p)
                                CylMem.OpenProcess(proc.Id);
                            int fJump = Client + Offsets.aJump;
                            int aLocalPlayer = Client + Offsets.oLocalPlayer;
                            int LocalPlayer = CylMem.ReadInt(aLocalPlayer);
                            int aFlags = LocalPlayer + Offsets.oFlag;
                            if (CylMem.ReadInt(aFlags) == 257)
                            {
                                CylMem.WriteInt(fJump, 5);
                                Thread.Sleep(10);
                                CylMem.WriteInt(fJump, 4);
                            }
                        }
                    }
                    Thread.Sleep(1);
                }
            }
        }

        private void keyTimer_Tick(object sender, EventArgs e)
        {
            int keyState_0 = GetAsyncKeyState(120);
            int keyState_1 = GetAsyncKeyState(113);
            int keyState_2 = GetAsyncKeyState(118);
            int keyState_3 = GetAsyncKeyState(114);
            if (keyState_2 < -32765)
            {
                if (HackStats.triggetbot_use == true)
                {
                    triggerChecked.Checked = false;
                }
                else
                {
                    triggerChecked.Checked = true;
                }
            }
            else if (keyState_3 < -32765)
            {
                if (HackStats.antiflash_use == true)
                {
                    flashButton.Checked = false;
                }
                else
                {
                    flashButton.Checked = true;
                }
            }
            else if (keyState_1 < -32765)
            {
                if (HackStats.wallhack_use == true)
                {
                    wallButton.Checked = false;
                }
                else
                {
                    wallButton.Checked = true;
                }
            }
            else if (keyState_0 < -32765)
            {
                if (HackStats.bunnyhop_use == true)
                {
                    bunnyChecked.Checked = false;
                }
                else
                {
                    bunnyChecked.Checked = true;
                }
            }
        }

        private void glowChck1_CheckedChanged(object sender, EventArgs e)
        {
            if (glowChck1.Checked == true)
            {
                HackStats.enemyGlow = true;

            }
            else
            {
                HackStats.enemyGlow = false;

            }
        }

        private void glowChck2_CheckedChanged(object sender, EventArgs e)
        {
            if (glowChck2.Checked == true)
            {
                HackStats.teamGlow = true;
            }
            else
            {
                HackStats.teamGlow = false;
            }
        }

        private void wallButton_CheckedChanged(object sender, EventArgs e)
        {
            if (wallButton.Checked == true)
            {
                HackStats.wallhack_use = true;
                Console.Beep();
            }
            else
            {
                HackStats.wallhack_use = false;
                Console.Beep();
            }
        }

        private void flashButton_CheckedChanged(object sender, EventArgs e)
        {
            if (flashButton.Checked == true)
            {
                HackStats.antiflash_use = true;
                Console.Beep();
            }
            else
            {
                HackStats.antiflash_use = false;
                Console.Beep();
            }
        }

        private void triggerChecked_CheckedChanged(object sender, EventArgs e)
        {
            if (triggerChecked.Checked == true)
            {
                HackStats.triggetbot_use = true;
                Console.Beep();
            }
            else
            {
                HackStats.triggetbot_use = false;
                Console.Beep();
            }
        }

        private void trigChck1_CheckedChanged(object sender, EventArgs e)
        {
            if (trigChck1.Checked == true)
            {
                HackStats.trigScope = true;
            }
            else
            {
                HackStats.trigScope = false;
            }
        }

        private void sprySave_Click(object sender, EventArgs e)
        {
            sprTime = Convert.ToInt32(spryTime.Text);
        }

        private void bunnyChecked_CheckedChanged(object sender, EventArgs e)
        {
            if (bunnyChecked.Checked == true)
            {
                HackStats.bunnyhop_use = true;
                Console.Beep();
            }
            else
            {
                HackStats.bunnyhop_use = false;
                Console.Beep();
            }
        }

        private void metroToggle1_CheckedChanged(object sender, EventArgs e)
        {
            if (metroToggle1.Checked == true)
            {
                keyTimer.Enabled = true;

            }
            else
            {
                keyTimer.Enabled = false;
            }
        }

        private void fovTrack_Scroll(object sender, ScrollEventArgs e)
        {
            fovValTXT.Text = "FOV Value => " + Convert.ToString(fovTrack.Value);
        }
        public static int FovChange
        {
            get
            {
                int BaseAddress = CylMem.ReadInt((int)clientModule.moduleAddress + Offsets.oLocalPlayer);
                return CylMem.ReadInt((int)BaseAddress + Offsets.oDefaultFOV);
            }
            set
            {
                int BaseAddress = CylMem.ReadInt((int)clientModule.moduleAddress + Offsets.oLocalPlayer);
                CylMem.WriteInt((int)BaseAddress + Offsets.oDefaultFOV, value);
            }
        }

        private void updFOV_Click(object sender, EventArgs e)
        {
            Console.Beep(1000, 250);
            FovChange = fovTrack.Value;
        }
    }
}

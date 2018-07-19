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

namespace CoreCheat_Reborn.Version0._3
{
    public partial class ver0_3Main : MetroFramework.Forms.MetroForm
    {
        public void Inject_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
        [DllImport("user32", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int GetAsyncKeyState(int vKey);
        public static int Client;
        public static Module clientModule = new Module("client_panorama.dll");
        public static Module engineModule = new Module("engine.dll");
        public static int performance = 180;
        public static string frmName;
        public static bool WallActive = false;
        public static bool aFlashActive = false;
        public static void dwAntiFlash()
        {
            if (GetModuleAddress())
            {
                while (true)
                {
                    int EngineBase = CylMem.ReadInt(engineModule.moduleAddress + Offsets.bClient);
                    if (aFlashActive == true)
                    {
                            flashMaxAlpha = 0f;
                            Thread.Sleep(350);
                    }
                    else
                    {
                        flashMaxAlpha = 255f;
                    }
                }
            }
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
        public ver0_3Main()
        {
            InitializeComponent();
        }

        private void ver0_3Main_Load(object sender, EventArgs e)
        {
            Thread wallHack = new Thread(new ThreadStart(wall));
            wallHack.Start();
            Thread antiflash = new Thread(new ThreadStart(dwAntiFlash));
            antiflash.Start();
        }

        private void fovTrack_Scroll(object sender, ScrollEventArgs e)
        {
            fovValTXT.Text = "FOV Value => " + Convert.ToString(fovTrack.Value);
        }

        private void updFOV_Click(object sender, EventArgs e)
        {
            Console.Beep(1000, 250);
            FovChange = fovTrack.Value;
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
                                Debug.Print(moduleAddress.ToString());
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
        public static bool GetModuleAddress()
        {

            try
            {
                Process[] p = Process.GetProcessesByName("csgo");

                if (p.Length > 0)
                {
                    foreach (ProcessModule m in p[0].Modules)
                    {
                        if (m.ModuleName == "client_panorama.dll")
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
        public class Offsets
        {
            public static int oLocalPlayer = 0xC5F80C;
            public static int oTeam = 0xF0;
            public static int oEntityList = 0x4C3C3EC;
            public static int oDormat = 0xE9;
            public static int oGlowIndex = 0xA320;
            public static int oGlowObject = 0x517C0E0;
            public static int oFlag = 0x100;
            public static int bClient = 0x586A74;
            public static int oHelth = 0xFC;
            public static int oDefaultFOV = 0x330C;
            public static int oFlashMaxAlpha = 0xA304;
            public static int oFlashDuration = 0xA308;
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
        private static void wall()
        {
            Process[] p = Process.GetProcessesByName("csgo");
            foreach (var proc in p)
                CylMem.OpenProcess(proc.Id);
            if (GetModuleAddress())
                while (true)
                {
                    int EngineBase = CylMem.ReadInt(engineModule.moduleAddress + Offsets.bClient);
                    int GameState = 1;//CylMem.ReadInt(EngineBase + Offsets.aGameChck);
                    if (GameState != 999)
                    {
                        //for (var i = 1; i < 16; ++i)
                        //{
                        //    int LocalBase = CylMem.ReadInt(clientModule.moduleAddress + Offsets.oLocalPlayer);
                        //    int WeaponHandle = CylMem.ReadInt(LocalBase + 0x2EE8 + (i - 1) * 0x4) & 0xFFF;
                        //    WeaponHandle &= 0xFFF;
                        //    int WeaponEntity = CylMem.ReadInt(clientModule.moduleAddress + 0x4A8574C + (WeaponHandle - 1) * 0x10);
                        //    int WeaponDefIndex = CylMem.ReadInt(WeaponEntity + 0x2F88);
                        //    if (WeaponDefIndex == 40)
                        //    {
                        //        CylMem.WriteInt(WeaponEntity + 0x2F88, 38);
                        //    }
                        //}
                        if (WallActive == true)
                        {
                            GlowStruct Terrorist = new GlowStruct()
                            {
                                r = 0.254f,
                                g = 0.236f,
                                b = 0.124f,
                                a = 2,
                                rwo = true,
                                rwuo = false
                            };
                            GlowStruct CTerrorist = new GlowStruct()
                            {
                                r = 0.113f,
                                g = 0.145f,
                                b = 0.204f,
                                a = 2,
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
                                    if (HisTeam == 2)
                                    {
                                        address = Client + Offsets.oGlowObject;
                                        int GlowObject = CylMem.ReadInt((int)address);

                                        int calculation = GlowIndex * 0x38 + 0x4;
                                        int current = GlowObject + calculation;
                                        CylMem.WriteFloat((int)current, Terrorist.r);

                                        calculation = GlowIndex * 0x38 + 0x8;
                                        current = GlowObject + calculation;
                                        CylMem.WriteFloat((int)current, Terrorist.g);

                                        calculation = GlowIndex * 0x38 + 0xC;
                                        current = GlowObject + calculation;
                                        CylMem.WriteFloat((int)current, Terrorist.b);

                                        calculation = GlowIndex * 0x38 + 0x10;
                                        current = GlowObject + calculation;
                                        CylMem.WriteFloat((int)current, Terrorist.a);

                                        calculation = GlowIndex * 0x38 + 0x24;
                                        current = GlowObject + calculation;
                                        CylMem.WriteBoolean((int)current, Terrorist.rwo);

                                        calculation = GlowIndex * 0x38 + 0x25;
                                        current = GlowObject + calculation;
                                        CylMem.WriteBoolean((int)current, Terrorist.rwuo);
                                    }
                                    else
                                    {
                                        if (WallActive == true)
                                        {
                                            address = Client + Offsets.oGlowObject;
                                            int GlowObject = CylMem.ReadInt((int)address);

                                            int calculation = GlowIndex * 0x38 + 0x4;
                                            int current = GlowObject + calculation;
                                            CylMem.WriteFloat((int)current, CTerrorist.r);

                                            calculation = GlowIndex * 0x38 + 0x8;
                                            current = GlowObject + calculation;
                                            CylMem.WriteFloat((int)current, CTerrorist.g);

                                            calculation = GlowIndex * 0x38 + 0xC;
                                            current = GlowObject + calculation;
                                            CylMem.WriteFloat((int)current, CTerrorist.b);

                                            calculation = GlowIndex * 0x38 + 0x10;
                                            current = GlowObject + calculation;
                                            CylMem.WriteFloat((int)current, CTerrorist.a);

                                            calculation = GlowIndex * 0x38 + 0x24;
                                            current = GlowObject + calculation;
                                            CylMem.WriteBoolean((int)current, CTerrorist.rwo);

                                            calculation = GlowIndex * 0x38 + 0x25;
                                            current = GlowObject + calculation;
                                            CylMem.WriteBoolean((int)current, CTerrorist.rwuo);
                                        }
                                    }

                                }
                                i++;
                            } while (i < 65);
                        }
                    }

                }
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

        private void glowToggle_CheckedChanged(object sender, EventArgs e)
        {
            if (glowToggle.Checked == true)
            {
                Console.Beep(600, 250);
                WallActive = true;
            }
            else
            {
                Console.Beep(400, 250);
                WallActive = false;
            }
        }

        private void titleTimer_Tick(object sender, EventArgs e)
        {
            this.Text = "PANAROMA SPECIAL                                       " + RandomString(30);
        }
        private static string RandomString(int length)
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            string input = "#$!%&?}{][ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var chars = Enumerable.Range(0, length).Select(x => input[random.Next(0, input.Length)]);
            return new string(chars.ToArray());
        }

        private void flashButton_CheckedChanged(object sender, EventArgs e)
        {
            if (flashButton.Checked == true)
            {
                aFlashActive = true;
                Console.Beep();
            }
            else
            {
                aFlashActive = false;
                Console.Beep();
            }
        }
    }
}

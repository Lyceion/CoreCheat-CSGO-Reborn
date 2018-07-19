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

namespace CoreCheat_Reborn.Version0._5
{
    public partial class ver0_5Main : Form
    {
       [DllImport("user32", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int GetAsyncKeyState(int vKey);
        public static int Client;
        public static Module clientModule = new Module("client.dll");
        public static Module engineModule = new Module("engine.dll");
        public static int performance = 180;
        public static string frmName;
        public static bool WallActive = false;
        public static bool AntiFlash = true;
        public ver0_5Main()
        {
            InitializeComponent();
        }
        private void ver0_5Main_Load(object sender, EventArgs e)
        {
            GetModuleAddress();
            Thread wallHck = new Thread(new ThreadStart(wall));
            wallHck.Start();
            Thread antiFlsh = new Thread(new ThreadStart(dwAntiFlash));
            antiFlsh.Start();
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
        public struct GlowStruct
        {
            public float r;
            public float g;
            public float b;
            public float a;
            public bool rwo;
            public bool rwuo;
        }
        private static string RandomString(int length)
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            string input = "#$!%&?}{][ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var chars = Enumerable.Range(0, length).Select(x => input[random.Next(0, input.Length)]);
            return new string(chars.ToArray());
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                WallActive = true;
                checkBox1.ForeColor = Color.Green;
            }
            else
            {
                WallActive = false;
                checkBox1.ForeColor = Color.Red;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                AntiFlash = true;
                checkBox2.ForeColor = Color.Green;
            }
            else
            {
                AntiFlash = false;
                checkBox2.ForeColor = Color.Red;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
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
                    int GameState = CylMem.ReadInt(EngineBase + Offsets.aGameChck);
                    if (GameState == 6)
                    {
                        if (WallActive == true)
                        {
                            Thread.Sleep(190);
                            GlowStruct Enemy = new GlowStruct()
                            {
                                r = 1f,
                                g = 0,
                                b = 0,
                                a = 0.8f,
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
                                i++;
                            } while (i < 65);
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
        public static void dwAntiFlash()
        {

            if (GetModuleAddress())
            {
                while (true)
                {
                    int EngineBase = CylMem.ReadInt(engineModule.moduleAddress + Offsets.bClient);
                    int GameState = CylMem.ReadInt(EngineBase + Offsets.aGameChck);
                    if (GameState == 6)
                    {
                        if (AntiFlash == true)
                        {
                            flashMaxAlpha = 0f;
                            Thread.Sleep(10);
                        }
                        else
                        {
                            flashMaxAlpha = 255f;
                        }
                    }
                }
            }
        }

        private void titleTimer_Tick(object sender, EventArgs e)
        {
            this.Text = "CoreProject v0.5     " + RandomString(30);
        }
    }
}

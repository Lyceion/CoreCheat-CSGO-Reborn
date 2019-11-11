using System;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using CylMem = CoreCheat_LSREMAKE.Class_Memory;
using static CoreCheat_LSREMAKE.Classes.netvars;
using static CoreCheat_LSREMAKE.Classes.signatures;
using static CoreCheat_LSREMAKE.Classes.Essentials;
using static CoreCheat_LSREMAKE.Versions.Panorama.Settings;

namespace CoreCheat_LSREMAKE.Versions.Panorama
{
    public partial class Main : MetroFramework.Forms.MetroForm
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

        public struct GlowStruct
        {
            public float r;
            public float g;
            public float b;
            public float a;
            public bool rwo;
            public bool rwuo;
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
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Thread Cheats = new Thread(new ThreadStart(MainThread));
            Cheats.Start();
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
        private static void MainThread()
        {
            Process[] p = Process.GetProcessesByName("csgo");
            foreach (var proc in p)
                CylMem.OpenProcess(proc.Id);
            int LocalBase = CylMem.ReadInt(clientModule.moduleAddress + dwLocalPlayer);
            int ClientAdress = CylMem.ReadInt(engineModule.moduleAddress + dwClientState);
            if (GetModuleAddress())
                while (true)
                {
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
                            address = Client + dwEntityList + (i - 1) * 0x10;
                            int EntityList = CylMem.ReadInt((int)address);

                            address = EntityList + m_iTeamNum;
                            int HisTeam = CylMem.ReadInt((int)address);

                            address = EntityList + m_bDormant;

                            if (!CylMem.ReadBool((int)address))
                            {
                                address = EntityList + m_iGlowIndex;

                                int GlowIndex = CylMem.ReadInt((int)address);
                                if (HisTeam == 2)
                                {
                                    address = Client + dwGlowObjectManager;
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
                                        address = Client + dwGlowObjectManager;
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
                        } while (i < CylMem.ReadInt(ClientAdress + dwClientState_MaxPlayer));
                    }
                    if (aFlashActive)
                    {
                        CylMem.WriteFloat(LocalBase + m_flFlashDuration, 0f);
                        CylMem.WriteFloat(LocalBase + m_flFlashMaxAlpha, 0f);
                    }
                    else
                    {
                        CylMem.WriteFloat(LocalBase + m_flFlashDuration, 255.0f);
                        CylMem.WriteFloat(LocalBase + m_flFlashMaxAlpha, 255.0f);
                    }
                    if (radarActive)
                    {
                        int i = 1;
                        do
                        {
                            int address = Client + dwEntityList + (i - 1) * 0x10;
                            int EntityList = CylMem.ReadInt((int)address);
                            CylMem.WriteBoolean(EntityList + m_bSpottedByMask, true);
                            i++;

                        } while (i < 20);
                    }
                    if (bunnyActive)
                    {
                        int LocalFlag = CylMem.ReadInt(LocalBase + m_fFlags);
                        if (HoldingKey(Keys.Space))
                        {
                            if ((LocalFlag == 257 || LocalFlag == 263) /*&& G.Engine.LocalPlayer.Velocity > 10*/)
                            {
                                CylMem.WriteInt(clientModule.moduleAddress + dwForceJump, 6);
                            }
                        }
                    }
                    if (triggerActive)
                    {
                        int address = Client + dwLocalPlayer;
                        int LocalPlayer = CylMem.ReadInt(address);

                        address = LocalPlayer + m_iTeamNum;
                        int MyTeam = CylMem.ReadInt(address);

                        address = LocalPlayer + m_iCrosshairId;
                        int PlayerInCross = CylMem.ReadInt(address);

                        if (PlayerInCross > 0 && PlayerInCross < 65)
                        {
                            address = Client + dwEntityList + (PlayerInCross - 1) * 0x0000010;
                            int PtrToPIC = CylMem.ReadInt(address);

                            address = PtrToPIC + m_iHealth;
                            int PICHealth = CylMem.ReadInt(address);

                            address = PtrToPIC + m_iTeamNum;
                            int PICTeam = CylMem.ReadInt(address);


                            if ((PICTeam != MyTeam) && (PICTeam > 1) && (PICHealth > 0))
                            {
                                for (int i = 0; i < 2; i++)
                                {
                                    CylMem.WriteInt(dwForceAttack, 1);
                                    Thread.Sleep(10);
                                    CylMem.WriteInt(dwForceAttack, 4);
                                }
                            }
                        }
                        Thread.Sleep(10);
                    }
                }

        }
        private void titleTimer_Tick(object sender, EventArgs e)
        {
            Text = "VERSION PANORAMA                                  " + RandomString(30);
        }
        private static string RandomString(int length)
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            string input = "#$!%&?}{][ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var chars = Enumerable.Range(0, length).Select(x => input[random.Next(0, input.Length)]);
            return new string(chars.ToArray());
        }
        private void glowToggle_CheckedChanged(object sender, EventArgs e)
        {
            if (glowToggle.Checked)
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
        private void flashButton_CheckedChanged(object sender, EventArgs e)
        {
            if (flashButton.Checked)
            {
                Console.Beep(600, 250);
                aFlashActive = true;
            }
            else
            {
                Console.Beep(400, 250);
                aFlashActive = false;
            }
        }

        private void RadarCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (radarCheck.Checked)
            {
                Console.Beep(600, 250);
                radarActive = true;
            }
            else
            {
                radarActive = false;
                Console.Beep(400, 250);
            }
        }

        private void BunnyButton_CheckedChanged(object sender, EventArgs e)
        {
            if (bunnyButton.Checked)
            {
                Console.Beep(600, 250);
                bunnyActive = true;
            }
            else
            {
                bunnyActive = false;
                Console.Beep(400, 250);
            }
        }

        private void TriggerButton_CheckedChanged(object sender, EventArgs e)
        {
            if (triggerButton.Checked)
            {
                Console.Beep(600, 250);
                triggerActive = true;
            }
            else
            {
                triggerActive = false;
                Console.Beep(400, 250);
            }
        }
    }
}

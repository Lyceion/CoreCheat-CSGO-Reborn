using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoreCheat_Reborn.Version0._3
{
    public partial class ver0_3Launcher : MetroFramework.Forms.MetroForm
    {
        public static int Client;
        public static Module clientModule = new Module("client_panorama.dll");
        public static Module engineModule = new Module("engine.dll");
        public ver0_3Launcher()
        {
            InitializeComponent();
        }

        private void ver0_3Launcher_Load(object sender, EventArgs e)
        {

        }
        private void manuelButton_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    Process[] p = Process.GetProcessesByName("csgo");

                    if (p.Length > 0)
                    {
                        GetModuleAddress();
                        if (clientModule.moduleAddress != 0)
                        {
                            this.Hide();
                            ver0_3Main mainfrm = new ver0_3Main();
                            mainfrm.Show();
                        }
                        else
                        {
                            MessageBox.Show("MODULES ARE NOT LOADED YET! PLEASE TRY AFTER FEW SECONDS! ");
                        }
                    }
                    else
                    {
                        MessageBox.Show("CS:GO NOT OPENED YET!");
                    }
                }
                catch
                {
                    MessageBox.Show("OPEN PROGRAM AS ADMINISTRATOR!");
                    Environment.Exit(0);
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
        public void Inject_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}

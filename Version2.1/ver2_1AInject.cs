using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoreCheat_Reborn.Version2._1
{
    public partial class ver2_1AInject : MetroFramework.Forms.MetroForm
    {
        public static string steampath;
        public string proccess = "csgo";
        public ver2_1AInject()
        {
            InitializeComponent();
        }

        private void ver2AInject_Load(object sender, EventArgs e)
        {
            startCSGO();
            procControl.Start();
        }
        public void Inject_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
        private void procControl_Tick(object sender, EventArgs e)
        {
            {
                try
                {
                    Process[] p = Process.GetProcessesByName(proccess);

                    if (p.Length > 0)
                    {
                        nowInject.Start();
                        procControl.Stop();
                    }
                }
                catch
                {

                }
            }
        }
        public void startCSGO()
        {
            string readValue = Convert.ToString(Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Valve\\Steam", "InstallPath", null));
            if (Directory.Exists(readValue))
            {
                if (File.Exists((readValue + "/Steam.exe")))
                {
                    steampath = readValue;
                }

            }
            try
            {
                Process.Start(steampath + @"\Steam.exe", "-applaunch 730");
            }
            catch
            {
                MessageBox.Show("An Error Occured on AutoInject. So, Try The Manuel Inject. And Send a Comment to My Forum Post.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void nowInject_Tick(object sender, EventArgs e)
        {
            Thread.Sleep(45000);
            this.Hide();
            ver2_1Main hck = new ver2_1Main();
            hck.Show();
            nowInject.Stop();
        }
    }
}

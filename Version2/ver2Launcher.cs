using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoreCheat_Reborn.Version2
{
    public partial class ver2Launcher : MetroFramework.Forms.MetroForm 
    {
        public static string autoInj;
        public static string manuelInj;
        public ver2Launcher()
        {
            InitializeComponent();
        }

        private void ver2Launcher_Load(object sender, EventArgs e)
        {
            try
            {
                using (var webClient = new System.Net.WebClient())
                {
                    manuelInj = webClient.DownloadString("http://cylpic.pe.hu/corecsgo/manuelInj.txt");
                    autoInj = webClient.DownloadString("http://cylpic.pe.hu/corecsgo/autoInj.txt");
                }
            }
            catch
            {

            }
            if (manuelInj == "kapali")
            {
                manuelButton.Text = "MANUEL DISABLED";
                manuelButton.Enabled = false;
            }
            if (autoInj == "kapali")
            {
                autoButton.Text = "AUTO DISABLED";
                autoButton.Enabled = false;
            }
        }

        private void autoButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Version2.ver2AInject Ainjector = new Version2.ver2AInject();
            Ainjector.Show();
        }

        private void manuelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Version2.ver2MInject Minjector = new Version2.ver2MInject();
            Minjector.Show();
        }
        public void Inject_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}

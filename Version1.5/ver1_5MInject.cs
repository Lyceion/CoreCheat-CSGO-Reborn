using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoreCheat_Reborn.Version1._5
{
    public partial class ver1_5MInject : MetroFramework.Forms.MetroForm
    {
        public string proccess = "csgo";
        public ver1_5MInject()
        {
            InitializeComponent();
        }

        private void ver1_5MInject_Load(object sender, EventArgs e)
        {
            procControl.Enabled = true;
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
                        injectTimer.Start();
                        procControl.Stop();
                    }
                }
                catch
                {

                }
            }
        }

        private void injectTimer_Tick(object sender, EventArgs e)
        {
            Thread.Sleep(15000);
            this.Hide();
            ver1_5Main hck = new ver1_5Main();
            hck.Show();
            injectTimer.Stop();
        }
        private void ManuelInject_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}

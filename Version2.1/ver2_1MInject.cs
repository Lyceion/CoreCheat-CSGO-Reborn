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

namespace CoreCheat_Reborn.Version2._1
{
    public partial class ver2_1MInject : MetroFramework.Forms.MetroForm
    {
        public string proccess = "csgo";
        public ver2_1MInject()
        {
            InitializeComponent();
        }

        private void ver2MInject_Load(object sender, EventArgs e)
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
            ver2_1Main hck = new ver2_1Main();
            hck.Show();
            injectTimer.Stop();
        }
    }
}

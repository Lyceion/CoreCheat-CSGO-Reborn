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

namespace CoreCheat_Reborn.Version0._5
{
    public partial class ver0_5Launcher : Form
    {
        public ver0_5Launcher()
        {
            InitializeComponent();
        }

        private void procControl_Tick(object sender, EventArgs e)
        {
            {
                try
                {
                    Process[] p = Process.GetProcessesByName("csgo");

                    if (p.Length > 0)
                    {
                        label1.ForeColor = Color.Green;
                        label1.Text = "CS:GO Detected, Injecting!";
                        Thread.Sleep(15000);
                        ver0_5Main hck = new ver0_5Main();
                        this.Hide();
                        hck.Show();
                        procControl.Stop();
                    }
                    else
                    {
                        button2.Enabled = false;
                        label1.ForeColor = Color.Red;
                        label1.Text = "Waiting For CS:GO";
                    }
                }
                catch
                {

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            procControl.Enabled = true;
        }
    }
}

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

namespace CoreCheat_Reborn
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public static string procDurum;
        public static string durumMsg;
        public static string durumLnk;
        public static string duyuruDrm;
        public static string verNum;
        public static string a;
        public static float b;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mainTab.SelectedIndex = 0;
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
            try
            {
                using (var webClient = new System.Net.WebClient())
                {
                    verNum = webClient.DownloadString("http://xxx.com/file/launcher/version.txt");
                    verLink.Text = webClient.DownloadString("http://xxx.com/file/launcher/linkversion.txt");
                    procDurum = webClient.DownloadString("http://xxx.com/file/launcher/durum.txt");
                    durumMsg = webClient.DownloadString("http://xxx.com/file/launcher/durumMsg.txt");
                    duyuruDrm = webClient.DownloadString("http://xxx.com/file/launcher/duyuru.txt");
                    version0_5.Text = webClient.DownloadString("http://xxx.com/file/vers0_5/durum.txt");
                    version1_5.Text = webClient.DownloadString("http://xxx.com/file/vers1_5/durum.txt");
                    version2.Text = webClient.DownloadString("http://xxx.com/file/vers2/durum.txt");
                    version2_1.Text = webClient.DownloadString("http://xxx.com/file/vers2_1/durum.txt");
                    version2_5.Text = webClient.DownloadString("http://xxx.com/file/vers2_5/durum.txt");
                    durumLnk = webClient.DownloadString("http://xxx.com/file/launcher/durumlink.txt");
                    verpanarom.Text = webClient.DownloadString("http://xxx.com/file/vers0_3/durum.txt");
                    annTXT.Text = webClient.DownloadString("http://xxx.com/file/launcher/duyuruFrm.txt");
                }
            }
            catch
            {

            }
            if (verNum != Convert.ToString(fvi.FileVersion))
            {
                MessageBox.Show("Your Launcher Has Been Outdated. Please Download New Version!", "Version Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Process.Start(verLink.Text);
                //Environment.Exit(0);
            }
            else
            {
                if (procDurum == "kapali")
                {
                    var webClient = new System.Net.WebClient();
                    MessageBox.Show("Launcher Closed For A While. Reason: \n" + webClient.DownloadString("http://xxx.com/file/launcher/durumMsg.txt"), "Info!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (durumLnk != String.Empty)
                    {
                        Process.Start(durumLnk);
                        Environment.Exit(0);
                    }
                    else
                    {
                        Environment.Exit(0);
                    }
                }
                else
                {
                    if (duyuruDrm == "acik")
                    {
                        var webClient = new System.Net.WebClient();
                        MessageBox.Show("Message From Admin: \n" + webClient.DownloadString("http://xxx.com/file/launcher/duyuruMsg.txt"), "Message:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {

                    }
                }
            }
        }

        private void versTimer_Tick(object sender, EventArgs e)
        {
            if (versCombo.SelectedIndex >= 0)
            {
                launchBtn.Enabled = true;
            }
            else
            {
                launchBtn.Enabled = false;
            }
        }

        private void launchBtn_Click(object sender, EventArgs e)
        {
            if (versCombo.SelectedIndex == 0)
            {
                if (version2_1.Text == "acik")
                {
                    Version2._1.ver2_1Launcher ver2Lnch = new Version2._1.ver2_1Launcher();
                    this.Hide();
                    versTimer.Enabled = false;
                    ver2Lnch.Show();
                }
                else
                {
                    Version2._1.ver2_1Launcher ver2Lnch = new Version2._1.ver2_1Launcher();
                    this.Hide();
                    versTimer.Enabled = false;
                    ver2Lnch.Show();
                    //var webClient = new System.Net.WebClient();
                    //MessageBox.Show("Version 2.1 Closed For A While. Reason: \n" + webClient.DownloadString("http://xxx.com/file/vers2_1/durumMsg.txt"), "Info!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else if (versCombo.SelectedIndex == 1)
            {
                if (verpanarom.Text == "acik")
                {
                    Version0._3.ver0_3Launcher ver2Lnch = new Version0._3.ver0_3Launcher();
                    this.Hide();
                    versTimer.Enabled = false;
                    ver2Lnch.Show();
                }
                else
                {
                    Version0._3.ver0_3Launcher ver2Lnch = new Version0._3.ver0_3Launcher();
                    this.Hide();
                    versTimer.Enabled = false;
                    ver2Lnch.Show();
                    //var webClient = new System.Net.WebClient();
                    //MessageBox.Show("Version 2.0 Closed For A While. Reason: \n" + webClient.DownloadString("http://xxx.com/file/vers0_3/durumMsg.txt"), "Info!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else if (versCombo.SelectedIndex == 2)
            {
                if (version2.Text == "acik")
                {
                    Version2.ver2Launcher ver2Lnch = new Version2.ver2Launcher();
                    this.Hide();
                    versTimer.Enabled = false;
                    ver2Lnch.Show();
                }
                else
                {
                    Version2.ver2Launcher ver2Lnch = new Version2.ver2Launcher();
                    this.Hide();
                    versTimer.Enabled = false;
                    ver2Lnch.Show();
                    //    var webClient = new System.Net.WebClient();
                    //    MessageBox.Show("Version 2.0 Closed For A While. Reason: \n" + webClient.DownloadString("http://xxx.com/file/vers2/durumMsg.txt"), "Info!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            else if (versCombo.SelectedIndex == 3)
            {
                if (version1_5.Text == "acik")
                {
                    Version1._5.ver1_5Launcher ver1_5Lnch = new Version1._5.ver1_5Launcher();
                    this.Hide();
                    versTimer.Enabled = false;
                    ver1_5Lnch.Show();
                }
                else
                {
                    Version1._5.ver1_5Launcher ver1_5Lnch = new Version1._5.ver1_5Launcher();
                    this.Hide();
                    versTimer.Enabled = false;
                    ver1_5Lnch.Show();
                    //var webClient = new System.Net.WebClient();
                    //MessageBox.Show("Version 1.5 Closed For A While. Reason: \n" + webClient.DownloadString("http://xxx.com/file/vers1_5/durumMsg.txt"), "Info!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (versCombo.SelectedIndex == 4)
            {
                if (version0_5.Text == "acik")
                {
                    Version0._5.ver0_5Launcher ver0_5Lnch = new Version0._5.ver0_5Launcher();
                    this.Hide();
                    versTimer.Enabled = false;
                    ver0_5Lnch.Show();
                }
                else
                {
                    Version0._5.ver0_5Launcher ver0_5Lnch = new Version0._5.ver0_5Launcher();
                    this.Hide();
                    versTimer.Enabled = false;
                    ver0_5Lnch.Show();
                    //var webClient = new System.Net.WebClient();
                    //MessageBox.Show("Version 0.5 Closed For A While. Reason: \n" + webClient.DownloadString("http://xxx.com/file/vers0_5/durumMsg.txt"), "Info!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("An Error Exited. Please Report To Us!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Inject_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("CoreCheat CSGO Will Be 'END' Within Close Time. I'm Sorry For That But I'm Tired.","Secret Message");
        }

    }
}

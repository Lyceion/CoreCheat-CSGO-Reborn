using System;
using System.Diagnostics;
using System.Windows.Forms;
using static CoreCheat_LSREMAKE.Classes.Global;
using static CoreCheat_LSREMAKE.Classes.WebConnection;
namespace CoreCheat_LSREMAKE
{
    public partial class vSelector : MetroFramework.Forms.MetroForm
    {
        public vSelector()
        {
            InitializeComponent();
            DataWrap();
        }

        private void vSelector_Load(object sender, EventArgs e)
        {
            mainTab.SelectedIndex = 0;
        }
        private void DataWrap()
        {
            //try
            //{
            //    using (var webClient = new System.Net.WebClient())
            //    {
            //        WebVersion = GetStrData("version");
            //        UpdateRedirect = GetStrData("update");
            //        ProgramStatus = IsProgramStatus();
            //        CheatError = GetStrData("cheaterr");
            //        OpenMessage = IsOpenMSG();
            //        CloseRedirect = IsCloseRedir();
            //        UpdateLink = GetStrData("update");
            //        annTXT.Text = GetStrData("announcment");
            //        CloseLink = GetStrData("closelink");
            //    }
            //}
            //catch { }
            versCombo.Items.Clear();
            versCombo.Items.Add("Version Panorama");
            if (versCombo.Items[0].ToString().Length < 3)
            {
                versCombo.Enabled = false;
            }
            //if (WebVersion != "OK")
            //{
            //    MessageBox.Show("Your Launcher Has Been Outdated Or Modified. Please Download New Version or Again!", "Version Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    MessageBox.Show(GetStrData("update"));
            //    Process.Start(UpdateLink);
            //    Environment.Exit(0);
            //}
            //else
            //{
            //    if (!ProgramStatus)
            //    {
            //        MessageBox.Show("Launcher Closed For A While. Reason: \n" + GetStrData("closealert"), "Info!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        if (CloseRedirect)
            //        {
            //            Process.Start(CloseLink);
            //            Environment.Exit(0);
            //        }
            //        else
            //        {
            //            Environment.Exit(0);
            //        }
            //    }
            //    else
            //    {
            //        if (OpenMessage)
            //        {
            //            MessageBox.Show("Message From Admin: \n" + GetStrData("message"), "Message:", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        }
            //        else
            //        {

            //        }
            //    }
            //}
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
            if (versCombo.SelectedItem.ToString() == "Version Panorama")
            {
                //if (IsCheatOpen("panorama"))
                //{
                    Versions.Panorama.Launcher launcher = new Versions.Panorama.Launcher();
                    Hide();
                    versTimer.Enabled = false;
                    launcher.Show();
                //}
                //else
                //{
                    var webClient = new System.Net.WebClient();
                    MessageBox.Show("Version Panorama Closed For A While. Reason: \n" + CheatError, "Info!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}

            }
        }
        public void vSelector_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void secretPic_Click(object sender, EventArgs e)
        {
            MessageBox.Show("UR M0M GAY. LOOOOOOOOOOOOOOOOOOL", "Secret Message");
        }

        private void ProfilePicture_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/MrCylops");
        }
    }
}

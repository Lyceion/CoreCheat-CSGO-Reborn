using System;
using System.Media;
using System.Diagnostics;
using System.Windows.Forms;
using static CoreCheat_Reborn.Classes.WebConnection;
using static CoreCheat_Reborn.Classes.Functions;

namespace CoreCheat_Reborn
{
    public partial class vSelector : MetroFramework.Forms.MetroForm
    {
        public static SoundPlayer snd = new SoundPlayer(Properties.Resources.imperialmarch);
        System.Windows.Forms.Timer fadeInTimer = new System.Windows.Forms.Timer();
        public vSelector()
        {
            InitializeComponent();
            DataWrap();
            snd.Play();
            Opacity = 0;
        }
        private void vSelector_Load(object sender, EventArgs e)
        {
            mainTab.SelectedIndex = 0;
            fadeInTimer.Interval = 30;
            fadeInTimer.Tick += new EventHandler(fadeIn);
            fadeInTimer.Start();
        }
        void fadeIn(object sender, EventArgs e)
        {
            if (Opacity >= 1)
                fadeInTimer.Stop();
            else
                Opacity += 0.05;
        }
        private void DataWrap()
        {
            versCombo.Items.Clear();
#if DEBUG
            versCombo.Items.Add("Version Panorama");
            versCombo.Items.Add("Fully Legit");
            versCombo.Items.Add("Only Wallhack");
            versCombo.Items.Add("DEV");
#else
            InitializeProject();
            string[] Cheats = GetStrData("cheats").Split(Environment.NewLine.ToCharArray());
            foreach (string cheat in Cheats)
                versCombo.Items.Add(cheat);
#endif
        }
        private void versTimer_Tick(object sender, EventArgs e)
        {
            if (versCombo.SelectedIndex >= 0)
                launchBtn.Enabled = true;
            else
                launchBtn.Enabled = false;
        }
        private void launchBtn_Click(object sender, EventArgs e)
        {
            if (versCombo.SelectedItem.ToString() == "Version Panorama")
            {
#if DEBUG
                Versions.Panorama.Launcher launcher = new Versions.Panorama.Launcher();
                Hide();
                versTimer.Enabled = false;
                launcher.Show();
                snd.Stop();
#else
                if (IsCheatOpen("panorama"))
                {
                    Versions.Panorama.Launcher launcher = new Versions.Panorama.Launcher();
                    Hide();
                    versTimer.Enabled = false;
                    launcher.Show();
                    snd.Stop();

                }
                else
                    MessageBox.Show("Version Panorama is closed for a while. Reason: \n" + GetStrData("cheaterr"), "Info!", MessageBoxButtons.OK, MessageBoxIcon.Information);
#endif
            }
            if (versCombo.SelectedItem.ToString() == "Only Wallhack")
            {
#if DEBUG
                Versions.OnlyWall.Launcher launcher = new Versions.OnlyWall.Launcher();
                Hide();
                versTimer.Enabled = false;
                launcher.Show();
                snd.Stop();
#else
                if (IsCheatOpen("wallhack"))
                {
                    Versions.OnlyWall.Launcher launcher = new Versions.OnlyWall.Launcher();
                    Hide();
                    versTimer.Enabled = false;
                    launcher.Show();
                    snd.Stop();

                }
                else
                    MessageBox.Show("Version Panorama is closed for a while. Reason: \n" + GetStrData("cheaterr"), "Info!", MessageBoxButtons.OK, MessageBoxIcon.Information);
#endif
            }
            if (versCombo.SelectedItem.ToString() == "Fully Legit")
            {
#if DEBUG
                Versions.FullLegit.Launcher launcher = new Versions.FullLegit.Launcher();
                Hide();
                versTimer.Enabled = false;
                launcher.Show();
                snd.Stop();
#else
                if (IsCheatOpen("legit"))
                {
                    Versions.FullLegit.Launcher launcher = new Versions.FullLegit.Launcher();
                    Hide();
                    versTimer.Enabled = false;
                    launcher.Show();
                    snd.Stop();
                }
                else
                    MessageBox.Show("Fully Legit is closed for a while. Reason: \n" + GetStrData("cheaterr"), "Info!", MessageBoxButtons.OK, MessageBoxIcon.Information);
#endif
            }
#if DEBUG
                if (versCombo.SelectedItem.ToString() == "DEV")
                {
                    Versions.ZDEV.Main Devolper = new Versions.ZDEV.Main();
                    Hide();
                    versTimer.Enabled = false;
                    Devolper.Show();
                    snd.Stop();
                }
#endif
        }
        public void vSelector_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
        private void secretPic_Click(object sender, EventArgs e)
        {
            MessageBox.Show("UR M0M GAY. LOOOOOOOOOOOOOOOOOOL", "Secret Message");
            Clipboard.SetText(Classes.Global.KEY);
        }
        private void ProfilePicture_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/MrCylops");
        }
        
    }
}

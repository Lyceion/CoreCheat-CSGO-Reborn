using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace CoreCheat_Reborn
{
    public partial class Expire : Form
    {
        private Timer FadeInTimer = new Timer();
        public Expire()
        {
            InitializeComponent();
            Opacity = 0;
        }
        private void LoadCheat_Click(object sender, EventArgs e)
        {
            Hide();
            vSelector a = new vSelector();
            a.Show();
        }
        private void CloseButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        private void Expire_Load(object sender, EventArgs e)
        {
            FadeInTimer.Interval = 30;
            FadeInTimer.Tick += new EventHandler(fadeIn);
            FadeInTimer.Start();
            var exp = new DateTime(2019, 09, 09,00,00,00);
            var s = DateTime.Today;
            if((DateTime.Compare(s, exp) > 0) || (DateTime.Compare(s, exp) == 0))
            {
                MessageBox.Show("En:\nCoreCheat Project Is Ended. Thank you everyone!\nTr:\nCoreCheat Projesi Sona Erdi. Herkese çok teşekkürler!");
                LoadCheat.Enabled = false;
            }
            Process.Start("https://github.com/Lufzys");
            Process.Start("https://github.com/MrCylops");
            Process.Start("https://github.com/lysep-corp");
            Process.Start("https://github.com/Septillioner");
            Process.Start("http://lysep.com/index_new.php");
        }
        void fadeIn(object sender, EventArgs e)
        {
            if (Opacity >= 1)
                FadeInTimer.Stop();
            else
                Opacity += 0.05;
        }

        private void Github1_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/lysep-corp");
        }

        private void Github2_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/MrCylops");
        }

        private void Github3_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/Septillioner");
        }

        private void Github4_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/Lufzys");
        }
    }
}

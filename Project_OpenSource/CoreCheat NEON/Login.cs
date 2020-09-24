using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoreCheat_NEON
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        uint i = 0;
        private void ColorTimer_Tick(object sender, EventArgs e)
        {
            btnBackPanel.ColorLeft = ColorTranslator.FromHtml(Rainbow(100, i % 100));
            btnBackPanel.ColorRight = ColorTranslator.FromHtml(Rainbow(50, i % 50));
            btnBackPanel.Refresh();
            if (i == uint.MaxValue)
                i = 0;
            i++;
        }
        public static string Rainbow(int numOfSteps, uint step)
        {
            var r = 0.0;
            var g = 0.0;
            var b = 0.0;
            var h = (double)step / numOfSteps;
            var i = (int)(h * 6);
            var f = h * 6.0 - i;
            var q = 1 - f;

            switch (i % 6)
            {
                case 0:
                    r = 1;
                    g = f;
                    b = 0;
                    break;
                case 1:
                    r = q;
                    g = 1;
                    b = 0;
                    break;
                case 2:
                    r = 0;
                    g = 1;
                    b = f;
                    break;
                case 3:
                    r = 0;
                    g = q;
                    b = 1;
                    break;
                case 4:
                    r = f;
                    g = 0;
                    b = 1;
                    break;
                case 5:
                    r = 1;
                    g = 0;
                    b = q;
                    break;
            }
            return "#" + ((int)(r * 255)).ToString("X2") + ((int)(g * 255)).ToString("X2") + ((int)(b * 255)).ToString("X2");
        }

        private void btnLogin_MouseHover(object sender, EventArgs e)
        {
            ColorTimer.Enabled = true;
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            ColorTimer.Enabled = false;
            btnBackPanel.ColorLeft = Color.FromArgb(22, 22, 22);
            btnBackPanel.ColorRight = Color.FromArgb(22, 22, 22);
            btnBackPanel.Refresh();
        }

        private void btnLogin_MouseMove(object sender, MouseEventArgs e)
        {
            ColorTimer.Enabled = true;
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Hide();
            CheatLoader Loader = new CheatLoader();
            Loader.Show();
        }
    }
}

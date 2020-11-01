using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoreCheat_Reborn.Versions.Panorama
{
    public partial class Main : Form
    {
        Pages.Visuals VisualsPage = new Pages.Visuals();
        Pages.Assists AssistsPage = new Pages.Assists();
        Pages.Aimbot AimbotPage = new Pages.Aimbot();
        Pages.Miscs MiscsPage = new Pages.Miscs();
        Pages.Settings SettingsPage = new Pages.Settings();

        private bool mouseDown;
        private Point lastLocation;
        Timer fadeInTimer = new Timer();
        private void Drag_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }
        private void Drag_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                Location = new Point(
                    (Location.X - lastLocation.X) + e.X, (Location.Y - lastLocation.Y) + e.Y);

                Update();
            }
        }
        private void Drag_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        public Main()
        {
            InitializeComponent();
            Opacity = 0;
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(VisualsPage);
            VisualsPage.Dock = DockStyle.Fill;
            SideBarPanel.Width = 0;
            VisualsPage.Location = new Point(ClientSize.Width / 2 - MainPanel.Size.Width / 2, ClientSize.Height / 2 - MainPanel.Size.Height / 2);
        }
        private void LoadTheme()
        {
            TopPanel.BackColor = Color.FromArgb(ProgramSettings.CheatTheme.MainThemeColor.R - 4, ProgramSettings.CheatTheme.MainThemeColor.G - 4, ProgramSettings.CheatTheme.MainThemeColor.B - 4);
            SideBarPanel.BackColor = Color.FromArgb(ProgramSettings.CheatTheme.MainThemeColor.R - 4, ProgramSettings.CheatTheme.MainThemeColor.G - 4, ProgramSettings.CheatTheme.MainThemeColor.B - 4);
            MainPanel.BackColor = ProgramSettings.CheatTheme.MainThemeColor;
            BackColor = ProgramSettings.CheatTheme.MainThemeColor;
            botGlow.BackColor = ProgramSettings.CheatTheme.SecondaryThemeColor;
            logoTXT.ForeColor = ProgramSettings.CheatTheme.SecondaryThemeColor;
            selectIndicator.BackColor = ProgramSettings.CheatTheme.SecondaryThemeColor;
            VisualsButton.FlatAppearance.MouseDownBackColor = ProgramSettings.CheatTheme.SecondaryThemeColor;
            AssistsButton.FlatAppearance.MouseDownBackColor = ProgramSettings.CheatTheme.SecondaryThemeColor;
            AimbotButton.FlatAppearance.MouseDownBackColor = ProgramSettings.CheatTheme.SecondaryThemeColor;
            MiscsButton.FlatAppearance.MouseDownBackColor = ProgramSettings.CheatTheme.SecondaryThemeColor;
            SettingsButton.FlatAppearance.MouseDownBackColor = ProgramSettings.CheatTheme.SecondaryThemeColor;
            CloseButton.BackColor = Color.FromArgb(ProgramSettings.CheatTheme.MainThemeColor.R - 4, ProgramSettings.CheatTheme.MainThemeColor.G - 4, ProgramSettings.CheatTheme.MainThemeColor.B - 4);
            MinimizeButton.BackColor = Color.FromArgb(ProgramSettings.CheatTheme.MainThemeColor.R - 4, ProgramSettings.CheatTheme.MainThemeColor.G - 4, ProgramSettings.CheatTheme.MainThemeColor.B - 4);
            MinimizeButton.FlatAppearance.MouseOverBackColor = ProgramSettings.CheatTheme.SecondaryThemeColor;
            logoTXT.ForeColor = Color.FromArgb(ProgramSettings.CheatTheme.MainThemeColor.ToArgb() ^ 0xffffff);
            CloseButton.ForeColor = Color.FromArgb(ProgramSettings.CheatTheme.MainThemeColor.ToArgb() ^ 0xffffff);
            MinimizeButton.ForeColor = Color.FromArgb(ProgramSettings.CheatTheme.MainThemeColor.ToArgb() ^ 0xffffff);
            ControlBoxPanel.BackColor = Color.FromArgb(ProgramSettings.CheatTheme.MainThemeColor.R - 4, ProgramSettings.CheatTheme.MainThemeColor.G - 4, ProgramSettings.CheatTheme.MainThemeColor.B - 4);
        }
        void fadeIn(object sender, EventArgs e)
        {
            if (Opacity >= 1)
            {
                fadeInTimer.Stop();
                for (int i = 0; i <= 147; i++)
                    SideBarPanel.Width = i;
            }
            else
                Opacity += 0.05;
        }
        private void DarkBackAll()
        {
            VisualsButton.BackColor = Color.FromArgb(ProgramSettings.CheatTheme.MainThemeColor.R - 7, ProgramSettings.CheatTheme.MainThemeColor.G - 7, ProgramSettings.CheatTheme.MainThemeColor.B - 7);
            AssistsButton.BackColor = Color.FromArgb(ProgramSettings.CheatTheme.MainThemeColor.R - 7, ProgramSettings.CheatTheme.MainThemeColor.G - 7, ProgramSettings.CheatTheme.MainThemeColor.B - 7);
            AimbotButton.BackColor = Color.FromArgb(ProgramSettings.CheatTheme.MainThemeColor.R - 7, ProgramSettings.CheatTheme.MainThemeColor.G - 7, ProgramSettings.CheatTheme.MainThemeColor.B - 7);
            MiscsButton.BackColor = Color.FromArgb(ProgramSettings.CheatTheme.MainThemeColor.R - 7, ProgramSettings.CheatTheme.MainThemeColor.G - 7, ProgramSettings.CheatTheme.MainThemeColor.B - 7);
            SettingsButton.BackColor = Color.FromArgb(ProgramSettings.CheatTheme.MainThemeColor.R - 7, ProgramSettings.CheatTheme.MainThemeColor.G - 7, ProgramSettings.CheatTheme.MainThemeColor.B - 7);
            VisualsButton.ForeColor = Color.DimGray;
            AssistsButton.ForeColor = Color.DimGray;
            AimbotButton.ForeColor = Color.DimGray;
            MiscsButton.ForeColor = Color.DimGray;
            SettingsButton.ForeColor = Color.DimGray;
        }
        private void InitCheat()
        {
            fadeInTimer.Interval = 30;
            fadeInTimer.Tick += new EventHandler(fadeIn);
            fadeInTimer.Start();
            LoadTheme();
            DarkBackAll();
            VisualsButton.BackColor = ProgramSettings.CheatTheme.MainThemeColor;
            VisualsButton.ForeColor = Color.FromArgb(ProgramSettings.CheatTheme.MainThemeColor.ToArgb() ^ 0xffffff);
            selectIndicator.Location = new Point(12, 71);
        }
        private void CloseButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void VisualsButton_Click(object sender, EventArgs e)
        {
            MoveIt(selectIndicator, 71);
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(VisualsPage);
            DarkBackAll();
            VisualsButton.BackColor = ProgramSettings.CheatTheme.MainThemeColor;
            VisualsButton.ForeColor = Color.FromArgb(ProgramSettings.CheatTheme.MainThemeColor.ToArgb() ^ 0xffffff);
        }

        private void AssistsButton_Click(object sender, EventArgs e)
        {
            MoveIt(selectIndicator, 112);
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(AssistsPage);
            DarkBackAll();
            AssistsButton.BackColor = ProgramSettings.CheatTheme.MainThemeColor;
            AssistsButton.ForeColor = Color.FromArgb(ProgramSettings.CheatTheme.MainThemeColor.ToArgb() ^ 0xffffff);
        }

        private void AimbotButton_Click(object sender, EventArgs e)
        {
            MoveIt(selectIndicator, 154);
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(AimbotPage);
            DarkBackAll();
            AimbotButton.BackColor = ProgramSettings.CheatTheme.MainThemeColor;
            AimbotButton.ForeColor = Color.FromArgb(ProgramSettings.CheatTheme.MainThemeColor.ToArgb() ^ 0xffffff);
        }

        private void MiscsButton_Click(object sender, EventArgs e)
        {
            MoveIt(selectIndicator, 196);
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(MiscsPage);
            DarkBackAll();
            MiscsButton.BackColor = ProgramSettings.CheatTheme.MainThemeColor;
            MiscsButton.ForeColor = Color.FromArgb(ProgramSettings.CheatTheme.MainThemeColor.ToArgb() ^ 0xffffff);
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            MoveIt(selectIndicator, 238);
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(SettingsPage);
            DarkBackAll();
            SettingsButton.BackColor = ProgramSettings.CheatTheme.MainThemeColor;
            SettingsButton.ForeColor = Color.FromArgb(ProgramSettings.CheatTheme.MainThemeColor.ToArgb() ^ 0xffffff);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            InitCheat();
        }

        uint i = 0;
        private void ColorTimer_Tick(object sender, EventArgs e)
        {
            ProgramSettings.CheatTheme.SecondaryThemeColor = ColorTranslator.FromHtml(Rainbow(500, i % 500));
            LoadTheme();
            if (i == uint.MaxValue)
                i = 0;
            i++;
        }

        public int GetTick(int Start, int End, int now, int maxtick)
        { 
            float normalized = (1*(float)(now) / (float)(Math.Abs(End - Start)+1));
            float t = (float)Math.Pow((double)normalized,3)+0.4f;
            int anan = (int)((float)(maxtick)*t);
            return Math.Abs(anan);
}
        async void MoveIt(Panel Moving, int LocationY)
        {
            int i = 1;
            if (Moving.Location.Y < LocationY)
            {
                int Y = Moving.Location.Y;
                do
                {
                    Y++;
                    Moving.Location = new Point(Moving.Location.X, Y);
                    Sleep(1);
                } while (Moving.Location.Y < LocationY);
            }
            else if (Moving.Location.Y > LocationY)
            {
                int Y = Moving.Location.Y;
                do
                {
                    Y--;
                    Moving.Location = new Point(Moving.Location.X, Y);
                    Sleep(1);
                } while (Moving.Location.Y > LocationY);
            }
        }
        async void Sleep(double msec)
        {
            for (var since = DateTime.Now; (DateTime.Now - since).TotalMilliseconds < msec;)
                await Task.Delay(TimeSpan.FromTicks(10));
        }
        public static String Rainbow(Int32 numOfSteps, UInt32 step)
        {
            var r = 0.0;
            var g = 0.0;
            var b = 0.0;
            var h = (Double)step / numOfSteps;
            var i = (Int32)(h * 6);
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
            return "#" + ((Int32)(r * 255)).ToString("X2") + ((Int32)(g * 255)).ToString("X2") + ((Int32)(b * 255)).ToString("X2");
        }
    }
}

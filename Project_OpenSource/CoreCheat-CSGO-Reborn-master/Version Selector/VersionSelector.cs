using System;
using System.Drawing;
using System.Windows.Forms;

namespace CoreCheat_Reborn.Version_Selector
{
    public partial class VersionSelector : Form
    {
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
        Pages.Home HomePage = new Pages.Home();
        Pages.Versions VersionsPage = new Pages.Versions();
        Pages.About AboutPage = new Pages.About();
        public VersionSelector()
        {
#if DEBUG
#else
            if (Environment.GetCommandLineArgs()[0] != "-updaterOut")
            {
                MessageBox.Show("En: Please open program from updater.\n\nTr: Lütfen programı güncelleyiciden açın.", "Info!");
                Environment.Exit(0);
            }
#endif
            InitializeComponent();
            Opacity = 0;
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(HomePage);
            HomePage.Dock = DockStyle.Fill;
            SideBarPanel.Width = 0;
            HomePage.Location = new Point(ClientSize.Width / 2 - MainPanel.Size.Width / 2, ClientSize.Height / 2 - MainPanel.Size.Height / 2);
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
        public int PageWidth
        {
            get
            {
                return MainPanel.Width;
            }
        }
        public int PageHeight
        {
            get
            {
                return MainPanel.Height;
            }
        }
        private void VersionSelectorNEW_Load(object sender, EventArgs e)
        {
            InitLoader();
        }
        private void LoadTheme()
        {
            TopPanel.BackColor = Color.FromArgb(ProgramSettings.CheatTheme.MainThemeColor.R - 4, ProgramSettings.CheatTheme.MainThemeColor.G - 4, ProgramSettings.CheatTheme.MainThemeColor.B - 4);
            SideBarPanel.BackColor = Color.FromArgb(ProgramSettings.CheatTheme.MainThemeColor.R - 4, ProgramSettings.CheatTheme.MainThemeColor.G - 4, ProgramSettings.CheatTheme.MainThemeColor.B - 4);
            MainPanel.BackColor = ProgramSettings.CheatTheme.MainThemeColor;
            BackColor = ProgramSettings.CheatTheme.MainThemeColor;
            topGlow.BackColor = ProgramSettings.CheatTheme.SecondaryThemeColor;
            logoTXT.ForeColor = ProgramSettings.CheatTheme.SecondaryThemeColor;
            selectIndicator.BackColor = ProgramSettings.CheatTheme.SecondaryThemeColor;
            HomeButton.FlatAppearance.MouseDownBackColor = ProgramSettings.CheatTheme.SecondaryThemeColor;
            VersionButton.FlatAppearance.MouseDownBackColor = ProgramSettings.CheatTheme.SecondaryThemeColor;
            AboutButton.FlatAppearance.MouseDownBackColor = ProgramSettings.CheatTheme.SecondaryThemeColor;
            HomeButton.BackColor = ProgramSettings.CheatTheme.MainThemeColor;
            VersionButton.BackColor = ProgramSettings.CheatTheme.MainThemeColor;
            AboutButton.BackColor = ProgramSettings.CheatTheme.MainThemeColor;
            CloseButton.BackColor = Color.FromArgb(ProgramSettings.CheatTheme.MainThemeColor.R - 4, ProgramSettings.CheatTheme.MainThemeColor.G - 4, ProgramSettings.CheatTheme.MainThemeColor.B - 4);
            MinimizeButton.BackColor = Color.FromArgb(ProgramSettings.CheatTheme.MainThemeColor.R - 4, ProgramSettings.CheatTheme.MainThemeColor.G - 4, ProgramSettings.CheatTheme.MainThemeColor.B - 4);
            MinimizeButton.FlatAppearance.MouseOverBackColor = ProgramSettings.CheatTheme.SecondaryThemeColor;
            //MinimizeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(MinimizeButton.BackColor.R - 10, MinimizeButton.BackColor.G - 10, MinimizeButton.BackColor.B - 10);
            logoTXT.ForeColor = Color.FromArgb(ProgramSettings.CheatTheme.MainThemeColor.ToArgb() ^ 0xffffff);
            logoTXT2.ForeColor = Color.FromArgb(ProgramSettings.CheatTheme.MainThemeColor.ToArgb() ^ 0xffffff);
            AboutButton.ForeColor = Color.FromArgb(ProgramSettings.CheatTheme.MainThemeColor.ToArgb() ^ 0xffffff);
            CloseButton.ForeColor = Color.FromArgb(ProgramSettings.CheatTheme.MainThemeColor.ToArgb() ^ 0xffffff);
            HomeButton.ForeColor = Color.FromArgb(ProgramSettings.CheatTheme.MainThemeColor.ToArgb() ^ 0xffffff);
            MinimizeButton.ForeColor = Color.FromArgb(ProgramSettings.CheatTheme.MainThemeColor.ToArgb() ^ 0xffffff);
            VersionButton.ForeColor = Color.FromArgb(ProgramSettings.CheatTheme.MainThemeColor.ToArgb() ^ 0xffffff);
            ControlBoxPanel.BackColor = Color.FromArgb(ProgramSettings.CheatTheme.MainThemeColor.R - 4, ProgramSettings.CheatTheme.MainThemeColor.G - 4, ProgramSettings.CheatTheme.MainThemeColor.B - 4);
        }
        private void DarkBackAll()
        {
            HomeButton.BackColor = Color.FromArgb(ProgramSettings.CheatTheme.MainThemeColor.R - 7, ProgramSettings.CheatTheme.MainThemeColor.G - 7, ProgramSettings.CheatTheme.MainThemeColor.B - 7);
            VersionButton.BackColor = Color.FromArgb(ProgramSettings.CheatTheme.MainThemeColor.R - 7, ProgramSettings.CheatTheme.MainThemeColor.G - 7, ProgramSettings.CheatTheme.MainThemeColor.B - 7);
            AboutButton.BackColor = Color.FromArgb(ProgramSettings.CheatTheme.MainThemeColor.R - 7, ProgramSettings.CheatTheme.MainThemeColor.G - 7, ProgramSettings.CheatTheme.MainThemeColor.B - 7);
            HomeButton.ForeColor = Color.DimGray;
            VersionButton.ForeColor = Color.DimGray;
            AboutButton.ForeColor = Color.DimGray;
        }
        private void InitLoader()
        {
            fadeInTimer.Interval = 30;
            fadeInTimer.Tick += new EventHandler(fadeIn);
            fadeInTimer.Start();
            LoadTheme();
            DarkBackAll();
            Classes.Functions.InitializeProject();
            HomeButton.BackColor = ProgramSettings.CheatTheme.MainThemeColor;
            HomeButton.ForeColor = Color.FromArgb(ProgramSettings.CheatTheme.MainThemeColor.ToArgb() ^ 0xffffff);
            selectIndicator.Location = new Point(10, 104);
        }
        private void CloseButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void HomeButton_Click(object sender, EventArgs e)
        {
            selectIndicator.Location = new Point(10, 104);
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(HomePage);
            DarkBackAll();
            HomeButton.BackColor = ProgramSettings.CheatTheme.MainThemeColor;
            HomeButton.ForeColor = Color.FromArgb(ProgramSettings.CheatTheme.MainThemeColor.ToArgb() ^ 0xffffff);
        }
        private void VersionButton_Click(object sender, EventArgs e)
        {
            selectIndicator.Location = new Point(10, 145);
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(VersionsPage);
            DarkBackAll();
            VersionButton.BackColor = ProgramSettings.CheatTheme.MainThemeColor;
            VersionButton.ForeColor = Color.FromArgb(ProgramSettings.CheatTheme.MainThemeColor.ToArgb() ^ 0xffffff);
        }
        private void AboutButton_Click(object sender, EventArgs e) 
        {
            selectIndicator.Location = new Point(10, 186);
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(AboutPage);
            DarkBackAll();
            AboutButton.BackColor = ProgramSettings.CheatTheme.MainThemeColor;
            AboutButton.ForeColor = Color.FromArgb(ProgramSettings.CheatTheme.MainThemeColor.ToArgb() ^ 0xffffff);
        }
    }
}

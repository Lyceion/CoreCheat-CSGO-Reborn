using System;
using System.Drawing;
using System.Windows.Forms;
using static CoreCheat_Reborn.Classes.WebConnection;

namespace CoreCheat_Reborn.Version_Selector.Pages
{
    public partial class Versions : UserControl
    {
        public static int i = 0;
        class CheatCard : Panel
        {
            public Form OpenForm = new Form();
            //public static string cheatStr = "Version Panorama\nFully Legit\nOnly Wallhack";
            //public string CheatName = cheatStr.Split(Environment.NewLine.ToCharArray())[i];
            public string CheatName = GetStrData("cheats").Split(Environment.NewLine.ToCharArray())[i];
            public CheatCard() : base()
            {
                Button StartCheatButton = new Button
                {
                    Dock = DockStyle.Bottom,
                    FlatStyle = FlatStyle.Flat,
                    Text = "LAUNCH CHEAT!"
                };
                PictureBox CheatPictureBox = new PictureBox
                {
                    Height = 156,
                    Dock = DockStyle.Top,
                    Image = Properties.Resources.CoreCheatTransparent,
                    SizeMode = PictureBoxSizeMode.StretchImage
                };
                StartCheatButton.Click += new EventHandler(OpenNewCheat);
                StartCheatButton.FlatAppearance.BorderSize = 1;
                StartCheatButton.ForeColor = ProgramSettings.CheatTheme.SecondaryThemeColor;
                Label CheatNameLabel = new Label
                {
                    ForeColor = Color.FromArgb(ProgramSettings.CheatTheme.MainThemeColor.ToArgb() ^ 0xffffff),
                    Text = CheatName,
                    Location = new Point(5, 165)
                };
                Panel ThemeIndicator = new Panel
                {
                    Dock = DockStyle.Bottom,
                    BackColor = ProgramSettings.CheatTheme.SecondaryThemeColor,
                    Height = 5
                };
                Controls.Add(CheatNameLabel);
                Controls.Add(StartCheatButton);
                Controls.Add(CheatPictureBox);
                Controls.Add(ThemeIndicator);
                CheatPictureBox.BringToFront();
                BackColor = Color.FromArgb(ProgramSettings.CheatTheme.MainThemeColor.R - 10, ProgramSettings.CheatTheme.MainThemeColor.G - 10, ProgramSettings.CheatTheme.MainThemeColor.B - 10);
                Width = 156;
                Height = 307;
            }
            public void OpenNewCheat(object sender, EventArgs e)
            {
                VersionSelector.ActiveForm.Hide();
                OpenForm.Show();
            }
        }
        public Versions()
        {
            InitializeComponent();
            LoadTheme();
        }
        private void Versions_Load(object sender, EventArgs e)
        {
            //string[] Cheats = GetStrData("cheats").Split(Environment.NewLine.ToCharArray());
            //string cheatStr = "Version Panorama\nFully Legit\nOnly Wallhack";
            string[] Cheats = GetStrData("cheats").Split(Environment.NewLine.ToCharArray());
            foreach (string cheat in Cheats)
            {
                CheatCard _cheatCard = new CheatCard();
                _cheatCard.Location = new Point(16 + (i * (_cheatCard.Width + 16)), 16);
                //_cheatCard.CheatName = cheat;
                if (cheat == "Version Panorama")
                    _cheatCard.OpenForm = new CoreCheat_Reborn.Versions.Panorama.Launcher();
                else if (cheat == "Fully Legit")
                    _cheatCard.OpenForm = new CoreCheat_Reborn.Versions.FullLegit.Launcher();
                else if (cheat == "Only Wallhack")
                    _cheatCard.OpenForm = new CoreCheat_Reborn.Versions.OnlyWall.Launcher();
                Controls.Add(_cheatCard);
                i++;
            }
        }
        private void LoadTheme()
        {
            BackColor = ProgramSettings.CheatTheme.MainThemeColor;
        }
    }
}

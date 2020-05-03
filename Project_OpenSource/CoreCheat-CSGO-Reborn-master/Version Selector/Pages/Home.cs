using System;
using System.Drawing;
using System.Windows.Forms;

namespace CoreCheat_Reborn.Version_Selector.Pages
{
    public partial class Home : UserControl
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }
        private void LoadTheme()
        {
            subTitleTXT.ForeColor = ProgramSettings.CheatTheme.SecondaryThemeColor;
            titleTXT.ForeColor = Color.FromArgb(ProgramSettings.CheatTheme.MainThemeColor.ToArgb() ^ 0xffffff);
            BackColor = ProgramSettings.CheatTheme.MainThemeColor;
        }
    }
}

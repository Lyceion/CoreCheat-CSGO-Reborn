using System;
using System.Drawing;
using System.Windows.Forms;

namespace CoreCheat_Reborn.Version_Selector.Pages
{
    public partial class About : UserControl
    {
        public About()
        {
            InitializeComponent();
            LoadTheme();
        }
        private void LoadTheme()
        {
            BackColor = ProgramSettings.CheatTheme.MainThemeColor;
            infoTXT.ForeColor = Color.FromArgb(ProgramSettings.CheatTheme.MainThemeColor.ToArgb() ^ 0xffffff);
            onwer2TXT.ForeColor = Color.FromArgb(ProgramSettings.CheatTheme.MainThemeColor.ToArgb() ^ 0xffffff);
            owner1TXT.ForeColor = Color.FromArgb(ProgramSettings.CheatTheme.MainThemeColor.ToArgb() ^ 0xffffff);
            owner3TXT.ForeColor = Color.FromArgb(ProgramSettings.CheatTheme.MainThemeColor.ToArgb() ^ 0xffffff);
            owner4TXT.ForeColor = Color.FromArgb(ProgramSettings.CheatTheme.MainThemeColor.ToArgb() ^ 0xffffff);
        }

        private void CylPic_Click(object sender, EventArgs e)
        {
            MessageBox.Show("UR M0M GAY. LOOOOOOOOOOOOOOOOOOL \n" + ProgramSettings.Globals.KEY, "Secret Message");
            Clipboard.SetText(ProgramSettings.Globals.KEY);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoreCheat_Reborn.Versions.Panorama.Pages
{
    public partial class Aimbot : UserControl
    {
        public Aimbot()
        {
            InitializeComponent();
        }

        private void Visuals_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }
        private void LoadTheme()
        {
            BackColor = ProgramSettings.CheatTheme.MainThemeColor;
        }
    }
}

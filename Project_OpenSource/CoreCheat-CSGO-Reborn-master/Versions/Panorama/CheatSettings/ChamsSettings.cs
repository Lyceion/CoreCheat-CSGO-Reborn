using System;
using System.Windows.Forms;
using static CoreCheat_Reborn.CheatClasses.Enums;
using static CoreCheat_Reborn.Versions.Panorama.Settings;

namespace CoreCheat_Reborn.Versions.Panorama.CheatSettings
{
    public partial class ChamsSettings : MetroFramework.Forms.MetroForm
    {
        public static int chamsColorIndex = 0;
        public ChamsSettings()
        {
            InitializeComponent();
            chamsColor.SelectedIndex = chamsColorIndex;
            chamsBrightnessTrack.Value = Convert.ToInt32(VisualConfig.ChamsBrightness);
            chamsBrightnessValueTXT.Text = VisualConfig.ChamsBrightness.ToString();
        }

        private void ChamsBrightnessTrack_Scroll(object sender, ScrollEventArgs e)
        {
            VisualConfig.ChamsBrightness = Convert.ToSingle(chamsBrightnessTrack.Value);
            chamsBrightnessValueTXT.Text = VisualConfig.ChamsBrightness.ToString();
        }

        private void ChamsColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            VisualConfig.selectedChamsColor = (VisualColor)chamsColor.SelectedIndex;
        }
    }
}

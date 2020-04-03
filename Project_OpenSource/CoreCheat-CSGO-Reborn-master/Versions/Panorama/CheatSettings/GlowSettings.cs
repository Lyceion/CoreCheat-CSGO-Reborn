using System;
using static CoreCheat_Reborn.CheatClasses.Enums;
using static CoreCheat_Reborn.Versions.Panorama.Settings;

namespace CoreCheat_Reborn.Versions.Panorama.CheatSettings
{
    public partial class GlowSettings : MetroFramework.Forms.MetroForm
    {
        public static int glowColorIndex = 0;
        public static int glowStyleIndex = 0;
        public static int glowTypeIndex = 0;
        public GlowSettings()
        {
            InitializeComponent();
            glowColor.SelectedIndex = glowColorIndex;
            glowStyle.SelectedIndex = glowStyleIndex;
            glowType.SelectedIndex = glowTypeIndex;
        }

        #region Glow Buttons
        private void GlowColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            VisualConfig.selectedGlowColor = (VisualColor)glowColor.SelectedIndex;
        }
        private void GlowStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            VisualConfig.selectedGlowStyle = (GlowStyle)glowStyle.SelectedIndex;
        }
        private void GlowType_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            VisualConfig.selectedGlowType = (GlowType)glowType.SelectedIndex;
        }
        private void GlowTeamCHCK_CheckedChanged(object sender, EventArgs e)
        {
            VisualConfig.glowLocalTeam = glowTeamCHCK.Checked;
        }
        private void GlowEnemyCHCK_CheckedChanged(object sender, EventArgs e)
        {
            VisualConfig.glowEnemyTeam = glowEnemyCHCK.Checked;
        }
        #endregion
    }
}

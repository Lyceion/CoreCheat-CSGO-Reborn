using System;
using System.Windows.Forms;
using static CoreCheat_Reborn.CheatClasses.Enums;
using static CoreCheat_Reborn.Versions.Panorama.Settings;

namespace CoreCheat_Reborn.Versions.Panorama.CheatSettings
{
    public partial class TriggerSettings : MetroFramework.Forms.MetroForm
    {
        public TriggerSettings()
        {
            InitializeComponent();
            msTXT.Text = timeTrack.Value.ToString() + " ms.";
        }

        private void NoScopeCheck_CheckedChanged(object sender, EventArgs e)
        {
            AssistsConfig.isNoScope = noScopeCheck.Checked;
        }
        private void FriendlyFire_CheckedChanged(object sender, EventArgs e)
        {
            AssistsConfig.isFriendlyFire = friendlyFire.Checked;
        }
        private void RandomRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (randomRadio.Checked)
            {
                customRadio.Checked = false;
                AssistsConfig.isSprayRandom = true;
                timeTrack.Enabled = false;
                applyCustomTime.Enabled = false;
            }
            else
            {
                AssistsConfig.isSprayRandom = false;
                timeTrack.Enabled = true;
                applyCustomTime.Enabled = true;
            }
        }
        private void CustomRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (customRadio.Checked)
            {
                randomRadio.Checked = false;
                AssistsConfig.isSprayRandom = false;
                timeTrack.Enabled = true;
                applyCustomTime.Enabled = true;
            }
            else
            {
                AssistsConfig.isSprayRandom = true;
                timeTrack.Enabled = false;
                applyCustomTime.Enabled = false;
            }
        }
        private void TimeTrack_Scroll(object sender, ScrollEventArgs e)
        {
            msTXT.Text = timeTrack.Value.ToString() + " ms.";
        }
        private void ApplyCustomTime_Click(object sender, EventArgs e)
        {
            WeaponSettings.TriggerSprayTime = timeTrack.Value;
        }

        private void TriggerSettings_Load(object sender, EventArgs e)
        {
            keyCombo.SelectedIndex = (int)AssistsConfig.TriggerKey;
        }

        private void KeyCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            AssistsConfig.TriggerKey = (KeysList)keyCombo.SelectedIndex;
        }
    }
}

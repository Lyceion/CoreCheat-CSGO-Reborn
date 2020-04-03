namespace CoreCheat_Reborn.Versions.Panorama.CheatSettings
{
    partial class TriggerSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TriggerSettings));
            this.friendlyFire = new MetroFramework.Controls.MetroCheckBox();
            this.msTXT = new MetroFramework.Controls.MetroLabel();
            this.sprayTimeText = new MetroFramework.Controls.MetroLabel();
            this.applyCustomTime = new MetroFramework.Controls.MetroButton();
            this.noScopeCheck = new MetroFramework.Controls.MetroCheckBox();
            this.customRadio = new MetroFramework.Controls.MetroRadioButton();
            this.randomRadio = new MetroFramework.Controls.MetroRadioButton();
            this.timeTrack = new MetroFramework.Controls.MetroTrackBar();
            this.keysTXT = new System.Windows.Forms.Label();
            this.keyCombo = new MetroFramework.Controls.MetroComboBox();
            this.SuspendLayout();
            // 
            // friendlyFire
            // 
            this.friendlyFire.AutoSize = true;
            this.friendlyFire.Location = new System.Drawing.Point(172, 66);
            this.friendlyFire.Name = "friendlyFire";
            this.friendlyFire.Size = new System.Drawing.Size(87, 15);
            this.friendlyFire.Style = MetroFramework.MetroColorStyle.Red;
            this.friendlyFire.TabIndex = 18;
            this.friendlyFire.Text = "Friendly Fire";
            this.friendlyFire.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.friendlyFire.UseCustomBackColor = true;
            this.friendlyFire.UseSelectable = true;
            this.friendlyFire.UseStyleColors = true;
            this.friendlyFire.CheckedChanged += new System.EventHandler(this.FriendlyFire_CheckedChanged);
            // 
            // msTXT
            // 
            this.msTXT.AutoSize = true;
            this.msTXT.FontSize = MetroFramework.MetroLabelSize.Small;
            this.msTXT.Location = new System.Drawing.Point(36, 159);
            this.msTXT.Name = "msTXT";
            this.msTXT.Size = new System.Drawing.Size(35, 15);
            this.msTXT.Style = MetroFramework.MetroColorStyle.Blue;
            this.msTXT.TabIndex = 17;
            this.msTXT.Text = "X ms.";
            this.msTXT.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.msTXT.UseCustomBackColor = true;
            this.msTXT.UseStyleColors = true;
            // 
            // sprayTimeText
            // 
            this.sprayTimeText.AutoSize = true;
            this.sprayTimeText.Location = new System.Drawing.Point(33, 98);
            this.sprayTimeText.Name = "sprayTimeText";
            this.sprayTimeText.Size = new System.Drawing.Size(78, 19);
            this.sprayTimeText.Style = MetroFramework.MetroColorStyle.White;
            this.sprayTimeText.TabIndex = 16;
            this.sprayTimeText.Text = "Spray Time:";
            this.sprayTimeText.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.sprayTimeText.UseCustomBackColor = true;
            this.sprayTimeText.UseStyleColors = true;
            // 
            // applyCustomTime
            // 
            this.applyCustomTime.Enabled = false;
            this.applyCustomTime.Location = new System.Drawing.Point(186, 159);
            this.applyCustomTime.Name = "applyCustomTime";
            this.applyCustomTime.Size = new System.Drawing.Size(75, 20);
            this.applyCustomTime.Style = MetroFramework.MetroColorStyle.Red;
            this.applyCustomTime.TabIndex = 15;
            this.applyCustomTime.Text = "Apply Time";
            this.applyCustomTime.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.applyCustomTime.UseCustomBackColor = true;
            this.applyCustomTime.UseSelectable = true;
            this.applyCustomTime.Click += new System.EventHandler(this.ApplyCustomTime_Click);
            // 
            // noScopeCheck
            // 
            this.noScopeCheck.AutoSize = true;
            this.noScopeCheck.Checked = true;
            this.noScopeCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.noScopeCheck.Location = new System.Drawing.Point(36, 66);
            this.noScopeCheck.Name = "noScopeCheck";
            this.noScopeCheck.Size = new System.Drawing.Size(105, 15);
            this.noScopeCheck.Style = MetroFramework.MetroColorStyle.Red;
            this.noScopeCheck.TabIndex = 14;
            this.noScopeCheck.Text = "Shoot NoScope";
            this.noScopeCheck.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.noScopeCheck.UseCustomBackColor = true;
            this.noScopeCheck.UseSelectable = true;
            this.noScopeCheck.UseStyleColors = true;
            this.noScopeCheck.CheckedChanged += new System.EventHandler(this.NoScopeCheck_CheckedChanged);
            // 
            // customRadio
            // 
            this.customRadio.AutoSize = true;
            this.customRadio.Location = new System.Drawing.Point(164, 120);
            this.customRadio.Name = "customRadio";
            this.customRadio.Size = new System.Drawing.Size(95, 15);
            this.customRadio.Style = MetroFramework.MetroColorStyle.Red;
            this.customRadio.TabIndex = 13;
            this.customRadio.Text = "Custom Time";
            this.customRadio.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.customRadio.UseCustomBackColor = true;
            this.customRadio.UseSelectable = true;
            this.customRadio.UseStyleColors = true;
            this.customRadio.CheckedChanged += new System.EventHandler(this.CustomRadio_CheckedChanged);
            // 
            // randomRadio
            // 
            this.randomRadio.AutoSize = true;
            this.randomRadio.Checked = true;
            this.randomRadio.Location = new System.Drawing.Point(36, 120);
            this.randomRadio.Name = "randomRadio";
            this.randomRadio.Size = new System.Drawing.Size(98, 15);
            this.randomRadio.Style = MetroFramework.MetroColorStyle.Red;
            this.randomRadio.TabIndex = 12;
            this.randomRadio.TabStop = true;
            this.randomRadio.Text = "Random Time";
            this.randomRadio.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.randomRadio.UseCustomBackColor = true;
            this.randomRadio.UseSelectable = true;
            this.randomRadio.UseStyleColors = true;
            this.randomRadio.CheckedChanged += new System.EventHandler(this.RandomRadio_CheckedChanged);
            // 
            // timeTrack
            // 
            this.timeTrack.BackColor = System.Drawing.Color.Transparent;
            this.timeTrack.Enabled = false;
            this.timeTrack.Location = new System.Drawing.Point(35, 139);
            this.timeTrack.Maximum = 1000;
            this.timeTrack.Minimum = 10;
            this.timeTrack.Name = "timeTrack";
            this.timeTrack.Size = new System.Drawing.Size(227, 14);
            this.timeTrack.Style = MetroFramework.MetroColorStyle.Red;
            this.timeTrack.TabIndex = 11;
            this.timeTrack.Text = "metroTrackBar1";
            this.timeTrack.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.timeTrack.UseCustomBackColor = true;
            this.timeTrack.Value = 20;
            this.timeTrack.Scroll += new System.Windows.Forms.ScrollEventHandler(this.TimeTrack_Scroll);
            // 
            // keysTXT
            // 
            this.keysTXT.AutoSize = true;
            this.keysTXT.ForeColor = System.Drawing.Color.White;
            this.keysTXT.Location = new System.Drawing.Point(33, 211);
            this.keysTXT.Name = "keysTXT";
            this.keysTXT.Size = new System.Drawing.Size(209, 52);
            this.keysTXT.TabIndex = 19;
            this.keysTXT.Text = "KEY ->\r\n\r\nNote: Keys mode only works while you are \r\nholding key!";
            // 
            // keyCombo
            // 
            this.keyCombo.FormattingEnabled = true;
            this.keyCombo.ItemHeight = 23;
            this.keyCombo.Items.AddRange(new object[] {
            "E",
            "X",
            "V",
            "<",
            "NO KEYS"});
            this.keyCombo.Location = new System.Drawing.Point(79, 203);
            this.keyCombo.Name = "keyCombo";
            this.keyCombo.Size = new System.Drawing.Size(183, 29);
            this.keyCombo.Style = MetroFramework.MetroColorStyle.Red;
            this.keyCombo.TabIndex = 20;
            this.keyCombo.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.keyCombo.UseSelectable = true;
            this.keyCombo.UseStyleColors = true;
            this.keyCombo.SelectedIndexChanged += new System.EventHandler(this.KeyCombo_SelectedIndexChanged);
            // 
            // TriggerSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 277);
            this.Controls.Add(this.keyCombo);
            this.Controls.Add(this.keysTXT);
            this.Controls.Add(this.friendlyFire);
            this.Controls.Add(this.msTXT);
            this.Controls.Add(this.sprayTimeText);
            this.Controls.Add(this.applyCustomTime);
            this.Controls.Add(this.noScopeCheck);
            this.Controls.Add(this.customRadio);
            this.Controls.Add(this.randomRadio);
            this.Controls.Add(this.timeTrack);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TriggerSettings";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Trigger Settings";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.TriggerSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroCheckBox friendlyFire;
        private MetroFramework.Controls.MetroLabel msTXT;
        private MetroFramework.Controls.MetroLabel sprayTimeText;
        private MetroFramework.Controls.MetroButton applyCustomTime;
        private MetroFramework.Controls.MetroCheckBox noScopeCheck;
        private MetroFramework.Controls.MetroRadioButton customRadio;
        private MetroFramework.Controls.MetroRadioButton randomRadio;
        private MetroFramework.Controls.MetroTrackBar timeTrack;
        private System.Windows.Forms.Label keysTXT;
        private MetroFramework.Controls.MetroComboBox keyCombo;
    }
}
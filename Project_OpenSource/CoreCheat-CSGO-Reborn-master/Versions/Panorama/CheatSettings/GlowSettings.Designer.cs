namespace CoreCheat_Reborn.Versions.Panorama.CheatSettings
{
    partial class GlowSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GlowSettings));
            this.glowStyle = new MetroFramework.Controls.MetroComboBox();
            this.glowTypeTXT = new MetroFramework.Controls.MetroLabel();
            this.glowType = new MetroFramework.Controls.MetroComboBox();
            this.glowEnemyCHCK = new MetroFramework.Controls.MetroCheckBox();
            this.glowTeamCHCK = new MetroFramework.Controls.MetroCheckBox();
            this.glowStyleTXT = new MetroFramework.Controls.MetroLabel();
            this.glowColorTXT = new MetroFramework.Controls.MetroLabel();
            this.glowColor = new MetroFramework.Controls.MetroComboBox();
            this.SuspendLayout();
            // 
            // glowStyle
            // 
            this.glowStyle.FormattingEnabled = true;
            this.glowStyle.ItemHeight = 23;
            this.glowStyle.Items.AddRange(new object[] {
            "Outline",
            "Bloom"});
            this.glowStyle.Location = new System.Drawing.Point(35, 137);
            this.glowStyle.Name = "glowStyle";
            this.glowStyle.Size = new System.Drawing.Size(112, 29);
            this.glowStyle.Style = MetroFramework.MetroColorStyle.Green;
            this.glowStyle.TabIndex = 13;
            this.glowStyle.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.glowStyle.UseSelectable = true;
            this.glowStyle.UseStyleColors = true;
            this.glowStyle.SelectedIndexChanged += new System.EventHandler(this.GlowStyle_SelectedIndexChanged);
            // 
            // glowTypeTXT
            // 
            this.glowTypeTXT.AutoSize = true;
            this.glowTypeTXT.FontSize = MetroFramework.MetroLabelSize.Small;
            this.glowTypeTXT.Location = new System.Drawing.Point(35, 184);
            this.glowTypeTXT.Name = "glowTypeTXT";
            this.glowTypeTXT.Size = new System.Drawing.Size(61, 15);
            this.glowTypeTXT.Style = MetroFramework.MetroColorStyle.Silver;
            this.glowTypeTXT.TabIndex = 18;
            this.glowTypeTXT.Text = "Glow Type:";
            this.glowTypeTXT.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.glowTypeTXT.UseCustomBackColor = true;
            // 
            // glowType
            // 
            this.glowType.FormattingEnabled = true;
            this.glowType.ItemHeight = 23;
            this.glowType.Items.AddRange(new object[] {
            "Normal",
            "Moving",
            "Frozen",
            "Breathing"});
            this.glowType.Location = new System.Drawing.Point(35, 199);
            this.glowType.Name = "glowType";
            this.glowType.Size = new System.Drawing.Size(112, 29);
            this.glowType.Style = MetroFramework.MetroColorStyle.Green;
            this.glowType.TabIndex = 17;
            this.glowType.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.glowType.UseSelectable = true;
            this.glowType.UseStyleColors = true;
            this.glowType.SelectedIndexChanged += new System.EventHandler(this.GlowType_SelectedIndexChanged_1);
            // 
            // glowEnemyCHCK
            // 
            this.glowEnemyCHCK.AutoSize = true;
            this.glowEnemyCHCK.Checked = true;
            this.glowEnemyCHCK.CheckState = System.Windows.Forms.CheckState.Checked;
            this.glowEnemyCHCK.Location = new System.Drawing.Point(171, 100);
            this.glowEnemyCHCK.Name = "glowEnemyCHCK";
            this.glowEnemyCHCK.Size = new System.Drawing.Size(89, 15);
            this.glowEnemyCHCK.Style = MetroFramework.MetroColorStyle.Green;
            this.glowEnemyCHCK.TabIndex = 16;
            this.glowEnemyCHCK.Text = "Glow Enemy";
            this.glowEnemyCHCK.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.glowEnemyCHCK.UseCustomBackColor = true;
            this.glowEnemyCHCK.UseSelectable = true;
            this.glowEnemyCHCK.CheckedChanged += new System.EventHandler(this.GlowEnemyCHCK_CheckedChanged);
            // 
            // glowTeamCHCK
            // 
            this.glowTeamCHCK.AutoSize = true;
            this.glowTeamCHCK.Checked = true;
            this.glowTeamCHCK.CheckState = System.Windows.Forms.CheckState.Checked;
            this.glowTeamCHCK.Location = new System.Drawing.Point(171, 79);
            this.glowTeamCHCK.Name = "glowTeamCHCK";
            this.glowTeamCHCK.Size = new System.Drawing.Size(82, 15);
            this.glowTeamCHCK.Style = MetroFramework.MetroColorStyle.Green;
            this.glowTeamCHCK.TabIndex = 15;
            this.glowTeamCHCK.Text = "Glow Team";
            this.glowTeamCHCK.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.glowTeamCHCK.UseCustomBackColor = true;
            this.glowTeamCHCK.UseSelectable = true;
            this.glowTeamCHCK.CheckedChanged += new System.EventHandler(this.GlowTeamCHCK_CheckedChanged);
            // 
            // glowStyleTXT
            // 
            this.glowStyleTXT.AutoSize = true;
            this.glowStyleTXT.FontSize = MetroFramework.MetroLabelSize.Small;
            this.glowStyleTXT.Location = new System.Drawing.Point(35, 123);
            this.glowStyleTXT.Name = "glowStyleTXT";
            this.glowStyleTXT.Size = new System.Drawing.Size(61, 15);
            this.glowStyleTXT.Style = MetroFramework.MetroColorStyle.Silver;
            this.glowStyleTXT.TabIndex = 14;
            this.glowStyleTXT.Text = "Glow Style:";
            this.glowStyleTXT.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.glowStyleTXT.UseCustomBackColor = true;
            // 
            // glowColorTXT
            // 
            this.glowColorTXT.AutoSize = true;
            this.glowColorTXT.FontSize = MetroFramework.MetroLabelSize.Small;
            this.glowColorTXT.Location = new System.Drawing.Point(35, 63);
            this.glowColorTXT.Name = "glowColorTXT";
            this.glowColorTXT.Size = new System.Drawing.Size(66, 15);
            this.glowColorTXT.Style = MetroFramework.MetroColorStyle.Silver;
            this.glowColorTXT.TabIndex = 12;
            this.glowColorTXT.Text = "Glow Color:";
            this.glowColorTXT.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.glowColorTXT.UseCustomBackColor = true;
            // 
            // glowColor
            // 
            this.glowColor.FormattingEnabled = true;
            this.glowColor.ItemHeight = 23;
            this.glowColor.Items.AddRange(new object[] {
            "Engine Colors",
            "Red / Blue",
            "Health Based"});
            this.glowColor.Location = new System.Drawing.Point(35, 79);
            this.glowColor.Name = "glowColor";
            this.glowColor.Size = new System.Drawing.Size(112, 29);
            this.glowColor.Style = MetroFramework.MetroColorStyle.Green;
            this.glowColor.TabIndex = 11;
            this.glowColor.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.glowColor.UseSelectable = true;
            this.glowColor.UseStyleColors = true;
            this.glowColor.SelectedIndexChanged += new System.EventHandler(this.GlowColor_SelectedIndexChanged);
            // 
            // GlowSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 277);
            this.Controls.Add(this.glowStyle);
            this.Controls.Add(this.glowTypeTXT);
            this.Controls.Add(this.glowType);
            this.Controls.Add(this.glowEnemyCHCK);
            this.Controls.Add(this.glowTeamCHCK);
            this.Controls.Add(this.glowStyleTXT);
            this.Controls.Add(this.glowColorTXT);
            this.Controls.Add(this.glowColor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GlowSettings";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Glow Settings";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel glowTypeTXT;
        private MetroFramework.Controls.MetroLabel glowStyleTXT;
        private MetroFramework.Controls.MetroLabel glowColorTXT;
        public MetroFramework.Controls.MetroComboBox glowStyle;
        public MetroFramework.Controls.MetroComboBox glowType;
        public MetroFramework.Controls.MetroCheckBox glowEnemyCHCK;
        public MetroFramework.Controls.MetroCheckBox glowTeamCHCK;
        public MetroFramework.Controls.MetroComboBox glowColor;
    }
}
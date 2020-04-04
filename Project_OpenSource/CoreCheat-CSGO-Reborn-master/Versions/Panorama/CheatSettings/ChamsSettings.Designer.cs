namespace CoreCheat_Reborn.Versions.Panorama.CheatSettings
{
    partial class ChamsSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChamsSettings));
            this.chamsColor = new MetroFramework.Controls.MetroComboBox();
            this.chamsColorTXT = new MetroFramework.Controls.MetroLabel();
            this.chamsBrightnessTrack = new MetroFramework.Controls.MetroTrackBar();
            this.chamsBrightnessTXT = new MetroFramework.Controls.MetroLabel();
            this.chamsBrightnessValueTXT = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // chamsColor
            // 
            this.chamsColor.FormattingEnabled = true;
            this.chamsColor.ItemHeight = 23;
            this.chamsColor.Items.AddRange(new object[] {
            "Engine Colors",
            "Red / Blue",
            "Health Based"});
            this.chamsColor.Location = new System.Drawing.Point(35, 79);
            this.chamsColor.Name = "chamsColor";
            this.chamsColor.Size = new System.Drawing.Size(120, 29);
            this.chamsColor.Style = MetroFramework.MetroColorStyle.Green;
            this.chamsColor.TabIndex = 3;
            this.chamsColor.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.chamsColor.UseSelectable = true;
            this.chamsColor.UseStyleColors = true;
            this.chamsColor.SelectedIndexChanged += new System.EventHandler(this.ChamsColor_SelectedIndexChanged);
            // 
            // chamsColorTXT
            // 
            this.chamsColorTXT.AutoSize = true;
            this.chamsColorTXT.FontSize = MetroFramework.MetroLabelSize.Small;
            this.chamsColorTXT.Location = new System.Drawing.Point(35, 63);
            this.chamsColorTXT.Name = "chamsColorTXT";
            this.chamsColorTXT.Size = new System.Drawing.Size(75, 15);
            this.chamsColorTXT.Style = MetroFramework.MetroColorStyle.Silver;
            this.chamsColorTXT.TabIndex = 13;
            this.chamsColorTXT.Text = "Chams Color:";
            this.chamsColorTXT.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.chamsColorTXT.UseCustomBackColor = true;
            // 
            // chamsBrightnessTrack
            // 
            this.chamsBrightnessTrack.BackColor = System.Drawing.Color.Transparent;
            this.chamsBrightnessTrack.Location = new System.Drawing.Point(35, 139);
            this.chamsBrightnessTrack.Maximum = 255;
            this.chamsBrightnessTrack.Name = "chamsBrightnessTrack";
            this.chamsBrightnessTrack.Size = new System.Drawing.Size(204, 23);
            this.chamsBrightnessTrack.Style = MetroFramework.MetroColorStyle.Red;
            this.chamsBrightnessTrack.TabIndex = 14;
            this.chamsBrightnessTrack.Text = "Chams Brightness:";
            this.chamsBrightnessTrack.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.chamsBrightnessTrack.Value = 10;
            this.chamsBrightnessTrack.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ChamsBrightnessTrack_Scroll);
            // 
            // chamsBrightnessTXT
            // 
            this.chamsBrightnessTXT.AutoSize = true;
            this.chamsBrightnessTXT.FontSize = MetroFramework.MetroLabelSize.Small;
            this.chamsBrightnessTXT.Location = new System.Drawing.Point(35, 121);
            this.chamsBrightnessTXT.Name = "chamsBrightnessTXT";
            this.chamsBrightnessTXT.Size = new System.Drawing.Size(99, 15);
            this.chamsBrightnessTXT.Style = MetroFramework.MetroColorStyle.Silver;
            this.chamsBrightnessTXT.TabIndex = 15;
            this.chamsBrightnessTXT.Text = "Chams Brightness:";
            this.chamsBrightnessTXT.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.chamsBrightnessTXT.UseCustomBackColor = true;
            // 
            // chamsBrightnessValueTXT
            // 
            this.chamsBrightnessValueTXT.AutoSize = true;
            this.chamsBrightnessValueTXT.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.chamsBrightnessValueTXT.Location = new System.Drawing.Point(245, 140);
            this.chamsBrightnessValueTXT.Name = "chamsBrightnessValueTXT";
            this.chamsBrightnessValueTXT.Size = new System.Drawing.Size(25, 19);
            this.chamsBrightnessValueTXT.Style = MetroFramework.MetroColorStyle.Silver;
            this.chamsBrightnessValueTXT.TabIndex = 16;
            this.chamsBrightnessValueTXT.Text = "10";
            this.chamsBrightnessValueTXT.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.chamsBrightnessValueTXT.UseCustomBackColor = true;
            // 
            // ChamsSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 277);
            this.Controls.Add(this.chamsBrightnessValueTXT);
            this.Controls.Add(this.chamsBrightnessTXT);
            this.Controls.Add(this.chamsBrightnessTrack);
            this.Controls.Add(this.chamsColorTXT);
            this.Controls.Add(this.chamsColor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChamsSettings";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Chams Settings";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel chamsColorTXT;
        private MetroFramework.Controls.MetroLabel chamsBrightnessTXT;
        public MetroFramework.Controls.MetroComboBox chamsColor;
        public MetroFramework.Controls.MetroTrackBar chamsBrightnessTrack;
        private MetroFramework.Controls.MetroLabel chamsBrightnessValueTXT;
    }
}
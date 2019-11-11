namespace CoreCheat_LSREMAKE.Versions.Panorama
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.mainPanel = new MetroFramework.Controls.MetroPanel();
            this.bunnyButton = new MetroFramework.Controls.MetroToggle();
            this.bunnyTXT = new MetroFramework.Controls.MetroLabel();
            this.radarCheck = new MetroFramework.Controls.MetroToggle();
            this.radarTXT = new MetroFramework.Controls.MetroLabel();
            this.flashButton = new MetroFramework.Controls.MetroToggle();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.glowTXT = new MetroFramework.Controls.MetroLabel();
            this.glowToggle = new MetroFramework.Controls.MetroToggle();
            this.illuTXT = new System.Windows.Forms.Label();
            this.titleTimer = new System.Windows.Forms.Timer(this.components);
            this.triggerButton = new MetroFramework.Controls.MetroToggle();
            this.triggerTXT = new MetroFramework.Controls.MetroLabel();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.triggerButton);
            this.mainPanel.Controls.Add(this.triggerTXT);
            this.mainPanel.Controls.Add(this.bunnyButton);
            this.mainPanel.Controls.Add(this.bunnyTXT);
            this.mainPanel.Controls.Add(this.radarCheck);
            this.mainPanel.Controls.Add(this.radarTXT);
            this.mainPanel.Controls.Add(this.flashButton);
            this.mainPanel.Controls.Add(this.metroLabel3);
            this.mainPanel.Controls.Add(this.glowTXT);
            this.mainPanel.Controls.Add(this.glowToggle);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.HorizontalScrollbarBarColor = true;
            this.mainPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.mainPanel.HorizontalScrollbarSize = 10;
            this.mainPanel.Location = new System.Drawing.Point(20, 60);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(251, 306);
            this.mainPanel.Style = MetroFramework.MetroColorStyle.Silver;
            this.mainPanel.TabIndex = 7;
            this.mainPanel.VerticalScrollbarBarColor = true;
            this.mainPanel.VerticalScrollbarHighlightOnWheel = false;
            this.mainPanel.VerticalScrollbarSize = 10;
            // 
            // bunnyButton
            // 
            this.bunnyButton.AutoSize = true;
            this.bunnyButton.Location = new System.Drawing.Point(163, 84);
            this.bunnyButton.Name = "bunnyButton";
            this.bunnyButton.Size = new System.Drawing.Size(80, 17);
            this.bunnyButton.TabIndex = 12;
            this.bunnyButton.Text = "Off";
            this.bunnyButton.UseSelectable = true;
            this.bunnyButton.CheckedChanged += new System.EventHandler(this.BunnyButton_CheckedChanged);
            // 
            // bunnyTXT
            // 
            this.bunnyTXT.AutoSize = true;
            this.bunnyTXT.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.bunnyTXT.ForeColor = System.Drawing.Color.Yellow;
            this.bunnyTXT.Location = new System.Drawing.Point(6, 84);
            this.bunnyTXT.Name = "bunnyTXT";
            this.bunnyTXT.Size = new System.Drawing.Size(98, 19);
            this.bunnyTXT.Style = MetroFramework.MetroColorStyle.Black;
            this.bunnyTXT.TabIndex = 11;
            this.bunnyTXT.Text = "BunnyHop =>";
            this.bunnyTXT.UseStyleColors = true;
            // 
            // radarCheck
            // 
            this.radarCheck.AutoSize = true;
            this.radarCheck.Location = new System.Drawing.Point(163, 59);
            this.radarCheck.Name = "radarCheck";
            this.radarCheck.Size = new System.Drawing.Size(80, 17);
            this.radarCheck.TabIndex = 10;
            this.radarCheck.Text = "Off";
            this.radarCheck.UseSelectable = true;
            this.radarCheck.CheckedChanged += new System.EventHandler(this.RadarCheck_CheckedChanged);
            // 
            // radarTXT
            // 
            this.radarTXT.AutoSize = true;
            this.radarTXT.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.radarTXT.ForeColor = System.Drawing.Color.Yellow;
            this.radarTXT.Location = new System.Drawing.Point(6, 59);
            this.radarTXT.Name = "radarTXT";
            this.radarTXT.Size = new System.Drawing.Size(113, 19);
            this.radarTXT.Style = MetroFramework.MetroColorStyle.Black;
            this.radarTXT.TabIndex = 9;
            this.radarTXT.Text = "Engine Radar =>";
            this.radarTXT.UseStyleColors = true;
            // 
            // flashButton
            // 
            this.flashButton.AutoSize = true;
            this.flashButton.Location = new System.Drawing.Point(163, 35);
            this.flashButton.Name = "flashButton";
            this.flashButton.Size = new System.Drawing.Size(80, 17);
            this.flashButton.TabIndex = 8;
            this.flashButton.Text = "Off";
            this.flashButton.UseSelectable = true;
            this.flashButton.CheckedChanged += new System.EventHandler(this.flashButton_CheckedChanged);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.ForeColor = System.Drawing.Color.Yellow;
            this.metroLabel3.Location = new System.Drawing.Point(6, 35);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(82, 19);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel3.TabIndex = 7;
            this.metroLabel3.Text = "NoFlash =>";
            this.metroLabel3.UseStyleColors = true;
            // 
            // glowTXT
            // 
            this.glowTXT.AutoSize = true;
            this.glowTXT.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.glowTXT.Location = new System.Drawing.Point(6, 9);
            this.glowTXT.Name = "glowTXT";
            this.glowTXT.Size = new System.Drawing.Size(86, 19);
            this.glowTXT.Style = MetroFramework.MetroColorStyle.Black;
            this.glowTXT.TabIndex = 3;
            this.glowTXT.Text = "Glow ESP =>";
            this.glowTXT.UseStyleColors = true;
            // 
            // glowToggle
            // 
            this.glowToggle.AutoSize = true;
            this.glowToggle.Location = new System.Drawing.Point(163, 10);
            this.glowToggle.Name = "glowToggle";
            this.glowToggle.Size = new System.Drawing.Size(80, 17);
            this.glowToggle.TabIndex = 2;
            this.glowToggle.Text = "Off";
            this.glowToggle.UseSelectable = true;
            this.glowToggle.CheckedChanged += new System.EventHandler(this.glowToggle_CheckedChanged);
            // 
            // illuTXT
            // 
            this.illuTXT.AutoSize = true;
            this.illuTXT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.illuTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.illuTXT.ForeColor = System.Drawing.Color.Red;
            this.illuTXT.Location = new System.Drawing.Point(89, 275);
            this.illuTXT.Name = "illuTXT";
            this.illuTXT.Size = new System.Drawing.Size(103, 13);
            this.illuTXT.TabIndex = 8;
            this.illuTXT.Text = "&By Cylops For ~ DHT";
            // 
            // titleTimer
            // 
            this.titleTimer.Enabled = true;
            this.titleTimer.Interval = 4500;
            this.titleTimer.Tick += new System.EventHandler(this.titleTimer_Tick);
            // 
            // triggerButton
            // 
            this.triggerButton.AutoSize = true;
            this.triggerButton.Enabled = false;
            this.triggerButton.Location = new System.Drawing.Point(163, 111);
            this.triggerButton.Name = "triggerButton";
            this.triggerButton.Size = new System.Drawing.Size(80, 17);
            this.triggerButton.TabIndex = 14;
            this.triggerButton.Text = "Off";
            this.triggerButton.UseSelectable = true;
            this.triggerButton.CheckedChanged += new System.EventHandler(this.TriggerButton_CheckedChanged);
            // 
            // triggerTXT
            // 
            this.triggerTXT.AutoSize = true;
            this.triggerTXT.Enabled = false;
            this.triggerTXT.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.triggerTXT.ForeColor = System.Drawing.Color.Yellow;
            this.triggerTXT.Location = new System.Drawing.Point(6, 111);
            this.triggerTXT.Name = "triggerTXT";
            this.triggerTXT.Size = new System.Drawing.Size(96, 19);
            this.triggerTXT.Style = MetroFramework.MetroColorStyle.Black;
            this.triggerTXT.TabIndex = 13;
            this.triggerTXT.Text = "TriggerBot =>";
            this.triggerTXT.UseStyleColors = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 386);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.illuTXT);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Text = "VERSION PANORAMA";
            this.TransparencyKey = System.Drawing.Color.Wheat;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Inject_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroPanel mainPanel;
        private MetroFramework.Controls.MetroLabel glowTXT;
        private MetroFramework.Controls.MetroToggle glowToggle;
        private System.Windows.Forms.Label illuTXT;
        private System.Windows.Forms.Timer titleTimer;
        private MetroFramework.Controls.MetroToggle flashButton;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroToggle radarCheck;
        private MetroFramework.Controls.MetroLabel radarTXT;
        private MetroFramework.Controls.MetroToggle bunnyButton;
        private MetroFramework.Controls.MetroLabel bunnyTXT;
        private MetroFramework.Controls.MetroToggle triggerButton;
        private MetroFramework.Controls.MetroLabel triggerTXT;
    }
}
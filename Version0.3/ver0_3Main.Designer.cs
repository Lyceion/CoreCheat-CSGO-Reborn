namespace CoreCheat_Reborn.Version0._3
{
    partial class ver0_3Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ver0_3Main));
            this.mainPanel = new MetroFramework.Controls.MetroPanel();
            this.flashButton = new MetroFramework.Controls.MetroToggle();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.updFOV = new MetroFramework.Controls.MetroButton();
            this.fovValTXT = new System.Windows.Forms.Label();
            this.fovTXT = new MetroFramework.Controls.MetroLabel();
            this.fovTrack = new MetroFramework.Controls.MetroTrackBar();
            this.glowTXT = new MetroFramework.Controls.MetroLabel();
            this.glowToggle = new MetroFramework.Controls.MetroToggle();
            this.illuTXT = new System.Windows.Forms.Label();
            this.titleTimer = new System.Windows.Forms.Timer(this.components);
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.flashButton);
            this.mainPanel.Controls.Add(this.metroLabel3);
            this.mainPanel.Controls.Add(this.updFOV);
            this.mainPanel.Controls.Add(this.fovValTXT);
            this.mainPanel.Controls.Add(this.fovTXT);
            this.mainPanel.Controls.Add(this.fovTrack);
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
            // flashButton
            // 
            this.flashButton.AutoSize = true;
            this.flashButton.Location = new System.Drawing.Point(163, 191);
            this.flashButton.Name = "flashButton";
            this.flashButton.Size = new System.Drawing.Size(80, 17);
            this.flashButton.Style = MetroFramework.MetroColorStyle.Silver;
            this.flashButton.TabIndex = 8;
            this.flashButton.Text = "Off";
            this.flashButton.UseSelectable = true;
            this.flashButton.UseStyleColors = true;
            this.flashButton.CheckedChanged += new System.EventHandler(this.flashButton_CheckedChanged);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.ForeColor = System.Drawing.Color.Yellow;
            this.metroLabel3.Location = new System.Drawing.Point(6, 191);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(82, 19);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroLabel3.TabIndex = 7;
            this.metroLabel3.Text = "NoFlash =>";
            this.metroLabel3.UseStyleColors = true;
            // 
            // updFOV
            // 
            this.updFOV.Location = new System.Drawing.Point(146, 119);
            this.updFOV.Name = "updFOV";
            this.updFOV.Size = new System.Drawing.Size(75, 23);
            this.updFOV.Style = MetroFramework.MetroColorStyle.Silver;
            this.updFOV.TabIndex = 6;
            this.updFOV.Text = "Update FOV!";
            this.updFOV.UseSelectable = true;
            this.updFOV.UseStyleColors = true;
            this.updFOV.Click += new System.EventHandler(this.updFOV_Click);
            // 
            // fovValTXT
            // 
            this.fovValTXT.AutoSize = true;
            this.fovValTXT.BackColor = System.Drawing.Color.White;
            this.fovValTXT.ForeColor = System.Drawing.Color.Black;
            this.fovValTXT.Location = new System.Drawing.Point(10, 124);
            this.fovValTXT.Name = "fovValTXT";
            this.fovValTXT.Size = new System.Drawing.Size(94, 13);
            this.fovValTXT.TabIndex = 5;
            this.fovValTXT.Text = "FOV Value => 100";
            // 
            // fovTXT
            // 
            this.fovTXT.AutoSize = true;
            this.fovTXT.Location = new System.Drawing.Point(6, 69);
            this.fovTXT.Name = "fovTXT";
            this.fovTXT.Size = new System.Drawing.Size(70, 19);
            this.fovTXT.Style = MetroFramework.MetroColorStyle.Black;
            this.fovTXT.TabIndex = 4;
            this.fovTXT.Text = "FOV Hack:";
            this.fovTXT.UseStyleColors = true;
            // 
            // fovTrack
            // 
            this.fovTrack.BackColor = System.Drawing.Color.Transparent;
            this.fovTrack.Location = new System.Drawing.Point(13, 91);
            this.fovTrack.Maximum = 160;
            this.fovTrack.Minimum = 90;
            this.fovTrack.Name = "fovTrack";
            this.fovTrack.Size = new System.Drawing.Size(213, 23);
            this.fovTrack.Style = MetroFramework.MetroColorStyle.Silver;
            this.fovTrack.TabIndex = 1;
            this.fovTrack.Text = "FOV";
            this.fovTrack.Value = 100;
            this.fovTrack.Scroll += new System.Windows.Forms.ScrollEventHandler(this.fovTrack_Scroll);
            // 
            // glowTXT
            // 
            this.glowTXT.AutoSize = true;
            this.glowTXT.Location = new System.Drawing.Point(6, 21);
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
            this.glowToggle.Location = new System.Drawing.Point(163, 22);
            this.glowToggle.Name = "glowToggle";
            this.glowToggle.Size = new System.Drawing.Size(80, 17);
            this.glowToggle.Style = MetroFramework.MetroColorStyle.Silver;
            this.glowToggle.TabIndex = 2;
            this.glowToggle.Text = "Off";
            this.glowToggle.UseSelectable = true;
            this.glowToggle.UseStyleColors = true;
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
            // ver0_3Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 386);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.illuTXT);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ver0_3Main";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "PANAROMA SPECIAL";
            this.TransparencyKey = System.Drawing.Color.Wheat;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Inject_FormClosing);
            this.Load += new System.EventHandler(this.ver0_3Main_Load);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroPanel mainPanel;
        private MetroFramework.Controls.MetroButton updFOV;
        private System.Windows.Forms.Label fovValTXT;
        private MetroFramework.Controls.MetroLabel fovTXT;
        private MetroFramework.Controls.MetroTrackBar fovTrack;
        private MetroFramework.Controls.MetroLabel glowTXT;
        private MetroFramework.Controls.MetroToggle glowToggle;
        private System.Windows.Forms.Label illuTXT;
        private System.Windows.Forms.Timer titleTimer;
        private MetroFramework.Controls.MetroToggle flashButton;
        private MetroFramework.Controls.MetroLabel metroLabel3;
    }
}
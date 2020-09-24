namespace CoreCheat_Reborn.Version_Selector
{
    partial class VersionSelector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VersionSelector));
            this.TopPanel = new System.Windows.Forms.Panel();
            this.ControlBoxPanel = new System.Windows.Forms.Panel();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.topGlow = new System.Windows.Forms.Panel();
            this.SideBarPanel = new System.Windows.Forms.Panel();
            this.selectIndicator = new System.Windows.Forms.Panel();
            this.AboutButton = new System.Windows.Forms.Button();
            this.VersionButton = new System.Windows.Forms.Button();
            this.HomeButton = new System.Windows.Forms.Button();
            this.logoTXT2 = new System.Windows.Forms.Label();
            this.logoTXT = new System.Windows.Forms.Label();
            this.LogoPicture = new System.Windows.Forms.PictureBox();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.TopPanel.SuspendLayout();
            this.ControlBoxPanel.SuspendLayout();
            this.SideBarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.Black;
            this.TopPanel.Controls.Add(this.ControlBoxPanel);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(270, 0);
            this.TopPanel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1162, 54);
            this.TopPanel.TabIndex = 1;
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Drag_MouseDown);
            this.TopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Drag_MouseMove);
            this.TopPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Drag_MouseUp);
            // 
            // ControlBoxPanel
            // 
            this.ControlBoxPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.ControlBoxPanel.Controls.Add(this.MinimizeButton);
            this.ControlBoxPanel.Controls.Add(this.CloseButton);
            this.ControlBoxPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.ControlBoxPanel.Location = new System.Drawing.Point(960, 0);
            this.ControlBoxPanel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ControlBoxPanel.Name = "ControlBoxPanel";
            this.ControlBoxPanel.Size = new System.Drawing.Size(202, 54);
            this.ControlBoxPanel.TabIndex = 2;
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.BackColor = System.Drawing.Color.Black;
            this.MinimizeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.MinimizeButton.FlatAppearance.BorderSize = 0;
            this.MinimizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.MinimizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.MinimizeButton.ForeColor = System.Drawing.Color.White;
            this.MinimizeButton.Location = new System.Drawing.Point(8, 0);
            this.MinimizeButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(97, 54);
            this.MinimizeButton.TabIndex = 3;
            this.MinimizeButton.Text = "_";
            this.MinimizeButton.UseVisualStyleBackColor = false;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.Black;
            this.CloseButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.CloseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CloseButton.ForeColor = System.Drawing.Color.White;
            this.CloseButton.Location = new System.Drawing.Point(105, 0);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(97, 54);
            this.CloseButton.TabIndex = 2;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // topGlow
            // 
            this.topGlow.BackColor = System.Drawing.Color.Black;
            this.topGlow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.topGlow.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.topGlow.Location = new System.Drawing.Point(0, 700);
            this.topGlow.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.topGlow.Name = "topGlow";
            this.topGlow.Size = new System.Drawing.Size(1432, 2);
            this.topGlow.TabIndex = 4;
            this.topGlow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Drag_MouseDown);
            this.topGlow.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Drag_MouseMove);
            this.topGlow.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Drag_MouseUp);
            // 
            // SideBarPanel
            // 
            this.SideBarPanel.BackColor = System.Drawing.Color.Black;
            this.SideBarPanel.Controls.Add(this.selectIndicator);
            this.SideBarPanel.Controls.Add(this.AboutButton);
            this.SideBarPanel.Controls.Add(this.VersionButton);
            this.SideBarPanel.Controls.Add(this.HomeButton);
            this.SideBarPanel.Controls.Add(this.logoTXT2);
            this.SideBarPanel.Controls.Add(this.logoTXT);
            this.SideBarPanel.Controls.Add(this.LogoPicture);
            this.SideBarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideBarPanel.Location = new System.Drawing.Point(0, 0);
            this.SideBarPanel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.SideBarPanel.Name = "SideBarPanel";
            this.SideBarPanel.Size = new System.Drawing.Size(270, 700);
            this.SideBarPanel.TabIndex = 5;
            this.SideBarPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Drag_MouseDown);
            this.SideBarPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Drag_MouseMove);
            this.SideBarPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Drag_MouseUp);
            // 
            // selectIndicator
            // 
            this.selectIndicator.BackColor = System.Drawing.Color.White;
            this.selectIndicator.Location = new System.Drawing.Point(15, 192);
            this.selectIndicator.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.selectIndicator.Name = "selectIndicator";
            this.selectIndicator.Size = new System.Drawing.Size(9, 68);
            this.selectIndicator.TabIndex = 6;
            // 
            // AboutButton
            // 
            this.AboutButton.BackColor = System.Drawing.Color.Black;
            this.AboutButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.AboutButton.FlatAppearance.BorderSize = 0;
            this.AboutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AboutButton.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AboutButton.ForeColor = System.Drawing.Color.White;
            this.AboutButton.Location = new System.Drawing.Point(26, 343);
            this.AboutButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(248, 68);
            this.AboutButton.TabIndex = 5;
            this.AboutButton.Text = "About";
            this.AboutButton.UseVisualStyleBackColor = false;
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // VersionButton
            // 
            this.VersionButton.BackColor = System.Drawing.Color.Black;
            this.VersionButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.VersionButton.FlatAppearance.BorderSize = 0;
            this.VersionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VersionButton.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.VersionButton.ForeColor = System.Drawing.Color.White;
            this.VersionButton.Location = new System.Drawing.Point(26, 268);
            this.VersionButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.VersionButton.Name = "VersionButton";
            this.VersionButton.Size = new System.Drawing.Size(248, 68);
            this.VersionButton.TabIndex = 4;
            this.VersionButton.Text = "Versions";
            this.VersionButton.UseVisualStyleBackColor = false;
            this.VersionButton.Click += new System.EventHandler(this.VersionButton_Click);
            // 
            // HomeButton
            // 
            this.HomeButton.BackColor = System.Drawing.Color.Black;
            this.HomeButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.HomeButton.FlatAppearance.BorderSize = 0;
            this.HomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeButton.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.HomeButton.ForeColor = System.Drawing.Color.White;
            this.HomeButton.Location = new System.Drawing.Point(26, 192);
            this.HomeButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(249, 68);
            this.HomeButton.TabIndex = 3;
            this.HomeButton.Text = "Home";
            this.HomeButton.UseVisualStyleBackColor = false;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // logoTXT2
            // 
            this.logoTXT2.AutoSize = true;
            this.logoTXT2.Font = new System.Drawing.Font("Segoe UI Light", 9F);
            this.logoTXT2.ForeColor = System.Drawing.Color.White;
            this.logoTXT2.Location = new System.Drawing.Point(15, 622);
            this.logoTXT2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.logoTXT2.Name = "logoTXT2";
            this.logoTXT2.Size = new System.Drawing.Size(174, 60);
            this.logoTXT2.TabIndex = 2;
            this.logoTXT2.Text = "Brought to you by\r\nLYSEP CORP.";
            this.logoTXT2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // logoTXT
            // 
            this.logoTXT.AutoSize = true;
            this.logoTXT.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.logoTXT.ForeColor = System.Drawing.Color.White;
            this.logoTXT.Location = new System.Drawing.Point(39, 6);
            this.logoTXT.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.logoTXT.Name = "logoTXT";
            this.logoTXT.Size = new System.Drawing.Size(172, 42);
            this.logoTXT.TabIndex = 1;
            this.logoTXT.Text = "Core Cheat";
            this.logoTXT.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Drag_MouseDown);
            this.logoTXT.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Drag_MouseMove);
            this.logoTXT.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Drag_MouseUp);
            // 
            // LogoPicture
            // 
            this.LogoPicture.Image = global::CoreCheat_Reborn.Properties.Resources.CoreCheatTransparent;
            this.LogoPicture.Location = new System.Drawing.Point(94, 59);
            this.LogoPicture.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.LogoPicture.Name = "LogoPicture";
            this.LogoPicture.Size = new System.Drawing.Size(68, 68);
            this.LogoPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoPicture.TabIndex = 0;
            this.LogoPicture.TabStop = false;
            this.LogoPicture.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Drag_MouseDown);
            this.LogoPicture.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Drag_MouseMove);
            this.LogoPicture.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Drag_MouseUp);
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.Black;
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(270, 54);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1162, 646);
            this.MainPanel.TabIndex = 6;
            // 
            // VersionSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(1432, 702);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.SideBarPanel);
            this.Controls.Add(this.topGlow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VersionSelector";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VersionSelectorNEW";
            this.Load += new System.EventHandler(this.VersionSelectorNEW_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Drag_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Drag_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Drag_MouseUp);
            this.TopPanel.ResumeLayout(false);
            this.ControlBoxPanel.ResumeLayout(false);
            this.SideBarPanel.ResumeLayout(false);
            this.SideBarPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Panel ControlBoxPanel;
        private System.Windows.Forms.Button MinimizeButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Panel topGlow;
        private System.Windows.Forms.Panel SideBarPanel;
        private System.Windows.Forms.PictureBox LogoPicture;
        private System.Windows.Forms.Label logoTXT;
        private System.Windows.Forms.Label logoTXT2;
        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.Button AboutButton;
        private System.Windows.Forms.Button VersionButton;
        private System.Windows.Forms.Panel selectIndicator;
        private System.Windows.Forms.Panel MainPanel;
    }
}
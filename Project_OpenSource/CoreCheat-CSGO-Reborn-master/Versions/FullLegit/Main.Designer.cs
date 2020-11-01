namespace CoreCheat_Reborn.Versions.FullLegit
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
            this.headerText = new System.Windows.Forms.Label();
            this.headerSubText = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.headerPic = new System.Windows.Forms.PictureBox();
            this.deadEspButton = new System.Windows.Forms.CheckBox();
            this.chamsButton = new System.Windows.Forms.CheckBox();
            this.triggerButton = new System.Windows.Forms.CheckBox();
            this.closeBtn = new System.Windows.Forms.Button();
            this.titleChgr = new System.Windows.Forms.Timer(this.components);
            this.radarButton = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.headerPic)).BeginInit();
            this.SuspendLayout();
            // 
            // headerText
            // 
            this.headerText.AutoSize = true;
            this.headerText.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.headerText.ForeColor = System.Drawing.Color.White;
            this.headerText.Location = new System.Drawing.Point(70, 3);
            this.headerText.Name = "headerText";
            this.headerText.Size = new System.Drawing.Size(132, 37);
            this.headerText.TabIndex = 0;
            this.headerText.Text = "CoreLegit";
            // 
            // headerSubText
            // 
            this.headerSubText.AutoSize = true;
            this.headerSubText.Font = new System.Drawing.Font("Segoe Print", 7F, System.Drawing.FontStyle.Italic);
            this.headerSubText.ForeColor = System.Drawing.Color.DarkRed;
            this.headerSubText.Location = new System.Drawing.Point(80, 42);
            this.headerSubText.Name = "headerSubText";
            this.headerSubText.Size = new System.Drawing.Size(106, 34);
            this.headerSubText.TabIndex = 2;
            this.headerSubText.Text = "\"Real legit cheating\r\nexperiance...\"";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.headerPic);
            this.panel1.Controls.Add(this.headerSubText);
            this.panel1.Controls.Add(this.headerText);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(224, 83);
            this.panel1.TabIndex = 3;
            // 
            // headerPic
            // 
            this.headerPic.Image = global::CoreCheat_Reborn.Properties.Resources.CoreCheatModified;
            this.headerPic.Location = new System.Drawing.Point(12, 14);
            this.headerPic.Name = "headerPic";
            this.headerPic.Size = new System.Drawing.Size(62, 62);
            this.headerPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.headerPic.TabIndex = 1;
            this.headerPic.TabStop = false;
            // 
            // deadEspButton
            // 
            this.deadEspButton.AutoSize = true;
            this.deadEspButton.ForeColor = System.Drawing.Color.Red;
            this.deadEspButton.Location = new System.Drawing.Point(12, 88);
            this.deadEspButton.Name = "deadEspButton";
            this.deadEspButton.Size = new System.Drawing.Size(76, 17);
            this.deadEspButton.TabIndex = 4;
            this.deadEspButton.Text = "Dead ESP";
            this.deadEspButton.UseVisualStyleBackColor = true;
            this.deadEspButton.CheckedChanged += new System.EventHandler(this.DeadEspButton_CheckedChanged);
            // 
            // chamsButton
            // 
            this.chamsButton.AutoSize = true;
            this.chamsButton.ForeColor = System.Drawing.Color.Red;
            this.chamsButton.Location = new System.Drawing.Point(12, 111);
            this.chamsButton.Name = "chamsButton";
            this.chamsButton.Size = new System.Drawing.Size(92, 17);
            this.chamsButton.TabIndex = 5;
            this.chamsButton.Text = "Health Chams";
            this.chamsButton.UseVisualStyleBackColor = true;
            this.chamsButton.CheckedChanged += new System.EventHandler(this.ChamsButton_CheckedChanged);
            // 
            // triggerButton
            // 
            this.triggerButton.AutoSize = true;
            this.triggerButton.Enabled = false;
            this.triggerButton.ForeColor = System.Drawing.Color.Red;
            this.triggerButton.Location = new System.Drawing.Point(12, 157);
            this.triggerButton.Name = "triggerButton";
            this.triggerButton.Size = new System.Drawing.Size(115, 17);
            this.triggerButton.TabIndex = 6;
            this.triggerButton.Text = "Humanized Trigger";
            this.triggerButton.UseVisualStyleBackColor = true;
            this.triggerButton.Visible = false;
            this.triggerButton.CheckedChanged += new System.EventHandler(this.TriggerButton_CheckedChanged);
            // 
            // closeBtn
            // 
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.ForeColor = System.Drawing.Color.White;
            this.closeBtn.Location = new System.Drawing.Point(9, 182);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(48, 23);
            this.closeBtn.TabIndex = 7;
            this.closeBtn.Text = "[EXIT]";
            this.closeBtn.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // titleChgr
            // 
            this.titleChgr.Enabled = true;
            this.titleChgr.Interval = 1000;
            this.titleChgr.Tick += new System.EventHandler(this.TitleChgr_Tick);
            // 
            // radarButton
            // 
            this.radarButton.AutoSize = true;
            this.radarButton.ForeColor = System.Drawing.Color.Red;
            this.radarButton.Location = new System.Drawing.Point(12, 134);
            this.radarButton.Name = "radarButton";
            this.radarButton.Size = new System.Drawing.Size(91, 17);
            this.radarButton.TabIndex = 8;
            this.radarButton.Text = "Engine Radar";
            this.radarButton.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(224, 208);
            this.Controls.Add(this.radarButton);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.triggerButton);
            this.Controls.Add(this.chamsButton);
            this.Controls.Add(this.deadEspButton);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.headerPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerText;
        private System.Windows.Forms.PictureBox headerPic;
        private System.Windows.Forms.Label headerSubText;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox deadEspButton;
        private System.Windows.Forms.CheckBox chamsButton;
        private System.Windows.Forms.CheckBox triggerButton;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Timer titleChgr;
        private System.Windows.Forms.CheckBox radarButton;
    }
}
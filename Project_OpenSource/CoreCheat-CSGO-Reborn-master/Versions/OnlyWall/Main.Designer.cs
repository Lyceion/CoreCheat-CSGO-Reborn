namespace CoreCheat_Reborn.Versions.OnlyWall
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
            this.mainGroup = new System.Windows.Forms.GroupBox();
            this.trashPerf = new System.Windows.Forms.RadioButton();
            this.lowPerf = new System.Windows.Forms.RadioButton();
            this.mediumPerf = new System.Windows.Forms.RadioButton();
            this.highPerf = new System.Windows.Forms.RadioButton();
            this.activeButton = new System.Windows.Forms.CheckBox();
            this.titleTimer = new System.Windows.Forms.Timer(this.components);
            this.mainGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainGroup
            // 
            this.mainGroup.Controls.Add(this.trashPerf);
            this.mainGroup.Controls.Add(this.lowPerf);
            this.mainGroup.Controls.Add(this.mediumPerf);
            this.mainGroup.Controls.Add(this.highPerf);
            this.mainGroup.Controls.Add(this.activeButton);
            this.mainGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainGroup.Location = new System.Drawing.Point(0, 0);
            this.mainGroup.Name = "mainGroup";
            this.mainGroup.Size = new System.Drawing.Size(144, 136);
            this.mainGroup.TabIndex = 0;
            this.mainGroup.TabStop = false;
            this.mainGroup.Text = "CoreWall";
            // 
            // trashPerf
            // 
            this.trashPerf.AutoSize = true;
            this.trashPerf.Location = new System.Drawing.Point(16, 111);
            this.trashPerf.Name = "trashPerf";
            this.trashPerf.Size = new System.Drawing.Size(115, 17);
            this.trashPerf.TabIndex = 4;
            this.trashPerf.Text = "Trash Performance";
            this.trashPerf.UseVisualStyleBackColor = true;
            this.trashPerf.CheckedChanged += new System.EventHandler(this.TrashPerf_CheckedChanged);
            // 
            // lowPerf
            // 
            this.lowPerf.AutoSize = true;
            this.lowPerf.Checked = true;
            this.lowPerf.Location = new System.Drawing.Point(16, 88);
            this.lowPerf.Name = "lowPerf";
            this.lowPerf.Size = new System.Drawing.Size(108, 17);
            this.lowPerf.TabIndex = 3;
            this.lowPerf.TabStop = true;
            this.lowPerf.Text = "Low Performance";
            this.lowPerf.UseVisualStyleBackColor = true;
            this.lowPerf.CheckedChanged += new System.EventHandler(this.LowPerf_CheckedChanged);
            // 
            // mediumPerf
            // 
            this.mediumPerf.AutoSize = true;
            this.mediumPerf.Location = new System.Drawing.Point(16, 65);
            this.mediumPerf.Name = "mediumPerf";
            this.mediumPerf.Size = new System.Drawing.Size(125, 17);
            this.mediumPerf.TabIndex = 2;
            this.mediumPerf.Text = "Medium Performance";
            this.mediumPerf.UseVisualStyleBackColor = true;
            this.mediumPerf.CheckedChanged += new System.EventHandler(this.MediumPerf_CheckedChanged);
            // 
            // highPerf
            // 
            this.highPerf.AutoSize = true;
            this.highPerf.Location = new System.Drawing.Point(16, 42);
            this.highPerf.Name = "highPerf";
            this.highPerf.Size = new System.Drawing.Size(110, 17);
            this.highPerf.TabIndex = 1;
            this.highPerf.Text = "High Performance";
            this.highPerf.UseVisualStyleBackColor = true;
            this.highPerf.CheckedChanged += new System.EventHandler(this.HighPerf_CheckedChanged);
            // 
            // activeButton
            // 
            this.activeButton.AutoSize = true;
            this.activeButton.Location = new System.Drawing.Point(6, 19);
            this.activeButton.Name = "activeButton";
            this.activeButton.Size = new System.Drawing.Size(88, 17);
            this.activeButton.TabIndex = 0;
            this.activeButton.Text = "Active HACK";
            this.activeButton.UseVisualStyleBackColor = true;
            this.activeButton.CheckedChanged += new System.EventHandler(this.ActiveButton_CheckedChanged);
            // 
            // titleTimer
            // 
            this.titleTimer.Enabled = true;
            this.titleTimer.Interval = 1500;
            this.titleTimer.Tick += new System.EventHandler(this.TitleTimer_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(144, 136);
            this.Controls.Add(this.mainGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Opacity = 0.85D;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.mainGroup.ResumeLayout(false);
            this.mainGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mainGroup;
        private System.Windows.Forms.CheckBox activeButton;
        private System.Windows.Forms.RadioButton highPerf;
        private System.Windows.Forms.RadioButton trashPerf;
        private System.Windows.Forms.RadioButton lowPerf;
        private System.Windows.Forms.RadioButton mediumPerf;
        private System.Windows.Forms.Timer titleTimer;
    }
}
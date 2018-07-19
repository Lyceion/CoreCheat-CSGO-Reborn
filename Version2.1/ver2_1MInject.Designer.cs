namespace CoreCheat_Reborn.Version2._1
{
    partial class ver2_1MInject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ver2_1MInject));
            this.coreLogo = new System.Windows.Forms.PictureBox();
            this.descTXT = new MetroFramework.Controls.MetroLabel();
            this.loadingSpinner = new MetroFramework.Controls.MetroProgressSpinner();
            this.procControl = new System.Windows.Forms.Timer(this.components);
            this.injectTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.coreLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // coreLogo
            // 
            this.coreLogo.Image = global::CoreCheat_Reborn.Properties.Resources.cbjj6_3piu7_0;
            this.coreLogo.Location = new System.Drawing.Point(386, 129);
            this.coreLogo.Name = "coreLogo";
            this.coreLogo.Size = new System.Drawing.Size(35, 34);
            this.coreLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coreLogo.TabIndex = 14;
            this.coreLogo.TabStop = false;
            // 
            // descTXT
            // 
            this.descTXT.AutoSize = true;
            this.descTXT.FontSize = MetroFramework.MetroLabelSize.Small;
            this.descTXT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.descTXT.Location = new System.Drawing.Point(159, 60);
            this.descTXT.Name = "descTXT";
            this.descTXT.Size = new System.Drawing.Size(221, 90);
            this.descTXT.Style = MetroFramework.MetroColorStyle.Lime;
            this.descTXT.TabIndex = 13;
            this.descTXT.Text = "Wa, Wa, What did you do?\r\nWhy \"Manuel\" Type?\r\nAre you idiot? Oh!\r\nIf it\'s not an " +
    "emergancy situation, please\r\nselect the automatic one. Don\'t be shy bro.\r\nJust S" +
    "elect :))";
            this.descTXT.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.descTXT.UseStyleColors = true;
            // 
            // loadingSpinner
            // 
            this.loadingSpinner.Location = new System.Drawing.Point(13, 52);
            this.loadingSpinner.Maximum = 100;
            this.loadingSpinner.Name = "loadingSpinner";
            this.loadingSpinner.Size = new System.Drawing.Size(113, 113);
            this.loadingSpinner.Speed = 3F;
            this.loadingSpinner.Style = MetroFramework.MetroColorStyle.Lime;
            this.loadingSpinner.TabIndex = 12;
            this.loadingSpinner.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.loadingSpinner.UseSelectable = true;
            this.loadingSpinner.UseStyleColors = true;
            // 
            // procControl
            // 
            this.procControl.Tick += new System.EventHandler(this.procControl_Tick);
            // 
            // injectTimer
            // 
            this.injectTimer.Tick += new System.EventHandler(this.injectTimer_Tick);
            // 
            // ver2_1MInject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 170);
            this.ControlBox = false;
            this.Controls.Add(this.coreLogo);
            this.Controls.Add(this.descTXT);
            this.Controls.Add(this.loadingSpinner);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ver2_1MInject";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "Waiting For CSGO";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Inject_FormClosing);
            this.Load += new System.EventHandler(this.ver2MInject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.coreLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox coreLogo;
        private MetroFramework.Controls.MetroLabel descTXT;
        private MetroFramework.Controls.MetroProgressSpinner loadingSpinner;
        private System.Windows.Forms.Timer procControl;
        private System.Windows.Forms.Timer injectTimer;
    }
}
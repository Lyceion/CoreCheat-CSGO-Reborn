namespace CoreCheat_Reborn.Version0._3
{
    partial class ver0_3Launcher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ver0_3Launcher));
            this.manuelButton = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // manuelButton
            // 
            this.manuelButton.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.manuelButton.Location = new System.Drawing.Point(13, 75);
            this.manuelButton.Name = "manuelButton";
            this.manuelButton.Size = new System.Drawing.Size(241, 56);
            this.manuelButton.Style = MetroFramework.MetroColorStyle.Silver;
            this.manuelButton.TabIndex = 6;
            this.manuelButton.Text = "\"I Already Opened CS:GO Bitch!\r\nLet Me In Fast!!!!\" [Manuel Start]";
            this.manuelButton.UseSelectable = true;
            this.manuelButton.UseStyleColors = true;
            this.manuelButton.Click += new System.EventHandler(this.manuelButton_Click);
            // 
            // ver0_3Launcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 178);
            this.ControlBox = false;
            this.Controls.Add(this.manuelButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ver0_3Launcher";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "PANAROMA SPEC";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.ver0_3Launcher_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton manuelButton;
    }
}
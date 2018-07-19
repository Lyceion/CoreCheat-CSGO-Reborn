namespace CoreCheat_Reborn.Version1._5
{
    partial class ver1_5Launcher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ver1_5Launcher));
            this.manuelButton = new MetroFramework.Controls.MetroButton();
            this.autoButton = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // manuelButton
            // 
            this.manuelButton.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.manuelButton.Location = new System.Drawing.Point(15, 112);
            this.manuelButton.Name = "manuelButton";
            this.manuelButton.Size = new System.Drawing.Size(241, 56);
            this.manuelButton.Style = MetroFramework.MetroColorStyle.Yellow;
            this.manuelButton.TabIndex = 3;
            this.manuelButton.Text = "\"I Already Opened CS:GO Bitch!\r\nLet Me In Fast!!!!\" [Manuel Start]";
            this.manuelButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.manuelButton.UseSelectable = true;
            this.manuelButton.UseStyleColors = true;
            this.manuelButton.Click += new System.EventHandler(this.manuelButton_Click);
            // 
            // autoButton
            // 
            this.autoButton.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.autoButton.Location = new System.Drawing.Point(15, 59);
            this.autoButton.Name = "autoButton";
            this.autoButton.Size = new System.Drawing.Size(241, 39);
            this.autoButton.Style = MetroFramework.MetroColorStyle.Yellow;
            this.autoButton.TabIndex = 2;
            this.autoButton.Text = "\"Yes Sir! I Want To Use Your Cheat\r\nSafer Way :)\" [Automaticly Start]";
            this.autoButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.autoButton.UseSelectable = true;
            this.autoButton.UseStyleColors = true;
            this.autoButton.Click += new System.EventHandler(this.autoButton_Click);
            // 
            // ver1_5Launcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 175);
            this.ControlBox = false;
            this.Controls.Add(this.manuelButton);
            this.Controls.Add(this.autoButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ver1_5Launcher";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.Style = MetroFramework.MetroColorStyle.Yellow;
            this.Text = "CoreCheat Launcher";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Inject_FormClosing);
            this.Load += new System.EventHandler(this.ver1_5MInject_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton manuelButton;
        private MetroFramework.Controls.MetroButton autoButton;
    }
}
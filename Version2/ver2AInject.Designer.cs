namespace CoreCheat_Reborn.Version2
{
    partial class ver2AInject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ver2AInject));
            this.descTXT = new MetroFramework.Controls.MetroLabel();
            this.loadingSpinner = new MetroFramework.Controls.MetroProgressSpinner();
            this.procControl = new System.Windows.Forms.Timer(this.components);
            this.nowInject = new System.Windows.Forms.Timer(this.components);
            this.coreLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.coreLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // descTXT
            // 
            this.descTXT.AutoSize = true;
            this.descTXT.FontSize = MetroFramework.MetroLabelSize.Small;
            this.descTXT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.descTXT.Location = new System.Drawing.Point(157, 63);
            this.descTXT.Name = "descTXT";
            this.descTXT.Size = new System.Drawing.Size(228, 90);
            this.descTXT.TabIndex = 11;
            this.descTXT.Text = "CoreCheat CS:GO Is Loading Automaticly...\r\nCalm Down, Take A Tea And Wait For Loa" +
    "d.\r\nCheat Will Open CS:GO And Will Be Injected.\r\n\r\nHardInject By:\r\nSeptillioner " +
    "~ Cylops";
            this.descTXT.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.descTXT.UseStyleColors = true;
            // 
            // loadingSpinner
            // 
            this.loadingSpinner.Location = new System.Drawing.Point(21, 53);
            this.loadingSpinner.Maximum = 100;
            this.loadingSpinner.Name = "loadingSpinner";
            this.loadingSpinner.Size = new System.Drawing.Size(113, 113);
            this.loadingSpinner.Speed = 3F;
            this.loadingSpinner.TabIndex = 10;
            this.loadingSpinner.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.loadingSpinner.UseSelectable = true;
            this.loadingSpinner.UseStyleColors = true;
            // 
            // procControl
            // 
            this.procControl.Tick += new System.EventHandler(this.procControl_Tick);
            // 
            // nowInject
            // 
            this.nowInject.Tick += new System.EventHandler(this.nowInject_Tick);
            // 
            // coreLogo
            // 
            this.coreLogo.Image = global::CoreCheat_Reborn.Properties.Resources.cbjj6_3piu7_0;
            this.coreLogo.Location = new System.Drawing.Point(378, 132);
            this.coreLogo.Name = "coreLogo";
            this.coreLogo.Size = new System.Drawing.Size(35, 34);
            this.coreLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coreLogo.TabIndex = 12;
            this.coreLogo.TabStop = false;
            // 
            // ver2AInject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 170);
            this.ControlBox = false;
            this.Controls.Add(this.coreLogo);
            this.Controls.Add(this.descTXT);
            this.Controls.Add(this.loadingSpinner);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ver2AInject";
            this.Resizable = false;
            this.Text = "We Wil Inject Automaticly. Be Calm :)";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Inject_FormClosing);
            this.Load += new System.EventHandler(this.ver2AInject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.coreLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel descTXT;
        private MetroFramework.Controls.MetroProgressSpinner loadingSpinner;
        private System.Windows.Forms.Timer procControl;
        private System.Windows.Forms.Timer nowInject;
        private System.Windows.Forms.PictureBox coreLogo;
    }
}
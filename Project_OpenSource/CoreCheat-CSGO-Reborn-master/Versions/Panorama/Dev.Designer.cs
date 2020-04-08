namespace CoreCheat_Reborn.Versions.Panorama
{
    partial class Dev
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dev));
            this.statusTXT = new MetroFramework.Controls.MetroLabel();
            this.infogetter = new System.Windows.Forms.Timer(this.components);
            this.testBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // statusTXT
            // 
            this.statusTXT.AutoSize = true;
            this.statusTXT.Location = new System.Drawing.Point(23, 75);
            this.statusTXT.Name = "statusTXT";
            this.statusTXT.Size = new System.Drawing.Size(51, 19);
            this.statusTXT.Style = MetroFramework.MetroColorStyle.Red;
            this.statusTXT.TabIndex = 0;
            this.statusTXT.Text = "STATUS";
            this.statusTXT.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.statusTXT.UseStyleColors = true;
            // 
            // infogetter
            // 
            this.infogetter.Enabled = true;
            this.infogetter.Tick += new System.EventHandler(this.Infogetter_Tick);
            // 
            // testBtn
            // 
            this.testBtn.Location = new System.Drawing.Point(8, 599);
            this.testBtn.Name = "testBtn";
            this.testBtn.Size = new System.Drawing.Size(19, 23);
            this.testBtn.TabIndex = 1;
            this.testBtn.Text = "?";
            this.testBtn.UseVisualStyleBackColor = true;
            this.testBtn.Click += new System.EventHandler(this.TestBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 599);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(41, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "HIDE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Dev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 632);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.testBtn);
            this.Controls.Add(this.statusTXT);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Dev";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "[DEBUG] Info";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Dev_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel statusTXT;
        private System.Windows.Forms.Timer infogetter;
        private System.Windows.Forms.Button testBtn;
        private System.Windows.Forms.Button button1;
    }
}
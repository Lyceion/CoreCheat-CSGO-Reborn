namespace CoreCheat_Updater
{
    partial class Main
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.titleText = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.updateProgress = new MetroFramework.Controls.MetroProgressSpinner();
            this.seperator = new System.Windows.Forms.Panel();
            this.statusTXT = new System.Windows.Forms.Label();
            this.dataInfo = new System.Windows.Forms.Label();
            this.percent = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // titleText
            // 
            this.titleText.AutoSize = true;
            this.titleText.FontSize = MetroFramework.MetroLabelSize.Small;
            this.titleText.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.titleText.Location = new System.Drawing.Point(67, 54);
            this.titleText.Name = "titleText";
            this.titleText.Size = new System.Drawing.Size(141, 15);
            this.titleText.Style = MetroFramework.MetroColorStyle.White;
            this.titleText.TabIndex = 1;
            this.titleText.Text = "\"God Of The Externals!\"";
            this.titleText.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.titleText.UseStyleColors = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CoreCheat_Updater.Properties.Resources.updater1;
            this.pictureBox1.Location = new System.Drawing.Point(71, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 164);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // updateProgress
            // 
            this.updateProgress.Location = new System.Drawing.Point(97, 227);
            this.updateProgress.Maximum = 100;
            this.updateProgress.Name = "updateProgress";
            this.updateProgress.Size = new System.Drawing.Size(81, 79);
            this.updateProgress.Style = MetroFramework.MetroColorStyle.Red;
            this.updateProgress.TabIndex = 2;
            this.updateProgress.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.updateProgress.UseSelectable = true;
            this.updateProgress.UseStyleColors = true;
            this.updateProgress.Click += new System.EventHandler(this.UpdateProgress_Click);
            // 
            // seperator
            // 
            this.seperator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.seperator.Location = new System.Drawing.Point(-5, 207);
            this.seperator.Name = "seperator";
            this.seperator.Size = new System.Drawing.Size(283, 5);
            this.seperator.TabIndex = 3;
            // 
            // statusTXT
            // 
            this.statusTXT.AutoSize = true;
            this.statusTXT.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.statusTXT.Location = new System.Drawing.Point(23, 365);
            this.statusTXT.Name = "statusTXT";
            this.statusTXT.Size = new System.Drawing.Size(50, 13);
            this.statusTXT.TabIndex = 4;
            this.statusTXT.Text = "STATUS";
            // 
            // dataInfo
            // 
            this.dataInfo.AutoSize = true;
            this.dataInfo.ForeColor = System.Drawing.Color.Red;
            this.dataInfo.Location = new System.Drawing.Point(88, 309);
            this.dataInfo.Name = "dataInfo";
            this.dataInfo.Size = new System.Drawing.Size(24, 13);
            this.dataInfo.TabIndex = 5;
            this.dataInfo.Text = "info";
            this.dataInfo.Visible = false;
            // 
            // percent
            // 
            this.percent.AutoSize = true;
            this.percent.ForeColor = System.Drawing.Color.Thistle;
            this.percent.Location = new System.Drawing.Point(125, 259);
            this.percent.Name = "percent";
            this.percent.Size = new System.Drawing.Size(15, 13);
            this.percent.TabIndex = 6;
            this.percent.Text = "%";
            this.percent.Visible = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 399);
            this.ControlBox = false;
            this.Controls.Add(this.percent);
            this.Controls.Add(this.dataInfo);
            this.Controls.Add(this.statusTXT);
            this.Controls.Add(this.seperator);
            this.Controls.Add(this.updateProgress);
            this.Controls.Add(this.titleText);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "CoreCheat";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.Shown += new System.EventHandler(this.Main_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel titleText;
        private MetroFramework.Controls.MetroProgressSpinner updateProgress;
        private System.Windows.Forms.Panel seperator;
        private System.Windows.Forms.Label statusTXT;
        private System.Windows.Forms.Label dataInfo;
        private System.Windows.Forms.Label percent;
    }
}


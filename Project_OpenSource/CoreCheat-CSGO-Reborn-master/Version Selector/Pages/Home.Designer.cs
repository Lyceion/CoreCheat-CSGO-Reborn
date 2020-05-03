namespace CoreCheat_Reborn.Version_Selector.Pages
{
    partial class Home
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

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.titleTXT = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.subTitleTXT = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // titleTXT
            // 
            this.titleTXT.AutoSize = true;
            this.titleTXT.Font = new System.Drawing.Font("Segoe UI Light", 25F);
            this.titleTXT.ForeColor = System.Drawing.Color.White;
            this.titleTXT.Location = new System.Drawing.Point(153, 127);
            this.titleTXT.Name = "titleTXT";
            this.titleTXT.Size = new System.Drawing.Size(332, 46);
            this.titleTXT.TabIndex = 0;
            this.titleTXT.Text = "CoreCheat LSREMAKE";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CoreCheat_Reborn.Properties.Resources.CoreCheat;
            this.pictureBox1.Location = new System.Drawing.Point(277, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // subTitleTXT
            // 
            this.subTitleTXT.AutoSize = true;
            this.subTitleTXT.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.subTitleTXT.ForeColor = System.Drawing.Color.White;
            this.subTitleTXT.Location = new System.Drawing.Point(215, 173);
            this.subTitleTXT.Name = "subTitleTXT";
            this.subTitleTXT.Size = new System.Drawing.Size(216, 30);
            this.subTitleTXT.TabIndex = 2;
            this.subTitleTXT.Text = "\"God of the Externals...\"";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.Controls.Add(this.subTitleTXT);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.titleTXT);
            this.Name = "Home";
            this.Size = new System.Drawing.Size(634, 348);
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleTXT;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label subTitleTXT;
    }
}

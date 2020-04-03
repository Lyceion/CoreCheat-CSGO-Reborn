namespace CoreCheat_Reborn
{
    partial class vSelector
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(vSelector));
            this.startInfo = new MetroFramework.Controls.MetroLabel();
            this.mainTab = new MetroFramework.Controls.MetroTabControl();
            this.versPage = new System.Windows.Forms.TabPage();
            this.logoPic = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.launchBtn = new MetroFramework.Controls.MetroButton();
            this.versCombo = new MetroFramework.Controls.MetroComboBox();
            this.infoPage = new MetroFramework.Controls.MetroTabPage();
            this.infoTXT = new MetroFramework.Controls.MetroLabel();
            this.cylPic = new System.Windows.Forms.PictureBox();
            this.profilePicture = new System.Windows.Forms.PictureBox();
            this.versTimer = new System.Windows.Forms.Timer(this.components);
            this.mainTab.SuspendLayout();
            this.versPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPic)).BeginInit();
            this.infoPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cylPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // startInfo
            // 
            this.startInfo.AutoSize = true;
            this.startInfo.Location = new System.Drawing.Point(212, 60);
            this.startInfo.Name = "startInfo";
            this.startInfo.Size = new System.Drawing.Size(140, 19);
            this.startInfo.Style = MetroFramework.MetroColorStyle.Blue;
            this.startInfo.TabIndex = 0;
            this.startInfo.Text = "\"God of the externals.\"";
            this.startInfo.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.startInfo.UseStyleColors = true;
            // 
            // mainTab
            // 
            this.mainTab.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.mainTab.Controls.Add(this.versPage);
            this.mainTab.Controls.Add(this.infoPage);
            this.mainTab.Location = new System.Drawing.Point(13, 82);
            this.mainTab.Multiline = true;
            this.mainTab.Name = "mainTab";
            this.mainTab.SelectedIndex = 0;
            this.mainTab.Size = new System.Drawing.Size(550, 230);
            this.mainTab.Style = MetroFramework.MetroColorStyle.Blue;
            this.mainTab.TabIndex = 0;
            this.mainTab.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mainTab.UseSelectable = true;
            this.mainTab.UseStyleColors = true;
            // 
            // versPage
            // 
            this.versPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.versPage.Controls.Add(this.logoPic);
            this.versPage.Controls.Add(this.label1);
            this.versPage.Controls.Add(this.launchBtn);
            this.versPage.Controls.Add(this.versCombo);
            this.versPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.versPage.Location = new System.Drawing.Point(4, 41);
            this.versPage.Name = "versPage";
            this.versPage.Size = new System.Drawing.Size(542, 185);
            this.versPage.TabIndex = 0;
            this.versPage.Text = "Versions";
            // 
            // logoPic
            // 
            this.logoPic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.logoPic.Image = global::CoreCheat_Reborn.Properties.Resources.CoreCheatTransparent;
            this.logoPic.Location = new System.Drawing.Point(242, 59);
            this.logoPic.Name = "logoPic";
            this.logoPic.Size = new System.Drawing.Size(45, 45);
            this.logoPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPic.TabIndex = 10;
            this.logoPic.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(209, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "\"Wishing good game!\"";
            // 
            // launchBtn
            // 
            this.launchBtn.Enabled = false;
            this.launchBtn.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.launchBtn.Location = new System.Drawing.Point(22, 129);
            this.launchBtn.Name = "launchBtn";
            this.launchBtn.Size = new System.Drawing.Size(496, 50);
            this.launchBtn.Style = MetroFramework.MetroColorStyle.Blue;
            this.launchBtn.TabIndex = 6;
            this.launchBtn.Text = "LAUNCH!";
            this.launchBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.launchBtn.UseSelectable = true;
            this.launchBtn.UseStyleColors = true;
            this.launchBtn.Click += new System.EventHandler(this.launchBtn_Click);
            // 
            // versCombo
            // 
            this.versCombo.FontWeight = MetroFramework.MetroComboBoxWeight.Light;
            this.versCombo.FormattingEnabled = true;
            this.versCombo.ItemHeight = 23;
            this.versCombo.Location = new System.Drawing.Point(165, 20);
            this.versCombo.Name = "versCombo";
            this.versCombo.PromptText = "Select Your Version";
            this.versCombo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.versCombo.Size = new System.Drawing.Size(206, 29);
            this.versCombo.Style = MetroFramework.MetroColorStyle.Blue;
            this.versCombo.TabIndex = 5;
            this.versCombo.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.versCombo.UseSelectable = true;
            this.versCombo.UseStyleColors = true;
            // 
            // infoPage
            // 
            this.infoPage.Controls.Add(this.infoTXT);
            this.infoPage.Controls.Add(this.cylPic);
            this.infoPage.Controls.Add(this.profilePicture);
            this.infoPage.HorizontalScrollbarBarColor = false;
            this.infoPage.HorizontalScrollbarHighlightOnWheel = false;
            this.infoPage.HorizontalScrollbarSize = 10;
            this.infoPage.Location = new System.Drawing.Point(4, 41);
            this.infoPage.Name = "infoPage";
            this.infoPage.Size = new System.Drawing.Size(542, 185);
            this.infoPage.Style = MetroFramework.MetroColorStyle.Red;
            this.infoPage.TabIndex = 2;
            this.infoPage.Text = "   Info";
            this.infoPage.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.infoPage.VerticalScrollbarBarColor = true;
            this.infoPage.VerticalScrollbarHighlightOnWheel = false;
            this.infoPage.VerticalScrollbarSize = 10;
            // 
            // infoTXT
            // 
            this.infoTXT.AutoSize = true;
            this.infoTXT.FontSize = MetroFramework.MetroLabelSize.Small;
            this.infoTXT.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.infoTXT.Location = new System.Drawing.Point(90, 12);
            this.infoTXT.Name = "infoTXT";
            this.infoTXT.Size = new System.Drawing.Size(215, 60);
            this.infoTXT.TabIndex = 8;
            this.infoTXT.Text = "CoreCheat is a Public CS:GO Hack Project.\r\nREMADE by Lysep CORP\r\nWritten By:\r\nCyl" +
    "ops (Lyceion) || Lufzy";
            this.infoTXT.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.infoTXT.UseCustomForeColor = true;
            // 
            // cylPic
            // 
            this.cylPic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.cylPic.Image = global::CoreCheat_Reborn.Properties.Resources.Profile;
            this.cylPic.Location = new System.Drawing.Point(493, 146);
            this.cylPic.Name = "cylPic";
            this.cylPic.Size = new System.Drawing.Size(35, 35);
            this.cylPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cylPic.TabIndex = 4;
            this.cylPic.TabStop = false;
            this.cylPic.Click += new System.EventHandler(this.secretPic_Click);
            // 
            // profilePicture
            // 
            this.profilePicture.ImageLocation = "https://avatars3.githubusercontent.com/u/21990827";
            this.profilePicture.Location = new System.Drawing.Point(0, 0);
            this.profilePicture.Name = "profilePicture";
            this.profilePicture.Size = new System.Drawing.Size(84, 84);
            this.profilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilePicture.TabIndex = 2;
            this.profilePicture.TabStop = false;
            this.profilePicture.Click += new System.EventHandler(this.ProfilePicture_Click);
            // 
            // versTimer
            // 
            this.versTimer.Enabled = true;
            this.versTimer.Tick += new System.EventHandler(this.versTimer_Tick);
            // 
            // vSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 323);
            this.Controls.Add(this.mainTab);
            this.Controls.Add(this.startInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "vSelector";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Text = "CoreCheat LS REMAKE";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.vSelector_FormClosing);
            this.Load += new System.EventHandler(this.vSelector_Load);
            this.mainTab.ResumeLayout(false);
            this.versPage.ResumeLayout(false);
            this.versPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPic)).EndInit();
            this.infoPage.ResumeLayout(false);
            this.infoPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cylPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel startInfo;
        private MetroFramework.Controls.MetroTabControl mainTab;
        private System.Windows.Forms.TabPage versPage;
        private MetroFramework.Controls.MetroComboBox versCombo;
        private MetroFramework.Controls.MetroButton launchBtn;
        private System.Windows.Forms.Timer versTimer;
        private MetroFramework.Controls.MetroTabPage infoPage;
        private System.Windows.Forms.PictureBox profilePicture;
        private System.Windows.Forms.PictureBox cylPic;
        private MetroFramework.Controls.MetroLabel infoTXT;
        private System.Windows.Forms.PictureBox logoPic;
        private System.Windows.Forms.Label label1;
    }
}


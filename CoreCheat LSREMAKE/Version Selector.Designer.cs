namespace CoreCheat_LSREMAKE
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
            this.titlePic = new System.Windows.Forms.PictureBox();
            this.titleTXT = new System.Windows.Forms.Label();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.launchBtn = new MetroFramework.Controls.MetroButton();
            this.versCombo = new MetroFramework.Controls.MetroComboBox();
            this.versTXT = new MetroFramework.Controls.MetroLabel();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.annTXT = new System.Windows.Forms.RichTextBox();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.infoTXT = new MetroFramework.Controls.MetroLabel();
            this.profilePicture = new System.Windows.Forms.PictureBox();
            this.versTimer = new System.Windows.Forms.Timer(this.components);
            this.mainTab.SuspendLayout();
            this.versPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.titlePic)).BeginInit();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // startInfo
            // 
            this.startInfo.AutoSize = true;
            this.startInfo.Location = new System.Drawing.Point(20, 60);
            this.startInfo.Name = "startInfo";
            this.startInfo.Size = new System.Drawing.Size(338, 19);
            this.startInfo.Style = MetroFramework.MetroColorStyle.Blue;
            this.startInfo.TabIndex = 0;
            this.startInfo.Text = "CoreCheat Is Back. But REMEMBER! NO GUARANTEE!!!!";
            this.startInfo.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.startInfo.UseStyleColors = true;
            // 
            // mainTab
            // 
            this.mainTab.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.mainTab.Controls.Add(this.versPage);
            this.mainTab.Controls.Add(this.metroTabPage1);
            this.mainTab.Controls.Add(this.metroTabPage2);
            this.mainTab.Location = new System.Drawing.Point(23, 82);
            this.mainTab.Multiline = true;
            this.mainTab.Name = "mainTab";
            this.mainTab.SelectedIndex = 0;
            this.mainTab.Size = new System.Drawing.Size(540, 209);
            this.mainTab.Style = MetroFramework.MetroColorStyle.Blue;
            this.mainTab.TabIndex = 0;
            this.mainTab.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mainTab.UseSelectable = true;
            this.mainTab.UseStyleColors = true;
            // 
            // versPage
            // 
            this.versPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.versPage.Controls.Add(this.titlePic);
            this.versPage.Controls.Add(this.titleTXT);
            this.versPage.Controls.Add(this.metroLabel1);
            this.versPage.Controls.Add(this.launchBtn);
            this.versPage.Controls.Add(this.versCombo);
            this.versPage.Controls.Add(this.versTXT);
            this.versPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.versPage.Location = new System.Drawing.Point(4, 41);
            this.versPage.Name = "versPage";
            this.versPage.Size = new System.Drawing.Size(532, 164);
            this.versPage.TabIndex = 0;
            this.versPage.Text = "Versions";
            // 
            // titlePic
            // 
            this.titlePic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            //this.titlePic.Image = global::CoreCheat_LSREMAKE.Properties.Resources.CoreCheatLogo;
            this.titlePic.Location = new System.Drawing.Point(19, 11);
            this.titlePic.Name = "titlePic";
            this.titlePic.Size = new System.Drawing.Size(45, 45);
            this.titlePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.titlePic.TabIndex = 8;
            this.titlePic.TabStop = false;
            // 
            // titleTXT
            // 
            this.titleTXT.AutoSize = true;
            this.titleTXT.Font = new System.Drawing.Font("Segoe UI Black", 13F, System.Drawing.FontStyle.Bold);
            this.titleTXT.Location = new System.Drawing.Point(63, 7);
            this.titleTXT.Name = "titleTXT";
            this.titleTXT.Size = new System.Drawing.Size(62, 50);
            this.titleTXT.TabIndex = 9;
            this.titleTXT.Text = "Core\r\nCheat";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.metroLabel1.Location = new System.Drawing.Point(15, 63);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(215, 90);
            this.metroLabel1.TabIndex = 7;
            this.metroLabel1.Text = "CoreCheat is a Public CS:GO Hack Project.\r\nHack Project. BUT, this time, REMADE b" +
    "y\r\nLysep CORP. Team LOOOOL!\r\n\r\nWritten By:\r\nCylops (Lyceion)";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // launchBtn
            // 
            this.launchBtn.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.launchBtn.Location = new System.Drawing.Point(307, 88);
            this.launchBtn.Name = "launchBtn";
            this.launchBtn.Size = new System.Drawing.Size(206, 50);
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
            this.versCombo.FormattingEnabled = true;
            this.versCombo.ItemHeight = 23;
            this.versCombo.Location = new System.Drawing.Point(307, 41);
            this.versCombo.Name = "versCombo";
            this.versCombo.PromptText = "Select Your Version";
            this.versCombo.Size = new System.Drawing.Size(206, 29);
            this.versCombo.Style = MetroFramework.MetroColorStyle.Blue;
            this.versCombo.TabIndex = 5;
            this.versCombo.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.versCombo.UseSelectable = true;
            this.versCombo.UseStyleColors = true;
            // 
            // versTXT
            // 
            this.versTXT.AutoSize = true;
            this.versTXT.Location = new System.Drawing.Point(309, 18);
            this.versTXT.Name = "versTXT";
            this.versTXT.Size = new System.Drawing.Size(54, 19);
            this.versTXT.Style = MetroFramework.MetroColorStyle.Blue;
            this.versTXT.TabIndex = 4;
            this.versTXT.Text = "Version:";
            this.versTXT.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.versTXT.UseStyleColors = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.metroTabPage1.Controls.Add(this.annTXT);
            this.metroTabPage1.HorizontalScrollbarBarColor = false;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 41);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(532, 164);
            this.metroTabPage1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTabPage1.TabIndex = 1;
            this.metroTabPage1.Text = "Announcment";
            this.metroTabPage1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage1.UseCustomBackColor = true;
            this.metroTabPage1.VerticalScrollbarBarColor = false;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // annTXT
            // 
            this.annTXT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.annTXT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.annTXT.ForeColor = System.Drawing.Color.White;
            this.annTXT.Location = new System.Drawing.Point(3, 3);
            this.annTXT.Name = "annTXT";
            this.annTXT.ReadOnly = true;
            this.annTXT.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.annTXT.Size = new System.Drawing.Size(520, 140);
            this.annTXT.TabIndex = 4;
            this.annTXT.Text = "";
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.pictureBox2);
            this.metroTabPage2.Controls.Add(this.infoTXT);
            this.metroTabPage2.Controls.Add(this.profilePicture);
            this.metroTabPage2.HorizontalScrollbarBarColor = false;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 41);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(532, 164);
            this.metroTabPage2.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTabPage2.TabIndex = 2;
            this.metroTabPage2.Text = "   Info";
            this.metroTabPage2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            //this.pictureBox2.Image = global::CoreCheat_Reborn.Properties.Resources.Profile;
            this.pictureBox2.Location = new System.Drawing.Point(488, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.secretPic_Click);
            // 
            // infoTXT
            // 
            this.infoTXT.AutoSize = true;
            this.infoTXT.Location = new System.Drawing.Point(118, 0);
            this.infoTXT.Name = "infoTXT";
            this.infoTXT.Size = new System.Drawing.Size(287, 76);
            this.infoTXT.Style = MetroFramework.MetroColorStyle.Blue;
            this.infoTXT.TabIndex = 3;
            this.infoTXT.Text = "CoreCheat LS REMAKE\r\nProgrammed By Cylops.\r\nAll Versions Of Cheats Now In This Li" +
    "ttle Nigga! \r\nSelect Your Version And Start Cheating!";
            this.infoTXT.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.infoTXT.UseStyleColors = true;
            // 
            // profilePicture
            // 
            this.profilePicture.ImageLocation = "https://avatars3.githubusercontent.com/u/21990827";
            this.profilePicture.Location = new System.Drawing.Point(0, 0);
            this.profilePicture.Name = "profilePicture";
            this.profilePicture.Size = new System.Drawing.Size(112, 112);
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
            this.ClientSize = new System.Drawing.Size(573, 301);
            this.Controls.Add(this.mainTab);
            this.Controls.Add(this.startInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "vSelector";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Text = "CoreCheat LS REMAKE -|- Select Version";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.vSelector_FormClosing);
            this.Load += new System.EventHandler(this.vSelector_Load);
            this.mainTab.ResumeLayout(false);
            this.versPage.ResumeLayout(false);
            this.versPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.titlePic)).EndInit();
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel startInfo;
        private MetroFramework.Controls.MetroTabControl mainTab;
        private System.Windows.Forms.TabPage versPage;
        private MetroFramework.Controls.MetroComboBox versCombo;
        private MetroFramework.Controls.MetroLabel versTXT;
        private MetroFramework.Controls.MetroButton launchBtn;
        private System.Windows.Forms.Timer versTimer;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private System.Windows.Forms.PictureBox profilePicture;
        private MetroFramework.Controls.MetroLabel infoTXT;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.RichTextBox annTXT;
        private System.Windows.Forms.Label titleTXT;
        private System.Windows.Forms.PictureBox titlePic;
    }
}


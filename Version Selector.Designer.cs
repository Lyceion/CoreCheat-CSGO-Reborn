namespace CoreCheat_Reborn
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.startInfo = new MetroFramework.Controls.MetroLabel();
            this.mainTab = new MetroFramework.Controls.MetroTabControl();
            this.versPage = new System.Windows.Forms.TabPage();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.launchBtn = new MetroFramework.Controls.MetroButton();
            this.versCombo = new MetroFramework.Controls.MetroComboBox();
            this.versTXT = new MetroFramework.Controls.MetroLabel();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.annTXT = new System.Windows.Forms.RichTextBox();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.infoTXT = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.versTimer = new System.Windows.Forms.Timer(this.components);
            this.version2 = new MetroFramework.Controls.MetroLabel();
            this.version1_5 = new MetroFramework.Controls.MetroLabel();
            this.version0_5 = new MetroFramework.Controls.MetroLabel();
            this.verTXT = new MetroFramework.Controls.MetroLabel();
            this.verLink = new MetroFramework.Controls.MetroLabel();
            this.version2_1 = new MetroFramework.Controls.MetroLabel();
            this.verpanarom = new MetroFramework.Controls.MetroLabel();
            this.version2_5 = new MetroFramework.Controls.MetroLabel();
            this.mainTab.SuspendLayout();
            this.versPage.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // startInfo
            // 
            this.startInfo.AutoSize = true;
            this.startInfo.Location = new System.Drawing.Point(20, 60);
            this.startInfo.Name = "startInfo";
            this.startInfo.Size = new System.Drawing.Size(540, 19);
            this.startInfo.Style = MetroFramework.MetroColorStyle.Red;
            this.startInfo.TabIndex = 0;
            this.startInfo.Text = "I\'m Added All Versions Of Cheat. Because, Some People Had Problem About Cheat. En" +
    "joy!";
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
            this.mainTab.Style = MetroFramework.MetroColorStyle.Red;
            this.mainTab.TabIndex = 0;
            this.mainTab.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mainTab.UseSelectable = true;
            this.mainTab.UseStyleColors = true;
            // 
            // versPage
            // 
            this.versPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.versPage.Controls.Add(this.metroLabel6);
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
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.metroLabel6.Location = new System.Drawing.Point(15, 121);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(255, 30);
            this.metroLabel6.TabIndex = 8;
            this.metroLabel6.Text = "Memory Control: CylMem Elite --- Written In C++\r\nUndetected At The Moment...";
            this.metroLabel6.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel6.UseCustomForeColor = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.metroLabel1.Location = new System.Drawing.Point(15, 13);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(286, 105);
            this.metroLabel1.TabIndex = 7;
            this.metroLabel1.Text = resources.GetString("metroLabel1.Text");
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // launchBtn
            // 
            this.launchBtn.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.launchBtn.Location = new System.Drawing.Point(307, 88);
            this.launchBtn.Name = "launchBtn";
            this.launchBtn.Size = new System.Drawing.Size(206, 50);
            this.launchBtn.Style = MetroFramework.MetroColorStyle.Red;
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
            this.versCombo.Items.AddRange(new object[] {
            "Version Elite (Beta)",
            "Version 2.1 [Not Panaroma]",
            "Version 0.3 [PANAROMA]",
            "Version 2.0 [Not Panaroma]",
            "Version 1.5 [Not Panaroma]",
            "Version 0.5 [Not Panaroma]"});
            this.versCombo.Location = new System.Drawing.Point(307, 41);
            this.versCombo.Name = "versCombo";
            this.versCombo.PromptText = "Select Your Version";
            this.versCombo.Size = new System.Drawing.Size(206, 29);
            this.versCombo.Style = MetroFramework.MetroColorStyle.Red;
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
            this.versTXT.Style = MetroFramework.MetroColorStyle.Red;
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
            this.metroTabPage2.Controls.Add(this.pictureBox1);
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
            this.pictureBox2.Image = global::CoreCheat_Reborn.Properties.Resources.cbjj6_3piu7_0;
            this.pictureBox2.Location = new System.Drawing.Point(278, 92);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // infoTXT
            // 
            this.infoTXT.AutoSize = true;
            this.infoTXT.Location = new System.Drawing.Point(118, 0);
            this.infoTXT.Name = "infoTXT";
            this.infoTXT.Size = new System.Drawing.Size(365, 76);
            this.infoTXT.Style = MetroFramework.MetroColorStyle.Red;
            this.infoTXT.TabIndex = 3;
            this.infoTXT.Text = "CoreCheat Reborn [MAIN]\r\nProgrammed By Cylops! MemoryControl => CylMEM Elite+\r\nAl" +
    "l Versions Of Cheats Now In This Little Nigga! \r\nSelect Your Version And Start C" +
    "heating!";
            this.infoTXT.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.infoTXT.UseStyleColors = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CoreCheat_Reborn.Properties.Resources.Profile;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // versTimer
            // 
            this.versTimer.Enabled = true;
            this.versTimer.Tick += new System.EventHandler(this.versTimer_Tick);
            // 
            // version2
            // 
            this.version2.AutoSize = true;
            this.version2.FontSize = MetroFramework.MetroLabelSize.Small;
            this.version2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.version2.Location = new System.Drawing.Point(447, 40);
            this.version2.Name = "version2";
            this.version2.Size = new System.Drawing.Size(34, 15);
            this.version2.TabIndex = 9;
            this.version2.Text = "NULL";
            this.version2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.version2.UseCustomForeColor = true;
            this.version2.Visible = false;
            // 
            // version1_5
            // 
            this.version1_5.AutoSize = true;
            this.version1_5.FontSize = MetroFramework.MetroLabelSize.Small;
            this.version1_5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.version1_5.Location = new System.Drawing.Point(447, 26);
            this.version1_5.Name = "version1_5";
            this.version1_5.Size = new System.Drawing.Size(34, 15);
            this.version1_5.TabIndex = 10;
            this.version1_5.Text = "NULL";
            this.version1_5.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.version1_5.UseCustomForeColor = true;
            this.version1_5.Visible = false;
            // 
            // version0_5
            // 
            this.version0_5.AutoSize = true;
            this.version0_5.FontSize = MetroFramework.MetroLabelSize.Small;
            this.version0_5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.version0_5.Location = new System.Drawing.Point(447, 11);
            this.version0_5.Name = "version0_5";
            this.version0_5.Size = new System.Drawing.Size(34, 15);
            this.version0_5.TabIndex = 11;
            this.version0_5.Text = "NULL";
            this.version0_5.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.version0_5.UseCustomForeColor = true;
            this.version0_5.Visible = false;
            // 
            // verTXT
            // 
            this.verTXT.AutoSize = true;
            this.verTXT.FontSize = MetroFramework.MetroLabelSize.Small;
            this.verTXT.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.verTXT.Location = new System.Drawing.Point(283, 11);
            this.verTXT.Name = "verTXT";
            this.verTXT.Size = new System.Drawing.Size(34, 15);
            this.verTXT.TabIndex = 12;
            this.verTXT.Text = "NULL";
            this.verTXT.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.verTXT.UseCustomForeColor = true;
            this.verTXT.Visible = false;
            // 
            // verLink
            // 
            this.verLink.AutoSize = true;
            this.verLink.FontSize = MetroFramework.MetroLabelSize.Small;
            this.verLink.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.verLink.Location = new System.Drawing.Point(283, 40);
            this.verLink.Name = "verLink";
            this.verLink.Size = new System.Drawing.Size(34, 15);
            this.verLink.TabIndex = 13;
            this.verLink.Text = "NULL";
            this.verLink.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.verLink.UseCustomForeColor = true;
            this.verLink.Visible = false;
            // 
            // version2_1
            // 
            this.version2_1.AutoSize = true;
            this.version2_1.FontSize = MetroFramework.MetroLabelSize.Small;
            this.version2_1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.version2_1.Location = new System.Drawing.Point(487, 11);
            this.version2_1.Name = "version2_1";
            this.version2_1.Size = new System.Drawing.Size(34, 15);
            this.version2_1.TabIndex = 14;
            this.version2_1.Text = "NULL";
            this.version2_1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.version2_1.UseCustomForeColor = true;
            this.version2_1.Visible = false;
            // 
            // verpanarom
            // 
            this.verpanarom.AutoSize = true;
            this.verpanarom.FontSize = MetroFramework.MetroLabelSize.Small;
            this.verpanarom.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.verpanarom.Location = new System.Drawing.Point(487, 26);
            this.verpanarom.Name = "verpanarom";
            this.verpanarom.Size = new System.Drawing.Size(34, 15);
            this.verpanarom.TabIndex = 15;
            this.verpanarom.Text = "NULL";
            this.verpanarom.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.verpanarom.UseCustomForeColor = true;
            this.verpanarom.Visible = false;
            // 
            // version2_5
            // 
            this.version2_5.AutoSize = true;
            this.version2_5.FontSize = MetroFramework.MetroLabelSize.Small;
            this.version2_5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.version2_5.Location = new System.Drawing.Point(487, 40);
            this.version2_5.Name = "version2_5";
            this.version2_5.Size = new System.Drawing.Size(34, 15);
            this.version2_5.TabIndex = 16;
            this.version2_5.Text = "NULL";
            this.version2_5.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.version2_5.UseCustomForeColor = true;
            this.version2_5.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 308);
            this.Controls.Add(this.version2_5);
            this.Controls.Add(this.verpanarom);
            this.Controls.Add(this.version2_1);
            this.Controls.Add(this.verLink);
            this.Controls.Add(this.verTXT);
            this.Controls.Add(this.version0_5);
            this.Controls.Add(this.version1_5);
            this.Controls.Add(this.version2);
            this.Controls.Add(this.mainTab);
            this.Controls.Add(this.startInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Select Your Version";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Inject_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mainTab.ResumeLayout(false);
            this.versPage.ResumeLayout(false);
            this.versPage.PerformLayout();
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel version2;
        private MetroFramework.Controls.MetroLabel version1_5;
        private MetroFramework.Controls.MetroLabel version0_5;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel infoTXT;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MetroFramework.Controls.MetroLabel verTXT;
        private MetroFramework.Controls.MetroLabel verLink;
        private System.Windows.Forms.RichTextBox annTXT;
        private MetroFramework.Controls.MetroLabel version2_1;
        private MetroFramework.Controls.MetroLabel verpanarom;
        private MetroFramework.Controls.MetroLabel version2_5;
    }
}


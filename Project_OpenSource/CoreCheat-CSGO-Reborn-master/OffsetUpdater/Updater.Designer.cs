namespace CoreCheat_Reborn.OffsetUpdater
{
    partial class Updater
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
            this.statusSpinner = new MetroFramework.Controls.MetroProgressSpinner();
            this.SuspendLayout();
            // 
            // statusSpinner
            // 
            this.statusSpinner.Location = new System.Drawing.Point(154, 79);
            this.statusSpinner.Maximum = 100;
            this.statusSpinner.Name = "statusSpinner";
            this.statusSpinner.Size = new System.Drawing.Size(100, 100);
            this.statusSpinner.TabIndex = 0;
            this.statusSpinner.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.statusSpinner.UseSelectable = true;
            this.statusSpinner.UseStyleColors = true;
            // 
            // Updater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 280);
            this.Controls.Add(this.statusSpinner);
            this.Name = "Updater";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Text = "Getting Offsets";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroProgressSpinner statusSpinner;
    }
}
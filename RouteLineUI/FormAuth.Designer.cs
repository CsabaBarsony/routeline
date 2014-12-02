namespace RouteLineUI
{
    partial class FormAuth
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
            this.labelInstallCode = new System.Windows.Forms.Label();
            this.buttonCodeOk = new System.Windows.Forms.Button();
            this.textBoxInstallCode = new System.Windows.Forms.TextBox();
            this.labelLicenseCode = new System.Windows.Forms.Label();
            this.textBoxLicenseCode = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelInstallCode
            // 
            this.labelInstallCode.AutoSize = true;
            this.labelInstallCode.Location = new System.Drawing.Point(76, 70);
            this.labelInstallCode.Name = "labelInstallCode";
            this.labelInstallCode.Size = new System.Drawing.Size(78, 13);
            this.labelInstallCode.TabIndex = 0;
            this.labelInstallCode.Text = "Telepítési kód:";
            // 
            // buttonCodeOk
            // 
            this.buttonCodeOk.Location = new System.Drawing.Point(134, 147);
            this.buttonCodeOk.Name = "buttonCodeOk";
            this.buttonCodeOk.Size = new System.Drawing.Size(75, 23);
            this.buttonCodeOk.TabIndex = 1;
            this.buttonCodeOk.Text = "OK";
            this.buttonCodeOk.UseVisualStyleBackColor = true;
            this.buttonCodeOk.Click += new System.EventHandler(this.buttonCodeOk_Click);
            // 
            // textBoxInstallCode
            // 
            this.textBoxInstallCode.Location = new System.Drawing.Point(160, 67);
            this.textBoxInstallCode.Name = "textBoxInstallCode";
            this.textBoxInstallCode.Size = new System.Drawing.Size(100, 20);
            this.textBoxInstallCode.TabIndex = 2;
            this.textBoxInstallCode.Text = "?s77=mGV";
            // 
            // labelLicenseCode
            // 
            this.labelLicenseCode.AutoSize = true;
            this.labelLicenseCode.Location = new System.Drawing.Point(91, 107);
            this.labelLicenseCode.Name = "labelLicenseCode";
            this.labelLicenseCode.Size = new System.Drawing.Size(63, 13);
            this.labelLicenseCode.TabIndex = 3;
            this.labelLicenseCode.Text = "Licenc kód:";
            // 
            // textBoxLicenseCode
            // 
            this.textBoxLicenseCode.Location = new System.Drawing.Point(160, 104);
            this.textBoxLicenseCode.Name = "textBoxLicenseCode";
            this.textBoxLicenseCode.Size = new System.Drawing.Size(100, 20);
            this.textBoxLicenseCode.TabIndex = 4;
            this.textBoxLicenseCode.Text = "9790";
            // 
            // FormAuth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 246);
            this.Controls.Add(this.textBoxLicenseCode);
            this.Controls.Add(this.labelLicenseCode);
            this.Controls.Add(this.textBoxInstallCode);
            this.Controls.Add(this.buttonCodeOk);
            this.Controls.Add(this.labelInstallCode);
            this.Name = "FormAuth";
            this.Text = "Regisztrációs kulcs";
            this.Load += new System.EventHandler(this.FormAuth_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInstallCode;
        private System.Windows.Forms.Button buttonCodeOk;
        private System.Windows.Forms.TextBox textBoxInstallCode;
        private System.Windows.Forms.Label labelLicenseCode;
        private System.Windows.Forms.TextBox textBoxLicenseCode;
    }
}
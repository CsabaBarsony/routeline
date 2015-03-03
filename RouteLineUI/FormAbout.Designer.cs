namespace RouteLineUI
{
    partial class FormAbout
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
            this.labelInstantweb = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelInstantweb
            // 
            this.labelInstantweb.AutoSize = true;
            this.labelInstantweb.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelInstantweb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelInstantweb.Location = new System.Drawing.Point(87, 255);
            this.labelInstantweb.Name = "labelInstantweb";
            this.labelInstantweb.Size = new System.Drawing.Size(130, 60);
            this.labelInstantweb.TabIndex = 0;
            this.labelInstantweb.Text = "RouteLine\r\nVersion 1.0\r\n© 2014 Instantweb Kft.\r\nAll rights reserved.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = global::RouteLineUI.Properties.Resources.instantweb;
            this.pictureBox1.Image = global::RouteLineUI.Properties.Resources.instantweb;
            this.pictureBox1.InitialImage = global::RouteLineUI.Properties.Resources.instantweb;
            this.pictureBox1.Location = new System.Drawing.Point(90, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(204, 212);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(238)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(379, 324);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelInstantweb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormAbout";
            this.Text = "Névjegy";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInstantweb;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
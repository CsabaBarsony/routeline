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
            this.labelExplanation = new System.Windows.Forms.Label();
            this.buttonCodeOk = new System.Windows.Forms.Button();
            this.textBoxCode = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelExplanation
            // 
            this.labelExplanation.AutoSize = true;
            this.labelExplanation.Location = new System.Drawing.Point(81, 70);
            this.labelExplanation.Name = "labelExplanation";
            this.labelExplanation.Size = new System.Drawing.Size(196, 13);
            this.labelExplanation.TabIndex = 0;
            this.labelExplanation.Text = "Kérem, adja meg a regisztrációs kulcsot!";
            // 
            // buttonCodeOk
            // 
            this.buttonCodeOk.Location = new System.Drawing.Point(142, 146);
            this.buttonCodeOk.Name = "buttonCodeOk";
            this.buttonCodeOk.Size = new System.Drawing.Size(75, 23);
            this.buttonCodeOk.TabIndex = 1;
            this.buttonCodeOk.Text = "OK";
            this.buttonCodeOk.UseVisualStyleBackColor = true;
            this.buttonCodeOk.Click += new System.EventHandler(this.buttonCodeOk_Click);
            // 
            // textBoxCode
            // 
            this.textBoxCode.Location = new System.Drawing.Point(129, 110);
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.Size = new System.Drawing.Size(100, 20);
            this.textBoxCode.TabIndex = 2;
            // 
            // FormAuth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 246);
            this.Controls.Add(this.textBoxCode);
            this.Controls.Add(this.buttonCodeOk);
            this.Controls.Add(this.labelExplanation);
            this.Name = "FormAuth";
            this.Text = "Regisztrációs kulcs";
            this.Load += new System.EventHandler(this.FormAuth_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelExplanation;
        private System.Windows.Forms.Button buttonCodeOk;
        private System.Windows.Forms.TextBox textBoxCode;
    }
}
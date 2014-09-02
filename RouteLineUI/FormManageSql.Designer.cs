namespace RouteLineUI
{
    partial class FormManageSql
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
            this.listBoxNameList = new System.Windows.Forms.ListBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSql = new System.Windows.Forms.TextBox();
            this.buttonNewCommand = new System.Windows.Forms.Button();
            this.buttonSaveCommand = new System.Windows.Forms.Button();
            this.buttonDeleteCommand = new System.Windows.Forms.Button();
            this.labelNameList = new System.Windows.Forms.Label();
            this.labelCommandName = new System.Windows.Forms.Label();
            this.labelCommandSql = new System.Windows.Forms.Label();
            this.buttonCommandLoad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxNameList
            // 
            this.listBoxNameList.FormattingEnabled = true;
            this.listBoxNameList.Location = new System.Drawing.Point(12, 25);
            this.listBoxNameList.Name = "listBoxNameList";
            this.listBoxNameList.Size = new System.Drawing.Size(237, 134);
            this.listBoxNameList.TabIndex = 0;
            this.listBoxNameList.SelectedIndexChanged += new System.EventHandler(this.listBoxNameList_SelectedIndexChanged);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(12, 178);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(237, 20);
            this.textBoxName.TabIndex = 1;
            // 
            // textBoxSql
            // 
            this.textBoxSql.Location = new System.Drawing.Point(12, 217);
            this.textBoxSql.Multiline = true;
            this.textBoxSql.Name = "textBoxSql";
            this.textBoxSql.Size = new System.Drawing.Size(237, 90);
            this.textBoxSql.TabIndex = 2;
            // 
            // buttonNewCommand
            // 
            this.buttonNewCommand.Location = new System.Drawing.Point(255, 54);
            this.buttonNewCommand.Name = "buttonNewCommand";
            this.buttonNewCommand.Size = new System.Drawing.Size(75, 23);
            this.buttonNewCommand.TabIndex = 3;
            this.buttonNewCommand.Text = "Új";
            this.buttonNewCommand.UseVisualStyleBackColor = true;
            this.buttonNewCommand.Click += new System.EventHandler(this.buttonNewCommand_Click);
            // 
            // buttonSaveCommand
            // 
            this.buttonSaveCommand.Location = new System.Drawing.Point(255, 83);
            this.buttonSaveCommand.Name = "buttonSaveCommand";
            this.buttonSaveCommand.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveCommand.TabIndex = 4;
            this.buttonSaveCommand.Text = "Mentés";
            this.buttonSaveCommand.UseVisualStyleBackColor = true;
            this.buttonSaveCommand.Click += new System.EventHandler(this.buttonSaveCommand_Click);
            // 
            // buttonDeleteCommand
            // 
            this.buttonDeleteCommand.Location = new System.Drawing.Point(255, 112);
            this.buttonDeleteCommand.Name = "buttonDeleteCommand";
            this.buttonDeleteCommand.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteCommand.TabIndex = 5;
            this.buttonDeleteCommand.Text = "Törlés";
            this.buttonDeleteCommand.UseVisualStyleBackColor = true;
            this.buttonDeleteCommand.Click += new System.EventHandler(this.buttonDeleteCommand_Click);
            // 
            // labelNameList
            // 
            this.labelNameList.AutoSize = true;
            this.labelNameList.Location = new System.Drawing.Point(12, 9);
            this.labelNameList.Name = "labelNameList";
            this.labelNameList.Size = new System.Drawing.Size(77, 13);
            this.labelNameList.TabIndex = 6;
            this.labelNameList.Text = "Lekérdezések:";
            // 
            // labelCommandName
            // 
            this.labelCommandName.AutoSize = true;
            this.labelCommandName.Location = new System.Drawing.Point(12, 162);
            this.labelCommandName.Name = "labelCommandName";
            this.labelCommandName.Size = new System.Drawing.Size(30, 13);
            this.labelCommandName.TabIndex = 7;
            this.labelCommandName.Text = "Név:";
            // 
            // labelCommandSql
            // 
            this.labelCommandSql.AutoSize = true;
            this.labelCommandSql.Location = new System.Drawing.Point(12, 201);
            this.labelCommandSql.Name = "labelCommandSql";
            this.labelCommandSql.Size = new System.Drawing.Size(31, 13);
            this.labelCommandSql.TabIndex = 8;
            this.labelCommandSql.Text = "SQL:";
            // 
            // buttonCommandLoad
            // 
            this.buttonCommandLoad.Location = new System.Drawing.Point(255, 25);
            this.buttonCommandLoad.Name = "buttonCommandLoad";
            this.buttonCommandLoad.Size = new System.Drawing.Size(75, 23);
            this.buttonCommandLoad.TabIndex = 9;
            this.buttonCommandLoad.Text = "Betöltés";
            this.buttonCommandLoad.UseVisualStyleBackColor = true;
            // 
            // FormManageSql
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 327);
            this.Controls.Add(this.buttonCommandLoad);
            this.Controls.Add(this.labelCommandSql);
            this.Controls.Add(this.labelCommandName);
            this.Controls.Add(this.labelNameList);
            this.Controls.Add(this.buttonDeleteCommand);
            this.Controls.Add(this.buttonSaveCommand);
            this.Controls.Add(this.buttonNewCommand);
            this.Controls.Add(this.textBoxSql);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.listBoxNameList);
            this.Name = "FormManageSql";
            this.Text = "SQL lekérdezés kezelése";
            this.Load += new System.EventHandler(this.FormManageSql_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxNameList;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSql;
        private System.Windows.Forms.Button buttonNewCommand;
        private System.Windows.Forms.Button buttonSaveCommand;
        private System.Windows.Forms.Button buttonDeleteCommand;
        private System.Windows.Forms.Label labelNameList;
        private System.Windows.Forms.Label labelCommandName;
        private System.Windows.Forms.Label labelCommandSql;
        private System.Windows.Forms.Button buttonCommandLoad;


    }
}
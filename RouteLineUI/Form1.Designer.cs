namespace RouteLineUI
{
    partial class FormMain
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
            this.buttonSqlOk = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.groupBoxDisplayType = new System.Windows.Forms.GroupBox();
            this.radioButtonHeatMap = new System.Windows.Forms.RadioButton();
            this.radioButtonLine = new System.Windows.Forms.RadioButton();
            this.radioButtonMarker = new System.Windows.Forms.RadioButton();
            this.myMap = new GMap.NET.WindowsForms.GMapControl();
            this.groupBoxQueries = new System.Windows.Forms.GroupBox();
            this.buttonDeleteQuery = new System.Windows.Forms.Button();
            this.buttonLoadQuery = new System.Windows.Forms.Button();
            this.buttonSaveQuery = new System.Windows.Forms.Button();
            this.checkedListBoxQueries = new System.Windows.Forms.CheckedListBox();
            this.panelSelectedQuery = new System.Windows.Forms.Panel();
            this.buttonNewQueryCancel = new System.Windows.Forms.Button();
            this.buttonNewQueryOk = new System.Windows.Forms.Button();
            this.textBoxQueryName = new System.Windows.Forms.TextBox();
            this.labelQueryName = new System.Windows.Forms.Label();
            this.labelQueryDescription = new System.Windows.Forms.Label();
            this.textBoxQueryDescription = new System.Windows.Forms.TextBox();
            this.textBoxQuerySql = new System.Windows.Forms.TextBox();
            this.labelQuerySql = new System.Windows.Forms.Label();
            this.buttonAddQuery = new System.Windows.Forms.Button();
            this.buttonRemoveQuery = new System.Windows.Forms.Button();
            this.openFileDialogXml = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogXml = new System.Windows.Forms.SaveFileDialog();
            this.groupBoxDisplayType.SuspendLayout();
            this.groupBoxQueries.SuspendLayout();
            this.panelSelectedQuery.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSqlOk
            // 
            this.buttonSqlOk.Location = new System.Drawing.Point(12, 12);
            this.buttonSqlOk.Name = "buttonSqlOk";
            this.buttonSqlOk.Size = new System.Drawing.Size(75, 23);
            this.buttonSqlOk.TabIndex = 2;
            this.buttonSqlOk.Text = "OK";
            this.buttonSqlOk.UseVisualStyleBackColor = true;
            this.buttonSqlOk.Click += new System.EventHandler(this.buttonSqlOk_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(93, 12);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 3;
            this.buttonClear.Text = "Törlés";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // groupBoxDisplayType
            // 
            this.groupBoxDisplayType.Controls.Add(this.radioButtonHeatMap);
            this.groupBoxDisplayType.Controls.Add(this.radioButtonLine);
            this.groupBoxDisplayType.Controls.Add(this.radioButtonMarker);
            this.groupBoxDisplayType.Location = new System.Drawing.Point(12, 41);
            this.groupBoxDisplayType.Name = "groupBoxDisplayType";
            this.groupBoxDisplayType.Size = new System.Drawing.Size(250, 35);
            this.groupBoxDisplayType.TabIndex = 4;
            this.groupBoxDisplayType.TabStop = false;
            // 
            // radioButtonHeatMap
            // 
            this.radioButtonHeatMap.AutoSize = true;
            this.radioButtonHeatMap.Enabled = false;
            this.radioButtonHeatMap.Location = new System.Drawing.Point(128, 10);
            this.radioButtonHeatMap.Name = "radioButtonHeatMap";
            this.radioButtonHeatMap.Size = new System.Drawing.Size(68, 17);
            this.radioButtonHeatMap.TabIndex = 2;
            this.radioButtonHeatMap.Text = "Heatmap";
            this.radioButtonHeatMap.UseVisualStyleBackColor = true;
            // 
            // radioButtonLine
            // 
            this.radioButtonLine.AutoSize = true;
            this.radioButtonLine.Location = new System.Drawing.Point(70, 10);
            this.radioButtonLine.Name = "radioButtonLine";
            this.radioButtonLine.Size = new System.Drawing.Size(52, 17);
            this.radioButtonLine.TabIndex = 1;
            this.radioButtonLine.Text = "Vonal";
            this.radioButtonLine.UseVisualStyleBackColor = true;
            // 
            // radioButtonMarker
            // 
            this.radioButtonMarker.AutoSize = true;
            this.radioButtonMarker.Checked = true;
            this.radioButtonMarker.Location = new System.Drawing.Point(6, 10);
            this.radioButtonMarker.Name = "radioButtonMarker";
            this.radioButtonMarker.Size = new System.Drawing.Size(58, 17);
            this.radioButtonMarker.TabIndex = 0;
            this.radioButtonMarker.TabStop = true;
            this.radioButtonMarker.Text = "Marker";
            this.radioButtonMarker.UseVisualStyleBackColor = true;
            // 
            // myMap
            // 
            this.myMap.Bearing = 0F;
            this.myMap.CanDragMap = true;
            this.myMap.EmptyTileColor = System.Drawing.Color.Navy;
            this.myMap.GrayScaleMode = false;
            this.myMap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.myMap.LevelsKeepInMemmory = 5;
            this.myMap.Location = new System.Drawing.Point(268, 12);
            this.myMap.MarkersEnabled = true;
            this.myMap.MaxZoom = 18;
            this.myMap.MinZoom = 2;
            this.myMap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.myMap.Name = "myMap";
            this.myMap.NegativeMode = false;
            this.myMap.PolygonsEnabled = true;
            this.myMap.RetryLoadTile = 0;
            this.myMap.RoutesEnabled = true;
            this.myMap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.myMap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.myMap.ShowTileGridLines = false;
            this.myMap.Size = new System.Drawing.Size(703, 591);
            this.myMap.TabIndex = 0;
            this.myMap.Zoom = 12D;
            // 
            // groupBoxQueries
            // 
            this.groupBoxQueries.Controls.Add(this.buttonDeleteQuery);
            this.groupBoxQueries.Controls.Add(this.buttonLoadQuery);
            this.groupBoxQueries.Controls.Add(this.buttonSaveQuery);
            this.groupBoxQueries.Controls.Add(this.checkedListBoxQueries);
            this.groupBoxQueries.Controls.Add(this.panelSelectedQuery);
            this.groupBoxQueries.Controls.Add(this.buttonAddQuery);
            this.groupBoxQueries.Controls.Add(this.buttonRemoveQuery);
            this.groupBoxQueries.Location = new System.Drawing.Point(12, 82);
            this.groupBoxQueries.Name = "groupBoxQueries";
            this.groupBoxQueries.Size = new System.Drawing.Size(250, 432);
            this.groupBoxQueries.TabIndex = 6;
            this.groupBoxQueries.TabStop = false;
            this.groupBoxQueries.Text = "Lekérdezések";
            // 
            // buttonDeleteQuery
            // 
            this.buttonDeleteQuery.Location = new System.Drawing.Point(168, 135);
            this.buttonDeleteQuery.Name = "buttonDeleteQuery";
            this.buttonDeleteQuery.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteQuery.TabIndex = 16;
            this.buttonDeleteQuery.Text = "Töröl";
            this.buttonDeleteQuery.UseVisualStyleBackColor = true;
            this.buttonDeleteQuery.Click += new System.EventHandler(this.buttonDeleteQuery_Click);
            // 
            // buttonLoadQuery
            // 
            this.buttonLoadQuery.Location = new System.Drawing.Point(168, 106);
            this.buttonLoadQuery.Name = "buttonLoadQuery";
            this.buttonLoadQuery.Size = new System.Drawing.Size(75, 23);
            this.buttonLoadQuery.TabIndex = 15;
            this.buttonLoadQuery.Text = "Betölt";
            this.buttonLoadQuery.UseVisualStyleBackColor = true;
            this.buttonLoadQuery.Click += new System.EventHandler(this.buttonLoadQuery_Click);
            // 
            // buttonSaveQuery
            // 
            this.buttonSaveQuery.Location = new System.Drawing.Point(168, 77);
            this.buttonSaveQuery.Name = "buttonSaveQuery";
            this.buttonSaveQuery.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveQuery.TabIndex = 14;
            this.buttonSaveQuery.Text = "Ment";
            this.buttonSaveQuery.UseVisualStyleBackColor = true;
            this.buttonSaveQuery.Click += new System.EventHandler(this.buttonSaveQuery_Click);
            // 
            // checkedListBoxQueries
            // 
            this.checkedListBoxQueries.FormattingEnabled = true;
            this.checkedListBoxQueries.Location = new System.Drawing.Point(7, 19);
            this.checkedListBoxQueries.Name = "checkedListBoxQueries";
            this.checkedListBoxQueries.Size = new System.Drawing.Size(155, 169);
            this.checkedListBoxQueries.TabIndex = 13;
            this.checkedListBoxQueries.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxQueries_SelectedIndexChanged);
            // 
            // panelSelectedQuery
            // 
            this.panelSelectedQuery.Controls.Add(this.buttonNewQueryCancel);
            this.panelSelectedQuery.Controls.Add(this.buttonNewQueryOk);
            this.panelSelectedQuery.Controls.Add(this.textBoxQueryName);
            this.panelSelectedQuery.Controls.Add(this.labelQueryName);
            this.panelSelectedQuery.Controls.Add(this.labelQueryDescription);
            this.panelSelectedQuery.Controls.Add(this.textBoxQueryDescription);
            this.panelSelectedQuery.Controls.Add(this.textBoxQuerySql);
            this.panelSelectedQuery.Controls.Add(this.labelQuerySql);
            this.panelSelectedQuery.Location = new System.Drawing.Point(7, 194);
            this.panelSelectedQuery.Name = "panelSelectedQuery";
            this.panelSelectedQuery.Size = new System.Drawing.Size(237, 232);
            this.panelSelectedQuery.TabIndex = 11;
            this.panelSelectedQuery.Visible = false;
            // 
            // buttonNewQueryCancel
            // 
            this.buttonNewQueryCancel.Location = new System.Drawing.Point(80, 208);
            this.buttonNewQueryCancel.Name = "buttonNewQueryCancel";
            this.buttonNewQueryCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonNewQueryCancel.TabIndex = 8;
            this.buttonNewQueryCancel.Text = "Mégse";
            this.buttonNewQueryCancel.UseVisualStyleBackColor = true;
            this.buttonNewQueryCancel.Click += new System.EventHandler(this.buttonNewQueryCancel_Click);
            // 
            // buttonNewQueryOk
            // 
            this.buttonNewQueryOk.Location = new System.Drawing.Point(-1, 208);
            this.buttonNewQueryOk.Name = "buttonNewQueryOk";
            this.buttonNewQueryOk.Size = new System.Drawing.Size(75, 23);
            this.buttonNewQueryOk.TabIndex = 7;
            this.buttonNewQueryOk.Text = "OK";
            this.buttonNewQueryOk.UseVisualStyleBackColor = true;
            this.buttonNewQueryOk.Click += new System.EventHandler(this.buttonNewQueryOk_Click);
            // 
            // textBoxQueryName
            // 
            this.textBoxQueryName.Location = new System.Drawing.Point(0, 16);
            this.textBoxQueryName.Name = "textBoxQueryName";
            this.textBoxQueryName.Size = new System.Drawing.Size(237, 20);
            this.textBoxQueryName.TabIndex = 4;
            // 
            // labelQueryName
            // 
            this.labelQueryName.AutoSize = true;
            this.labelQueryName.Location = new System.Drawing.Point(3, 0);
            this.labelQueryName.Name = "labelQueryName";
            this.labelQueryName.Size = new System.Drawing.Size(30, 13);
            this.labelQueryName.TabIndex = 1;
            this.labelQueryName.Text = "Név:";
            // 
            // labelQueryDescription
            // 
            this.labelQueryDescription.AutoSize = true;
            this.labelQueryDescription.Location = new System.Drawing.Point(3, 39);
            this.labelQueryDescription.Name = "labelQueryDescription";
            this.labelQueryDescription.Size = new System.Drawing.Size(40, 13);
            this.labelQueryDescription.TabIndex = 2;
            this.labelQueryDescription.Text = "Leírás:";
            // 
            // textBoxQueryDescription
            // 
            this.textBoxQueryDescription.Location = new System.Drawing.Point(0, 55);
            this.textBoxQueryDescription.Name = "textBoxQueryDescription";
            this.textBoxQueryDescription.Size = new System.Drawing.Size(237, 20);
            this.textBoxQueryDescription.TabIndex = 5;
            // 
            // textBoxQuerySql
            // 
            this.textBoxQuerySql.Location = new System.Drawing.Point(0, 94);
            this.textBoxQuerySql.Multiline = true;
            this.textBoxQuerySql.Name = "textBoxQuerySql";
            this.textBoxQuerySql.Size = new System.Drawing.Size(237, 108);
            this.textBoxQuerySql.TabIndex = 6;
            // 
            // labelQuerySql
            // 
            this.labelQuerySql.AutoSize = true;
            this.labelQuerySql.Location = new System.Drawing.Point(3, 78);
            this.labelQuerySql.Name = "labelQuerySql";
            this.labelQuerySql.Size = new System.Drawing.Size(31, 13);
            this.labelQuerySql.TabIndex = 3;
            this.labelQuerySql.Text = "SQL:";
            // 
            // buttonAddQuery
            // 
            this.buttonAddQuery.Location = new System.Drawing.Point(168, 19);
            this.buttonAddQuery.Name = "buttonAddQuery";
            this.buttonAddQuery.Size = new System.Drawing.Size(75, 23);
            this.buttonAddQuery.TabIndex = 8;
            this.buttonAddQuery.Text = "Hozzáad";
            this.buttonAddQuery.UseVisualStyleBackColor = true;
            this.buttonAddQuery.Click += new System.EventHandler(this.buttonAddQuery_Click);
            // 
            // buttonRemoveQuery
            // 
            this.buttonRemoveQuery.Location = new System.Drawing.Point(168, 48);
            this.buttonRemoveQuery.Name = "buttonRemoveQuery";
            this.buttonRemoveQuery.Size = new System.Drawing.Size(75, 23);
            this.buttonRemoveQuery.TabIndex = 9;
            this.buttonRemoveQuery.Text = "Elvesz";
            this.buttonRemoveQuery.UseVisualStyleBackColor = true;
            this.buttonRemoveQuery.Click += new System.EventHandler(this.buttonRemoveQuery_Click);
            // 
            // saveFileDialogXml
            // 
            this.saveFileDialogXml.Filter = "XML Fájl (*.xml)|*.xml";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 615);
            this.Controls.Add(this.groupBoxQueries);
            this.Controls.Add(this.groupBoxDisplayType);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonSqlOk);
            this.Controls.Add(this.myMap);
            this.Name = "FormMain";
            this.Text = "RouteLine";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxDisplayType.ResumeLayout(false);
            this.groupBoxDisplayType.PerformLayout();
            this.groupBoxQueries.ResumeLayout(false);
            this.panelSelectedQuery.ResumeLayout(false);
            this.panelSelectedQuery.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl myMap;
        private System.Windows.Forms.Button buttonSqlOk;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.GroupBox groupBoxDisplayType;
        private System.Windows.Forms.RadioButton radioButtonHeatMap;
        private System.Windows.Forms.RadioButton radioButtonLine;
        private System.Windows.Forms.RadioButton radioButtonMarker;
        private System.Windows.Forms.GroupBox groupBoxQueries;
        private System.Windows.Forms.TextBox textBoxQuerySql;
        private System.Windows.Forms.TextBox textBoxQueryDescription;
        private System.Windows.Forms.TextBox textBoxQueryName;
        private System.Windows.Forms.Label labelQuerySql;
        private System.Windows.Forms.Label labelQueryDescription;
        private System.Windows.Forms.Label labelQueryName;
        private System.Windows.Forms.Button buttonRemoveQuery;
        private System.Windows.Forms.Button buttonAddQuery;
        private System.Windows.Forms.Panel panelSelectedQuery;
        private System.Windows.Forms.OpenFileDialog openFileDialogXml;
        private System.Windows.Forms.CheckedListBox checkedListBoxQueries;
        private System.Windows.Forms.Button buttonDeleteQuery;
        private System.Windows.Forms.Button buttonLoadQuery;
        private System.Windows.Forms.Button buttonSaveQuery;
        private System.Windows.Forms.Button buttonNewQueryCancel;
        private System.Windows.Forms.Button buttonNewQueryOk;
        private System.Windows.Forms.SaveFileDialog saveFileDialogXml;

    }
}


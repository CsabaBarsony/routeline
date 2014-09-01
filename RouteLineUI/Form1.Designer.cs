namespace RouteLineUI
{
    partial class Form1
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
            this.textBoxSql = new System.Windows.Forms.TextBox();
            this.buttonSqlOk = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.groupBoxDisplayType = new System.Windows.Forms.GroupBox();
            this.radioButtonHeatMap = new System.Windows.Forms.RadioButton();
            this.radioButtonLine = new System.Windows.Forms.RadioButton();
            this.radioButtonMarker = new System.Windows.Forms.RadioButton();
            this.myMap = new GMap.NET.WindowsForms.GMapControl();
            this.groupBoxDisplayType.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxSql
            // 
            this.textBoxSql.Location = new System.Drawing.Point(12, 12);
            this.textBoxSql.Multiline = true;
            this.textBoxSql.Name = "textBoxSql";
            this.textBoxSql.Size = new System.Drawing.Size(221, 81);
            this.textBoxSql.TabIndex = 1;
            this.textBoxSql.Text = "select * from taxi_locations where id > 100 and id < 300";
            // 
            // buttonSqlOk
            // 
            this.buttonSqlOk.Location = new System.Drawing.Point(12, 99);
            this.buttonSqlOk.Name = "buttonSqlOk";
            this.buttonSqlOk.Size = new System.Drawing.Size(75, 23);
            this.buttonSqlOk.TabIndex = 2;
            this.buttonSqlOk.Text = "OK";
            this.buttonSqlOk.UseVisualStyleBackColor = true;
            this.buttonSqlOk.Click += new System.EventHandler(this.buttonSqlOk_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(94, 98);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 3;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // groupBoxDisplayType
            // 
            this.groupBoxDisplayType.Controls.Add(this.radioButtonHeatMap);
            this.groupBoxDisplayType.Controls.Add(this.radioButtonLine);
            this.groupBoxDisplayType.Controls.Add(this.radioButtonMarker);
            this.groupBoxDisplayType.Location = new System.Drawing.Point(12, 128);
            this.groupBoxDisplayType.Name = "groupBoxDisplayType";
            this.groupBoxDisplayType.Size = new System.Drawing.Size(221, 101);
            this.groupBoxDisplayType.TabIndex = 4;
            this.groupBoxDisplayType.TabStop = false;
            // 
            // radioButtonHeatMap
            // 
            this.radioButtonHeatMap.AutoSize = true;
            this.radioButtonHeatMap.Enabled = false;
            this.radioButtonHeatMap.Location = new System.Drawing.Point(7, 68);
            this.radioButtonHeatMap.Name = "radioButtonHeatMap";
            this.radioButtonHeatMap.Size = new System.Drawing.Size(68, 17);
            this.radioButtonHeatMap.TabIndex = 2;
            this.radioButtonHeatMap.Text = "Heatmap";
            this.radioButtonHeatMap.UseVisualStyleBackColor = true;
            // 
            // radioButtonLine
            // 
            this.radioButtonLine.AutoSize = true;
            this.radioButtonLine.Location = new System.Drawing.Point(7, 44);
            this.radioButtonLine.Name = "radioButtonLine";
            this.radioButtonLine.Size = new System.Drawing.Size(45, 17);
            this.radioButtonLine.TabIndex = 1;
            this.radioButtonLine.Text = "Line";
            this.radioButtonLine.UseVisualStyleBackColor = true;
            // 
            // radioButtonMarker
            // 
            this.radioButtonMarker.AutoSize = true;
            this.radioButtonMarker.Checked = true;
            this.radioButtonMarker.Location = new System.Drawing.Point(7, 20);
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
            this.myMap.Location = new System.Drawing.Point(239, 12);
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
            this.myMap.Size = new System.Drawing.Size(732, 591);
            this.myMap.TabIndex = 0;
            this.myMap.Zoom = 12D;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 615);
            this.Controls.Add(this.groupBoxDisplayType);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonSqlOk);
            this.Controls.Add(this.textBoxSql);
            this.Controls.Add(this.myMap);
            this.Name = "Form1";
            this.Text = "RouteLine";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxDisplayType.ResumeLayout(false);
            this.groupBoxDisplayType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl myMap;
        private System.Windows.Forms.TextBox textBoxSql;
        private System.Windows.Forms.Button buttonSqlOk;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.GroupBox groupBoxDisplayType;
        private System.Windows.Forms.RadioButton radioButtonHeatMap;
        private System.Windows.Forms.RadioButton radioButtonLine;
        private System.Windows.Forms.RadioButton radioButtonMarker;

    }
}


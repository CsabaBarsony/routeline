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
            this.buttonSqlOk = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.groupBoxDisplayType = new System.Windows.Forms.GroupBox();
            this.radioButtonHeatMap = new System.Windows.Forms.RadioButton();
            this.radioButtonLine = new System.Windows.Forms.RadioButton();
            this.radioButtonMarker = new System.Windows.Forms.RadioButton();
            this.myMap = new GMap.NET.WindowsForms.GMapControl();
            this.groupBoxQueries = new System.Windows.Forms.GroupBox();
            this.labelAccuracyMeter = new System.Windows.Forms.Label();
            this.labelMinAccuracy = new System.Windows.Forms.Label();
            this.numericUpDownMinAccuracy = new System.Windows.Forms.NumericUpDown();
            this.buttonQueryDown = new System.Windows.Forms.Button();
            this.buttonQueryUp = new System.Windows.Forms.Button();
            this.labelQueryCount = new System.Windows.Forms.Label();
            this.buttonCloneQuery = new System.Windows.Forms.Button();
            this.buttonDeleteQuery = new System.Windows.Forms.Button();
            this.checkedListBoxQueries = new System.Windows.Forms.CheckedListBox();
            this.panelSelectedQuery = new System.Windows.Forms.Panel();
            this.panelColorSample = new System.Windows.Forms.Panel();
            this.buttonQueryColor = new System.Windows.Forms.Button();
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
            this.colorDialogQuery = new System.Windows.Forms.ColorDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fájlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSave = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainerMapAndTable = new System.Windows.Forms.SplitContainer();
            this.tabControlTables = new System.Windows.Forms.TabControl();
            this.tableLayoutPanel2Columns = new System.Windows.Forms.TableLayoutPanel();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelRight = new System.Windows.Forms.Panel();
            this.textBoxQueryVariables = new System.Windows.Forms.TextBox();
            this.labelQueryVariables = new System.Windows.Forms.Label();
            this.groupBoxDisplayType.SuspendLayout();
            this.groupBoxQueries.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinAccuracy)).BeginInit();
            this.panelSelectedQuery.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMapAndTable)).BeginInit();
            this.splitContainerMapAndTable.Panel1.SuspendLayout();
            this.splitContainerMapAndTable.Panel2.SuspendLayout();
            this.splitContainerMapAndTable.SuspendLayout();
            this.tableLayoutPanel2Columns.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSqlOk
            // 
            this.buttonSqlOk.Location = new System.Drawing.Point(3, 3);
            this.buttonSqlOk.Name = "buttonSqlOk";
            this.buttonSqlOk.Size = new System.Drawing.Size(75, 23);
            this.buttonSqlOk.TabIndex = 2;
            this.buttonSqlOk.Text = "Mutat";
            this.buttonSqlOk.UseVisualStyleBackColor = true;
            this.buttonSqlOk.Click += new System.EventHandler(this.buttonSqlOk_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(84, 3);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 3;
            this.buttonClear.Text = "Elrejt";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // groupBoxDisplayType
            // 
            this.groupBoxDisplayType.Controls.Add(this.radioButtonHeatMap);
            this.groupBoxDisplayType.Controls.Add(this.radioButtonLine);
            this.groupBoxDisplayType.Controls.Add(this.radioButtonMarker);
            this.groupBoxDisplayType.Location = new System.Drawing.Point(3, 38);
            this.groupBoxDisplayType.Name = "groupBoxDisplayType";
            this.groupBoxDisplayType.Size = new System.Drawing.Size(263, 35);
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
            this.myMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myMap.EmptyTileColor = System.Drawing.Color.Navy;
            this.myMap.GrayScaleMode = false;
            this.myMap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.myMap.LevelsKeepInMemmory = 5;
            this.myMap.Location = new System.Drawing.Point(0, 0);
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
            this.myMap.Size = new System.Drawing.Size(702, 429);
            this.myMap.TabIndex = 0;
            this.myMap.Zoom = 12D;
            this.myMap.OnMarkerClick += new GMap.NET.WindowsForms.MarkerClick(this.myMap_OnMarkerClick);
            // 
            // groupBoxQueries
            // 
            this.groupBoxQueries.Controls.Add(this.labelQueryVariables);
            this.groupBoxQueries.Controls.Add(this.labelAccuracyMeter);
            this.groupBoxQueries.Controls.Add(this.textBoxQueryVariables);
            this.groupBoxQueries.Controls.Add(this.labelMinAccuracy);
            this.groupBoxQueries.Controls.Add(this.numericUpDownMinAccuracy);
            this.groupBoxQueries.Controls.Add(this.buttonQueryDown);
            this.groupBoxQueries.Controls.Add(this.buttonQueryUp);
            this.groupBoxQueries.Controls.Add(this.labelQueryCount);
            this.groupBoxQueries.Controls.Add(this.buttonCloneQuery);
            this.groupBoxQueries.Controls.Add(this.buttonDeleteQuery);
            this.groupBoxQueries.Controls.Add(this.checkedListBoxQueries);
            this.groupBoxQueries.Controls.Add(this.panelSelectedQuery);
            this.groupBoxQueries.Controls.Add(this.buttonAddQuery);
            this.groupBoxQueries.Controls.Add(this.buttonRemoveQuery);
            this.groupBoxQueries.Location = new System.Drawing.Point(3, 79);
            this.groupBoxQueries.Name = "groupBoxQueries";
            this.groupBoxQueries.Size = new System.Drawing.Size(263, 514);
            this.groupBoxQueries.TabIndex = 6;
            this.groupBoxQueries.TabStop = false;
            this.groupBoxQueries.Text = "Lekérdezések";
            // 
            // labelAccuracyMeter
            // 
            this.labelAccuracyMeter.AutoSize = true;
            this.labelAccuracyMeter.Location = new System.Drawing.Point(132, 431);
            this.labelAccuracyMeter.Name = "labelAccuracyMeter";
            this.labelAccuracyMeter.Size = new System.Drawing.Size(33, 13);
            this.labelAccuracyMeter.TabIndex = 24;
            this.labelAccuracyMeter.Text = "méter";
            // 
            // labelMinAccuracy
            // 
            this.labelMinAccuracy.AutoSize = true;
            this.labelMinAccuracy.Location = new System.Drawing.Point(6, 413);
            this.labelMinAccuracy.Name = "labelMinAccuracy";
            this.labelMinAccuracy.Size = new System.Drawing.Size(60, 13);
            this.labelMinAccuracy.TabIndex = 23;
            this.labelMinAccuracy.Text = "Pontosság:";
            // 
            // numericUpDownMinAccuracy
            // 
            this.numericUpDownMinAccuracy.Location = new System.Drawing.Point(6, 429);
            this.numericUpDownMinAccuracy.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownMinAccuracy.Name = "numericUpDownMinAccuracy";
            this.numericUpDownMinAccuracy.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownMinAccuracy.TabIndex = 22;
            this.numericUpDownMinAccuracy.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // buttonQueryDown
            // 
            this.buttonQueryDown.Location = new System.Drawing.Point(182, 164);
            this.buttonQueryDown.Name = "buttonQueryDown";
            this.buttonQueryDown.Size = new System.Drawing.Size(75, 23);
            this.buttonQueryDown.TabIndex = 21;
            this.buttonQueryDown.Text = "Le";
            this.buttonQueryDown.UseVisualStyleBackColor = true;
            this.buttonQueryDown.Click += new System.EventHandler(this.buttonQueryDown_Click);
            // 
            // buttonQueryUp
            // 
            this.buttonQueryUp.Location = new System.Drawing.Point(182, 135);
            this.buttonQueryUp.Name = "buttonQueryUp";
            this.buttonQueryUp.Size = new System.Drawing.Size(75, 23);
            this.buttonQueryUp.TabIndex = 20;
            this.buttonQueryUp.Text = "Fel";
            this.buttonQueryUp.UseVisualStyleBackColor = true;
            this.buttonQueryUp.Click += new System.EventHandler(this.buttonQueryUp_Click);
            // 
            // labelQueryCount
            // 
            this.labelQueryCount.AutoSize = true;
            this.labelQueryCount.Location = new System.Drawing.Point(6, 491);
            this.labelQueryCount.Name = "labelQueryCount";
            this.labelQueryCount.Size = new System.Drawing.Size(100, 13);
            this.labelQueryCount.TabIndex = 19;
            this.labelQueryCount.Text = "lekérdezett sorok: 0";
            // 
            // buttonCloneQuery
            // 
            this.buttonCloneQuery.Location = new System.Drawing.Point(182, 106);
            this.buttonCloneQuery.Name = "buttonCloneQuery";
            this.buttonCloneQuery.Size = new System.Drawing.Size(75, 23);
            this.buttonCloneQuery.TabIndex = 19;
            this.buttonCloneQuery.Text = "Klónoz";
            this.buttonCloneQuery.UseVisualStyleBackColor = true;
            this.buttonCloneQuery.Click += new System.EventHandler(this.buttonCloneQuery_Click);
            // 
            // buttonDeleteQuery
            // 
            this.buttonDeleteQuery.Location = new System.Drawing.Point(182, 77);
            this.buttonDeleteQuery.Name = "buttonDeleteQuery";
            this.buttonDeleteQuery.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteQuery.TabIndex = 16;
            this.buttonDeleteQuery.Text = "Töröl";
            this.buttonDeleteQuery.UseVisualStyleBackColor = true;
            this.buttonDeleteQuery.Click += new System.EventHandler(this.buttonDeleteQuery_Click);
            // 
            // checkedListBoxQueries
            // 
            this.checkedListBoxQueries.FormattingEnabled = true;
            this.checkedListBoxQueries.Location = new System.Drawing.Point(7, 19);
            this.checkedListBoxQueries.Name = "checkedListBoxQueries";
            this.checkedListBoxQueries.Size = new System.Drawing.Size(169, 169);
            this.checkedListBoxQueries.TabIndex = 13;
            this.checkedListBoxQueries.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxQueries_SelectedIndexChanged);
            // 
            // panelSelectedQuery
            // 
            this.panelSelectedQuery.Controls.Add(this.panelColorSample);
            this.panelSelectedQuery.Controls.Add(this.buttonQueryColor);
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
            this.panelSelectedQuery.Size = new System.Drawing.Size(250, 216);
            this.panelSelectedQuery.TabIndex = 11;
            this.panelSelectedQuery.Visible = false;
            // 
            // panelColorSample
            // 
            this.panelColorSample.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelColorSample.Location = new System.Drawing.Point(80, 164);
            this.panelColorSample.Name = "panelColorSample";
            this.panelColorSample.Size = new System.Drawing.Size(35, 23);
            this.panelColorSample.TabIndex = 18;
            // 
            // buttonQueryColor
            // 
            this.buttonQueryColor.Location = new System.Drawing.Point(-1, 164);
            this.buttonQueryColor.Name = "buttonQueryColor";
            this.buttonQueryColor.Size = new System.Drawing.Size(75, 23);
            this.buttonQueryColor.TabIndex = 8;
            this.buttonQueryColor.Text = "Szín";
            this.buttonQueryColor.UseVisualStyleBackColor = true;
            this.buttonQueryColor.Click += new System.EventHandler(this.buttonQueryColor_Click);
            // 
            // buttonNewQueryCancel
            // 
            this.buttonNewQueryCancel.Location = new System.Drawing.Point(80, 193);
            this.buttonNewQueryCancel.Name = "buttonNewQueryCancel";
            this.buttonNewQueryCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonNewQueryCancel.TabIndex = 10;
            this.buttonNewQueryCancel.Text = "Mégse";
            this.buttonNewQueryCancel.UseVisualStyleBackColor = true;
            this.buttonNewQueryCancel.Click += new System.EventHandler(this.buttonNewQueryCancel_Click);
            // 
            // buttonNewQueryOk
            // 
            this.buttonNewQueryOk.Location = new System.Drawing.Point(-1, 193);
            this.buttonNewQueryOk.Name = "buttonNewQueryOk";
            this.buttonNewQueryOk.Size = new System.Drawing.Size(75, 23);
            this.buttonNewQueryOk.TabIndex = 9;
            this.buttonNewQueryOk.Text = "OK";
            this.buttonNewQueryOk.UseVisualStyleBackColor = true;
            this.buttonNewQueryOk.Click += new System.EventHandler(this.buttonNewQueryOk_Click);
            // 
            // textBoxQueryName
            // 
            this.textBoxQueryName.Location = new System.Drawing.Point(0, 16);
            this.textBoxQueryName.Name = "textBoxQueryName";
            this.textBoxQueryName.Size = new System.Drawing.Size(250, 20);
            this.textBoxQueryName.TabIndex = 4;
            // 
            // labelQueryName
            // 
            this.labelQueryName.AutoSize = true;
            this.labelQueryName.Location = new System.Drawing.Point(-1, 0);
            this.labelQueryName.Name = "labelQueryName";
            this.labelQueryName.Size = new System.Drawing.Size(30, 13);
            this.labelQueryName.TabIndex = 1;
            this.labelQueryName.Text = "Név:";
            // 
            // labelQueryDescription
            // 
            this.labelQueryDescription.AutoSize = true;
            this.labelQueryDescription.Location = new System.Drawing.Point(-1, 39);
            this.labelQueryDescription.Name = "labelQueryDescription";
            this.labelQueryDescription.Size = new System.Drawing.Size(40, 13);
            this.labelQueryDescription.TabIndex = 2;
            this.labelQueryDescription.Text = "Leírás:";
            // 
            // textBoxQueryDescription
            // 
            this.textBoxQueryDescription.Location = new System.Drawing.Point(0, 55);
            this.textBoxQueryDescription.Name = "textBoxQueryDescription";
            this.textBoxQueryDescription.Size = new System.Drawing.Size(250, 20);
            this.textBoxQueryDescription.TabIndex = 5;
            // 
            // textBoxQuerySql
            // 
            this.textBoxQuerySql.Location = new System.Drawing.Point(0, 94);
            this.textBoxQuerySql.Multiline = true;
            this.textBoxQuerySql.Name = "textBoxQuerySql";
            this.textBoxQuerySql.Size = new System.Drawing.Size(250, 64);
            this.textBoxQuerySql.TabIndex = 6;
            // 
            // labelQuerySql
            // 
            this.labelQuerySql.AutoSize = true;
            this.labelQuerySql.Location = new System.Drawing.Point(-1, 78);
            this.labelQuerySql.Name = "labelQuerySql";
            this.labelQuerySql.Size = new System.Drawing.Size(31, 13);
            this.labelQuerySql.TabIndex = 3;
            this.labelQuerySql.Text = "SQL:";
            // 
            // buttonAddQuery
            // 
            this.buttonAddQuery.Location = new System.Drawing.Point(182, 19);
            this.buttonAddQuery.Name = "buttonAddQuery";
            this.buttonAddQuery.Size = new System.Drawing.Size(75, 23);
            this.buttonAddQuery.TabIndex = 8;
            this.buttonAddQuery.Text = "Hozzáad";
            this.buttonAddQuery.UseVisualStyleBackColor = true;
            this.buttonAddQuery.Click += new System.EventHandler(this.buttonAddQuery_Click);
            // 
            // buttonRemoveQuery
            // 
            this.buttonRemoveQuery.Location = new System.Drawing.Point(182, 48);
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
            // colorDialogQuery
            // 
            this.colorDialogQuery.Color = System.Drawing.Color.Blue;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fájlToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(983, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fájlToolStripMenuItem
            // 
            this.fájlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemLoad,
            this.toolStripMenuItemSave});
            this.fájlToolStripMenuItem.Name = "fájlToolStripMenuItem";
            this.fájlToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fájlToolStripMenuItem.Text = "Fájl";
            // 
            // toolStripMenuItemLoad
            // 
            this.toolStripMenuItemLoad.Name = "toolStripMenuItemLoad";
            this.toolStripMenuItemLoad.Size = new System.Drawing.Size(105, 22);
            this.toolStripMenuItemLoad.Text = "Betölt";
            this.toolStripMenuItemLoad.Click += new System.EventHandler(this.toolStripMenuItemLoad_Click);
            // 
            // toolStripMenuItemSave
            // 
            this.toolStripMenuItemSave.Name = "toolStripMenuItemSave";
            this.toolStripMenuItemSave.Size = new System.Drawing.Size(105, 22);
            this.toolStripMenuItemSave.Text = "Ment";
            this.toolStripMenuItemSave.Click += new System.EventHandler(this.toolStripMenuItemSave_Click);
            // 
            // splitContainerMapAndTable
            // 
            this.splitContainerMapAndTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMapAndTable.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainerMapAndTable.Location = new System.Drawing.Point(0, 0);
            this.splitContainerMapAndTable.Name = "splitContainerMapAndTable";
            this.splitContainerMapAndTable.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerMapAndTable.Panel1
            // 
            this.splitContainerMapAndTable.Panel1.Controls.Add(this.myMap);
            // 
            // splitContainerMapAndTable.Panel2
            // 
            this.splitContainerMapAndTable.Panel2.Controls.Add(this.tabControlTables);
            this.splitContainerMapAndTable.Size = new System.Drawing.Size(702, 600);
            this.splitContainerMapAndTable.SplitterDistance = 429;
            this.splitContainerMapAndTable.TabIndex = 8;
            // 
            // tabControlTables
            // 
            this.tabControlTables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlTables.Location = new System.Drawing.Point(0, 0);
            this.tabControlTables.Name = "tabControlTables";
            this.tabControlTables.SelectedIndex = 0;
            this.tabControlTables.Size = new System.Drawing.Size(702, 167);
            this.tabControlTables.TabIndex = 0;
            // 
            // tableLayoutPanel2Columns
            // 
            this.tableLayoutPanel2Columns.ColumnCount = 2;
            this.tableLayoutPanel2Columns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 275F));
            this.tableLayoutPanel2Columns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2Columns.Controls.Add(this.panelLeft, 0, 0);
            this.tableLayoutPanel2Columns.Controls.Add(this.panelRight, 1, 0);
            this.tableLayoutPanel2Columns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2Columns.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel2Columns.Name = "tableLayoutPanel2Columns";
            this.tableLayoutPanel2Columns.RowCount = 1;
            this.tableLayoutPanel2Columns.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2Columns.Size = new System.Drawing.Size(983, 606);
            this.tableLayoutPanel2Columns.TabIndex = 1;
            // 
            // panelLeft
            // 
            this.panelLeft.AutoScroll = true;
            this.panelLeft.BackColor = System.Drawing.SystemColors.Control;
            this.panelLeft.Controls.Add(this.buttonSqlOk);
            this.panelLeft.Controls.Add(this.groupBoxDisplayType);
            this.panelLeft.Controls.Add(this.buttonClear);
            this.panelLeft.Controls.Add(this.groupBoxQueries);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLeft.Location = new System.Drawing.Point(3, 3);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(269, 600);
            this.panelLeft.TabIndex = 0;
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.SystemColors.Control;
            this.panelRight.Controls.Add(this.splitContainerMapAndTable);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(278, 3);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(702, 600);
            this.panelRight.TabIndex = 1;
            // 
            // textBoxQueryVariables
            // 
            this.textBoxQueryVariables.Location = new System.Drawing.Point(6, 468);
            this.textBoxQueryVariables.Name = "textBoxQueryVariables";
            this.textBoxQueryVariables.Size = new System.Drawing.Size(250, 20);
            this.textBoxQueryVariables.TabIndex = 7;
            // 
            // labelQueryVariables
            // 
            this.labelQueryVariables.AutoSize = true;
            this.labelQueryVariables.Location = new System.Drawing.Point(6, 452);
            this.labelQueryVariables.Name = "labelQueryVariables";
            this.labelQueryVariables.Size = new System.Drawing.Size(51, 13);
            this.labelQueryVariables.TabIndex = 20;
            this.labelQueryVariables.Text = "Változók:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 630);
            this.Controls.Add(this.tableLayoutPanel2Columns);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "RouteLine";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxDisplayType.ResumeLayout(false);
            this.groupBoxDisplayType.PerformLayout();
            this.groupBoxQueries.ResumeLayout(false);
            this.groupBoxQueries.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinAccuracy)).EndInit();
            this.panelSelectedQuery.ResumeLayout(false);
            this.panelSelectedQuery.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainerMapAndTable.Panel1.ResumeLayout(false);
            this.splitContainerMapAndTable.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMapAndTable)).EndInit();
            this.splitContainerMapAndTable.ResumeLayout(false);
            this.tableLayoutPanel2Columns.ResumeLayout(false);
            this.panelLeft.ResumeLayout(false);
            this.panelRight.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Button buttonNewQueryCancel;
        private System.Windows.Forms.Button buttonNewQueryOk;
        private System.Windows.Forms.SaveFileDialog saveFileDialogXml;
        private System.Windows.Forms.ColorDialog colorDialogQuery;
        private System.Windows.Forms.Button buttonQueryColor;
        private System.Windows.Forms.Panel panelColorSample;
        private System.Windows.Forms.Button buttonCloneQuery;
        private System.Windows.Forms.Label labelQueryCount;
        private System.Windows.Forms.Button buttonQueryDown;
        private System.Windows.Forms.Button buttonQueryUp;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fájlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemLoad;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSave;
        private System.Windows.Forms.Label labelMinAccuracy;
        private System.Windows.Forms.NumericUpDown numericUpDownMinAccuracy;
        private System.Windows.Forms.SplitContainer splitContainerMapAndTable;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2Columns;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Label labelAccuracyMeter;
        private System.Windows.Forms.TabControl tabControlTables;
        private System.Windows.Forms.Label labelQueryVariables;
        private System.Windows.Forms.TextBox textBoxQueryVariables;

    }
}


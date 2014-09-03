using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using Npgsql;
using RouteLineUI.Classes;

namespace RouteLineUI
{
    public partial class FormMain : Form
    {
        private GMapOverlay markerOverlay;
        private GMapOverlay routesOverlay;
        private SqlReader sqlReader;
        private List<Location> locations;
        private List<Query> queries;
        private ColorConverter colorConverter;

        public FormMain()
        {
            this.markerOverlay = new GMapOverlay("markers");
            this.routesOverlay = new GMapOverlay("routes");
            this.sqlReader = new SqlReader("Server=csabavm;Port=5432;User Id=postgres;Password=Asd..123;Database=tmcdb_production;");
            this.queries = new List<Query>();
            this.MouseWheel += new MouseEventHandler(MapMouseWheel);
            this.colorConverter = new ColorConverter();
            InitializeComponent();
        }

        private void Form1_Load(Object sender, EventArgs e)
        {
            myMap.DisableFocusOnMouseEnter = true;
            myMap.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            myMap.Position = new GMap.NET.PointLatLng(46.25, 20.15);
            myMap.Overlays.Add(markerOverlay);
            panelColorSample.BackColor = colorDialogQuery.Color;
            checkedListBoxQueries.Items.Add(new Query { name = "név 1", description = "leírás 1", sql = "select * from taxi_locations where id < 500", color = "Blue" }, true);
            checkedListBoxQueries.Items.Add(new Query { name = "név 2", description = "leírás 2", sql = "select * from taxi_locations where id > 4500 and id < 5000", color = "Green" }, true);
        }

        private void MapMouseWheel(object sender, MouseEventArgs e)
        {
            this.myMap.Focus();
        }

        private async void buttonSqlOk_Click(object sender, EventArgs e)
        {
            buttonSqlOk.Text = "Loading...";
            buttonSqlOk.Enabled = false;
            await Task.Run(() =>
            {
                locations = sqlReader.readLocations("select * from taxi_locations where id < 500");
            });

            if (radioButtonMarker.Checked)
            {
                Bitmap m = new Bitmap(10, 10);
                Graphics g = Graphics.FromImage(m);
                Brush orangeBrush = new SolidBrush(Color.OrangeRed);
                Brush blueBrush = new SolidBrush(Color.Blue);
                g.FillPie(orangeBrush, 0f, 0f, 10f, 10f, 90f, 180f);
                g.FillPie(blueBrush, 0f, 0f, 10f, 10f, 270f, 180f);
                Bitmap img = new Bitmap("blue_dot.png");
                foreach (Location l in locations)
                {
                    markerOverlay.Markers.Add(new GMarkerGoogle(new PointLatLng(l.lat, l.lon), m));
                }
            }
            else if (radioButtonLine.Checked)
            {
                List<PointLatLng> points = new List<PointLatLng>();

                foreach (Location l in locations)
                {
                    points.Add(new PointLatLng(l.lat, l.lon));
                }

                GMapRoute path1 = new GMapRoute(points, "myroute");
                path1.Stroke = new Pen(Color.FromArgb(100, 255, 100), 5.0f);
                GMapRoute path2 = new GMapRoute(points, "myroute");
                path2.Stroke = new Pen(Color.FromArgb(255, 109, 109), 2.0f);
                markerOverlay.Routes.Add(path1);
                markerOverlay.Routes.Add(path2);
            }
            buttonSqlOk.Text = "OK";
            buttonSqlOk.Enabled = true;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            locations = null;
            markerOverlay.Markers.Clear();
            markerOverlay.Routes.Clear();
        }

        private void buttonManageSql_Click(object sender, EventArgs e)
        {
            FormManageSql formManageSql = new FormManageSql();
            formManageSql.ShowDialog();
        }

        private void buttonAddQuery_Click(object sender, EventArgs e)
        {
            checkedListBoxQueries.SelectedIndex = -1;
            this.emptyQueryPanel();
            panelSelectedQuery.Visible = true;
            textBoxQueryName.Focus();
        }

        private void buttonRemoveQuery_Click(object sender, EventArgs e)
        {
            if (checkedListBoxQueries.SelectedIndex < 0) return;
            checkedListBoxQueries.Items.Remove(checkedListBoxQueries.Items[checkedListBoxQueries.SelectedIndex]);
            this.emptyQueryPanel();
            panelSelectedQuery.Visible = false;
        }

        private void buttonSaveQuery_Click(object sender, EventArgs e)
        {
            saveFileDialogXml.ShowDialog();

            if (saveFileDialogXml.FileName != "")
            {
                FileStream fs = (FileStream)saveFileDialogXml.OpenFile();
                XmlSerializer writer = new XmlSerializer(typeof(List<Query>));
                writer.Serialize(fs, checkedListBoxQueries.Items.Cast<Query>().ToList());
                fs.Close();
            }
        }

        private void buttonLoadQuery_Click(object sender, EventArgs e)
        {
            if (0 < checkedListBoxQueries.Items.Count)
                if (MessageBox.Show("A nem mentett változtatások elvesznek. Biztosan folytatja?", "A nem mentett változtatások elvesznek", MessageBoxButtons.YesNo) == DialogResult.No) return;
            openFileDialogXml.ShowDialog();
            if (openFileDialogXml.FileName != "")
            {
                XmlSerializer reader = new XmlSerializer(typeof(List<Query>));
                StreamReader file = new StreamReader(openFileDialogXml.FileName);
                List<Query> loadedQueries = new List<Query>();
                try
                {
                    loadedQueries = (List<Query>)reader.Deserialize(file);
                }
                catch (InvalidOperationException ex)
                {
                    MessageBox.Show("Hiba a fájl megnyitásakor: " + ex.Message);
                    return;
                }

                checkedListBoxQueries.Items.Clear();

                foreach (Query q in loadedQueries)
                {
                    checkedListBoxQueries.Items.Add(q, true);
                }

                this.emptyQueryPanel();
                panelSelectedQuery.Visible = false;
            }
        }

        private void buttonDeleteQuery_Click(object sender, EventArgs e)
        {
            if (checkedListBoxQueries.Items.Count == 0) return;
            if (MessageBox.Show("Biztosan törli az összes lekérdezést?", "Összes lekérdezés törlése", MessageBoxButtons.YesNo) == DialogResult.No) return;
            checkedListBoxQueries.Items.Clear();
            this.emptyQueryPanel();
            panelSelectedQuery.Visible = false;
        }

        private void buttonNewQueryOk_Click(object sender, EventArgs e)
        {
            if (textBoxQueryName.Text == "" || textBoxQueryDescription.Text == "" || textBoxQuerySql.Text == "")
            {
                MessageBox.Show("Minden mezőt ki kell tölteni!");
                return;
            }

            Query newQuery = new Query
            {
                name = textBoxQueryName.Text,
                description = textBoxQueryDescription.Text,
                sql = textBoxQuerySql.Text,
                color = colorConverter.ConvertToString(panelColorSample.BackColor)
            };

            if (0 <= checkedListBoxQueries.SelectedIndex)
            {
                checkedListBoxQueries.Items[checkedListBoxQueries.SelectedIndex] = newQuery;
            }
            else
            {
                checkedListBoxQueries.Items.Add(newQuery, true);
            }

            this.emptyQueryPanel();
            panelSelectedQuery.Visible = false;
        }

        private void buttonNewQueryCancel_Click(object sender, EventArgs e)
        {
            this.emptyQueryPanel();
            panelSelectedQuery.Visible = false;
            checkedListBoxQueries.SelectedIndex = -1;
        }

        private void checkedListBoxQueries_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkedListBoxQueries.SelectedIndex < 0) return;
            panelSelectedQuery.Visible = true;
            Query selectedQuery = (Query)checkedListBoxQueries.Items[checkedListBoxQueries.SelectedIndex];
            textBoxQueryName.Text = selectedQuery.name;
            textBoxQueryDescription.Text = selectedQuery.description;
            textBoxQuerySql.Text = selectedQuery.sql;
            panelColorSample.BackColor = (Color)colorConverter.ConvertFromString(selectedQuery.color);
        }

        private void emptyQueryPanel()
        {
            textBoxQueryName.Text = textBoxQueryDescription.Text = textBoxQuerySql.Text = "";
        }

        private void buttonQueryColor_Click(object sender, EventArgs e)
        {
            if (colorDialogQuery.ShowDialog() == DialogResult.OK)
            {
                panelColorSample.BackColor = colorDialogQuery.Color;
            }
        }
    }
}

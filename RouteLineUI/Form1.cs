﻿using GMap.NET;
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
        private List<Route> routes;
        private List<Query> queries;
        private ColorConverter colorConverter;
        private string labelQueryCountText;

        public FormMain()
        {
            this.markerOverlay = new GMapOverlay("markers");
            this.routesOverlay = new GMapOverlay("routes");
            this.sqlReader = new SqlReader("Server=csabavm;Port=5432;User Id=postgres;Password=Asd..123;Database=tmcdb_production;");
            this.queries = new List<Query>();
            this.MouseWheel += new MouseEventHandler(MapMouseWheel);
            this.colorConverter = new ColorConverter();
            this.labelQueryCountText = "lekérdezett sorok: ";
            InitializeComponent();
        }

        private void Form1_Load(Object sender, EventArgs e)
        {
            //FormAuth authForm = new FormAuth();
            //authForm.Show();
            //this.Hide();

            myMap.DisableFocusOnMouseEnter = true;
            myMap.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            myMap.Position = new GMap.NET.PointLatLng(46.25, 20.15);
            myMap.Overlays.Add(markerOverlay);
            panelColorSample.BackColor = colorDialogQuery.Color;
            checkedListBoxQueries.Items.Add(new Query { name = "név 1", description = "leírás 1", sql = "select * from taxi_locations where tracking_session_id = 1000 order by ts limit 500", color = "Blue" }, true);
            checkedListBoxQueries.Items.Add(new Query { name = "név 2", description = "leírás 2", sql = "select * from taxi_locations where id > 4500 and id < 5000", color = "Green" }, true);
        }

        private void MapMouseWheel(object sender, MouseEventArgs e)
        {
            this.myMap.Focus();
        }

        private async void buttonSqlOk_Click(object sender, EventArgs e)
        {
            this.markerOverlay.Clear();
            this.routesOverlay.Clear();
            this.routes = new List<Route>();
            List<Query> checkedQueries = checkedListBoxQueries.CheckedItems.Cast<Query>().ToList();
            int rowCount = 0;
            await Task.Run(() =>
            {
                foreach (Query q in checkedQueries)
                {
                    List<Location> location = new List<Location>();
                    try
                    {
                        location = sqlReader.readLocations(q.sql);
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Hiba történt a lekérdezés közben: " + ex.Message);
                    }
                    routes.Add(new Route
                    {
                        query = new Query { name = q.name, description = q.description, sql = q.sql, color = q.color },
                        locations = location
                    });
                    rowCount += location.Count;
                }
            });

            labelQueryCount.Text = labelQueryCountText + rowCount.ToString();

            if (radioButtonMarker.Checked)
            {
                foreach (Route r in this.routes)
                {
                    Bitmap m = new Bitmap(10, 10);
                    Graphics g = Graphics.FromImage(m);
                    Color color = (Color)colorConverter.ConvertFromString(r.query.color);
                    Brush brush = new SolidBrush(color);
                    g.FillEllipse(brush, 0f, 0f, 10f, 10f);
                    foreach (Location l in r.locations)
                    {
                        markerOverlay.Markers.Add(new GMarkerGoogle(new PointLatLng(l.lat, l.lon), m));
                    }
                }
            }
            else if (radioButtonLine.Checked)
            {
                foreach (Route r in this.routes)
                {
                    List<List<PointLatLng>> pointsList = new List<List<PointLatLng>>();
                    int lastStatus = 0;
                    List<PointLatLng> points = new List<PointLatLng>();
                    pointsList.Add(points);
                    foreach (Location l in r.locations)
                    {
                        if (l.status == lastStatus)
                        {
                            points.Add(new PointLatLng(l.lat, l.lon));
                        }
                        else
                        {
                            points = new List<PointLatLng>();
                            pointsList.Add(points);
                            lastStatus = l.status;
                        }
                    }
                    GMapRoute route;
                    foreach (List<PointLatLng> p in pointsList)
                    {
                        route = new GMapRoute(p, "myRoute");
                        route.Stroke = new Pen((Color)colorConverter.ConvertFromString(r.query.color), 3f);
                        markerOverlay.Routes.Add(route);
                    }
                }
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            routes = null;
            markerOverlay.Markers.Clear();
            markerOverlay.Routes.Clear();
            labelQueryCount.Text = labelQueryCountText + "0";
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
            Random rnd = new Random();
            panelColorSample.BackColor = Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255));
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
            
        }

        private void buttonLoadQuery_Click(object sender, EventArgs e)
        {
            
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

        private void buttonCloneQuery_Click(object sender, EventArgs e)
        {
            if (checkedListBoxQueries.SelectedItems.Count == 1)
            {
                Query itemToClone = (Query)checkedListBoxQueries.SelectedItems[0];
                checkedListBoxQueries.Items.Add(itemToClone);
            }
        }

        private void buttonQueryUp_Click(object sender, EventArgs e)
        {
            this.reorderList(true);
        }

        private void buttonQueryDown_Click(object sender, EventArgs e)
        {
            this.reorderList(false);
        }

        private void reorderList(bool up)
        {
            int changeIndex;
            int indexOnEdge;

            if (up)
            {
                changeIndex = -1;
                indexOnEdge = 0;
            }
            else
            {
                changeIndex = 1;
                indexOnEdge = checkedListBoxQueries.Items.Count - 1;
            }

            if (checkedListBoxQueries.SelectedItems.Count != 1) return;
            Query selectedQuery = (Query)checkedListBoxQueries.SelectedItem;
            int selectedIndex = checkedListBoxQueries.Items.IndexOf(selectedQuery);
            if (selectedIndex == indexOnEdge) return;
            Query queryToChange = (Query)checkedListBoxQueries.Items[selectedIndex + changeIndex];
            checkedListBoxQueries.Items[selectedIndex] = queryToChange;
            checkedListBoxQueries.Items[selectedIndex + changeIndex] = selectedQuery;
            checkedListBoxQueries.SetSelected(selectedIndex, false);
            checkedListBoxQueries.SetSelected(selectedIndex + changeIndex, true);
        }

        private void toolStripMenuItemLoad_Click(object sender, EventArgs e)
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

        private void toolStripMenuItemSave_Click(object sender, EventArgs e)
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
    }
}

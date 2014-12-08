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
using System.Configuration;

namespace RouteLineUI
{
    public partial class Form1 : Form
    {
        private GMapOverlay         markerOverlay;
        private GMapOverlay         routesOverlay;
        private SqlReader           sqlReader;
        private List<Route>         routes;
        private List<Query>         queries;
        private List<DataGridView>  dataGrids;
        private ColorConverter      colorConverter;
        private string              labelQueryCountText;
        private bool                newQueryEditing = false;

        public Form1()
        {
            this.markerOverlay          =  new GMapOverlay("markers");
            this.routesOverlay          =  new GMapOverlay("routes");
            this.queries                =  new List<Query>();
            this.dataGrids              =  new List<DataGridView>();
            this.MouseWheel             += new MouseEventHandler(MapMouseWheel);
            this.colorConverter         =  new ColorConverter();
            this.labelQueryCountText    =  "lekérdezett sorok: ";

            InitializeComponent();
        }

        private void Form1_Load(Object sender, EventArgs e)
        {
            myMap.DisableFocusOnMouseEnter = true;
            myMap.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            myMap.Zoom = 10.0;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            myMap.Position = new GMap.NET.PointLatLng(46.25, 20.15);
            myMap.Overlays.Add(markerOverlay);
            panelColorSample.BackColor = colorDialogQuery.Color;
            //checkedListBoxQueries.Items.Add(new Query { name = "név 1", description = "leírás 1", sql = "select * from taxi_locations where tracking_session_id = 1000 order by ts limit 500", color = "Blue" }, true);
            //checkedListBoxQueries.Items.Add(new Query { name = "név 2", description = "leírás 2", sql = "select * from taxi_locations where id > 4500 and id < 5000", color = "Red" }, true);

            
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            //Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            //KeyValueConfigurationCollection settings = config.AppSettings.Settings;
            //string[] settingKeys = settings.AllKeys;
            //if (!settingKeys.Contains("server")     ||
            //    !settingKeys.Contains("port")       ||
            //    !settingKeys.Contains("user_id")    ||
            //    !settingKeys.Contains("password")   ||
            //    !settingKeys.Contains("database"))
            //{
            //    FormSettings formSettings = new FormSettings(true);
            //    formSettings.Show();
            //}
            //this.sqlReader = new SqlReader(
            //    "Server="   + settings["server"]    .Value    + ";" +
            //    "Port="     + settings["port"]      .Value    + ";" +
            //    "User="     + settings["user_id"]   .Value    + ";" +
            //    "Password=" + settings["password"]  .Value    + ";" +
            //    "Database=" + settings["database"]  .Value    + ";"
            //);

            try
            {
                this.sqlReader = new SqlReader(
                "Server=" + ConnectionDetails.server + ";" +
                "Port=" + ConnectionDetails.port + ";" +
                "User=" + ConnectionDetails.user + ";" +
                "Password=" + ConnectionDetails.password + ";" +
                "Database=" + ConnectionDetails.database + ";"
            );
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba adatbázishoz csatlakozás közben! " + ex.Message);
                Application.Exit();
            }
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
            buttonSqlOk.Text = "Töltés...";
            buttonSqlOk.Enabled = false;
            await Task.Run(() =>
            {
                foreach (Query q in checkedQueries)
                {
                    List<Location> location = new List<Location>();
                    try
                    {
                        location = sqlReader.readLocations(q.sql, textBoxQueryVariables.Text);
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Hiba történt a lekérdezés közben: " + ex.Message);
                    }
                    routes.Add(new Route
                    {
                        name = q.name,
                        query = new Query { name = q.name, description = q.description, sql = q.sql, color = q.color },
                        locations = location
                    });
                    rowCount += location.Count;
                }
            });

            tabControlTables.TabPages.Clear();

            foreach (Route r in routes)
            {
                DataGridView dataGridView = new DataGridView();
                BindingSource source = new BindingSource();
                dataGridView.DataSource = source;
                dataGridView.Dock = DockStyle.Fill;
                dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
                dataGridView.CellClick += new DataGridViewCellEventHandler(this.dataGrid_CellClick);
                dataGrids.Add(dataGridView);
                TabPage tabPage = new TabPage(r.name);
                tabPage.Controls.Add(dataGridView);
                tabControlTables.TabPages.Add(tabPage);

                foreach (Location l in r.locations)
                {
                    source.Add(l);
                }
            }

            labelQueryCount.Text = labelQueryCountText + rowCount.ToString();
            buttonSqlOk.Text = "Mutat";
            buttonSqlOk.Enabled = true;

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
                        if (l.accuracy > (double)numericUpDownMinAccuracy.Value) continue;
                        Marker marker = new Marker(new PointLatLng(l.lat, l.lon), m, l.id, r);
                        markerOverlay.Markers.Add(marker);
                    }
                }
            }
            else if (radioButtonLine.Checked)
            {
                foreach (Route r in this.routes)
                {
                    List<List<PointLatLng>> pointsList = new List<List<PointLatLng>>();
                    int lastUserId = 0;
                    DateTime lastTimeStamp = new DateTime();
                    List<PointLatLng> points = new List<PointLatLng>();
                    pointsList.Add(points);
                    foreach (Location l in r.locations)
                    {
                        if (l.accuracy > (double)numericUpDownMinAccuracy.Value) continue;
                        TimeSpan ts = Convert.ToDateTime(l.ts) - lastTimeStamp;
                        if (ts.TotalSeconds < 60.0 && lastUserId == l.userId)
                        {
                            points.Add(new PointLatLng(l.lat, l.lon));
                        }
                        else
                        {
                            points = new List<PointLatLng>();
                            pointsList.Add(points);
                            lastUserId = l.userId;
                        }
                        lastTimeStamp = Convert.ToDateTime(l.ts);
                    }
                    GMapRoute route;
                    foreach (List<PointLatLng> p in pointsList)
                    {
                        route = new GMapRoute(p, "myRoute");
                        route.Stroke = new Pen((Color)colorConverter.ConvertFromString(r.query.color), 2f);
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
            newQueryEditing = true;
            Random rnd = new Random();
            KnownColor[] names = (KnownColor[])Enum.GetValues(typeof(KnownColor));
            KnownColor randomColorName = names[rnd.Next(names.Length)];
            checkedListBoxQueries.Items.Add(new Query() { name = "új lekérdezés", description = "", sql = "", color = randomColorName.ToString() });
            
            this.emptyQueryPanel();
            panelSelectedQuery.Visible = true;
            textBoxQueryName.Focus();
            
            panelColorSample.BackColor = Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255));
            checkedListBoxQueries.SelectedIndex = checkedListBoxQueries.Items.Count - 1;
            checkedListBoxQueries.SetItemChecked(checkedListBoxQueries.SelectedIndex, true);
            textBoxQueryName.SelectAll();
        }

        private void buttonRemoveQuery_Click(object sender, EventArgs e)
        {
            if (checkedListBoxQueries.SelectedIndex < 0) return;
            checkedListBoxQueries.Items.Remove(checkedListBoxQueries.Items[checkedListBoxQueries.SelectedIndex]);
            this.emptyQueryPanel();
            panelSelectedQuery.Visible = false;
        }

        private void buttonDeleteQuery_Click(object sender, EventArgs e)
        {
            if (checkedListBoxQueries.Items.Count == 0) return;
            if (MessageBox.Show("Biztosan törli az összes lekérdezést?", "Összes lekérdezés törlése", MessageBoxButtons.YesNo) == DialogResult.No) return;
            checkedListBoxQueries.Items.Clear();
            this.emptyQueryPanel();
            textBoxQueryVariables.Text = "";
            panelSelectedQuery.Visible = false;
        }

        private void buttonNewQueryOk_Click(object sender, EventArgs e)
        {
            if (textBoxQueryName.Text == "" || textBoxQuerySql.Text == "")
            {
                MessageBox.Show("A \"név és \"SQL mezők kitöltése kötelező!");
                return;
            }

            if (newQueryEditing)
            {
                foreach (Query q in checkedListBoxQueries.Items)
                {
                    if (q.name == textBoxQueryName.Text)
                    {
                        MessageBox.Show("Már létezik lekérdezés ilyen névvel: " + textBoxQueryName.Text);
                        return;
                    }
                }
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
            newQueryEditing = false;
        }

        private void buttonNewQueryCancel_Click(object sender, EventArgs e)
        {
            this.emptyQueryPanel();
            panelSelectedQuery.Visible = false;
            checkedListBoxQueries.SelectedIndex = -1;
            newQueryEditing = false;
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
            bool originalChecked = checkedListBoxQueries.GetItemChecked(selectedIndex);
            checkedListBoxQueries.SetItemChecked(selectedIndex, checkedListBoxQueries.GetItemChecked(selectedIndex + changeIndex));
            checkedListBoxQueries.SetItemChecked(selectedIndex + changeIndex, originalChecked);
        }

        private void toolStripMenuItemLoad_Click(object sender, EventArgs e)
        {
            if (0 < checkedListBoxQueries.Items.Count)
                if (MessageBox.Show("A nem mentett változtatások elvesznek. Biztosan folytatja?", "A nem mentett változtatások elvesznek", MessageBoxButtons.YesNo) == DialogResult.No) return;
            openFileDialogXml.ShowDialog();
            if (openFileDialogXml.FileName != "")
            {
                XmlSerializer reader = new XmlSerializer(typeof(SaveData));
                StreamReader file = new StreamReader(openFileDialogXml.FileName);
                SaveData loadedData = new SaveData();
                try
                {
                    loadedData = (SaveData)reader.Deserialize(file);
                }
                catch (InvalidOperationException ex)
                {
                    MessageBox.Show("Hiba a fájl megnyitásakor: " + ex.Message);
                    return;
                }

                checkedListBoxQueries.Items.Clear();

                foreach (Query q in loadedData.queries)
                {
                    checkedListBoxQueries.Items.Add(q, true);
                }

                textBoxQueryVariables.Text = loadedData.variables;

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
                XmlSerializer writer = new XmlSerializer(typeof(SaveData));
                SaveData saveData = new SaveData(){
                    queries = checkedListBoxQueries.Items.Cast<Query>().ToList(),
                    variables = textBoxQueryVariables.Text
                };
                writer.Serialize(fs, saveData);
                fs.Close();
            }
        }

        private void myMap_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            Marker marker = item as Marker;
            foreach (DataGridView dw in dataGrids)
            {
                foreach (DataGridViewRow r in dw.Rows)
                {
                    if (r.Cells[0].Value != null && r.Cells[0].Value.ToString() == marker.id.ToString())
                    {
                        dw.ClearSelection();
                        r.Selected = true;
                        dw.FirstDisplayedScrollingRowIndex = dw.SelectedRows[0].Index;
                        foreach (TabPage tp in this.tabControlTables.TabPages)
                        {
                            if (tp.Text == marker.route.name) this.tabControlTables.SelectedTab = tp;
                        }
                    }
                }
            }
        }

        private void dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dw = sender as DataGridView;
            String id = dw.SelectedRows[0].Cells[0].Value.ToString();
            Marker marker = null;
            foreach (Marker m in markerOverlay.Markers)
            {
                if (m.id.ToString() == id)
                {
                    marker = m;
                    break;
                } 
            }
            if (marker == null) return;
            this.myMap.Position = marker.Position;
        }

        private void beállításokToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripMenuItemSettings_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Itt lehet, hogy nem is lesz Beállítások menüpont...");
            return;

            FormSettings formSettings = new FormSettings(false);
            formSettings.Show();
        }

        private void toolStripMenuItemAbout_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void toolStripMenuItemHelp_Click(object sender, EventArgs e)
        {
            FormHelp formHelp = new FormHelp();
            formHelp.ShowDialog();
        }
    }
}

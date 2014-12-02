using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RouteLineUI.Classes;

namespace RouteLineUI
{
    public partial class FormSettings : Form
    {
        private KeyValueConfigurationCollection settings;
        private Configuration config;
        private bool mustFill;

        public FormSettings(bool mustFill)
        {
            this.mustFill = mustFill;
            InitializeComponent();
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {
            config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            this.settings = config.AppSettings.Settings;
            string[] settingKeys = settings.AllKeys;

            if (settingKeys.Contains("server"))   textBoxServer.Text = settings["server"].Value;
            else                                  textBoxServer.Text = "csabavm";

            if (settingKeys.Contains("port"))     textBoxPort.Text = settings["port"].Value;
            else                                  textBoxPort.Text = "5432";

            if (settingKeys.Contains("user_id"))  textBoxUserId.Text = settings["user_id"].Value;
            else                                  textBoxUserId.Text = "postgres";

            if (settingKeys.Contains("password"))
            {
                textBoxPassword.Text = settings["password"].Value;
                checkBoxRememberPassword.Checked = true;
            }

            if (settingKeys.Contains("database"))
            {
                textBoxDatabase.Text = settings["database"].Value;
                textBoxPassword.Focus();
            }

        }

        private void buttonOkSettings_Click(object sender, EventArgs e)
        {
            if (textBoxServer.Text      == "" ||
                textBoxPort.Text        == "" ||
                textBoxUserId.Text      == "" ||
                textBoxDatabase.Text    == "")
            {
                MessageBox.Show("Hiba: nincs minden kötelező mező kitöltve!");
                return;
            }

            settings.Remove("server");
            settings.Remove("port");
            settings.Remove("user_id");
            settings.Remove("password");
            settings.Remove("database");

            settings.Add("server", textBoxServer.Text);
            settings.Add("port", textBoxPort.Text);
            settings.Add("user_id", textBoxUserId.Text);
            settings.Add("database", textBoxDatabase.Text);

            if (checkBoxRememberPassword.Checked) settings.Add("password", textBoxPassword.Text);

            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");

            ConnectionDetails.server = textBoxServer.Text;
            ConnectionDetails.port = textBoxPort.Text;
            ConnectionDetails.database = textBoxDatabase.Text;
            ConnectionDetails.user = textBoxUserId.Text;
            ConnectionDetails.password = textBoxPassword.Text;

            if (mustFill)
            {
                Form1 mainForm = new Form1();
                mainForm.Show();
                this.Owner = mainForm;
                this.Hide();
            }
            else
            {
                this.Close();
            }
        }

        private void buttonCancelSettings_Click(object sender, EventArgs e)
        {
            if (this.mustFill)
            {
                Application.Exit();
            }
            else
            {
                this.Close();
            }
        }
    }
}

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

            if (settingKeys.Contains("server")) textBoxServer.Text = settings["server"].Value;
            if (settingKeys.Contains("port")) textBoxPort.Text = settings["port"].Value;
            if (settingKeys.Contains("user_id")) textBoxUserId.Text = settings["user_id"].Value;
            if (settingKeys.Contains("password")) textBoxPassword.Text = settings["password"].Value;
            if (settingKeys.Contains("database")) textBoxDatabase.Text = settings["database"].Value;
        }

        private void buttonOkSettings_Click(object sender, EventArgs e)
        {
            if (textBoxServer.Text      == "" ||
                textBoxPort.Text        == "" ||
                textBoxUserId.Text      == "" ||
                textBoxPassword.Text    == "" ||
                textBoxDatabase.Text    == "")
            {
                MessageBox.Show("Minden mezőt ki kell tölteni!");
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
            settings.Add("password", textBoxPassword.Text);
            settings.Add("database", textBoxDatabase.Text);

            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");

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

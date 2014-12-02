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
    public partial class FormAuth : Form
    {
        public FormAuth()
        {
            InitializeComponent();
        }

        private void FormAuth_Load(object sender, EventArgs e)
        {
        }

        private void buttonCodeOk_Click(object sender, EventArgs e)
        {
            if (textBoxInstallCode.Text != "?s77=mGV")
            {
                MessageBox.Show("Hibás telepítési kód!");
                return;
            }

            if(textBoxLicenseCode.Text != "9790")
            {
                MessageBox.Show("Hibás licenc kód!");
                return;
            }

            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings.Add("registered", "true");
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");

            FormSettings formSettings = new FormSettings(true);
            formSettings.Show();
            this.Owner = formSettings;
            this.Hide();
        }
    }
}

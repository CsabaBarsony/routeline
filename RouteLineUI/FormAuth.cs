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
            if (textBoxCode.Text != "asdf")
            {
                MessageBox.Show("Hibás telepítési kód!");
                return;
            }

            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings.Add("registered", "true");
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");

            Form1 mainForm = new Form1();
            mainForm.Show();
            this.Owner = mainForm;
            this.Hide();
        }
    }
}

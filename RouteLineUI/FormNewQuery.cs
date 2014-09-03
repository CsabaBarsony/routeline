using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using RouteLineUI.Classes;

namespace RouteLineUI
{
    public partial class FormNewQuery : Form
    {
        public FormNewQuery()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text == "" || textBoxDescription.Text == "" || textBoxSql.Text == "")
            {
                MessageBox.Show("Minden mezőt ki kell tölteni!");
                return;
            }
            saveFileDialogXml.ShowDialog();

            if (saveFileDialogXml.FileName != "")
            {
                Query newQuery = new Query { name = textBoxName.Text, description = textBoxDescription.Text, sql = textBoxSql.Text };
                FileStream fs = (FileStream)saveFileDialogXml.OpenFile();
                XmlSerializer writer = new XmlSerializer(typeof(Query));
                writer.Serialize(fs, newQuery);

                fs.Close();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

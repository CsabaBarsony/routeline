using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RouteLineUI
{
    public partial class FormManageSql : Form
    {
        private List<SqlCommand> commandList = new List<SqlCommand>();

        public FormManageSql()
        {
            InitializeComponent();
        }

        private void FormManageSql_Load(object sender, EventArgs e)
        {
            SqlCommand c1 = new SqlCommand();
            c1.Name = "lekérdezés 1";
            c1.Sql = "SELECT * FROM taxi_rides";
            SqlCommand c2 = new SqlCommand();
            c2.Name = "lekérdezés 2";
            c2.Sql = "SELECT * FROM users";
            commandList.Add(c1);
            commandList.Add(c2);

            this.refreshListBox();
        }

        private void listBoxNameList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxNameList.SelectedItem == null) return;
            SqlCommand command = (SqlCommand)commandList.Single(z => z.Name == listBoxNameList.SelectedItem.ToString());
            textBoxName.Text = command.Name;
            textBoxSql.Text = command.Sql;
        }

        private void buttonNewCommand_Click(object sender, EventArgs e)
        {
            textBoxName.Text = "";
            textBoxName.Focus();
            textBoxSql.Text = "";
            listBoxNameList.ClearSelected();
        }

        private void buttonSaveCommand_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text == "" || textBoxSql.Text == "")
            {
                MessageBox.Show("Név vagy SQL mező üres!");
                return;
            }

            int commandIndex = commandList.FindIndex(c => c.Name == textBoxName.Text);

            if (commandIndex >= 0)
            {
                commandList[commandIndex].Sql = textBoxSql.Text;
            }
            else
            {
                SqlCommand newCommand = new SqlCommand { Name = textBoxName.Text, Sql = textBoxSql.Text };
                commandList.Add(newCommand);
            }
            
            this.refreshListBox();
        }

        private void buttonDeleteCommand_Click(object sender, EventArgs e)
        {
            if (listBoxNameList.SelectedItem == null) return;
            var confirmResult = MessageBox.Show("Biztosan törli a lekérdezést?", "Törlés", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                SqlCommand command = (SqlCommand)commandList.Single(z => z.Name == listBoxNameList.SelectedItem.ToString());
                commandList.Remove(command);
                this.refreshListBox();
            }
        }

        private void refreshListBox()
        {
            listBoxNameList.Items.Clear();

            foreach (SqlCommand c in commandList)
            {
                listBoxNameList.Items.Add(c.Name);
            }
        }
    }

    [Serializable]
    public class SqlCommand : ISerializable
    {
        public String Name { get; set; }
        public String Sql { get; set; }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }
    }
}

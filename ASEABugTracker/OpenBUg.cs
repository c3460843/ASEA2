using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASEABugTracker
{
    public partial class OpenBug : Form
    {
        SqlConnection obConnection;
        public static string sessionOpenBug;

        public OpenBug()
        {
            InitializeComponent();
            populateOpenList();
        }

        private void populateOpenList()
        {
            obConnection = new SqlConnection
                (@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 
                C:\Users\Admin\Documents\ASEABugTrackDB.mdf;");

            String selcmd = "SELECT BugId, Application, Username FROM BugTable";

            SqlCommand mySqlCommand = new SqlCommand(selcmd, obConnection);

            try
            {
                obConnection.Open();

                SqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();

                listBoxOpen.Items.Clear();

                while (mySqlDataReader.Read())
                {

                    listBoxOpen.Items.Add(mySqlDataReader["BugId"] + "." + mySqlDataReader["Application"] + "." + mySqlDataReader["Username"]); 
                }
            }

            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            obConnection.Close();
            String selectedItem = listBoxOpen.SelectedItem.ToString();
            String[] seletectItemArray = selectedItem.Split('.');
            sessionOpenBug = seletectItemArray[0];
            this.Hide();
            Main.ActiveForm.Hide();
            Main session = new Main();
            session.Show();

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            obConnection.Close();
            this.Hide();
        }
    }
}

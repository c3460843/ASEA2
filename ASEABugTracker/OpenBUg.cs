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

            String selcmd="";

            int caseSwitch=1;                                                                                                                      //001
            if (!checkBoxDisplayOwn.Checked && !checkBoxDisplayUnfixed.Checked && comboBoxLanguage.Text != "All Languages") { caseSwitch = 2; };   //000
            if (!checkBoxDisplayOwn.Checked &&  checkBoxDisplayUnfixed.Checked && comboBoxLanguage.Text != "All Languages") { caseSwitch = 3; };   //010
            if (!checkBoxDisplayOwn.Checked &&  checkBoxDisplayUnfixed.Checked && comboBoxLanguage.Text == "All Languages") { caseSwitch = 4; };   //011
            if ( checkBoxDisplayOwn.Checked && !checkBoxDisplayUnfixed.Checked && comboBoxLanguage.Text != "All Languages") { caseSwitch = 5; };   //100
            if ( checkBoxDisplayOwn.Checked && !checkBoxDisplayUnfixed.Checked && comboBoxLanguage.Text == "All Languages") { caseSwitch = 6; };   //101
            if ( checkBoxDisplayOwn.Checked &&  checkBoxDisplayUnfixed.Checked && comboBoxLanguage.Text != "All Languages") { caseSwitch = 7; };   //110
            if ( checkBoxDisplayOwn.Checked &&  checkBoxDisplayUnfixed.Checked && comboBoxLanguage.Text == "All Languages") { caseSwitch = 8; };   //111
           
            switch (caseSwitch)
            {
                case 1:
                    selcmd = "SELECT BugId, Application, Username, Language, Fixed FROM BugTable";
                    break;
                case 2:
                    selcmd = "SELECT BugId, Application, Username, Language, Fixed FROM BugTable WHERE Language = '" +comboBoxLanguage.Text +"'";
                    break;
                case 3:
                    selcmd = "SELECT BugId, Application, Username, Language, Fixed FROM BugTable WHERE Fixed = 0 AND Language = '" +comboBoxLanguage.Text + "'";
                    break;
                case 4:
                    selcmd = "SELECT BugId, Application, Username, Language, Fixed FROM BugTable WHERE Fixed = 0";
                    break;
                case 5:
                    selcmd = "SELECT BugId, Application, Username, Language, Fixed FROM BugTable WHERE Username = '" + Login.sessionUsername + "' AND Language = '" + comboBoxLanguage.Text + "'";
                    break;
                case 6:
                    selcmd = "SELECT BugId, Application, Username, Language, Fixed FROM BugTable WHERE Username = '" + Login.sessionUsername + "'";
                    break;
                case 7:
                    selcmd = "SELECT BugId, Application, Username, Language, Fixed FROM BugTable WHERE Fixed = 0 AND Username = '" + Login.sessionUsername +"' AND Language = '" +comboBoxLanguage.Text + "'";
                    break;
                case 8:
                    selcmd = "SELECT BugId, Application, Username, Language, Fixed FROM BugTable WHERE Fixed = 0 AND Username = '" + Login.sessionUsername + "'";
                    break;
            }

            

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

        private void checkBoxDisplayOwn_CheckedChanged(object sender, EventArgs e)
        {
            populateOpenList();
        }

        private void checkBoxDisplayUnfixed_CheckedChanged(object sender, EventArgs e)
        {
            populateOpenList();
        }

        private void comboBoxLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            populateOpenList();
        }
    }
}

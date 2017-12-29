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
    public partial class NewBugForm : Form
    {
        SqlConnection newBugConnection;

        public NewBugForm()
        {
            InitializeComponent();
            txtAuthorNew.Text = Login.sessionUsername;
        }

        public void insertBugRecord(String application, String symptom, String cause, String tclass, String method, String code, String linenostart, String linenoend, String language, String commandString)
        {

            try
            {
                newBugConnection = new SqlConnection
                (@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 
                C:\Users\Admin\Documents\ASEABugTrackDB.mdf;");
                newBugConnection.Open();
                SqlCommand cmdInsert = new SqlCommand(commandString, newBugConnection);
                cmdInsert.Parameters.AddWithValue("@Username", Login.sessionUsername);
                cmdInsert.Parameters.AddWithValue("@Application", application);
                cmdInsert.Parameters.AddWithValue("@Symptom", symptom);
                cmdInsert.Parameters.AddWithValue("@Cause", cause);
                cmdInsert.Parameters.AddWithValue("@Class", tclass);
                cmdInsert.Parameters.AddWithValue("@Method", method);
                cmdInsert.Parameters.AddWithValue("@Code", code);
                cmdInsert.Parameters.AddWithValue("@LineNoStart", linenostart);
                cmdInsert.Parameters.AddWithValue("@LineEndStart", linenoend);
                cmdInsert.Parameters.AddWithValue("@Language", language);
                cmdInsert.ExecuteNonQuery();
                this.Hide();
                MessageBox.Show(application + " bug submitted successfully.");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(application + " .." + ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void insertVerRecord(String isfixedbool, String sqlFormatDateTimeNow, String alteredcode, String username, int bugid, String entryno, String commandString)
        {
            try
            {
                newBugConnection = new SqlConnection
                (@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 
                C:\Users\Admin\Documents\ASEABugTrackDB.mdf;");
                newBugConnection.Open();
                SqlCommand cmdInsert = new SqlCommand(commandString, newBugConnection);
                cmdInsert.Parameters.AddWithValue("@Fixed", isfixedbool);
                cmdInsert.Parameters.AddWithValue("@EntryDateTime", sqlFormatDateTimeNow);
                cmdInsert.Parameters.AddWithValue("@AlteredCode", alteredcode);
                cmdInsert.Parameters.AddWithValue("@Username", username);
                cmdInsert.Parameters.AddWithValue("@BugId", bugid);
                cmdInsert.Parameters.AddWithValue("@EntryNo", entryno);
                cmdInsert.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(bugid + "." + entryno + " .." + ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool checkInputs()
        {
            bool rtnvalue = true;

            if (
                string.IsNullOrEmpty(txtApplicationNew.Text) ||
                string.IsNullOrEmpty(txtSymptomNew.Text) ||
                string.IsNullOrEmpty(txtCauseNew.Text) ||
                string.IsNullOrEmpty(txtClassNew.Text) ||
                string.IsNullOrEmpty(txtMethodNew.Text) ||
                string.IsNullOrEmpty(txtCodeNew.Text) ||
                string.IsNullOrEmpty(txtLineNoStartNew.Text) ||
                string.IsNullOrEmpty(txtLineNoEndNew.Text) ||
                comboBoxLanguage == null)
            {
                MessageBox.Show("Error: Please check your inputs");
                rtnvalue = false;
            }

            return (rtnvalue);
        }

        private void buttonNewBug_Click(object sender, EventArgs e)
        {
            if (checkInputs())
            {
                String bugCommandString = "INSERT INTO BugTable(Username, Application, Symptom, Cause, Class, Method, CodeBlock, LineNoStart, LineNoEnd, Language) VALUES (@Username, @Application, @Symptom, @Cause, @Class, @Method, @Code, @LineNoStart, @LineEndStart, @Language)";
                insertBugRecord(txtApplicationNew.Text, txtSymptomNew.Text, txtCauseNew.Text, txtClassNew.Text, txtMethodNew.Text, txtCodeNew.Text, txtLineNoStartNew.Text, txtLineNoEndNew.Text, comboBoxLanguage.SelectedItem.ToString(), bugCommandString);
                

                String selBugIdCommand = "SELECT TOP 1 BugId FROM BugTable WHERE Username = '" + Login.sessionUsername +"' ORDER BY BugId DESC";
                SqlCommand sqlBugIdCommand = new SqlCommand(selBugIdCommand, newBugConnection);

                SqlDataReader bugIdSqlDataReader = sqlBugIdCommand.ExecuteReader();

                int bugId =0;
                while (bugIdSqlDataReader.Read())
                {
                    bugId = bugIdSqlDataReader.GetInt32(0);
                }

                bugIdSqlDataReader.Close();
                            
                String verCommandString = "INSERT INTO VersionTable(Fixed, EntryDateTime, AlteredCode, Username, BugId, EntryNo) VALUES (@Fixed, @EntryDateTime, @AlteredCode, @Username, @BugId, @EntryNo)";
                insertVerRecord("0", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff"), txtCodeNew.Text, Login.sessionUsername, bugId, "0", verCommandString);
                newBugConnection.Close();
                this.Close();
            }  
        }

        private void buttonNBCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;
using ICSharpCode.TextEditor.Document;

namespace ASEABugTracker
{
    public partial class Main : Form
    {
        SqlConnection mainConnection;
        String language;

        public Main()
        {
            InitializeComponent();
            Session();   
        }

        public void Session()
        {
            txtUsername.Text = Login.sessionUsername;
            txtBugId.Text = OpenBug.sessionOpenBug;
            buttonFix.Enabled = false;
            submitAuditToolStripMenuItem.Enabled = false;
            if (txtBugId.Text != "")
            {
                Populate();
                submitAuditToolStripMenuItem.Enabled = true;
            }
        }
        

        public void Populate()
        {
            mainConnection = new SqlConnection
                (@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 
                C:\Users\Admin\Documents\ASEABugTrackDB.mdf;");
            String selBugCommand = "SELECT Username, Application, Symptom, Cause, Class, Method, CodeBlock, LineNoStart, LineNoEnd, Language, Fixed FROM BugTable WHERE BugId = " + txtBugId.Text;
            SqlCommand sqlBugCommand = new SqlCommand(selBugCommand, mainConnection);

            String selVerCommand = "SELECT EntryNo, Username, EntryDateTime FROM VersionTable WHERE BugId = " + txtBugId.Text;
            SqlCommand sqlVerCommand = new SqlCommand(selVerCommand, mainConnection);

            try
            {
                mainConnection.Open();

                SqlDataReader bugSqlDataReader = sqlBugCommand.ExecuteReader();
                
                while (bugSqlDataReader.Read())
                {
                    if (bugSqlDataReader.GetString(0) == Login.sessionUsername) { submitAuditToolStripMenuItem.Enabled = true; buttonFix.Enabled = true; }
                    txtApplication.Text = bugSqlDataReader.GetString(1);
                    txtSymptom.Text = bugSqlDataReader.GetString(2);
                    txtCause.Text = bugSqlDataReader.GetString(3);
                    txtClass.Text = bugSqlDataReader.GetString(4);
                    txtMethod.Text = bugSqlDataReader.GetString(5);
                    txtCode.Text = bugSqlDataReader.GetString(6);
                    txtLineNoStart.Text = bugSqlDataReader.GetInt32(7).ToString();
                    txtLineNoEnd.Text = bugSqlDataReader.GetInt32(8).ToString();
                    txtLanguage.Text = bugSqlDataReader.GetString(9);
                    if (bugSqlDataReader.GetBoolean(10) == false) { labelFix.Text = "Unfixed"; }
                    else { labelFix.Text = "Fixed"; submitAuditToolStripMenuItem.Enabled = true; }
                }

                bugSqlDataReader.Close();

                SqlDataReader verSqlDataReader = sqlVerCommand.ExecuteReader();
                listBoxInput.Items.Clear();

                while (verSqlDataReader.Read())
                {
                    if (verSqlDataReader.GetInt32(0)==0) { listBoxInput.Items.Add("[source_code] created by " + verSqlDataReader["Username"] + " on " + verSqlDataReader["EntryDateTime"]);}
                    else {listBoxInput.Items.Add("[" + txtBugId.Text + "." + verSqlDataReader["EntryNo"] + "] created by " + verSqlDataReader["Username"] + " on " + verSqlDataReader["EntryDateTime"]);}                   
                }
                verSqlDataReader.Close();
            }

            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
 
        public bool CheckInput()
        {
            bool rtnvalue = true;

            if (string.IsNullOrEmpty(txtCode.Text))

            {
                MessageBox.Show("Error: code block empty.");
                rtnvalue = false;
            }

            return (rtnvalue);

        }


        public void InsertRecord(String sqlFormatDateTimeNow, String alteredcode, String username, String bugid, String entryno, String commandString)
        {
            try
            {
                mainConnection = new SqlConnection
                (@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 
                C:\Users\Admin\Documents\ASEABugTrackDB.mdf;");
                mainConnection.Open();
                SqlCommand cmdInsert = new SqlCommand(commandString, mainConnection);
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

        
        public void InsertFixRecord(bool fixBool, String commandFixed)
        {
            try
            {
                mainConnection = new SqlConnection
                (@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 
                C:\Users\Admin\Documents\ASEABugTrackDB.mdf;");
                mainConnection.Open();
                SqlCommand cmdFixed = new SqlCommand(commandFixed, mainConnection);
                cmdFixed.Parameters.AddWithValue("@Fixed", fixBool);
                cmdFixed.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(fixBool + "." + " .." + ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        

        private void txtCode_Load(object sender, EventArgs e)
        {
            language = txtLanguage.Text;
            String dir = Application.StartupPath;
            FileSyntaxModeProvider fsmp;
            if (Directory.Exists(dir))
            {
                fsmp = new FileSyntaxModeProvider(dir);
                HighlightingManager.Manager.AddSyntaxModeFileProvider(fsmp);
                txtCode.SetHighlighting(language);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
            Environment.Exit(1);
        }

            private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewBugForm nbf = new NewBugForm();
            nbf.Show();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenBug ob = new OpenBug();
            ob.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Login session = new Login();
            OpenBug.sessionOpenBug = "";
            session.Show();

        }

        private void listBoxInput_SelectedIndexChanged(object sender, EventArgs e)
        {
            mainConnection = new SqlConnection
                (@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 
                C:\Users\Admin\Documents\ASEABugTrackDB.mdf;");
            String selCodeCommand = "SELECT AlteredCode FROM VersionTable WHERE EntryNo = " + listBoxInput.SelectedIndex + "AND BugId =" + OpenBug.sessionOpenBug;
            SqlCommand sqlCodeCommand = new SqlCommand(selCodeCommand, mainConnection);

            try
            {
                mainConnection.Open();

                SqlDataReader codeSqlDataReader = sqlCodeCommand.ExecuteReader();

                while (codeSqlDataReader.Read())
                {
                    txtCode.Text = codeSqlDataReader.GetString(0);
                }

                codeSqlDataReader.Close();
            }

            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            txtCode_Load(null,e);
        }

        private void submitAuditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CheckInput())
            {

                String commandString = "INSERT INTO VersionTable(EntryDateTime, AlteredCode, Username, BugId, EntryNo) VALUES (@EntryDateTime, @AlteredCode, @Username, @BugId, @EntryNo)";

                InsertRecord(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff"), txtCode.Text, Login.sessionUsername, txtBugId.Text, listBoxInput.Items.Count.ToString(), commandString);
                Populate();
            }
        }

        private void buttonFix_Click(object sender, EventArgs e)
        {
            if (labelFix.Text == "Unfixed")
            {
                DialogResult dialogResult = MessageBox.Show("Is the bug fixed so no more alteration submissions may be made?", "Change Bug's Unfixed Status", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    submitAuditToolStripMenuItem.Enabled = false;
                    String commandFixed = "UPDATE BugTable SET Fixed = 1 WHERE BugId = " + txtBugId.Text;
                    InsertFixRecord(true, commandFixed);
                    labelFix.Text = "Fixed";
                }
                else if (dialogResult == DialogResult.No)
                {
                }
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Would you like to reopen the bug so alteration submissions may be made?", "Change Bug's Fixed Status", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    submitAuditToolStripMenuItem.Enabled = true;
                    String commandFixed = "UPDATE BugTable SET Fixed = 0 WHERE BugId = " + txtBugId.Text;
                    InsertFixRecord(false, commandFixed);
                    labelFix.Text = "Unfixed";
                }
                else if (dialogResult == DialogResult.No)
                {
                }
            }
        }
    }
}

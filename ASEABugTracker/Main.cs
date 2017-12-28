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

        public Main()
        {
            InitializeComponent();
            txtUsername.Text = Login.sessionUsername;
            txtBugId.Text = OpenBug.sessionOpenBug;
            if (txtBugId.Text != "")
            {
                populate();
            }
        }

        

        public void populate()
        {

            mainConnection = new SqlConnection
                (@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 
                C:\Users\Admin\Documents\ASEABugTrackDB.mdf;");
            String selBugCommand = "SELECT Username, Application, Symptom, Cause, Class, Method, CodeBlock, LineNoStart, LineNoEnd FROM BugTable WHERE BugId = " + txtBugId.Text;
            SqlCommand sqlBugCommand = new SqlCommand(selBugCommand, mainConnection);

            String selVerCommand = "SELECT EntryNo, Username FROM VersionTable WHERE BugId = " + txtBugId.Text;
            SqlCommand sqlVerCommand = new SqlCommand(selVerCommand, mainConnection);
            

            try
            {
                mainConnection.Open();

                SqlDataReader bugSqlDataReader = sqlBugCommand.ExecuteReader();
                
                while (bugSqlDataReader.Read())
                {
                    txtUsername.Text = bugSqlDataReader.GetString(0);
                    txtApplication.Text = bugSqlDataReader.GetString(1);
                    txtSymptom.Text = bugSqlDataReader.GetString(2);
                    txtCause.Text = bugSqlDataReader.GetString(3);
                    txtClass.Text = bugSqlDataReader.GetString(4);
                    txtMethod.Text = bugSqlDataReader.GetString(5);
                    txtCode.Text = bugSqlDataReader.GetString(6);
                    txtLineNoStart.Text = bugSqlDataReader.GetInt32(7).ToString();
                    txtLineNoEnd.Text = bugSqlDataReader.GetInt32(8).ToString();
                }

                bugSqlDataReader.Close();

                SqlDataReader verSqlDataReader = sqlVerCommand.ExecuteReader();
                listBoxInput.Items.Clear();

                while (verSqlDataReader.Read())
                {

                    listBoxInput.Items.Add(verSqlDataReader["EntryNo"] + " " + verSqlDataReader["Username"]);

                }
                verSqlDataReader.Close();
            }

            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }



        public void cleartxtBoxes()
        {
            txtBugId.Text = txtApplication.Text = txtSymptom.Text = txtCause.Text = txtClass.Text = txtMethod.Text = txtCode.Text = txtLineNoStart.Text = txtLineNoEnd.Text = "";
        }
 
        public bool checkInputs()
        {
            bool rtnvalue = true;

            if (
                string.IsNullOrEmpty(txtCode.Text) ||
                string.IsNullOrEmpty(txtLineNoStart.Text) ||
                string.IsNullOrEmpty(txtLineNoEnd.Text))
            {
                MessageBox.Show("Error: code block empty.");
                rtnvalue = false;
            }

            return (rtnvalue);

        }


        public void insertRecord(String isfixedbool, String entrydatetime, String alteredcode, String username, String bugid, String entryno, String commandString)
        {
            try
            {
                mainConnection = new SqlConnection
                (@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 
                C:\Users\Admin\Documents\ASEABugTrackDB.mdf;");
                mainConnection.Open();
                SqlCommand cmdInsert = new SqlCommand(commandString, mainConnection);
                cmdInsert.Parameters.AddWithValue("@Fixed", isfixedbool);
                cmdInsert.Parameters.AddWithValue("@EntryDateTime", entrydatetime);
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkInputs())
            {

                String commandString = "INSERT INTO VersionTable(Fixed, EntryDateTime, AlteredCode, Username, BugId, EntryNo) VALUES (@VersionId, @Fixed, @EntryDateTime, @AlteredCode, @Username, @BugId, @EntryNo)";

                insertRecord("", "", txtCode.Text, Login.sessionUsername, txtBugId.Text, listBoxInput.Items.Count + 1.ToString(), commandString);
                populate();
                //cleartxtBoxes();
            }

        }



        private void txtCode_Load(object sender, EventArgs e)
        {
            String language = "C#";
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

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}

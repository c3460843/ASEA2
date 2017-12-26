using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;
using ICSharpCode.TextEditor.Document;

namespace ASEABugTracker
{
    public partial class Form1 : Form
    {
        SqlConnection mySqlConnection;
        
        public Form1()
        {
            InitializeComponent();
            populateListBox();
        }

        public void populateListBox()
        {
            mySqlConnection = new SqlConnection
                (@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 
                C:\Users\Admin\Documents\ASEABugTrackDB.mdf;");

            String selcmd = "SELECT BugID, Author, Application, Symptom, Cause, Class, Method, CodeBlock, LineNoStart, LineNoEnd  FROM BugTable ORDER BY BugID";

            SqlCommand mySqlCommand = new SqlCommand(selcmd, mySqlConnection);

            try
            {
                mySqlConnection.Open();

                Console.WriteLine("connection open");

                SqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();

                listBoxInput.Items.Clear();

                while (mySqlDataReader.Read())
                {

                    listBoxInput.Items.Add(mySqlDataReader["BugID"] + " " +
                           mySqlDataReader["Author"] + mySqlDataReader["Application"] + mySqlDataReader["Symptom"] + mySqlDataReader["Cause"] + mySqlDataReader["Class"]
                           + mySqlDataReader["Method"] + mySqlDataReader["CodeBlock"] +mySqlDataReader["LineNoStart"] +mySqlDataReader["LineNoEnd"]);

                }
            }

            catch (SqlException ex)
            {

                MessageBox.Show("ID?" + " .." + ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }



        public void cleartxtBoxes()
        {
            txtBugId.Text = txtAuthor.Text = txtApplication.Text = txtSymptom.Text = txtCause.Text = txtClass.Text = txtMethod.Text = txtCode.Text = txtLineNoStart.Text = txtLineNoEnd.Text = "";
        }

        public bool checkInputs()
        {
            bool rtnvalue = true;

            if (
                string.IsNullOrEmpty(txtAuthor.Text) ||
                string.IsNullOrEmpty(txtApplication.Text) ||
                string.IsNullOrEmpty(txtSymptom.Text) ||
                string.IsNullOrEmpty(txtCause.Text) ||
                string.IsNullOrEmpty(txtClass.Text) ||
                string.IsNullOrEmpty(txtMethod.Text) ||
                string.IsNullOrEmpty(txtCode.Text) ||
                string.IsNullOrEmpty(txtLineNoStart.Text) ||
                string.IsNullOrEmpty(txtLineNoEnd.Text))
            {
                MessageBox.Show("Error: Please check your inputs");
                rtnvalue = false;
            }

            return (rtnvalue);

        }


        public void insertRecord(/*String bugid,*/ String author, String application, String symptom, String cause, String tclass, String method, String code, String linenostart, String linenoend, String commandString)
        {

            try
            {
                mySqlConnection = new SqlConnection
                (@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 
                C:\Users\Admin\Documents\ASEABugTrackDB.mdf;");
                mySqlConnection.Open();
                SqlCommand cmdInsert = new SqlCommand(commandString, mySqlConnection);
                //bugid = "";
                //cmdInsert.Parameters.AddWithValue("@BugID", bugid);
                cmdInsert.Parameters.AddWithValue("@Author", author);
                cmdInsert.Parameters.AddWithValue("@Application", application);
                cmdInsert.Parameters.AddWithValue("@Symptom", symptom);
                cmdInsert.Parameters.AddWithValue("@Cause", cause);
                cmdInsert.Parameters.AddWithValue("@Class", tclass);
                cmdInsert.Parameters.AddWithValue("@Method", method);
                cmdInsert.Parameters.AddWithValue("@Code", code);
                cmdInsert.Parameters.AddWithValue("@LineNoStart", linenostart);
                cmdInsert.Parameters.AddWithValue("@LineEndStart", linenoend);
                cmdInsert.ExecuteNonQuery();
                                
            }
            catch (SqlException ex)
            {
                MessageBox.Show("ID?" + " .." + ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkInputs())
            {

                String commandString = "INSERT INTO BugTable(Author, Application, Symptom, Cause, Class, Method, CodeBlock, LineNoStart, LineNoEnd) VALUES (@Author, @Application, @Symptom, @Cause, @Class, @Method, @Code, @LineNoStart, @LineEndStart)";

                insertRecord(txtAuthor.Text, txtApplication.Text, txtSymptom.Text, txtCause.Text, txtClass.Text, txtMethod.Text, txtCode.Text, txtLineNoStart.Text, txtLineNoEnd.Text, commandString);
                populateListBox();
                cleartxtBoxes();
            }

        }

      

        private void txtCode_Load(object sender, EventArgs e)
        {
            String dir = Application.StartupPath;
            FileSyntaxModeProvider fsmp;
            if (Directory.Exists(dir))
            {
                fsmp = new FileSyntaxModeProvider(dir);
                HighlightingManager.Manager.AddSyntaxModeFileProvider(fsmp);
                txtCode.SetHighlighting("C#");
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
                
    }
}

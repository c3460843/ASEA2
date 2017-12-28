using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace ASEABugTracker
{
    public partial class Login : Form
    {
        public static string sessionUsername;

        public Login()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            SqlConnection loginConnection = new SqlConnection
                (@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 
                C:\Users\Admin\Documents\ASEABugTrackDB.mdf;");
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From UserTable where Username='" + txtLoginUsername.Text + "' and Password = '" + txtLoginPassword.Text + "'", loginConnection);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                sessionUsername = txtLoginUsername.Text;
                this.Hide();
                Main session = new Main();
                session.Show();
            }
            else
            {
                MessageBox.Show("Incorrect login details.");
            }
        }
    }
}

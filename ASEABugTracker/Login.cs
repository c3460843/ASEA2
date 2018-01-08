using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace ASEABugTracker
{
    public partial class Login : Form
    {
        /// <summary>
        ///  Used externally to identify current user.
        /// </summary>
        public static string sessionUsername;

        /// <summary>
        ///  Entry point for the <see cref="ASEABugTracker.Login"/> form.
        /// </summary>
        public Login()
        {
            InitializeComponent();
        }

        /// <summary>
        ///  Connects to the database and using <see cref="SqlDataAdapter"/>, selects the username and password that match the details entered (<see cref="txtLoginUsername"/>, 
        ///  <see cref="txtLoginPassword"/>), if 1 (correct) result is returned, this <see cref="Login"/> form is hidden and a new <see cref="Main"/> form (session) is created and displayed, 
        ///  when <see cref="buttonLogin"/> is clicked.
        /// </summary>
        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            SqlConnection loginConnection = new SqlConnection
                (@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 
                |DataDirectory|\ASEABugTrackDB.mdf;");
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

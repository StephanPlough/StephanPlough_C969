using MySql.Data.MySqlClient;
using System.Configuration;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace StephanPlough_C969
{ 
    public partial class Login : Form
    {
        public string userText = string.Empty;
        private bool clearText = true;
        public Login()
        {
            InitializeComponent();
            LanguageSettings();
        }

        private void logIn_LogInButton_Click(object sender, EventArgs e)
        {
            string constr = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
            MySqlConnection conn = new MySqlConnection(constr);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand($"SELECT userId FROM user WHERE userName = '{logIn_UserNameTextBox.Text}' AND password = '{logIn_PasswordTextBox.Text}'", conn);
            MySqlDataReader rdr = cmd.ExecuteReader();
     
           if (rdr.HasRows)
            {
                rdr.Read();
                ID.username = logIn_UserNameTextBox.Text;
                ID.UserID(Convert.ToInt32(rdr[0]));
                rdr.Close();
                conn.Close();

                this.Hide();
                Home home = new Home();
                home.Show();
            }
            else
            {
                MessageBox.Show("Username or Password is incorrect");
            }

           
        }

        private void LanguageSettings()
        {
            switch (CultureInfo.CurrentCulture.TwoLetterISOLanguageName)
            {
                case "es":
                    logIn_Label.Text = "Conferencias de Plough";
                    SpanishTextToGray();
                    break;
                case "en":
                    logIn_Label.Text = "Plough's Conferencing: Log In";
                    break;
                default:
                    MessageBox.Show("Please pick English or Spanish in your Settings.");
                    break;
            }
        }

        public void TextToGray() // For default textboxes
        {
            logIn_UserNameTextBox.Text = "Username";
            logIn_UserNameTextBox.ForeColor = System.Drawing.Color.Gray;
            logIn_PasswordTextBox.Text = "Password";
            logIn_PasswordTextBox.ForeColor = System.Drawing.Color.Gray;
        }

        public void SpanishTextToGray()
        {
            logIn_UserNameTextBox.Text = "Nombre de usuario";
            logIn_UserNameTextBox.ForeColor= System.Drawing.Color.Gray;
            logIn_PasswordTextBox.Text = "Contraseña";
            logIn_PasswordTextBox.ForeColor = System.Drawing.Color.Gray;
        }
        private void Login_Load(object sender, EventArgs e)
        {
            TextToGray();
        }
        public string usernameLabel()
        {
            var username = userText;
            return username;
        }
        private void logIn_UsernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void logIn_PasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void logIn_Label_Click(object sender, EventArgs e)
        {

        }

        private void logIn_RememberMeCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Used to test the connection to database
            this.Hide();
            databaseConnTest newTest = new databaseConnTest();
            newTest.ShowDialog();
        }

        private void logIn_UserNameTextBox_Click(object sender, EventArgs e)
        {
            logIn_UserNameTextBox.Text = "";
            logIn_UserNameTextBox.ForeColor = System.Drawing.Color.Black;
        }

        private void logIn_PasswordTextBox_Click(object sender, EventArgs e)
        {
            logIn_PasswordTextBox.Text = "";
            logIn_PasswordTextBox.ForeColor = System.Drawing.Color.Black;
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            TextToGray();
        }

        
    }
}
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace StephanPlough_C969
{
    public partial class ConsultantReport : Form
    {
        public ConsultantReport()
        {
            InitializeComponent();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void goBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string consultant = searchUserTextbox.Text.Trim();

            if (string.IsNullOrEmpty(consultant))
            {
                MessageBox.Show("Please enter a user");
            }
            LoadDataCR();

            string connectionString = ConfigurationManager.ConnectionStrings["localDb"].ConnectionString;
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            string userSql = $"SELECT userId FROM user WHERE userName = '{consultant}'";
            MySqlCommand command = new MySqlCommand(userSql, connection);
            var verification = command.ExecuteScalar();

            if (verification == null)
            {
                MessageBox.Show("User not found");
            }
            else
            {
                int id = Convert.ToInt32(verification);
                string appointmentSql = $"SELECT appointmentId, type, start, end FROM appointment WHERE userId = '{id}'";
                MySqlCommand command1 = new MySqlCommand(appointmentSql, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command1);
                DataTable userAppointments = new DataTable();
                adapter.Fill(userAppointments);
                dgvConsultantReport.DataSource = userAppointments;
            }
        }

        private void searchUserTextbox_TextChanged(object sender, EventArgs e)
        {

        }
        public void LoadDataCR()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["localDb"].ConnectionString;
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            string userSql = "SELECT * FROM user";
            MySqlCommand command = new MySqlCommand(userSql, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable fillUser = new DataTable();
            adapter.Fill(fillUser);
            dgvConsultantReport.DataSource = fillUser;
        }
        private void ConsultantReport_Load(object sender, EventArgs e)
        {
            try
            {
                LoadDataCR();
            }
            catch
            {
                MessageBox.Show("Uh oh");
            }
        }
    }
}

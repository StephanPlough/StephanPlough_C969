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
using MySql.Data.MySqlClient;

namespace StephanPlough_C969
{
    public partial class AppointmentReport : Form
    {
        private DataGridView dgv;
        public AppointmentReport()
        {
            InitializeComponent();
            dgv = new DataGridView();
        }

        private void AppointmentReport_Load(object sender, EventArgs e)
        {
            typeComboBox.Items.Add("Coffee");
            typeComboBox.Items.Add("Guerilla Testing");
            typeComboBox.Items.Add("Presentation");
            typeComboBox.Items.Add("Scrum");
        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string appointmentType = typeComboBox.Text.Trim();
            string month = textBoxMonth.Text.Trim();

            if (string.IsNullOrEmpty(appointmentType)  || string.IsNullOrEmpty(month))
            {
                MessageBox.Show("Please fill in all fields");
            }
            else
            {
            
                    string connectionString = ConfigurationManager.ConnectionStrings["localDb"].ConnectionString;
                    MySqlConnection connection = new MySqlConnection(connectionString);
                    connection.Open();

                    int searchedAmount = NumOfAppointments(connection, appointmentType, month);

                dataGridView1.Columns[0].Name = "Appointment Type";
                dataGridView1.Columns[1].Name = "Ammount";
                    dataGridView1.Rows.Add(appointmentType, searchedAmount);
                    dataGridView1.Refresh();
                
                
            }
        }

        public int NumOfAppointments(MySqlConnection connection,  string appointmentType, string month)
        {
            int monthNum = NameToNumberConversion(month);
            string appointmentCountSql = $"SELECT COUNT(*) FROM appointment WHERE type = '{appointmentType}' AND MONTH(start) = '{month}';";
            MySqlCommand command = new MySqlCommand(appointmentCountSql, connection);
            return Convert.ToInt32(command.ExecuteScalar());
        }

        public int NameToNumberConversion(string Month)
        {
            switch (Month)
            {
                case "January":
                    return 1;
                    break;
                case "Feburary":
                    return 2;
                    break;
                case "March":
                    return 3;
                    break;
                case "April":
                    return 4;
                    break;
                case "May":
                    return 5;
                    break;
                case "June":
                    return 6;
                    break;
                case "July":
                    return 7;
                    break;
                case "August":
                    return 8;
                    break;
                case "September":
                    return 9;
                    break;
                case "October":
                    return 10;
                case "November":
                    return 11;
                case "December":
                    return 12;
                    break;

            }
            return 0;
        }

    }
}

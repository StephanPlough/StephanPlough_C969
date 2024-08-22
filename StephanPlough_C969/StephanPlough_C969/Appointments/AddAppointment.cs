using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StephanPlough_C969
{
    public partial class AddAppointment : Form
    {
        public int MaxID = ID.newAppointmentID("appointmentId") + 1;

        public enum Validation
        {
            NoIssues,
            EmptyFields,
            InvalidTime,
            OutOfHoursRange,
            MultipleDays
        }
        

        public AddAppointment()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void addAppointment_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["localDb"].ConnectionString);
            connection.Open();
            DateTime appStart = DatePickerStart.Value;
            DateTime utcStart = appStart.ToUniversalTime();
            DateTime appEnd = DateTimePickerEnd.Value;
            DateTime utcEnd = appEnd.ToUniversalTime();

            string appointmentStart = appStart.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss");
            string appointmentEnd = appEnd.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss");
            string customer = comboBox2.Text;
            string customerIDsql = $"SELECT customerId FROM customer WHERE customerName = '{customer}'";
            MySqlCommand command = new MySqlCommand(customerIDsql, connection);
            int customerID = Convert.ToInt32(command.ExecuteScalar());
            string appointmentType = comboBox1.Text;
            string username = ID.username;
            int userID = ID.findUserID();
            bool Save = false;
            if (string.IsNullOrEmpty(comboBox1.Text) || string.IsNullOrEmpty(comboBox2.Text))
            {
                MessageBox.Show("Please enter all fields");
            }
            else 
            {
                switch (ValidateAppointments(appStart, appEnd))
                {
                    case Validation.InvalidTime:
                        MessageBox.Show($"Please ensure start of Appointment({MaxID}) is before the end");
                        Save = false;
                        break;
                    case Validation.OutOfHoursRange:
                        MessageBox.Show($"Please ensure Appointment({MaxID}) is within business hours.");
                        MessageBox.Show("Business Hours: 7A - 10P");
                        Save = false;
                        break;
                    case Validation.MultipleDays:
                        MessageBox.Show($"Please ensure Appointment({MaxID}) is not spanning multiple days");
                        Save = false;
                        break;
                    default:
                        Save = true;
                        break;

                }
                int overlap = AppointmentOverlap(appStart, appEnd, userID);
                if (overlap == 0)
                {
                    MessageBox.Show("Please do not book an overlapping appointment");
                    Save = false;
                }
                if (Save == true)
                {

                    string addAppointmentsql = $@"INSERT INTO appointment
                                                   (appointmentId, customerId, userId, title, description,
                                                    location, contact, type, url, start, end, createDate,
                                                    createdBy, lastUpdate, lastUpdateBy)
                                                VALUES('{MaxID}', '{customerID}', '{userID}', 'na','na','na','na', '{appointmentType}', 'na',
                                                       '{appointmentStart}', '{appointmentEnd}', NOW(), '{username}', NOW(), '{username}')";
                    MySqlCommand saveAppointment = new MySqlCommand(addAppointmentsql, connection);
                    saveAppointment.ExecuteNonQuery();

                    connection.Close();
                    this.Close();
                    Appointment appointment = new Appointment();
                    appointment.ShowDialog();
                }
            }

            
        }
        
        public int AppointmentOverlap(DateTime start, DateTime end, int id)
        {
            MySqlConnection connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["localDb"].ConnectionString);
            connection.Open();
            string appointmentStart = start.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss");
            string appointmentEnd = end.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss");
            string checkOverlapsql = $@"SELECT COUNT(*)
                                        FROM appointment 
                                        WHERE EXISTS
                                        (SELECT * FROM appointment
                                        WHERE start <= '{appointmentEnd}'
                                        AND end >= '{appointmentStart}'
                                        AND userId = '{id}')";

            MySqlCommand command = new MySqlCommand(checkOverlapsql, connection);
            int overlap = Convert.ToInt32(command.ExecuteScalar());
            return overlap > 0 ? 0 : 1;                      
        }

        private void AddAppointment_Load(object sender, EventArgs e)
        {
            LoadCustomerData();
        }

        public void LoadCustomerData()
        {
            AddAppointmentTypes();

            MySqlConnection connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["localDb"].ConnectionString);
            connection.Open();
            string grabUser = $"SELECT * FROM customer";
            MySqlCommand command = new MySqlCommand(grabUser, connection);
            DataTable customer = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            adapter.Fill(customer);
            comboBox2.SelectedIndex = -1;
            comboBox2.ValueMember = "customerId";
            comboBox2.DisplayMember = "customerName";
            comboBox2.DataSource = customer;

            label6.Text = MaxID.ToString();

        }

        public void AddAppointmentTypes()
        {
            comboBox1.Items.Add("Scrum");
            comboBox1.Items.Add("Presentation");
            comboBox1.Items.Add("Guerilla Testing");
            comboBox1.Items.Add("Coffee");

        }
        
        public Validation ValidateAppointments(DateTime start, DateTime end)
        {
            if (start > end)
            {
                return Validation.InvalidTime;
            }

            if (start.Hour < 7 || start.Hour > 22 || end.Hour > 22)
            {
                return Validation.OutOfHoursRange;
            }

            if (start.Date != end.Date)
            {
                return Validation.MultipleDays;
            }
            return Validation.NoIssues;
        }

       public void SavedandValidated()
        {
            MySqlConnection connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["localDb"].ConnectionString);
            connection.Open();
            string user = ID.username;
            int userID = ID.findUserID();
            string customer = comboBox2.Text;
            string appointmentType = comboBox1.Text;
            string customerIDsql = $"SELECT customerId FROM customer WHERE customerName = '{customer}'";
            MySqlCommand command = new MySqlCommand(customerIDsql, connection);
            int customerId = Convert.ToInt32(command.ExecuteScalar());


        }
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

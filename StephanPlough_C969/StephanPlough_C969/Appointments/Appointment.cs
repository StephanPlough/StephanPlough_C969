using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StephanPlough_C969
{
    public partial class Appointment : Form
    {
        Data Datasql = new Data();
        private string appointmentID;

        public Appointment()
        {
            InitializeComponent();
        }

        public void DataLoad()
        {

            string dgvFill = $@"SELECT
                                    customer.customerId, customer.customerName, appointment.appointmentId, appointment.Type, appointment.Start, appointment.End
                                FROM
                                    customer
                                JOIN
                                    appointment on customer.customerId = appointment.customerId";

            DataTable appointment = Datasql.DataFilling(dgvFill);
            foreach (DataRow dr in appointment.Rows)
            {
                dr["start"] = ((DateTime)dr["start"]).ToLocalTime();
                dr["end"] = ((DateTime)dr["end"]).ToLocalTime();
            }
            dataGridView1.DataSource = appointment;
            dataGridView1.ClearSelection();


        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddAppointment addAppoint = new AddAppointment();
            addAppoint.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Appointment_Load(object sender, EventArgs e)
        {
            DataLoad();
        }

        private void MonthlyButton_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                string dgvFill = $@"SELECT
                                    customer.customerId, customer.customerName, appointment.appointmentId, appointment.Type, appointment.Start, appointment.End
                                FROM
                                    customer
                                JOIN
                                    appointment on customer.customerId = appointment.customerId 
                                WHERE
                                    MONTH (appointment.start) = MONTH (NOW()) AND YEAR (appointment.start) = YEAR (NOW())";

                DataTable appointment = Datasql.DataFilling(dgvFill);
                foreach (DataRow dr in appointment.Rows)
                {
                    dr["start"] = ((DateTime)dr["start"]).ToLocalTime();
                    dr["end"] = ((DateTime)dr["end"]).ToLocalTime();
                }
                dataGridView1.DataSource = appointment;
                dataGridView1.ClearSelection();
            }
            catch
            {
                MessageBox.Show("Error: Please check SQL query");
            }
            finally
            {

            }
        }

        private void WeeklyButton_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                string dgvFill = $@"SELECT
                                    customer.customerId, customer.customerName, appointment.appointmentId, appointment.Type, appointment.Start, appointment.End
                                FROM
                                    customer
                                JOIN
                                    appointment on customer.customerId = appointment.customerId 
                                WHERE
                                    WEEK (appointment.start) = WEEK (NOW()) AND YEAR (appointment.start) = YEAR (NOW())";

                DataTable appointment = Datasql.DataFilling(dgvFill);
                foreach (DataRow dr in appointment.Rows)
                {
                    dr["start"] = ((DateTime)dr["start"]).ToLocalTime();
                    dr["end"] = ((DateTime)dr["end"]).ToLocalTime();
                }
                dataGridView1.DataSource = appointment;
                dataGridView1.ClearSelection();
            }
            catch
            {
                MessageBox.Show("Error: Please check SQL query");
            }
            finally
            {

            }
        }

        private void AllAppointments_CheckedChanged(object sender, EventArgs e)
        {
            DataLoad();
        }

        private void delete_Click(object sender, EventArgs e)
        {

            appointmentID = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            string connectionString = ConfigurationManager.ConnectionStrings["localDb"].ConnectionString;
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            string deleteSql = $"DELETE FROM appointment WHERE appointmentId = '{appointmentID}'";
            MySqlCommand deleteCommand = new MySqlCommand(deleteSql, connection);
            deleteCommand.ExecuteNonQuery();
            DataLoad();
        }
        
        public string CellValue(DataGridViewRow row,  int index)
        {
            return row.Cells[index].Value.ToString();
        }
        private void editAppointment_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                this.Hide();
                EditAppointment editappoint = new EditAppointment();
                UpdateAppForm(editappoint);
                editappoint.Show();
            }
            else
            {
                MessageBox.Show("Please select an appointment to update");
            }
        }
        private void UpdateAppForm(EditAppointment editappoint)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            editappoint.customerComboBox.Text = CellValue(row, 1);
            editappoint.label6.Text = CellValue(row, 2);
            editappoint.typeComboBox.Text = CellValue(row, 3);
            editappoint.DatePickerStart.Value = Convert.ToDateTime(CellValue(row, 4));
            editappoint.DateTimePickerEnd.Value = Convert.ToDateTime(CellValue(row, 5));
        }
        
    }
}

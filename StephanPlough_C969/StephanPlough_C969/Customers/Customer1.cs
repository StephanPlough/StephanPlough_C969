using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StephanPlough_C969
{
    public partial class Customer1 : Form
    {
        public Customer1()
        {

            InitializeComponent();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public string CellValue(DataGridViewRow row, int index)
        {
            return row.Cells[index].Value.ToString();
        }

        private void UpdateCustomerForm(UpdateCustomer updatecust)
        {
            DataGridViewRow row = dataGridView2.SelectedRows[0];
            updatecust.textBoxCustomer.Text = CellValue(row, 1);
            updatecust.textBoxAddress.Text = CellValue(row, 3);
            updatecust.textBoxPhoneNumber.Text = CellValue(row, 2);
            updatecust.textBoxCity.Text = CellValue(row, 4);
            updatecust.textBoxCountry.Text = CellValue(row, 6);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            AddCustomer addcust = new AddCustomer();
            addcust.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                this.Hide();
                UpdateCustomer editcust = new UpdateCustomer();
                UpdateCustomerForm(editcust);
                editcust.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a customer to update");
            }

        }

        private void Customer_Load(object sender, EventArgs e)
        {
            dataLoad();
        }
        public void dataLoad()
        {
            string constr = ConfigurationManager.ConnectionStrings["localDB"].ConnectionString;
            MySqlConnection conn = new MySqlConnection(constr);
            conn.Open();
            string dgvFill = @"SELECT 
                                    customer.customerId, customer.customerName, address.phone, 
                                    address.address, city.city, address.postalCode, country.country 
                               FROM 
                                    customer 
                               JOIN 
                                    address on customer.addressId = address.addressId 
                               JOIN 
                                    city on address.cityId = city.cityId 
                               JOIN 
                                    country on city.countryId = country.countryId";
            MySqlCommand cmd = new MySqlCommand(dgvFill, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable customer = new DataTable();
            adp.Fill(customer);
            dataGridView2.DataSource = customer;
            dataGridView2.ClearSelection();
        }

        
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {

                try
                {

                    string customerID = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
                    string address = dataGridView2.SelectedRows[0].Cells[3].Value.ToString();
                    string constr = ConfigurationManager.ConnectionStrings["localDB"].ConnectionString;
                    MySqlConnection conn = new MySqlConnection(constr);
                    conn.Open();
                    string removeCustomer = $"DELETE FROM customer WHERE customerId = '{customerID}'";
                    MySqlCommand customerCmd = new MySqlCommand(removeCustomer, conn);
                    customerCmd.Prepare();
                    customerCmd.ExecuteNonQuery();
                    string removeAdress = $"DELETE FROM address WHERE address = '{address}'";
                    MySqlCommand addressCmd = new MySqlCommand(removeAdress, conn);
                    addressCmd.Prepare();
                    addressCmd.ExecuteNonQuery();
                    string removeAppointment = $"DELETE FROM appointment WHERE customerId = '{customerID}'";
                    MySqlCommand appointmentCmd = new MySqlCommand(removeAppointment, conn);
                    appointmentCmd.Prepare();
                    appointmentCmd.ExecuteNonQuery();

                    dataLoad();
                }

                catch (MySqlException ex)
                {
                    MessageBox.Show("No");
                }
                finally
                {
                    dataGridView2.Update();
                    // conn.Close();
                }

            }
        }

        private void Customer_Load()
        {
            throw new NotImplementedException();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}

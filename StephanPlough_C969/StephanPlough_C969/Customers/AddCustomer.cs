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
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddCustomer_Load(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["localDb"].ConnectionString);
            connection.Open();
            Login log = new Login();
            label8.Text = log.usernameLabel();
        }

        private void save_Click(object sender, EventArgs e)
        {
            SaveWithExceptions();
            if (SaveWithExceptions() == true)
            {
                string constr = ConfigurationManager.ConnectionStrings["localDB"].ConnectionString;
                MySqlConnection conn = new MySqlConnection(constr);
                conn.Open();

                var custID = addID("customer", "customerId") + 1;
                var addressID = addID("address", "addressId") + 1;
                var cityID = addID("city", "cityId") + 1;
                var countryID = addID("country", "countryId") + 1;

                var addCountry = @$"INSERT INTO
                                         country(countryId, country, createDate, createdBy, lastUpdate, lastUpdateBy)
                                    VALUES
                                         ('{countryID}', '{textBox_Country.Text}', NOW(), '{ID.username}', NOW(), '{ID.username}')";

                MySqlCommand cmdCountry = new MySqlCommand(addCountry, conn);
                cmdCountry.Prepare();
                cmdCountry.ExecuteNonQuery();

                var addCity = $@"INSERT INTO
                                    city(cityId, city, countryId, createDate, createdBy, lastUpdate, lastUpdateBy)
                                 VALUES
                                      ('{cityID}', '{textBox_City.Text}', '{countryID}', NOW(), '{ID.username}', NOW(), '{ID.username}')";
                MySqlCommand cmdCity = new MySqlCommand(addCity, conn);
                cmdCity.Prepare();
                cmdCity.ExecuteNonQuery();

                var addAddress = $@"INSERT INTO
                                        address(addressId, address, address2, cityId, postalCode, phone, createDate, createdBy, lastUpdate, lastUpdateBy)
                                    VALUES
                                        ('{addressID}','{textBox_Address.Text}', '', '{cityID}', '{textBox_Zip.Text}', {textBox_PhoneNum.Text}, NOW(), '{ID.username}', NOW(), '{ID.username}')";
                MySqlCommand cmdAddress = new MySqlCommand(addAddress, conn);
                cmdAddress.Prepare();
                cmdAddress.ExecuteNonQuery();

                var addCustomer = $@"INSERT INTO
                                        customer(customerId, customerName, addressId, active, createDate, createdBy, lastUpdate, lastUpdateBy)
                                     VALUES
                                        ('{custID}', '{textBox_Name.Text}','{addressID}', 1, NOW(), '{ID.username}', NOW(), '{ID.username}')";
                MySqlCommand cmdCustomer = new MySqlCommand(addCustomer, conn);
                cmdCustomer.Prepare();
                cmdCustomer.ExecuteNonQuery();

                conn.Close();
                this.Close();
                Customer1 customer = new Customer1();
                customer.ShowDialog();


            }
        }

        public bool SaveWithExceptions()
        {
            var save = false;
            if (string.IsNullOrEmpty(textBox_Name.Text) ||
               string.IsNullOrEmpty(textBox_Address.Text) ||
               string.IsNullOrEmpty(textBox_City.Text) ||
               string.IsNullOrEmpty(textBox_PhoneNum.Text) ||
               string.IsNullOrEmpty(textBox_Country.Text))
            {
                MessageBox.Show("Please fill in all the fields");
                return false;
            }
            else
            {
                return true;
            }
        }

        public int addID(string tableName, string id)
        {
            string constr = ConfigurationManager.ConnectionStrings["localDB"].ConnectionString;
            MySqlConnection conn = new MySqlConnection(constr);
            conn.Open();

            string addIDtoField = $"SELECT MAX({id}) FROM {tableName}";

            MySqlCommand comm = new MySqlCommand(addIDtoField, conn);
            MySqlDataReader mySqlDataReader = comm.ExecuteReader();

            if (mySqlDataReader.Read())
            {
                if (!Convert.IsDBNull(mySqlDataReader[0]))
                {
                    return mySqlDataReader.GetInt32(0);
                }
            }
            return 0;
        }


    }
}

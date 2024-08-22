using Microsoft.VisualBasic.ApplicationServices;
using StephanPlough_C969.Models;
using System;
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
    public partial class Home : Form
    {
        Users loggedUser;
        public Home()
        {

            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void toCustomer_Click(object sender, EventArgs e)
        {

            Customer1 cust = new Customer1();
            cust.ShowDialog();
        }

        private void toReports_Click(object sender, EventArgs e)
        {
            ConsultantReport cr = new ConsultantReport();
            cr.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Appointment appointment = new Appointment();
            appointment.ShowDialog();
            this.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AppointmentReport ar = new AppointmentReport();
            ar.ShowDialog();
        }
    }
}

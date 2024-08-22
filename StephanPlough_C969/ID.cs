using MySql.Data.MySqlClient;
using Org.BouncyCastle.Bcpg;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StephanPlough_C969
{
    public class ID

    {
        public static string connectionString = ConfigurationManager.ConnectionStrings["localDb"].ConnectionString;
        // Place all ID methods in seperate class
        private static int userID;
        private static string user;
        
        public static void UserID(int id)
        {
            userID = id;

        }

        public static int newAppointmentID(string id)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            string newIdsql = $"SELECT MAX({id}) FROM appointment";
            MySqlCommand command = new MySqlCommand(newIdsql, connection);
            MySqlDataReader reader = command.ExecuteReader();

            if(reader.Read() && reader[0] != DBNull.Value)
            {
                return Convert.ToInt32(reader[0]);
            }
            return 0;
        }
          
        public static string username { get { return user; } set { user = value; } }
        
        public static int findUserID()
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            string userIDsql = $"SELECT userId FROM user WHERE username = '{username}'";
            MySqlCommand command = new MySqlCommand(userIDsql, connection);
            int id = Convert.ToInt32(command.ExecuteScalar());
            return id;
        }
        
    }

    
}

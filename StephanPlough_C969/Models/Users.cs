using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StephanPlough_C969.Models
{
    public class Users
    {
        public int UserID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }

        public Users(string user, string pass) 
        {
            IsActive = true;
            Username = user;
            Password = pass;

        }

        public Users()
        {

        }

        
    }
}

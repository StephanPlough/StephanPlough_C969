using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StephanPlough_C969.Models
{
    public class Appointment
    {
        public int AppointmentID { get; set; }
        public int UserID { get; set; }
        public int CustomerID { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public string Title { get; set; }
        public Address Address { get; set; }
        public string Description { get; set; }

        public Appointment(int appID, int userID, int custID, DateTime start, DateTime end, string title, Address add, string description)
        {
            AppointmentID = appID;
            UserID = userID;
            CustomerID = custID;
            Start = start;
            End = end;
            Title = title;
            Address = add;
            Description = description;

        }



    }

    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StephanPlough_C969.Models
{
    public class Customer
    {
        public int CountryID { get; set; }
        public string CountryName { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdate { get; set;}
        public string CreatedBy { get; set; }
        public string LastUpdatedBy { get; set;}

        public Customer(int countryID, string name, DateTime create, DateTime update, string createdBy, string updatedBy) 
        {
            CountryID = countryID;
            CountryName = name;
            CreateDate = create;
            LastUpdate = update;
            CreatedBy = createdBy;
            LastUpdatedBy = updatedBy;
        }
    }
}

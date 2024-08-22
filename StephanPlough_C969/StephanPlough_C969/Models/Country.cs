using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StephanPlough_C969.Models
{
    public class Country
    {
        public string CountryName {  get; set; }
        public int CountryID { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdate {  get; set; }

        public string CreatedBy { get; set; }
        public string LastUpdatedBy { get; set; }

    }
}

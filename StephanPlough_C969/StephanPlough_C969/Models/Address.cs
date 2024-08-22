using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StephanPlough_C969.Models
{
    public class Address
    {
        public int AddressID { get; set; }
        public string AddressOne { get; set; }
        public string AddressTwo { get; set; }
        public int CityID { get; set; }
        public int ZipCode { get; set; }
        public string Phone { get; set; }
        public string CreatedBy { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StephanPlough_C969.Models
{
    public class City
    {
        public string CityName {  get; set; }
        public int CityID { get; set; }
        public int CountryID { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdate { get; set; }
        public string Created {  get; set; }
        public string LastUpdated { get; set; }

        public City(string city, int cityID, int countryID, DateTime createDate, DateTime lastUpdate
            , string created, string lastUpdated)
        {
            CityName = city;
            CityID = cityID;
            CountryID = countryID;
            LastUpdate = lastUpdate;
            CreateDate = createDate;
            Created = created;
            LastUpdated = lastUpdated;
        }

    }
}

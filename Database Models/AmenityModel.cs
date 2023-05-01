using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_System
{
    public class AmenityModel
    {
        public int amenity_id { get; set; }
        public string amenity_name { get; set; }
        public string description { get; set; }

        public string AmenityInfo
        {
            get
            {
                return $"{amenity_name}";
            }
        }

        public int AmenityKey
        {
            get
            {
                return amenity_id;
            }
        }
    }
}

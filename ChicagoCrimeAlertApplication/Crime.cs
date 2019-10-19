using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChicagoCrimeAlertApplication
{
    class Crime
    {
        public Crime() { 
            //Default constructor
        }

        public DateTime date { get; set; }
        public string block { get; set; }
        public string primary_type { get; set; }
        public string description { get; set; }
        public string location_description { get; set; }
        public bool arrest { get; set; }
        public bool domestic { get; set; }
        public string ward { get; set; }
        public string community_area { get; set; }
        public DateTime updated_on { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
    }
}

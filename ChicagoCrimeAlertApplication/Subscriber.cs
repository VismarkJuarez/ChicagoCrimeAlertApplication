using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChicagoCrimeAlertApplication
{
    class Subscriber
    {
        public Subscriber() { }

        public Subscriber(String firstName, String lastName, int wardNumber, String phoneNumber) {
            this.firstName = firstName;
            this.lastName = lastName;
            this.wardNumber = wardNumber;
            this.phoneNumber = phoneNumber;
        }

        public String firstName {set; get;}
        public String lastName { set; get; }
        public int wardNumber { set; get; }
        public String phoneNumber { set; get; }
    }
}

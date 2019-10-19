using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChicagoCrimeAlertApplication
{
    class Crimes
    {
        ArrayList crimes { set; get; }

        public Crimes() { 
            //Default constructor
        }

        public Crimes(ArrayList crimes)
        {
            this.crimes = crimes;
        }

    }
}

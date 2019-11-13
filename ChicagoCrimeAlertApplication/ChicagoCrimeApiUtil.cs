using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace ChicagoCrimeAlertApplication
{
    class ChicagoCrimeApiUtil
    {
        static HttpClient client = new HttpClient();

        private ChicagoCrimeApiUtil() { 
            //Hiding constructor -- this will be a utility class.
        }


        //TODO heavy refactoring/modularization required
        public static List<CrimeFrequencyDataPoint> performGetRequest(List<String> selectedCrimes, String selectedYear) {
            string responseBody = string.Empty;
            string url = @"https://data.cityofchicago.org/resource/6zsd-86xi.json?$select=primary_type,COUNT(primary_type)&$group=primary_type&year=" + selectedYear;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.AutomaticDecompression = DecompressionMethods.GZip;

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                responseBody = reader.ReadToEnd();
            }

            JArray a = JArray.Parse(responseBody);

            List<CrimeFrequencyDataPoint> crimeFrequencyDataPoints = new List<CrimeFrequencyDataPoint>();

            List<String> crimes = new List<String>();
            List<int> crimeFrequencyCounts = new List<int>();

            //Extract the JSON payload and store it into two lists: one holdig the crime name
            //and another holding the corresponding crime frequency count.
            foreach (JObject o in a.Children<JObject>())
            {
                foreach (JProperty p in o.Properties())
                {
                    if (p.Name.Equals("primary_type"))
                    {
                        crimes.Add((String)p.Value);
                    }
                    else if (p.Name.Equals("COUNT_primary_type")) {
                        crimeFrequencyCounts.Add((int)p.Value);
                    }
                }
            }

            //attempt to find each of the user-specified crimes in the `crimes` list:
            for (int i = 0; i < selectedCrimes.Count; i++) {
                String currentCrime = selectedCrimes[i];
                int crimeFrequencyCountIndex = crimes.IndexOf(currentCrime);

                //If found, store appropriate info
                if (crimeFrequencyCountIndex > -1) {
                    //craft a new CrimeFrequencyDataPoint and store relevant data
                    int crimeFrequency = crimeFrequencyCounts[crimeFrequencyCountIndex];

                    CrimeFrequencyDataPoint crimeFrequencyDataPoint = new CrimeFrequencyDataPoint();
                    crimeFrequencyDataPoint.crimeName = currentCrime;
                    crimeFrequencyDataPoint.crimeFrequency = crimeFrequency;

                    //store the datapoint
                    crimeFrequencyDataPoints.Add(crimeFrequencyDataPoint);
                }
            }

                Console.WriteLine("returning a list of size: " + crimeFrequencyDataPoints.Count);
            return crimeFrequencyDataPoints;
        }

    }
}

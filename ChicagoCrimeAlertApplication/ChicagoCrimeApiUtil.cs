using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
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

        public static async Task invokeApiAsync() {
            // Call asynchronous network methods in a try/catch block to handle exceptions.
            try
            {
                //https://data.cityofchicago.org/resource/ijzp-q8t2.json?$select=date, block, primary_type, description, location_description, arrest, domestic, ward, community_area, updated_on, latitude, longitude LIMIT 50
                string responseBody = await client.GetStringAsync("https://data.cityofchicago.org/resource/6zsd-86xi.json?$select=primary_type,COUNT(primary_type)&$group=primary_type&year=2019");
                Console.WriteLine("printing the response body: " + responseBody);


                //TODO stopped here. Need to figure out how to parse this stuff.


                //List<Crime> crimes = JsonConvert.DeserializeObject<List<Crime>>(responseBody);
                AnnualCrimeFrequencies annualCrimeFrequencies = JsonConvert.DeserializeObject<AnnualCrimeFrequencies>(responseBody);

                Console.WriteLine("drum roll: " + annualCrimeFrequencies);
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
            }
        }


    }
}

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

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
                string responseBody = await client.GetStringAsync("https://data.cityofchicago.org/resource/ijzp-q8t2.json?$select=date, block, primary_type, description, location_description, arrest, domestic, ward, community_area, updated_on, latitude, longitude LIMIT 50");
                Console.WriteLine(responseBody);

                List<Crime> crimes = JsonConvert.DeserializeObject<List<Crime>>(responseBody);

                //Console.WriteLine("drum roll: " + crimes[0].primary_type);
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
            }
        }


    }
}

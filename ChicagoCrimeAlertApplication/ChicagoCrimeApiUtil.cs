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
                JArray a = JArray.Parse(responseBody);

                foreach (JObject o in a.Children<JObject>())
                {
                    foreach (JProperty p in o.Properties())
                    {
                        //TODO: Now, we can match the p.Name attribute with whatever we're looking to pull from the JSON response.
                        string name = p.Name;
                        string value = (string)p.Value;
                        Console.WriteLine(name + " -- " + value);
                    }
                }

            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
            }
        }


    }
}

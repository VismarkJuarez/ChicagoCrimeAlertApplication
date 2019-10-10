using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace ChicagoCrimeAlertApplication
{
    class TwilioApiUtil
    {
        private TwilioApiUtil()
        {
            /*
             * Hiding constructor.  This class will be used as a utility class.
             * No need to instantiate it.
             */
        }

        public static string showGreeting(string yourName)
        {
            return "Hello, " + yourName;
        }

        public static void sendTextMessage(String phoneNumber, String messageContent)
        {
            /*
             TODO: HIDE Credentials!!!
             */

            // Find your Account Sid and Token at twilio.com/console
            // DANGER! This is insecure. See http://twil.io/secure
            const string accountSid = "AC2c3ea4c8bab866082211221e9d34ff35";
            const string authToken = "fd3c5e3ba5a4e42cfa6b42496727ea66";

            TwilioClient.Init(accountSid, authToken);

            var message = MessageResource.Create(
                body: messageContent,
                from: new Twilio.Types.PhoneNumber("+18722527725"),
                to: new Twilio.Types.PhoneNumber("+1" + phoneNumber)
            );

            Console.WriteLine("Text message has been sent!");
        }
    }
}

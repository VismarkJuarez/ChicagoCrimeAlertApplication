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

        public static void sendRegistrationSuccessfulTextMessage(String phoneNumber, string firstName, string wardNumber)
        {
            String accountSid = CredentialsFileReaderUtil.retrieveFromCredentialsFile("twilioAccountSid");
            String authToken = CredentialsFileReaderUtil.retrieveFromCredentialsFile("twilioAuthToken");
            String twilioPhoneNumber = CredentialsFileReaderUtil.retrieveFromCredentialsFile("twilioPhoneNumber");

            //Creating a new TwilioClient object -- to be used for sending Twilio sms text message.
            TwilioClient.Init(accountSid, authToken);

            string registrationSuccessfulMessage = "Hello, "
                + firstName
                + ".  You have been successfully registered to received notifications for ward "
                + wardNumber
                + ".";

            //Crafting the actual sms message and sending
            var message = MessageResource.Create(
                body: registrationSuccessfulMessage,
                from: new Twilio.Types.PhoneNumber(twilioPhoneNumber),
                to: new Twilio.Types.PhoneNumber(phoneNumber)
            );

            Console.WriteLine("Text message has been sent!");
        }
    }
}

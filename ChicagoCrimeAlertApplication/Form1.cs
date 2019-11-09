using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChicagoCrimeAlertApplication
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }


        private void recordNewUser()
        {
            /*
           TODO:
               - Input vlidation (phone number cannot be < || > 10 digits).
               - Phone number input should only be numbers.
               - The custom message and phone number cannot be null.
            */

            //Store the phone numbere entered by the user
            String phoneNumber = phoneNumberTextBox.Text;
            string firstName = firstNameTextBox.Text;
            string wardNumber = wardTextBox.Text; //should verify that user entered a valid value

            Console.WriteLine("The user entered the phone number: " + phoneNumber);

            //record the new user in the Mongo Database
            recordNewUserInMongoDB();

            //Send an initial text message to the user to notify them that they have
            //been successfully registered to receive notifications.
            TwilioApiUtil.sendRegistrationSuccessfulTextMessage(phoneNumber, firstName, wardNumber);
        }

        private void insertNewSubscriberIntoDatabase(BsonDocument subscriber) {
            int ward = subscriber.GetValue("ward").AsInt32;

            //Connecting to the database
            var subscribersCollection = MongoUtil.retrieveCollection("smsAlerting", "subscribers");

            //Perform the update to the database
            var filter = Builders<BsonDocument>.Filter.Eq("ward", ward);
            var update = Builders<BsonDocument>.Update.Push("subscribers", subscriber);

            //Execute the update
            subscribersCollection.UpdateOne(filter, update);
        }

        private  BsonDocument convertUserInputToDocumentFormat() {
            //Store user input
            String firstName = firstNameTextBox.Text;
            String lastName = lastNameTextBox.Text;
            int wardNumber = Int32.Parse(wardTextBox.Text);
            String phoneNumber = phoneNumberTextBox.Text;

            var newSubscriber = new BsonDocument {
                { "firstName", firstName },
                { "lastName", lastName },
                { "ward", wardNumber },
                { "phoneNumber", phoneNumber }
            };

            return newSubscriber;
        }


   
        private void recordNewUserInMongoDB()
        {
            // TODO Implement sanitation and validation methods.
            var subscribersCollection = MongoUtil.retrieveCollection("smsAlerting", "subscribers");
            BsonDocument newSubscriber = convertUserInputToDocumentFormat();
            insertNewSubscriberIntoDatabase(newSubscriber);
            Console.WriteLine("Successfully inserted the following subscriber into the Mongo database:" + newSubscriber.ToJson());
        }

        private void callApiButton_Click(object sender, EventArgs e)
        {
            //A test button for invoking and testing the API communicaton
            //functionality
            ChicagoCrimeApiUtil.invokeApiAsync();
        }

        private void metroTabPage1_Click(object sender, EventArgs e)
        {

        }

        private void metroTabPage4_Click(object sender, EventArgs e)
        {

        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            //retrieve all of the user's entered data and process it
            //(store it into Database and senduser a success message if all is processed successfully)
            recordNewUser();
        }

        private void firstNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

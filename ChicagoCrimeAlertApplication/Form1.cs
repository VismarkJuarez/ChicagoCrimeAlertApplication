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

<<<<<<< HEAD
        private void PhoneNumberLabel_Click(object sender, EventArgs e)
=======
        private void Button4_Click(object sender, EventArgs e)
>>>>>>> master
        {

        }

<<<<<<< HEAD
        private void SendMessageButton_Click(object sender, EventArgs e)
        {
            /*
           TODO:
               - Input vlidation (phone number cannot be < || > 10 digits).
               - Phone number input should only be numbers.
               - The custom message and phone number cannot be null.
            */

            //Store the phone numbere entered by the user
            String phoneNumber = phoneNumberTextBox.Text;
            Console.WriteLine("The user entered the phone number: " + phoneNumber);

            //Store the custom message entered by the user.
            String customMessage = customMessageTextBox.Text;
            Console.WriteLine("The user entered the following custom message: " + customMessage);

            TwilioApiUtil.sendTextMessage(phoneNumber, customMessage);

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
            int wardNumber = Int32.Parse(wardNumberTextBox.Text);
            String phoneNumber = phoneNumberTextBox.Text;

            var newSubscriber = new BsonDocument {
                { "firstName", firstName },
                { "lastName", lastName },
                { "ward", wardNumber },
                { "phoneNumber", phoneNumber }
            };

            return newSubscriber;
        }

        private void mongoButton_Click(object sender, EventArgs e)
        {
            // TODO Implement sanitation and validation methods.
            var subscribersCollection = MongoUtil.retrieveCollection("smsAlerting", "subscribers");
            BsonDocument newSubscriber = convertUserInputToDocumentFormat();
            insertNewSubscriberIntoDatabase(newSubscriber);
            Console.WriteLine("Successfully inserted the following subscriber into the Mongo database:" + newSubscriber.ToJson());
        }

        private void customMessageLabel_Click(object sender, EventArgs e)
        {

        }

        private void callApiButton_Click(object sender, EventArgs e)
        {
            //A test button for invoking and testing the API communicaton
            //functionality
            ChicagoCrimeApiUtil.invokeApiAsync();
=======
        private void Button5_Click(object sender, EventArgs e)
        {
>>>>>>> master

        }
    }
}

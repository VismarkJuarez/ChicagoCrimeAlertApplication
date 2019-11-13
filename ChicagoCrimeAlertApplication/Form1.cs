using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
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

        private void insertNewSubscriberIntoDatabase(BsonDocument subscriber)
        {
            int ward = subscriber.GetValue("ward").AsInt32;

            //Connecting to the database
            var subscribersCollection = MongoUtil.retrieveCollection("smsAlerting", "subscribers");

            //Perform the update to the database
            var filter = Builders<BsonDocument>.Filter.Eq("ward", ward);
            var update = Builders<BsonDocument>.Update.Push("subscribers", subscriber);

            //Execute the update
            subscribersCollection.UpdateOne(filter, update);
        }

        private BsonDocument convertUserInputToDocumentFormat()
        {
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


        private void loadChart()
        {

        }


        private void loadBarChart()
        {

            //Setting up stylistic configurations fo the chart
            this.crimeFrequencyByYearChart.Series["Crime Frequency"].IsValueShownAsLabel = true;
            this.crimeFrequencyByYearChart.Series["Crime Frequency"].Font = new System.Drawing.Font("Arial", 12);
            this.crimeFrequencyByYearChart.ChartAreas[0].AxisX.LabelStyle.Angle = -90;
            this.crimeFrequencyByYearChart.ChartAreas[0].AxisX.Interval = 1;

            //retrieve user-selected combobox values:
            String selectedCrime1 = this.crimeComboBox1.SelectedItem != null ? this.crimeComboBox1.SelectedItem.ToString() : null;
            String selectedCrime2 = this.crimeComboBox2.SelectedItem != null ? this.crimeComboBox2.SelectedItem.ToString() : null;
            String selectedCrime3 = this.crimeComboBox3.SelectedItem != null ? this.crimeComboBox3.SelectedItem.ToString() : null;
            String selectedCrime4 = this.crimeComboBox4.SelectedItem != null ? this.crimeComboBox4.SelectedItem.ToString() : null;
            String selectedCrime5 = this.crimeComboBox5.SelectedItem != null ? this.crimeComboBox5.SelectedItem.ToString() : null;
            String selectedCrime6 = this.crimeComboBox6.SelectedItem != null ? this.crimeComboBox6.SelectedItem.ToString() : null;
            String selectedCrime7 = this.crimeComboBox7.SelectedItem != null ? this.crimeComboBox7.SelectedItem.ToString() : null;
            String selectedCrime8 = this.crimeComboBox8.SelectedItem != null ? this.crimeComboBox8.SelectedItem.ToString() : null;
            String selectedCrime9 = this.crimeComboBox9.SelectedItem != null ? this.crimeComboBox9.SelectedItem.ToString() : null;
            String selectedCrime10 = this.crimeComboBox10.SelectedItem != null ? this.crimeComboBox10.SelectedItem.ToString() : null;

            //Store user input into a list
            List<String> selectedCrimes = new List<String>() {
                selectedCrime1,
                selectedCrime2,
                selectedCrime3,
                selectedCrime4,
                selectedCrime5,
                selectedCrime6,
                selectedCrime7,
                selectedCrime8,
                selectedCrime9,
                selectedCrime10
            };

            String selectedYear = this.crimeFrequencyYearComboBox.Text;

            //retrieve crime frequency counts for the user-indicated crimes
            List<CrimeFrequencyDataPoint> crimeFrequencyDataPoints = ChicagoCrimeApiUtil.performGetRequest(selectedCrimes, selectedYear);

            for (int i = 0; i < crimeFrequencyDataPoints.Count; i++) {
                String currentCrime = crimeFrequencyDataPoints[i].crimeName;
                int crimeFrequency = crimeFrequencyDataPoints[i].crimeFrequency;

                //only process input from combo boxes that received user input
                if (currentCrime != null) {
                    this.crimeFrequencyByYearChart.Series["Crime Frequency"].Points.AddXY(currentCrime, crimeFrequency);
                }
            }
        }

        private void executeQueryButton_Click(object sender, EventArgs e)
        {
            //Will fetch data from the Chicago Crime Portal API and display it on the line chart.
            loadBarChart();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

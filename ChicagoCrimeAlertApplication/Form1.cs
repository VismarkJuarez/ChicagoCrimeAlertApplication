using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

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

        private void plotCrimeFrequencyCountForYear(String crimeName, int year, int crimeFrequencyCount) {
            this.lineGraph.Series[crimeName].Points.AddXY(year, crimeFrequencyCount);
            Console.WriteLine("Plotting (" + year + ", " + crimeFrequencyCount + ")");
        }



        private void loadLineChart() {
            //Setting up stylistic configurations for the chart
            this.lineGraph.ChartAreas[0].AxisX.LabelStyle.Angle = -90;
            this.lineGraph.ChartAreas[0].AxisX.Interval = 1;

            //retrieve user-selected combobox values:
            String selectedCrime1 = this.lineGraphCrime1.SelectedItem != null ? this.lineGraphCrime1.SelectedItem.ToString() : null;
            String selectedCrime2 = this.lineGraphCrime2.SelectedItem != null ? this.lineGraphCrime2.SelectedItem.ToString() : null;
            String selectedCrime3 = this.lineGraphCrime3.SelectedItem != null ? this.lineGraphCrime3.SelectedItem.ToString() : null;
            String selectedCrime4 = this.lineGraphCrime4.SelectedItem != null ? this.lineGraphCrime4.SelectedItem.ToString() : null;
            String selectedCrime5 = this.lineGraphCrime5.SelectedItem != null ? this.lineGraphCrime5.SelectedItem.ToString() : null;
            String selectedCrime6 = this.lineGraphCrime6.SelectedItem != null ? this.lineGraphCrime6.SelectedItem.ToString() : null;
            String selectedCrime7 = this.lineGraphCrime7.SelectedItem != null ? this.lineGraphCrime7.SelectedItem.ToString() : null;
            String selectedCrime8 = this.lineGraphCrime8.SelectedItem != null ? this.lineGraphCrime8.SelectedItem.ToString() : null;
            String selectedCrime9 = this.lineGraphCrime9.SelectedItem != null ? this.lineGraphCrime9.SelectedItem.ToString() : null;
            String selectedCrime10 = this.lineGraphCrime10.SelectedItem != null ? this.lineGraphCrime10.SelectedItem.ToString() : null;

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

            //Extract user-selected starting and ending year: TODO startingYear should not be < endingYear
            int startingYear = Int32.Parse(this.startingYearDropDown.Text);
            int endingYear = Int32.Parse(this.endingYearDropDown.Text);


            //Extract selected ward:
            String ward = this.wardDropdown.Text;
            int numberOfCrimes = selectedCrimes.Count;

            //Create a new Series (line) for each user-selected crime:
            for (int c = 0; c < numberOfCrimes; c++) {
                String currentCrime = selectedCrimes[c];
                if (currentCrime != "" && currentCrime != null) { //create a new Series (line) for the crime, so long as it exists (is not empty)
                    addNewSeriesToLineChart(currentCrime);
                }
            }

            //for each year, retrieve a count of how many instances of each crime occured in the given ward for the specific year
            for (int currentYear = startingYear; currentYear <= endingYear; currentYear++) {
                for (int i = 0; i < numberOfCrimes; i++) {
                    String currentCrime = selectedCrimes[i];
                    if (currentCrime != null && currentCrime != "") {
                        int annualCrimeFrequencyCount = ChicagoCrimeApiUtil.findAnnualCrimeFrequencyCount(currentCrime, currentYear, ward);
                        plotCrimeFrequencyCountForYear(currentCrime, currentYear, annualCrimeFrequencyCount);
                    }
                }
            }
        }

        private void addNewSeriesToLineChart(String nameOfNewSeries) {
            Console.WriteLine("Adding new Series to line chart: " + nameOfNewSeries);
            this.lineGraph.Series.Add(nameOfNewSeries);
            this.lineGraph.Series[nameOfNewSeries].Color = generateRandomColor();
            this.lineGraph.Series[nameOfNewSeries].IsVisibleInLegend = true;
            this.lineGraph.Series[nameOfNewSeries].ChartType = SeriesChartType.Spline;
            this.lineGraph.Series[nameOfNewSeries].IsValueShownAsLabel = true;
            this.lineGraph.Series[nameOfNewSeries].Font = new System.Drawing.Font("Arial", 9);
        }

        //TODO ranom color generator does not actually work.  Need to create our own random color-generator.
        private Color generateRandomColor() {
            Random rnd = null;
            rnd = new Random();
            return Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
        }

        private void executeQueryButton_Click(object sender, EventArgs e)
        {
            //Will fetch data from the Chicago Crime Portal API and display it on the bar chart.
            loadBarChart();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void crimeComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void crimeComboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void mainForm_Load(object sender, EventArgs e)
        {

        }

        private void lineGraphButton_Click(object sender, EventArgs e)
        {
            loadLineChart();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

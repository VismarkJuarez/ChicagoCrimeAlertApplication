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

        private void PhoneNumberLabel_Click(object sender, EventArgs e)
        {

        }

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
    }
}

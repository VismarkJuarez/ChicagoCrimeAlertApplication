namespace ChicagoCrimeAlertApplication
{
    partial class mainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
<<<<<<< HEAD
            this.phoneNumberLabel = new System.Windows.Forms.Label();
            this.customMessageLabel = new System.Windows.Forms.Label();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.customMessageTextBox = new System.Windows.Forms.TextBox();
            this.sendMessageButton = new System.Windows.Forms.Button();
            this.mongoButton = new System.Windows.Forms.Button();
            this.wardNumber = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.wardNumberTextBox = new System.Windows.Forms.TextBox();
            this.firstName = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.Label();
            this.callApiButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.AutoSize = true;
            this.phoneNumberLabel.Location = new System.Drawing.Point(2, 142);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(81, 13);
            this.phoneNumberLabel.TabIndex = 0;
            this.phoneNumberLabel.Text = "Phone Number:";
            this.phoneNumberLabel.Click += new System.EventHandler(this.PhoneNumberLabel_Click);
            // 
            // customMessageLabel
            // 
            this.customMessageLabel.AutoSize = true;
            this.customMessageLabel.Location = new System.Drawing.Point(2, 185);
            this.customMessageLabel.Name = "customMessageLabel";
            this.customMessageLabel.Size = new System.Drawing.Size(91, 13);
            this.customMessageLabel.TabIndex = 1;
            this.customMessageLabel.Text = "Custom Message:";
            this.customMessageLabel.Click += new System.EventHandler(this.customMessageLabel_Click);
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.Location = new System.Drawing.Point(109, 142);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(118, 20);
            this.phoneNumberTextBox.TabIndex = 2;
            // 
            // customMessageTextBox
            // 
            this.customMessageTextBox.Location = new System.Drawing.Point(109, 182);
            this.customMessageTextBox.Multiline = true;
            this.customMessageTextBox.Name = "customMessageTextBox";
            this.customMessageTextBox.Size = new System.Drawing.Size(202, 97);
            this.customMessageTextBox.TabIndex = 3;
            // 
            // sendMessageButton
            // 
            this.sendMessageButton.Location = new System.Drawing.Point(165, 285);
            this.sendMessageButton.Name = "sendMessageButton";
            this.sendMessageButton.Size = new System.Drawing.Size(75, 23);
            this.sendMessageButton.TabIndex = 4;
            this.sendMessageButton.Text = "SEND";
            this.sendMessageButton.UseVisualStyleBackColor = true;
            this.sendMessageButton.Click += new System.EventHandler(this.SendMessageButton_Click);
            // 
            // mongoButton
            // 
            this.mongoButton.Location = new System.Drawing.Point(165, 323);
            this.mongoButton.Name = "mongoButton";
            this.mongoButton.Size = new System.Drawing.Size(75, 23);
            this.mongoButton.TabIndex = 5;
            this.mongoButton.Text = "testMongoCnnectivity";
            this.mongoButton.UseVisualStyleBackColor = true;
            this.mongoButton.Click += new System.EventHandler(this.mongoButton_Click);
            // 
            // wardNumber
            // 
            this.wardNumber.AutoSize = true;
            this.wardNumber.Location = new System.Drawing.Point(2, 112);
            this.wardNumber.Name = "wardNumber";
            this.wardNumber.Size = new System.Drawing.Size(76, 13);
            this.wardNumber.TabIndex = 6;
            this.wardNumber.Text = "Ward Number:";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(109, 60);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(118, 20);
            this.firstNameTextBox.TabIndex = 7;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(109, 86);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(118, 20);
            this.lastNameTextBox.TabIndex = 8;
            // 
            // wardNumberTextBox
            // 
            this.wardNumberTextBox.Location = new System.Drawing.Point(109, 112);
            this.wardNumberTextBox.Name = "wardNumberTextBox";
            this.wardNumberTextBox.Size = new System.Drawing.Size(118, 20);
            this.wardNumberTextBox.TabIndex = 9;
            // 
            // firstName
            // 
            this.firstName.AutoSize = true;
            this.firstName.Location = new System.Drawing.Point(2, 62);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(60, 13);
            this.firstName.TabIndex = 10;
            this.firstName.Text = "First Name:";
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.Location = new System.Drawing.Point(2, 86);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(61, 13);
            this.LastName.TabIndex = 11;
            this.LastName.Text = "Last Name:";
            // 
            // callApiButton
            // 
            this.callApiButton.Location = new System.Drawing.Point(165, 364);
            this.callApiButton.Name = "callApiButton";
            this.callApiButton.Size = new System.Drawing.Size(75, 23);
            this.callApiButton.TabIndex = 12;
            this.callApiButton.Text = "Call API";
            this.callApiButton.UseVisualStyleBackColor = true;
            this.callApiButton.Click += new System.EventHandler(this.callApiButton_Click);
=======
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 82);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 92);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 82);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 180);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(151, 82);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 268);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(151, 82);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 356);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(151, 82);
            this.button5.TabIndex = 4;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
>>>>>>> master
            // 
            // mainForm
            // 
            this.AcceptButton = this.sendMessageButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
<<<<<<< HEAD
            this.Controls.Add(this.callApiButton);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.wardNumberTextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.wardNumber);
            this.Controls.Add(this.mongoButton);
            this.Controls.Add(this.sendMessageButton);
            this.Controls.Add(this.customMessageTextBox);
            this.Controls.Add(this.phoneNumberTextBox);
            this.Controls.Add(this.customMessageLabel);
            this.Controls.Add(this.phoneNumberLabel);
=======
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
>>>>>>> master
            this.Name = "mainForm";
            this.Text = "Chicago Crime Alert Application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label phoneNumberLabel;
        private System.Windows.Forms.Label customMessageLabel;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.TextBox customMessageTextBox;
        private System.Windows.Forms.Button sendMessageButton;
        private System.Windows.Forms.Button mongoButton;
        private System.Windows.Forms.Label wardNumber;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox wardNumberTextBox;
        private System.Windows.Forms.Label firstName;
        private System.Windows.Forms.Label LastName;
        private System.Windows.Forms.Button callApiButton;

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;

    }
}


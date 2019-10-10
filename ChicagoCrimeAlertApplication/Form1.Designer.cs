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
            this.phoneNumberLabel = new System.Windows.Forms.Label();
            this.customMessageLabel = new System.Windows.Forms.Label();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.customMessageTextBox = new System.Windows.Forms.TextBox();
            this.sendMessageButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.AutoSize = true;
            this.phoneNumberLabel.Location = new System.Drawing.Point(12, 20);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(81, 13);
            this.phoneNumberLabel.TabIndex = 0;
            this.phoneNumberLabel.Text = "Phone Number:";
            this.phoneNumberLabel.Click += new System.EventHandler(this.PhoneNumberLabel_Click);
            // 
            // customMessageLabel
            // 
            this.customMessageLabel.AutoSize = true;
            this.customMessageLabel.Location = new System.Drawing.Point(12, 61);
            this.customMessageLabel.Name = "customMessageLabel";
            this.customMessageLabel.Size = new System.Drawing.Size(91, 13);
            this.customMessageLabel.TabIndex = 1;
            this.customMessageLabel.Text = "Custom Message:";
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.Location = new System.Drawing.Point(109, 20);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(118, 20);
            this.phoneNumberTextBox.TabIndex = 2;
            // 
            // customMessageTextBox
            // 
            this.customMessageTextBox.Location = new System.Drawing.Point(109, 58);
            this.customMessageTextBox.Multiline = true;
            this.customMessageTextBox.Name = "customMessageTextBox";
            this.customMessageTextBox.Size = new System.Drawing.Size(202, 97);
            this.customMessageTextBox.TabIndex = 3;
            // 
            // sendMessageButton
            // 
            this.sendMessageButton.Location = new System.Drawing.Point(172, 174);
            this.sendMessageButton.Name = "sendMessageButton";
            this.sendMessageButton.Size = new System.Drawing.Size(75, 23);
            this.sendMessageButton.TabIndex = 4;
            this.sendMessageButton.Text = "SEND";
            this.sendMessageButton.UseVisualStyleBackColor = true;
            this.sendMessageButton.Click += new System.EventHandler(this.SendMessageButton_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sendMessageButton);
            this.Controls.Add(this.customMessageTextBox);
            this.Controls.Add(this.phoneNumberTextBox);
            this.Controls.Add(this.customMessageLabel);
            this.Controls.Add(this.phoneNumberLabel);
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
    }
}


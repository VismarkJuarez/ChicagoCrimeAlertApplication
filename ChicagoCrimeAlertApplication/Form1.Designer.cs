using System;

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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.crimeComboBox6 = new System.Windows.Forms.ComboBox();
            this.crimeComboBox5 = new System.Windows.Forms.ComboBox();
            this.crimeComboBox4 = new System.Windows.Forms.ComboBox();
            this.crimeComboBox3 = new System.Windows.Forms.ComboBox();
            this.crimeComboBox2 = new System.Windows.Forms.ComboBox();
            this.crimeComboBox1 = new System.Windows.Forms.ComboBox();
            this.crimeFrequencyByYearChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.executeQueryButton = new System.Windows.Forms.Button();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage4 = new MetroFramework.Controls.MetroTabPage();
            this.submitButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.wardTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.metroTabPage5 = new MetroFramework.Controls.MetroTabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.crimeComboBox7 = new System.Windows.Forms.ComboBox();
            this.crimeComboBox8 = new System.Windows.Forms.ComboBox();
            this.crimeComboBox9 = new System.Windows.Forms.ComboBox();
            this.crimeComboBox10 = new System.Windows.Forms.ComboBox();
            this.crimeFrequencyYearComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.crimeFrequencyByYearChart)).BeginInit();
            this.metroTabPage4.SuspendLayout();
            this.metroTabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(742, 36);
            this.panel1.TabIndex = 5;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Controls.Add(this.metroTabPage3);
            this.metroTabControl1.Controls.Add(this.metroTabPage4);
            this.metroTabControl1.Controls.Add(this.metroTabPage5);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(0, 0);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(1119, 492);
            this.metroTabControl1.TabIndex = 6;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.label1);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(1111, 453);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Welcome Page";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            this.metroTabPage1.Click += new System.EventHandler(this.metroTabPage1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(327, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcome Page";
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.label17);
            this.metroTabPage2.Controls.Add(this.label16);
            this.metroTabPage2.Controls.Add(this.label15);
            this.metroTabPage2.Controls.Add(this.label14);
            this.metroTabPage2.Controls.Add(this.label13);
            this.metroTabPage2.Controls.Add(this.label12);
            this.metroTabPage2.Controls.Add(this.label11);
            this.metroTabPage2.Controls.Add(this.label10);
            this.metroTabPage2.Controls.Add(this.label9);
            this.metroTabPage2.Controls.Add(this.label3);
            this.metroTabPage2.Controls.Add(this.label2);
            this.metroTabPage2.Controls.Add(this.crimeFrequencyYearComboBox);
            this.metroTabPage2.Controls.Add(this.crimeComboBox10);
            this.metroTabPage2.Controls.Add(this.crimeComboBox9);
            this.metroTabPage2.Controls.Add(this.crimeComboBox8);
            this.metroTabPage2.Controls.Add(this.crimeComboBox7);
            this.metroTabPage2.Controls.Add(this.crimeComboBox6);
            this.metroTabPage2.Controls.Add(this.crimeComboBox5);
            this.metroTabPage2.Controls.Add(this.crimeComboBox4);
            this.metroTabPage2.Controls.Add(this.crimeComboBox3);
            this.metroTabPage2.Controls.Add(this.crimeComboBox2);
            this.metroTabPage2.Controls.Add(this.crimeComboBox1);
            this.metroTabPage2.Controls.Add(this.crimeFrequencyByYearChart);
            this.metroTabPage2.Controls.Add(this.executeQueryButton);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(1111, 450);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Crime Statistics";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // crimeComboBox6
            // 
            this.crimeComboBox6.FormattingEnabled = true;
            this.crimeComboBox6.Items.AddRange(new object[] {
            "DECEPTIVE PRACTICE",
            "PROSTITUTION",
            "OTHER OFFENSE",
            "OBSCENITY",
            "THEFT",
            "LIQUOR LAW VIOLATION",
            "BURGLARY",
            "PUBLIC PEACE VIOLATION",
            "HOMICIDE",
            "BATTERY",
            "ARSON",
            "NARCOTICS",
            "OFFENSE INVOLVING CHILDREN",
            "GAMBLING",
            "HUMAN TRAFFICKING",
            "ASSAULT",
            "MOTOR VEHICLE THEFT",
            "INTIMIDATION",
            "CONCEALED CARRY LICENSE VIOLATION",
            "PUBLIC INDECENCY",
            "ROBBERY",
            "WEAPONS VIOLATION",
            "KIDNAPPING",
            "INTERFERENCE WITH PUBLIC OFFICER",
            "CRIM SEXUAL ASSAULT",
            "CRIMINAL TRESPASS",
            "CRIMINAL DAMAGE",
            "SEX OFFENSE",
            "STALKING",
            "OTHER NARCOTIC VIOLATION"});
            this.crimeComboBox6.Location = new System.Drawing.Point(244, 229);
            this.crimeComboBox6.Name = "crimeComboBox6";
            this.crimeComboBox6.Size = new System.Drawing.Size(218, 21);
            this.crimeComboBox6.TabIndex = 11;
            // 
            // crimeComboBox5
            // 
            this.crimeComboBox5.FormattingEnabled = true;
            this.crimeComboBox5.Items.AddRange(new object[] {
            "DECEPTIVE PRACTICE",
            "PROSTITUTION",
            "OTHER OFFENSE",
            "OBSCENITY",
            "THEFT",
            "LIQUOR LAW VIOLATION",
            "BURGLARY",
            "PUBLIC PEACE VIOLATION",
            "HOMICIDE",
            "BATTERY",
            "ARSON",
            "NARCOTICS",
            "OFFENSE INVOLVING CHILDREN",
            "GAMBLING",
            "HUMAN TRAFFICKING",
            "ASSAULT",
            "MOTOR VEHICLE THEFT",
            "INTIMIDATION",
            "CONCEALED CARRY LICENSE VIOLATION",
            "PUBLIC INDECENCY",
            "ROBBERY",
            "WEAPONS VIOLATION",
            "KIDNAPPING",
            "INTERFERENCE WITH PUBLIC OFFICER",
            "CRIM SEXUAL ASSAULT",
            "CRIMINAL TRESPASS",
            "CRIMINAL DAMAGE",
            "SEX OFFENSE",
            "STALKING",
            "OTHER NARCOTIC VIOLATION"});
            this.crimeComboBox5.Location = new System.Drawing.Point(244, 202);
            this.crimeComboBox5.Name = "crimeComboBox5";
            this.crimeComboBox5.Size = new System.Drawing.Size(218, 21);
            this.crimeComboBox5.TabIndex = 10;
            // 
            // crimeComboBox4
            // 
            this.crimeComboBox4.FormattingEnabled = true;
            this.crimeComboBox4.Items.AddRange(new object[] {
            "DECEPTIVE PRACTICE",
            "PROSTITUTION",
            "OTHER OFFENSE",
            "OBSCENITY",
            "THEFT",
            "LIQUOR LAW VIOLATION",
            "BURGLARY",
            "PUBLIC PEACE VIOLATION",
            "HOMICIDE",
            "BATTERY",
            "ARSON",
            "NARCOTICS",
            "OFFENSE INVOLVING CHILDREN",
            "GAMBLING",
            "HUMAN TRAFFICKING",
            "ASSAULT",
            "MOTOR VEHICLE THEFT",
            "INTIMIDATION",
            "CONCEALED CARRY LICENSE VIOLATION",
            "PUBLIC INDECENCY",
            "ROBBERY",
            "WEAPONS VIOLATION",
            "KIDNAPPING",
            "INTERFERENCE WITH PUBLIC OFFICER",
            "CRIM SEXUAL ASSAULT",
            "CRIMINAL TRESPASS",
            "CRIMINAL DAMAGE",
            "SEX OFFENSE",
            "STALKING",
            "OTHER NARCOTIC VIOLATION"});
            this.crimeComboBox4.Location = new System.Drawing.Point(244, 175);
            this.crimeComboBox4.Name = "crimeComboBox4";
            this.crimeComboBox4.Size = new System.Drawing.Size(218, 21);
            this.crimeComboBox4.TabIndex = 9;
            // 
            // crimeComboBox3
            // 
            this.crimeComboBox3.FormattingEnabled = true;
            this.crimeComboBox3.Items.AddRange(new object[] {
            "DECEPTIVE PRACTICE",
            "PROSTITUTION",
            "OTHER OFFENSE",
            "OBSCENITY",
            "THEFT",
            "LIQUOR LAW VIOLATION",
            "BURGLARY",
            "PUBLIC PEACE VIOLATION",
            "HOMICIDE",
            "BATTERY",
            "ARSON",
            "NARCOTICS",
            "OFFENSE INVOLVING CHILDREN",
            "GAMBLING",
            "HUMAN TRAFFICKING",
            "ASSAULT",
            "MOTOR VEHICLE THEFT",
            "INTIMIDATION",
            "CONCEALED CARRY LICENSE VIOLATION",
            "PUBLIC INDECENCY",
            "ROBBERY",
            "WEAPONS VIOLATION",
            "KIDNAPPING",
            "INTERFERENCE WITH PUBLIC OFFICER",
            "CRIM SEXUAL ASSAULT",
            "CRIMINAL TRESPASS",
            "CRIMINAL DAMAGE",
            "SEX OFFENSE",
            "STALKING",
            "OTHER NARCOTIC VIOLATION"});
            this.crimeComboBox3.Location = new System.Drawing.Point(244, 148);
            this.crimeComboBox3.Name = "crimeComboBox3";
            this.crimeComboBox3.Size = new System.Drawing.Size(218, 21);
            this.crimeComboBox3.TabIndex = 8;
            // 
            // crimeComboBox2
            // 
            this.crimeComboBox2.FormattingEnabled = true;
            this.crimeComboBox2.Items.AddRange(new object[] {
            "DECEPTIVE PRACTICE",
            "PROSTITUTION",
            "OTHER OFFENSE",
            "OBSCENITY",
            "THEFT",
            "LIQUOR LAW VIOLATION",
            "BURGLARY",
            "PUBLIC PEACE VIOLATION",
            "HOMICIDE",
            "BATTERY",
            "ARSON",
            "NARCOTICS",
            "OFFENSE INVOLVING CHILDREN",
            "GAMBLING",
            "HUMAN TRAFFICKING",
            "ASSAULT",
            "MOTOR VEHICLE THEFT",
            "INTIMIDATION",
            "CONCEALED CARRY LICENSE VIOLATION",
            "PUBLIC INDECENCY",
            "ROBBERY",
            "WEAPONS VIOLATION",
            "KIDNAPPING",
            "INTERFERENCE WITH PUBLIC OFFICER",
            "CRIM SEXUAL ASSAULT",
            "CRIMINAL TRESPASS",
            "CRIMINAL DAMAGE",
            "SEX OFFENSE",
            "STALKING",
            "OTHER NARCOTIC VIOLATION"});
            this.crimeComboBox2.Location = new System.Drawing.Point(244, 121);
            this.crimeComboBox2.Name = "crimeComboBox2";
            this.crimeComboBox2.Size = new System.Drawing.Size(218, 21);
            this.crimeComboBox2.TabIndex = 7;
            // 
            // crimeComboBox1
            // 
            this.crimeComboBox1.FormattingEnabled = true;
            this.crimeComboBox1.Items.AddRange(new object[] {
            "DECEPTIVE PRACTICE",
            "PROSTITUTION",
            "OTHER OFFENSE",
            "OBSCENITY",
            "THEFT",
            "LIQUOR LAW VIOLATION",
            "BURGLARY",
            "PUBLIC PEACE VIOLATION",
            "HOMICIDE",
            "BATTERY",
            "ARSON",
            "NARCOTICS",
            "OFFENSE INVOLVING CHILDREN",
            "GAMBLING",
            "HUMAN TRAFFICKING",
            "ASSAULT",
            "MOTOR VEHICLE THEFT",
            "INTIMIDATION",
            "CONCEALED CARRY LICENSE VIOLATION",
            "PUBLIC INDECENCY",
            "ROBBERY",
            "WEAPONS VIOLATION",
            "KIDNAPPING",
            "INTERFERENCE WITH PUBLIC OFFICER",
            "CRIM SEXUAL ASSAULT",
            "CRIMINAL TRESPASS",
            "CRIMINAL DAMAGE",
            "SEX OFFENSE",
            "STALKING",
            "OTHER NARCOTIC VIOLATION"});
            this.crimeComboBox1.Location = new System.Drawing.Point(244, 94);
            this.crimeComboBox1.Name = "crimeComboBox1";
            this.crimeComboBox1.Size = new System.Drawing.Size(218, 21);
            this.crimeComboBox1.TabIndex = 6;
            // 
            // crimeFrequencyByYearChart
            // 
            chartArea2.Name = "ChartArea1";
            this.crimeFrequencyByYearChart.ChartAreas.Add(chartArea2);
            this.crimeFrequencyByYearChart.ImeMode = System.Windows.Forms.ImeMode.On;
            legend2.Name = "Legend1";
            this.crimeFrequencyByYearChart.Legends.Add(legend2);
            this.crimeFrequencyByYearChart.Location = new System.Drawing.Point(468, 43);
            this.crimeFrequencyByYearChart.Name = "crimeFrequencyByYearChart";
            series2.ChartArea = "ChartArea1";
            series2.Font = new System.Drawing.Font("Microsoft Uighur", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.LabelAngle = 60;
            series2.Legend = "Legend1";
            series2.Name = "Crime Frequency";
            series2.XValueMember = "Crime";
            series2.YValueMembers = "Crime Frequency";
            this.crimeFrequencyByYearChart.Series.Add(series2);
            this.crimeFrequencyByYearChart.Size = new System.Drawing.Size(634, 344);
            this.crimeFrequencyByYearChart.TabIndex = 5;
            this.crimeFrequencyByYearChart.Text = "chart1";
            // 
            // executeQueryButton
            // 
            this.executeQueryButton.Location = new System.Drawing.Point(154, 364);
            this.executeQueryButton.Name = "executeQueryButton";
            this.executeQueryButton.Size = new System.Drawing.Size(100, 23);
            this.executeQueryButton.TabIndex = 4;
            this.executeQueryButton.Text = "Execute Query";
            this.executeQueryButton.UseVisualStyleBackColor = true;
            this.executeQueryButton.Click += new System.EventHandler(this.executeQueryButton_Click);
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 10;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(1111, 450);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "Crime Related News";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 10;
            // 
            // metroTabPage4
            // 
            this.metroTabPage4.Controls.Add(this.submitButton);
            this.metroTabPage4.Controls.Add(this.label8);
            this.metroTabPage4.Controls.Add(this.label7);
            this.metroTabPage4.Controls.Add(this.label6);
            this.metroTabPage4.Controls.Add(this.phoneNumberTextBox);
            this.metroTabPage4.Controls.Add(this.wardTextBox);
            this.metroTabPage4.Controls.Add(this.lastNameTextBox);
            this.metroTabPage4.Controls.Add(this.firstNameTextBox);
            this.metroTabPage4.Controls.Add(this.label4);
            this.metroTabPage4.HorizontalScrollbarBarColor = true;
            this.metroTabPage4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage4.HorizontalScrollbarSize = 10;
            this.metroTabPage4.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage4.Name = "metroTabPage4";
            this.metroTabPage4.Size = new System.Drawing.Size(1111, 453);
            this.metroTabPage4.TabIndex = 3;
            this.metroTabPage4.Text = "Alert System";
            this.metroTabPage4.VerticalScrollbarBarColor = true;
            this.metroTabPage4.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage4.VerticalScrollbarSize = 10;
            this.metroTabPage4.Click += new System.EventHandler(this.metroTabPage4_Click);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(332, 238);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 10;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(198, 210);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Phone Number: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(246, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "ward: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(218, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Last Name: ";
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.Location = new System.Drawing.Point(288, 203);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(174, 20);
            this.phoneNumberTextBox.TabIndex = 6;
            // 
            // wardTextBox
            // 
            this.wardTextBox.Location = new System.Drawing.Point(288, 172);
            this.wardTextBox.Name = "wardTextBox";
            this.wardTextBox.Size = new System.Drawing.Size(174, 20);
            this.wardTextBox.TabIndex = 5;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(288, 137);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(174, 20);
            this.lastNameTextBox.TabIndex = 4;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(288, 97);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(174, 20);
            this.firstNameTextBox.TabIndex = 3;
            this.firstNameTextBox.TextChanged += new System.EventHandler(this.firstNameTextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(219, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "First Name: ";
            // 
            // metroTabPage5
            // 
            this.metroTabPage5.Controls.Add(this.label5);
            this.metroTabPage5.HorizontalScrollbarBarColor = true;
            this.metroTabPage5.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage5.HorizontalScrollbarSize = 10;
            this.metroTabPage5.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage5.Name = "metroTabPage5";
            this.metroTabPage5.Size = new System.Drawing.Size(1111, 453);
            this.metroTabPage5.TabIndex = 4;
            this.metroTabPage5.Text = "About Us";
            this.metroTabPage5.VerticalScrollbarBarColor = true;
            this.metroTabPage5.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage5.VerticalScrollbarSize = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(339, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "About Us";
            // 
            // crimeComboBox7
            // 
            this.crimeComboBox7.FormattingEnabled = true;
            this.crimeComboBox7.Items.AddRange(new object[] {
            "DECEPTIVE PRACTICE",
            "PROSTITUTION",
            "OTHER OFFENSE",
            "OBSCENITY",
            "THEFT",
            "LIQUOR LAW VIOLATION",
            "BURGLARY",
            "PUBLIC PEACE VIOLATION",
            "HOMICIDE",
            "BATTERY",
            "ARSON",
            "NARCOTICS",
            "OFFENSE INVOLVING CHILDREN",
            "GAMBLING",
            "HUMAN TRAFFICKING",
            "ASSAULT",
            "MOTOR VEHICLE THEFT",
            "INTIMIDATION",
            "CONCEALED CARRY LICENSE VIOLATION",
            "PUBLIC INDECENCY",
            "ROBBERY",
            "WEAPONS VIOLATION",
            "KIDNAPPING",
            "INTERFERENCE WITH PUBLIC OFFICER",
            "CRIM SEXUAL ASSAULT",
            "CRIMINAL TRESPASS",
            "CRIMINAL DAMAGE",
            "SEX OFFENSE",
            "STALKING",
            "OTHER NARCOTIC VIOLATION"});
            this.crimeComboBox7.Location = new System.Drawing.Point(244, 256);
            this.crimeComboBox7.Name = "crimeComboBox7";
            this.crimeComboBox7.Size = new System.Drawing.Size(218, 21);
            this.crimeComboBox7.TabIndex = 12;
            // 
            // crimeComboBox8
            // 
            this.crimeComboBox8.FormattingEnabled = true;
            this.crimeComboBox8.Items.AddRange(new object[] {
            "DECEPTIVE PRACTICE",
            "PROSTITUTION",
            "OTHER OFFENSE",
            "OBSCENITY",
            "THEFT",
            "LIQUOR LAW VIOLATION",
            "BURGLARY",
            "PUBLIC PEACE VIOLATION",
            "HOMICIDE",
            "BATTERY",
            "ARSON",
            "NARCOTICS",
            "OFFENSE INVOLVING CHILDREN",
            "GAMBLING",
            "HUMAN TRAFFICKING",
            "ASSAULT",
            "MOTOR VEHICLE THEFT",
            "INTIMIDATION",
            "CONCEALED CARRY LICENSE VIOLATION",
            "PUBLIC INDECENCY",
            "ROBBERY",
            "WEAPONS VIOLATION",
            "KIDNAPPING",
            "INTERFERENCE WITH PUBLIC OFFICER",
            "CRIM SEXUAL ASSAULT",
            "CRIMINAL TRESPASS",
            "CRIMINAL DAMAGE",
            "SEX OFFENSE",
            "STALKING",
            "OTHER NARCOTIC VIOLATION"});
            this.crimeComboBox8.Location = new System.Drawing.Point(244, 283);
            this.crimeComboBox8.Name = "crimeComboBox8";
            this.crimeComboBox8.Size = new System.Drawing.Size(218, 21);
            this.crimeComboBox8.TabIndex = 13;
            // 
            // crimeComboBox9
            // 
            this.crimeComboBox9.FormattingEnabled = true;
            this.crimeComboBox9.Items.AddRange(new object[] {
            "DECEPTIVE PRACTICE",
            "PROSTITUTION",
            "OTHER OFFENSE",
            "OBSCENITY",
            "THEFT",
            "LIQUOR LAW VIOLATION",
            "BURGLARY",
            "PUBLIC PEACE VIOLATION",
            "HOMICIDE",
            "BATTERY",
            "ARSON",
            "NARCOTICS",
            "OFFENSE INVOLVING CHILDREN",
            "GAMBLING",
            "HUMAN TRAFFICKING",
            "ASSAULT",
            "MOTOR VEHICLE THEFT",
            "INTIMIDATION",
            "CONCEALED CARRY LICENSE VIOLATION",
            "PUBLIC INDECENCY",
            "ROBBERY",
            "WEAPONS VIOLATION",
            "KIDNAPPING",
            "INTERFERENCE WITH PUBLIC OFFICER",
            "CRIM SEXUAL ASSAULT",
            "CRIMINAL TRESPASS",
            "CRIMINAL DAMAGE",
            "SEX OFFENSE",
            "STALKING",
            "OTHER NARCOTIC VIOLATION"});
            this.crimeComboBox9.Location = new System.Drawing.Point(244, 310);
            this.crimeComboBox9.Name = "crimeComboBox9";
            this.crimeComboBox9.Size = new System.Drawing.Size(218, 21);
            this.crimeComboBox9.TabIndex = 14;
            // 
            // crimeComboBox10
            // 
            this.crimeComboBox10.FormattingEnabled = true;
            this.crimeComboBox10.Items.AddRange(new object[] {
            "DECEPTIVE PRACTICE",
            "PROSTITUTION",
            "OTHER OFFENSE",
            "OBSCENITY",
            "THEFT",
            "LIQUOR LAW VIOLATION",
            "BURGLARY",
            "PUBLIC PEACE VIOLATION",
            "HOMICIDE",
            "BATTERY",
            "ARSON",
            "NARCOTICS",
            "OFFENSE INVOLVING CHILDREN",
            "GAMBLING",
            "HUMAN TRAFFICKING",
            "ASSAULT",
            "MOTOR VEHICLE THEFT",
            "INTIMIDATION",
            "CONCEALED CARRY LICENSE VIOLATION",
            "PUBLIC INDECENCY",
            "ROBBERY",
            "WEAPONS VIOLATION",
            "KIDNAPPING",
            "INTERFERENCE WITH PUBLIC OFFICER",
            "CRIM SEXUAL ASSAULT",
            "CRIMINAL TRESPASS",
            "CRIMINAL DAMAGE",
            "SEX OFFENSE",
            "STALKING",
            "OTHER NARCOTIC VIOLATION"});
            this.crimeComboBox10.Location = new System.Drawing.Point(244, 337);
            this.crimeComboBox10.Name = "crimeComboBox10";
            this.crimeComboBox10.Size = new System.Drawing.Size(218, 21);
            this.crimeComboBox10.TabIndex = 15;
            // 
            // crimeFrequencyYearComboBox
            // 
            this.crimeFrequencyYearComboBox.FormattingEnabled = true;
            this.crimeFrequencyYearComboBox.Items.AddRange(new object[] {
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019"});
            this.crimeFrequencyYearComboBox.Location = new System.Drawing.Point(315, 54);
            this.crimeFrequencyYearComboBox.Name = "crimeFrequencyYearComboBox";
            this.crimeFrequencyYearComboBox.Size = new System.Drawing.Size(121, 21);
            this.crimeFrequencyYearComboBox.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(241, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Select Year: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(190, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Crime 1: ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(190, 124);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Crime 2: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(190, 151);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Crime 3: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(190, 178);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Crime 4: ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(190, 205);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Crime 5: ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Location = new System.Drawing.Point(190, 232);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 13);
            this.label13.TabIndex = 23;
            this.label13.Text = "Crime 6: ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label14.Location = new System.Drawing.Point(190, 259);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 13);
            this.label14.TabIndex = 24;
            this.label14.Text = "Crime 7: ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label15.Location = new System.Drawing.Point(190, 286);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 13);
            this.label15.TabIndex = 25;
            this.label15.Text = "Crime 8: ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label16.Location = new System.Drawing.Point(190, 313);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(48, 13);
            this.label16.TabIndex = 26;
            this.label16.Text = "Crime 9: ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label17.Location = new System.Drawing.Point(190, 340);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(54, 13);
            this.label17.TabIndex = 27;
            this.label17.Text = "Crime 10: ";
            // 
            // mainForm
            // 
            this.ClientSize = new System.Drawing.Size(1119, 492);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "mainForm";
            this.Text = "Chicago Crime Alert Application";
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.crimeFrequencyByYearChart)).EndInit();
            this.metroTabPage4.ResumeLayout(false);
            this.metroTabPage4.PerformLayout();
            this.metroTabPage5.ResumeLayout(false);
            this.metroTabPage5.PerformLayout();
            this.ResumeLayout(false);

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            
        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private MetroFramework.Controls.MetroTabPage metroTabPage4;
        private MetroFramework.Controls.MetroTabPage metroTabPage5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.TextBox wardTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button executeQueryButton;
        private System.Windows.Forms.ComboBox crimeComboBox1;
        private System.Windows.Forms.ComboBox crimeComboBox6;
        private System.Windows.Forms.ComboBox crimeComboBox5;
        private System.Windows.Forms.ComboBox crimeComboBox4;
        private System.Windows.Forms.ComboBox crimeComboBox3;
        private System.Windows.Forms.ComboBox crimeComboBox2;
        public System.Windows.Forms.DataVisualization.Charting.Chart crimeFrequencyByYearChart;
        private System.Windows.Forms.ComboBox crimeComboBox10;
        private System.Windows.Forms.ComboBox crimeComboBox9;
        private System.Windows.Forms.ComboBox crimeComboBox8;
        private System.Windows.Forms.ComboBox crimeComboBox7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox crimeFrequencyYearComboBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
    }
}


namespace View
{
    partial class UserView
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
            this.fullNameLabel = new System.Windows.Forms.Label();
            this.voterIDLabel = new System.Windows.Forms.Label();
            this.occupationLabel = new System.Windows.Forms.Label();
            this.dateOfBirthLabel = new System.Windows.Forms.Label();
            this.phoneNumberLabel = new System.Windows.Forms.Label();
            this.fullNameTextBox = new System.Windows.Forms.TextBox();
            this.voterIDTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.ocuupationTextBox = new System.Windows.Forms.TextBox();
            this.dateOfBirthPicker = new System.Windows.Forms.DateTimePicker();
            this.gridOrders = new System.Windows.Forms.ListView();
            this.submitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fullNameLabel
            // 
            this.fullNameLabel.AutoSize = true;
            this.fullNameLabel.Location = new System.Drawing.Point(45, 41);
            this.fullNameLabel.Name = "fullNameLabel";
            this.fullNameLabel.Size = new System.Drawing.Size(54, 13);
            this.fullNameLabel.TabIndex = 0;
            this.fullNameLabel.Text = "Full Name";
            // 
            // voterIDLabel
            // 
            this.voterIDLabel.AutoSize = true;
            this.voterIDLabel.Location = new System.Drawing.Point(45, 125);
            this.voterIDLabel.Name = "voterIDLabel";
            this.voterIDLabel.Size = new System.Drawing.Size(86, 13);
            this.voterIDLabel.TabIndex = 1;
            this.voterIDLabel.Text = "Voter ID Number";
            // 
            // occupationLabel
            // 
            this.occupationLabel.AutoSize = true;
            this.occupationLabel.Location = new System.Drawing.Point(45, 205);
            this.occupationLabel.Name = "occupationLabel";
            this.occupationLabel.Size = new System.Drawing.Size(62, 13);
            this.occupationLabel.TabIndex = 2;
            this.occupationLabel.Text = "Occupation";
            // 
            // dateOfBirthLabel
            // 
            this.dateOfBirthLabel.AutoSize = true;
            this.dateOfBirthLabel.Location = new System.Drawing.Point(307, 41);
            this.dateOfBirthLabel.Name = "dateOfBirthLabel";
            this.dateOfBirthLabel.Size = new System.Drawing.Size(68, 13);
            this.dateOfBirthLabel.TabIndex = 3;
            this.dateOfBirthLabel.Text = "Date Of Birth";
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.AutoSize = true;
            this.phoneNumberLabel.Location = new System.Drawing.Point(307, 125);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(81, 13);
            this.phoneNumberLabel.TabIndex = 4;
            this.phoneNumberLabel.Text = "Phone Number ";
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.Location = new System.Drawing.Point(48, 83);
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.fullNameTextBox.TabIndex = 5;
            this.fullNameTextBox.Text = "Full Name";
            // 
            // voterIDTextBox
            // 
            this.voterIDTextBox.Location = new System.Drawing.Point(48, 169);
            this.voterIDTextBox.Name = "voterIDTextBox";
            this.voterIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.voterIDTextBox.TabIndex = 6;
            this.voterIDTextBox.Text = "Voter ID";
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.Location = new System.Drawing.Point(310, 169);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.phoneNumberTextBox.TabIndex = 7;
            this.phoneNumberTextBox.Text = "Phone Number ";
            // 
            // ocuupationTextBox
            // 
            this.ocuupationTextBox.Location = new System.Drawing.Point(48, 244);
            this.ocuupationTextBox.Name = "ocuupationTextBox";
            this.ocuupationTextBox.Size = new System.Drawing.Size(100, 20);
            this.ocuupationTextBox.TabIndex = 9;
            this.ocuupationTextBox.Text = "Ocuupation";
            // 
            // dateOfBirthPicker
            // 
            this.dateOfBirthPicker.Location = new System.Drawing.Point(310, 83);
            this.dateOfBirthPicker.Name = "dateOfBirthPicker";
            this.dateOfBirthPicker.Size = new System.Drawing.Size(200, 20);
            this.dateOfBirthPicker.TabIndex = 10;
            // 
            // gridOrders
            // 
            this.gridOrders.FullRowSelect = true;
            this.gridOrders.GridLines = true;
            this.gridOrders.Location = new System.Drawing.Point(48, 288);
            this.gridOrders.Name = "gridOrders";
            this.gridOrders.Size = new System.Drawing.Size(680, 153);
            this.gridOrders.TabIndex = 3;
            this.gridOrders.UseCompatibleStateImageBehavior = false;
            this.gridOrders.View = System.Windows.Forms.View.Details;
            this.gridOrders.SelectedIndexChanged += new System.EventHandler(this.gridOrders_SelectedIndexChanged);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(566, 169);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(110, 49);
            this.submitButton.TabIndex = 12;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // UserView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 467);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.gridOrders);
            this.Controls.Add(this.dateOfBirthPicker);
            this.Controls.Add(this.ocuupationTextBox);
            this.Controls.Add(this.phoneNumberTextBox);
            this.Controls.Add(this.voterIDTextBox);
            this.Controls.Add(this.fullNameTextBox);
            this.Controls.Add(this.phoneNumberLabel);
            this.Controls.Add(this.dateOfBirthLabel);
            this.Controls.Add(this.occupationLabel);
            this.Controls.Add(this.voterIDLabel);
            this.Controls.Add(this.fullNameLabel);
            this.Name = "UserView";
            this.Text = "Reservation";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fullNameLabel;
        private System.Windows.Forms.Label voterIDLabel;
        private System.Windows.Forms.Label occupationLabel;
        private System.Windows.Forms.Label dateOfBirthLabel;
        private System.Windows.Forms.Label phoneNumberLabel;
        private System.Windows.Forms.TextBox fullNameTextBox;
        private System.Windows.Forms.TextBox voterIDTextBox;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.TextBox ocuupationTextBox;
        private System.Windows.Forms.DateTimePicker dateOfBirthPicker;
        private System.Windows.Forms.Button submitButton;
        internal System.Windows.Forms.ListView gridOrders;
    }
}
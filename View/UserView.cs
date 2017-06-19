using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controller;
using Model;
using System.Configuration;
using System.Data.SqlClient;

namespace View
{
    public partial class UserView : Form, IUserView
    {
        //string connstr = Reservation.Utility.GetConnectionString();
        //connection string er method
        internal static string GetConnectionString()
        {
            //Util-2 Assume failure.  
            string returnValue = null;

            //Util-3 Look for the name in the connectionStrings section.  
            //ConnectionStringSettings settings =
            //ConfigurationManager.ConnectionStrings["Reservation.Properties.Settings.connString"];
            string settings = "Data Source=./;Initial Catalog=demo;Persist Security Info=True;User ID=sa;Password=ddm@TT";

            //If found, return the connection string.  
            //if (settings != null)
            //    returnValue = settings.ConnectionString;

            return settings;
        }
      
        SqlConnection conn = new SqlConnection(UserView.GetConnectionString());


        public UserView()
        {
            InitializeComponent();
        }
        UserController _controller;

        public int Age
        {
            set
            {
                throw new NotImplementedException();
            }
        }

        public string DateOfBirth
        {
            get
            {
                return this.dateOfBirthPicker.Text;
            }

            set
            {
                this.dateOfBirthPicker.Text=value;
            }
        }

        public string FullName
        {
            get
            {
                return this.fullNameTextBox.Text;
            }

            set
            {
                this.fullNameTextBox.Text=value;
            }
        }

        public string Occupation
        {
            get
            {
                return this.ocuupationTextBox.Text;
            }

            set
            {
                this.ocuupationTextBox.Text=value;
            }
        }

        public string PhoneNumber
        {
            get
            {
                return this.phoneNumberTextBox.Text;
            }

            set
            {
                this.phoneNumberTextBox.Text = value;
            }
        }

        public string VoterID
        {
            get
            {
                return this.voterIDTextBox.Text;
            }

            set
            {
                this.voterIDTextBox.Text = value;
            }
        }

        public void ClearGrid()
        {
            this.gridOrders.Columns.Clear();

            this.gridOrders.Columns.Add("Full Name", 150, HorizontalAlignment.Left);
            this.gridOrders.Columns.Add("VoterID", 150, HorizontalAlignment.Left);
            this.gridOrders.Columns.Add("Occupation", 150, HorizontalAlignment.Left);
            this.gridOrders.Columns.Add("Date Of Birth", 150, HorizontalAlignment.Left);
            this.gridOrders.Columns.Add("Phone Number", 150, HorizontalAlignment.Left);

            // Add rows to grid
            this.gridOrders.Items.Clear();
        }
        public void AddUserToGrid(Data user)
        {
            ListViewItem parent;
            parent = this.gridOrders.Items.Add(user.FullName);
            parent.SubItems.Add(user.VoterID);
            parent.SubItems.Add(user.Occupation);
            parent.SubItems.Add(user.DateOfBirth);
            parent.SubItems.Add(user.PhoneNumber);
            DisplayData();
        }
        //Display Data in DataGridView  
        public void DisplayData()
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT FullName, VoterID, Occupation, DateOfBirth, PhoneNumber FROM Reservedemo", conn);
            SqlDataReader objRead = cmd.ExecuteReader();
            this.gridOrders.Items.Clear();
            while (objRead.Read())
            {
                ListViewItem parent;
                parent = this.gridOrders.Items.Add(objRead["FullName"].ToString());
                parent.SubItems.Add(objRead["VoterID"].ToString());
                parent.SubItems.Add(objRead["Occupation"].ToString());
                parent.SubItems.Add(objRead["DateOfBirth"].ToString());
                parent.SubItems.Add(objRead["PhoneNumber"].ToString());
            }

                conn.Close();
        }


        public void SetController(Controller.UserController controller)
        {
            _controller = controller;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            this._controller.Save();

            //inserting into database
           
            conn.Open();
            
            //  int phoneNumber = Convert.ToInt32(user.PhoneNumber);
            //string query = "INSERT INTO RESERVEDEMO (FullName,VoterID,Occupation,DateOfBirth,PhoneNumber) VALUES ( " +
            //    " +fullNameTextBox.Text+","+voterIDTextBox.Text+","+ ocuupationTextBox.Text+","+ );";

            string query = "INSERT INTO Reservedemo (FullName, VoterID,Occupation,DateOfBirth, PhoneNumber) VALUES (@FullName,@VoterID,@Occupation,@DateOfBirth,@PhoneNumber)";

            // 
            //string query = "INSERT INTO RESERVEDEMO (FullName, VoterID,Occupation,DateOfBirth, PhoneNumber) VALUES ('" + fullNameTextBox.Text + "','" + voterIDTextBox.Text + "','" + ocuupationTextBox.Text + "','" + dateOfBirthPicker.Text + "','" + phoneNumberTextBox.Text + "')";


            //     INSERT INTO TABLE_NAME(column1, column2, column3,...columnN) VALUES(value1, value2, value3,...valueN);
            SqlCommand cmd = new SqlCommand(query, conn);


            cmd.Parameters.AddWithValue("@FullName", fullNameTextBox.Text);
            cmd.Parameters.AddWithValue("@VoterID", voterIDTextBox.Text);
            cmd.Parameters.AddWithValue("@Occupation", ocuupationTextBox.Text);
            cmd.Parameters.AddWithValue("@DateOfBirth", dateOfBirthPicker.Text);
            cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumberTextBox.Text);

            var check = cmd.ExecuteNonQuery();


            conn.Close();

        }

        private void gridOrders_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

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

namespace View
{
    public partial class UserView : Form, IUserView
    {
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
                this.ocuupationTextBox.Text = value;
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
        }

        private void gridOrders_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

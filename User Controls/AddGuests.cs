using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management_System.User_Controls
{
    public partial class AddGuests : UserControl
    {
        public AddGuests()
        {
            InitializeComponent();
        }

        DataTable guestList = new DataTable();

        private void AddGuests_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                DataAccess db = new DataAccess();
                guestList = db.SearchGuests(guestSearchTextBox.Text);
                guestsList.DataSource = guestList;
                guestsList.ClearSelection();
                guestsList.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void addGuestButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            if (db.checkGuestExists(guestEmail.Text) == true)
            {
                errorLabel.Visible = true;
                errorLabel.Text = "Email is taken.";
            }
            else if (guestFirstName.Text == "" || guestLastName.Text == "" || guestPhoneNumber.Text == "" || guestEmail.Text == "")
            {
                errorLabel.Visible = true;
                errorLabel.Text = "Please fill out all fields.";
            }
            else if (guestPhoneNumber.Text.All(char.IsDigit) == false)
            {
                errorLabel.Visible = true;
                errorLabel.Text = "Phonenumber must only contain numbers.";
            }
            else
            {
                db.RegisterGuest(guestFirstName.Text, guestLastName.Text, Convert.ToInt64(guestPhoneNumber.Text), guestEmail.Text);
                MessageBox.Show("Guest registered successfully.");
                errorLabel.Visible = false;

                guestList = db.SearchGuests(guestSearchTextBox.Text);
                guestsList.DataSource = guestList;
                guestsList.ClearSelection();

                guestFirstName.Text = "";
                guestLastName.Text = "";
                guestPhoneNumber.Text = "";
                guestEmail.Text = "";
            }
        }

        private void guestSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            guestList = db.SearchGuests(guestSearchTextBox.Text);
            guestsList.DataSource = guestList;
            guestsList.ClearSelection();
        }

        private void deleteGuestButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            if (db.checkGuestExists(delGuestTextBox.Text) == true && delGuestTextBox.Text != "")
            {
                MessageBox.Show("Guest deleted succesfully.");
                db.DeleteGuest(delGuestTextBox.Text);
                delGuestTextBox.Text = "";
                guestList = db.SearchGuests(guestSearchTextBox.Text);
                guestsList.DataSource = guestList;
                errorLabelGuests.Visible = false;
            }
            else
            {
                errorLabelGuests.Visible = true;
                delGuestTextBox.Text = "";
            }
        }
    }
}

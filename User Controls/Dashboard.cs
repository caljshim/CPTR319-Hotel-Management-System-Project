using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management_System.User_Controls
{
    public partial class Dashboard : UserControl
    {
        DataAccess db = new DataAccess();
        List<AmenityModel> AllAmenities = new List<AmenityModel>();

        public Dashboard()
        {
            InitializeComponent();
        }
         private void Dashboard_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                guestCountLabel.Text = $"Registered Guests: {db.CountGuests()}";
                roomCountLabel.Text = $"Registered Rooms: {db.CountRooms()}";
                reservationsCountLabel.Text = $"Current Reservations: {db.CountCurrentReservations()}";
                employeeCountLabel.Text = $"Employees: {db.CountEmployees()}";

                updateAmenityList();
            }
        }

        private void addAmenityButton_Click(object sender, EventArgs e)
        {
            Form CreateAmenity = new CreateAmenitiesForm();
            CreateAmenity.Show();
        }

        public void updateAmenityList()
        {
            AllAmenities = db.UpdateAmenityList();
            amenitiesList.DataSource = AllAmenities;
            amenitiesList.DisplayMember = "AmenityInfo";
            amenitiesList.ValueMember = "AmenityKey";
        }

        private void delAmenityButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to delete this amenity?", "Delete Amenity", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                if (amenitiesList.SelectedIndex != -1)
                {
                    db.DeleteAmenity(Convert.ToInt32(amenitiesList.SelectedValue));
                    updateAmenityList();
                    MessageBox.Show("Amenity deleted successfully.");
                }
            }
        }

        private void editAmenityButton_Click(object sender, EventArgs e)
        {
            EditAmenitiesForm EditAmenity = new EditAmenitiesForm();
            EditAmenity.editPrimaryKey = Convert.ToInt32(amenitiesList.SelectedValue);
            EditAmenity.Show();
        }

        private void viewAmenityButton_Click(object sender, EventArgs e)
        {
            ViewAmenity ViewAmenity = new ViewAmenity();
            ViewAmenity.editPrimaryKey = Convert.ToInt32(amenitiesList.SelectedValue);
            ViewAmenity.Show();
        }
    }
}

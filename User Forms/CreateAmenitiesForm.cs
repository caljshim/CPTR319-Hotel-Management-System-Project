using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management_System
{
    public partial class CreateAmenitiesForm : Form
    {
        DataAccess db =  new DataAccess();
        public CreateAmenitiesForm()
        {
            InitializeComponent();
        }

        private void cancelAmenityButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Progress will not be saved. Do you still want to cancel?", "Cancel Amenity Creation", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void addAmenityButton_Click(object sender, EventArgs e)
        {
            if (amenityNameTextBox.Text == "")
            {
                errorLabel.Text = "Please enter a name.";
                errorLabel.Visible = true;
            }
            else if (descriptionTextBox.Text == "")
            {
                errorLabel.Text = "Please enter a description.";
                errorLabel.Visible = true;
            }
            else
            {
                db.AddAmenity(amenityNameTextBox.Text, descriptionTextBox.Text);

                HomeForm homeForm = Application.OpenForms["Home"] as HomeForm;

                homeForm.updateDashboard();

                DialogResult = MessageBox.Show("Amenity added successfully.");
                if (DialogResult == DialogResult.OK)
                {
                    this.Close();
                }
            }
        }
    }
}

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
    public partial class EditAmenitiesForm : Form
    {
        DataAccess db = new DataAccess();
        public int editPrimaryKey { get; set; }
        public EditAmenitiesForm()
        {
            InitializeComponent();
        }

        private void EditAmenity_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                List<string> amenityNameAndDesc = db.GetAmenityNameAndDesc(editPrimaryKey);
                editAmenityTextBox.Text = amenityNameAndDesc[0];
                editDescriptionTextBox.Text = amenityNameAndDesc[1];
            }
        }
        private void saveAmenityButton_Click(object sender, EventArgs e)
        {
            if (editAmenityTextBox.Text == "")
            {
                errorLabel.Text = "Please enter a name.";
                errorLabel.Visible = true;
            }
            else if (editDescriptionTextBox.Text == "")
            {
                errorLabel.Text = "Please enter a description.";
                errorLabel.Visible = true;
            }
            else
            {
                db.EditAmenity(editPrimaryKey, editAmenityTextBox.Text, editDescriptionTextBox.Text);

                HomeForm homeForm = Application.OpenForms["Home"] as HomeForm;

                homeForm.updateDashboard();

                DialogResult = MessageBox.Show("Amenity edited successfully.");
                if (DialogResult == DialogResult.OK)
                {
                    this.Close();
                }
            }
        }

        private void cancelAmenityButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Progress will not be saved. Do you still want to cancel?", "Cancel Amenity Edit", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}

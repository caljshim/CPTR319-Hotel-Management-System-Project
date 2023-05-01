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
    public partial class ViewAmenity : Form
    {
        DataAccess db = new DataAccess();
        public int editPrimaryKey { get; set; }
        public ViewAmenity()
        {
            InitializeComponent();
        }
        private void ViewAmenity_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                descriptionTextBox.ReadOnly = true;
                List<string> amenityNameAndDesc = db.GetAmenityNameAndDesc(editPrimaryKey);
                amenityName.Text = amenityNameAndDesc[0];
                descriptionTextBox.Text = amenityNameAndDesc[1];
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

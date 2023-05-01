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
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
            this.Name = "Home";
            this.FormClosing += form_closing;
        }

        private void MovePanel(Control btn)
        {
            panelSlide.Top = btn.Top;
            panelSlide.Height = btn.Height;
        }

        private void ButtonDashboard_click(object sender, EventArgs e)
        {
            MovePanel(buttonDashboard);
            addEmployees2.Hide();
            addGuests1.Hide();
            addRooms1.Hide();
            addReservations2.Hide();
            dashboard1.Show();

        }

        private void ButtonGuests_click(object sender, EventArgs e)
        {
            MovePanel(buttonGuests);
            addEmployees2.Hide();
            addGuests1.Show();
            addRooms1.Hide();
            addReservations2.Hide();
            dashboard1.Hide();
        }

        private void ButtonRooms_click(object sender, EventArgs e)
        {
            MovePanel(buttonRooms);
            addEmployees2.Hide();
            addGuests1.Hide();
            addRooms1.Show();
            addReservations2.Hide();
            dashboard1.Hide();
        }

        private void ButtonReservations_click(object sender, EventArgs e)
        {
            MovePanel(buttonReservations);
            addGuests1.Hide();
            addEmployees2.Hide();
            addRooms1.Hide();
            addReservations2.Show();
            dashboard1.Hide();
            addReservations2.updateReservationsSearch();
        }

        private void ButtonSettings_click(object sender, EventArgs e)
        {
            MovePanel(buttonSettings);
            addGuests1.Hide();
            addEmployees2.Show();
            addRooms1.Hide();
            addReservations2.Hide();
            dashboard1.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            Form login = new Login();
            login.Show();
        }

        public void updateDashboard()
        {
            dashboard1.updateAmenityList();
        }

        private void form_closing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }
    }
}

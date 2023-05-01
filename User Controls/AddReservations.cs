using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hotel_Management_System.User_Controls
{
    public partial class AddReservations : UserControl
    {
        List<RoomModel> availableRoomsList = new List<RoomModel>();
        DataAccess db = new DataAccess();
        DataTable AllReservationsList = new DataTable();
        public AddReservations()
        {
            InitializeComponent();
        }
        private void AddReservations_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                dateTimeCkIn.MinDate = DateTime.Today;
                dateTimeCkOut.MinDate = DateTime.Today;

                dateTimeCkIn.CustomFormat = "yyyy-MM-dd";
                dateTimeCkIn.Format = DateTimePickerFormat.Custom;

                dateTimeCkOut.CustomFormat = "yyyy-MM-dd";
                dateTimeCkOut.Format = DateTimePickerFormat.Custom;

                availableRoomsList = db.checkAvailableRooms(dateTimeCkIn.Text, dateTimeCkOut.Text);

                updateAvailableRooms();
                updateReservationsSearch();

                comboBoxRoom.SelectedIndex = 0;
                comboBoxRoom.DropDownStyle = ComboBoxStyle.DropDownList;

                updatePrice();
            }
        }
        public void updateAvailableRooms()
        {
            availableRoomsList = db.checkAvailableRooms(dateTimeCkIn.Text, dateTimeCkOut.Text);
            if (availableRoomsList.Count == 0)
            {
                var empty = new[] { "No rooms available." };
                addReservationButton.Enabled = false;
                AddReservationErrorLabel.Text = "No rooms available.";
                AddReservationErrorLabel.Visible = true;
                comboBoxRoom.DataSource = empty;
            }
            else
            {
                AddReservationErrorLabel.Visible = false;
                addReservationButton.Enabled = true;
                comboBoxRoom.DataSource = availableRoomsList;
                comboBoxRoom.DisplayMember = "FullInfo";
            }
            comboBoxRoom.SelectedIndex = 0;
            comboBoxRoom.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void addReservationButton_Click(object sender, EventArgs e)
        {
            if (db.checkGuestExists(addReservationEmail.Text) == false)
            {
                AddReservationErrorLabel.Text = "Guest email not found.";
                addReservationEmail.Text = "";
                AddReservationErrorLabel.Visible = true;
            }
            else if (Math.Round((dateTimeCkOut.Value - dateTimeCkIn.Value).TotalDays) == 0)
            {
                AddReservationErrorLabel.Text = "Reservations must be at least one day.";
                AddReservationErrorLabel.Visible = true;
            }
            else
            {
                string roomNumber = comboBoxRoom.Text.TrimStart('#');
                roomNumber = roomNumber.Remove(roomNumber.IndexOf(":"));
                db.AddReservation(Convert.ToInt32(roomNumber), addReservationEmail.Text, dateTimeCkIn.Text, dateTimeCkOut.Text, Convert.ToDecimal(priceLabel.Text.TrimStart('$')));
                MessageBox.Show("Reservation added successfully.");
                AddReservationErrorLabel.Visible = false;
                addReservationEmail.Text = "";

                updateAvailableRooms();
                updatePrice();
                updateReservationsSearch();
            }
        }

        private void updatePrice()
        {
            decimal price;
            decimal pricePerDay = 0;
            decimal days;
            char[] trim = { '1', '2', '3', '4', '5', '6', '7', '8', '9', ' ', '#', ':' };
            days = Convert.ToDecimal((dateTimeCkOut.Value - dateTimeCkIn.Value).TotalDays);
            days = Math.Round(days);
            if (comboBoxRoom.Text.Contains("No rooms available."))
            {
                price = 0;
            }
            else
            {
                price = days * db.GetPrice(comboBoxRoom.Text.TrimStart(trim));
            }
            if (days != 0)
            {
                pricePerDay = price / days;
            }

            string priceString = price.ToString("C");
            string pricePerDayString = pricePerDay.ToString("C");
            priceLabel.Text = priceString;
            priceLabel.Visible = true;

            pricePerDayLabel.Text = pricePerDayString;
            pricePerDayLabel.Visible = true;
        }

        private void dateTimeCkIn_ValueChanged(object sender, EventArgs e)
        {
            updateAvailableRooms();
            dateTimeCkOut.MinDate = dateTimeCkIn.Value;
            updatePrice();
        }

        private void dateTimeCkOut_ValueChanged(object sender, EventArgs e)
        {
            updateAvailableRooms();
            updatePrice();
        }

        private void comboBoxRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            updatePrice();
        }

        public void updateReservationsSearch()
        {
            AllReservationsList = db.SearchReservation(allReservationsSearchEmail.Text);
            allReservationsList.DataSource = AllReservationsList;
            allReservationsList.ClearSelection();
        }

        private void allReservationsSearchEmail_TextChanged(object sender, EventArgs e)
        {
            updateReservationsSearch();
        }

        private void allReservationsList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to delete this reservation?", "Delete Reservation Type", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                if (e.RowIndex != -1)
                {
                    DataGridViewRow row = allReservationsList.Rows[e.RowIndex];
                    db.DeleteReservation(Convert.ToInt32(row.Cells[0].Value));

                    updateReservationsSearch();
                    updateAvailableRooms();
                    updatePrice();
                }
            }
        }
    }
}

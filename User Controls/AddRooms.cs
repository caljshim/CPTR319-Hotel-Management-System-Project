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
    public partial class AddRooms : UserControl
    {
        DataAccess db = new DataAccess();
        DataTable roomList = new DataTable();
        DataTable roomTypeListData = new DataTable();
        List<RoomTypeModel> roomTypeComboBoxList= new List<RoomTypeModel>();

        public AddRooms()
        {
            InitializeComponent();
        }
        private void AddRooms_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                roomList = db.SearchRooms(roomSearchTextBox.Text);
                roomsList.DataSource = roomList;
                roomsList.ClearSelection();

                roomTypeListData = db.updateRoomTypeList();
                roomTypeList.DataSource = roomTypeListData;
                roomTypeList.ClearSelection();

                roomTypeComboBoxList = db.updateRoomTypeComboBox();
                comboBox1.DataSource = roomTypeComboBoxList;
                comboBox1.DisplayMember = "RoomTypeInfo";

                if (comboBox1.Items.Count == 0)
                {
                    comboBox1.Items.Add("No room types");
                }

                comboBox1.SelectedIndex = 0;
                comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            }
        }

        private void addRoomButton_Click(object sender, EventArgs e)
        {
            if (addRoomNumberTextBox.Text == "" || addRoomNumberTextBox.Text.All(char.IsDigit) == false)
            {
                AddRoomErrorLabel.Text = "Please enter a valid room number.";
                AddRoomErrorLabel.Visible = true;
                addRoomNumberTextBox.Text = "";
            }
            else if (db.checkRoomExists(Convert.ToInt32(addRoomNumberTextBox.Text)) == true)
            {
                AddRoomErrorLabel.Text = "Room number already registered.";
                AddRoomErrorLabel.Visible = true;
                addRoomNumberTextBox.Text = "";
            }
            else
            {
                string roomTypeString = comboBox1.Text.Remove(comboBox1.Text.IndexOf(":"));
                db.AddRoom(roomTypeString, Convert.ToInt32(addRoomNumberTextBox.Text));
                MessageBox.Show("Room registered successfully.");
                AddRoomErrorLabel.Visible = false;
                addRoomNumberTextBox.Text = "";

                roomList = db.SearchRooms(addRoomNumberTextBox.Text);
                roomsList.DataSource = roomList;
                roomsList.ClearSelection();
            }
        }

        private void roomSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            roomList = db.SearchRooms(roomSearchTextBox.Text);
            roomsList.DataSource = roomList;
            roomsList.ClearSelection();
        }

        private void deleteRoomsButton_Click(object sender, EventArgs e)
        {
            if (deleteRoomsTextBox.Text != "")
            {
                if (db.checkRoomExists(Convert.ToInt32(deleteRoomsTextBox.Text)) == true)
                {
                    MessageBox.Show("Room deleted succesfully.");
                    db.DeleteRoom(Convert.ToInt32(deleteRoomsTextBox.Text));
                    deleteRoomsTextBox.Text = "";

                    roomList = db.SearchRooms(deleteRoomsTextBox.Text);
                    roomsList.DataSource = roomList;
                    comboBox1.DataSource = roomTypeListData;
                    comboBox1.DisplayMember = "FullInfo";

                    roomTypeListData = db.updateRoomTypeList();
                    roomTypeList.DataSource = roomTypeListData;
                    roomTypeList.ClearSelection();

                    roomTypeComboBoxList = db.updateRoomTypeComboBox();
                    comboBox1.DataSource = roomTypeComboBoxList;
                    comboBox1.DisplayMember = "RoomTypeInfo";

                    deleteRoomsErrorLabel.Visible = false;
                }
            }
            else
            {
                deleteRoomsErrorLabel.Text = "Room not found.";
                deleteRoomsErrorLabel.Visible = true;
            }
        }

        private void addRoomTypeButton_Click(object sender, EventArgs e)
        {
            if (db.checkRoomTypeExists(addRoomTypeTextBox.Text))
            {
                addRoomTypeErrorLabel.Text = "Room type already exists.";
                addRoomTypeErrorLabel.Visible = true;
                addRoomTypeTextBox.Text = "";
                addRoomTypePriceTextBox.Text = "";
            }
            else if (addRoomTypeTextBox.Text == "")
            {
                addRoomTypeErrorLabel.Text = "Please enter a room type.";
                addRoomTypeErrorLabel.Visible = true;
                addRoomTypeTextBox.Text = "";
                addRoomTypePriceTextBox.Text = "";
            }
            else if (addRoomTypePriceTextBox.Text == "" || decimal.TryParse(addRoomTypePriceTextBox.Text, out decimal result) == false)
            {
                addRoomTypeErrorLabel.Text = "Invalid price.";
                addRoomTypeErrorLabel.Visible = true;
                addRoomTypeTextBox.Text = "";
                addRoomTypePriceTextBox.Text = "";
            }
            else
            {
                db.AddRoomType(addRoomTypeTextBox.Text, Convert.ToDecimal(addRoomTypePriceTextBox.Text));
                MessageBox.Show("Room type added successfully.");
                addRoomTypeErrorLabel.Visible = false;
                addRoomTypeTextBox.Text = "";
                addRoomTypePriceTextBox.Text = "";

                roomTypeListData = db.updateRoomTypeList();
                roomTypeList.DataSource = roomTypeListData;
                roomTypeList.ClearSelection();

                roomTypeComboBoxList = db.updateRoomTypeComboBox();
                comboBox1.DataSource = roomTypeComboBoxList;
                comboBox1.DisplayMember = "RoomTypeInfo";
            }
        }

        private void roomTypeList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to delete this room type?", "Delete Room Type", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                if (e.RowIndex != -1)
                {
                    DataGridViewRow row = roomTypeList.Rows[e.RowIndex];
                    db.DeleteRoomType(row.Cells[0].Value.ToString());

                    roomList = db.SearchRooms(roomSearchTextBox.Text);
                    roomsList.DataSource = roomList;
                    roomsList.ClearSelection();

                    roomTypeListData = db.updateRoomTypeList();
                    roomTypeList.DataSource = roomTypeListData;
                    roomTypeList.ClearSelection();

                    roomTypeComboBoxList = db.updateRoomTypeComboBox();
                    comboBox1.DataSource = roomTypeComboBoxList;
                    comboBox1.DisplayMember = "RoomTypeInfo";
                }
            }
        }
    }
}

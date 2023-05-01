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
    public partial class AddEmployees : UserControl
    {
        DataTable userList = new DataTable();
        public AddEmployees()
        {
            InitializeComponent();
        }
        private void addEmployeeButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            if (db.checkUserExists(addEmpUserText.Text) == true)
            {
                errorLabel.Visible = true;
                errorLabel.Text = "Username is taken.";
                addEmpConfText.Text = "";
                addEmpPassText.Text = "";
                addEmpUserText.Text = "";
            }
            else if (addEmpPassText.Text != addEmpConfText.Text)
            {
                errorLabel.Visible = true;
                errorLabel.Text = "Passwords don't match.";
                addEmpConfText.Text = "";
                addEmpPassText.Text = "";
            }
            else if (addEmpPassText.Text == "" && addEmpConfText.Text == "")
            {
                errorLabel.Visible = true;
                errorLabel.Text = "Password can't be blank.";
                addEmpConfText.Text = "";
                addEmpPassText.Text = "";
            }
            else
            {
                db.AddUser(addEmpUserText.Text, addEmpPassText.Text);
                MessageBox.Show("Employee added successfully.");
                userList = db.SearchUser(userSearchTextBox.Text);
                usersList.DataSource = userList;
                errorLabel.Visible = false;
                addEmpConfText.Text = "";
                addEmpPassText.Text = "";
                addEmpUserText.Text = "";
            }
        }

        private void userSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            userList = db.SearchUser(userSearchTextBox.Text);
            usersList.DataSource = userList;
            usersList.ClearSelection();
        }

        private void usersList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = usersList.Rows[e.RowIndex];
                updUserTextBox.Text = row.Cells[1].Value.ToString();
                updUserTextBox.Text = row.Cells[1].Value.ToString();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            List<UserModel> users = new List<UserModel>();
            DataAccess db = new DataAccess();
            users = db.LoginUser(updUserTextBox.Text, updPassTextBox.Text);
            if (users.Count > 0)
            {
                MessageBox.Show("Employee deleted successfully.");
                db.DeleteUser(updUserTextBox.Text, updPassTextBox.Text);
                updUserTextBox.Text = "";
                updPassTextBox.Text = "";

                userList = db.SearchUser(userSearchTextBox.Text);
                usersList.DataSource = userList;
                usersList.ClearSelection();

                errorLabel2.Visible = false;
            }
            else
            {
                errorLabel2.Visible = true;
                updUserTextBox.Text = "";
                updPassTextBox.Text = "";
            }
        }

        private void AddEmployees_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                DataAccess db = new DataAccess();
                userList = db.SearchUser(userSearchTextBox.Text);
                usersList.DataSource = userList;
                usersList.ClearSelection();
            }
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hotel_Management_System
{
    public partial class Login : Form
    {
        List<UserModel> users = new List<UserModel>();
        Form home = new HomeForm();
        public Login()
        {
            InitializeComponent();
            this.FormClosing += form_closing;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            users = db.LoginUser(usernameTextBox.Text, passwordTextBox.Text);

            if (users.Count != 0)
            {
                home.Show();
                this.Hide();
            }
            else
            {
                errorMessageLabel.Visible = true;
                usernameTextBox.Text = "";
                passwordTextBox.Text = "";
            }
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


namespace Hotel_Management_System
{
    partial class HomeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.logoutLabel = new System.Windows.Forms.LinkLabel();
            this.panelSlide = new System.Windows.Forms.Panel();
            this.buttonGuests = new System.Windows.Forms.Button();
            this.buttonReservations = new System.Windows.Forms.Button();
            this.buttonRooms = new System.Windows.Forms.Button();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.buttonDashboard = new System.Windows.Forms.Button();
            this.addRooms1 = new Hotel_Management_System.User_Controls.AddRooms();
            this.addGuests1 = new Hotel_Management_System.User_Controls.AddGuests();
            this.addEmployees2 = new Hotel_Management_System.User_Controls.AddEmployees();
            this.dashboard1 = new Hotel_Management_System.User_Controls.Dashboard();
            this.addReservations2 = new Hotel_Management_System.User_Controls.AddReservations();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Caleb\'s Hotel\r\nManagement System\r\n\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.logoutLabel);
            this.panel2.Controls.Add(this.panelSlide);
            this.panel2.Controls.Add(this.buttonGuests);
            this.panel2.Controls.Add(this.buttonReservations);
            this.panel2.Controls.Add(this.buttonRooms);
            this.panel2.Controls.Add(this.buttonSettings);
            this.panel2.Controls.Add(this.buttonDashboard);
            this.panel2.Location = new System.Drawing.Point(12, 118);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 320);
            this.panel2.TabIndex = 2;
            // 
            // logoutLabel
            // 
            this.logoutLabel.AutoSize = true;
            this.logoutLabel.Location = new System.Drawing.Point(20, 299);
            this.logoutLabel.Name = "logoutLabel";
            this.logoutLabel.Size = new System.Drawing.Size(40, 13);
            this.logoutLabel.TabIndex = 3;
            this.logoutLabel.TabStop = true;
            this.logoutLabel.Text = "Logout";
            this.logoutLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // panelSlide
            // 
            this.panelSlide.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelSlide.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSlide.Location = new System.Drawing.Point(6, 26);
            this.panelSlide.Name = "panelSlide";
            this.panelSlide.Size = new System.Drawing.Size(10, 48);
            this.panelSlide.TabIndex = 3;
            // 
            // buttonGuests
            // 
            this.buttonGuests.Location = new System.Drawing.Point(23, 81);
            this.buttonGuests.Name = "buttonGuests";
            this.buttonGuests.Size = new System.Drawing.Size(153, 49);
            this.buttonGuests.TabIndex = 2;
            this.buttonGuests.Text = "Guests";
            this.buttonGuests.UseVisualStyleBackColor = true;
            this.buttonGuests.Click += new System.EventHandler(this.ButtonGuests_click);
            // 
            // buttonReservations
            // 
            this.buttonReservations.Location = new System.Drawing.Point(23, 192);
            this.buttonReservations.Name = "buttonReservations";
            this.buttonReservations.Size = new System.Drawing.Size(153, 49);
            this.buttonReservations.TabIndex = 4;
            this.buttonReservations.Text = "Reservations";
            this.buttonReservations.UseVisualStyleBackColor = true;
            this.buttonReservations.Click += new System.EventHandler(this.ButtonReservations_click);
            // 
            // buttonRooms
            // 
            this.buttonRooms.Location = new System.Drawing.Point(22, 136);
            this.buttonRooms.Name = "buttonRooms";
            this.buttonRooms.Size = new System.Drawing.Size(153, 49);
            this.buttonRooms.TabIndex = 3;
            this.buttonRooms.Text = "Rooms";
            this.buttonRooms.UseVisualStyleBackColor = true;
            this.buttonRooms.Click += new System.EventHandler(this.ButtonRooms_click);
            // 
            // buttonSettings
            // 
            this.buttonSettings.Location = new System.Drawing.Point(23, 247);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(153, 49);
            this.buttonSettings.TabIndex = 5;
            this.buttonSettings.Text = "Employees";
            this.buttonSettings.UseVisualStyleBackColor = true;
            this.buttonSettings.Click += new System.EventHandler(this.ButtonSettings_click);
            // 
            // buttonDashboard
            // 
            this.buttonDashboard.Location = new System.Drawing.Point(22, 26);
            this.buttonDashboard.Name = "buttonDashboard";
            this.buttonDashboard.Size = new System.Drawing.Size(153, 49);
            this.buttonDashboard.TabIndex = 1;
            this.buttonDashboard.Text = "Dashboard";
            this.buttonDashboard.UseVisualStyleBackColor = true;
            this.buttonDashboard.Click += new System.EventHandler(this.ButtonDashboard_click);
            // 
            // addRooms1
            // 
            this.addRooms1.Location = new System.Drawing.Point(218, 12);
            this.addRooms1.Name = "addRooms1";
            this.addRooms1.Size = new System.Drawing.Size(575, 431);
            this.addRooms1.TabIndex = 5;
            this.addRooms1.Visible = false;
            // 
            // addGuests1
            // 
            this.addGuests1.Location = new System.Drawing.Point(218, 12);
            this.addGuests1.Name = "addGuests1";
            this.addGuests1.Size = new System.Drawing.Size(577, 432);
            this.addGuests1.TabIndex = 4;
            this.addGuests1.Visible = false;
            // 
            // addEmployees2
            // 
            this.addEmployees2.Location = new System.Drawing.Point(218, 12);
            this.addEmployees2.Name = "addEmployees2";
            this.addEmployees2.Size = new System.Drawing.Size(570, 426);
            this.addEmployees2.TabIndex = 3;
            this.addEmployees2.Visible = false;
            // 
            // dashboard1
            // 
            this.dashboard1.Location = new System.Drawing.Point(218, 12);
            this.dashboard1.Name = "dashboard1";
            this.dashboard1.Size = new System.Drawing.Size(579, 436);
            this.dashboard1.TabIndex = 6;
            // 
            // addReservations2
            // 
            this.addReservations2.Location = new System.Drawing.Point(218, 12);
            this.addReservations2.Name = "addReservations2";
            this.addReservations2.Size = new System.Drawing.Size(576, 434);
            this.addReservations2.TabIndex = 7;
            this.addReservations2.Visible = false;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addReservations2);
            this.Controls.Add(this.dashboard1);
            this.Controls.Add(this.addRooms1);
            this.Controls.Add(this.addGuests1);
            this.Controls.Add(this.addEmployees2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HomeForm";
            this.Text = "Home";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonGuests;
        private System.Windows.Forms.Button buttonReservations;
        private System.Windows.Forms.Button buttonRooms;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Button buttonDashboard;
        private System.Windows.Forms.Panel panelSlide;
        private System.Windows.Forms.LinkLabel logoutLabel;
        private User_Controls.AddEmployees addEmployees2;
        private User_Controls.AddGuests addGuests1;
        private User_Controls.AddRooms addRooms1;
        private User_Controls.Dashboard dashboard1;
        private User_Controls.AddReservations addReservations2;
    }
}
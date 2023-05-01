namespace Hotel_Management_System.User_Controls
{
    partial class AddReservations
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.AddUser = new System.Windows.Forms.TabPage();
            this.pricePerDayLabel = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dateTimeCkOut = new System.Windows.Forms.DateTimePicker();
            this.dateTimeCkIn = new System.Windows.Forms.DateTimePicker();
            this.priceLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxRoom = new System.Windows.Forms.ComboBox();
            this.AddReservationErrorLabel = new System.Windows.Forms.Label();
            this.addReservationButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.addReservationEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.allReservationsList = new System.Windows.Forms.DataGridView();
            this.allReservationsSearchEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.AddUser.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.allReservationsList)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.AddUser);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(570, 426);
            this.tabControl1.TabIndex = 4;
            // 
            // AddUser
            // 
            this.AddUser.Controls.Add(this.pricePerDayLabel);
            this.AddUser.Controls.Add(this.label13);
            this.AddUser.Controls.Add(this.dateTimeCkOut);
            this.AddUser.Controls.Add(this.dateTimeCkIn);
            this.AddUser.Controls.Add(this.priceLabel);
            this.AddUser.Controls.Add(this.label11);
            this.AddUser.Controls.Add(this.label8);
            this.AddUser.Controls.Add(this.label7);
            this.AddUser.Controls.Add(this.comboBoxRoom);
            this.AddUser.Controls.Add(this.AddReservationErrorLabel);
            this.AddUser.Controls.Add(this.addReservationButton);
            this.AddUser.Controls.Add(this.label3);
            this.AddUser.Controls.Add(this.addReservationEmail);
            this.AddUser.Controls.Add(this.label2);
            this.AddUser.Controls.Add(this.label1);
            this.AddUser.Location = new System.Drawing.Point(4, 22);
            this.AddUser.Name = "AddUser";
            this.AddUser.Padding = new System.Windows.Forms.Padding(3);
            this.AddUser.Size = new System.Drawing.Size(562, 400);
            this.AddUser.TabIndex = 0;
            this.AddUser.Text = "Make Reservations";
            this.AddUser.UseVisualStyleBackColor = true;
            // 
            // pricePerDayLabel
            // 
            this.pricePerDayLabel.AutoSize = true;
            this.pricePerDayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricePerDayLabel.Location = new System.Drawing.Point(347, 246);
            this.pricePerDayLabel.Name = "pricePerDayLabel";
            this.pricePerDayLabel.Size = new System.Drawing.Size(53, 24);
            this.pricePerDayLabel.TabIndex = 14;
            this.pricePerDayLabel.Text = "Price";
            this.pricePerDayLabel.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(324, 279);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(131, 25);
            this.label13.TabIndex = 13;
            this.label13.Text = "Total price:";
            // 
            // dateTimeCkOut
            // 
            this.dateTimeCkOut.Location = new System.Drawing.Point(55, 182);
            this.dateTimeCkOut.Name = "dateTimeCkOut";
            this.dateTimeCkOut.Size = new System.Drawing.Size(200, 20);
            this.dateTimeCkOut.TabIndex = 12;
            this.dateTimeCkOut.ValueChanged += new System.EventHandler(this.dateTimeCkOut_ValueChanged);
            // 
            // dateTimeCkIn
            // 
            this.dateTimeCkIn.Location = new System.Drawing.Point(55, 115);
            this.dateTimeCkIn.Name = "dateTimeCkIn";
            this.dateTimeCkIn.Size = new System.Drawing.Size(200, 20);
            this.dateTimeCkIn.TabIndex = 11;
            this.dateTimeCkIn.ValueChanged += new System.EventHandler(this.dateTimeCkIn_ValueChanged);
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.Location = new System.Drawing.Point(347, 304);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(53, 24);
            this.priceLabel.TabIndex = 10;
            this.priceLabel.Text = "Price";
            this.priceLabel.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(324, 221);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(159, 25);
            this.label11.TabIndex = 9;
            this.label11.Text = "Price per day:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(50, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(179, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "Check-Out Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(50, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Check-In Date";
            // 
            // comboBoxRoom
            // 
            this.comboBoxRoom.FormattingEnabled = true;
            this.comboBoxRoom.Location = new System.Drawing.Point(329, 181);
            this.comboBoxRoom.Name = "comboBoxRoom";
            this.comboBoxRoom.Size = new System.Drawing.Size(153, 21);
            this.comboBoxRoom.TabIndex = 3;
            this.comboBoxRoom.SelectedIndexChanged += new System.EventHandler(this.comboBoxRoom_SelectedIndexChanged);
            // 
            // AddReservationErrorLabel
            // 
            this.AddReservationErrorLabel.AutoSize = true;
            this.AddReservationErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.AddReservationErrorLabel.Location = new System.Drawing.Point(52, 211);
            this.AddReservationErrorLabel.Name = "AddReservationErrorLabel";
            this.AddReservationErrorLabel.Size = new System.Drawing.Size(29, 13);
            this.AddReservationErrorLabel.TabIndex = 8;
            this.AddReservationErrorLabel.Text = "label";
            this.AddReservationErrorLabel.Visible = false;
            // 
            // addReservationButton
            // 
            this.addReservationButton.Location = new System.Drawing.Point(55, 290);
            this.addReservationButton.Name = "addReservationButton";
            this.addReservationButton.Size = new System.Drawing.Size(153, 45);
            this.addReservationButton.TabIndex = 5;
            this.addReservationButton.Text = "Add";
            this.addReservationButton.UseVisualStyleBackColor = true;
            this.addReservationButton.Click += new System.EventHandler(this.addReservationButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(324, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Guest Email:";
            // 
            // addReservationEmail
            // 
            this.addReservationEmail.Location = new System.Drawing.Point(329, 115);
            this.addReservationEmail.Name = "addReservationEmail";
            this.addReservationEmail.Size = new System.Drawing.Size(153, 20);
            this.addReservationEmail.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(324, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Available Rooms";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Make Reservations:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.allReservationsList);
            this.tabPage2.Controls.Add(this.allReservationsSearchEmail);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(562, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Search Reservations";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // allReservationsList
            // 
            this.allReservationsList.AllowUserToAddRows = false;
            this.allReservationsList.AllowUserToDeleteRows = false;
            this.allReservationsList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.allReservationsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allReservationsList.Location = new System.Drawing.Point(34, 109);
            this.allReservationsList.Name = "allReservationsList";
            this.allReservationsList.ReadOnly = true;
            this.allReservationsList.Size = new System.Drawing.Size(493, 265);
            this.allReservationsList.TabIndex = 5;
            this.allReservationsList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.allReservationsList_CellContentClick);
            // 
            // allReservationsSearchEmail
            // 
            this.allReservationsSearchEmail.Location = new System.Drawing.Point(34, 82);
            this.allReservationsSearchEmail.Name = "allReservationsSearchEmail";
            this.allReservationsSearchEmail.Size = new System.Drawing.Size(153, 20);
            this.allReservationsSearchEmail.TabIndex = 3;
            this.allReservationsSearchEmail.TextChanged += new System.EventHandler(this.allReservationsSearchEmail_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "Guest Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(340, 37);
            this.label5.TabIndex = 1;
            this.label5.Text = "Search Reservations:";
            // 
            // AddReservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "AddReservations";
            this.Size = new System.Drawing.Size(576, 434);
            this.Load += new System.EventHandler(this.AddReservations_Load);
            this.tabControl1.ResumeLayout(false);
            this.AddUser.ResumeLayout(false);
            this.AddUser.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.allReservationsList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage AddUser;
        private System.Windows.Forms.ComboBox comboBoxRoom;
        private System.Windows.Forms.Label AddReservationErrorLabel;
        private System.Windows.Forms.Button addReservationButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView allReservationsList;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox allReservationsSearchEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dateTimeCkOut;
        private System.Windows.Forms.DateTimePicker dateTimeCkIn;
        private System.Windows.Forms.TextBox addReservationEmail;
        private System.Windows.Forms.Label pricePerDayLabel;
        private System.Windows.Forms.Label label13;
    }
}

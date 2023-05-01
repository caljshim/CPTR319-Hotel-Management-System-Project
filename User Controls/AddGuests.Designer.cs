namespace Hotel_Management_System.User_Controls
{
    partial class AddGuests
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
            this.label7 = new System.Windows.Forms.Label();
            this.guestEmail = new System.Windows.Forms.TextBox();
            this.errorLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.guestPhoneNumber = new System.Windows.Forms.TextBox();
            this.addEmployeeButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.guestLastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.guestFirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.guestsList = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.guestSearchTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.errorLabelGuests = new System.Windows.Forms.Label();
            this.deleteGuestButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.delGuestTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.AddUser.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guestsList)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.AddUser);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(570, 426);
            this.tabControl1.TabIndex = 2;
            // 
            // AddUser
            // 
            this.AddUser.Controls.Add(this.label7);
            this.AddUser.Controls.Add(this.guestEmail);
            this.AddUser.Controls.Add(this.errorLabel);
            this.AddUser.Controls.Add(this.label4);
            this.AddUser.Controls.Add(this.guestPhoneNumber);
            this.AddUser.Controls.Add(this.addEmployeeButton);
            this.AddUser.Controls.Add(this.label3);
            this.AddUser.Controls.Add(this.guestLastName);
            this.AddUser.Controls.Add(this.label2);
            this.AddUser.Controls.Add(this.guestFirstName);
            this.AddUser.Controls.Add(this.label1);
            this.AddUser.Location = new System.Drawing.Point(4, 22);
            this.AddUser.Name = "AddUser";
            this.AddUser.Padding = new System.Windows.Forms.Padding(3);
            this.AddUser.Size = new System.Drawing.Size(562, 400);
            this.AddUser.TabIndex = 0;
            this.AddUser.Text = "Register Guests";
            this.AddUser.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(315, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 25);
            this.label7.TabIndex = 10;
            this.label7.Text = "Email address";
            // 
            // guestEmail
            // 
            this.guestEmail.Location = new System.Drawing.Point(320, 202);
            this.guestEmail.Name = "guestEmail";
            this.guestEmail.Size = new System.Drawing.Size(153, 20);
            this.guestEmail.TabIndex = 9;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(52, 237);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(35, 13);
            this.errorLabel.TabIndex = 8;
            this.errorLabel.Text = "label7";
            this.errorLabel.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Phone number";
            // 
            // guestPhoneNumber
            // 
            this.guestPhoneNumber.Location = new System.Drawing.Point(55, 202);
            this.guestPhoneNumber.Name = "guestPhoneNumber";
            this.guestPhoneNumber.Size = new System.Drawing.Size(153, 20);
            this.guestPhoneNumber.TabIndex = 5;
            // 
            // addEmployeeButton
            // 
            this.addEmployeeButton.Location = new System.Drawing.Point(55, 290);
            this.addEmployeeButton.Name = "addEmployeeButton";
            this.addEmployeeButton.Size = new System.Drawing.Size(153, 45);
            this.addEmployeeButton.TabIndex = 6;
            this.addEmployeeButton.Text = "Add";
            this.addEmployeeButton.UseVisualStyleBackColor = true;
            this.addEmployeeButton.Click += new System.EventHandler(this.addGuestButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(315, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Last Name";
            // 
            // guestLastName
            // 
            this.guestLastName.Location = new System.Drawing.Point(320, 113);
            this.guestLastName.Name = "guestLastName";
            this.guestLastName.Size = new System.Drawing.Size(153, 20);
            this.guestLastName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "First Name";
            // 
            // guestFirstName
            // 
            this.guestFirstName.Location = new System.Drawing.Point(55, 113);
            this.guestFirstName.Name = "guestFirstName";
            this.guestFirstName.Size = new System.Drawing.Size(153, 20);
            this.guestFirstName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Register Guests:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.guestsList);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.guestSearchTextBox);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(562, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Search Guests";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // guestsList
            // 
            this.guestsList.AllowUserToAddRows = false;
            this.guestsList.AllowUserToDeleteRows = false;
            this.guestsList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guestsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.guestsList.Location = new System.Drawing.Point(22, 146);
            this.guestsList.Name = "guestsList";
            this.guestsList.ReadOnly = true;
            this.guestsList.Size = new System.Drawing.Size(518, 221);
            this.guestsList.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "Email:";
            // 
            // guestSearchTextBox
            // 
            this.guestSearchTextBox.Location = new System.Drawing.Point(22, 103);
            this.guestSearchTextBox.Name = "guestSearchTextBox";
            this.guestSearchTextBox.Size = new System.Drawing.Size(153, 20);
            this.guestSearchTextBox.TabIndex = 3;
            this.guestSearchTextBox.TextChanged += new System.EventHandler(this.guestSearchTextBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(251, 37);
            this.label5.TabIndex = 1;
            this.label5.Text = "Search Guests:";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.errorLabelGuests);
            this.tabPage1.Controls.Add(this.deleteGuestButton);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.delGuestTextBox);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(562, 400);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Delete Guests";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // errorLabelGuests
            // 
            this.errorLabelGuests.AutoSize = true;
            this.errorLabelGuests.Cursor = System.Windows.Forms.Cursors.Default;
            this.errorLabelGuests.ForeColor = System.Drawing.Color.Red;
            this.errorLabelGuests.Location = new System.Drawing.Point(33, 145);
            this.errorLabelGuests.Name = "errorLabelGuests";
            this.errorLabelGuests.Size = new System.Drawing.Size(86, 13);
            this.errorLabelGuests.TabIndex = 15;
            this.errorLabelGuests.Text = "Guest not found.";
            this.errorLabelGuests.Visible = false;
            // 
            // deleteGuestButton
            // 
            this.deleteGuestButton.BackColor = System.Drawing.Color.Transparent;
            this.deleteGuestButton.Location = new System.Drawing.Point(36, 315);
            this.deleteGuestButton.Name = "deleteGuestButton";
            this.deleteGuestButton.Size = new System.Drawing.Size(153, 45);
            this.deleteGuestButton.TabIndex = 14;
            this.deleteGuestButton.Text = "Delete";
            this.deleteGuestButton.UseVisualStyleBackColor = false;
            this.deleteGuestButton.Click += new System.EventHandler(this.deleteGuestButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(31, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 25);
            this.label9.TabIndex = 10;
            this.label9.Text = "Email:";
            // 
            // delGuestTextBox
            // 
            this.delGuestTextBox.Location = new System.Drawing.Point(36, 112);
            this.delGuestTextBox.Name = "delGuestTextBox";
            this.delGuestTextBox.Size = new System.Drawing.Size(153, 20);
            this.delGuestTextBox.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(240, 37);
            this.label10.TabIndex = 8;
            this.label10.Text = "Delete Guests:";
            // 
            // AddGuests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "AddGuests";
            this.Size = new System.Drawing.Size(570, 426);
            this.Load += new System.EventHandler(this.AddGuests_Load);
            this.tabControl1.ResumeLayout(false);
            this.AddUser.ResumeLayout(false);
            this.AddUser.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guestsList)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage AddUser;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox guestEmail;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox guestPhoneNumber;
        private System.Windows.Forms.Button addEmployeeButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox guestLastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox guestFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView guestsList;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox guestSearchTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label errorLabelGuests;
        private System.Windows.Forms.Button deleteGuestButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox delGuestTextBox;
        private System.Windows.Forms.Label label10;
    }
}

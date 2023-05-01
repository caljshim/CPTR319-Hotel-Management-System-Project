namespace Hotel_Management_System.User_Controls
{
    partial class AddRooms
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.AddRoomErrorLabel = new System.Windows.Forms.Label();
            this.addRoomButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.addRoomNumberTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.roomsList = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.roomSearchTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.deleteRoomsErrorLabel = new System.Windows.Forms.Label();
            this.deleteRoomsButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.deleteRoomsTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.roomTypeList = new System.Windows.Forms.DataGridView();
            this.addRoomTypeTextBox = new System.Windows.Forms.TextBox();
            this.addRoomTypeErrorLabel = new System.Windows.Forms.Label();
            this.addRoomTypeButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.addRoomTypePriceTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.AddUser.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomsList)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomTypeList)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.AddUser);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(570, 426);
            this.tabControl1.TabIndex = 3;
            // 
            // AddUser
            // 
            this.AddUser.Controls.Add(this.comboBox1);
            this.AddUser.Controls.Add(this.AddRoomErrorLabel);
            this.AddUser.Controls.Add(this.addRoomButton);
            this.AddUser.Controls.Add(this.label3);
            this.AddUser.Controls.Add(this.addRoomNumberTextBox);
            this.AddUser.Controls.Add(this.label2);
            this.AddUser.Controls.Add(this.label1);
            this.AddUser.Location = new System.Drawing.Point(4, 22);
            this.AddUser.Name = "AddUser";
            this.AddUser.Padding = new System.Windows.Forms.Padding(3);
            this.AddUser.Size = new System.Drawing.Size(562, 400);
            this.AddUser.TabIndex = 0;
            this.AddUser.Text = "Add Rooms";
            this.AddUser.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(55, 113);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(153, 21);
            this.comboBox1.TabIndex = 9;
            // 
            // AddRoomErrorLabel
            // 
            this.AddRoomErrorLabel.AutoSize = true;
            this.AddRoomErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.AddRoomErrorLabel.Location = new System.Drawing.Point(52, 211);
            this.AddRoomErrorLabel.Name = "AddRoomErrorLabel";
            this.AddRoomErrorLabel.Size = new System.Drawing.Size(29, 13);
            this.AddRoomErrorLabel.TabIndex = 8;
            this.AddRoomErrorLabel.Text = "label";
            this.AddRoomErrorLabel.Visible = false;
            // 
            // addRoomButton
            // 
            this.addRoomButton.Location = new System.Drawing.Point(55, 290);
            this.addRoomButton.Name = "addRoomButton";
            this.addRoomButton.Size = new System.Drawing.Size(153, 45);
            this.addRoomButton.TabIndex = 6;
            this.addRoomButton.Text = "Add";
            this.addRoomButton.UseVisualStyleBackColor = true;
            this.addRoomButton.Click += new System.EventHandler(this.addRoomButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Room Number";
            // 
            // addRoomNumberTextBox
            // 
            this.addRoomNumberTextBox.Location = new System.Drawing.Point(55, 179);
            this.addRoomNumberTextBox.Name = "addRoomNumberTextBox";
            this.addRoomNumberTextBox.Size = new System.Drawing.Size(153, 20);
            this.addRoomNumberTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Room Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Rooms:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.roomsList);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.roomSearchTextBox);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(562, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Search Rooms";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // roomsList
            // 
            this.roomsList.AllowUserToAddRows = false;
            this.roomsList.AllowUserToDeleteRows = false;
            this.roomsList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.roomsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.roomsList.Location = new System.Drawing.Point(22, 146);
            this.roomsList.Name = "roomsList";
            this.roomsList.ReadOnly = true;
            this.roomsList.Size = new System.Drawing.Size(244, 221);
            this.roomsList.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "Room Number:";
            // 
            // roomSearchTextBox
            // 
            this.roomSearchTextBox.Location = new System.Drawing.Point(22, 103);
            this.roomSearchTextBox.Name = "roomSearchTextBox";
            this.roomSearchTextBox.Size = new System.Drawing.Size(153, 20);
            this.roomSearchTextBox.TabIndex = 3;
            this.roomSearchTextBox.TextChanged += new System.EventHandler(this.roomSearchTextBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(250, 37);
            this.label5.TabIndex = 1;
            this.label5.Text = "Search Rooms:";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.deleteRoomsErrorLabel);
            this.tabPage1.Controls.Add(this.deleteRoomsButton);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.deleteRoomsTextBox);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(562, 400);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Delete Rooms";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // deleteRoomsErrorLabel
            // 
            this.deleteRoomsErrorLabel.AutoSize = true;
            this.deleteRoomsErrorLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.deleteRoomsErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.deleteRoomsErrorLabel.Location = new System.Drawing.Point(33, 145);
            this.deleteRoomsErrorLabel.Name = "deleteRoomsErrorLabel";
            this.deleteRoomsErrorLabel.Size = new System.Drawing.Size(86, 13);
            this.deleteRoomsErrorLabel.TabIndex = 15;
            this.deleteRoomsErrorLabel.Text = "Guest not found.";
            this.deleteRoomsErrorLabel.Visible = false;
            // 
            // deleteRoomsButton
            // 
            this.deleteRoomsButton.BackColor = System.Drawing.Color.Transparent;
            this.deleteRoomsButton.Location = new System.Drawing.Point(36, 315);
            this.deleteRoomsButton.Name = "deleteRoomsButton";
            this.deleteRoomsButton.Size = new System.Drawing.Size(153, 45);
            this.deleteRoomsButton.TabIndex = 14;
            this.deleteRoomsButton.Text = "Delete";
            this.deleteRoomsButton.UseVisualStyleBackColor = false;
            this.deleteRoomsButton.Click += new System.EventHandler(this.deleteRoomsButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(31, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(167, 25);
            this.label9.TabIndex = 10;
            this.label9.Text = "Room Number:";
            // 
            // deleteRoomsTextBox
            // 
            this.deleteRoomsTextBox.Location = new System.Drawing.Point(36, 112);
            this.deleteRoomsTextBox.Name = "deleteRoomsTextBox";
            this.deleteRoomsTextBox.Size = new System.Drawing.Size(153, 20);
            this.deleteRoomsTextBox.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(239, 37);
            this.label10.TabIndex = 8;
            this.label10.Text = "Delete Rooms:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.roomTypeList);
            this.tabPage3.Controls.Add(this.addRoomTypeTextBox);
            this.tabPage3.Controls.Add(this.addRoomTypeErrorLabel);
            this.tabPage3.Controls.Add(this.addRoomTypeButton);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.addRoomTypePriceTextBox);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(562, 400);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Add Room Types";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(30, 176);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(25, 25);
            this.label12.TabIndex = 19;
            this.label12.Text = "$";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(283, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(241, 25);
            this.label4.TabIndex = 18;
            this.label4.Text = "Existing Room Types:";
            // 
            // roomTypeList
            // 
            this.roomTypeList.AllowUserToAddRows = false;
            this.roomTypeList.AllowUserToDeleteRows = false;
            this.roomTypeList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.roomTypeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.roomTypeList.Location = new System.Drawing.Point(288, 151);
            this.roomTypeList.Name = "roomTypeList";
            this.roomTypeList.ReadOnly = true;
            this.roomTypeList.Size = new System.Drawing.Size(244, 221);
            this.roomTypeList.TabIndex = 17;
            this.roomTypeList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.roomTypeList_CellClick);
            // 
            // addRoomTypeTextBox
            // 
            this.addRoomTypeTextBox.Location = new System.Drawing.Point(55, 113);
            this.addRoomTypeTextBox.Name = "addRoomTypeTextBox";
            this.addRoomTypeTextBox.Size = new System.Drawing.Size(153, 20);
            this.addRoomTypeTextBox.TabIndex = 16;
            // 
            // addRoomTypeErrorLabel
            // 
            this.addRoomTypeErrorLabel.AutoSize = true;
            this.addRoomTypeErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.addRoomTypeErrorLabel.Location = new System.Drawing.Point(52, 211);
            this.addRoomTypeErrorLabel.Name = "addRoomTypeErrorLabel";
            this.addRoomTypeErrorLabel.Size = new System.Drawing.Size(29, 13);
            this.addRoomTypeErrorLabel.TabIndex = 15;
            this.addRoomTypeErrorLabel.Text = "label";
            this.addRoomTypeErrorLabel.Visible = false;
            // 
            // addRoomTypeButton
            // 
            this.addRoomTypeButton.Location = new System.Drawing.Point(55, 290);
            this.addRoomTypeButton.Name = "addRoomTypeButton";
            this.addRoomTypeButton.Size = new System.Drawing.Size(153, 45);
            this.addRoomTypeButton.TabIndex = 14;
            this.addRoomTypeButton.Text = "Add";
            this.addRoomTypeButton.UseVisualStyleBackColor = true;
            this.addRoomTypeButton.Click += new System.EventHandler(this.addRoomTypeButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(50, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "Price";
            // 
            // addRoomTypePriceTextBox
            // 
            this.addRoomTypePriceTextBox.Location = new System.Drawing.Point(55, 179);
            this.addRoomTypePriceTextBox.Name = "addRoomTypePriceTextBox";
            this.addRoomTypePriceTextBox.Size = new System.Drawing.Size(153, 20);
            this.addRoomTypePriceTextBox.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(50, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 25);
            this.label8.TabIndex = 11;
            this.label8.Text = "Room Type";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(288, 37);
            this.label11.TabIndex = 10;
            this.label11.Text = "Add Room Types:";
            // 
            // AddRooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "AddRooms";
            this.Size = new System.Drawing.Size(570, 426);
            this.Load += new System.EventHandler(this.AddRooms_Load);
            this.tabControl1.ResumeLayout(false);
            this.AddUser.ResumeLayout(false);
            this.AddUser.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomsList)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomTypeList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage AddUser;
        private System.Windows.Forms.Label AddRoomErrorLabel;
        private System.Windows.Forms.Button addRoomButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox addRoomNumberTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView roomsList;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox roomSearchTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label deleteRoomsErrorLabel;
        private System.Windows.Forms.Button deleteRoomsButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox deleteRoomsTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox addRoomTypeTextBox;
        private System.Windows.Forms.Label addRoomTypeErrorLabel;
        private System.Windows.Forms.Button addRoomTypeButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox addRoomTypePriceTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView roomTypeList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label12;
    }
}

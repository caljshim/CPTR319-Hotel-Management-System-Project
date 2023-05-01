namespace Hotel_Management_System.User_Controls
{
    partial class AddEmployees
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
            this.errorLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.addEmpConfText = new System.Windows.Forms.TextBox();
            this.addEmployeeButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.addEmpPassText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addEmpUserText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.usersList = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.userSearchTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.errorLabel2 = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.updPassTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.updUserTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.AddUser.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersList)).BeginInit();
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
            this.tabControl1.TabIndex = 1;
            // 
            // AddUser
            // 
            this.AddUser.Controls.Add(this.errorLabel);
            this.AddUser.Controls.Add(this.label4);
            this.AddUser.Controls.Add(this.addEmpConfText);
            this.AddUser.Controls.Add(this.addEmployeeButton);
            this.AddUser.Controls.Add(this.label3);
            this.AddUser.Controls.Add(this.addEmpPassText);
            this.AddUser.Controls.Add(this.label2);
            this.AddUser.Controls.Add(this.addEmpUserText);
            this.AddUser.Controls.Add(this.label1);
            this.AddUser.Location = new System.Drawing.Point(4, 22);
            this.AddUser.Name = "AddUser";
            this.AddUser.Padding = new System.Windows.Forms.Padding(3);
            this.AddUser.Size = new System.Drawing.Size(562, 400);
            this.AddUser.TabIndex = 0;
            this.AddUser.Text = "Add Employees";
            this.AddUser.UseVisualStyleBackColor = true;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(52, 257);
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
            this.label4.Location = new System.Drawing.Point(50, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(209, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Confirm Password:";
            // 
            // addEmpConfText
            // 
            this.addEmpConfText.Location = new System.Drawing.Point(55, 223);
            this.addEmpConfText.Name = "addEmpConfText";
            this.addEmpConfText.Size = new System.Drawing.Size(153, 20);
            this.addEmpConfText.TabIndex = 5;
            // 
            // addEmployeeButton
            // 
            this.addEmployeeButton.Location = new System.Drawing.Point(55, 290);
            this.addEmployeeButton.Name = "addEmployeeButton";
            this.addEmployeeButton.Size = new System.Drawing.Size(153, 45);
            this.addEmployeeButton.TabIndex = 6;
            this.addEmployeeButton.Text = "Add";
            this.addEmployeeButton.UseVisualStyleBackColor = true;
            this.addEmployeeButton.Click += new System.EventHandler(this.addEmployeeButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password:";
            // 
            // addEmpPassText
            // 
            this.addEmpPassText.Location = new System.Drawing.Point(55, 160);
            this.addEmpPassText.Name = "addEmpPassText";
            this.addEmpPassText.Size = new System.Drawing.Size(153, 20);
            this.addEmpPassText.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Username:";
            // 
            // addEmpUserText
            // 
            this.addEmpUserText.Location = new System.Drawing.Point(55, 99);
            this.addEmpUserText.Name = "addEmpUserText";
            this.addEmpUserText.Size = new System.Drawing.Size(153, 20);
            this.addEmpUserText.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Employee:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.usersList);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.userSearchTextBox);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(562, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Search Employees";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // usersList
            // 
            this.usersList.AllowUserToAddRows = false;
            this.usersList.AllowUserToDeleteRows = false;
            this.usersList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersList.Location = new System.Drawing.Point(22, 146);
            this.usersList.Name = "usersList";
            this.usersList.ReadOnly = true;
            this.usersList.Size = new System.Drawing.Size(344, 221);
            this.usersList.TabIndex = 5;
            this.usersList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.usersList_CellClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "Username:";
            // 
            // userSearchTextBox
            // 
            this.userSearchTextBox.Location = new System.Drawing.Point(22, 103);
            this.userSearchTextBox.Name = "userSearchTextBox";
            this.userSearchTextBox.Size = new System.Drawing.Size(153, 20);
            this.userSearchTextBox.TabIndex = 3;
            this.userSearchTextBox.TextChanged += new System.EventHandler(this.userSearchTextBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(309, 37);
            this.label5.TabIndex = 1;
            this.label5.Text = "Search Employees:";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.errorLabel2);
            this.tabPage1.Controls.Add(this.deleteButton);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.updPassTextBox);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.updUserTextBox);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(562, 400);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Delete Employees";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // errorLabel2
            // 
            this.errorLabel2.AutoSize = true;
            this.errorLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.errorLabel2.ForeColor = System.Drawing.Color.Red;
            this.errorLabel2.Location = new System.Drawing.Point(33, 222);
            this.errorLabel2.Name = "errorLabel2";
            this.errorLabel2.Size = new System.Drawing.Size(173, 13);
            this.errorLabel2.TabIndex = 15;
            this.errorLabel2.Text = "Username or Password is incorrect.";
            this.errorLabel2.Visible = false;
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Transparent;
            this.deleteButton.Location = new System.Drawing.Point(36, 315);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(153, 45);
            this.deleteButton.TabIndex = 14;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(31, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 25);
            this.label8.TabIndex = 12;
            this.label8.Text = "Password:";
            // 
            // updPassTextBox
            // 
            this.updPassTextBox.Location = new System.Drawing.Point(36, 189);
            this.updPassTextBox.Name = "updPassTextBox";
            this.updPassTextBox.Size = new System.Drawing.Size(153, 20);
            this.updPassTextBox.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(31, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 25);
            this.label9.TabIndex = 10;
            this.label9.Text = "Username:";
            // 
            // updUserTextBox
            // 
            this.updUserTextBox.Location = new System.Drawing.Point(36, 112);
            this.updUserTextBox.Name = "updUserTextBox";
            this.updUserTextBox.Size = new System.Drawing.Size(153, 20);
            this.updUserTextBox.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(288, 37);
            this.label10.TabIndex = 8;
            this.label10.Text = "Delete Employees";
            // 
            // AddEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "AddEmployees";
            this.Size = new System.Drawing.Size(570, 426);
            this.tabControl1.ResumeLayout(false);
            this.AddUser.ResumeLayout(false);
            this.AddUser.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersList)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.Load += new System.EventHandler(this.AddEmployees_Load);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage AddUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox addEmpConfText;
        private System.Windows.Forms.Button addEmployeeButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox addEmpPassText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox addEmpUserText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView usersList;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox userSearchTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox updPassTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox updUserTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Label errorLabel2;
    }
}

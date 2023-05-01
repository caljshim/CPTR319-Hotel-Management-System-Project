namespace Hotel_Management_System.User_Controls
{
    partial class Dashboard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.viewAmenityButton = new System.Windows.Forms.Button();
            this.editAmenityButton = new System.Windows.Forms.Button();
            this.delAmenityButton = new System.Windows.Forms.Button();
            this.addAmenityButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.employeeCountLabel = new System.Windows.Forms.Label();
            this.reservationsCountLabel = new System.Windows.Forms.Label();
            this.roomCountLabel = new System.Windows.Forms.Label();
            this.guestCountLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.amenitiesList = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.employeeCountLabel);
            this.panel1.Controls.Add(this.reservationsCountLabel);
            this.panel1.Controls.Add(this.roomCountLabel);
            this.panel1.Controls.Add(this.guestCountLabel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.amenitiesList);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(564, 420);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.viewAmenityButton);
            this.panel2.Controls.Add(this.editAmenityButton);
            this.panel2.Controls.Add(this.delAmenityButton);
            this.panel2.Controls.Add(this.addAmenityButton);
            this.panel2.Location = new System.Drawing.Point(323, 379);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(221, 32);
            this.panel2.TabIndex = 9;
            // 
            // viewAmenityButton
            // 
            this.viewAmenityButton.Location = new System.Drawing.Point(144, 2);
            this.viewAmenityButton.Name = "viewAmenityButton";
            this.viewAmenityButton.Size = new System.Drawing.Size(42, 25);
            this.viewAmenityButton.TabIndex = 11;
            this.viewAmenityButton.Text = "View";
            this.viewAmenityButton.UseVisualStyleBackColor = true;
            this.viewAmenityButton.Click += new System.EventHandler(this.viewAmenityButton_Click);
            // 
            // editAmenityButton
            // 
            this.editAmenityButton.Location = new System.Drawing.Point(96, 2);
            this.editAmenityButton.Name = "editAmenityButton";
            this.editAmenityButton.Size = new System.Drawing.Size(42, 25);
            this.editAmenityButton.TabIndex = 10;
            this.editAmenityButton.Text = "Edit";
            this.editAmenityButton.UseVisualStyleBackColor = true;
            this.editAmenityButton.Click += new System.EventHandler(this.editAmenityButton_Click);
            // 
            // delAmenityButton
            // 
            this.delAmenityButton.Location = new System.Drawing.Point(65, 2);
            this.delAmenityButton.Name = "delAmenityButton";
            this.delAmenityButton.Size = new System.Drawing.Size(25, 25);
            this.delAmenityButton.TabIndex = 9;
            this.delAmenityButton.Text = "-";
            this.delAmenityButton.UseVisualStyleBackColor = true;
            this.delAmenityButton.Click += new System.EventHandler(this.delAmenityButton_Click);
            // 
            // addAmenityButton
            // 
            this.addAmenityButton.Location = new System.Drawing.Point(34, 2);
            this.addAmenityButton.Name = "addAmenityButton";
            this.addAmenityButton.Size = new System.Drawing.Size(25, 25);
            this.addAmenityButton.TabIndex = 8;
            this.addAmenityButton.Text = "+";
            this.addAmenityButton.UseVisualStyleBackColor = true;
            this.addAmenityButton.Click += new System.EventHandler(this.addAmenityButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(318, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Hotel Amenities:";
            // 
            // employeeCountLabel
            // 
            this.employeeCountLabel.AutoSize = true;
            this.employeeCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeCountLabel.Location = new System.Drawing.Point(5, 313);
            this.employeeCountLabel.Name = "employeeCountLabel";
            this.employeeCountLabel.Size = new System.Drawing.Size(134, 25);
            this.employeeCountLabel.TabIndex = 6;
            this.employeeCountLabel.Text = "Employees:";
            // 
            // reservationsCountLabel
            // 
            this.reservationsCountLabel.AutoSize = true;
            this.reservationsCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservationsCountLabel.Location = new System.Drawing.Point(5, 252);
            this.reservationsCountLabel.Name = "reservationsCountLabel";
            this.reservationsCountLabel.Size = new System.Drawing.Size(242, 25);
            this.reservationsCountLabel.TabIndex = 5;
            this.reservationsCountLabel.Text = "Current Reservations:";
            // 
            // roomCountLabel
            // 
            this.roomCountLabel.AutoSize = true;
            this.roomCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomCountLabel.Location = new System.Drawing.Point(5, 191);
            this.roomCountLabel.Name = "roomCountLabel";
            this.roomCountLabel.Size = new System.Drawing.Size(212, 25);
            this.roomCountLabel.TabIndex = 4;
            this.roomCountLabel.Text = "Registered Rooms:";
            // 
            // guestCountLabel
            // 
            this.guestCountLabel.AutoSize = true;
            this.guestCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guestCountLabel.Location = new System.Drawing.Point(5, 130);
            this.guestCountLabel.Name = "guestCountLabel";
            this.guestCountLabel.Size = new System.Drawing.Size(214, 25);
            this.guestCountLabel.TabIndex = 3;
            this.guestCountLabel.Text = "Registered Guests:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dashboard:";
            // 
            // amenitiesList
            // 
            this.amenitiesList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amenitiesList.FormattingEnabled = true;
            this.amenitiesList.ItemHeight = 20;
            this.amenitiesList.Location = new System.Drawing.Point(323, 87);
            this.amenitiesList.Name = "amenitiesList";
            this.amenitiesList.Size = new System.Drawing.Size(221, 324);
            this.amenitiesList.TabIndex = 0;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "Dashboard";
            this.Size = new System.Drawing.Size(570, 426);
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.ListBox amenitiesList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label guestCountLabel;
        private System.Windows.Forms.Label roomCountLabel;
        private System.Windows.Forms.Label reservationsCountLabel;
        private System.Windows.Forms.Label employeeCountLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button addAmenityButton;
        private System.Windows.Forms.Button delAmenityButton;
        private System.Windows.Forms.Button editAmenityButton;
        private System.Windows.Forms.Button viewAmenityButton;
    }
}

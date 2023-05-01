namespace Hotel_Management_System
{
    partial class CreateAmenitiesForm
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
            this.amenityNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guestCountLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.RichTextBox();
            this.addAmenityButton = new System.Windows.Forms.Button();
            this.cancelAmenityButton = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // amenityNameTextBox
            // 
            this.amenityNameTextBox.Location = new System.Drawing.Point(23, 87);
            this.amenityNameTextBox.Name = "amenityNameTextBox";
            this.amenityNameTextBox.Size = new System.Drawing.Size(158, 20);
            this.amenityNameTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Add Amenity:";
            // 
            // guestCountLabel
            // 
            this.guestCountLabel.AutoSize = true;
            this.guestCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guestCountLabel.Location = new System.Drawing.Point(18, 59);
            this.guestCountLabel.Name = "guestCountLabel";
            this.guestCountLabel.Size = new System.Drawing.Size(163, 25);
            this.guestCountLabel.TabIndex = 4;
            this.guestCountLabel.Text = "Amenity Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Description";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(23, 160);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(394, 145);
            this.descriptionTextBox.TabIndex = 6;
            this.descriptionTextBox.Text = "";
            // 
            // addAmenityButton
            // 
            this.addAmenityButton.Location = new System.Drawing.Point(23, 320);
            this.addAmenityButton.Name = "addAmenityButton";
            this.addAmenityButton.Size = new System.Drawing.Size(126, 37);
            this.addAmenityButton.TabIndex = 7;
            this.addAmenityButton.Text = "Add";
            this.addAmenityButton.UseVisualStyleBackColor = true;
            this.addAmenityButton.Click += new System.EventHandler(this.addAmenityButton_Click);
            // 
            // cancelAmenityButton
            // 
            this.cancelAmenityButton.Location = new System.Drawing.Point(155, 320);
            this.cancelAmenityButton.Name = "cancelAmenityButton";
            this.cancelAmenityButton.Size = new System.Drawing.Size(126, 37);
            this.cancelAmenityButton.TabIndex = 8;
            this.cancelAmenityButton.Text = "Cancel";
            this.cancelAmenityButton.UseVisualStyleBackColor = true;
            this.cancelAmenityButton.Click += new System.EventHandler(this.cancelAmenityButton_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(20, 110);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(29, 13);
            this.errorLabel.TabIndex = 9;
            this.errorLabel.Text = "label";
            this.errorLabel.Visible = false;
            // 
            // CreateAmenitiesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 369);
            this.ControlBox = false;
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.cancelAmenityButton);
            this.Controls.Add(this.addAmenityButton);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.guestCountLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.amenityNameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateAmenitiesForm";
            this.Text = "Create Amenity";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox amenityNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label guestCountLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox descriptionTextBox;
        private System.Windows.Forms.Button addAmenityButton;
        private System.Windows.Forms.Button cancelAmenityButton;
        private System.Windows.Forms.Label errorLabel;
    }
}
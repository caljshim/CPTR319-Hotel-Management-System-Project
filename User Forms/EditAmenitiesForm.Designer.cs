namespace Hotel_Management_System
{
    partial class EditAmenitiesForm
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
            this.errorLabel = new System.Windows.Forms.Label();
            this.cancelAmenityButton = new System.Windows.Forms.Button();
            this.saveAmenityButton = new System.Windows.Forms.Button();
            this.editDescriptionTextBox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.guestCountLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.editAmenityTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(20, 110);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(29, 13);
            this.errorLabel.TabIndex = 17;
            this.errorLabel.Text = "label";
            this.errorLabel.Visible = false;
            // 
            // cancelAmenityButton
            // 
            this.cancelAmenityButton.Location = new System.Drawing.Point(155, 320);
            this.cancelAmenityButton.Name = "cancelAmenityButton";
            this.cancelAmenityButton.Size = new System.Drawing.Size(126, 37);
            this.cancelAmenityButton.TabIndex = 16;
            this.cancelAmenityButton.Text = "Cancel";
            this.cancelAmenityButton.UseVisualStyleBackColor = true;
            this.cancelAmenityButton.Click += new System.EventHandler(this.cancelAmenityButton_Click);
            // 
            // saveAmenityButton
            // 
            this.saveAmenityButton.Location = new System.Drawing.Point(23, 320);
            this.saveAmenityButton.Name = "saveAmenityButton";
            this.saveAmenityButton.Size = new System.Drawing.Size(126, 37);
            this.saveAmenityButton.TabIndex = 15;
            this.saveAmenityButton.Text = "Save";
            this.saveAmenityButton.UseVisualStyleBackColor = true;
            this.saveAmenityButton.Click += new System.EventHandler(this.saveAmenityButton_Click);
            // 
            // editDescriptionTextBox
            // 
            this.editDescriptionTextBox.Location = new System.Drawing.Point(23, 160);
            this.editDescriptionTextBox.Name = "editDescriptionTextBox";
            this.editDescriptionTextBox.Size = new System.Drawing.Size(394, 145);
            this.editDescriptionTextBox.TabIndex = 14;
            this.editDescriptionTextBox.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Description";
            // 
            // guestCountLabel
            // 
            this.guestCountLabel.AutoSize = true;
            this.guestCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guestCountLabel.Location = new System.Drawing.Point(18, 59);
            this.guestCountLabel.Name = "guestCountLabel";
            this.guestCountLabel.Size = new System.Drawing.Size(163, 25);
            this.guestCountLabel.TabIndex = 12;
            this.guestCountLabel.Text = "Amenity Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 37);
            this.label1.TabIndex = 11;
            this.label1.Text = "Edit Amenity:";
            // 
            // editAmenityTextBox
            // 
            this.editAmenityTextBox.Location = new System.Drawing.Point(23, 87);
            this.editAmenityTextBox.Name = "editAmenityTextBox";
            this.editAmenityTextBox.Size = new System.Drawing.Size(158, 20);
            this.editAmenityTextBox.TabIndex = 10;
            // 
            // EditAmenitiesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 369);
            this.ControlBox = false;
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.cancelAmenityButton);
            this.Controls.Add(this.saveAmenityButton);
            this.Controls.Add(this.editDescriptionTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.guestCountLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.editAmenityTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EditAmenitiesForm";
            this.Text = "Edit Amenity";
            this.Load += new System.EventHandler(this.EditAmenity_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Button cancelAmenityButton;
        private System.Windows.Forms.Button saveAmenityButton;
        private System.Windows.Forms.RichTextBox editDescriptionTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label guestCountLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox editAmenityTextBox;
    }
}
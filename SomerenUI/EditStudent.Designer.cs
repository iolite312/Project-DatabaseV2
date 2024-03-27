namespace SomerenUI
{
    partial class EditStudent
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
            btnEditStudent = new System.Windows.Forms.Button();
            lblFirstName = new System.Windows.Forms.Label();
            lblLastName = new System.Windows.Forms.Label();
            lblStudentNumber = new System.Windows.Forms.Label();
            lblPhoneNumber = new System.Windows.Forms.Label();
            lblClass = new System.Windows.Forms.Label();
            lblRoomNumber = new System.Windows.Forms.Label();
            txtFirstName = new System.Windows.Forms.TextBox();
            txtLastName = new System.Windows.Forms.TextBox();
            txtStudentNumber = new System.Windows.Forms.TextBox();
            txtPhoneNumber = new System.Windows.Forms.TextBox();
            txtClass = new System.Windows.Forms.TextBox();
            txtRoomNumber = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // btnEditStudent
            // 
            btnEditStudent.Location = new System.Drawing.Point(44, 340);
            btnEditStudent.Name = "btnEditStudent";
            btnEditStudent.Size = new System.Drawing.Size(112, 34);
            btnEditStudent.TabIndex = 0;
            btnEditStudent.Text = "Edit";
            btnEditStudent.UseVisualStyleBackColor = true;
            btnEditStudent.Click += btnEditStudent_Click;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new System.Drawing.Point(44, 44);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new System.Drawing.Size(106, 25);
            lblFirstName.TabIndex = 1;
            lblFirstName.Text = "First Name :";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new System.Drawing.Point(44, 85);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new System.Drawing.Size(104, 25);
            lblLastName.TabIndex = 2;
            lblLastName.Text = "Last Name :";
            // 
            // lblStudentNumber
            // 
            lblStudentNumber.AutoSize = true;
            lblStudentNumber.Location = new System.Drawing.Point(44, 129);
            lblStudentNumber.Name = "lblStudentNumber";
            lblStudentNumber.Size = new System.Drawing.Size(152, 25);
            lblStudentNumber.TabIndex = 3;
            lblStudentNumber.Text = "Student Number :";
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Location = new System.Drawing.Point(44, 172);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new System.Drawing.Size(141, 25);
            lblPhoneNumber.TabIndex = 4;
            lblPhoneNumber.Text = "Phone Number :";
            // 
            // lblClass
            // 
            lblClass.AutoSize = true;
            lblClass.Location = new System.Drawing.Point(44, 215);
            lblClass.Name = "lblClass";
            lblClass.Size = new System.Drawing.Size(61, 25);
            lblClass.TabIndex = 5;
            lblClass.Text = "Class :";
            // 
            // lblRoomNumber
            // 
            lblRoomNumber.AutoSize = true;
            lblRoomNumber.Location = new System.Drawing.Point(44, 257);
            lblRoomNumber.Name = "lblRoomNumber";
            lblRoomNumber.Size = new System.Drawing.Size(139, 25);
            lblRoomNumber.TabIndex = 6;
            lblRoomNumber.Text = "Room Number :";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new System.Drawing.Point(190, 44);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new System.Drawing.Size(150, 31);
            txtFirstName.TabIndex = 7;
            // 
            // txtLastName
            // 
            txtLastName.Location = new System.Drawing.Point(190, 85);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new System.Drawing.Size(150, 31);
            txtLastName.TabIndex = 8;
            // 
            // txtStudentNumber
            // 
            txtStudentNumber.Location = new System.Drawing.Point(190, 129);
            txtStudentNumber.Name = "txtStudentNumber";
            txtStudentNumber.Size = new System.Drawing.Size(150, 31);
            txtStudentNumber.TabIndex = 9;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new System.Drawing.Point(190, 172);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new System.Drawing.Size(150, 31);
            txtPhoneNumber.TabIndex = 10;
            // 
            // txtClass
            // 
            txtClass.Location = new System.Drawing.Point(190, 215);
            txtClass.Name = "txtClass";
            txtClass.Size = new System.Drawing.Size(150, 31);
            txtClass.TabIndex = 11;
            // 
            // txtRoomNumber
            // 
            txtRoomNumber.Location = new System.Drawing.Point(190, 257);
            txtRoomNumber.Name = "txtRoomNumber";
            txtRoomNumber.Size = new System.Drawing.Size(150, 31);
            txtRoomNumber.TabIndex = 12;
            // 
            // EditStudent
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(txtRoomNumber);
            Controls.Add(txtClass);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtStudentNumber);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(lblRoomNumber);
            Controls.Add(lblClass);
            Controls.Add(lblPhoneNumber);
            Controls.Add(lblStudentNumber);
            Controls.Add(lblLastName);
            Controls.Add(lblFirstName);
            Controls.Add(btnEditStudent);
            Name = "EditStudent";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnEditStudent;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblStudentNumber;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label lblRoomNumber;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtStudentNumber;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.TextBox txtRoomNumber;
    }
}
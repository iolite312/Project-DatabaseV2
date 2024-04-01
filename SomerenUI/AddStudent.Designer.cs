namespace SomerenUI
{
    partial class AddStudent
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
            btnAddStudent = new System.Windows.Forms.Button();
            lblFirstName = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            txtFirstName = new System.Windows.Forms.TextBox();
            txtLastName = new System.Windows.Forms.TextBox();
            txtStudentNumber = new System.Windows.Forms.TextBox();
            txtClass = new System.Windows.Forms.TextBox();
            txtRoomNumber = new System.Windows.Forms.TextBox();
            txtPhoneNumber = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // btnAddStudent
            // 
            btnAddStudent.Location = new System.Drawing.Point(37, 423);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new System.Drawing.Size(134, 34);
            btnAddStudent.TabIndex = 0;
            btnAddStudent.Text = "Add Student";
            btnAddStudent.UseVisualStyleBackColor = true;
            btnAddStudent.Click += btnAddStudent_Click;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new System.Drawing.Point(37, 63);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new System.Drawing.Size(111, 25);
            lblFirstName.TabIndex = 1;
            lblFirstName.Text = "First Name : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(37, 108);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(104, 25);
            label2.TabIndex = 2;
            label2.Text = "Last Name :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(37, 156);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(152, 25);
            label3.TabIndex = 3;
            label3.Text = "Student Number :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(37, 204);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(146, 25);
            label4.TabIndex = 4;
            label4.Text = "Phone Number : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(37, 257);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(66, 25);
            label5.TabIndex = 5;
            label5.Text = "Class : ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            label6.Location = new System.Drawing.Point(37, 316);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(139, 25);
            label6.TabIndex = 6;
            label6.Text = "Room Number: ";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new System.Drawing.Point(199, 63);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new System.Drawing.Size(150, 31);
            txtFirstName.TabIndex = 7;
            // 
            // txtLastName
            // 
            txtLastName.Location = new System.Drawing.Point(199, 108);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new System.Drawing.Size(150, 31);
            txtLastName.TabIndex = 8;
            // 
            // txtStudentNumber
            // 
            txtStudentNumber.Location = new System.Drawing.Point(199, 153);
            txtStudentNumber.Name = "txtStudentNumber";
            txtStudentNumber.Size = new System.Drawing.Size(150, 31);
            txtStudentNumber.TabIndex = 9;
            // 
            // txtClass
            // 
            txtClass.Location = new System.Drawing.Point(199, 257);
            txtClass.Name = "txtClass";
            txtClass.Size = new System.Drawing.Size(150, 31);
            txtClass.TabIndex = 10;
            // 
            // txtRoomNumber
            // 
            txtRoomNumber.Location = new System.Drawing.Point(199, 310);
            txtRoomNumber.Name = "txtRoomNumber";
            txtRoomNumber.Size = new System.Drawing.Size(150, 31);
            txtRoomNumber.TabIndex = 11;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new System.Drawing.Point(199, 204);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new System.Drawing.Size(150, 31);
            txtPhoneNumber.TabIndex = 12;
            // 
            // AddStudent
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(820, 531);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtRoomNumber);
            Controls.Add(txtClass);
            Controls.Add(txtStudentNumber);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblFirstName);
            Controls.Add(btnAddStudent);
            Name = "AddStudent";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtStudentNumber;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.TextBox txtRoomNumber;
        private System.Windows.Forms.TextBox txtPhoneNumber;
    }
}
namespace SomerenUI
{
    partial class DeleteStudent
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
            btnDeleteIN = new System.Windows.Forms.Button();
            lblStudentennummmer = new System.Windows.Forms.Label();
            lblLasttName = new System.Windows.Forms.Label();
            txtBoxStudentNumber = new System.Windows.Forms.TextBox();
            txtBoxLastName = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // btnDeleteIN
            // 
            btnDeleteIN.Location = new System.Drawing.Point(48, 217);
            btnDeleteIN.Name = "btnDeleteIN";
            btnDeleteIN.Size = new System.Drawing.Size(112, 34);
            btnDeleteIN.TabIndex = 0;
            btnDeleteIN.Text = "Delete";
            btnDeleteIN.UseVisualStyleBackColor = true;
            btnDeleteIN.Click += btnDeleteIN_Click;
            // 
            // lblStudentennummmer
            // 
            lblStudentennummmer.AutoSize = true;
            lblStudentennummmer.Location = new System.Drawing.Point(48, 60);
            lblStudentennummmer.Name = "lblStudentennummmer";
            lblStudentennummmer.Size = new System.Drawing.Size(152, 25);
            lblStudentennummmer.TabIndex = 1;
            lblStudentennummmer.Text = "Student Number :";
            // 
            // lblLasttName
            // 
            lblLasttName.AutoSize = true;
            lblLasttName.Location = new System.Drawing.Point(48, 113);
            lblLasttName.Name = "lblLasttName";
            lblLasttName.Size = new System.Drawing.Size(104, 25);
            lblLasttName.TabIndex = 2;
            lblLasttName.Text = "Last Name :";
            // 
            // txtBoxStudentNumber
            // 
            txtBoxStudentNumber.Location = new System.Drawing.Point(227, 54);
            txtBoxStudentNumber.Name = "txtBoxStudentNumber";
            txtBoxStudentNumber.Size = new System.Drawing.Size(150, 31);
            txtBoxStudentNumber.TabIndex = 3;
            // 
            // txtBoxLastName
            // 
            txtBoxLastName.Location = new System.Drawing.Point(227, 107);
            txtBoxLastName.Name = "txtBoxLastName";
            txtBoxLastName.Size = new System.Drawing.Size(150, 31);
            txtBoxLastName.TabIndex = 4;
            // 
            // DeleteStudent
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(txtBoxLastName);
            Controls.Add(txtBoxStudentNumber);
            Controls.Add(lblLasttName);
            Controls.Add(lblStudentennummmer);
            Controls.Add(btnDeleteIN);
            Name = "DeleteStudent";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnDeleteIN;
        private System.Windows.Forms.Label lblStudentennummmer;
        private System.Windows.Forms.Label lblLasttName;
        private System.Windows.Forms.TextBox txtBoxStudentNumber;
        private System.Windows.Forms.TextBox txtBoxLastName;
    }
}
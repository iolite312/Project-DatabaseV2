namespace SomerenUI
{
    partial class ConfirmManageSupervisors
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
            label2 = new System.Windows.Forms.Label();
            listViewSupervising = new System.Windows.Forms.ListView();
            lectureID = new System.Windows.Forms.ColumnHeader();
            firstnameLecturer = new System.Windows.Forms.ColumnHeader();
            lastNameLecturer = new System.Windows.Forms.ColumnHeader();
            lblManageSupervisors = new System.Windows.Forms.Label();
            listViewNonSupervising = new System.Windows.Forms.ListView();
            columnHeader1 = new System.Windows.Forms.ColumnHeader();
            columnHeader2 = new System.Windows.Forms.ColumnHeader();
            columnHeader3 = new System.Windows.Forms.ColumnHeader();
            label1 = new System.Windows.Forms.Label();
            ConfirmButton = new System.Windows.Forms.Button();
            CancelButton = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(613, 56);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(209, 20);
            label2.TabIndex = 13;
            label2.Text = "Word verwijderd als begleider";
            // 
            // listViewSupervising
            // 
            listViewSupervising.AllowDrop = true;
            listViewSupervising.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { lectureID, firstnameLecturer, lastNameLecturer });
            listViewSupervising.FullRowSelect = true;
            listViewSupervising.GridLines = true;
            listViewSupervising.Location = new System.Drawing.Point(11, 80);
            listViewSupervising.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            listViewSupervising.Name = "listViewSupervising";
            listViewSupervising.Size = new System.Drawing.Size(374, 408);
            listViewSupervising.TabIndex = 10;
            listViewSupervising.UseCompatibleStateImageBehavior = false;
            listViewSupervising.View = System.Windows.Forms.View.Details;
            // 
            // lectureID
            // 
            lectureID.Text = "id";
            // 
            // firstnameLecturer
            // 
            firstnameLecturer.Text = "First name";
            firstnameLecturer.Width = 150;
            // 
            // lastNameLecturer
            // 
            lastNameLecturer.Text = "Last name";
            lastNameLecturer.Width = 150;
            // 
            // lblManageSupervisors
            // 
            lblManageSupervisors.AutoSize = true;
            lblManageSupervisors.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblManageSupervisors.Location = new System.Drawing.Point(11, 9);
            lblManageSupervisors.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblManageSupervisors.Name = "lblManageSupervisors";
            lblManageSupervisors.Size = new System.Drawing.Size(247, 41);
            lblManageSupervisors.TabIndex = 9;
            lblManageSupervisors.Text = "Confirm Changes";
            // 
            // listViewNonSupervising
            // 
            listViewNonSupervising.AllowDrop = true;
            listViewNonSupervising.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listViewNonSupervising.FullRowSelect = true;
            listViewNonSupervising.GridLines = true;
            listViewNonSupervising.Location = new System.Drawing.Point(613, 80);
            listViewNonSupervising.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            listViewNonSupervising.Name = "listViewNonSupervising";
            listViewNonSupervising.Size = new System.Drawing.Size(374, 408);
            listViewNonSupervising.TabIndex = 11;
            listViewNonSupervising.UseCompatibleStateImageBehavior = false;
            listViewNonSupervising.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "id";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "First name";
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Last name";
            columnHeader3.Width = 150;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(11, 56);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(228, 20);
            label1.TabIndex = 12;
            label1.Text = "Word toegevoegd als begeleider";
            // 
            // ConfirmButton
            // 
            ConfirmButton.Location = new System.Drawing.Point(503, 459);
            ConfirmButton.Name = "ConfirmButton";
            ConfirmButton.Size = new System.Drawing.Size(94, 29);
            ConfirmButton.TabIndex = 14;
            ConfirmButton.Text = "Confirm";
            ConfirmButton.UseVisualStyleBackColor = true;
            ConfirmButton.Click += ConfirmButton_Click;
            // 
            // CancelButton
            // 
            CancelButton.Location = new System.Drawing.Point(403, 459);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new System.Drawing.Size(94, 29);
            CancelButton.TabIndex = 15;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += button2_Click;
            // 
            // ConfirmManageSupervisors
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(999, 515);
            Controls.Add(CancelButton);
            Controls.Add(ConfirmButton);
            Controls.Add(label2);
            Controls.Add(listViewSupervising);
            Controls.Add(lblManageSupervisors);
            Controls.Add(listViewNonSupervising);
            Controls.Add(label1);
            Name = "ConfirmManageSupervisors";
            Text = "Confirm Manage Supervisors";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listViewSupervising;
        private System.Windows.Forms.ColumnHeader lectureID;
        private System.Windows.Forms.ColumnHeader firstnameLecturer;
        private System.Windows.Forms.ColumnHeader lastNameLecturer;
        private System.Windows.Forms.Label lblManageSupervisors;
        private System.Windows.Forms.ListView listViewNonSupervising;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.Button CancelButton;
    }
}
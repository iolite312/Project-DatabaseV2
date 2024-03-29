namespace SomerenUI
{
    partial class ManageSupervisors
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
            lblManageSupervisors = new System.Windows.Forms.Label();
            listViewSupervising = new System.Windows.Forms.ListView();
            lectureID = new System.Windows.Forms.ColumnHeader();
            firstnameLecturer = new System.Windows.Forms.ColumnHeader();
            lastNameLecturer = new System.Windows.Forms.ColumnHeader();
            listViewNonSupervising = new System.Windows.Forms.ListView();
            columnHeader1 = new System.Windows.Forms.ColumnHeader();
            columnHeader2 = new System.Windows.Forms.ColumnHeader();
            columnHeader3 = new System.Windows.Forms.ColumnHeader();
            AddSupervisorsBtn = new System.Windows.Forms.Button();
            RemoveSupervisorsBtn = new System.Windows.Forms.Button();
            Savebtn = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // lblManageSupervisors
            // 
            lblManageSupervisors.AutoSize = true;
            lblManageSupervisors.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblManageSupervisors.Location = new System.Drawing.Point(11, 9);
            lblManageSupervisors.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblManageSupervisors.Name = "lblManageSupervisors";
            lblManageSupervisors.Size = new System.Drawing.Size(286, 41);
            lblManageSupervisors.TabIndex = 1;
            lblManageSupervisors.Text = "Manage Supervisors";
            // 
            // listViewSupervising
            // 
            listViewSupervising.AllowDrop = true;
            listViewSupervising.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { lectureID, firstnameLecturer, lastNameLecturer });
            listViewSupervising.FullRowSelect = true;
            listViewSupervising.GridLines = true;
            listViewSupervising.Location = new System.Drawing.Point(11, 83);
            listViewSupervising.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            listViewSupervising.Name = "listViewSupervising";
            listViewSupervising.Size = new System.Drawing.Size(374, 408);
            listViewSupervising.TabIndex = 2;
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
            // listViewNonSupervising
            // 
            listViewNonSupervising.AllowDrop = true;
            listViewNonSupervising.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listViewNonSupervising.FullRowSelect = true;
            listViewNonSupervising.GridLines = true;
            listViewNonSupervising.Location = new System.Drawing.Point(610, 83);
            listViewNonSupervising.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            listViewNonSupervising.Name = "listViewNonSupervising";
            listViewNonSupervising.Size = new System.Drawing.Size(374, 408);
            listViewNonSupervising.TabIndex = 3;
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
            // AddSupervisorsBtn
            // 
            AddSupervisorsBtn.Location = new System.Drawing.Point(445, 392);
            AddSupervisorsBtn.Name = "AddSupervisorsBtn";
            AddSupervisorsBtn.Size = new System.Drawing.Size(104, 29);
            AddSupervisorsBtn.TabIndex = 4;
            AddSupervisorsBtn.Text = "<< Add";
            AddSupervisorsBtn.UseVisualStyleBackColor = true;
            AddSupervisorsBtn.Click += AddSupervisors_Click;
            // 
            // RemoveSupervisorsBtn
            // 
            RemoveSupervisorsBtn.Location = new System.Drawing.Point(445, 427);
            RemoveSupervisorsBtn.Name = "RemoveSupervisorsBtn";
            RemoveSupervisorsBtn.Size = new System.Drawing.Size(104, 29);
            RemoveSupervisorsBtn.TabIndex = 5;
            RemoveSupervisorsBtn.Text = "Remove >>";
            RemoveSupervisorsBtn.UseVisualStyleBackColor = true;
            RemoveSupervisorsBtn.Click += RemoveSupervisorsBtn_Click;
            // 
            // Savebtn
            // 
            Savebtn.Location = new System.Drawing.Point(445, 462);
            Savebtn.Name = "Savebtn";
            Savebtn.Size = new System.Drawing.Size(104, 29);
            Savebtn.TabIndex = 6;
            Savebtn.Text = "Save";
            Savebtn.UseVisualStyleBackColor = true;
            Savebtn.Click += Savebtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 59);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(68, 20);
            label1.TabIndex = 7;
            label1.Text = "Begeleid";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(610, 59);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(100, 20);
            label2.TabIndex = 8;
            label2.Text = "Begeleid Niet";
            // 
            // ManageSupervisors
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(996, 515);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Savebtn);
            Controls.Add(RemoveSupervisorsBtn);
            Controls.Add(AddSupervisorsBtn);
            Controls.Add(listViewNonSupervising);
            Controls.Add(listViewSupervising);
            Controls.Add(lblManageSupervisors);
            Name = "ManageSupervisors";
            Text = "Manage Supervisors";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblManageSupervisors;
        private System.Windows.Forms.ListView listViewSupervising;
        private System.Windows.Forms.ColumnHeader lectureID;
        private System.Windows.Forms.ColumnHeader firstnameLecturer;
        private System.Windows.Forms.ColumnHeader lastNameLecturer;
        private System.Windows.Forms.ListView listViewNonSupervising;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button AddSupervisorsBtn;
        private System.Windows.Forms.Button RemoveSupervisorsBtn;
        private System.Windows.Forms.Button Savebtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
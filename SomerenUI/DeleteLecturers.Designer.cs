namespace SomerenUI
{
    partial class DeleteLecturers
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
            DeleteLecturerHeaderLbl = new System.Windows.Forms.Label();
            DeleteLecturerDeletedLbl = new System.Windows.Forms.Label();
            DeleteLecturerDeleteYesBtn = new System.Windows.Forms.Button();
            DeleteLecturerNametxt = new System.Windows.Forms.TextBox();
            LecturerDeleteLecturerNameLbl = new System.Windows.Forms.Label();
            DeleteLecturerDeleteNoBtn = new System.Windows.Forms.Button();
            DeleteLecturerQuestionLbl = new System.Windows.Forms.Label();
            DeleteLecturerCautionLbl = new System.Windows.Forms.Label();
            DeleteLecturerNumberTxt = new System.Windows.Forms.TextBox();
            LecturerDeleteNumberLbl = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // DeleteLecturerHeaderLbl
            // 
            DeleteLecturerHeaderLbl.AutoSize = true;
            DeleteLecturerHeaderLbl.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            DeleteLecturerHeaderLbl.Location = new System.Drawing.Point(293, 30);
            DeleteLecturerHeaderLbl.Name = "DeleteLecturerHeaderLbl";
            DeleteLecturerHeaderLbl.Size = new System.Drawing.Size(177, 35);
            DeleteLecturerHeaderLbl.TabIndex = 35;
            DeleteLecturerHeaderLbl.Text = "Delete lecturer";
            // 
            // DeleteLecturerDeletedLbl
            // 
            DeleteLecturerDeletedLbl.AutoSize = true;
            DeleteLecturerDeletedLbl.Location = new System.Drawing.Point(314, 325);
            DeleteLecturerDeletedLbl.Name = "DeleteLecturerDeletedLbl";
            DeleteLecturerDeletedLbl.Size = new System.Drawing.Size(121, 20);
            DeleteLecturerDeletedLbl.TabIndex = 34;
            DeleteLecturerDeletedLbl.Text = "Lecturer deleted!";
            // 
            // DeleteLecturerDeleteYesBtn
            // 
            DeleteLecturerDeleteYesBtn.Location = new System.Drawing.Point(326, 258);
            DeleteLecturerDeleteYesBtn.Name = "DeleteLecturerDeleteYesBtn";
            DeleteLecturerDeleteYesBtn.Size = new System.Drawing.Size(94, 29);
            DeleteLecturerDeleteYesBtn.TabIndex = 33;
            DeleteLecturerDeleteYesBtn.Text = "Yes";
            DeleteLecturerDeleteYesBtn.UseVisualStyleBackColor = true;
            DeleteLecturerDeleteYesBtn.Click += DeleteLecturerDeleteYesBtn_Click;
            // 
            // DeleteLecturerNametxt
            // 
            DeleteLecturerNametxt.Location = new System.Drawing.Point(360, 147);
            DeleteLecturerNametxt.Name = "DeleteLecturerNametxt";
            DeleteLecturerNametxt.Size = new System.Drawing.Size(125, 27);
            DeleteLecturerNametxt.TabIndex = 32;
            // 
            // LecturerDeleteLecturerNameLbl
            // 
            LecturerDeleteLecturerNameLbl.AutoSize = true;
            LecturerDeleteLecturerNameLbl.Location = new System.Drawing.Point(293, 150);
            LecturerDeleteLecturerNameLbl.Name = "LecturerDeleteLecturerNameLbl";
            LecturerDeleteLecturerNameLbl.Size = new System.Drawing.Size(52, 20);
            LecturerDeleteLecturerNameLbl.TabIndex = 31;
            LecturerDeleteLecturerNameLbl.Text = "Name:";
            // 
            // DeleteLecturerDeleteNoBtn
            // 
            DeleteLecturerDeleteNoBtn.Location = new System.Drawing.Point(326, 293);
            DeleteLecturerDeleteNoBtn.Name = "DeleteLecturerDeleteNoBtn";
            DeleteLecturerDeleteNoBtn.Size = new System.Drawing.Size(94, 29);
            DeleteLecturerDeleteNoBtn.TabIndex = 36;
            DeleteLecturerDeleteNoBtn.Text = "No";
            DeleteLecturerDeleteNoBtn.UseVisualStyleBackColor = true;
            DeleteLecturerDeleteNoBtn.Click += DeleteLecturerDeleteNoBtn_Click;
            // 
            // DeleteLecturerQuestionLbl
            // 
            DeleteLecturerQuestionLbl.AutoSize = true;
            DeleteLecturerQuestionLbl.Location = new System.Drawing.Point(234, 200);
            DeleteLecturerQuestionLbl.Name = "DeleteLecturerQuestionLbl";
            DeleteLecturerQuestionLbl.Size = new System.Drawing.Size(307, 20);
            DeleteLecturerQuestionLbl.TabIndex = 37;
            DeleteLecturerQuestionLbl.Text = "Are you sure you want to delete this lecturer?";
            // 
            // DeleteLecturerCautionLbl
            // 
            DeleteLecturerCautionLbl.AutoSize = true;
            DeleteLecturerCautionLbl.Location = new System.Drawing.Point(261, 220);
            DeleteLecturerCautionLbl.Name = "DeleteLecturerCautionLbl";
            DeleteLecturerCautionLbl.Size = new System.Drawing.Size(252, 20);
            DeleteLecturerCautionLbl.TabIndex = 38;
            DeleteLecturerCautionLbl.Text = "(Beware this action is not reversible!)";
            // 
            // DeleteLecturerNumberTxt
            // 
            DeleteLecturerNumberTxt.Location = new System.Drawing.Point(360, 95);
            DeleteLecturerNumberTxt.Name = "DeleteLecturerNumberTxt";
            DeleteLecturerNumberTxt.Size = new System.Drawing.Size(125, 27);
            DeleteLecturerNumberTxt.TabIndex = 40;
            // 
            // LecturerDeleteNumberLbl
            // 
            LecturerDeleteNumberLbl.AutoSize = true;
            LecturerDeleteNumberLbl.Location = new System.Drawing.Point(225, 98);
            LecturerDeleteNumberLbl.Name = "LecturerDeleteNumberLbl";
            LecturerDeleteNumberLbl.Size = new System.Drawing.Size(120, 20);
            LecturerDeleteNumberLbl.TabIndex = 39;
            LecturerDeleteNumberLbl.Text = "Lecturer number:";
            // 
            // DeleteLecturers
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(DeleteLecturerNumberTxt);
            Controls.Add(LecturerDeleteNumberLbl);
            Controls.Add(DeleteLecturerCautionLbl);
            Controls.Add(DeleteLecturerQuestionLbl);
            Controls.Add(DeleteLecturerDeleteNoBtn);
            Controls.Add(DeleteLecturerHeaderLbl);
            Controls.Add(DeleteLecturerDeletedLbl);
            Controls.Add(DeleteLecturerDeleteYesBtn);
            Controls.Add(DeleteLecturerNametxt);
            Controls.Add(LecturerDeleteLecturerNameLbl);
            Name = "DeleteLecturers";
            Text = "DeleteLecturers";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label DeleteLecturerHeaderLbl;
        private System.Windows.Forms.Label DeleteLecturerDeletedLbl;
        private System.Windows.Forms.Button DeleteLecturerDeleteYesBtn;
        private System.Windows.Forms.TextBox DeleteLecturerNametxt;
        private System.Windows.Forms.Label LecturerDeleteLecturerNameLbl;
        private System.Windows.Forms.Button DeleteLecturerDeleteNoBtn;
        private System.Windows.Forms.Label DeleteLecturerQuestionLbl;
        private System.Windows.Forms.Label DeleteLecturerCautionLbl;
        private System.Windows.Forms.TextBox DeleteLecturerNumberTxt;
        private System.Windows.Forms.Label LecturerDeleteNumberLbl;
    }
}
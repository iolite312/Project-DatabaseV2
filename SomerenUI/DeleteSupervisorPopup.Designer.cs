namespace SomerenUI
{
    partial class DeleteSupervisorPopup
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
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            CancelBtn = new System.Windows.Forms.Button();
            ConfirmBtn = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(213, 23);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(345, 20);
            label1.TabIndex = 0;
            label1.Text = "The action that you want to do contains a deletion,";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(227, 52);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(311, 20);
            label2.TabIndex = 1;
            label2.Text = "Are you sure you want to remove supervisors?";
            // 
            // CancelBtn
            // 
            CancelBtn.Location = new System.Drawing.Point(227, 147);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new System.Drawing.Size(130, 29);
            CancelBtn.TabIndex = 2;
            CancelBtn.Text = "Cancel";
            CancelBtn.UseVisualStyleBackColor = true;
            CancelBtn.Click += CancelBtn_Click;
            // 
            // ConfirmBtn
            // 
            ConfirmBtn.Location = new System.Drawing.Point(391, 147);
            ConfirmBtn.Name = "ConfirmBtn";
            ConfirmBtn.Size = new System.Drawing.Size(147, 29);
            ConfirmBtn.TabIndex = 3;
            ConfirmBtn.Text = "Confirm";
            ConfirmBtn.UseVisualStyleBackColor = true;
            ConfirmBtn.Click += ConfirmBtn_Click;
            // 
            // DeleteSupervisorPopup
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(750, 239);
            Controls.Add(ConfirmBtn);
            Controls.Add(CancelBtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "DeleteSupervisorPopup";
            Text = "Delete Supervisor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button ConfirmBtn;
    }
}
namespace SomerenUI
{
    partial class DeleteDrink
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
            DeleteDrinkHeaderLbl = new System.Windows.Forms.Label();
            DeleteDrinksEditedLbl = new System.Windows.Forms.Label();
            DeleteDrinkEditBtn = new System.Windows.Forms.Button();
            DeleteDrinkNametxt = new System.Windows.Forms.TextBox();
            DeleteDrinkSelectCB = new System.Windows.Forms.ComboBox();
            DrinkDeleteDrinkNameLbl = new System.Windows.Forms.Label();
            DrinkDeleteDrinkIdLbl = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // DeleteDrinkHeaderLbl
            // 
            DeleteDrinkHeaderLbl.AutoSize = true;
            DeleteDrinkHeaderLbl.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            DeleteDrinkHeaderLbl.Location = new System.Drawing.Point(357, 72);
            DeleteDrinkHeaderLbl.Name = "DeleteDrinkHeaderLbl";
            DeleteDrinkHeaderLbl.Size = new System.Drawing.Size(149, 35);
            DeleteDrinkHeaderLbl.TabIndex = 30;
            DeleteDrinkHeaderLbl.Text = "Delete drink";
            // 
            // DeleteDrinksEditedLbl
            // 
            DeleteDrinksEditedLbl.AutoSize = true;
            DeleteDrinksEditedLbl.Location = new System.Drawing.Point(364, 277);
            DeleteDrinksEditedLbl.Name = "DeleteDrinksEditedLbl";
            DeleteDrinksEditedLbl.Size = new System.Drawing.Size(103, 20);
            DeleteDrinksEditedLbl.TabIndex = 29;
            DeleteDrinksEditedLbl.Text = "Drink deleted!";
            // 
            // DeleteDrinkEditBtn
            // 
            DeleteDrinkEditBtn.Location = new System.Drawing.Point(371, 245);
            DeleteDrinkEditBtn.Name = "DeleteDrinkEditBtn";
            DeleteDrinkEditBtn.Size = new System.Drawing.Size(94, 29);
            DeleteDrinkEditBtn.TabIndex = 26;
            DeleteDrinkEditBtn.Text = "Delete drink";
            DeleteDrinkEditBtn.UseVisualStyleBackColor = true;
            DeleteDrinkEditBtn.Click += DeleteDrinkEditBtn_Click;
            // 
            // DeleteDrinkNametxt
            // 
            DeleteDrinkNametxt.Location = new System.Drawing.Point(398, 176);
            DeleteDrinkNametxt.Name = "DeleteDrinkNametxt";
            DeleteDrinkNametxt.Size = new System.Drawing.Size(125, 27);
            DeleteDrinkNametxt.TabIndex = 25;
            // 
            // DeleteDrinkSelectCB
            // 
            DeleteDrinkSelectCB.FormattingEnabled = true;
            DeleteDrinkSelectCB.Location = new System.Drawing.Point(398, 142);
            DeleteDrinkSelectCB.Name = "DeleteDrinkSelectCB";
            DeleteDrinkSelectCB.Size = new System.Drawing.Size(125, 28);
            DeleteDrinkSelectCB.TabIndex = 22;
            DeleteDrinkSelectCB.SelectedIndexChanged += DeleteDrinkSelectCB_SelectedIndexChanged;
            // 
            // DrinkDeleteDrinkNameLbl
            // 
            DrinkDeleteDrinkNameLbl.AutoSize = true;
            DrinkDeleteDrinkNameLbl.Location = new System.Drawing.Point(278, 183);
            DrinkDeleteDrinkNameLbl.Name = "DrinkDeleteDrinkNameLbl";
            DrinkDeleteDrinkNameLbl.Size = new System.Drawing.Size(52, 20);
            DrinkDeleteDrinkNameLbl.TabIndex = 18;
            DrinkDeleteDrinkNameLbl.Text = "Name:";
            // 
            // DrinkDeleteDrinkIdLbl
            // 
            DrinkDeleteDrinkIdLbl.AutoSize = true;
            DrinkDeleteDrinkIdLbl.Location = new System.Drawing.Point(281, 142);
            DrinkDeleteDrinkIdLbl.Name = "DrinkDeleteDrinkIdLbl";
            DrinkDeleteDrinkIdLbl.Size = new System.Drawing.Size(25, 20);
            DrinkDeleteDrinkIdLbl.TabIndex = 17;
            DrinkDeleteDrinkIdLbl.Text = "Id:";
            // 
            // DeleteDrink
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(DeleteDrinkHeaderLbl);
            Controls.Add(DeleteDrinksEditedLbl);
            Controls.Add(DeleteDrinkEditBtn);
            Controls.Add(DeleteDrinkNametxt);
            Controls.Add(DeleteDrinkSelectCB);
            Controls.Add(DrinkDeleteDrinkNameLbl);
            Controls.Add(DrinkDeleteDrinkIdLbl);
            Name = "DeleteDrink";
            Text = "DeleteDrink";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label DeleteDrinkHeaderLbl;
        private System.Windows.Forms.Label DeleteDrinksEditedLbl;
        private System.Windows.Forms.Button DeleteDrinkEditBtn;
        private System.Windows.Forms.TextBox DeleteDrinkNametxt;
        private System.Windows.Forms.ComboBox DeleteDrinkSelectCB;
        private System.Windows.Forms.Label DrinkDeleteDrinkNameLbl;
        private System.Windows.Forms.Label DrinkDeleteDrinkIdLbl;
    }
}
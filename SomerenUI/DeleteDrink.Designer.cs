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
            DrinkDeleteDrinkNameLbl = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // DeleteDrinkHeaderLbl
            // 
            DeleteDrinkHeaderLbl.AutoSize = true;
            DeleteDrinkHeaderLbl.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            DeleteDrinkHeaderLbl.Location = new System.Drawing.Point(43, 9);
            DeleteDrinkHeaderLbl.Name = "DeleteDrinkHeaderLbl";
            DeleteDrinkHeaderLbl.Size = new System.Drawing.Size(149, 35);
            DeleteDrinkHeaderLbl.TabIndex = 30;
            DeleteDrinkHeaderLbl.Text = "Delete drink";
            // 
            // DeleteDrinksEditedLbl
            // 
            DeleteDrinksEditedLbl.AutoSize = true;
            DeleteDrinksEditedLbl.Location = new System.Drawing.Point(53, 161);
            DeleteDrinksEditedLbl.Name = "DeleteDrinksEditedLbl";
            DeleteDrinksEditedLbl.Size = new System.Drawing.Size(103, 20);
            DeleteDrinksEditedLbl.TabIndex = 29;
            DeleteDrinksEditedLbl.Text = "Drink deleted!";
            // 
            // DeleteDrinkEditBtn
            // 
            DeleteDrinkEditBtn.Location = new System.Drawing.Point(60, 129);
            DeleteDrinkEditBtn.Name = "DeleteDrinkEditBtn";
            DeleteDrinkEditBtn.Size = new System.Drawing.Size(94, 29);
            DeleteDrinkEditBtn.TabIndex = 26;
            DeleteDrinkEditBtn.Text = "Delete drink";
            DeleteDrinkEditBtn.UseVisualStyleBackColor = true;
            DeleteDrinkEditBtn.Click += DeleteDrinkEditBtn_Click;
            // 
            // DeleteDrinkNametxt
            // 
            DeleteDrinkNametxt.Location = new System.Drawing.Point(95, 62);
            DeleteDrinkNametxt.Name = "DeleteDrinkNametxt";
            DeleteDrinkNametxt.Size = new System.Drawing.Size(125, 27);
            DeleteDrinkNametxt.TabIndex = 25;
            // 
            // DrinkDeleteDrinkNameLbl
            // 
            DrinkDeleteDrinkNameLbl.AutoSize = true;
            DrinkDeleteDrinkNameLbl.Location = new System.Drawing.Point(12, 65);
            DrinkDeleteDrinkNameLbl.Name = "DrinkDeleteDrinkNameLbl";
            DrinkDeleteDrinkNameLbl.Size = new System.Drawing.Size(52, 20);
            DrinkDeleteDrinkNameLbl.TabIndex = 18;
            DrinkDeleteDrinkNameLbl.Text = "Name:";
            // 
            // DeleteDrink
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(230, 195);
            Controls.Add(DeleteDrinkHeaderLbl);
            Controls.Add(DeleteDrinksEditedLbl);
            Controls.Add(DeleteDrinkEditBtn);
            Controls.Add(DeleteDrinkNametxt);
            Controls.Add(DrinkDeleteDrinkNameLbl);
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
        private System.Windows.Forms.Label DrinkDeleteDrinkNameLbl;
    }
}
﻿namespace SomerenUI
{
    partial class EditDrink
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
            DrinkEditDrinkIdLbl = new System.Windows.Forms.Label();
            DrinkEditDrinkNameLbl = new System.Windows.Forms.Label();
            DrinkEditDrinkPriceLbl = new System.Windows.Forms.Label();
            DrinkEditDrinkTypeLbl = new System.Windows.Forms.Label();
            DrinkEditDrinkStockLbl = new System.Windows.Forms.Label();
            EditDrinkSelectCB = new System.Windows.Forms.ComboBox();
            EditDrinkPricetxt = new System.Windows.Forms.TextBox();
            EditDrinkStockTxt = new System.Windows.Forms.TextBox();
            EditDrinkNametxt = new System.Windows.Forms.TextBox();
            EditDrinkEditBtn = new System.Windows.Forms.Button();
            DrinkEditAlcoholicNoBtn = new System.Windows.Forms.RadioButton();
            DrinkEditAlcoholicYesBtn = new System.Windows.Forms.RadioButton();
            EditDrinksEditedLbl = new System.Windows.Forms.Label();
            EditDrinkHeaderLbl = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // DrinkEditDrinkIdLbl
            // 
            DrinkEditDrinkIdLbl.AutoSize = true;
            DrinkEditDrinkIdLbl.Location = new System.Drawing.Point(9, 105);
            DrinkEditDrinkIdLbl.Name = "DrinkEditDrinkIdLbl";
            DrinkEditDrinkIdLbl.Size = new System.Drawing.Size(25, 20);
            DrinkEditDrinkIdLbl.TabIndex = 0;
            DrinkEditDrinkIdLbl.Text = "Id:";
            // 
            // DrinkEditDrinkNameLbl
            // 
            DrinkEditDrinkNameLbl.AutoSize = true;
            DrinkEditDrinkNameLbl.Location = new System.Drawing.Point(6, 146);
            DrinkEditDrinkNameLbl.Name = "DrinkEditDrinkNameLbl";
            DrinkEditDrinkNameLbl.Size = new System.Drawing.Size(52, 20);
            DrinkEditDrinkNameLbl.TabIndex = 1;
            DrinkEditDrinkNameLbl.Text = "Name:";
            // 
            // DrinkEditDrinkPriceLbl
            // 
            DrinkEditDrinkPriceLbl.AutoSize = true;
            DrinkEditDrinkPriceLbl.Location = new System.Drawing.Point(6, 179);
            DrinkEditDrinkPriceLbl.Name = "DrinkEditDrinkPriceLbl";
            DrinkEditDrinkPriceLbl.Size = new System.Drawing.Size(44, 20);
            DrinkEditDrinkPriceLbl.TabIndex = 2;
            DrinkEditDrinkPriceLbl.Text = "Price:";
            // 
            // DrinkEditDrinkTypeLbl
            // 
            DrinkEditDrinkTypeLbl.AutoSize = true;
            DrinkEditDrinkTypeLbl.Location = new System.Drawing.Point(9, 209);
            DrinkEditDrinkTypeLbl.Name = "DrinkEditDrinkTypeLbl";
            DrinkEditDrinkTypeLbl.Size = new System.Drawing.Size(74, 20);
            DrinkEditDrinkTypeLbl.TabIndex = 3;
            DrinkEditDrinkTypeLbl.Text = "Alcoholic:";
            // 
            // DrinkEditDrinkStockLbl
            // 
            DrinkEditDrinkStockLbl.AutoSize = true;
            DrinkEditDrinkStockLbl.Location = new System.Drawing.Point(9, 242);
            DrinkEditDrinkStockLbl.Name = "DrinkEditDrinkStockLbl";
            DrinkEditDrinkStockLbl.Size = new System.Drawing.Size(48, 20);
            DrinkEditDrinkStockLbl.TabIndex = 4;
            DrinkEditDrinkStockLbl.Text = "Stock:";
            // 
            // EditDrinkSelectCB
            // 
            EditDrinkSelectCB.FormattingEnabled = true;
            EditDrinkSelectCB.Location = new System.Drawing.Point(126, 105);
            EditDrinkSelectCB.Name = "EditDrinkSelectCB";
            EditDrinkSelectCB.Size = new System.Drawing.Size(125, 28);
            EditDrinkSelectCB.TabIndex = 5;
            EditDrinkSelectCB.SelectedIndexChanged += EditDrinkSelectCB_SelectedIndexChanged;
            // 
            // EditDrinkPricetxt
            // 
            EditDrinkPricetxt.Location = new System.Drawing.Point(126, 172);
            EditDrinkPricetxt.Name = "EditDrinkPricetxt";
            EditDrinkPricetxt.Size = new System.Drawing.Size(125, 27);
            EditDrinkPricetxt.TabIndex = 7;
            // 
            // EditDrinkStockTxt
            // 
            EditDrinkStockTxt.Location = new System.Drawing.Point(126, 235);
            EditDrinkStockTxt.Name = "EditDrinkStockTxt";
            EditDrinkStockTxt.Size = new System.Drawing.Size(125, 27);
            EditDrinkStockTxt.TabIndex = 9;
            // 
            // EditDrinkNametxt
            // 
            EditDrinkNametxt.Location = new System.Drawing.Point(126, 139);
            EditDrinkNametxt.Name = "EditDrinkNametxt";
            EditDrinkNametxt.Size = new System.Drawing.Size(125, 27);
            EditDrinkNametxt.TabIndex = 11;
            // 
            // EditDrinkEditBtn
            // 
            EditDrinkEditBtn.Location = new System.Drawing.Point(98, 289);
            EditDrinkEditBtn.Name = "EditDrinkEditBtn";
            EditDrinkEditBtn.Size = new System.Drawing.Size(94, 29);
            EditDrinkEditBtn.TabIndex = 12;
            EditDrinkEditBtn.Text = "Edit drink";
            EditDrinkEditBtn.UseVisualStyleBackColor = true;
            EditDrinkEditBtn.Click += EditDrinkEditBtn_Click;
            // 
            // DrinkEditAlcoholicNoBtn
            // 
            DrinkEditAlcoholicNoBtn.AutoSize = true;
            DrinkEditAlcoholicNoBtn.Location = new System.Drawing.Point(201, 205);
            DrinkEditAlcoholicNoBtn.Name = "DrinkEditAlcoholicNoBtn";
            DrinkEditAlcoholicNoBtn.Size = new System.Drawing.Size(50, 24);
            DrinkEditAlcoholicNoBtn.TabIndex = 14;
            DrinkEditAlcoholicNoBtn.TabStop = true;
            DrinkEditAlcoholicNoBtn.Text = "No";
            DrinkEditAlcoholicNoBtn.UseVisualStyleBackColor = true;
            // 
            // DrinkEditAlcoholicYesBtn
            // 
            DrinkEditAlcoholicYesBtn.AutoSize = true;
            DrinkEditAlcoholicYesBtn.Location = new System.Drawing.Point(126, 205);
            DrinkEditAlcoholicYesBtn.Name = "DrinkEditAlcoholicYesBtn";
            DrinkEditAlcoholicYesBtn.Size = new System.Drawing.Size(51, 24);
            DrinkEditAlcoholicYesBtn.TabIndex = 13;
            DrinkEditAlcoholicYesBtn.TabStop = true;
            DrinkEditAlcoholicYesBtn.Text = "Yes";
            DrinkEditAlcoholicYesBtn.UseVisualStyleBackColor = true;
            // 
            // EditDrinksEditedLbl
            // 
            EditDrinksEditedLbl.AutoSize = true;
            EditDrinksEditedLbl.Location = new System.Drawing.Point(91, 321);
            EditDrinksEditedLbl.Name = "EditDrinksEditedLbl";
            EditDrinksEditedLbl.Size = new System.Drawing.Size(108, 20);
            EditDrinksEditedLbl.TabIndex = 15;
            EditDrinksEditedLbl.Text = "Drink updated!";
            // 
            // EditDrinkHeaderLbl
            // 
            EditDrinkHeaderLbl.AutoSize = true;
            EditDrinkHeaderLbl.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            EditDrinkHeaderLbl.Location = new System.Drawing.Point(85, 35);
            EditDrinkHeaderLbl.Name = "EditDrinkHeaderLbl";
            EditDrinkHeaderLbl.Size = new System.Drawing.Size(120, 35);
            EditDrinkHeaderLbl.TabIndex = 16;
            EditDrinkHeaderLbl.Text = "Edit drink";
            // 
            // EditDrink
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(273, 367);
            Controls.Add(EditDrinkHeaderLbl);
            Controls.Add(EditDrinksEditedLbl);
            Controls.Add(DrinkEditAlcoholicNoBtn);
            Controls.Add(DrinkEditAlcoholicYesBtn);
            Controls.Add(EditDrinkEditBtn);
            Controls.Add(EditDrinkNametxt);
            Controls.Add(EditDrinkStockTxt);
            Controls.Add(EditDrinkPricetxt);
            Controls.Add(EditDrinkSelectCB);
            Controls.Add(DrinkEditDrinkStockLbl);
            Controls.Add(DrinkEditDrinkTypeLbl);
            Controls.Add(DrinkEditDrinkPriceLbl);
            Controls.Add(DrinkEditDrinkNameLbl);
            Controls.Add(DrinkEditDrinkIdLbl);
            Name = "EditDrink";
            Text = "EditDrink";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label DrinkEditDrinkIdLbl;
        private System.Windows.Forms.Label DrinkEditDrinkNameLbl;
        private System.Windows.Forms.Label DrinkEditDrinkPriceLbl;
        private System.Windows.Forms.Label DrinkEditDrinkTypeLbl;
        private System.Windows.Forms.Label DrinkEditDrinkStockLbl;
        private System.Windows.Forms.ComboBox EditDrinkSelectCB;
        private System.Windows.Forms.TextBox EditDrinkPricetxt;
        private System.Windows.Forms.TextBox EditDrinkStockTxt;
        private System.Windows.Forms.TextBox EditDrinkNametxt;
        private System.Windows.Forms.Button EditDrinkEditBtn;
        private System.Windows.Forms.RadioButton DrinkEditAlcoholicNoBtn;
        private System.Windows.Forms.RadioButton DrinkEditAlcoholicYesBtn;
        private System.Windows.Forms.Label EditDrinksEditedLbl;
        private System.Windows.Forms.Label EditDrinkHeaderLbl;
    }
}
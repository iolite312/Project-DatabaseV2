namespace SomerenUI
{
    partial class AddDrink
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
            DrinkAddNamelbl = new System.Windows.Forms.Label();
            DrinkAddPricelbl = new System.Windows.Forms.Label();
            DrinkAddAlcoholiclbl = new System.Windows.Forms.Label();
            DrinkAddNameTxt = new System.Windows.Forms.TextBox();
            DrinkAddPriceTxt = new System.Windows.Forms.TextBox();
            DrinkAddStockTxt = new System.Windows.Forms.TextBox();
            DrinkAddStockLbl = new System.Windows.Forms.Label();
            DrinkAddAlcoholicYesBtn = new System.Windows.Forms.RadioButton();
            DrinkAddAlcoholicNoBtn = new System.Windows.Forms.RadioButton();
            AddDrinksLbl = new System.Windows.Forms.Label();
            AddDrinksSubmitBtn = new System.Windows.Forms.Button();
            AddDrinksAddedLbl = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // DrinkAddNamelbl
            // 
            DrinkAddNamelbl.AutoSize = true;
            DrinkAddNamelbl.Location = new System.Drawing.Point(42, 82);
            DrinkAddNamelbl.Name = "DrinkAddNamelbl";
            DrinkAddNamelbl.Size = new System.Drawing.Size(52, 20);
            DrinkAddNamelbl.TabIndex = 0;
            DrinkAddNamelbl.Text = "Name:";
            // 
            // DrinkAddPricelbl
            // 
            DrinkAddPricelbl.AutoSize = true;
            DrinkAddPricelbl.Location = new System.Drawing.Point(42, 134);
            DrinkAddPricelbl.Name = "DrinkAddPricelbl";
            DrinkAddPricelbl.Size = new System.Drawing.Size(44, 20);
            DrinkAddPricelbl.TabIndex = 1;
            DrinkAddPricelbl.Text = "Price:";
            // 
            // DrinkAddAlcoholiclbl
            // 
            DrinkAddAlcoholiclbl.AutoSize = true;
            DrinkAddAlcoholiclbl.Location = new System.Drawing.Point(42, 191);
            DrinkAddAlcoholiclbl.Name = "DrinkAddAlcoholiclbl";
            DrinkAddAlcoholiclbl.Size = new System.Drawing.Size(74, 20);
            DrinkAddAlcoholiclbl.TabIndex = 2;
            DrinkAddAlcoholiclbl.Text = "Alcoholic:";
            // 
            // DrinkAddNameTxt
            // 
            DrinkAddNameTxt.Location = new System.Drawing.Point(175, 79);
            DrinkAddNameTxt.Name = "DrinkAddNameTxt";
            DrinkAddNameTxt.Size = new System.Drawing.Size(125, 27);
            DrinkAddNameTxt.TabIndex = 3;
            // 
            // DrinkAddPriceTxt
            // 
            DrinkAddPriceTxt.Location = new System.Drawing.Point(175, 134);
            DrinkAddPriceTxt.Name = "DrinkAddPriceTxt";
            DrinkAddPriceTxt.Size = new System.Drawing.Size(125, 27);
            DrinkAddPriceTxt.TabIndex = 4;
            // 
            // DrinkAddStockTxt
            // 
            DrinkAddStockTxt.Location = new System.Drawing.Point(175, 249);
            DrinkAddStockTxt.Name = "DrinkAddStockTxt";
            DrinkAddStockTxt.Size = new System.Drawing.Size(125, 27);
            DrinkAddStockTxt.TabIndex = 5;
            // 
            // DrinkAddStockLbl
            // 
            DrinkAddStockLbl.AutoSize = true;
            DrinkAddStockLbl.Location = new System.Drawing.Point(42, 249);
            DrinkAddStockLbl.Name = "DrinkAddStockLbl";
            DrinkAddStockLbl.Size = new System.Drawing.Size(48, 20);
            DrinkAddStockLbl.TabIndex = 6;
            DrinkAddStockLbl.Text = "Stock:";
            // 
            // DrinkAddAlcoholicYesBtn
            // 
            DrinkAddAlcoholicYesBtn.AutoSize = true;
            DrinkAddAlcoholicYesBtn.Location = new System.Drawing.Point(175, 191);
            DrinkAddAlcoholicYesBtn.Name = "DrinkAddAlcoholicYesBtn";
            DrinkAddAlcoholicYesBtn.Size = new System.Drawing.Size(51, 24);
            DrinkAddAlcoholicYesBtn.TabIndex = 7;
            DrinkAddAlcoholicYesBtn.TabStop = true;
            DrinkAddAlcoholicYesBtn.Text = "Yes";
            DrinkAddAlcoholicYesBtn.UseVisualStyleBackColor = true;
            // 
            // DrinkAddAlcoholicNoBtn
            // 
            DrinkAddAlcoholicNoBtn.AutoSize = true;
            DrinkAddAlcoholicNoBtn.Location = new System.Drawing.Point(250, 191);
            DrinkAddAlcoholicNoBtn.Name = "DrinkAddAlcoholicNoBtn";
            DrinkAddAlcoholicNoBtn.Size = new System.Drawing.Size(50, 24);
            DrinkAddAlcoholicNoBtn.TabIndex = 8;
            DrinkAddAlcoholicNoBtn.TabStop = true;
            DrinkAddAlcoholicNoBtn.Text = "No";
            DrinkAddAlcoholicNoBtn.UseVisualStyleBackColor = true;
            // 
            // AddDrinksLbl
            // 
            AddDrinksLbl.AutoSize = true;
            AddDrinksLbl.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            AddDrinksLbl.Location = new System.Drawing.Point(113, 9);
            AddDrinksLbl.Name = "AddDrinksLbl";
            AddDrinksLbl.Size = new System.Drawing.Size(135, 35);
            AddDrinksLbl.TabIndex = 9;
            AddDrinksLbl.Text = "Add drinks";
            // 
            // AddDrinksSubmitBtn
            // 
            AddDrinksSubmitBtn.Location = new System.Drawing.Point(129, 314);
            AddDrinksSubmitBtn.Name = "AddDrinksSubmitBtn";
            AddDrinksSubmitBtn.Size = new System.Drawing.Size(94, 29);
            AddDrinksSubmitBtn.TabIndex = 10;
            AddDrinksSubmitBtn.Text = "Submit";
            AddDrinksSubmitBtn.UseVisualStyleBackColor = true;
            AddDrinksSubmitBtn.Click += AddDrinksSubmitBtn_Click;
            // 
            // AddDrinksAddedLbl
            // 
            AddDrinksAddedLbl.AutoSize = true;
            AddDrinksAddedLbl.Location = new System.Drawing.Point(132, 367);
            AddDrinksAddedLbl.Name = "AddDrinksAddedLbl";
            AddDrinksAddedLbl.Size = new System.Drawing.Size(95, 20);
            AddDrinksAddedLbl.TabIndex = 11;
            AddDrinksAddedLbl.Text = "Drink added!";
            // 
            // AddDrink
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(355, 450);
            Controls.Add(AddDrinksAddedLbl);
            Controls.Add(AddDrinksSubmitBtn);
            Controls.Add(AddDrinksLbl);
            Controls.Add(DrinkAddAlcoholicNoBtn);
            Controls.Add(DrinkAddAlcoholicYesBtn);
            Controls.Add(DrinkAddStockLbl);
            Controls.Add(DrinkAddStockTxt);
            Controls.Add(DrinkAddPriceTxt);
            Controls.Add(DrinkAddNameTxt);
            Controls.Add(DrinkAddAlcoholiclbl);
            Controls.Add(DrinkAddPricelbl);
            Controls.Add(DrinkAddNamelbl);
            Name = "AddDrink";
            Text = "AddDrink";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label DrinkAddNamelbl;
        private System.Windows.Forms.Label DrinkAddPricelbl;
        private System.Windows.Forms.Label DrinkAddAlcoholiclbl;
        private System.Windows.Forms.TextBox DrinkAddNameTxt;
        private System.Windows.Forms.TextBox DrinkAddPriceTxt;
        private System.Windows.Forms.TextBox DrinkAddStockTxt;
        private System.Windows.Forms.Label DrinkAddStockLbl;
        private System.Windows.Forms.RadioButton DrinkAddAlcoholicYesBtn;
        private System.Windows.Forms.RadioButton DrinkAddAlcoholicNoBtn;
        private System.Windows.Forms.Label AddDrinksLbl;
        private System.Windows.Forms.Button AddDrinksSubmitBtn;
        private System.Windows.Forms.Label AddDrinksAddedLbl;
    }
}
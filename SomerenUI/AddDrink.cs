using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SomerenService;
using SomerenModel;
using System.CodeDom;

namespace SomerenUI
{
    public partial class AddDrink : Form
    {
        public AddDrink()
        {
            InitializeComponent();
            AddDrinksAddedLbl.Visible = false;
        }


        private void AddDrinksSubmitBtn_Click(object sender, EventArgs e)
        {
            AddingDrink();
        }

        private void AddingDrink()
        {
            DrinksService drinksService = new DrinksService();
            try
            {
                string name = DrinkAddNameTxt.Text.ToString(); decimal price = decimal.Parse(DrinkAddPriceTxt.Text); Int16 isAlcoholic; int stock = int.Parse(DrinkAddStockTxt.Text);
                if (DrinkAddAlcoholicYesBtn.Checked) { isAlcoholic = 1; } else if (DrinkAddAlcoholicNoBtn.Checked) { isAlcoholic = 0; } else { throw new Exception("Please select if the drink contains alcohol."); }
                CheckNotEmpty(name, price, stock);
                Drinks drink = new Drinks(name, price, isAlcoholic, stock);
                drinksService.AddDrinks(drink);
                AddDrinksAddedLbl.Visible = true;
            }
            catch (Exception ex) { MessageBox.Show($"Error: {ex.Message}"); }
        }

        private void CheckNotEmpty(string name, decimal price, int stock)
        {
            bool nullCheck;
            if (string.IsNullOrEmpty(name)) { throw new Exception("Please enter a name for the drink");}
            if (price < 0) {throw new Exception("Please enter a valid price for the drink e.g 2.00");}
            if (stock < 0) { throw new Exception("Please enter a valid stock amount for the drink e.g 20");}
        }
    }
}

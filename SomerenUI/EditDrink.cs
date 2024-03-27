using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SomerenModel;
using SomerenService;
using static System.Windows.Forms.LinkLabel;

namespace SomerenUI
{
    public partial class EditDrink : Form
    {
        DrinksService drinksService;
        Drinks drink;

        public EditDrink(Drinks drinkEdit)
        {
            drinksService = new DrinksService();
            drink = drinkEdit;
            InitializeComponent();
            EditDrinksEditedLbl.Visible = false;
            EditDrinkNametxt.Text = drink.name.ToString();
            EditDrinkPricetxt.Text = drink.price.ToString();
            EditDrinkStockTxt.Text = drink.stock.ToString();
            if (drink.type == 0) { DrinkEditAlcoholicYesBtn.Checked = false; DrinkEditAlcoholicNoBtn.Checked = true; }
            else { DrinkEditAlcoholicYesBtn.Checked = true; DrinkEditAlcoholicNoBtn.Checked = false; }
        }

        



        private void EditingDrink()
        {
            try
            {
                int drinkId = drink.Id; string name = EditDrinkNametxt.Text.ToString(); decimal price = decimal.Parse(EditDrinkPricetxt.Text); Int16 isAlcoholic; int stock = int.Parse(EditDrinkStockTxt.Text);
                if (DrinkEditAlcoholicYesBtn.Checked) { isAlcoholic = 1; } else if (DrinkEditAlcoholicNoBtn.Checked) { isAlcoholic = 0; } else { throw new Exception("Please select if the drink contains alcohol."); }
                CheckNotEmpty(name, price, stock);
                Drinks EditedDrink = new Drinks(drinkId, name, price, isAlcoholic, stock);
                drinksService.EditDrinks(EditedDrink);
                EditDrinksEditedLbl.Visible = true;
            }
            catch (Exception ex) { MessageBox.Show($"Error: {ex.Message}"); }
        }

        private void CheckNotEmpty(string name, decimal price, int stock)
        {
            
            if (string.IsNullOrEmpty(name)) { throw new Exception("Please enter a name for the drink"); }
            if (price < 0) { throw new Exception("Please enter a valid price for the drink e.g 2.00"); }
            if (stock < 0) { throw new Exception("Please enter a valid stock amount for the drink e.g 20"); }
        }

        private void EditDrinkEditBtn_Click(object sender, EventArgs e)
        {
            EditingDrink();
        }
    }
}

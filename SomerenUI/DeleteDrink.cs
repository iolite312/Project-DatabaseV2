using SomerenModel;
using SomerenService;
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

namespace SomerenUI
{
    public partial class DeleteDrink : Form
    {
        DrinksService drinksService;
        Drinks drink;
        public DeleteDrink(Drinks drinkDelete)
        {
            drinksService = new DrinksService();
            this.drink = drinkDelete;
            InitializeComponent();
            DeleteDrinksEditedLbl.Visible = false;
            DeleteDrinkNametxt.Text = drink.name.ToString();
        }

       

        private void DeleteDrinkEditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                drinksService.RemoveDrinks(drink);
            }
            catch (Exception ex) { MessageBox.Show($"Error: {ex.Message}"); }
            DeleteDrinksEditedLbl.Visible = true;
        }

        
    }
}

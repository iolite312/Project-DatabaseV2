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
        List<Drinks> drinks;
        Drinks drink;
        public DeleteDrink()
        {
            InitializeComponent();
            DeleteDrinksEditedLbl.Visible = false;
            drinksService = new DrinksService();
            drinks = drinksService.GetDrinks();
            foreach (Drinks drink in drinks)
            {
                DeleteDrinkSelectCB.Items.Add(drink.Id);
            }
        }

        private void DeleteDrinkSelectCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            string drinkIdString = DeleteDrinkSelectCB.SelectedItem.ToString();
            int drinkId = int.Parse(drinkIdString);
            drink = drinksService.GetDrinkById(drinkId);
            DeleteDrinkNametxt.Text = drink.name.ToString();
        }

        private void DeleteDrinkEditBtn_Click(object sender, EventArgs e)
        {
            DeletingDrink();

        }

        private void DeletingDrink()
        {
            try
            {
                string drinkIdString = DeleteDrinkSelectCB.SelectedItem.ToString(); int drinkId = int.Parse(drinkIdString); string name = DeleteDrinkNametxt.Text.ToString();
                drinksService.RemoveDrinks(drink);
                DeleteDrinksEditedLbl.Visible = true;
            }
            catch (Exception ex) { MessageBox.Show($"Error: {ex.Message}"); }
        }
    }
}

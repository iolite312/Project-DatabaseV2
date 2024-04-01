using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenService
{
    public class DrinksService
    {
        private DrinksDao drinksDao;

        public DrinksService()
        {
            drinksDao = new DrinksDao();
        }

        public List<Drinks> GetDrinks()
        {
            List<Drinks> drinks = drinksDao.GetAllDrinks();
            return drinks;
        }
        public List<Drinks> GetDrinksNotOrdered()
        {
            List<Drinks> drinks = drinksDao.GetAllDrinksNotOrdered();
            return drinks;
        }

        public void AddDrinks(Drinks drink)
        {
            drinksDao.AddDrink(drink);
        }

        public void EditDrinks(Drinks drink)
        {
            drinksDao.EditDrink(drink); 
        }

        public void RemoveDrinks(Drinks drink)
        {
            drinksDao.DeleteDrink(drink);
        }

        public Drinks GetDrinkById(int id)
        {
            Drinks drink = drinksDao.GetById(id);
            return drink;
        }
    }
}

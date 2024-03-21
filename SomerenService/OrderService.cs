using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenService
{
    public class OrderService
    {
        private OrderDao orderDao;
        public OrderService() 
        { 
            orderDao = new OrderDao();
        }
        public void InsertOrder(Order order, Drinks drink)
        {
            orderDao.InsertOrder(order);
            DrinksService drinksService = new DrinksService();
            Drinks newDrink = drink;
            int newStock = newDrink.stock - order.Count;
            newDrink.stock = newStock;
            drinksService.EditDrinks(newDrink);

        }
    }
}

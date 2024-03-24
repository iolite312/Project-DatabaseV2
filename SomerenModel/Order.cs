using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class Order
    {
        public int DrinkId { get; set; }
        public int StudentId { get; set; }
        public DateTime Date { get; set; }
        public int Count { get; set; }

        public Order(int drinkId, int studentId, DateTime date, int count)
        {
            DrinkId = drinkId;
            StudentId = studentId;
            Date = date;
            Count = count;
        }
    }
}

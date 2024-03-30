using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class Order
    {
        public Drinks Drink { get; set; }
        public Student Student { get; set; }
        public DateTime Date { get; set; }
        public int Count { get; set; }

        public Order(Drinks drink, Student student, DateTime date, int count)
        {
            Drink = drink;
            Student = student;
            Date = date;
            Count = count;
        }
    }
}

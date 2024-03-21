using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class Drinks
    {

        public Drinks(int id, string name, decimal price, Int16 type, int stock)
        {
            this.Id = id;
            this.name = name;
            this.price = price;
            this.type = type;
            this.stock = stock;
        }

        public Drinks(string name, decimal price, Int16 type, int stock)
        {
            this.name = name;
            this.price = price;
            this.type = type;
            this.stock = stock;
        }
        public int Id { get; set; }     // database id
        public string name { get; set; }
        
        public decimal price { get; set; } 

        public Int16 type {  get; set; }
        public string Type {
            get
            {
                if (type == 1)
                {
                    return "Alcoholic";
                }
                return "Non alcoholic";
            } }
        public int stock { get; set; }

        public string stockStatus
        {get{switch (stock){
                    case 0:
                        return "stock empty";
                    case <= 10:
                        return "Stock nearly depleted";
                    default:
                        return "stock sufficient";
                }}
        }
    }
}

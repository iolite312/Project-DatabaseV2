using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    using System;

    public class DrankVAT
    {
        public DateTime datum { get; set; }
        public int aantal_gehaald { get; set; }
        public int drankId { get; set; }
        public string SoortDrank { get; set; }
        public bool IsAlcoholic { get; set; }
        public decimal Prijs { get; set; }
        public int Stock { get; set; }

        public static class ValidationYear
        {
            public static bool IsValidYear(int year)
            {
                int currentYear = DateTime.Now.Year;
                return year == currentYear;
            }
        }
    }
}
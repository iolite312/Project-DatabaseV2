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
        public int id { get; set; }
        public string SoortDrank { get; set; }
        public bool IsAlcoholic { get; set; }
        public decimal Prijs { get; set; }
        public int Stock { get; set; }


        public decimal CalculateVAT()
        {
            // Determine VAT rates based on whether the drink is alcoholic or not
            decimal VATRateLow = 0.06m; // 6%
            decimal VATRateHigh = 0.21m; // 21%

            // Initialize VAT amounts for low and high rates
            decimal totalVATLow = 0;
            decimal totalVATHigh = 0;

            // Calculate VAT amount for the whole stock
            if (IsAlcoholic)
            {
                totalVATHigh = Prijs * Stock * VATRateHigh;
            }
            else if (!IsAlcoholic) 
            {
                totalVATLow = Prijs * Stock * VATRateLow;
            }

            // Calculate total VAT amount
            decimal totalVAT = totalVATLow + totalVATHigh;

            return totalVAT;
        }


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
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


        public decimal CalculateVAT(List<DrankVAT> orderedData)
        {
            // Determine VAT rates based on whether the drink is alcoholic or not
            decimal VATRateLow = 0.06m; // 6%
            decimal VATRateHigh = 0.21m; // 21%

            // Initialize VAT amounts for low and high rates
            decimal totalVATLow = 0;
            decimal totalVATHigh = 0;

            // Check if the drink is ordered by checking if its drankId is present in the list of ordered drinks
            if (drankId != null)
            {
                // The drink is ordered
                if (IsAlcoholic)
                {
                    totalVATHigh += Prijs * aantal_gehaald * VATRateHigh;
                }
                else
                {
                    totalVATLow += Prijs * aantal_gehaald * VATRateLow;
                }
            }
            else
            {
                // Add logic here if the drink is not ordered (e.g., calculate VAT based on default criteria)
                // totalVATLow = ...; // Set to a default value for VAT
                // totalVATHigh = ...; // Set to a default value for VAT
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
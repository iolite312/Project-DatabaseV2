using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenService
{
    public class DrankVATService
    {
        private DrankVATDao drankDAO;

        public DrankVATService()
        {
            drankDAO = new DrankVATDao();
        }

        // Method to calculate VAT for the drinks in a given quarter
        public void CalculateVATForQuarter(int year, string quarter, out decimal totalVATLow, out decimal totalVATHigh, out decimal totalVAT)
        {
            // Retrieve drinks sold in the specified quarter
            List<DrankVAT> dranken = drankDAO.GetDrankenForQuarter(year, quarter);

            totalVAT = 0;
            totalVATLow = 0;
            totalVATHigh = 0;
            // Calculate total VAT for all drinks in the quarter
            foreach (DrankVAT drank in dranken)
            {
                decimal tempVATHigh, tempVAT, tempVATLow;
                // Calculate VAT for each drink in the quarter based on ordered data
                CalculateVAT(drank, out tempVATLow, out tempVATHigh, out tempVAT);
                totalVAT += tempVAT;
                totalVATLow += tempVATLow;
                totalVATHigh += tempVATHigh;
            }

        }
        private void CalculateVAT(DrankVAT drank, out decimal totalVATLow, out decimal totalVATHigh, out decimal totalVAT)
        {
            // Determine VAT rates based on whether the drink is alcoholic or not
            decimal VATRateLow = 0.06m; // 6%
            decimal VATRateHigh = 0.21m; // 21%

            // Initialize VAT amounts for low and high rates
            totalVATLow = 0;
            totalVATHigh = 0;

            // Check if the drink is ordered by checking if its drankId is present in the list of ordered drinks
            if (drank.drankId != null)
            {
                // The drink is ordered
                if (drank.IsAlcoholic)
                {
                    totalVATHigh += drank.Prijs * drank.aantal_gehaald * VATRateHigh;
                }
                else
                {
                    totalVATLow += drank.Prijs * drank.aantal_gehaald * VATRateLow;
                }
            }

            // Calculate total VAT amount
            totalVAT = totalVATLow + totalVATHigh;
        }
        public void CalculateQuarterDates(int year, string quarter, out DateTime startQuarter, out DateTime endQuarter)
        {

            switch (quarter)
            {
                case "1":
                    startQuarter = new DateTime(year, 1, 1);
                    endQuarter = new DateTime(year, 3, 31);
                    break;
                case "2":
                    startQuarter = new DateTime(year, 4, 1);
                    endQuarter = new DateTime(year, 6, 30);
                    break;
                case "3":
                    startQuarter = new DateTime(year, 7, 1);
                    endQuarter = new DateTime(year, 9, 30);
                    break;
                case "4":
                    startQuarter = new DateTime(year, 10, 1);
                    endQuarter = new DateTime(year, 12, 31);
                    break;
                default:
                    throw new ArgumentException("Invalid quarter: " + quarter);
            }
        }
    }
}

using SomerenModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenDAL
{
    public class DrankDao : BaseDao
    {

        public List<Drank> GetAllDranken()
        {
            string query = "SELECT drankId, soortDrank, isAlcoholic, prijs, stock FROM [Drank]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadDranken(ExecuteSelectQuery(query, sqlParameters));
        }

        // Method to retrieve drinks sold in a specified quarter
        public List<Drank> GetDrankenForQuarter(int year, string quarter)
        {
            // Determine the start and end dates of the quarter
            DateTime startQuarter, endQuarter;
            CalculateQuarterDates(year, quarter, out startQuarter, out endQuarter);

            // Query to retrieve drinks sold within the specified quarter
            string query = "SELECT drankId, soortDrank, isAlcoholic, prijs, stock FROM [Drank] ";

            // Set parameters for the query
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
            new SqlParameter("@startQuarter", startQuarter),
            new SqlParameter("@endQuarter", endQuarter)
            };

            // Execute the query and return the result
            return ReadDranken(ExecuteSelectQuery(query, sqlParameters));
        }






        private void CalculateQuarterDates(int year, string quarter, out DateTime startQuarter, out DateTime endQuarter)
        {
            // Calculate the start and end dates of the quarter based on the year and quarter
            int quarterNumber = ConvertQuarterToInt(quarter);

            switch (quarterNumber)
            {
                case 1:
                    startQuarter = new DateTime(year, 1, 1);
                    endQuarter = new DateTime(year, 3, 31);
                    break;
                case 2:
                    startQuarter = new DateTime(year, 4, 1);
                    endQuarter = new DateTime(year, 6, 30);
                    break;
                case 3:
                    startQuarter = new DateTime(year, 7, 1);
                    endQuarter = new DateTime(year, 9, 30);
                    break;
                case 4:
                    startQuarter = new DateTime(year, 10, 1);
                    endQuarter = new DateTime(year, 12, 31);
                    break;
                default:
                    throw new ArgumentException("Invalid quarter: " + quarter);
            }
        }



        private int ConvertQuarterToInt(string quarter)
        {
            switch (quarter.ToUpper())
            {
                case "1":
                    return 1;
                case "2":
                    return 2;
                case "3":
                    return 3;
                case "4":
                    return 4;
                default:
                    throw new ArgumentException("Invalid quarter: " + quarter);
            }
        }

        private List<Drank> ReadDranken(DataTable dataTable)
        {
            List<Drank> dranken = new List<Drank>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Drank drank = new Drank()
                {
                    SoortDrank = dr["soortDrank"].ToString(),
                    Prijs = (decimal)dr["prijs"],
                    Stock = (int)dr["stock"],
                    IsAlcoholic = ((Int16)dr["isAlcoholic"] != 0) // Convert Int16 to bool
                };

                // Calculate VAT for the drink based on its price, stock, and alcohol content
                drank.CalculateVAT();

                dranken.Add(drank);
            }
            return dranken;
        }

    }
}

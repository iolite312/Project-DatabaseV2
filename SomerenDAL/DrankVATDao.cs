using SomerenModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.AccessControl;

namespace SomerenDAL
{
    public class DrankVATDao : BaseDao
    {
        // Method to retrieve drinks sold in a specified quarter
        public List<DrankVAT> GetDrankenForQuarter(int year, string quarter)
        {
            DateTime startQuarter, endQuarter;
            CalculateQuarterDates(year, quarter, out startQuarter, out endQuarter);

            // Query to retrieve drinks sold within the specified quarter from the 'Besteld' table
            string besteldQuery = "SELECT d.[drankId], d.[soortDrank], d.[isAlcoholic], d.[prijs], b.[datum], b.[aantal_gehaald] " +
                "FROM [dbo].[Drank] as d join [Besteld] AS b ON d.drankId = b.drankId " +
                "WHERE CONVERT (date, b.datum) BETWEEN " +
                "@startQuarter AND @endQuarter";

            // Set parameters for the query
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
            new SqlParameter("@startQuarter", startQuarter),
            new SqlParameter("@endQuarter", endQuarter)
            };

            // Execute the query and return the result
            return ReadFromBesteld(ExecuteSelectQuery(besteldQuery, sqlParameters));
        }

        private List<DrankVAT> ReadFromBesteld(DataTable dataTable)
        {
            List<DrankVAT> items = new List<DrankVAT>();

            foreach (DataRow dr in dataTable.Rows)
            {
                DrankVAT newItem = new DrankVAT()
                {
                    IsAlcoholic = ((Int16)dr["isAlcoholic"] != 0), // Convert Int16 to bool
                    Prijs = (decimal)dr["prijs"],
                    drankId = (int)dr["drankId"],
                    datum = (DateTime)dr["datum"],
                    aantal_gehaald = (int)dr["aantal_gehaald"]
                };

                items.Add(newItem);
            }

            return items;
        }
        private void CalculateQuarterDates(int year, string quarter, out DateTime startQuarter, out DateTime endQuarter)
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
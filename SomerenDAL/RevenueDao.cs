using SomerenModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenDAL
{
    public class RevenueDao : BaseDao
    {
        public List<Revenue> GetDateRangeSales(DateTime startDate, DateTime endDate)
        {
            string query =  "SELECT " +
                            "COUNT(DISTINCT Student.studentNummer) AS numberOfCustomers, " +
                            "SUM(ISNULL(aantal_gehaald * prijs, 0)) AS turnOver, " +
                            "SUM(ISNULL(aantal_gehaald, 0)) AS sales " +
                            "FROM dbo.besteld " +
                            "JOIN Student ON besteld.studentNummer = Student.studentNummer " +
                            "JOIN Drank ON besteld.drankID = Drank.drankId " +
                            "WHERE CONVERT(date, besteld.datum) between @startDate AND @endDate";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@startDate", startDate),
                new SqlParameter("@endDate", endDate)
            };

            DataTable dataTable = ExecuteSelectQuery(query, sqlParameters);
            return ReadTables(dataTable);
        }

        private List<Revenue> ReadTables(DataTable dataTable)
        {
            List<Revenue> revenues = new List<Revenue>();
            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                foreach (DataRow dr in dataTable.Rows)
                {

                    Revenue revenue = new()
                    {
                        numberOfCustomer = (int)dr["numberOfCustomers"],
                        sales = (int)dr["sales"],
                        turnOver = (decimal)dr["turnOver"]
                    };
                    revenues.Add(revenue);
                }
            }
           
            return revenues;
        }
    }
}

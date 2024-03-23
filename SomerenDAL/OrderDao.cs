using SomerenModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenDAL
{
    public class OrderDao : BaseDao
    {
        public void InsertOrder(Order order)
        {
            string query = "INSERT INTO [besteld] ([drankId],[studentNummer],[datum],[aantal_gehaald]) " +
                "VALUES(@drankId,@studentNumber,@date,@Count)";
            SqlParameter[] sqlParameters = new SqlParameter[4];
            sqlParameters[0] = new SqlParameter() { ParameterName = "@drankId", Value = order.DrinkId };
            sqlParameters[1] = new SqlParameter() { ParameterName = "@studentNumber", Value = order.StudentId };
            sqlParameters[2] = new SqlParameter() { ParameterName = "@date", Value = order.Date };
            sqlParameters[3] = new SqlParameter() { ParameterName = "@Count", Value = order.Count };
            ExecuteEditQuery(query, sqlParameters);
        }
    }
}

using SomerenModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using System.Collections;
using System.Diagnostics;
using System.Xml.Linq;

namespace SomerenDAL
{
    public class DrinksDao : BaseDao
    {
        public List<Drinks> GetAllDrinks()
        {
            string query = "SELECT drankid, SoortDrank, isAlcoholic , prijs, stock  FROM [Drank] ORDER BY stock ASC";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public Drinks GetById(int id)
        {
            string query = "SELECT drankid, SoortDrank, isAlcoholic , prijs, stock  FROM [Drank] WHERE drankid = @Id";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@Id", id);
            return ReadSingleRow(ExecuteSelectQuery(query, sqlParameters));

        }

        private Drinks ReadSingleRow(DataTable dataTable)
        {
            if (dataTable.Rows.Count > 0)
            {
                DataRow dr = dataTable.Rows[0];
                int Id = (int)dr["drankId"];
                string name = dr["SoortDrank"].ToString();
                Int16 type = (Int16)dr["isAlcoholic"];
                int stock = (int)dr["stock"];
                decimal price = (decimal)dr["prijs"];
                Drinks drink = new Drinks(Id, name, price, type, stock);
                return drink;
            }
            else { throw new Exception("The DataTable is empty"); }
        }
        
       

      

        private List<Drinks> ReadTables(DataTable dataTable)
        {
            List<Drinks> drinks = new List<Drinks>();
            foreach (DataRow dr in dataTable.Rows)
            {
                int Id = (int)dr["drankId"];
                string name = dr["SoortDrank"].ToString();
                Int16 type = (Int16)dr["isAlcoholic"];
                int stock = (int)dr["stock"];
                decimal price = (decimal)dr["prijs"];
                Drinks drink = new Drinks(Id, name, price, type, stock);
                drinks.Add(drink);
            }
            return drinks;
        }


        public Drinks AddDrink(Drinks drink)
        {
            string query = "INSERT INTO [Drank] ([soortDrank], [isAlcoholic], [prijs], [stock]) VALUES (@soortDrank, @isAlcoholic, @prijs, @stock);" +
                "SELECT CAST(scope_identity() AS int)";
            SqlParameter[] sqlParameters = new SqlParameter[4];
            sqlParameters[0] = new SqlParameter("@soortDrank", drink.name);
            sqlParameters[1] = new SqlParameter("@isAlcoholic", drink.type);
            sqlParameters[2] = new SqlParameter("@prijs", drink.price);
            sqlParameters[3] = new SqlParameter("@stock", drink.stock);
            ExecuteAddQuery(query, sqlParameters, out int drinkId);
            return new Drinks(drinkId, drink.name, drink.price, drink.type,drink.stock);
        }

        public void EditDrink(Drinks drink)
        {
            string query = "UPDATE [Drank] SET [soortDrank] = @soortDrank, [isAlcoholic] = @isAlcoholic, [prijs] =  @prijs, [stock] = @stock WHERE drankid = @Id";
            SqlParameter[] sqlParameters = new SqlParameter[5];
            sqlParameters[0] = new SqlParameter("@Id", drink.Id);
            sqlParameters[1] = new SqlParameter("@soortDrank", drink.name);
            sqlParameters[2] = new SqlParameter("@isAlcoholic", drink.type);
            sqlParameters[3] = new SqlParameter("@prijs", drink.price);
            sqlParameters[4] = new SqlParameter("@stock", drink.stock);
            ExecuteEditQuery(query, sqlParameters);
        }


        public void DeleteDrink(Drinks drink)
        {
            string query = "DELETE FROM Drank WHERE drankid = @Id";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@id", drink.Id);
            ExecuteEditQuery(query, sqlParameters);
        }

    }
}

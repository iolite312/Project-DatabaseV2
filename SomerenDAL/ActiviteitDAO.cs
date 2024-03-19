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
    public class ActiviteitDAO :BaseDao
    {
        public List<Activiteiten> GetAllActivities()
        {
            string query = "SELECT id, Soort_Activiteit, Dag, Begin_Tijd, Eind_Tijd FROM [Activiteiten]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadActivities(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Activiteiten> ReadActivities(DataTable dataTable)
        {
            List<Activiteiten> activities = new List<Activiteiten>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Activiteiten activity = new Activiteiten()
                {
                    id = (int)dr["id"],
                    Soort_Activiteit = dr["Soort_Activiteit"].ToString(),
                    Begin_Tijd = (TimeSpan)dr["Begin_Tijd"],
                    Eind_Tijd = (TimeSpan)dr["Eind_Tijd"],
                    Datum = Convert.ToDateTime(dr["Dag"]),
                };
                activities.Add(activity);
            }
            return activities;
        }
    }
}

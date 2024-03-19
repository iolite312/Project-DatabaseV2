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
    public class LecturerDao : BaseDao
    {
        public List<Teacher> GetAllTeachers()
        {
            string query = "SELECT id, DocentNummer, Voornaam , Achternaam, TelefoonNummer , DateOfBirth FROM [Docent]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Teacher> ReadTables(DataTable dataTable)
        {
            List<Teacher> teachers = new List<Teacher>();
            foreach (DataRow dr in dataTable.Rows)
            {
                Teacher teacher = new Teacher()
                {
                    Id = (int)dr["Id"],
                    Number = (int)dr["DocentNummer"],
                    FirstName = dr["Voornaam"].ToString(),
                    SurName = dr["Achternaam"].ToString(),
                    TelephoneNumber = (int)dr["TelefoonNummer"],
                    BirthDate = (DateTime)dr["DateOfBirth"]
                };
                teachers.Add(teacher);
            }
            return teachers;
        }
    }
}

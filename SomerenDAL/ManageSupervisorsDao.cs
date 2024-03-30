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
    public class ManageSupervisorsDao : BaseDao
    {
        public List<Teacher> GetAllNonSupervisingTeachers(string activityName)
        {
            string query = "SELECT D.id, D.DocentNummer, D.Voornaam, D.Achternaam, D.TelefoonNummer, D.DateOfBirth, D.KamerNummer FROM Docent AS D " +
                "WHERE NOT EXISTS ( SELECT 1 FROM Begeleid AS B WHERE D.DocentNummer = B.DocentNummer AND B.Soort_Activiteit = @ActivityName)" +
                "ORDER BY D.Achternaam ASC";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter() { ParameterName = "@ActivityName", Value = activityName };
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        public List<Teacher> GetAllSupervisingTeachers(string activityName)
        {
            string query = "SELECT D.id, D.DocentNummer, D.Voornaam, D.Achternaam, D.TelefoonNummer, D.DateOfBirth, D.KamerNummer FROM Docent AS D " +
                "WHERE EXISTS ( SELECT 1 FROM Begeleid AS B WHERE D.DocentNummer = B.DocentNummer AND B.Soort_Activiteit = @ActivityName)" +
                "ORDER BY D.Achternaam ASC";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter() { ParameterName = "@ActivityName", Value = activityName };
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Teacher> ReadTables(DataTable dataTable)
        {
            List<Teacher> teachers = new List<Teacher>();
            foreach (DataRow dr in dataTable.Rows)
            {
                int Id = (int)dr["Id"];
                int Number = (int)dr["DocentNummer"];
                string FirstName = dr["Voornaam"].ToString();
                string SurName = dr["Achternaam"].ToString();
                int TelephoneNumber = (int)dr["TelefoonNummer"];
                DateTime BirthDate = (DateTime)dr["DateOfBirth"];
                string Room = dr["KamerNummer"].ToString();
                Teacher teacher = new Teacher(Id, FirstName, SurName, Number, TelephoneNumber, Room, BirthDate);
                teachers.Add(teacher);
            }
            return teachers;
        }
        public void AddSupervisorsToActivity(List<Teacher> teachers, Activiteiten activiteit)
        {
            foreach (Teacher teacher in teachers)
            {
                string query = "INSERT INTO Begeleid (Soort_activiteit, DocentNummer) VALUES" +
                    "(@ActivityName, @DocentNummer)";
                SqlParameter[] sqlParameters = new SqlParameter[2];
                sqlParameters[0] = new SqlParameter() { ParameterName = "@ActivityName", Value = activiteit.Soort_Activiteit };
                sqlParameters[1] = new SqlParameter() { ParameterName = "@DocentNummer", Value = teacher.Number };
                ExecuteEditQuery(query, sqlParameters);
            }
        }
        public void RemoveSupervisorsFromActivity(List<Teacher> teachers, Activiteiten activiteit)
        {
            foreach (Teacher teacher in teachers)
            {
                string query = "DELETE FROM Begeleid WHERE Soort_activiteit = @ActivityName AND DocentNummer = @DocentNummer";
                SqlParameter[] sqlParameters = new SqlParameter[2];
                sqlParameters[0] = new SqlParameter() { ParameterName = "@ActivityName", Value = activiteit.Soort_Activiteit };
                sqlParameters[1] = new SqlParameter() { ParameterName = "@DocentNummer", Value = teacher.Number };
                ExecuteEditQuery(query, sqlParameters);
            }
        }
    }
}

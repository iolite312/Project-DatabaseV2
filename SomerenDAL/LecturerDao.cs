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
            string query = "SELECT id, DocentNummer, Voornaam , Achternaam, TelefoonNummer , DateOfBirth, KamerNummer FROM [Docent] ORDER BY [Achternaam] ASC";
            return ReadTables(ExecuteSelectQuery(query));
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

        public Teacher AddLecturer(Teacher teacher)
        {
            string query = "INSERT INTO [Docent] ([DocentNummer],[Voornaam],[Achternaam],[DateOfBirth],[TelefoonNummer],[KamerNummer]) VALUES (@docentNummer, @voornaam, @achternaam, @dateOfBirth, @telefoonNummer, @kamerNummer);" +
                "SELECT CAST(scope_identity() AS int)";
            SqlParameter[] sqlParameters = new SqlParameter[6];
            sqlParameters[0] = new SqlParameter("@docentNummer", teacher.Number);
            sqlParameters[1] = new SqlParameter("@voornaam", teacher.FirstName);
            sqlParameters[2] = new SqlParameter("@achternaam", teacher.SurName);
            sqlParameters[3] = new SqlParameter("@dateOfBirth", teacher.BirthDate);
            sqlParameters[4] = new SqlParameter("@telefoonNummer", teacher.TelephoneNumber);
            sqlParameters[5] = new SqlParameter("@kamerNummer", teacher.Room);
            ExecuteAddQuery(query, sqlParameters, out int teacherId);
            return new Teacher(teacherId, teacher.FirstName, teacher.SurName, teacher.Number, teacher.TelephoneNumber, teacher.Room, teacher.BirthDate);
        }

        public void EditLecturer(Teacher teacher)
        {
            string query = "UPDATE [Docent] SET [DocentNummer] = @docentNummer, [Voornaam] = @voornaam, [Achternaam] = @achternaam, [DateOfBirth] = @dateOfBirth, [TelefoonNummer] = @telefoonNummer, [KamerNummer] = @kamerNummer WHERE id = @Id";
            SqlParameter[] sqlParameters = new SqlParameter[7];
            sqlParameters[0] = new SqlParameter("@docentNummer", teacher.Number);
            sqlParameters[1] = new SqlParameter("@voornaam", teacher.FirstName);
            sqlParameters[2] = new SqlParameter("@achternaam", teacher.SurName);
            sqlParameters[3] = new SqlParameter("@dateOfBirth", teacher.BirthDate);
            sqlParameters[4] = new SqlParameter("@telefoonNummer", teacher.TelephoneNumber);
            sqlParameters[5] = new SqlParameter("@kamerNummer", teacher.Room);
            sqlParameters[6] = new SqlParameter("@Id", teacher.Id);
            ExecuteEditQuery(query, sqlParameters);
        }


        public void DeleteLecturer(Teacher teacher)
        {
            string query = "DELETE FROM Docent WHERE id = @Id";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@id", teacher.Id);
            ExecuteEditQuery(query, sqlParameters);
        }
        public Teacher GetById(int id)
        {
            string query = "SELECT id, DocentNummer, Voornaam , Achternaam, TelefoonNummer , DateOfBirth, KamerNummer FROM [Docent] WHERE id = @Id";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@Id", id);
            return ReadSingleRow(ExecuteSelectQuery(query, sqlParameters));

        }

        private Teacher ReadSingleRow(DataTable dataTable)
        {
            if (dataTable.Rows.Count > 0)
            {
                DataRow dr = dataTable.Rows[0];
                int Id = (int)dr["Id"];
                int Number = (int)dr["DocentNummer"];
                string FirstName = dr["Voornaam"].ToString();
                string SurName = dr["Achternaam"].ToString();
                int TelephoneNumber = (int)dr["TelefoonNummer"];
                DateTime BirthDate = (DateTime)dr["DateOfBirth"];
                string Room = dr["KamerNummer"].ToString();
                Teacher teacher = new Teacher(Id, FirstName, SurName, Number, TelephoneNumber, Room, BirthDate);
                return teacher;
            }
            else { throw new Exception("The DataTable is empty"); }
        }
    }
}

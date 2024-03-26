using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using SomerenModel;
using System.Security.Claims;

namespace SomerenDAL
{
    public class StudentDao : BaseDao
    {
        public List<Student> GetAllStudents()
        {
            string query = "SELECT StudentNummer, Voornaam, Achternaam, TelefoonNummer, KamerNummer, Klas FROM [Student] ORDER BY Achternaam";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Student> ReadTables(DataTable dataTable)
        {
            List<Student> students = new List<Student>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Student student = new Student()
                {

                    FirstName = dr["Voornaam"].ToString(),
                    LastName = dr["Achternaam"].ToString(),
                    Number = (int)dr["StudentNummer"],
                    PhoneNumber = (int)dr["TelefoonNummer"],
                    Class = dr["Klas"].ToString(),
                    RoomNumber = dr["KamerNummer"].ToString()

                };
                students.Add(student);
            }
            return students;
        }

        // Add a new student to the database
        public void AddStudent(Student student)
        {
            string query = "INSERT INTO [Student] (StudentNummer, Voornaam, Achternaam, TelefoonNummer, KamerNummer, Klas) " +
                           "VALUES (@StudentNummer, @Voornaam, @Achternaam, @TelefoonNummer, @KamerNummer, @Klas)";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@StudentNummer", student.Number),
                new SqlParameter("@Voornaam", student.FirstName),
                new SqlParameter("@Achternaam", student.LastName),
                new SqlParameter("@TelefoonNummer", student.PhoneNumber),
                new SqlParameter("@KamerNummer", student.RoomNumber),
                new SqlParameter("@Klas", student.Class)
            };
            ExecuteEditQuery(query, sqlParameters);
        }

        // Update an existing student in the database
        public void EditStudent(Student student)
        {
            string query = "UPDATE [Student] SET StudentNummer = @StudentNummer, Voornaam = @Voornaam, " +
                           "Achternaam = @Achternaam, TelefoonNummer = @TelefoonNummer, " +
                           "KamerNummer = @KamerNummer, Klas = @Klas WHERE Id = @Id";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@StudentNummer", student.Number),
                new SqlParameter("@Voornaam", student.FirstName),
                new SqlParameter("@Achternaam", student.LastName),
                new SqlParameter("@TelefoonNummer", student.PhoneNumber),
                new SqlParameter("@KamerNummer", student.RoomNumber),
                new SqlParameter("@Klas", student.Class),
                new SqlParameter("@Id", student.Id)
            };
            ExecuteEditQuery(query, sqlParameters);
        }

        // Remove an existing student from the database
        public void DeleteStudent(int studentNumber, string lastName)
        {
            string query = "DELETE FROM [Student] WHERE StudentNummer = @StudentNumber AND Achternaam = @LastName";
            SqlParameter[] sqlParameters =
            {
                 new SqlParameter("@StudentNumber", studentNumber),
                 new SqlParameter("@LastName", lastName)            
            };
            ExecuteEditQuery(query, sqlParameters);
        }

        public bool StudentExists(int studentNumber, string lastName)
        {
            string query = "SELECT COUNT(*) FROM [Student] WHERE StudentNummer = @StudentNummer AND Achternaam = @Achternaam";
            SqlParameter[] sqlParameters =
            {
            new SqlParameter("@StudentNummer", studentNumber),
            new SqlParameter("@Achternaam", lastName)
        };

            int count = ExecuteScalar(query, sqlParameters);
            return count > 0;
        }


    }
}
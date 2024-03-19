﻿using System.Collections.Generic;
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
            string query = "SELECT Id,StudentNummer, Voornaam, Achternaam, TelefoonNummer, KamerNummer, Klas FROM [Student]";
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
                    Id = (int)dr["Id"],
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
    }
}
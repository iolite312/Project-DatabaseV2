using SomerenDAL;
using SomerenModel;
using System.Collections.Generic;

namespace SomerenService
{
    public class StudentService
    {
        private StudentDao studentdb;

        public StudentService()
        {
            studentdb = new StudentDao();
        }

        public List<Student> GetStudents()
        {
            List<Student> students = studentdb.GetAllStudents();
            return students;
        }
        // Add a new student to the database
        public void AddStudent(Student student)
        {
            studentdb.AddStudent(student);
        }

        // edit an existing student in the database
        public void EditStudent(Student student)
        {
            studentdb.EditStudent(student);
        }


        public void DeleteStudent(int studentNumber, string lastName)
        {
            studentdb.DeleteStudent(studentNumber, lastName);
        }
        public bool StudentExists(int studentNumber, string lastName)
        {
            return studentdb.StudentExists(studentNumber, lastName);
        }
    }
}
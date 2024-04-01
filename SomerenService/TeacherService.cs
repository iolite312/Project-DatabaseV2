using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenService
{
    public class TeacherService
    {
        private LecturerDao lecturerdb;

        public TeacherService()
        {
            lecturerdb = new LecturerDao();
        }

        public List<Teacher> GetTeachers()
        {
            List<Teacher> teachers = lecturerdb.GetAllTeachers();
            return teachers;
        }

        public void AddLecturer(Teacher teacher)
        {
            lecturerdb.AddLecturer(teacher);
        }

        public void EditLecturer(Teacher teacher)
        {
            lecturerdb.EditLecturer(teacher);
        }

        public void RemoveLecturer(Teacher teacher)
        {
            lecturerdb.DeleteLecturer(teacher);
        }

        public Teacher GetLecturerById(int id)
        {
            Teacher teacher = lecturerdb.GetById(id);
            return teacher;
        }
    }
}

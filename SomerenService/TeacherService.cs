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
    }
}

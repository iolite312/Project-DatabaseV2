using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenService
{
    public class ManageSupervisorsService
    {
        private ManageSupervisorsDao manageSupervisorsDao;

        public ManageSupervisorsService()
        {
            manageSupervisorsDao = new ManageSupervisorsDao();
        }
        public List<Teacher> GetAllNonSupervisingTeachers(string activityName)
        {
            return manageSupervisorsDao.GetAllNonSupervisingTeachers(activityName);
        }
        public List<Teacher> GetAllSupervisingTeachers(string activityName)
        {
            return manageSupervisorsDao.GetAllSupervisingTeachers(activityName);
        }
        public void AddSupervisorsToActivity(List<Teacher> teachers, Activiteiten activiteit)
        {
            manageSupervisorsDao.AddSupervisorsToActivity(teachers, activiteit);
        }
        public void RemoveSupervisorsToActivity(List<Teacher> teachers, Activiteiten activiteit)
        {
            manageSupervisorsDao.RemoveSupervisorsFromActivity(teachers, activiteit);
        }
    }
}

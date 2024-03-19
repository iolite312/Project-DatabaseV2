using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomerenDAL;
using SomerenModel;

namespace SomerenService
{
    public class ActiviteitenService
    {
        private ActiviteitDAO activiteitDAO;

        public ActiviteitenService()
        {
            activiteitDAO = new ActiviteitDAO();
        }

        public List<Activiteiten> GetActivities()
        {
            List<Activiteiten> activities = activiteitDAO.GetAllActivities();
            return activities;
        }
    }
}

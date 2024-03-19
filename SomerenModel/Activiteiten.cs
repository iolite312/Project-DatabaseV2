using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class Activiteiten
    {
        public int id { get; set; }
        public string Soort_Activiteit { get; set; }
        public TimeSpan Begin_Tijd { get; set; }
        public TimeSpan Eind_Tijd { get; set; }
        public DateTime Datum { get; set; }
    }
}

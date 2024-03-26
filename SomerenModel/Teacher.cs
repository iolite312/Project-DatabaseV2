using Microsoft.VisualBasic;
using System;

namespace SomerenModel
{
    public class Teacher
    {
        public Teacher(int id, string FirstName, string SurName, int Number, int TelephoneNumber, string Room, DateTime BirthDate) 
        {
            Id = id;
            this.FirstName = FirstName;
            this.SurName = SurName;
            this.Number = Number;
            this.TelephoneNumber = TelephoneNumber;
            this.Room = Room;
            this.BirthDate = BirthDate;
        }

        public Teacher(string FirstName, string SurName, int Number, int TelephoneNumber, string Room, DateTime BirthDate)
        {
            this.FirstName = FirstName;
            this.SurName = SurName;
            this.Number = Number;
            this.TelephoneNumber = TelephoneNumber;
            this.Room = Room;
            this.BirthDate = BirthDate;
        }

        public int Id { get; set; }     // database id
        public string FirstName { get; set; }
        public string SurName { get; set; }
        public int Number { get; set; } // LecturerNumber, e.g. 47198

        public int TelephoneNumber { get; set; }

        public string Room { get; set; }
        public DateTime BirthDate { get; set; }

        public string FullName
        {
            
            get { return $"{FirstName} {SurName}"; }
        }

        public int Age { get {return CalculateAge(BirthDate) ;} }

        static int CalculateAge(DateTime birthdate)
        {
            DateTime currentDate = DateTime.Now;
            int age = currentDate.Year - birthdate.Year;
            if (birthdate > currentDate.AddYears(-age))
            {
                age--;
            }
            return age;
        }
    }
}
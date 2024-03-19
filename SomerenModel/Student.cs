﻿using System;

namespace SomerenModel
{
    public class Student
    {
        public int Id { get; set; }     // database id
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Number { get; set; } // StudentNumber, e.g. 474791
        public int PhoneNumber { get; set; } 
            
        public string RoomNumber { get; set; }
        public string Class { get; set; }
        public string FullName { get { return $"{FirstName} {LastName}"; } }
    }
}
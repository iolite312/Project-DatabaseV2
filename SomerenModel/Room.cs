namespace SomerenModel
{
    public class Room
    {
        public int Id { get; set; }         // database id
        public string RoomNumber { get; set; }     // RoomNumber, e.g. A206, A100,
        public int Floor { get; set; }   // number of beds, either 4, 6, 8, 12 or 16
        public char Building 
        {
            get 
            {
                return RoomNumber[0]; //Gets the building where the room is located
            }
        }
        public string Type
        {
            get
            {
                if (Floor == 1 && Building == 'A')
                {
                    return "Lecturer"; // when true it is a room for a teacher
                } else
                {
                    return "Student"; // when false it is a room for a teacher
                }
            }
        }
        public int RoomSize
        {
            get
            {
                return Type == "Lecturer" ? 1 : 8;
            }
        }
    }
}
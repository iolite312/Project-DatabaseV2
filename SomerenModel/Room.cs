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
        public RoomEnum Type { get; set; }
        public int RoomSize
        {
            get
            {
                return Type == RoomEnum.lecturer ? 1 : 8;
            }
        }
    }
}
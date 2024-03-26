using SomerenModel;
using SomerenService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SomerenUI
{
    public partial class AddLecturers : Form
    {
        public AddLecturers()
        {
            InitializeComponent();
            AddLecturerAddedLbl.Visible = false;
            AddRooms();
        }

        private void AddLecturerSubmitBtn_Click(object sender, EventArgs e)
        {
            AddingLecturer();
        }

        private void AddingLecturer()
        {
            TeacherService teacherService = new TeacherService();
            try
            {
                int teacherNumber = int.Parse(LecturerAddNumberTxt.Text);
                string FirstName = LecturerAddFirstNameTxt.Text.ToString();
                string SurName = LecturerAddSurNameTxt.Text.ToString();
                DateTime DateOfBirth = AddLecturerDTP.Value;
                int TelephoneNumber = int.Parse(LecturerAddTelephoneNumberTxt.Text);
                string Room = AddLecturerRoomCb.SelectedItem.ToString();
                CheckNotEmpty(teacherNumber, FirstName, SurName, DateOfBirth, TelephoneNumber, Room);
                CheckNotDoubleValue(teacherNumber, Room);
                Teacher teacher = new Teacher(FirstName, SurName, teacherNumber, TelephoneNumber, Room, DateOfBirth);
                teacherService.AddLecturer(teacher);
                AddLecturerAddedLbl.Visible = true;
            }
            catch (Exception ex) { MessageBox.Show($"Error: {ex.Message}"); }
        }

        private void CheckNotEmpty(int teacherNumber, string FirstName, string SurName, DateTime DateOfBirth, int TelephoneNumber, string Room)
        {
            if (teacherNumber == 0) { throw new Exception("Please enter the teacher number of the lecturer"); }
            if (string.IsNullOrEmpty(FirstName)) { throw new Exception("Please enter the firstname of the lecturer"); }
            if (string.IsNullOrEmpty(SurName)) { throw new Exception("Please enter the surname of the lecturer"); }
            if (string.IsNullOrEmpty(Room)) { throw new Exception("Please select a room"); }
            if (TelephoneNumber.ToString().Length >= 10) { throw new Exception("Please enter a valid phone number"); }
            if (DateOfBirth.Year >= DateTime.Now.Year - 18 ) { throw new Exception("Please enter a valid date of birth"); }
        }

        private void CheckNotDoubleValue(int teacherNumber, string room)
        {
            TeacherService teacher = new TeacherService();
            List<Teacher> allTeachers = teacher.GetTeachers();
            foreach(Teacher teacherComparison in allTeachers)
            {
                if (teacherComparison.Number == teacherNumber){ throw new Exception("Please enter a teacher number that is not yet present."); }
                if (teacherComparison.Room == room) { throw new Exception("Please enter a room that is not yet occupied."); }
            }
        }

        private void AddRooms()
        {
            RoomService roomService = new RoomService();
            List<Room> rooms = roomService.GetRooms();
            foreach (Room room in rooms)
            {
                if (room.Type == RoomEnum.lecturer)
                {
                    AddLecturerRoomCb.Items.Add(room.RoomNumber);
                }
            }
        }
    }
}

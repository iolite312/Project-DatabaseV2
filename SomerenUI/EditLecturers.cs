using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class EditLecturers : Form
    {
        TeacherService teacherService;
        Teacher teacher;
        public EditLecturers(Teacher editTeacher)
        {
            teacherService = new TeacherService();
            teacher = editTeacher;
            InitializeComponent();
            EditLecturerEditedLbl.Visible = false;
            AddRooms();
            FillFields();
        }



        private void CheckNotEmpty(int teacherNumber, string FirstName, string SurName, DateTime DateOfBirth, int TelephoneNumber, string Room)
        {
            if (teacherNumber == 0) { throw new Exception("Please enter the teacher number of the lecturer"); }
            if (string.IsNullOrEmpty(FirstName)) { throw new Exception("Please enter the firstname of the lecturer"); }
            if (string.IsNullOrEmpty(SurName)) { throw new Exception("Please enter the surname of the lecturer"); }
            if (string.IsNullOrEmpty(Room)) { throw new Exception("Please select a room"); }
            if (TelephoneNumber.ToString().Length >= 10) { throw new Exception("Please enter a valid phone number"); }
            if (DateOfBirth.Year >= DateTime.Now.Year - 18) { throw new Exception("Please enter a valid date of birth"); }
        }

        private void CheckNotDoubleValue(int teacherNumber, string room)
        {
            List<Teacher> allTeachers = teacherService.GetTeachers();
            foreach (Teacher teacherComparison in allTeachers)
            {
                if (teacher.Id != teacherComparison.Id)
                {
                    if (teacherComparison.Number == teacherNumber) { throw new Exception("Please enter a teacher number that is not yet present."); }
                    if (teacherComparison.Room == room) { throw new Exception("Please enter a room that is not yet occupied."); }
                }
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
                    EditLecturerRoomCb.Items.Add(room.RoomNumber);
                }
            }
        }

        private void FillFields()
        {
            LecturerEditNumberTxt.Text = teacher.Number.ToString();
            LecturerEditFirstNameTxt.Text = teacher.FirstName.ToString();
            LecturerEditSurNameTxt.Text = teacher.SurName.ToString();
            EditLecturerDTP.Text = teacher.BirthDate.ToString();
            LecturerEditTelephoneNumberTxt.Text = teacher.TelephoneNumber.ToString();
            EditLecturerRoomCb.Text = teacher.Room.ToString();
        }

        private void EditLecturerSubmitBtn_Click(object sender, EventArgs e)
        {
            editLecturer();
        }

        private void editLecturer() 
        {
            try
            {
                getUpdatedValues();
                teacherService.EditLecturer(teacher);
            }catch (Exception ex) { MessageBox.Show($"Error: {ex.Message}"); }
            EditLecturerEditedLbl.Visible = true;
        }
        private Teacher getUpdatedValues()
        {
            int Number = int.Parse(LecturerEditNumberTxt.Text);
            string FirstName = LecturerEditFirstNameTxt.Text.ToString();
            string SurName = LecturerEditSurNameTxt.Text.ToString();
            DateTime DateOfBirth = EditLecturerDTP.Value;
            int TelephoneNumber = int.Parse(LecturerEditTelephoneNumberTxt.Text);
            string Room = EditLecturerRoomCb.SelectedItem.ToString();
            CheckNotEmpty(Number, FirstName, SurName, DateOfBirth, TelephoneNumber, Room);
            CheckNotDoubleValue(Number, Room);
            teacher = updateTeacher(Number, FirstName, SurName, DateOfBirth, TelephoneNumber, Room);
            return teacher;
        }

        private Teacher updateTeacher(int Number, string FirstName, string SurName, DateTime DateOfBirth, int TelephoneNumber, string Room)
        {
            teacher.Number = Number; teacher.FirstName = FirstName; teacher.SurName = SurName; teacher.BirthDate = DateOfBirth; teacher.TelephoneNumber = TelephoneNumber; teacher.Room = Room;
            return teacher;
        }
    }


}

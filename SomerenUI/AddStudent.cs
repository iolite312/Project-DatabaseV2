using SomerenModel;
using SomerenService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SomerenUI
{
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void AddNewStudent()
        {
            StudentService studentService = new StudentService();

            try
            {
                string firstName = txtFirstName.Text.Trim();
                string lastName = txtLastName.Text.Trim();
                int studentNumber = int.Parse(txtStudentNumber.Text);
                int phoneNumber = int.Parse(txtPhoneNumber.Text);
                string studentClass = txtClass.Text.Trim();
                string roomNumber = txtRoomNumber.Text.Trim();

                // Validate inputs
                CheckNotEmpty(firstName, lastName, studentNumber, phoneNumber, studentClass, roomNumber);

                // Create student object
                Student newStudent = new Student()
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Number = studentNumber,
                    PhoneNumber = phoneNumber,
                    Class = studentClass,
                    RoomNumber = roomNumber
                };

                // Add student to database
                studentService.AddStudent(newStudent);

                // Show success message
                //lblStudentAdded.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        private void CheckNotEmpty(string firstName, string lastName, int studentNumber, int phoneNumber, string studentClass, string roomNumber)
        {
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName))
            {
                throw new Exception("Please enter both first name and last name.");
            }
            if (studentNumber <= 0)
            {
                throw new Exception("Please enter a valid student number.");
            }
            if (phoneNumber <= 0)
            {
                throw new Exception("Please enter a valid phone number.");
            }
            if (string.IsNullOrEmpty(studentClass))
            {
                throw new Exception("Please enter the student's class.");
            }
            if (string.IsNullOrEmpty(roomNumber))
            {
                throw new Exception("Please enter the student's room number.");
            }
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            AddNewStudent();

        }
    }
}

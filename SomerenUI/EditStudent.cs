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
    public partial class EditStudent : Form
    {
        private StudentService studentService;
        private Student selectedStudent; // Added field to store the selected student

        public EditStudent(Student student)
        {
            InitializeComponent();
            studentService = new StudentService();
            selectedStudent = student; // Store the provided student for editing

            // Display the details of the provided student in text boxes
            txtFirstName.Text = selectedStudent.FirstName;
            txtLastName.Text = selectedStudent.LastName;
            txtStudentNumber.Text = selectedStudent.Number.ToString();
            txtPhoneNumber.Text = selectedStudent.PhoneNumber.ToString();
            txtClass.Text = selectedStudent.Class;
            txtRoomNumber.Text = selectedStudent.RoomNumber;
        }

        private void btnEditStudent_Click(object sender, EventArgs e)
        {
            try
            {
                // Update the selected student with the edited details
                selectedStudent.FirstName = txtFirstName.Text;
                selectedStudent.LastName = txtLastName.Text;
                selectedStudent.Number = int.Parse(txtStudentNumber.Text);
                selectedStudent.PhoneNumber = int.Parse(txtPhoneNumber.Text);
                selectedStudent.Class = txtClass.Text;
                selectedStudent.RoomNumber = txtRoomNumber.Text;

                // Call the service to update the student in the database
                studentService.EditStudent(selectedStudent);

                // Show success message
                MessageBox.Show("Student updated successfully!");

                // Close the edit form
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating student: {ex.Message}");
            }
        }
    }
}

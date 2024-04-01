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
    public partial class DeleteStudent : Form
    {
        public DeleteStudent()
        {
            InitializeComponent();
        }

        private void DeleteExistingStudent()
        {
            StudentService studentService = new StudentService();

            try
            {
                int studentNumber = int.Parse(txtBoxStudentNumber.Text);
                string lastName = txtBoxLastName.Text;

                // Check if the student exists
                bool studentExists = studentService.StudentExists(studentNumber, lastName);

                if (studentExists)
                {
                    // Delete the student from the database
                    studentService.DeleteStudent(studentNumber, lastName);

                    // Show success message
                    MessageBox.Show("Student deleted successfully!");

                    // Clear input fields
                    txtBoxStudentNumber.Clear();
                    txtBoxLastName.Clear();
                }
                else
                {
                    // Show error message if the student doesn't exist
                    MessageBox.Show("Student not found. Please enter a valid student number and last name.");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid student number.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting student: {ex.Message}");
            }
        }
        private void btnDeleteIN_Click(object sender, EventArgs e)
        {
            DeleteExistingStudent();
        }
    }
}

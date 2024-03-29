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
using static System.Windows.Forms.LinkLabel;

namespace SomerenUI
{
    public partial class DeleteLecturers : Form
    {
        TeacherService teacherService;
        Teacher teacher;

        public DeleteLecturers(Teacher DeleteTeacher)
        {
            InitializeComponent();
            teacherService = new TeacherService();
            teacher = DeleteTeacher;
            DeleteLecturerDeletedLbl.Visible = false;
            FillFields();
        }

        private void DeleteLecturerDeleteNoBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void FillFields()
        {
            DeleteLecturerNumberTxt.Text = teacher.Number.ToString();
            DeleteLecturerNametxt.Text = teacher.FullName.ToString();
        }

        private void DeleteLecturerDeleteYesBtn_Click(object sender, EventArgs e)
        {
            try
            {
                teacherService.RemoveLecturer(teacher);
            }
            catch (Exception ex) { MessageBox.Show($"Error: {ex.Message}"); }
            DeleteLecturerDeletedLbl.Visible = true;
        }
    }
}

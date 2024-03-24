using SomerenService;
using SomerenModel;
using System.Windows.Forms;
using System.Collections.Generic;
using System;
using SomerenDAL;
using static SomerenModel.DrankVAT;

namespace SomerenUI
{
    public partial class SomerenUI : Form
    {
        public SomerenUI()
        {
            InitializeComponent();
        }

        private void ShowDashboardPanel()
        {
            // hide all other panels
            pnlStudents.Hide();
            pnlRooms.Hide();
            pnlLecturers.Hide();
            pnlActivities.Hide();
            pnlVATReport.Hide();

            // show dashboard
            pnlDashboard.Show();
        }

        private void ShowStudentsPanel()
        {
            // hide all other panels
            pnlDashboard.Hide();
            pnlRooms.Hide();
            pnlLecturers.Hide();
            pnlActivities.Hide();
            pnlVATReport.Hide();

            // show students
            pnlStudents.Show();

            try
            {
                // get and display all students
                List<Student> students = GetStudents();
                DisplayStudents(students);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the students: " + e.Message);
            }
        }
        private void ShowRoomsPanel()
        {
            //hide unused panels
            pnlDashboard.Hide();
            pnlStudents.Hide();
            pnlLecturers.Hide();
            pnlActivities.Hide();
            pnlVATReport.Hide();


            //show rooms panel
            pnlRooms.Show();
            try
            {
                // get and display all students
                List<Room> rooms = GetRooms();
                DisplayRooms(rooms);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the rooms: " + e.Message);
            }
        }
        private List<Room> GetRooms()
        {
            RoomService roomService = new RoomService();
            List<Room> rooms = roomService.GetRooms();
            return rooms;
        }
        private void DisplayRooms(List<Room> rooms)
        {
            // clear the listview before filling it
            listViewRooms.Items.Clear();

            foreach (Room room in rooms)
            {
                ListViewItem li = new ListViewItem(room.Id.ToString());
                li.SubItems.Add(room.RoomNumber);
                li.SubItems.Add(room.RoomSize.ToString());
                li.SubItems.Add(room.Type);

                li.Tag = room;   // link student object to listview item
                listViewRooms.Items.Add(li);
            }
        }

        private List<Student> GetStudents()
        {
            StudentService studentService = new StudentService();
            List<Student> students = studentService.GetStudents();
            return students;
        }

        private void DisplayStudents(List<Student> students)
        {
            // clear the listview before filling it
            listViewStudents.Items.Clear();

            foreach (Student student in students)
            {
                ListViewItem li = new ListViewItem(student.Id.ToString());
                li.SubItems.Add(student.Number.ToString());
                li.SubItems.Add(student.FirstName);
                li.SubItems.Add(student.LastName);
                li.SubItems.Add(student.Class);
                li.SubItems.Add(student.PhoneNumber.ToString());
                li.SubItems.Add(student.RoomNumber);


                li.Tag = student;   // link student object to listview item
                listViewStudents.Items.Add(li);
            }
            foreach (ColumnHeader column in listViewStudents.Columns)
            {
                column.Width = -1; // -1 means auto size based on content
            }
        }

        private void dashboardToolStripMenuItem1_Click(object sender, System.EventArgs e)
        {
            ShowDashboardPanel();
        }

        private void exitToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowStudentsPanel();
        }


        private void roomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowRoomsPanel();
        }


        /* Show Teachers*/
        private void ShowTeachersPanel()
        {
            // hide all other panels
            pnlDashboard.Hide();
            pnlStudents.Hide();
            pnlRooms.Hide();
            pnlActivities.Hide();
            pnlVATReport.Hide();
            // show teachers
            pnlLecturers.Show();
            try
            {
                // get and display all teachers
                List<Teacher> teachers = GetTeachers();
                DisplayTeachers(teachers);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the lecturers: " + e.Message);
            }
        }

        private List<Teacher> GetTeachers()
        {
            TeacherService teacherService = new TeacherService();
            List<Teacher> teachers = teacherService.GetTeachers();
            return teachers;
        }

        private void DisplayTeachers(List<Teacher> teachers)
        {
            // clear the listview before filling it
            listViewLecturers.Items.Clear();
            foreach (Teacher teacher in teachers)
            {
                ListViewItem li = new ListViewItem(teacher.Number.ToString());
                li.SubItems.Add(teacher.FirstName.ToString());
                li.SubItems.Add(teacher.SurName);
                li.SubItems.Add(teacher.TelephoneNumber.ToString());
                li.SubItems.Add(teacher.Age.ToString());
                li.Tag = teacher;   // link Lecturer object to listview item
                listViewLecturers.Items.Add(li);
            }
        }


        private void ShowActivitiesPanel()
        {
            // Hide all other panels
            pnlDashboard.Hide();
            pnlLecturers.Hide();
            pnlRooms.Hide();
            pnlStudents.Hide();
            pnlVATReport.Hide();
            // Show activities panel
            pnlActivities.Show();

            try
            {
                // Get and display all activities
                List<Activiteiten> activiteiten = GetActiviteiten();
                DisplayActiviteiten(activiteiten);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the activities: " + e.Message);
            }
        }

        private void DisplayActiviteiten(List<Activiteiten> activiteiten)
        {
            // Clear existing items from the ListView
            listViewActivities.Items.Clear();

            // Add each activity to the ListView
            foreach (Activiteiten activity in activiteiten)
            {
                ListViewItem li = new ListViewItem(activity.id.ToString());
                li.SubItems.Add(activity.Soort_Activiteit);
                li.SubItems.Add(activity.Begin_Tijd.ToString());
                li.SubItems.Add(activity.Eind_Tijd.ToString());
                li.SubItems.Add(activity.Datum.ToShortDateString());


                li.Tag = activity;
                listViewActivities.Items.Add(li);
            }
        }

        private List<Activiteiten> GetActiviteiten()
        {
            ActiviteitenService activiteitenService = new ActiviteitenService();
            List<Activiteiten> activiteiten = activiteitenService.GetActivities();
            return activiteiten;
        }

        private void ShowVATReportPanel()
        {
            pnlActivities.Hide();
            pnlDashboard.Hide();
            pnlLecturers.Hide();
            pnlRooms.Hide();
            pnlStudents.Hide();
            pnlVATReport.Show();

            // Validate year
            int year;
            if (!int.TryParse(textBoxYear.Text, out year) || !DrankVAT.ValidationYear.IsValidYear(year))
            {
                // Handle invalid year input
                return;
            }

            // Proceed with other validations
            string quarter = textBoxQuarter.Text.ToUpper();
            if (string.IsNullOrEmpty(quarter) || !(quarter == "1" || quarter == "2" || quarter == "3" || quarter == "Q4"))
            {
                // Handle invalid quarter input
                return;
            }
        }
        private void DisplayVatReport(int year, string quarter)
        {
            DrankVATService drankVATService = new DrankVATService();
            decimal totalVat, totalVATHigh, totalVATLow;
            drankVATService.CalculateVATForQuarter(year, quarter, out totalVATLow, out totalVATHigh, out totalVat);
            DateTime startQuarter, endQuarter;
            drankVATService.CalculateQuarterDates(year, quarter, out startQuarter, out endQuarter);
            ListViewItem item = new ListViewItem(year.ToString());
            item.SubItems.Add(quarter);
            item.SubItems.Add(startQuarter.ToString());
            item.SubItems.Add(endQuarter.ToString());
            item.SubItems.Add(totalVATLow.ToString("C"));
            item.SubItems.Add(totalVATHigh.ToString("C"));
            item.SubItems.Add(totalVat.ToString("C"));
            listViewVATReport.Items.Clear(); // Clear all items first
            listViewVATReport.Items.Add(item);
        }

        private void lecturersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowTeachersPanel();
        }

        private void activitiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowActivitiesPanel();
        }

        private void vATReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowVATReportPanel();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Validate input
            if (string.IsNullOrWhiteSpace(textBoxYear.Text) || string.IsNullOrWhiteSpace(textBoxQuarter.Text))
            {
                MessageBox.Show("Please enter both year and quarter.");
                return;
            }

            int year;
            if (!int.TryParse(textBoxYear.Text, out year))
            {
                MessageBox.Show("Please enter a valid year.");
                return;
            }

            if (!ValidationYear.IsValidYear(year))
            {
                MessageBox.Show("There is only data available for 2024");
                return;
            }

            string quarter = textBoxQuarter.Text.ToUpper();
            if (quarter != "1" && quarter != "2" && quarter != "3" && quarter != "4")
            {
                MessageBox.Show("Please enter a valid quarter (1, 2, 3, or 4).");
                return;
            }

            try
            {
                DisplayVatReport(year, quarter);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
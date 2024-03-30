using SomerenService;
using SomerenModel;
using static SomerenModel.DrankVAT;
using System.Windows.Forms;
using System.Collections.Generic;
using System;
using System.Data.SqlTypes;

namespace SomerenUI
{
    public partial class SomerenUI : Form
    {
        public SomerenUI()
        {
            InitializeComponent();
            ShowDashboardPanel();
        }



        private void ShowDashboardPanel()
        {
            // hide all other panels
            pnlStudents.Hide();
            pnlRooms.Hide();
            pnlLecturers.Hide();
            pnlActivities.Hide();
            pnlVATReport.Hide();
            pnlStock.Hide();
            pnlOrders.Hide();
            pnlRevenue.Hide();
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
            pnlStock.Hide();
            pnlOrders.Hide();
            pnlRevenue.Hide();
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
            pnlOrders.Hide();
            pnlStock.Hide();
            pnlRevenue.Hide();
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
                li.SubItems.Add(room.Type.ToString());

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
            pnlStock.Hide();
            pnlOrders.Hide();
            pnlRevenue.Hide();
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
            pnlRevenue.Hide();
            pnlStock.Hide();
            pnlOrders.Hide();
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
        private void submitDate()
        {
            DateTime startDate = dtpStartDate.Value.Date;
            DateTime endDate = dtpEndDate.Value.Date;
            if (startDate < endDate)
            {
                lblDateSelect.Text = ($"Selected period: {startDate.ToString("dd/MM/yyyy")} - {endDate.ToString("dd/MM/yyyy")}");

                try
                {
                    List<Revenue> revenues = GetSales(startDate, endDate);
                    displayRev(revenues);
                }
                catch (Exception e)
                {
                    MessageBox.Show("Something went wrong while loading the revenue: " + e.Message);
                }

            }
            else
            {
                MessageBox.Show("Invalid Period: Please select dates within the valid range.");
            }

        }
        private List<Revenue> GetSales(DateTime startDate, DateTime endDate)
        {
            RevenueService revenueService = new();
            if (startDate < SqlDateTime.MinValue.Value)
            {
                startDate = SqlDateTime.MinValue.Value;
            }
            if (endDate > SqlDateTime.MaxValue.Value)
            {
                endDate = SqlDateTime.MaxValue.Value;
            }
            List<Revenue> revenues = revenueService.GetRangeDate(startDate, endDate);
            return revenues;
        }

        private void displayRev(List<Revenue> Sales)
        {
            lvRevenue.Items.Clear();

            foreach (Revenue rev in Sales)
            {
                ListViewItem item = new ListViewItem(rev.numberOfCustomer.ToString());
                item.SubItems.Add(rev.sales.ToString());
                item.SubItems.Add(rev.turnOver.ToString("0.00"));
                lvRevenue.Items.Add(item);
            }

            lvRevenue.Show();
        }
        /* Show stock */

        private void ShowStockPanel()
        {
            // hide all other panels
            pnlDashboard.Hide();
            pnlStudents.Hide();
            pnlRooms.Hide();
            pnlActivities.Hide();
            pnlVATReport.Hide();
            pnlLecturers.Hide();
            pnlOrders.Hide();
            pnlRevenue.Hide();
            // show stock
            pnlStock.Show();
            try
            {
                // get and display all teachers
                List<Drinks> drinks = GetDrinks();
                DisplayDrinks(drinks);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the stock: " + e.Message);
            }
        }

        private List<Drinks> GetDrinks()
        {
            DrinksService drinksService = new DrinksService();
            List<Drinks> drinks = drinksService.GetDrinks();
            return drinks;
        }

        private void DisplayDrinks(List<Drinks> drinks)
        {
            // clear the listview before filling it
            listViewStock.Items.Clear();
            foreach (Drinks drink in drinks)
            {
                ListViewItem li = new ListViewItem(drink.Id.ToString());
                li.SubItems.Add(drink.name.ToString());
                li.SubItems.Add(drink.price.ToString());
                li.SubItems.Add(drink.Type);
                li.SubItems.Add(drink.stock.ToString());
                li.SubItems.Add(drink.stockStatus);
                li.Tag = drink;   // link drink object to listview item
                listViewStock.Items.Add(li);
            }
        }
        private void DisplayRevenue()
        {
            // Hide all other panels
            pnlDashboard.Hide();
            pnlLecturers.Hide();
            pnlRooms.Hide();
            pnlStudents.Hide();
            pnlActivities.Hide();
            pnlVATReport.Hide();
            pnlOrders.Hide();
            pnlStock.Hide();

            // Show Revenue panel
            pnlRevenue.Show();

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
        private void revenueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayRevenue();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            submitDate();
        }
        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowStockPanel();
        }

        private void DrinksAddBtn_Click(object sender, EventArgs e)
        {
            AddDrink addDrinksForm = new AddDrink();
            addDrinksForm.ShowDialog();
            ShowStockPanel();
        }

        private void DrinksEditBtn_Click(object sender, EventArgs e)
        {
            EditDrink EditDrinkForm = new EditDrink();
            EditDrinkForm.ShowDialog();
            ShowStockPanel();
        }

        private void DrinksDeleteBtn_Click(object sender, EventArgs e)
        {
            DeleteDrink deleteDrinkForm = new DeleteDrink();
            deleteDrinkForm.ShowDialog();
            ShowStockPanel();
        }

        private void ordersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowOrderPanel();
        }
        private void ShowOrderPanel()
        {
            // hide all other panels
            pnlDashboard.Hide();
            pnlStudents.Hide();
            pnlRooms.Hide();
            pnlActivities.Hide();
            pnlLecturers.Hide();
            pnlStock.Hide();
            pnlRevenue.Hide();
            pnlVATReport.Hide();
            // show Orders
            pnlOrders.Show();
            try
            {
                DisplayOrders();
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the Orders: " + e.Message);
            }
        }
        private void DisplayOrders()
        {
            List<Student> students = GetStudents();
            List<Drinks> drinks = GetDrinks();
            foreach (Student student in students)
            {
                comboStudent.Items.Add($"{student.FullName}");

            }
            foreach (Drinks drink in drinks)
            {
                comboDrinks.Items.Add($"{drink.name}");
            }
        }

        private void comboDrinks_SelectedIndexChanged(object sender, EventArgs e)
        {
            DrinksService drinksService = new DrinksService();
            int currentDrink = comboDrinks.SelectedIndex;
            Drinks fullDrink = drinksService.GetDrinkById(currentDrink + 1);
            for (int i = 0; fullDrink.stock >= i; i++)
            {
                comboCount.Items.Add(i);
            }

        }

        private void orderPlacebtn_Click(object sender, EventArgs e)
        {
            try
            {
                OrderService orderService = new OrderService();
                DrinksService drinksService = new DrinksService();
                List<Student> students = GetStudents();
                Student currentStudent = students[comboStudent.SelectedIndex];
                Drinks fullDrink = drinksService.GetDrinkById(comboDrinks.SelectedIndex + 1);
                int totalDrinks = CheckOrderCount();
                Order order = new Order(fullDrink.Id, currentStudent.Number, DateTime.Now, totalDrinks);
                orderService.InsertOrder(order, fullDrink);
                ClearOrderScreen();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ClearOrderScreen()
        {
            MessageBox.Show("Order was a succes!");
            comboCount.Items.Clear();
            comboStudent.Items.Clear();
            comboDrinks.Items.Clear();
            comboCount.ResetText();
            comboStudent.ResetText();
            comboDrinks.ResetText();
            DisplayOrders();
        }
        private int CheckOrderCount()
        {
            if ((int)comboCount.SelectedItem == 0)
            {
                throw new Exception("Select a higher count than 0");
            }
            return (int)comboCount.SelectedItem;
        }

        private void comboCount_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                DrinksService drinksService = new DrinksService();
                Drinks fullDrink = drinksService.GetDrinkById(comboDrinks.SelectedIndex + 1);
                int totalDrinks = CheckOrderCount();
                decimal totalPrice = totalDrinks * fullDrink.price;
                OrderTotalInputlbl.Text = $"{totalPrice}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void manageSupervisorsbtn_Click(object sender, EventArgs e)
        {
            ManageSupervisors manageSupervisors = new ManageSupervisors();
            manageSupervisors.ShowDialog();
            ShowActivitiesPanel();
        }

        private void manageParticipantsbtn_Click(object sender, EventArgs e)
        {
            ManageParticipants manageParticipants = new ManageParticipants();
            manageParticipants.ShowDialog();
            ShowActivitiesPanel();
        }

        private void btnAddLV_Click(object sender, EventArgs e)
        {
            AddStudent addStudent = new AddStudent();
            addStudent.ShowDialog();
            ShowStudentsPanel();
        }

        private void btnDeleteLV_Click(object sender, EventArgs e)
        {
            DeleteStudent deleteStudent = new DeleteStudent();
            deleteStudent.ShowDialog();
            ShowStudentsPanel();
        }

        private Student selectedStudent;
        private StudentService studentService = new StudentService();

        private void btnEditLV_Click(object sender, EventArgs e)
        {
            if (listViewStudents.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewStudents.SelectedItems[0];
                selectedStudent = (Student)selectedItem.Tag; // Assign the selected student to the class-level field

                // Pass the selected student to the edit form
                EditStudent editForm = new EditStudent(selectedStudent);
                editForm.FormClosed += EditForm_FormClosed;
                editForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a student to edit.");
            }
        }
        private void EditForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            RefreshStudentList();
        }
        private void RefreshStudentList()
        {

            if (studentService != null)
            {
                List<Student> students = studentService.GetStudents();

            }
            else
            {
                MessageBox.Show("Can't update");
            }
        }

        private void listViewStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewStudents.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewStudents.SelectedItems[0];
                selectedStudent = (Student)selectedItem.Tag;
            }
        }
    }
}
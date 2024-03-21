using SomerenService;
using SomerenModel;
using System.Windows.Forms;
using System.Collections.Generic;
using System;

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
            pnlStock.Hide();

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
            pnlStock.Hide();
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
            pnlStock.Hide();
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
            pnlStock.Hide();
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
            pnlStock.Hide();
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

        /* Show stock */

        private void ShowStockPanel()
        {
            // hide all other panels
            pnlDashboard.Hide();
            pnlStudents.Hide();
            pnlRooms.Hide();
            pnlActivities.Hide();
            pnlLecturers.Hide();
            pnlOrders.Hide();
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



        private void lecturersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowTeachersPanel();
        }

        private void activitiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowActivitiesPanel();
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
            } catch (Exception ex)
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
    }
}
using SomerenModel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SomerenUI
{
    partial class SomerenUI
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SomerenUI));
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            dashboardToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            studentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            lecturersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            activitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            roomsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            stockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ordersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            revenueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            vATReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            pnlDashboard = new System.Windows.Forms.Panel();
            lblDashboard = new System.Windows.Forms.Label();
            pnlStudents = new System.Windows.Forms.Panel();
            listViewStudents = new System.Windows.Forms.ListView();
            idStudent = new System.Windows.Forms.ColumnHeader();
            studentNummer = new System.Windows.Forms.ColumnHeader();
            voornaam = new System.Windows.Forms.ColumnHeader();
            achternaam = new System.Windows.Forms.ColumnHeader();
            klas = new System.Windows.Forms.ColumnHeader();
            telefoonnummer = new System.Windows.Forms.ColumnHeader();
            kamernummer = new System.Windows.Forms.ColumnHeader();
            btnDeleteLV = new System.Windows.Forms.Button();
            btnEditLV = new System.Windows.Forms.Button();
            btnAddLV = new System.Windows.Forms.Button();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            label1 = new System.Windows.Forms.Label();
            pnlOrders = new System.Windows.Forms.Panel();
            OrderTotalInputlbl = new System.Windows.Forms.Label();
            OrderTotalPricelbl = new System.Windows.Forms.Label();
            orderPlacebtn = new System.Windows.Forms.Button();
            comboCount = new System.Windows.Forms.ComboBox();
            comboDrinks = new System.Windows.Forms.ComboBox();
            comboStudent = new System.Windows.Forms.ComboBox();
            orderCountlbl = new System.Windows.Forms.Label();
            orderDrinklbl = new System.Windows.Forms.Label();
            orderStudentlbl = new System.Windows.Forms.Label();
            pictureBox5 = new System.Windows.Forms.PictureBox();
            label3 = new System.Windows.Forms.Label();
            pnlLecturers = new System.Windows.Forms.Panel();
            listViewLecturers = new System.Windows.Forms.ListView();
            lectureID = new System.Windows.Forms.ColumnHeader();
            firstnameLecturer = new System.Windows.Forms.ColumnHeader();
            lastNameLecturer = new System.Windows.Forms.ColumnHeader();
            telephoneNumberL = new System.Windows.Forms.ColumnHeader();
            AgeLecturer = new System.Windows.Forms.ColumnHeader();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            label2 = new System.Windows.Forms.Label();
            pnlVATReport = new System.Windows.Forms.Panel();
            button1 = new System.Windows.Forms.Button();
            textBoxQuarter = new System.Windows.Forms.TextBox();
            textBoxYear = new System.Windows.Forms.TextBox();
            VATReportQuarterlbl = new System.Windows.Forms.Label();
            VATReportYearlbl = new System.Windows.Forms.Label();
            pictureBox8 = new System.Windows.Forms.PictureBox();
            listViewVATReport = new System.Windows.Forms.ListView();
            columnHeader1 = new System.Windows.Forms.ColumnHeader();
            columnHeader2 = new System.Windows.Forms.ColumnHeader();
            columnHeader3 = new System.Windows.Forms.ColumnHeader();
            columnHeader4 = new System.Windows.Forms.ColumnHeader();
            columnHeader5 = new System.Windows.Forms.ColumnHeader();
            columnHeader6 = new System.Windows.Forms.ColumnHeader();
            columnHeader7 = new System.Windows.Forms.ColumnHeader();
            VATReportlbl = new System.Windows.Forms.Label();
            pnlRooms = new System.Windows.Forms.Panel();
            pictureBox3 = new System.Windows.Forms.PictureBox();
            listViewRooms = new System.Windows.Forms.ListView();
            id = new System.Windows.Forms.ColumnHeader();
            roomNumber = new System.Windows.Forms.ColumnHeader();
            roomSize = new System.Windows.Forms.ColumnHeader();
            roomType = new System.Windows.Forms.ColumnHeader();
            labelRooms = new System.Windows.Forms.Label();
            FirstName = new System.Windows.Forms.ColumnHeader();
            LastName = new System.Windows.Forms.ColumnHeader();
            TelephoneNumber = new System.Windows.Forms.ColumnHeader();
            Age = new System.Windows.Forms.ColumnHeader();
            pnlActivities = new System.Windows.Forms.Panel();
            manageParticipantsbtn = new System.Windows.Forms.Button();
            manageSupervisorsbtn = new System.Windows.Forms.Button();
            pictureBox4 = new System.Windows.Forms.PictureBox();
            listViewActivities = new System.Windows.Forms.ListView();
            ActivityId = new System.Windows.Forms.ColumnHeader();
            ActiviteitSoortActiviteit = new System.Windows.Forms.ColumnHeader();
            ActiviteitBeginTijd = new System.Windows.Forms.ColumnHeader();
            ActiviteitEindTijd = new System.Windows.Forms.ColumnHeader();
            ActiviteitDatum = new System.Windows.Forms.ColumnHeader();
            labelActivities = new System.Windows.Forms.Label();
            pnlRevenue = new System.Windows.Forms.Panel();
            lblDateSelect = new System.Windows.Forms.Label();
            btnSubmit = new System.Windows.Forms.Button();
            lvRevenue = new System.Windows.Forms.ListView();
            numberOfCustomers = new System.Windows.Forms.ColumnHeader();
            sales = new System.Windows.Forms.ColumnHeader();
            turnOver = new System.Windows.Forms.ColumnHeader();
            lblEndDate = new System.Windows.Forms.Label();
            lblStartDate = new System.Windows.Forms.Label();
            dtpEndDate = new System.Windows.Forms.DateTimePicker();
            dtpStartDate = new System.Windows.Forms.DateTimePicker();
            lblRevenue = new System.Windows.Forms.Label();
            pictureBox6 = new System.Windows.Forms.PictureBox();
            pnlStock = new System.Windows.Forms.Panel();
            DrinksDeleteBtn = new System.Windows.Forms.Button();
            DrinksEditBtn = new System.Windows.Forms.Button();
            DrinksAddBtn = new System.Windows.Forms.Button();
            pictureBoxStock = new System.Windows.Forms.PictureBox();
            listViewStock = new System.Windows.Forms.ListView();
            StockId = new System.Windows.Forms.ColumnHeader();
            StockName = new System.Windows.Forms.ColumnHeader();
            StockPrice = new System.Windows.Forms.ColumnHeader();
            StockType = new System.Windows.Forms.ColumnHeader();
            StockStock = new System.Windows.Forms.ColumnHeader();
            StockStatus = new System.Windows.Forms.ColumnHeader();
            lblStock = new System.Windows.Forms.Label();
            menuStrip1.SuspendLayout();
            pnlDashboard.SuspendLayout();
            pnlStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            pnlLecturers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            pnlVATReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            pnlRooms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            pnlActivities.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            pnlRevenue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            pnlStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxStock).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { dashboardToolStripMenuItem, studentsToolStripMenuItem, lecturersToolStripMenuItem, activitiesToolStripMenuItem, roomsToolStripMenuItem, stockToolStripMenuItem, ordersToolStripMenuItem, revenueToolStripMenuItem, vATReportToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new System.Windows.Forms.Padding(9, 4, 0, 4);
            menuStrip1.Size = new System.Drawing.Size(1400, 37);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // dashboardToolStripMenuItem
            // 
            dashboardToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { dashboardToolStripMenuItem1, exitToolStripMenuItem });
            dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            dashboardToolStripMenuItem.Size = new System.Drawing.Size(118, 29);
            dashboardToolStripMenuItem.Text = "Application";
            // 
            // dashboardToolStripMenuItem1
            // 
            dashboardToolStripMenuItem1.Name = "dashboardToolStripMenuItem1";
            dashboardToolStripMenuItem1.Size = new System.Drawing.Size(202, 34);
            dashboardToolStripMenuItem1.Text = "Dashboard";
            dashboardToolStripMenuItem1.Click += dashboardToolStripMenuItem1_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new System.Drawing.Size(202, 34);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // studentsToolStripMenuItem
            // 
            studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            studentsToolStripMenuItem.Size = new System.Drawing.Size(97, 29);
            studentsToolStripMenuItem.Text = "Students";
            studentsToolStripMenuItem.Click += studentsToolStripMenuItem_Click;
            // 
            // lecturersToolStripMenuItem
            // 
            lecturersToolStripMenuItem.Name = "lecturersToolStripMenuItem";
            lecturersToolStripMenuItem.Size = new System.Drawing.Size(98, 29);
            lecturersToolStripMenuItem.Text = "Lecturers";
            lecturersToolStripMenuItem.Click += lecturersToolStripMenuItem_Click;
            // 
            // activitiesToolStripMenuItem
            // 
            activitiesToolStripMenuItem.Name = "activitiesToolStripMenuItem";
            activitiesToolStripMenuItem.Size = new System.Drawing.Size(98, 29);
            activitiesToolStripMenuItem.Text = "Activities";
            activitiesToolStripMenuItem.Click += activitiesToolStripMenuItem_Click;
            // 
            // roomsToolStripMenuItem
            // 
            roomsToolStripMenuItem.Name = "roomsToolStripMenuItem";
            roomsToolStripMenuItem.Size = new System.Drawing.Size(84, 29);
            roomsToolStripMenuItem.Text = "Rooms";
            roomsToolStripMenuItem.Click += roomsToolStripMenuItem_Click;
            // 
            // stockToolStripMenuItem
            // 
            stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            stockToolStripMenuItem.Size = new System.Drawing.Size(71, 29);
            stockToolStripMenuItem.Text = "Stock";
            stockToolStripMenuItem.Click += stockToolStripMenuItem_Click;
            // 
            // ordersToolStripMenuItem
            // 
            ordersToolStripMenuItem.Name = "ordersToolStripMenuItem";
            ordersToolStripMenuItem.Size = new System.Drawing.Size(82, 29);
            ordersToolStripMenuItem.Text = "Orders";
            ordersToolStripMenuItem.Click += ordersToolStripMenuItem_Click;
            // 
            // revenueToolStripMenuItem
            // 
            revenueToolStripMenuItem.Name = "revenueToolStripMenuItem";
            revenueToolStripMenuItem.Size = new System.Drawing.Size(94, 29);
            revenueToolStripMenuItem.Text = "Revenue";
            revenueToolStripMenuItem.Click += revenueToolStripMenuItem_Click;
            // 
            // vATReportToolStripMenuItem
            // 
            vATReportToolStripMenuItem.Name = "vATReportToolStripMenuItem";
            vATReportToolStripMenuItem.Size = new System.Drawing.Size(116, 29);
            vATReportToolStripMenuItem.Text = "VAT Report";
            vATReportToolStripMenuItem.Click += vATReportToolStripMenuItem_Click;
            // 
            // pnlDashboard
            // 
            pnlDashboard.Controls.Add(lblDashboard);
            pnlDashboard.Location = new System.Drawing.Point(18, 45);
            pnlDashboard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            pnlDashboard.Name = "pnlDashboard";
            pnlDashboard.Size = new System.Drawing.Size(1340, 776);
            pnlDashboard.TabIndex = 1;
            // 
            // lblDashboard
            // 
            lblDashboard.AutoSize = true;
            lblDashboard.Location = new System.Drawing.Point(19, 21);
            lblDashboard.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblDashboard.Name = "lblDashboard";
            lblDashboard.Size = new System.Drawing.Size(313, 25);
            lblDashboard.TabIndex = 0;
            lblDashboard.Text = "Welcome to the Someren Application!";
            // 
            // pnlStudents
            // 
            pnlStudents.Controls.Add(listViewStudents);
            pnlStudents.Controls.Add(btnDeleteLV);
            pnlStudents.Controls.Add(btnEditLV);
            pnlStudents.Controls.Add(btnAddLV);
            pnlStudents.Controls.Add(pictureBox1);
            pnlStudents.Controls.Add(label1);
            pnlStudents.Location = new System.Drawing.Point(19, 49);
            pnlStudents.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            pnlStudents.Name = "pnlStudents";
            pnlStudents.Size = new System.Drawing.Size(1340, 776);
            pnlStudents.TabIndex = 2;
            // 
            // listViewStudents
            // 
            listViewStudents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { idStudent, studentNummer, voornaam, achternaam, klas, telefoonnummer, kamernummer });
            listViewStudents.FullRowSelect = true;
            listViewStudents.Location = new System.Drawing.Point(22, 70);
            listViewStudents.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            listViewStudents.MultiSelect = false;
            listViewStudents.Name = "listViewStudents";
            listViewStudents.Size = new System.Drawing.Size(862, 656);
            listViewStudents.TabIndex = 1;
            listViewStudents.UseCompatibleStateImageBehavior = false;
            listViewStudents.View = System.Windows.Forms.View.Details;
            listViewStudents.SelectedIndexChanged += listViewStudents_SelectedIndexChanged;
            // 
            // idStudent
            // 
            idStudent.Text = "id";
            // 
            // studentNummer
            // 
            studentNummer.Text = "Studentnummer";
            studentNummer.Width = 160;
            // 
            // voornaam
            // 
            voornaam.Text = "Voornaam";
            voornaam.Width = 120;
            // 
            // achternaam
            // 
            achternaam.Text = "Achternaam";
            achternaam.Width = 120;
            // 
            // klas
            // 
            klas.Text = "Klas";
            klas.Width = 80;
            // 
            // telefoonnummer
            // 
            telefoonnummer.Text = "Telefoonnummer";
            telefoonnummer.Width = 160;
            // 
            // kamernummer
            // 
            kamernummer.Text = "Kamernummer";
            kamernummer.Width = 160;
            // 
            // btnDeleteLV
            // 
            btnDeleteLV.Location = new System.Drawing.Point(929, 309);
            btnDeleteLV.Margin = new System.Windows.Forms.Padding(2);
            btnDeleteLV.Name = "btnDeleteLV";
            btnDeleteLV.Size = new System.Drawing.Size(112, 34);
            btnDeleteLV.TabIndex = 0;
            btnDeleteLV.Text = "Delete";
            btnDeleteLV.UseVisualStyleBackColor = true;
            btnDeleteLV.Click += btnDeleteLV_Click;
            // 
            // btnEditLV
            // 
            btnEditLV.Location = new System.Drawing.Point(929, 251);
            btnEditLV.Margin = new System.Windows.Forms.Padding(2);
            btnEditLV.Name = "btnEditLV";
            btnEditLV.Size = new System.Drawing.Size(112, 34);
            btnEditLV.TabIndex = 0;
            btnEditLV.Text = "Edit";
            btnEditLV.UseVisualStyleBackColor = true;
            btnEditLV.Click += btnEditLV_Click;
            // 
            // btnAddLV
            // 
            btnAddLV.Location = new System.Drawing.Point(929, 198);
            btnAddLV.Margin = new System.Windows.Forms.Padding(2);
            btnAddLV.Name = "btnAddLV";
            btnAddLV.Size = new System.Drawing.Size(112, 34);
            btnAddLV.TabIndex = 0;
            btnAddLV.Text = "Add";
            btnAddLV.UseVisualStyleBackColor = true;
            btnAddLV.Click += btnAddLV_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(1150, 0);
            pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(186, 205);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(24, 15);
            label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(157, 48);
            label1.TabIndex = 0;
            label1.Text = "Students";
            // 
            // pnlOrders
            // 
            pnlOrders.Controls.Add(OrderTotalInputlbl);
            pnlOrders.Controls.Add(OrderTotalPricelbl);
            pnlOrders.Controls.Add(orderPlacebtn);
            pnlOrders.Controls.Add(comboCount);
            pnlOrders.Controls.Add(comboDrinks);
            pnlOrders.Controls.Add(comboStudent);
            pnlOrders.Controls.Add(orderCountlbl);
            pnlOrders.Controls.Add(orderDrinklbl);
            pnlOrders.Controls.Add(orderStudentlbl);
            pnlOrders.Controls.Add(pictureBox5);
            pnlOrders.Controls.Add(label3);
            pnlOrders.Location = new System.Drawing.Point(14, 44);
            pnlOrders.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            pnlOrders.Name = "pnlOrders";
            pnlOrders.Size = new System.Drawing.Size(1126, 574);
            pnlOrders.TabIndex = 8;
            // 
            // OrderTotalInputlbl
            // 
            OrderTotalInputlbl.AutoSize = true;
            OrderTotalInputlbl.Location = new System.Drawing.Point(625, 162);
            OrderTotalInputlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            OrderTotalInputlbl.Name = "OrderTotalInputlbl";
            OrderTotalInputlbl.Size = new System.Drawing.Size(46, 25);
            OrderTotalInputlbl.TabIndex = 13;
            OrderTotalInputlbl.Text = "0.00";
            // 
            // OrderTotalPricelbl
            // 
            OrderTotalPricelbl.AutoSize = true;
            OrderTotalPricelbl.Location = new System.Drawing.Point(558, 162);
            OrderTotalPricelbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            OrderTotalPricelbl.Name = "OrderTotalPricelbl";
            OrderTotalPricelbl.Size = new System.Drawing.Size(62, 25);
            OrderTotalPricelbl.TabIndex = 12;
            OrderTotalPricelbl.Text = "Totaal:";
            // 
            // orderPlacebtn
            // 
            orderPlacebtn.Location = new System.Drawing.Point(782, 101);
            orderPlacebtn.Margin = new System.Windows.Forms.Padding(2);
            orderPlacebtn.Name = "orderPlacebtn";
            orderPlacebtn.Size = new System.Drawing.Size(109, 36);
            orderPlacebtn.TabIndex = 11;
            orderPlacebtn.Text = "Place Order";
            orderPlacebtn.UseVisualStyleBackColor = true;
            orderPlacebtn.Click += orderPlacebtn_Click;
            // 
            // comboCount
            // 
            comboCount.FormattingEnabled = true;
            comboCount.Location = new System.Drawing.Point(625, 101);
            comboCount.Margin = new System.Windows.Forms.Padding(2);
            comboCount.Name = "comboCount";
            comboCount.Size = new System.Drawing.Size(152, 33);
            comboCount.TabIndex = 10;
            comboCount.SelectedIndexChanged += comboCount_SelectedIndexChanged;
            // 
            // comboDrinks
            // 
            comboDrinks.FormattingEnabled = true;
            comboDrinks.Location = new System.Drawing.Point(398, 102);
            comboDrinks.Margin = new System.Windows.Forms.Padding(2);
            comboDrinks.Name = "comboDrinks";
            comboDrinks.Size = new System.Drawing.Size(152, 33);
            comboDrinks.TabIndex = 9;
            comboDrinks.SelectedIndexChanged += comboDrinks_SelectedIndexChanged;
            // 
            // comboStudent
            // 
            comboStudent.FormattingEnabled = true;
            comboStudent.Location = new System.Drawing.Point(88, 102);
            comboStudent.Margin = new System.Windows.Forms.Padding(2);
            comboStudent.Name = "comboStudent";
            comboStudent.Size = new System.Drawing.Size(195, 33);
            comboStudent.TabIndex = 8;
            // 
            // orderCountlbl
            // 
            orderCountlbl.AutoSize = true;
            orderCountlbl.Location = new System.Drawing.Point(555, 106);
            orderCountlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            orderCountlbl.Name = "orderCountlbl";
            orderCountlbl.Size = new System.Drawing.Size(62, 25);
            orderCountlbl.TabIndex = 7;
            orderCountlbl.Text = "Aantal";
            // 
            // orderDrinklbl
            // 
            orderDrinklbl.AutoSize = true;
            orderDrinklbl.Location = new System.Drawing.Point(289, 105);
            orderDrinklbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            orderDrinklbl.Name = "orderDrinklbl";
            orderDrinklbl.Size = new System.Drawing.Size(108, 25);
            orderDrinklbl.TabIndex = 6;
            orderDrinklbl.Text = "Soort Drank";
            // 
            // orderStudentlbl
            // 
            orderStudentlbl.AutoSize = true;
            orderStudentlbl.Location = new System.Drawing.Point(6, 106);
            orderStudentlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            orderStudentlbl.Name = "orderStudentlbl";
            orderStudentlbl.Size = new System.Drawing.Size(73, 25);
            orderStudentlbl.TabIndex = 5;
            orderStudentlbl.Text = "Student";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (System.Drawing.Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new System.Drawing.Point(920, 9);
            pictureBox5.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new System.Drawing.Size(171, 164);
            pictureBox5.TabIndex = 4;
            pictureBox5.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(15, 9);
            label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(128, 48);
            label3.TabIndex = 0;
            label3.Text = "Orders";
            // 
            // pnlLecturers
            // 
            pnlLecturers.Controls.Add(listViewLecturers);
            pnlLecturers.Controls.Add(pictureBox2);
            pnlLecturers.Controls.Add(label2);
            pnlLecturers.Location = new System.Drawing.Point(18, 44);
            pnlLecturers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            pnlLecturers.Name = "pnlLecturers";
            pnlLecturers.Size = new System.Drawing.Size(1340, 776);
            pnlLecturers.TabIndex = 3;
            // 
            // listViewLecturers
            // 
            listViewLecturers.AllowDrop = true;
            listViewLecturers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { lectureID, firstnameLecturer, lastNameLecturer, telephoneNumberL, AgeLecturer });
            listViewLecturers.FullRowSelect = true;
            listViewLecturers.GridLines = true;
            listViewLecturers.Location = new System.Drawing.Point(22, 70);
            listViewLecturers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            listViewLecturers.Name = "listViewLecturers";
            listViewLecturers.Size = new System.Drawing.Size(1093, 509);
            listViewLecturers.TabIndex = 1;
            listViewLecturers.UseCompatibleStateImageBehavior = false;
            listViewLecturers.View = System.Windows.Forms.View.Details;
            // 
            // lectureID
            // 
            lectureID.Text = "id";
            // 
            // firstnameLecturer
            // 
            firstnameLecturer.Text = "First name";
            firstnameLecturer.Width = 150;
            // 
            // lastNameLecturer
            // 
            lastNameLecturer.Text = "Last name";
            lastNameLecturer.Width = 150;
            // 
            // telephoneNumberL
            // 
            telephoneNumberL.Text = "Telephone number";
            telephoneNumberL.Width = 150;
            // 
            // AgeLecturer
            // 
            AgeLecturer.Text = "Age";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (System.Drawing.Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new System.Drawing.Point(1150, 0);
            pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(186, 205);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(19, 11);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(165, 48);
            label2.TabIndex = 0;
            label2.Text = "Lecturers";
            // 
            // pnlVATReport
            // 
            pnlVATReport.Controls.Add(button1);
            pnlVATReport.Controls.Add(textBoxQuarter);
            pnlVATReport.Controls.Add(textBoxYear);
            pnlVATReport.Controls.Add(VATReportQuarterlbl);
            pnlVATReport.Controls.Add(VATReportYearlbl);
            pnlVATReport.Controls.Add(pictureBox8);
            pnlVATReport.Controls.Add(listViewVATReport);
            pnlVATReport.Controls.Add(VATReportlbl);
            pnlVATReport.Location = new System.Drawing.Point(15, 39);
            pnlVATReport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            pnlVATReport.Name = "pnlVATReport";
            pnlVATReport.Size = new System.Drawing.Size(1340, 814);
            pnlVATReport.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(191, 209);
            button1.Margin = new System.Windows.Forms.Padding(4);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(118, 36);
            button1.TabIndex = 9;
            button1.Text = "Calculate";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBoxQuarter
            // 
            textBoxQuarter.Location = new System.Drawing.Point(236, 144);
            textBoxQuarter.Margin = new System.Windows.Forms.Padding(4);
            textBoxQuarter.Name = "textBoxQuarter";
            textBoxQuarter.Size = new System.Drawing.Size(33, 31);
            textBoxQuarter.TabIndex = 8;
            // 
            // textBoxYear
            // 
            textBoxYear.Location = new System.Drawing.Point(236, 94);
            textBoxYear.Margin = new System.Windows.Forms.Padding(4);
            textBoxYear.Name = "textBoxYear";
            textBoxYear.Size = new System.Drawing.Size(72, 31);
            textBoxYear.TabIndex = 7;
            // 
            // VATReportQuarterlbl
            // 
            VATReportQuarterlbl.AutoSize = true;
            VATReportQuarterlbl.Location = new System.Drawing.Point(25, 148);
            VATReportQuarterlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            VATReportQuarterlbl.Name = "VATReportQuarterlbl";
            VATReportQuarterlbl.Size = new System.Drawing.Size(148, 25);
            VATReportQuarterlbl.TabIndex = 6;
            VATReportQuarterlbl.Text = "Quarter number :";
            // 
            // VATReportYearlbl
            // 
            VATReportYearlbl.AutoSize = true;
            VATReportYearlbl.Location = new System.Drawing.Point(25, 94);
            VATReportYearlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            VATReportYearlbl.Name = "VATReportYearlbl";
            VATReportYearlbl.Size = new System.Drawing.Size(53, 25);
            VATReportYearlbl.TabIndex = 5;
            VATReportYearlbl.Text = "Year :";
            // 
            // pictureBox8
            // 
            pictureBox8.Image = (System.Drawing.Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new System.Drawing.Point(1150, 11);
            pictureBox8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new System.Drawing.Size(186, 205);
            pictureBox8.TabIndex = 4;
            pictureBox8.TabStop = false;
            // 
            // listViewVATReport
            // 
            listViewVATReport.AllowDrop = true;
            listViewVATReport.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7 });
            listViewVATReport.FullRowSelect = true;
            listViewVATReport.GridLines = true;
            listViewVATReport.Location = new System.Drawing.Point(25, 299);
            listViewVATReport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            listViewVATReport.Name = "listViewVATReport";
            listViewVATReport.Size = new System.Drawing.Size(1144, 446);
            listViewVATReport.TabIndex = 1;
            listViewVATReport.UseCompatibleStateImageBehavior = false;
            listViewVATReport.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Year";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Quarter";
            columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "BeginQuarter";
            columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "EndQuarter";
            columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "VAT Low (6%)";
            columnHeader5.Width = 150;
            // 
            // columnHeader6
            // 
            columnHeader6.Tag = "";
            columnHeader6.Text = "VAT High (21%)";
            columnHeader6.Width = 150;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Total VAT";
            columnHeader7.Width = 150;
            // 
            // VATReportlbl
            // 
            VATReportlbl.AutoSize = true;
            VATReportlbl.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            VATReportlbl.Location = new System.Drawing.Point(19, 11);
            VATReportlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            VATReportlbl.Name = "VATReportlbl";
            VATReportlbl.Size = new System.Drawing.Size(196, 48);
            VATReportlbl.TabIndex = 0;
            VATReportlbl.Text = "VAT Report";
            // 
            // pnlRooms
            // 
            pnlRooms.Controls.Add(pictureBox3);
            pnlRooms.Controls.Add(listViewRooms);
            pnlRooms.Controls.Add(labelRooms);
            pnlRooms.Location = new System.Drawing.Point(0, 39);
            pnlRooms.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            pnlRooms.Name = "pnlRooms";
            pnlRooms.Size = new System.Drawing.Size(1340, 771);
            pnlRooms.TabIndex = 3;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (System.Drawing.Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new System.Drawing.Point(1150, 11);
            pictureBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new System.Drawing.Size(186, 205);
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // listViewRooms
            // 
            listViewRooms.AllowDrop = true;
            listViewRooms.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { id, roomNumber, roomSize, roomType });
            listViewRooms.FullRowSelect = true;
            listViewRooms.GridLines = true;
            listViewRooms.Location = new System.Drawing.Point(22, 70);
            listViewRooms.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            listViewRooms.Name = "listViewRooms";
            listViewRooms.Size = new System.Drawing.Size(1093, 509);
            listViewRooms.TabIndex = 1;
            listViewRooms.UseCompatibleStateImageBehavior = false;
            listViewRooms.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            id.Text = "Id";
            // 
            // roomNumber
            // 
            roomNumber.Text = "Kamernummer";
            roomNumber.Width = 120;
            // 
            // roomSize
            // 
            roomSize.Text = "Kamergrootte";
            roomSize.Width = 120;
            // 
            // roomType
            // 
            roomType.Text = "Soort Kamer";
            roomType.Width = 120;
            // 
            // labelRooms
            // 
            labelRooms.AutoSize = true;
            labelRooms.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelRooms.Location = new System.Drawing.Point(19, 11);
            labelRooms.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelRooms.Name = "labelRooms";
            labelRooms.Size = new System.Drawing.Size(129, 48);
            labelRooms.TabIndex = 0;
            labelRooms.Text = "Rooms";
            // 
            // FirstName
            // 
            FirstName.Text = "First name";
            FirstName.Width = 150;
            // 
            // LastName
            // 
            LastName.Text = "Last name";
            LastName.Width = 150;
            // 
            // TelephoneNumber
            // 
            TelephoneNumber.Text = "Telephone number";
            TelephoneNumber.Width = 150;
            // 
            // Age
            // 
            Age.Text = "Age";
            // 
            // pnlActivities
            // 
            pnlActivities.Controls.Add(manageParticipantsbtn);
            pnlActivities.Controls.Add(manageSupervisorsbtn);
            pnlActivities.Controls.Add(pictureBox4);
            pnlActivities.Controls.Add(listViewActivities);
            pnlActivities.Controls.Add(labelActivities);
            pnlActivities.Location = new System.Drawing.Point(20, 39);
            pnlActivities.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            pnlActivities.Name = "pnlActivities";
            pnlActivities.Size = new System.Drawing.Size(1340, 774);
            pnlActivities.TabIndex = 5;
            // 
            // manageParticipantsbtn
            // 
            manageParticipantsbtn.Location = new System.Drawing.Point(1135, 270);
            manageParticipantsbtn.Margin = new System.Windows.Forms.Padding(4);
            manageParticipantsbtn.Name = "manageParticipantsbtn";
            manageParticipantsbtn.Size = new System.Drawing.Size(196, 36);
            manageParticipantsbtn.TabIndex = 6;
            manageParticipantsbtn.Text = "Manage Participants";
            manageParticipantsbtn.UseVisualStyleBackColor = true;
            manageParticipantsbtn.Click += manageParticipantsbtn_Click;
            // 
            // manageSupervisorsbtn
            // 
            manageSupervisorsbtn.Location = new System.Drawing.Point(1135, 225);
            manageSupervisorsbtn.Margin = new System.Windows.Forms.Padding(4);
            manageSupervisorsbtn.Name = "manageSupervisorsbtn";
            manageSupervisorsbtn.Size = new System.Drawing.Size(196, 36);
            manageSupervisorsbtn.TabIndex = 5;
            manageSupervisorsbtn.Text = "Manage Supervisors";
            manageSupervisorsbtn.UseVisualStyleBackColor = true;
            manageSupervisorsbtn.Click += manageSupervisorsbtn_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (System.Drawing.Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new System.Drawing.Point(1150, 5);
            pictureBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new System.Drawing.Size(186, 205);
            pictureBox4.TabIndex = 4;
            pictureBox4.TabStop = false;
            // 
            // listViewActivities
            // 
            listViewActivities.AllowDrop = true;
            listViewActivities.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { ActivityId, ActiviteitSoortActiviteit, ActiviteitBeginTijd, ActiviteitEindTijd, ActiviteitDatum });
            listViewActivities.FullRowSelect = true;
            listViewActivities.GridLines = true;
            listViewActivities.Location = new System.Drawing.Point(26, 71);
            listViewActivities.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            listViewActivities.Name = "listViewActivities";
            listViewActivities.Size = new System.Drawing.Size(1093, 509);
            listViewActivities.TabIndex = 1;
            listViewActivities.UseCompatibleStateImageBehavior = false;
            listViewActivities.View = System.Windows.Forms.View.Details;
            // 
            // ActivityId
            // 
            ActivityId.Text = "Id";
            // 
            // ActiviteitSoortActiviteit
            // 
            ActiviteitSoortActiviteit.Text = "Soort activiteit";
            ActiviteitSoortActiviteit.Width = 120;
            // 
            // ActiviteitBeginTijd
            // 
            ActiviteitBeginTijd.Text = "Begin tijd";
            ActiviteitBeginTijd.Width = 120;
            // 
            // ActiviteitEindTijd
            // 
            ActiviteitEindTijd.Text = "Eind Tijd";
            ActiviteitEindTijd.Width = 120;
            // 
            // ActiviteitDatum
            // 
            ActiviteitDatum.Text = "Datum";
            ActiviteitDatum.Width = 120;
            // 
            // labelActivities
            // 
            labelActivities.AutoSize = true;
            labelActivities.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelActivities.Location = new System.Drawing.Point(19, 11);
            labelActivities.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelActivities.Name = "labelActivities";
            labelActivities.Size = new System.Drawing.Size(162, 48);
            labelActivities.TabIndex = 0;
            labelActivities.Text = "Activities";
            // 
            // pnlRevenue
            // 
            pnlRevenue.Controls.Add(lblDateSelect);
            pnlRevenue.Controls.Add(btnSubmit);
            pnlRevenue.Controls.Add(lvRevenue);
            pnlRevenue.Controls.Add(lblEndDate);
            pnlRevenue.Controls.Add(lblStartDate);
            pnlRevenue.Controls.Add(dtpEndDate);
            pnlRevenue.Controls.Add(dtpStartDate);
            pnlRevenue.Controls.Add(lblRevenue);
            pnlRevenue.Controls.Add(pictureBox6);
            pnlRevenue.Location = new System.Drawing.Point(-14, 42);
            pnlRevenue.Margin = new System.Windows.Forms.Padding(2);
            pnlRevenue.Name = "pnlRevenue";
            pnlRevenue.Size = new System.Drawing.Size(1371, 709);
            pnlRevenue.TabIndex = 5;
            // 
            // lblDateSelect
            // 
            lblDateSelect.AutoSize = true;
            lblDateSelect.Location = new System.Drawing.Point(36, 186);
            lblDateSelect.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblDateSelect.Name = "lblDateSelect";
            lblDateSelect.Size = new System.Drawing.Size(0, 25);
            lblDateSelect.TabIndex = 13;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new System.Drawing.Point(28, 214);
            btnSubmit.Margin = new System.Windows.Forms.Padding(2);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new System.Drawing.Size(112, 34);
            btnSubmit.TabIndex = 12;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // lvRevenue
            // 
            lvRevenue.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { numberOfCustomers, sales, turnOver });
            lvRevenue.Location = new System.Drawing.Point(28, 259);
            lvRevenue.Margin = new System.Windows.Forms.Padding(2);
            lvRevenue.Name = "lvRevenue";
            lvRevenue.Size = new System.Drawing.Size(542, 432);
            lvRevenue.TabIndex = 11;
            lvRevenue.UseCompatibleStateImageBehavior = false;
            lvRevenue.View = System.Windows.Forms.View.Details;
            // 
            // numberOfCustomers
            // 
            numberOfCustomers.Text = "Customers";
            numberOfCustomers.Width = 150;
            // 
            // sales
            // 
            sales.Text = "Sales";
            sales.Width = 120;
            // 
            // turnOver
            // 
            turnOver.Text = "Turnover";
            turnOver.Width = 120;
            // 
            // lblEndDate
            // 
            lblEndDate.AutoSize = true;
            lblEndDate.Location = new System.Drawing.Point(28, 119);
            lblEndDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblEndDate.Name = "lblEndDate";
            lblEndDate.Size = new System.Drawing.Size(84, 25);
            lblEndDate.TabIndex = 10;
            lblEndDate.Text = "End Date";
            // 
            // lblStartDate
            // 
            lblStartDate.AutoSize = true;
            lblStartDate.Location = new System.Drawing.Point(28, 72);
            lblStartDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new System.Drawing.Size(90, 25);
            lblStartDate.TabIndex = 9;
            lblStartDate.Text = "Start Date";
            // 
            // dtpEndDate
            // 
            dtpEndDate.Location = new System.Drawing.Point(238, 114);
            dtpEndDate.Margin = new System.Windows.Forms.Padding(2);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new System.Drawing.Size(300, 31);
            dtpEndDate.TabIndex = 8;
            // 
            // dtpStartDate
            // 
            dtpStartDate.Location = new System.Drawing.Point(238, 66);
            dtpStartDate.Margin = new System.Windows.Forms.Padding(2);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new System.Drawing.Size(300, 31);
            dtpStartDate.TabIndex = 7;
            // 
            // lblRevenue
            // 
            lblRevenue.AutoSize = true;
            lblRevenue.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblRevenue.Location = new System.Drawing.Point(28, 20);
            lblRevenue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblRevenue.Name = "lblRevenue";
            lblRevenue.Size = new System.Drawing.Size(155, 48);
            lblRevenue.TabIndex = 6;
            lblRevenue.Text = "Revenue";
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (System.Drawing.Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new System.Drawing.Point(1158, 0);
            pictureBox6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new System.Drawing.Size(186, 205);
            pictureBox6.TabIndex = 5;
            pictureBox6.TabStop = false;
            // 
            // pnlStock
            // 
            pnlStock.Controls.Add(DrinksDeleteBtn);
            pnlStock.Controls.Add(DrinksEditBtn);
            pnlStock.Controls.Add(DrinksAddBtn);
            pnlStock.Controls.Add(pictureBoxStock);
            pnlStock.Controls.Add(listViewStock);
            pnlStock.Controls.Add(lblStock);
            pnlStock.Location = new System.Drawing.Point(9, 34);
            pnlStock.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            pnlStock.Name = "pnlStock";
            pnlStock.Size = new System.Drawing.Size(1154, 618);
            pnlStock.TabIndex = 6;
            // 
            // DrinksDeleteBtn
            // 
            DrinksDeleteBtn.Location = new System.Drawing.Point(920, 320);
            DrinksDeleteBtn.Margin = new System.Windows.Forms.Padding(2);
            DrinksDeleteBtn.Name = "DrinksDeleteBtn";
            DrinksDeleteBtn.Size = new System.Drawing.Size(106, 36);
            DrinksDeleteBtn.TabIndex = 7;
            DrinksDeleteBtn.Text = "Delete";
            DrinksDeleteBtn.UseVisualStyleBackColor = true;
            DrinksDeleteBtn.Click += DrinksDeleteBtn_Click;
            // 
            // DrinksEditBtn
            // 
            DrinksEditBtn.Location = new System.Drawing.Point(920, 279);
            DrinksEditBtn.Margin = new System.Windows.Forms.Padding(2);
            DrinksEditBtn.Name = "DrinksEditBtn";
            DrinksEditBtn.Size = new System.Drawing.Size(106, 36);
            DrinksEditBtn.TabIndex = 6;
            DrinksEditBtn.Text = "Edit";
            DrinksEditBtn.UseVisualStyleBackColor = true;
            DrinksEditBtn.Click += DrinksEditBtn_Click;
            // 
            // DrinksAddBtn
            // 
            DrinksAddBtn.Location = new System.Drawing.Point(920, 234);
            DrinksAddBtn.Margin = new System.Windows.Forms.Padding(2);
            DrinksAddBtn.Name = "DrinksAddBtn";
            DrinksAddBtn.Size = new System.Drawing.Size(106, 40);
            DrinksAddBtn.TabIndex = 5;
            DrinksAddBtn.Text = "Add";
            DrinksAddBtn.UseVisualStyleBackColor = true;
            DrinksAddBtn.Click += DrinksAddBtn_Click;
            // 
            // pictureBoxStock
            // 
            pictureBoxStock.Image = (System.Drawing.Image)resources.GetObject("pictureBoxStock.Image");
            pictureBoxStock.Location = new System.Drawing.Point(920, 9);
            pictureBoxStock.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            pictureBoxStock.Name = "pictureBoxStock";
            pictureBoxStock.Size = new System.Drawing.Size(149, 164);
            pictureBoxStock.TabIndex = 4;
            pictureBoxStock.TabStop = false;
            // 
            // listViewStock
            // 
            listViewStock.AllowDrop = true;
            listViewStock.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { StockId, StockName, StockPrice, StockType, StockStock, StockStatus });
            listViewStock.FullRowSelect = true;
            listViewStock.GridLines = true;
            listViewStock.Location = new System.Drawing.Point(18, 56);
            listViewStock.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            listViewStock.Name = "listViewStock";
            listViewStock.Size = new System.Drawing.Size(896, 422);
            listViewStock.TabIndex = 1;
            listViewStock.UseCompatibleStateImageBehavior = false;
            listViewStock.View = System.Windows.Forms.View.Details;
            // 
            // StockId
            // 
            StockId.Text = "Id";
            // 
            // StockName
            // 
            StockName.Text = "Name";
            StockName.Width = 120;
            // 
            // StockPrice
            // 
            StockPrice.Text = "Price";
            // 
            // StockType
            // 
            StockType.Text = "Type";
            StockType.Width = 120;
            // 
            // StockStock
            // 
            StockStock.Text = "Stock";
            StockStock.Width = 120;
            // 
            // StockStatus
            // 
            StockStatus.Text = "Status";
            StockStatus.Width = 200;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblStock.Location = new System.Drawing.Point(15, 9);
            lblStock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblStock.Name = "lblStock";
            lblStock.Size = new System.Drawing.Size(106, 48);
            lblStock.TabIndex = 0;
            lblStock.Text = "Stock";
            // 
            // SomerenUI
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1400, 879);
            Controls.Add(pnlStudents);
            Controls.Add(pnlActivities);
            Controls.Add(pnlOrders);
            Controls.Add(pnlLecturers);
            Controls.Add(pnlStock);
            Controls.Add(pnlVATReport);
            Controls.Add(pnlRooms);
            Controls.Add(menuStrip1);
            Controls.Add(pnlDashboard);
            Controls.Add(pnlRevenue);
            MainMenuStrip = menuStrip1;
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            Name = "SomerenUI";
            Text = "SomerenApp";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            pnlDashboard.ResumeLayout(false);
            pnlDashboard.PerformLayout();
            pnlStudents.ResumeLayout(false);
            pnlStudents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlOrders.ResumeLayout(false);
            pnlOrders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            pnlLecturers.ResumeLayout(false);
            pnlLecturers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            pnlVATReport.ResumeLayout(false);
            pnlVATReport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            pnlRooms.ResumeLayout(false);
            pnlRooms.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            pnlActivities.ResumeLayout(false);
            pnlActivities.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            pnlRevenue.ResumeLayout(false);
            pnlRevenue.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            pnlStock.ResumeLayout(false);
            pnlStock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxStock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lecturersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activitiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roomsToolStripMenuItem;
        private System.Windows.Forms.Panel pnlDashboard;
        private System.Windows.Forms.Label lblDashboard;
        private System.Windows.Forms.Panel pnlStudents;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView listViewStudents;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader idStudent;
        private System.Windows.Forms.ColumnHeader studentNummer;
        private System.Windows.Forms.ColumnHeader voornaam;
        private System.Windows.Forms.ColumnHeader achternaam;
        private System.Windows.Forms.ColumnHeader klas;
        private System.Windows.Forms.ColumnHeader telefoonnummer;
        private System.Windows.Forms.ColumnHeader kamernummer;
        private System.Windows.Forms.Panel pnlRooms;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ListView listViewRooms;
        private System.Windows.Forms.Label labelRooms;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader roomNumber;
        private System.Windows.Forms.ColumnHeader roomSize;
        private System.Windows.Forms.ColumnHeader roomType;
        private System.Windows.Forms.Panel pnlLecturers;
        private System.Windows.Forms.ListView listViewLecturers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader FirstName;
        private System.Windows.Forms.ColumnHeader LastName;
        private System.Windows.Forms.ColumnHeader TelephoneNumber;
        private System.Windows.Forms.ColumnHeader Age;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ColumnHeader lectureID;
        private System.Windows.Forms.ColumnHeader firstnameLecturer;
        private System.Windows.Forms.ColumnHeader lastNameLecturer;
        private System.Windows.Forms.ColumnHeader telephoneNumberL;
        private System.Windows.Forms.ColumnHeader AgeLecturer;
        private System.Windows.Forms.Panel pnlActivities;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.ListView listViewActivities;
        private System.Windows.Forms.ColumnHeader ActivityId;
        private System.Windows.Forms.ColumnHeader ActiviteitSoortActiviteit;
        private System.Windows.Forms.ColumnHeader ActiviteitBeginTijd;
        private System.Windows.Forms.ColumnHeader ActiviteitEindTijd;
        private System.Windows.Forms.Label labelActivities;
        private System.Windows.Forms.ColumnHeader ActiviteitDatum;
        private System.Windows.Forms.ToolStripMenuItem stockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem revenueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vATReportToolStripMenuItem;
        private System.Windows.Forms.Panel pnlVATReport;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.ListView listViewVATReport;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label VATReportlbl;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.TextBox textBoxQuarter;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.Label VATReportQuarterlbl;
        private System.Windows.Forms.Label VATReportYearlbl;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnlRevenue;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label lblRevenue;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.ListView lvRevenue;
        private System.Windows.Forms.ColumnHeader numberOfCustomers;
        private System.Windows.Forms.ColumnHeader sales;
        private System.Windows.Forms.ColumnHeader turnOver;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblDateSelect;
        private System.Windows.Forms.Panel pnlStock;
        private System.Windows.Forms.PictureBox pictureBoxStock;
        private System.Windows.Forms.ListView listViewStock;
        private System.Windows.Forms.ColumnHeader StockId;
        private System.Windows.Forms.ColumnHeader StockName;
        private System.Windows.Forms.ColumnHeader StockPrice;
        private System.Windows.Forms.ColumnHeader StockType;
        private System.Windows.Forms.ColumnHeader StockStock;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.ColumnHeader StockStatus;
        private System.Windows.Forms.Button DrinksDeleteBtn;
        private System.Windows.Forms.Button DrinksEditBtn;
        private System.Windows.Forms.Button DrinksAddBtn;
        private System.Windows.Forms.Panel pnlOrders;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboCount;
        private System.Windows.Forms.ComboBox comboDrinks;
        private System.Windows.Forms.ComboBox comboStudent;
        private System.Windows.Forms.Label orderCountlbl;
        private System.Windows.Forms.Label orderDrinklbl;
        private System.Windows.Forms.Label orderStudentlbl;
        private System.Windows.Forms.Button orderPlacebtn;
        private System.Windows.Forms.Label OrderTotalInputlbl;
        private System.Windows.Forms.Label OrderTotalPricelbl;
        private System.Windows.Forms.Button manageParticipantsbtn;
        private System.Windows.Forms.Button manageSupervisorsbtn;
        private System.Windows.Forms.Button btnDeleteLV;
        private System.Windows.Forms.Button btnEditLV;
        private System.Windows.Forms.Button btnAddLV;
    }
}
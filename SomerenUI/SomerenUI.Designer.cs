﻿using SomerenModel;
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
            pictureBox1 = new System.Windows.Forms.PictureBox();
            listViewStudents = new System.Windows.Forms.ListView();
            idStudent = new System.Windows.Forms.ColumnHeader();
            studentNummer = new System.Windows.Forms.ColumnHeader();
            voornaam = new System.Windows.Forms.ColumnHeader();
            achternaam = new System.Windows.Forms.ColumnHeader();
            klas = new System.Windows.Forms.ColumnHeader();
            telefoonnummer = new System.Windows.Forms.ColumnHeader();
            kamernummer = new System.Windows.Forms.ColumnHeader();
            label1 = new System.Windows.Forms.Label();
            pnlRooms = new System.Windows.Forms.Panel();
            pictureBox3 = new System.Windows.Forms.PictureBox();
            listViewRooms = new System.Windows.Forms.ListView();
            id = new System.Windows.Forms.ColumnHeader();
            roomNumber = new System.Windows.Forms.ColumnHeader();
            roomSize = new System.Windows.Forms.ColumnHeader();
            roomType = new System.Windows.Forms.ColumnHeader();
            labelRooms = new System.Windows.Forms.Label();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            pnlLecturers = new System.Windows.Forms.Panel();
            LecturersDeleteBtn = new System.Windows.Forms.Button();
            LecturersEditBtn = new System.Windows.Forms.Button();
            LecturersAddBtn = new System.Windows.Forms.Button();
            listViewLecturers = new System.Windows.Forms.ListView();
            lectureID = new System.Windows.Forms.ColumnHeader();
            firstnameLecturer = new System.Windows.Forms.ColumnHeader();
            lastNameLecturer = new System.Windows.Forms.ColumnHeader();
            telephoneNumberL = new System.Windows.Forms.ColumnHeader();
            AgeLecturer = new System.Windows.Forms.ColumnHeader();
            label2 = new System.Windows.Forms.Label();
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
            pnlStock = new System.Windows.Forms.Panel();
            DrinksDeleteBtn = new System.Windows.Forms.Button();
            DrinksEditBtn = new System.Windows.Forms.Button();
            DrinksAddBtn = new System.Windows.Forms.Button();
            pictureBoxStock = new System.Windows.Forms.PictureBox();
            listViewStock = new System.Windows.Forms.ListView();
            StockName = new System.Windows.Forms.ColumnHeader();
            StockPrice = new System.Windows.Forms.ColumnHeader();
            StockType = new System.Windows.Forms.ColumnHeader();
            StockStock = new System.Windows.Forms.ColumnHeader();
            StockStatus = new System.Windows.Forms.ColumnHeader();
            lblStock = new System.Windows.Forms.Label();
            Room = new System.Windows.Forms.ColumnHeader();
            menuStrip1.SuspendLayout();
            pnlDashboard.SuspendLayout();
            pnlStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlRooms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            pnlLecturers.SuspendLayout();
            pnlActivities.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            pnlVATReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            pnlRevenue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            pnlOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
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
            menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            menuStrip1.Size = new System.Drawing.Size(1120, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // dashboardToolStripMenuItem
            // 
            dashboardToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { dashboardToolStripMenuItem1, exitToolStripMenuItem });
            dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            dashboardToolStripMenuItem.Size = new System.Drawing.Size(100, 24);
            dashboardToolStripMenuItem.Text = "Application";
            // 
            // dashboardToolStripMenuItem1
            // 
            dashboardToolStripMenuItem1.Name = "dashboardToolStripMenuItem1";
            dashboardToolStripMenuItem1.Size = new System.Drawing.Size(165, 26);
            dashboardToolStripMenuItem1.Text = "Dashboard";
            dashboardToolStripMenuItem1.Click += dashboardToolStripMenuItem1_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // studentsToolStripMenuItem
            // 
            studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            studentsToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            studentsToolStripMenuItem.Text = "Students";
            studentsToolStripMenuItem.Click += studentsToolStripMenuItem_Click;
            // 
            // lecturersToolStripMenuItem
            // 
            lecturersToolStripMenuItem.Name = "lecturersToolStripMenuItem";
            lecturersToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            lecturersToolStripMenuItem.Text = "Lecturers";
            lecturersToolStripMenuItem.Click += lecturersToolStripMenuItem_Click;
            // 
            // activitiesToolStripMenuItem
            // 
            activitiesToolStripMenuItem.Name = "activitiesToolStripMenuItem";
            activitiesToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            activitiesToolStripMenuItem.Text = "Activities";
            activitiesToolStripMenuItem.Click += activitiesToolStripMenuItem_Click;
            // 
            // roomsToolStripMenuItem
            // 
            roomsToolStripMenuItem.Name = "roomsToolStripMenuItem";
            roomsToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            roomsToolStripMenuItem.Text = "Rooms";
            roomsToolStripMenuItem.Click += roomsToolStripMenuItem_Click;
            // 
            // stockToolStripMenuItem
            // 
            stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            stockToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            stockToolStripMenuItem.Text = "Stock";
            stockToolStripMenuItem.Click += stockToolStripMenuItem_Click;
            // 
            // ordersToolStripMenuItem
            // 
            ordersToolStripMenuItem.Name = "ordersToolStripMenuItem";
            ordersToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            ordersToolStripMenuItem.Text = "Orders";
            ordersToolStripMenuItem.Click += ordersToolStripMenuItem_Click;
            // 
            // revenueToolStripMenuItem
            // 
            revenueToolStripMenuItem.Name = "revenueToolStripMenuItem";
            revenueToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            revenueToolStripMenuItem.Text = "Revenue";
            revenueToolStripMenuItem.Click += revenueToolStripMenuItem_Click;
            // 
            // vATReportToolStripMenuItem
            // 
            vATReportToolStripMenuItem.Name = "vATReportToolStripMenuItem";
            vATReportToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            vATReportToolStripMenuItem.Text = "VAT Report";
            vATReportToolStripMenuItem.Click += vATReportToolStripMenuItem_Click;
            // 
            // pnlDashboard
            // 
            pnlDashboard.Controls.Add(lblDashboard);
            pnlDashboard.Location = new System.Drawing.Point(14, 36);
            pnlDashboard.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pnlDashboard.Name = "pnlDashboard";
            pnlDashboard.Size = new System.Drawing.Size(1072, 621);
            pnlDashboard.TabIndex = 1;
            // 
            // lblDashboard
            // 
            lblDashboard.AutoSize = true;
            lblDashboard.Location = new System.Drawing.Point(15, 17);
            lblDashboard.Name = "lblDashboard";
            lblDashboard.Size = new System.Drawing.Size(262, 20);
            lblDashboard.TabIndex = 0;
            lblDashboard.Text = "Welcome to the Someren Application!";
            // 
            // pnlStudents
            // 
            pnlStudents.Controls.Add(pictureBox1);
            pnlStudents.Controls.Add(listViewStudents);
            pnlStudents.Controls.Add(label1);
            pnlStudents.Location = new System.Drawing.Point(14, 36);
            pnlStudents.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pnlStudents.Name = "pnlStudents";
            pnlStudents.Size = new System.Drawing.Size(1072, 621);
            pnlStudents.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(920, 0);
            pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(149, 164);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // listViewStudents
            // 
            listViewStudents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { idStudent, studentNummer, voornaam, achternaam, klas, telefoonnummer, kamernummer });
            listViewStudents.Location = new System.Drawing.Point(18, 56);
            listViewStudents.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            listViewStudents.Name = "listViewStudents";
            listViewStudents.Size = new System.Drawing.Size(898, 526);
            listViewStudents.TabIndex = 1;
            listViewStudents.UseCompatibleStateImageBehavior = false;
            listViewStudents.View = System.Windows.Forms.View.Details;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(19, 12);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(134, 41);
            label1.TabIndex = 0;
            label1.Text = "Students";
            // 
            // pnlRooms
            // 
            pnlRooms.Controls.Add(pictureBox3);
            pnlRooms.Controls.Add(listViewRooms);
            pnlRooms.Controls.Add(labelRooms);
            pnlRooms.Location = new System.Drawing.Point(15, 36);
            pnlRooms.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pnlRooms.Name = "pnlRooms";
            pnlRooms.Size = new System.Drawing.Size(1072, 617);
            pnlRooms.TabIndex = 3;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (System.Drawing.Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new System.Drawing.Point(920, 9);
            pictureBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new System.Drawing.Size(149, 164);
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // listViewRooms
            // 
            listViewRooms.AllowDrop = true;
            listViewRooms.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { id, roomNumber, roomSize, roomType });
            listViewRooms.FullRowSelect = true;
            listViewRooms.GridLines = true;
            listViewRooms.Location = new System.Drawing.Point(18, 56);
            listViewRooms.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            listViewRooms.Name = "listViewRooms";
            listViewRooms.Size = new System.Drawing.Size(875, 408);
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
            labelRooms.Location = new System.Drawing.Point(15, 9);
            labelRooms.Name = "labelRooms";
            labelRooms.Size = new System.Drawing.Size(110, 41);
            labelRooms.TabIndex = 0;
            labelRooms.Text = "Rooms";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (System.Drawing.Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new System.Drawing.Point(920, 0);
            pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(149, 164);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // pnlLecturers
            // 
            pnlLecturers.Controls.Add(LecturersDeleteBtn);
            pnlLecturers.Controls.Add(LecturersEditBtn);
            pnlLecturers.Controls.Add(LecturersAddBtn);
            pnlLecturers.Controls.Add(pictureBox2);
            pnlLecturers.Controls.Add(listViewLecturers);
            pnlLecturers.Controls.Add(label2);
            pnlLecturers.Location = new System.Drawing.Point(14, 36);
            pnlLecturers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pnlLecturers.Name = "pnlLecturers";
            pnlLecturers.Size = new System.Drawing.Size(1072, 621);
            pnlLecturers.TabIndex = 3;
            // 
            // LecturersDeleteBtn
            // 
            LecturersDeleteBtn.Location = new System.Drawing.Point(924, 284);
            LecturersDeleteBtn.Name = "LecturersDeleteBtn";
            LecturersDeleteBtn.Size = new System.Drawing.Size(94, 29);
            LecturersDeleteBtn.TabIndex = 5;
            LecturersDeleteBtn.Text = "Delete";
            LecturersDeleteBtn.UseVisualStyleBackColor = true;
            LecturersDeleteBtn.Click += LecturersDeleteBtn_Click;
            // 
            // LecturersEditBtn
            // 
            LecturersEditBtn.Location = new System.Drawing.Point(924, 249);
            LecturersEditBtn.Name = "LecturersEditBtn";
            LecturersEditBtn.Size = new System.Drawing.Size(94, 29);
            LecturersEditBtn.TabIndex = 4;
            LecturersEditBtn.Text = "Edit";
            LecturersEditBtn.UseVisualStyleBackColor = true;
            LecturersEditBtn.Click += LecturersEditBtn_Click;
            // 
            // LecturersAddBtn
            // 
            LecturersAddBtn.Location = new System.Drawing.Point(924, 214);
            LecturersAddBtn.Name = "LecturersAddBtn";
            LecturersAddBtn.Size = new System.Drawing.Size(94, 29);
            LecturersAddBtn.TabIndex = 3;
            LecturersAddBtn.Text = "Add";
            LecturersAddBtn.UseVisualStyleBackColor = true;
            LecturersAddBtn.Click += LecturersAddBtn_Click;
            // 
            // listViewLecturers
            // 
            listViewLecturers.AllowDrop = true;
            listViewLecturers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { lectureID, firstnameLecturer, lastNameLecturer, telephoneNumberL, AgeLecturer, Room });
            listViewLecturers.FullRowSelect = true;
            listViewLecturers.GridLines = true;
            listViewLecturers.Location = new System.Drawing.Point(18, 56);
            listViewLecturers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            listViewLecturers.Name = "listViewLecturers";
            listViewLecturers.Size = new System.Drawing.Size(875, 408);
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(15, 9);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(138, 41);
            label2.TabIndex = 0;
            label2.Text = "Lecturers";
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
            pnlActivities.Location = new System.Drawing.Point(12, 34);
            pnlActivities.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pnlActivities.Name = "pnlActivities";
            pnlActivities.Size = new System.Drawing.Size(1072, 619);
            pnlActivities.TabIndex = 5;
            // 
            // manageParticipantsbtn
            // 
            manageParticipantsbtn.Location = new System.Drawing.Point(908, 216);
            manageParticipantsbtn.Name = "manageParticipantsbtn";
            manageParticipantsbtn.Size = new System.Drawing.Size(157, 29);
            manageParticipantsbtn.TabIndex = 6;
            manageParticipantsbtn.Text = "Manage Participants";
            manageParticipantsbtn.UseVisualStyleBackColor = true;
            manageParticipantsbtn.Click += manageParticipantsbtn_Click;
            // 
            // manageSupervisorsbtn
            // 
            manageSupervisorsbtn.Location = new System.Drawing.Point(908, 180);
            manageSupervisorsbtn.Name = "manageSupervisorsbtn";
            manageSupervisorsbtn.Size = new System.Drawing.Size(157, 29);
            manageSupervisorsbtn.TabIndex = 5;
            manageSupervisorsbtn.Text = "Manage Supervisors";
            manageSupervisorsbtn.UseVisualStyleBackColor = true;
            manageSupervisorsbtn.Click += manageSupervisorsbtn_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (System.Drawing.Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new System.Drawing.Point(920, 4);
            pictureBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new System.Drawing.Size(149, 164);
            pictureBox4.TabIndex = 4;
            pictureBox4.TabStop = false;
            // 
            // listViewActivities
            // 
            listViewActivities.AllowDrop = true;
            listViewActivities.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { ActivityId, ActiviteitSoortActiviteit, ActiviteitBeginTijd, ActiviteitEindTijd, ActiviteitDatum });
            listViewActivities.FullRowSelect = true;
            listViewActivities.GridLines = true;
            listViewActivities.Location = new System.Drawing.Point(21, 57);
            listViewActivities.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            listViewActivities.Name = "listViewActivities";
            listViewActivities.Size = new System.Drawing.Size(875, 408);
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
            labelActivities.Location = new System.Drawing.Point(15, 9);
            labelActivities.Name = "labelActivities";
            labelActivities.Size = new System.Drawing.Size(135, 41);
            labelActivities.TabIndex = 0;
            labelActivities.Text = "Activities";
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
            pnlVATReport.Location = new System.Drawing.Point(13, 31);
            pnlVATReport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pnlVATReport.Name = "pnlVATReport";
            pnlVATReport.Size = new System.Drawing.Size(1072, 651);
            pnlVATReport.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(153, 167);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(94, 29);
            button1.TabIndex = 9;
            button1.Text = "Calculate";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBoxQuarter
            // 
            textBoxQuarter.Location = new System.Drawing.Point(189, 115);
            textBoxQuarter.Name = "textBoxQuarter";
            textBoxQuarter.Size = new System.Drawing.Size(27, 27);
            textBoxQuarter.TabIndex = 8;
            // 
            // textBoxYear
            // 
            textBoxYear.Location = new System.Drawing.Point(189, 75);
            textBoxYear.Name = "textBoxYear";
            textBoxYear.Size = new System.Drawing.Size(58, 27);
            textBoxYear.TabIndex = 7;
            // 
            // VATReportQuarterlbl
            // 
            VATReportQuarterlbl.AutoSize = true;
            VATReportQuarterlbl.Location = new System.Drawing.Point(20, 118);
            VATReportQuarterlbl.Name = "VATReportQuarterlbl";
            VATReportQuarterlbl.Size = new System.Drawing.Size(121, 20);
            VATReportQuarterlbl.TabIndex = 6;
            VATReportQuarterlbl.Text = "Quarter number :";
            // 
            // VATReportYearlbl
            // 
            VATReportYearlbl.AutoSize = true;
            VATReportYearlbl.Location = new System.Drawing.Point(20, 75);
            VATReportYearlbl.Name = "VATReportYearlbl";
            VATReportYearlbl.Size = new System.Drawing.Size(44, 20);
            VATReportYearlbl.TabIndex = 5;
            VATReportYearlbl.Text = "Year :";
            // 
            // pictureBox8
            // 
            pictureBox8.Image = (System.Drawing.Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new System.Drawing.Point(920, 9);
            pictureBox8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new System.Drawing.Size(149, 164);
            pictureBox8.TabIndex = 4;
            pictureBox8.TabStop = false;
            // 
            // listViewVATReport
            // 
            listViewVATReport.AllowDrop = true;
            listViewVATReport.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7 });
            listViewVATReport.FullRowSelect = true;
            listViewVATReport.GridLines = true;
            listViewVATReport.Location = new System.Drawing.Point(20, 239);
            listViewVATReport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            listViewVATReport.Name = "listViewVATReport";
            listViewVATReport.Size = new System.Drawing.Size(916, 358);
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
            VATReportlbl.Location = new System.Drawing.Point(15, 9);
            VATReportlbl.Name = "VATReportlbl";
            VATReportlbl.Size = new System.Drawing.Size(165, 41);
            VATReportlbl.TabIndex = 0;
            VATReportlbl.Text = "VAT Report";
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
            pnlRevenue.Location = new System.Drawing.Point(12, 34);
            pnlRevenue.Margin = new System.Windows.Forms.Padding(2);
            pnlRevenue.Name = "pnlRevenue";
            pnlRevenue.Size = new System.Drawing.Size(1097, 567);
            pnlRevenue.TabIndex = 5;
            // 
            // lblDateSelect
            // 
            lblDateSelect.AutoSize = true;
            lblDateSelect.Location = new System.Drawing.Point(29, 149);
            lblDateSelect.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblDateSelect.Name = "lblDateSelect";
            lblDateSelect.Size = new System.Drawing.Size(0, 20);
            lblDateSelect.TabIndex = 13;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new System.Drawing.Point(22, 171);
            btnSubmit.Margin = new System.Windows.Forms.Padding(2);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new System.Drawing.Size(90, 27);
            btnSubmit.TabIndex = 12;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // lvRevenue
            // 
            lvRevenue.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { numberOfCustomers, sales, turnOver });
            lvRevenue.Location = new System.Drawing.Point(22, 207);
            lvRevenue.Margin = new System.Windows.Forms.Padding(2);
            lvRevenue.Name = "lvRevenue";
            lvRevenue.Size = new System.Drawing.Size(434, 346);
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
            lblEndDate.Location = new System.Drawing.Point(22, 95);
            lblEndDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblEndDate.Name = "lblEndDate";
            lblEndDate.Size = new System.Drawing.Size(70, 20);
            lblEndDate.TabIndex = 10;
            lblEndDate.Text = "End Date";
            // 
            // lblStartDate
            // 
            lblStartDate.AutoSize = true;
            lblStartDate.Location = new System.Drawing.Point(22, 58);
            lblStartDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new System.Drawing.Size(76, 20);
            lblStartDate.TabIndex = 9;
            lblStartDate.Text = "Start Date";
            // 
            // dtpEndDate
            // 
            dtpEndDate.Location = new System.Drawing.Point(190, 91);
            dtpEndDate.Margin = new System.Windows.Forms.Padding(2);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new System.Drawing.Size(241, 27);
            dtpEndDate.TabIndex = 8;
            // 
            // dtpStartDate
            // 
            dtpStartDate.Location = new System.Drawing.Point(190, 53);
            dtpStartDate.Margin = new System.Windows.Forms.Padding(2);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new System.Drawing.Size(241, 27);
            dtpStartDate.TabIndex = 7;
            // 
            // lblRevenue
            // 
            lblRevenue.AutoSize = true;
            lblRevenue.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblRevenue.Location = new System.Drawing.Point(22, 16);
            lblRevenue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblRevenue.Name = "lblRevenue";
            lblRevenue.Size = new System.Drawing.Size(131, 41);
            lblRevenue.TabIndex = 6;
            lblRevenue.Text = "Revenue";
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (System.Drawing.Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new System.Drawing.Point(926, 0);
            pictureBox6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new System.Drawing.Size(149, 164);
            pictureBox6.TabIndex = 5;
            pictureBox6.TabStop = false;
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
            pnlOrders.Location = new System.Drawing.Point(14, 27);
            pnlOrders.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            pnlOrders.Name = "pnlOrders";
            pnlOrders.Size = new System.Drawing.Size(901, 459);
            pnlOrders.TabIndex = 8;
            // 
            // OrderTotalInputlbl
            // 
            OrderTotalInputlbl.AutoSize = true;
            OrderTotalInputlbl.Location = new System.Drawing.Point(500, 130);
            OrderTotalInputlbl.Name = "OrderTotalInputlbl";
            OrderTotalInputlbl.Size = new System.Drawing.Size(36, 20);
            OrderTotalInputlbl.TabIndex = 13;
            OrderTotalInputlbl.Text = "0.00";
            // 
            // OrderTotalPricelbl
            // 
            OrderTotalPricelbl.AutoSize = true;
            OrderTotalPricelbl.Location = new System.Drawing.Point(446, 130);
            OrderTotalPricelbl.Name = "OrderTotalPricelbl";
            OrderTotalPricelbl.Size = new System.Drawing.Size(53, 20);
            OrderTotalPricelbl.TabIndex = 12;
            OrderTotalPricelbl.Text = "Totaal:";
            // 
            // orderPlacebtn
            // 
            orderPlacebtn.Location = new System.Drawing.Point(626, 81);
            orderPlacebtn.Margin = new System.Windows.Forms.Padding(2);
            orderPlacebtn.Name = "orderPlacebtn";
            orderPlacebtn.Size = new System.Drawing.Size(87, 29);
            orderPlacebtn.TabIndex = 11;
            orderPlacebtn.Text = "Place Order";
            orderPlacebtn.UseVisualStyleBackColor = true;
            orderPlacebtn.Click += orderPlacebtn_Click;
            // 
            // comboCount
            // 
            comboCount.FormattingEnabled = true;
            comboCount.Location = new System.Drawing.Point(500, 81);
            comboCount.Margin = new System.Windows.Forms.Padding(2);
            comboCount.Name = "comboCount";
            comboCount.Size = new System.Drawing.Size(122, 28);
            comboCount.TabIndex = 10;
            comboCount.SelectedIndexChanged += comboCount_SelectedIndexChanged;
            // 
            // comboDrinks
            // 
            comboDrinks.FormattingEnabled = true;
            comboDrinks.Location = new System.Drawing.Point(318, 82);
            comboDrinks.Margin = new System.Windows.Forms.Padding(2);
            comboDrinks.Name = "comboDrinks";
            comboDrinks.Size = new System.Drawing.Size(122, 28);
            comboDrinks.TabIndex = 9;
            comboDrinks.SelectedIndexChanged += comboDrinks_SelectedIndexChanged;
            // 
            // comboStudent
            // 
            comboStudent.FormattingEnabled = true;
            comboStudent.Location = new System.Drawing.Point(70, 82);
            comboStudent.Margin = new System.Windows.Forms.Padding(2);
            comboStudent.Name = "comboStudent";
            comboStudent.Size = new System.Drawing.Size(157, 28);
            comboStudent.TabIndex = 8;
            // 
            // orderCountlbl
            // 
            orderCountlbl.AutoSize = true;
            orderCountlbl.Location = new System.Drawing.Point(444, 85);
            orderCountlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            orderCountlbl.Name = "orderCountlbl";
            orderCountlbl.Size = new System.Drawing.Size(52, 20);
            orderCountlbl.TabIndex = 7;
            orderCountlbl.Text = "Aantal";
            // 
            // orderDrinklbl
            // 
            orderDrinklbl.AutoSize = true;
            orderDrinklbl.Location = new System.Drawing.Point(231, 84);
            orderDrinklbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            orderDrinklbl.Name = "orderDrinklbl";
            orderDrinklbl.Size = new System.Drawing.Size(88, 20);
            orderDrinklbl.TabIndex = 6;
            orderDrinklbl.Text = "Soort Drank";
            // 
            // orderStudentlbl
            // 
            orderStudentlbl.AutoSize = true;
            orderStudentlbl.Location = new System.Drawing.Point(5, 85);
            orderStudentlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            orderStudentlbl.Name = "orderStudentlbl";
            orderStudentlbl.Size = new System.Drawing.Size(60, 20);
            orderStudentlbl.TabIndex = 5;
            orderStudentlbl.Text = "Student";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (System.Drawing.Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new System.Drawing.Point(736, 7);
            pictureBox5.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new System.Drawing.Size(137, 131);
            pictureBox5.TabIndex = 4;
            pictureBox5.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(12, 7);
            label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(108, 41);
            label3.TabIndex = 0;
            label3.Text = "Orders";
            // 
            // pnlStock
            // 
            pnlStock.Controls.Add(DrinksDeleteBtn);
            pnlStock.Controls.Add(DrinksEditBtn);
            pnlStock.Controls.Add(DrinksAddBtn);
            pnlStock.Controls.Add(pictureBoxStock);
            pnlStock.Controls.Add(listViewStock);
            pnlStock.Controls.Add(lblStock);
            pnlStock.Location = new System.Drawing.Point(7, 27);
            pnlStock.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            pnlStock.Name = "pnlStock";
            pnlStock.Size = new System.Drawing.Size(923, 494);
            pnlStock.TabIndex = 6;
            // 
            // DrinksDeleteBtn
            // 
            DrinksDeleteBtn.Location = new System.Drawing.Point(736, 256);
            DrinksDeleteBtn.Margin = new System.Windows.Forms.Padding(2);
            DrinksDeleteBtn.Name = "DrinksDeleteBtn";
            DrinksDeleteBtn.Size = new System.Drawing.Size(85, 29);
            DrinksDeleteBtn.TabIndex = 7;
            DrinksDeleteBtn.Text = "Delete";
            DrinksDeleteBtn.UseVisualStyleBackColor = true;
            DrinksDeleteBtn.Click += DrinksDeleteBtn_Click;
            // 
            // DrinksEditBtn
            // 
            DrinksEditBtn.Location = new System.Drawing.Point(736, 223);
            DrinksEditBtn.Margin = new System.Windows.Forms.Padding(2);
            DrinksEditBtn.Name = "DrinksEditBtn";
            DrinksEditBtn.Size = new System.Drawing.Size(85, 29);
            DrinksEditBtn.TabIndex = 6;
            DrinksEditBtn.Text = "Edit";
            DrinksEditBtn.UseVisualStyleBackColor = true;
            DrinksEditBtn.Click += DrinksEditBtn_Click;
            // 
            // DrinksAddBtn
            // 
            DrinksAddBtn.Location = new System.Drawing.Point(736, 187);
            DrinksAddBtn.Margin = new System.Windows.Forms.Padding(2);
            DrinksAddBtn.Name = "DrinksAddBtn";
            DrinksAddBtn.Size = new System.Drawing.Size(85, 32);
            DrinksAddBtn.TabIndex = 5;
            DrinksAddBtn.Text = "Add";
            DrinksAddBtn.UseVisualStyleBackColor = true;
            DrinksAddBtn.Click += DrinksAddBtn_Click;
            // 
            // pictureBoxStock
            // 
            pictureBoxStock.Image = (System.Drawing.Image)resources.GetObject("pictureBoxStock.Image");
            pictureBoxStock.Location = new System.Drawing.Point(736, 7);
            pictureBoxStock.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            pictureBoxStock.Name = "pictureBoxStock";
            pictureBoxStock.Size = new System.Drawing.Size(119, 131);
            pictureBoxStock.TabIndex = 4;
            pictureBoxStock.TabStop = false;
            // 
            // listViewStock
            // 
            listViewStock.AllowDrop = true;
            listViewStock.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { StockName, StockPrice, StockType, StockStock, StockStatus });
            listViewStock.FullRowSelect = true;
            listViewStock.GridLines = true;
            listViewStock.Location = new System.Drawing.Point(14, 45);
            listViewStock.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            listViewStock.Name = "listViewStock";
            listViewStock.Size = new System.Drawing.Size(718, 338);
            listViewStock.TabIndex = 1;
            listViewStock.UseCompatibleStateImageBehavior = false;
            listViewStock.View = System.Windows.Forms.View.Details;
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
            lblStock.Location = new System.Drawing.Point(12, 7);
            lblStock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblStock.Name = "lblStock";
            lblStock.Size = new System.Drawing.Size(90, 41);
            lblStock.TabIndex = 0;
            lblStock.Text = "Stock";
            // 
            // Room
            // 
            Room.Text = "Room";
            // 
            // SomerenUI
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1120, 703);
            Controls.Add(pnlStock);
            Controls.Add(pnlLecturers);
            Controls.Add(pnlActivities);
            Controls.Add(pnlVATReport);
            Controls.Add(pnlOrders);
            Controls.Add(pnlRevenue);
            Controls.Add(pnlRooms);
            Controls.Add(menuStrip1);
            Controls.Add(pnlStudents);
            Controls.Add(pnlDashboard);
            MainMenuStrip = menuStrip1;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "SomerenUI";
            Text = "SomerenApp";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            pnlDashboard.ResumeLayout(false);
            pnlDashboard.PerformLayout();
            pnlStudents.ResumeLayout(false);
            pnlStudents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlRooms.ResumeLayout(false);
            pnlRooms.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            pnlLecturers.ResumeLayout(false);
            pnlLecturers.PerformLayout();
            pnlActivities.ResumeLayout(false);
            pnlActivities.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            pnlVATReport.ResumeLayout(false);
            pnlVATReport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            pnlRevenue.ResumeLayout(false);
            pnlRevenue.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            pnlOrders.ResumeLayout(false);
            pnlOrders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
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
        private System.Windows.Forms.Button LecturersDeleteBtn;
        private System.Windows.Forms.Button LecturersEditBtn;
        private System.Windows.Forms.Button LecturersAddBtn;
        private System.Windows.Forms.ColumnHeader Room;
    }
}
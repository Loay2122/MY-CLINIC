namespace MY_CLINIC
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnSignOut = new System.Windows.Forms.Button();
            this.BtnHelp = new System.Windows.Forms.Button();
            this.panelSettingsSubMenu = new System.Windows.Forms.Panel();
            this.BtnWorkExpenses = new System.Windows.Forms.Button();
            this.BtnWorkHours = new System.Windows.Forms.Button();
            this.BtnWorkSettings = new System.Windows.Forms.Button();
            this.panelReportSubMenu = new System.Windows.Forms.Panel();
            this.BtnQuarter = new System.Windows.Forms.Button();
            this.BtnMonthly = new System.Windows.Forms.Button();
            this.BtnWeekly = new System.Windows.Forms.Button();
            this.BtnFinancialReport = new System.Windows.Forms.Button();
            this.panelEmpSubMenu = new System.Windows.Forms.Panel();
            this.BtnShowEmp = new System.Windows.Forms.Button();
            this.BtnAddEmp = new System.Windows.Forms.Button();
            this.BtnManageEmp = new System.Windows.Forms.Button();
            this.panelAppointmentSubMenu = new System.Windows.Forms.Panel();
            this.BtnAppointmentSchedule = new System.Windows.Forms.Button();
            this.BtnAddAppointment = new System.Windows.Forms.Button();
            this.BtnShowPatient = new System.Windows.Forms.Button();
            this.BtnAddPatient = new System.Windows.Forms.Button();
            this.BtnAppointmentSubMenu = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.labelMsg = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelSideMenu.SuspendLayout();
            this.panelFooter.SuspendLayout();
            this.panelSettingsSubMenu.SuspendLayout();
            this.panelReportSubMenu.SuspendLayout();
            this.panelEmpSubMenu.SuspendLayout();
            this.panelAppointmentSubMenu.SuspendLayout();
            this.panelChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelSideMenu.Controls.Add(this.panelFooter);
            this.panelSideMenu.Controls.Add(this.BtnHelp);
            this.panelSideMenu.Controls.Add(this.panelSettingsSubMenu);
            this.panelSideMenu.Controls.Add(this.BtnWorkSettings);
            this.panelSideMenu.Controls.Add(this.panelReportSubMenu);
            this.panelSideMenu.Controls.Add(this.BtnFinancialReport);
            this.panelSideMenu.Controls.Add(this.panelEmpSubMenu);
            this.panelSideMenu.Controls.Add(this.BtnManageEmp);
            this.panelSideMenu.Controls.Add(this.panelAppointmentSubMenu);
            this.panelSideMenu.Controls.Add(this.BtnAppointmentSubMenu);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(246, 553);
            this.panelSideMenu.TabIndex = 0;
            // 
            // panelFooter
            // 
            this.panelFooter.Controls.Add(this.BtnExit);
            this.panelFooter.Controls.Add(this.BtnSignOut);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 700);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(225, 67);
            this.panelFooter.TabIndex = 10;
            // 
            // BtnExit
            // 
            this.BtnExit.BackgroundImage = global::MY_CLINIC.Properties.Resources._292_2924736_logout_icon_png_blue;
            this.BtnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnExit.Location = new System.Drawing.Point(139, 5);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(59, 45);
            this.BtnExit.TabIndex = 10;
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnSignOut
            // 
            this.BtnSignOut.BackgroundImage = global::MY_CLINIC.Properties.Resources.log_out_icon_5;
            this.BtnSignOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSignOut.Location = new System.Drawing.Point(46, 5);
            this.BtnSignOut.Name = "BtnSignOut";
            this.BtnSignOut.Size = new System.Drawing.Size(59, 45);
            this.BtnSignOut.TabIndex = 9;
            this.BtnSignOut.UseVisualStyleBackColor = true;
            this.BtnSignOut.Click += new System.EventHandler(this.BtnSignOut_Click);
            // 
            // BtnHelp
            // 
            this.BtnHelp.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnHelp.FlatAppearance.BorderSize = 0;
            this.BtnHelp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.BtnHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.BtnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHelp.ForeColor = System.Drawing.Color.SteelBlue;
            this.BtnHelp.Location = new System.Drawing.Point(0, 653);
            this.BtnHelp.Name = "BtnHelp";
            this.BtnHelp.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnHelp.Size = new System.Drawing.Size(225, 47);
            this.BtnHelp.TabIndex = 8;
            this.BtnHelp.Text = "Help";
            this.BtnHelp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnHelp.UseVisualStyleBackColor = true;
            this.BtnHelp.Click += new System.EventHandler(this.BtnHelp_Click);
            // 
            // panelSettingsSubMenu
            // 
            this.panelSettingsSubMenu.BackColor = System.Drawing.Color.SteelBlue;
            this.panelSettingsSubMenu.Controls.Add(this.BtnWorkExpenses);
            this.panelSettingsSubMenu.Controls.Add(this.BtnWorkHours);
            this.panelSettingsSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSettingsSubMenu.Location = new System.Drawing.Point(0, 590);
            this.panelSettingsSubMenu.Name = "panelSettingsSubMenu";
            this.panelSettingsSubMenu.Size = new System.Drawing.Size(225, 63);
            this.panelSettingsSubMenu.TabIndex = 7;
            this.panelSettingsSubMenu.Visible = false;
            // 
            // BtnWorkExpenses
            // 
            this.BtnWorkExpenses.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnWorkExpenses.FlatAppearance.BorderSize = 0;
            this.BtnWorkExpenses.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnWorkExpenses.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnWorkExpenses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnWorkExpenses.Location = new System.Drawing.Point(0, 35);
            this.BtnWorkExpenses.Name = "BtnWorkExpenses";
            this.BtnWorkExpenses.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.BtnWorkExpenses.Size = new System.Drawing.Size(225, 29);
            this.BtnWorkExpenses.TabIndex = 1;
            this.BtnWorkExpenses.Text = "Set Work Expenses";
            this.BtnWorkExpenses.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnWorkExpenses.UseVisualStyleBackColor = true;
            this.BtnWorkExpenses.Click += new System.EventHandler(this.BtnWorkExpenses_Click);
            // 
            // BtnWorkHours
            // 
            this.BtnWorkHours.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnWorkHours.FlatAppearance.BorderSize = 0;
            this.BtnWorkHours.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnWorkHours.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnWorkHours.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnWorkHours.Location = new System.Drawing.Point(0, 0);
            this.BtnWorkHours.Name = "BtnWorkHours";
            this.BtnWorkHours.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.BtnWorkHours.Size = new System.Drawing.Size(225, 35);
            this.BtnWorkHours.TabIndex = 0;
            this.BtnWorkHours.Text = "Set Work Hours";
            this.BtnWorkHours.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnWorkHours.UseVisualStyleBackColor = true;
            this.BtnWorkHours.Click += new System.EventHandler(this.BtnWorkHours_Click);
            // 
            // BtnWorkSettings
            // 
            this.BtnWorkSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnWorkSettings.FlatAppearance.BorderSize = 0;
            this.BtnWorkSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.BtnWorkSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.BtnWorkSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnWorkSettings.ForeColor = System.Drawing.Color.SteelBlue;
            this.BtnWorkSettings.Location = new System.Drawing.Point(0, 539);
            this.BtnWorkSettings.Name = "BtnWorkSettings";
            this.BtnWorkSettings.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnWorkSettings.Size = new System.Drawing.Size(225, 51);
            this.BtnWorkSettings.TabIndex = 6;
            this.BtnWorkSettings.Text = "Work Settings";
            this.BtnWorkSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnWorkSettings.UseVisualStyleBackColor = true;
            this.BtnWorkSettings.Click += new System.EventHandler(this.BtnWorkSettings_Click);
            // 
            // panelReportSubMenu
            // 
            this.panelReportSubMenu.BackColor = System.Drawing.Color.SteelBlue;
            this.panelReportSubMenu.Controls.Add(this.BtnQuarter);
            this.panelReportSubMenu.Controls.Add(this.BtnMonthly);
            this.panelReportSubMenu.Controls.Add(this.BtnWeekly);
            this.panelReportSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelReportSubMenu.Location = new System.Drawing.Point(0, 439);
            this.panelReportSubMenu.Name = "panelReportSubMenu";
            this.panelReportSubMenu.Size = new System.Drawing.Size(225, 100);
            this.panelReportSubMenu.TabIndex = 5;
            this.panelReportSubMenu.Visible = false;
            // 
            // BtnQuarter
            // 
            this.BtnQuarter.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnQuarter.FlatAppearance.BorderSize = 0;
            this.BtnQuarter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnQuarter.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnQuarter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnQuarter.Location = new System.Drawing.Point(0, 68);
            this.BtnQuarter.Name = "BtnQuarter";
            this.BtnQuarter.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.BtnQuarter.Size = new System.Drawing.Size(225, 33);
            this.BtnQuarter.TabIndex = 2;
            this.BtnQuarter.Text = "Quarter Annual Report";
            this.BtnQuarter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnQuarter.UseVisualStyleBackColor = true;
            // 
            // BtnMonthly
            // 
            this.BtnMonthly.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnMonthly.FlatAppearance.BorderSize = 0;
            this.BtnMonthly.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnMonthly.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnMonthly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMonthly.Location = new System.Drawing.Point(0, 35);
            this.BtnMonthly.Name = "BtnMonthly";
            this.BtnMonthly.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.BtnMonthly.Size = new System.Drawing.Size(225, 33);
            this.BtnMonthly.TabIndex = 1;
            this.BtnMonthly.Text = "Monthly Report";
            this.BtnMonthly.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMonthly.UseVisualStyleBackColor = true;
            // 
            // BtnWeekly
            // 
            this.BtnWeekly.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnWeekly.FlatAppearance.BorderSize = 0;
            this.BtnWeekly.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnWeekly.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnWeekly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnWeekly.Location = new System.Drawing.Point(0, 0);
            this.BtnWeekly.Name = "BtnWeekly";
            this.BtnWeekly.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.BtnWeekly.Size = new System.Drawing.Size(225, 35);
            this.BtnWeekly.TabIndex = 0;
            this.BtnWeekly.Text = "Weekly Report";
            this.BtnWeekly.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnWeekly.UseVisualStyleBackColor = true;
            // 
            // BtnFinancialReport
            // 
            this.BtnFinancialReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnFinancialReport.FlatAppearance.BorderSize = 0;
            this.BtnFinancialReport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.BtnFinancialReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.BtnFinancialReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFinancialReport.ForeColor = System.Drawing.Color.SteelBlue;
            this.BtnFinancialReport.Location = new System.Drawing.Point(0, 388);
            this.BtnFinancialReport.Name = "BtnFinancialReport";
            this.BtnFinancialReport.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnFinancialReport.Size = new System.Drawing.Size(225, 51);
            this.BtnFinancialReport.TabIndex = 4;
            this.BtnFinancialReport.Text = "Financial Reports";
            this.BtnFinancialReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnFinancialReport.UseVisualStyleBackColor = true;
            this.BtnFinancialReport.Click += new System.EventHandler(this.BtnFinancialReport_Click);
            // 
            // panelEmpSubMenu
            // 
            this.panelEmpSubMenu.BackColor = System.Drawing.Color.SteelBlue;
            this.panelEmpSubMenu.Controls.Add(this.BtnShowEmp);
            this.panelEmpSubMenu.Controls.Add(this.BtnAddEmp);
            this.panelEmpSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEmpSubMenu.Location = new System.Drawing.Point(0, 325);
            this.panelEmpSubMenu.Name = "panelEmpSubMenu";
            this.panelEmpSubMenu.Size = new System.Drawing.Size(225, 63);
            this.panelEmpSubMenu.TabIndex = 3;
            this.panelEmpSubMenu.Visible = false;
            // 
            // BtnShowEmp
            // 
            this.BtnShowEmp.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnShowEmp.FlatAppearance.BorderSize = 0;
            this.BtnShowEmp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnShowEmp.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnShowEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnShowEmp.Location = new System.Drawing.Point(0, 35);
            this.BtnShowEmp.Name = "BtnShowEmp";
            this.BtnShowEmp.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.BtnShowEmp.Size = new System.Drawing.Size(225, 29);
            this.BtnShowEmp.TabIndex = 1;
            this.BtnShowEmp.Text = "Show Employees";
            this.BtnShowEmp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnShowEmp.UseVisualStyleBackColor = true;
            // 
            // BtnAddEmp
            // 
            this.BtnAddEmp.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnAddEmp.FlatAppearance.BorderSize = 0;
            this.BtnAddEmp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnAddEmp.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnAddEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddEmp.Location = new System.Drawing.Point(0, 0);
            this.BtnAddEmp.Name = "BtnAddEmp";
            this.BtnAddEmp.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.BtnAddEmp.Size = new System.Drawing.Size(225, 35);
            this.BtnAddEmp.TabIndex = 0;
            this.BtnAddEmp.Text = "Add Employee";
            this.BtnAddEmp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAddEmp.UseVisualStyleBackColor = true;
            this.BtnAddEmp.Click += new System.EventHandler(this.BtnAddEmp_Click_1);
            // 
            // BtnManageEmp
            // 
            this.BtnManageEmp.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnManageEmp.FlatAppearance.BorderSize = 0;
            this.BtnManageEmp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.BtnManageEmp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.BtnManageEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnManageEmp.ForeColor = System.Drawing.Color.SteelBlue;
            this.BtnManageEmp.Location = new System.Drawing.Point(0, 274);
            this.BtnManageEmp.Name = "BtnManageEmp";
            this.BtnManageEmp.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnManageEmp.Size = new System.Drawing.Size(225, 51);
            this.BtnManageEmp.TabIndex = 2;
            this.BtnManageEmp.Text = "Manage Employees";
            this.BtnManageEmp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnManageEmp.UseVisualStyleBackColor = true;
            this.BtnManageEmp.Click += new System.EventHandler(this.BtnAddEmp_Click);
            // 
            // panelAppointmentSubMenu
            // 
            this.panelAppointmentSubMenu.BackColor = System.Drawing.Color.SteelBlue;
            this.panelAppointmentSubMenu.Controls.Add(this.BtnAppointmentSchedule);
            this.panelAppointmentSubMenu.Controls.Add(this.BtnAddAppointment);
            this.panelAppointmentSubMenu.Controls.Add(this.BtnShowPatient);
            this.panelAppointmentSubMenu.Controls.Add(this.BtnAddPatient);
            this.panelAppointmentSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAppointmentSubMenu.Location = new System.Drawing.Point(0, 158);
            this.panelAppointmentSubMenu.Name = "panelAppointmentSubMenu";
            this.panelAppointmentSubMenu.Size = new System.Drawing.Size(225, 116);
            this.panelAppointmentSubMenu.TabIndex = 1;
            this.panelAppointmentSubMenu.Visible = false;
            // 
            // BtnAppointmentSchedule
            // 
            this.BtnAppointmentSchedule.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnAppointmentSchedule.FlatAppearance.BorderSize = 0;
            this.BtnAppointmentSchedule.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnAppointmentSchedule.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnAppointmentSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAppointmentSchedule.Location = new System.Drawing.Point(0, 86);
            this.BtnAppointmentSchedule.Name = "BtnAppointmentSchedule";
            this.BtnAppointmentSchedule.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.BtnAppointmentSchedule.Size = new System.Drawing.Size(225, 29);
            this.BtnAppointmentSchedule.TabIndex = 6;
            this.BtnAppointmentSchedule.Text = "Appointment Schedule";
            this.BtnAppointmentSchedule.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAppointmentSchedule.UseVisualStyleBackColor = true;
            // 
            // BtnAddAppointment
            // 
            this.BtnAddAppointment.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnAddAppointment.FlatAppearance.BorderSize = 0;
            this.BtnAddAppointment.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnAddAppointment.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnAddAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddAppointment.Location = new System.Drawing.Point(0, 59);
            this.BtnAddAppointment.Name = "BtnAddAppointment";
            this.BtnAddAppointment.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.BtnAddAppointment.Size = new System.Drawing.Size(225, 27);
            this.BtnAddAppointment.TabIndex = 5;
            this.BtnAddAppointment.Text = "Add Appointment";
            this.BtnAddAppointment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAddAppointment.UseVisualStyleBackColor = true;
            this.BtnAddAppointment.Click += new System.EventHandler(this.BtnAddAppointment_Click);
            // 
            // BtnShowPatient
            // 
            this.BtnShowPatient.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnShowPatient.FlatAppearance.BorderSize = 0;
            this.BtnShowPatient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnShowPatient.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnShowPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnShowPatient.Location = new System.Drawing.Point(0, 28);
            this.BtnShowPatient.Name = "BtnShowPatient";
            this.BtnShowPatient.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.BtnShowPatient.Size = new System.Drawing.Size(225, 31);
            this.BtnShowPatient.TabIndex = 3;
            this.BtnShowPatient.Text = "Show Patients";
            this.BtnShowPatient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnShowPatient.UseVisualStyleBackColor = true;
            // 
            // BtnAddPatient
            // 
            this.BtnAddPatient.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnAddPatient.FlatAppearance.BorderSize = 0;
            this.BtnAddPatient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnAddPatient.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnAddPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddPatient.Location = new System.Drawing.Point(0, 0);
            this.BtnAddPatient.Name = "BtnAddPatient";
            this.BtnAddPatient.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.BtnAddPatient.Size = new System.Drawing.Size(225, 28);
            this.BtnAddPatient.TabIndex = 0;
            this.BtnAddPatient.Text = "Add Patient";
            this.BtnAddPatient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAddPatient.UseVisualStyleBackColor = true;
            this.BtnAddPatient.Click += new System.EventHandler(this.BtnAddPatient_Click);
            // 
            // BtnAppointmentSubMenu
            // 
            this.BtnAppointmentSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnAppointmentSubMenu.FlatAppearance.BorderSize = 0;
            this.BtnAppointmentSubMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.BtnAppointmentSubMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.BtnAppointmentSubMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAppointmentSubMenu.ForeColor = System.Drawing.Color.SteelBlue;
            this.BtnAppointmentSubMenu.Location = new System.Drawing.Point(0, 107);
            this.BtnAppointmentSubMenu.Name = "BtnAppointmentSubMenu";
            this.BtnAppointmentSubMenu.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnAppointmentSubMenu.Size = new System.Drawing.Size(225, 51);
            this.BtnAppointmentSubMenu.TabIndex = 0;
            this.BtnAppointmentSubMenu.Text = "Manage Appointments";
            this.BtnAppointmentSubMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAppointmentSubMenu.UseVisualStyleBackColor = true;
            this.BtnAppointmentSubMenu.Click += new System.EventHandler(this.BtnAppointmentSubMenu_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackgroundImage = global::MY_CLINIC.Properties.Resources.logo1;
            this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(225, 107);
            this.panelLogo.TabIndex = 0;
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.SteelBlue;
            this.panelChildForm.Controls.Add(this.labelMsg);
            this.panelChildForm.Controls.Add(this.pictureBox1);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(246, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(686, 553);
            this.panelChildForm.TabIndex = 1;
            // 
            // labelMsg
            // 
            this.labelMsg.AutoSize = true;
            this.labelMsg.Location = new System.Drawing.Point(17, 20);
            this.labelMsg.Name = "labelMsg";
            this.labelMsg.Size = new System.Drawing.Size(0, 20);
            this.labelMsg.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::MY_CLINIC.Properties.Resources.logo3;
            this.pictureBox1.Location = new System.Drawing.Point(170, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(358, 251);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 553);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelSideMenu);
            this.MinimumSize = new System.Drawing.Size(949, 598);
            this.Name = "Main";
            this.Text = "My Clinic";
            this.panelSideMenu.ResumeLayout(false);
            this.panelFooter.ResumeLayout(false);
            this.panelSettingsSubMenu.ResumeLayout(false);
            this.panelReportSubMenu.ResumeLayout(false);
            this.panelEmpSubMenu.ResumeLayout(false);
            this.panelAppointmentSubMenu.ResumeLayout(false);
            this.panelChildForm.ResumeLayout(false);
            this.panelChildForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelSideMenu;
        private Panel panelSettingsSubMenu;
        private Button BtnWorkExpenses;
        private Button BtnWorkHours;
        private Button BtnWorkSettings;
        private Panel panelReportSubMenu;
        private Button BtnQuarter;
        private Button BtnMonthly;
        private Button BtnWeekly;
        private Button BtnFinancialReport;
        private Panel panelEmpSubMenu;
        private Button BtnShowEmp;
        private Button BtnAddEmp;
        private Button BtnManageEmp;
        private Panel panelAppointmentSubMenu;
        private Button BtnAppointmentSchedule;
        private Button BtnAddAppointment;
        private Button BtnShowPatient;
        private Button BtnAddPatient;
        private Button BtnAppointmentSubMenu;
        private Panel panelLogo;
        private Panel panelChildForm;
        private Button BtnExit;
        private Button BtnSignOut;
        private Button BtnHelp;
        private PictureBox pictureBox1;
        private Panel panelFooter;
        private Label labelMsg;
    }
}
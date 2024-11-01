namespace THE_COOKY_APP.GUI.ACCOUNT
{
    partial class SetUpFunction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetUpFunction));
            gbAccountInformation = new GroupBox();
            cmbNameRole = new ComboBox();
            lblNameRole = new Label();
            txtUsername = new TextBox();
            lblUsername = new Label();
            txtFullName = new TextBox();
            lblFullName = new Label();
            gbChefFunction = new GroupBox();
            cbListChef = new LOGIN.CustomCheckBox();
            cbUpdateChef = new LOGIN.CustomCheckBox();
            cbDeleteChef = new LOGIN.CustomCheckBox();
            cbAddChef = new LOGIN.CustomCheckBox();
            gbStudentFunction = new GroupBox();
            cbListStudent = new LOGIN.CustomCheckBox();
            cbUpdateStudent = new LOGIN.CustomCheckBox();
            cbDeleteStudent = new LOGIN.CustomCheckBox();
            cbAddStudent = new LOGIN.CustomCheckBox();
            gpTimeTableFunction = new GroupBox();
            cbTimeTableSummary = new LOGIN.CustomCheckBox();
            cbTimeTablePlan = new LOGIN.CustomCheckBox();
            gpDataFunction = new GroupBox();
            cbDataReality = new LOGIN.CustomCheckBox();
            cbDataPlan = new LOGIN.CustomCheckBox();
            btnSave = new CLASSROOM.RoundedButton();
            cbAddClassroom = new LOGIN.CustomCheckBox();
            cbDeleteClassroom = new LOGIN.CustomCheckBox();
            cbUpdateClassroom = new LOGIN.CustomCheckBox();
            gpClassroomFunction = new GroupBox();
            cbListClassroom = new LOGIN.CustomCheckBox();
            gbReportFunction = new GroupBox();
            cbReportSummary = new LOGIN.CustomCheckBox();
            cbReportKPI = new LOGIN.CustomCheckBox();
            cbReportClass = new LOGIN.CustomCheckBox();
            cbReportLocation = new LOGIN.CustomCheckBox();
            cbReportMonth = new LOGIN.CustomCheckBox();
            gbLocationFunction = new GroupBox();
            cbListLocation = new LOGIN.CustomCheckBox();
            cbUpdateLocation = new LOGIN.CustomCheckBox();
            cbDeleteLocation = new LOGIN.CustomCheckBox();
            cbAddLocation = new LOGIN.CustomCheckBox();
            gpTopicFunction = new GroupBox();
            cbListTopic = new LOGIN.CustomCheckBox();
            cbUpdateTopic = new LOGIN.CustomCheckBox();
            cbDeleteTopic = new LOGIN.CustomCheckBox();
            cbAddTopic = new LOGIN.CustomCheckBox();
            gbAccountInformation.SuspendLayout();
            gbChefFunction.SuspendLayout();
            gbStudentFunction.SuspendLayout();
            gpTimeTableFunction.SuspendLayout();
            gpDataFunction.SuspendLayout();
            gpClassroomFunction.SuspendLayout();
            gbReportFunction.SuspendLayout();
            gbLocationFunction.SuspendLayout();
            gpTopicFunction.SuspendLayout();
            SuspendLayout();
            // 
            // gbAccountInformation
            // 
            gbAccountInformation.BackColor = Color.FromArgb(255, 227, 232);
            gbAccountInformation.Controls.Add(cmbNameRole);
            gbAccountInformation.Controls.Add(lblNameRole);
            gbAccountInformation.Controls.Add(txtUsername);
            gbAccountInformation.Controls.Add(lblUsername);
            gbAccountInformation.Controls.Add(txtFullName);
            gbAccountInformation.Controls.Add(lblFullName);
            gbAccountInformation.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            gbAccountInformation.Location = new Point(35, 46);
            gbAccountInformation.Name = "gbAccountInformation";
            gbAccountInformation.Size = new Size(561, 292);
            gbAccountInformation.TabIndex = 0;
            gbAccountInformation.TabStop = false;
            gbAccountInformation.Text = "Thông tin nhân viên";
            // 
            // cmbNameRole
            // 
            cmbNameRole.Enabled = false;
            cmbNameRole.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbNameRole.FormattingEnabled = true;
            cmbNameRole.Items.AddRange(new object[] { "Nhân viên", "Giám đốc" });
            cmbNameRole.Location = new Point(221, 226);
            cmbNameRole.Name = "cmbNameRole";
            cmbNameRole.Size = new Size(256, 36);
            cmbNameRole.TabIndex = 17;
            // 
            // lblNameRole
            // 
            lblNameRole.AutoSize = true;
            lblNameRole.BackColor = Color.FromArgb(255, 227, 232);
            lblNameRole.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNameRole.ForeColor = Color.DarkRed;
            lblNameRole.Location = new Point(42, 229);
            lblNameRole.Name = "lblNameRole";
            lblNameRole.Size = new Size(93, 28);
            lblNameRole.TabIndex = 15;
            lblNameRole.Text = "Chức vụ:";
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Enabled = false;
            txtUsername.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(221, 131);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(256, 34);
            txtUsername.TabIndex = 10;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.BackColor = Color.FromArgb(255, 227, 232);
            lblUsername.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblUsername.ForeColor = Color.DarkRed;
            lblUsername.Location = new Point(42, 133);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(145, 28);
            lblUsername.TabIndex = 9;
            lblUsername.Text = "Tên tài khoản:";
            // 
            // txtFullName
            // 
            txtFullName.BorderStyle = BorderStyle.FixedSingle;
            txtFullName.Enabled = false;
            txtFullName.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtFullName.Location = new Point(221, 44);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(256, 34);
            txtFullName.TabIndex = 8;
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.BackColor = Color.FromArgb(255, 227, 232);
            lblFullName.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblFullName.ForeColor = Color.DarkRed;
            lblFullName.Location = new Point(42, 46);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(109, 28);
            lblFullName.TabIndex = 4;
            lblFullName.Text = "Họ và tên:";
            // 
            // gbChefFunction
            // 
            gbChefFunction.BackColor = Color.FromArgb(255, 227, 232);
            gbChefFunction.Controls.Add(cbListChef);
            gbChefFunction.Controls.Add(cbUpdateChef);
            gbChefFunction.Controls.Add(cbDeleteChef);
            gbChefFunction.Controls.Add(cbAddChef);
            gbChefFunction.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            gbChefFunction.ForeColor = Color.DarkRed;
            gbChefFunction.Location = new Point(35, 377);
            gbChefFunction.Name = "gbChefFunction";
            gbChefFunction.Size = new Size(362, 289);
            gbChefFunction.TabIndex = 4;
            gbChefFunction.TabStop = false;
            gbChefFunction.Text = "Cụm chức năng giáo viên";
            // 
            // cbListChef
            // 
            cbListChef.AutoSize = true;
            cbListChef.CheckBoxSize = 20;
            cbListChef.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbListChef.ForeColor = Color.Black;
            cbListChef.Location = new Point(42, 171);
            cbListChef.Name = "cbListChef";
            cbListChef.Size = new Size(266, 32);
            cbListChef.TabIndex = 3;
            cbListChef.Text = "Xem danh sách giáo viên";
            cbListChef.UseVisualStyleBackColor = true;
            // 
            // cbUpdateChef
            // 
            cbUpdateChef.AutoSize = true;
            cbUpdateChef.CheckBoxSize = 20;
            cbUpdateChef.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbUpdateChef.ForeColor = Color.Black;
            cbUpdateChef.Location = new Point(42, 235);
            cbUpdateChef.Name = "cbUpdateChef";
            cbUpdateChef.Size = new Size(299, 32);
            cbUpdateChef.TabIndex = 2;
            cbUpdateChef.Text = "Cập nhật thông tin giáo viên";
            cbUpdateChef.UseVisualStyleBackColor = true;
            // 
            // cbDeleteChef
            // 
            cbDeleteChef.AutoSize = true;
            cbDeleteChef.CheckBoxSize = 20;
            cbDeleteChef.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbDeleteChef.ForeColor = Color.Black;
            cbDeleteChef.Location = new Point(42, 105);
            cbDeleteChef.Name = "cbDeleteChef";
            cbDeleteChef.Size = new Size(161, 32);
            cbDeleteChef.TabIndex = 1;
            cbDeleteChef.Text = "Xóa giáo viên";
            cbDeleteChef.UseVisualStyleBackColor = true;
            // 
            // cbAddChef
            // 
            cbAddChef.AutoSize = true;
            cbAddChef.CheckBoxSize = 20;
            cbAddChef.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbAddChef.ForeColor = Color.Black;
            cbAddChef.Location = new Point(42, 40);
            cbAddChef.Name = "cbAddChef";
            cbAddChef.Size = new Size(220, 32);
            cbAddChef.TabIndex = 0;
            cbAddChef.Text = "Thêm mới giáo viên";
            cbAddChef.UseVisualStyleBackColor = true;
            // 
            // gbStudentFunction
            // 
            gbStudentFunction.BackColor = Color.FromArgb(255, 227, 232);
            gbStudentFunction.Controls.Add(cbListStudent);
            gbStudentFunction.Controls.Add(cbUpdateStudent);
            gbStudentFunction.Controls.Add(cbDeleteStudent);
            gbStudentFunction.Controls.Add(cbAddStudent);
            gbStudentFunction.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            gbStudentFunction.ForeColor = Color.DarkRed;
            gbStudentFunction.Location = new Point(891, 377);
            gbStudentFunction.Name = "gbStudentFunction";
            gbStudentFunction.Size = new Size(362, 289);
            gbStudentFunction.TabIndex = 6;
            gbStudentFunction.TabStop = false;
            gbStudentFunction.Text = "Cụm chức năng học viên";
            // 
            // cbListStudent
            // 
            cbListStudent.AutoSize = true;
            cbListStudent.CheckBoxSize = 20;
            cbListStudent.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbListStudent.ForeColor = Color.Black;
            cbListStudent.Location = new Point(42, 171);
            cbListStudent.Name = "cbListStudent";
            cbListStudent.Size = new Size(260, 32);
            cbListStudent.TabIndex = 4;
            cbListStudent.Text = "Xem danh sách học viên";
            cbListStudent.UseVisualStyleBackColor = true;
            // 
            // cbUpdateStudent
            // 
            cbUpdateStudent.AutoSize = true;
            cbUpdateStudent.CheckBoxSize = 20;
            cbUpdateStudent.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbUpdateStudent.ForeColor = Color.Black;
            cbUpdateStudent.Location = new Point(42, 235);
            cbUpdateStudent.Name = "cbUpdateStudent";
            cbUpdateStudent.Size = new Size(293, 32);
            cbUpdateStudent.TabIndex = 2;
            cbUpdateStudent.Text = "Cập nhật thông tin học viên";
            cbUpdateStudent.UseVisualStyleBackColor = true;
            // 
            // cbDeleteStudent
            // 
            cbDeleteStudent.AutoSize = true;
            cbDeleteStudent.CheckBoxSize = 20;
            cbDeleteStudent.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbDeleteStudent.ForeColor = Color.Black;
            cbDeleteStudent.Location = new Point(42, 105);
            cbDeleteStudent.Name = "cbDeleteStudent";
            cbDeleteStudent.Size = new Size(158, 32);
            cbDeleteStudent.TabIndex = 1;
            cbDeleteStudent.Text = "Hủy học viên";
            cbDeleteStudent.UseVisualStyleBackColor = true;
            // 
            // cbAddStudent
            // 
            cbAddStudent.AutoSize = true;
            cbAddStudent.CheckBoxSize = 20;
            cbAddStudent.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbAddStudent.ForeColor = Color.Black;
            cbAddStudent.Location = new Point(42, 40);
            cbAddStudent.Name = "cbAddStudent";
            cbAddStudent.Size = new Size(214, 32);
            cbAddStudent.TabIndex = 0;
            cbAddStudent.Text = "Thêm mới học viên";
            cbAddStudent.UseVisualStyleBackColor = true;
            // 
            // gpTimeTableFunction
            // 
            gpTimeTableFunction.BackColor = Color.FromArgb(255, 227, 232);
            gpTimeTableFunction.Controls.Add(cbTimeTableSummary);
            gpTimeTableFunction.Controls.Add(cbTimeTablePlan);
            gpTimeTableFunction.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            gpTimeTableFunction.ForeColor = Color.DarkRed;
            gpTimeTableFunction.Location = new Point(177, 997);
            gpTimeTableFunction.Name = "gpTimeTableFunction";
            gpTimeTableFunction.Size = new Size(362, 163);
            gpTimeTableFunction.TabIndex = 7;
            gpTimeTableFunction.TabStop = false;
            gpTimeTableFunction.Text = "Cụm chức năng bảng biểu";
            // 
            // cbTimeTableSummary
            // 
            cbTimeTableSummary.AutoSize = true;
            cbTimeTableSummary.CheckBoxSize = 20;
            cbTimeTableSummary.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbTimeTableSummary.ForeColor = Color.Black;
            cbTimeTableSummary.Location = new Point(42, 105);
            cbTimeTableSummary.Name = "cbTimeTableSummary";
            cbTimeTableSummary.Size = new Size(268, 32);
            cbTimeTableSummary.TabIndex = 2;
            cbTimeTableSummary.Text = "Xem bảng biểu tổng hợp";
            cbTimeTableSummary.UseVisualStyleBackColor = true;
            // 
            // cbTimeTablePlan
            // 
            cbTimeTablePlan.AutoSize = true;
            cbTimeTablePlan.CheckBoxSize = 20;
            cbTimeTablePlan.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbTimeTablePlan.ForeColor = Color.Black;
            cbTimeTablePlan.Location = new Point(42, 40);
            cbTimeTablePlan.Name = "cbTimeTablePlan";
            cbTimeTablePlan.Size = new Size(252, 32);
            cbTimeTablePlan.TabIndex = 0;
            cbTimeTablePlan.Text = "Xem bảng biểu dự kiến";
            cbTimeTablePlan.UseVisualStyleBackColor = true;
            // 
            // gpDataFunction
            // 
            gpDataFunction.BackColor = Color.FromArgb(255, 227, 232);
            gpDataFunction.Controls.Add(cbDataReality);
            gpDataFunction.Controls.Add(cbDataPlan);
            gpDataFunction.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            gpDataFunction.ForeColor = Color.DarkRed;
            gpDataFunction.Location = new Point(757, 997);
            gpDataFunction.Name = "gpDataFunction";
            gpDataFunction.Size = new Size(362, 163);
            gpDataFunction.TabIndex = 9;
            gpDataFunction.TabStop = false;
            gpDataFunction.Text = "Cụm chức năng dữ liệu";
            // 
            // cbDataReality
            // 
            cbDataReality.AutoSize = true;
            cbDataReality.CheckBoxSize = 20;
            cbDataReality.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbDataReality.ForeColor = Color.Black;
            cbDataReality.Location = new Point(42, 105);
            cbDataReality.Name = "cbDataReality";
            cbDataReality.Size = new Size(218, 32);
            cbDataReality.TabIndex = 4;
            cbDataReality.Text = "Xem dữ liệu thực tế";
            cbDataReality.UseVisualStyleBackColor = true;
            // 
            // cbDataPlan
            // 
            cbDataPlan.AutoSize = true;
            cbDataPlan.CheckBoxSize = 20;
            cbDataPlan.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbDataPlan.ForeColor = Color.Black;
            cbDataPlan.Location = new Point(42, 40);
            cbDataPlan.Name = "cbDataPlan";
            cbDataPlan.Size = new Size(223, 32);
            cbDataPlan.TabIndex = 3;
            cbDataPlan.Text = "Xem dữ liệu dự kiến";
            cbDataPlan.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.BorderRadius = 40;
            btnSave.ButtonColor = Color.DarkRed;
            btnSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSave.Location = new Point(1141, 308);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 39);
            btnSave.TabIndex = 21;
            btnSave.Text = "Lưu trữ";
            btnSave.TextColor = Color.White;
            btnSave.UseVisualStyleBackColor = true;
            // 
            // cbAddClassroom
            // 
            cbAddClassroom.AutoSize = true;
            cbAddClassroom.CheckBoxSize = 20;
            cbAddClassroom.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbAddClassroom.ForeColor = Color.Black;
            cbAddClassroom.Location = new Point(42, 40);
            cbAddClassroom.Name = "cbAddClassroom";
            cbAddClassroom.Size = new Size(205, 32);
            cbAddClassroom.TabIndex = 0;
            cbAddClassroom.Text = "Thêm mới lớp học";
            cbAddClassroom.UseVisualStyleBackColor = true;
            // 
            // cbDeleteClassroom
            // 
            cbDeleteClassroom.AutoSize = true;
            cbDeleteClassroom.CheckBoxSize = 20;
            cbDeleteClassroom.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbDeleteClassroom.ForeColor = Color.Black;
            cbDeleteClassroom.Location = new Point(42, 105);
            cbDeleteClassroom.Name = "cbDeleteClassroom";
            cbDeleteClassroom.Size = new Size(149, 32);
            cbDeleteClassroom.TabIndex = 1;
            cbDeleteClassroom.Text = "Hủy lớp học";
            cbDeleteClassroom.UseVisualStyleBackColor = true;
            // 
            // cbUpdateClassroom
            // 
            cbUpdateClassroom.AutoSize = true;
            cbUpdateClassroom.CheckBoxSize = 20;
            cbUpdateClassroom.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbUpdateClassroom.ForeColor = Color.Black;
            cbUpdateClassroom.Location = new Point(42, 235);
            cbUpdateClassroom.Name = "cbUpdateClassroom";
            cbUpdateClassroom.Size = new Size(284, 32);
            cbUpdateClassroom.TabIndex = 2;
            cbUpdateClassroom.Text = "Cập nhật thông tin lớp học";
            cbUpdateClassroom.UseVisualStyleBackColor = true;
            // 
            // gpClassroomFunction
            // 
            gpClassroomFunction.BackColor = Color.FromArgb(255, 227, 232);
            gpClassroomFunction.Controls.Add(cbListClassroom);
            gpClassroomFunction.Controls.Add(cbUpdateClassroom);
            gpClassroomFunction.Controls.Add(cbDeleteClassroom);
            gpClassroomFunction.Controls.Add(cbAddClassroom);
            gpClassroomFunction.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            gpClassroomFunction.ForeColor = Color.DarkRed;
            gpClassroomFunction.Location = new Point(466, 686);
            gpClassroomFunction.Name = "gpClassroomFunction";
            gpClassroomFunction.Size = new Size(362, 289);
            gpClassroomFunction.TabIndex = 5;
            gpClassroomFunction.TabStop = false;
            gpClassroomFunction.Text = "Cụm chức năng lớp học";
            // 
            // cbListClassroom
            // 
            cbListClassroom.AutoSize = true;
            cbListClassroom.CheckBoxSize = 20;
            cbListClassroom.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbListClassroom.ForeColor = Color.Black;
            cbListClassroom.Location = new Point(42, 171);
            cbListClassroom.Name = "cbListClassroom";
            cbListClassroom.Size = new Size(251, 32);
            cbListClassroom.TabIndex = 4;
            cbListClassroom.Text = "Xem danh sách lớp học";
            cbListClassroom.UseVisualStyleBackColor = true;
            // 
            // gbReportFunction
            // 
            gbReportFunction.BackColor = Color.FromArgb(255, 227, 232);
            gbReportFunction.Controls.Add(cbReportSummary);
            gbReportFunction.Controls.Add(cbReportKPI);
            gbReportFunction.Controls.Add(cbReportClass);
            gbReportFunction.Controls.Add(cbReportLocation);
            gbReportFunction.Controls.Add(cbReportMonth);
            gbReportFunction.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            gbReportFunction.ForeColor = Color.DarkRed;
            gbReportFunction.Location = new Point(891, 686);
            gbReportFunction.Name = "gbReportFunction";
            gbReportFunction.Size = new Size(362, 289);
            gbReportFunction.TabIndex = 22;
            gbReportFunction.TabStop = false;
            gbReportFunction.Text = "Cụm chức năng báo cáo";
            // 
            // cbReportSummary
            // 
            cbReportSummary.AutoSize = true;
            cbReportSummary.CheckBoxSize = 20;
            cbReportSummary.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbReportSummary.ForeColor = Color.Black;
            cbReportSummary.Location = new Point(42, 237);
            cbReportSummary.Name = "cbReportSummary";
            cbReportSummary.Size = new Size(247, 32);
            cbReportSummary.TabIndex = 5;
            cbReportSummary.Text = "Xem báo cáo tổng hợp";
            cbReportSummary.UseVisualStyleBackColor = true;
            // 
            // cbReportKPI
            // 
            cbReportKPI.AutoSize = true;
            cbReportKPI.CheckBoxSize = 20;
            cbReportKPI.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbReportKPI.ForeColor = Color.Black;
            cbReportKPI.Location = new Point(42, 133);
            cbReportKPI.Name = "cbReportKPI";
            cbReportKPI.Size = new Size(229, 32);
            cbReportKPI.TabIndex = 4;
            cbReportKPI.Text = "Xem báo cáo chỉ tiêu";
            cbReportKPI.UseVisualStyleBackColor = true;
            // 
            // cbReportClass
            // 
            cbReportClass.AutoSize = true;
            cbReportClass.CheckBoxSize = 20;
            cbReportClass.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbReportClass.ForeColor = Color.Black;
            cbReportClass.Location = new Point(42, 184);
            cbReportClass.Name = "cbReportClass";
            cbReportClass.Size = new Size(239, 32);
            cbReportClass.TabIndex = 2;
            cbReportClass.Text = "Xem báo cáo theo lớp";
            cbReportClass.UseVisualStyleBackColor = true;
            // 
            // cbReportLocation
            // 
            cbReportLocation.AutoSize = true;
            cbReportLocation.CheckBoxSize = 20;
            cbReportLocation.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbReportLocation.ForeColor = Color.Black;
            cbReportLocation.Location = new Point(42, 81);
            cbReportLocation.Name = "cbReportLocation";
            cbReportLocation.Size = new Size(241, 32);
            cbReportLocation.TabIndex = 1;
            cbReportLocation.Text = "Xem báo cáo địa điểm";
            cbReportLocation.UseVisualStyleBackColor = true;
            // 
            // cbReportMonth
            // 
            cbReportMonth.AutoSize = true;
            cbReportMonth.CheckBoxSize = 20;
            cbReportMonth.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbReportMonth.ForeColor = Color.Black;
            cbReportMonth.Location = new Point(42, 30);
            cbReportMonth.Name = "cbReportMonth";
            cbReportMonth.Size = new Size(215, 32);
            cbReportMonth.TabIndex = 0;
            cbReportMonth.Text = "Xem báo cáo tháng";
            cbReportMonth.UseVisualStyleBackColor = true;
            // 
            // gbLocationFunction
            // 
            gbLocationFunction.BackColor = Color.FromArgb(255, 227, 232);
            gbLocationFunction.Controls.Add(cbListLocation);
            gbLocationFunction.Controls.Add(cbUpdateLocation);
            gbLocationFunction.Controls.Add(cbDeleteLocation);
            gbLocationFunction.Controls.Add(cbAddLocation);
            gbLocationFunction.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            gbLocationFunction.ForeColor = Color.DarkRed;
            gbLocationFunction.Location = new Point(35, 686);
            gbLocationFunction.Name = "gbLocationFunction";
            gbLocationFunction.Size = new Size(362, 289);
            gbLocationFunction.TabIndex = 23;
            gbLocationFunction.TabStop = false;
            gbLocationFunction.Text = "Cụm chức năng địa điểm";
            // 
            // cbListLocation
            // 
            cbListLocation.AutoSize = true;
            cbListLocation.CheckBoxSize = 20;
            cbListLocation.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbListLocation.ForeColor = Color.Black;
            cbListLocation.Location = new Point(42, 181);
            cbListLocation.Name = "cbListLocation";
            cbListLocation.Size = new Size(262, 32);
            cbListLocation.TabIndex = 4;
            cbListLocation.Text = "Xem danh sách địa điểm";
            cbListLocation.UseVisualStyleBackColor = true;
            // 
            // cbUpdateLocation
            // 
            cbUpdateLocation.AutoSize = true;
            cbUpdateLocation.CheckBoxSize = 20;
            cbUpdateLocation.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbUpdateLocation.ForeColor = Color.Black;
            cbUpdateLocation.Location = new Point(42, 241);
            cbUpdateLocation.Name = "cbUpdateLocation";
            cbUpdateLocation.Size = new Size(295, 32);
            cbUpdateLocation.TabIndex = 2;
            cbUpdateLocation.Text = "Cập nhật thông tin địa điểm";
            cbUpdateLocation.UseVisualStyleBackColor = true;
            // 
            // cbDeleteLocation
            // 
            cbDeleteLocation.AutoSize = true;
            cbDeleteLocation.CheckBoxSize = 20;
            cbDeleteLocation.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbDeleteLocation.ForeColor = Color.Black;
            cbDeleteLocation.Location = new Point(42, 115);
            cbDeleteLocation.Name = "cbDeleteLocation";
            cbDeleteLocation.Size = new Size(160, 32);
            cbDeleteLocation.TabIndex = 1;
            cbDeleteLocation.Text = "Hủy địa điểm";
            cbDeleteLocation.UseVisualStyleBackColor = true;
            // 
            // cbAddLocation
            // 
            cbAddLocation.AutoSize = true;
            cbAddLocation.CheckBoxSize = 20;
            cbAddLocation.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbAddLocation.ForeColor = Color.Black;
            cbAddLocation.Location = new Point(42, 50);
            cbAddLocation.Name = "cbAddLocation";
            cbAddLocation.Size = new Size(216, 32);
            cbAddLocation.TabIndex = 0;
            cbAddLocation.Text = "Thêm mới địa điểm";
            cbAddLocation.UseVisualStyleBackColor = true;
            // 
            // gpTopicFunction
            // 
            gpTopicFunction.BackColor = Color.FromArgb(255, 227, 232);
            gpTopicFunction.Controls.Add(cbListTopic);
            gpTopicFunction.Controls.Add(cbUpdateTopic);
            gpTopicFunction.Controls.Add(cbDeleteTopic);
            gpTopicFunction.Controls.Add(cbAddTopic);
            gpTopicFunction.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            gpTopicFunction.ForeColor = Color.DarkRed;
            gpTopicFunction.Location = new Point(466, 377);
            gpTopicFunction.Name = "gpTopicFunction";
            gpTopicFunction.Size = new Size(362, 289);
            gpTopicFunction.TabIndex = 17;
            gpTopicFunction.TabStop = false;
            gpTopicFunction.Text = "Cụm chức năng chủ đề";
            // 
            // cbListTopic
            // 
            cbListTopic.AutoSize = true;
            cbListTopic.CheckBoxSize = 20;
            cbListTopic.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbListTopic.ForeColor = Color.Black;
            cbListTopic.Location = new Point(42, 171);
            cbListTopic.Name = "cbListTopic";
            cbListTopic.Size = new Size(245, 32);
            cbListTopic.TabIndex = 4;
            cbListTopic.Text = "Xem danh sách chủ đề";
            cbListTopic.UseVisualStyleBackColor = true;
            // 
            // cbUpdateTopic
            // 
            cbUpdateTopic.AutoSize = true;
            cbUpdateTopic.CheckBoxSize = 20;
            cbUpdateTopic.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbUpdateTopic.ForeColor = Color.Black;
            cbUpdateTopic.Location = new Point(42, 234);
            cbUpdateTopic.Name = "cbUpdateTopic";
            cbUpdateTopic.Size = new Size(278, 32);
            cbUpdateTopic.TabIndex = 2;
            cbUpdateTopic.Text = "Cập nhật thông tin chủ đề";
            cbUpdateTopic.UseVisualStyleBackColor = true;
            // 
            // cbDeleteTopic
            // 
            cbDeleteTopic.AutoSize = true;
            cbDeleteTopic.CheckBoxSize = 20;
            cbDeleteTopic.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbDeleteTopic.ForeColor = Color.Black;
            cbDeleteTopic.Location = new Point(42, 105);
            cbDeleteTopic.Name = "cbDeleteTopic";
            cbDeleteTopic.Size = new Size(143, 32);
            cbDeleteTopic.TabIndex = 1;
            cbDeleteTopic.Text = "Hủy chủ đề";
            cbDeleteTopic.UseVisualStyleBackColor = true;
            // 
            // cbAddTopic
            // 
            cbAddTopic.AutoSize = true;
            cbAddTopic.CheckBoxSize = 20;
            cbAddTopic.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbAddTopic.ForeColor = Color.Black;
            cbAddTopic.Location = new Point(42, 40);
            cbAddTopic.Name = "cbAddTopic";
            cbAddTopic.Size = new Size(199, 32);
            cbAddTopic.TabIndex = 0;
            cbAddTopic.Text = "Thêm mới chủ đề";
            cbAddTopic.UseVisualStyleBackColor = true;
            // 
            // SetUpFunction
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(251, 236, 240);
            ClientSize = new Size(1304, 1050);
            Controls.Add(gpTopicFunction);
            Controls.Add(gbLocationFunction);
            Controls.Add(gbReportFunction);
            Controls.Add(btnSave);
            Controls.Add(gpClassroomFunction);
            Controls.Add(gbStudentFunction);
            Controls.Add(gpDataFunction);
            Controls.Add(gpTimeTableFunction);
            Controls.Add(gbChefFunction);
            Controls.Add(gbAccountInformation);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SetUpFunction";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Phân quyền chức năng";
            gbAccountInformation.ResumeLayout(false);
            gbAccountInformation.PerformLayout();
            gbChefFunction.ResumeLayout(false);
            gbChefFunction.PerformLayout();
            gbStudentFunction.ResumeLayout(false);
            gbStudentFunction.PerformLayout();
            gpTimeTableFunction.ResumeLayout(false);
            gpTimeTableFunction.PerformLayout();
            gpDataFunction.ResumeLayout(false);
            gpDataFunction.PerformLayout();
            gpClassroomFunction.ResumeLayout(false);
            gpClassroomFunction.PerformLayout();
            gbReportFunction.ResumeLayout(false);
            gbReportFunction.PerformLayout();
            gbLocationFunction.ResumeLayout(false);
            gbLocationFunction.PerformLayout();
            gpTopicFunction.ResumeLayout(false);
            gpTopicFunction.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbAccountInformation;
        private Label lblFullName;
        private TextBox txtFullName;
        private Label lblUsername;
        private TextBox txtUsername;
        private Label lblNameRole;
        private GroupBox gbChefFunction;
        private LOGIN.CustomCheckBox cbAddChef;
        private LOGIN.CustomCheckBox cbUpdateChef;
        private LOGIN.CustomCheckBox cbDeleteChef;
        private GroupBox gbStudentFunction;
        private LOGIN.CustomCheckBox cbUpdateStudent;
        private LOGIN.CustomCheckBox cbDeleteStudent;
        private LOGIN.CustomCheckBox cbAddStudent;
        private GroupBox gpTimeTableFunction;
        private LOGIN.CustomCheckBox cbTimeTableSummary;
        private LOGIN.CustomCheckBox cbTimeTablePlan;
        private GroupBox gpDataFunction;
        private LOGIN.CustomCheckBox cbDataReality;
        private LOGIN.CustomCheckBox cbDataPlan;
        private CLASSROOM.RoundedButton btnSave;
        private LOGIN.CustomCheckBox cbListChef;
        private LOGIN.CustomCheckBox cbListStudent;
        private LOGIN.CustomCheckBox cbAddClassroom;
        private LOGIN.CustomCheckBox cbDeleteClassroom;
        private LOGIN.CustomCheckBox cbUpdateClassroom;
        private GroupBox gpClassroomFunction;
        private LOGIN.CustomCheckBox cbListClassroom;
        private GroupBox gbReportFunction;
        private LOGIN.CustomCheckBox cbReportKPI;
        private LOGIN.CustomCheckBox cbReportClass;
        private LOGIN.CustomCheckBox cbReportLocation;
        private LOGIN.CustomCheckBox cbReportMonth;
        private GroupBox gbLocationFunction;
        private LOGIN.CustomCheckBox cbListLocation;
        private LOGIN.CustomCheckBox cbUpdateLocation;
        private LOGIN.CustomCheckBox cbDeleteLocation;
        private LOGIN.CustomCheckBox cbAddLocation;
        private GroupBox gpTopicFunction;
        private LOGIN.CustomCheckBox cbListTopic;
        private LOGIN.CustomCheckBox cbUpdateTopic;
        private LOGIN.CustomCheckBox cbDeleteTopic;
        private LOGIN.CustomCheckBox cbAddTopic;
        private LOGIN.CustomCheckBox cbReportSummary;
        private ComboBox cmbNameRole;
    }
}
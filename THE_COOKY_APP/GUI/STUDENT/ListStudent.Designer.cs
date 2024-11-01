namespace THE_COOKY_APP.GUI.STUDENT
{
    partial class ListStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListStudent));
            gbStudentInformation = new GroupBox();
            dtpDateOfBirth = new DateTimePicker();
            txtGender = new TextBox();
            txtAddress = new TextBox();
            txtNameStudent = new TextBox();
            lblDateOfBirth = new Label();
            lblGender = new Label();
            lblPhoneNumber = new Label();
            lblNameStudent = new Label();
            gbAction = new GroupBox();
            btnSave = new CLASSROOM.RoundedButton();
            btnDelete = new CLASSROOM.RoundedButton();
            btnUpdate = new CLASSROOM.RoundedButton();
            txtSearch = new TextBox();
            lblSearch = new Label();
            dgvListStudent = new DataGridView();
            txtGmail = new TextBox();
            lblGmail = new Label();
            gbStudentInformation.SuspendLayout();
            gbAction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListStudent).BeginInit();
            SuspendLayout();
            // 
            // gbStudentInformation
            // 
            gbStudentInformation.BackColor = Color.FromArgb(255, 227, 232);
            gbStudentInformation.Controls.Add(txtGmail);
            gbStudentInformation.Controls.Add(lblGmail);
            gbStudentInformation.Controls.Add(dtpDateOfBirth);
            gbStudentInformation.Controls.Add(txtGender);
            gbStudentInformation.Controls.Add(txtAddress);
            gbStudentInformation.Controls.Add(txtNameStudent);
            gbStudentInformation.Controls.Add(lblDateOfBirth);
            gbStudentInformation.Controls.Add(lblGender);
            gbStudentInformation.Controls.Add(lblPhoneNumber);
            gbStudentInformation.Controls.Add(lblNameStudent);
            gbStudentInformation.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            gbStudentInformation.Location = new Point(28, 310);
            gbStudentInformation.Name = "gbStudentInformation";
            gbStudentInformation.Size = new Size(505, 421);
            gbStudentInformation.TabIndex = 2;
            gbStudentInformation.TabStop = false;
            gbStudentInformation.Text = "Thông tin học viên";
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.CustomFormat = "dd/MM/yyyy";
            dtpDateOfBirth.Enabled = false;
            dtpDateOfBirth.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpDateOfBirth.Format = DateTimePickerFormat.Custom;
            dtpDateOfBirth.Location = new Point(213, 209);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(256, 34);
            dtpDateOfBirth.TabIndex = 10;
            // 
            // txtGender
            // 
            txtGender.BorderStyle = BorderStyle.FixedSingle;
            txtGender.Enabled = false;
            txtGender.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtGender.Location = new Point(213, 366);
            txtGender.Name = "txtGender";
            txtGender.Size = new Size(256, 34);
            txtGender.TabIndex = 9;
            // 
            // txtAddress
            // 
            txtAddress.BorderStyle = BorderStyle.FixedSingle;
            txtAddress.Enabled = false;
            txtAddress.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtAddress.Location = new Point(213, 130);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(256, 34);
            txtAddress.TabIndex = 8;
            // 
            // txtNameStudent
            // 
            txtNameStudent.BorderStyle = BorderStyle.FixedSingle;
            txtNameStudent.Enabled = false;
            txtNameStudent.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNameStudent.Location = new Point(213, 54);
            txtNameStudent.Name = "txtNameStudent";
            txtNameStudent.Size = new Size(256, 34);
            txtNameStudent.TabIndex = 7;
            // 
            // lblDateOfBirth
            // 
            lblDateOfBirth.AutoSize = true;
            lblDateOfBirth.BackColor = Color.FromArgb(255, 227, 232);
            lblDateOfBirth.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDateOfBirth.ForeColor = Color.DarkRed;
            lblDateOfBirth.Location = new Point(40, 214);
            lblDateOfBirth.Name = "lblDateOfBirth";
            lblDateOfBirth.Size = new Size(107, 28);
            lblDateOfBirth.TabIndex = 6;
            lblDateOfBirth.Text = "Năm sinh:";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.BackColor = Color.FromArgb(255, 227, 232);
            lblGender.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblGender.ForeColor = Color.DarkRed;
            lblGender.Location = new Point(40, 368);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(100, 28);
            lblGender.TabIndex = 5;
            lblGender.Text = "Giới tính:";
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.BackColor = Color.FromArgb(255, 227, 232);
            lblPhoneNumber.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPhoneNumber.ForeColor = Color.DarkRed;
            lblPhoneNumber.Location = new Point(40, 133);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(143, 28);
            lblPhoneNumber.TabIndex = 4;
            lblPhoneNumber.Text = "Số điện thoại:";
            // 
            // lblNameStudent
            // 
            lblNameStudent.AutoSize = true;
            lblNameStudent.BackColor = Color.FromArgb(255, 227, 232);
            lblNameStudent.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNameStudent.ForeColor = Color.DarkRed;
            lblNameStudent.Location = new Point(40, 57);
            lblNameStudent.Name = "lblNameStudent";
            lblNameStudent.Size = new Size(136, 28);
            lblNameStudent.TabIndex = 3;
            lblNameStudent.Text = "Tên học viên:";
            // 
            // gbAction
            // 
            gbAction.BackColor = Color.FromArgb(255, 227, 232);
            gbAction.Controls.Add(btnSave);
            gbAction.Controls.Add(btnDelete);
            gbAction.Controls.Add(btnUpdate);
            gbAction.Controls.Add(txtSearch);
            gbAction.Controls.Add(lblSearch);
            gbAction.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            gbAction.Location = new Point(28, 62);
            gbAction.Name = "gbAction";
            gbAction.Size = new Size(505, 209);
            gbAction.TabIndex = 13;
            gbAction.TabStop = false;
            gbAction.Text = "Thao tác";
            // 
            // btnSave
            // 
            btnSave.BorderRadius = 40;
            btnSave.ButtonColor = Color.DarkRed;
            btnSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSave.Location = new Point(199, 122);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 39);
            btnSave.TabIndex = 25;
            btnSave.Text = "Lưu";
            btnSave.TextColor = Color.White;
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.BorderRadius = 40;
            btnDelete.ButtonColor = Color.DarkRed;
            btnDelete.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDelete.Location = new Point(357, 122);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 39);
            btnDelete.TabIndex = 23;
            btnDelete.Text = "Xóa";
            btnDelete.TextColor = Color.White;
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.BorderRadius = 40;
            btnUpdate.ButtonColor = Color.DarkRed;
            btnUpdate.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnUpdate.Location = new Point(33, 122);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(112, 39);
            btnUpdate.TabIndex = 21;
            btnUpdate.Text = "Sửa";
            btnUpdate.TextColor = Color.White;
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(213, 50);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(256, 34);
            txtSearch.TabIndex = 8;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.BackColor = Color.FromArgb(255, 227, 232);
            lblSearch.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSearch.ForeColor = Color.DarkRed;
            lblSearch.Location = new Point(40, 52);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(105, 28);
            lblSearch.TabIndex = 7;
            lblSearch.Text = "Tìm kiếm:";
            // 
            // dgvListStudent
            // 
            dgvListStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListStudent.Location = new Point(568, 62);
            dgvListStudent.Name = "dgvListStudent";
            dgvListStudent.RowHeadersWidth = 62;
            dgvListStudent.Size = new Size(682, 669);
            dgvListStudent.TabIndex = 14;
            // 
            // txtGmail
            // 
            txtGmail.BorderStyle = BorderStyle.FixedSingle;
            txtGmail.Enabled = false;
            txtGmail.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtGmail.Location = new Point(213, 289);
            txtGmail.Name = "txtGmail";
            txtGmail.Size = new Size(256, 34);
            txtGmail.TabIndex = 12;
            // 
            // lblGmail
            // 
            lblGmail.AutoSize = true;
            lblGmail.BackColor = Color.FromArgb(255, 227, 232);
            lblGmail.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblGmail.ForeColor = Color.DarkRed;
            lblGmail.Location = new Point(40, 291);
            lblGmail.Name = "lblGmail";
            lblGmail.Size = new Size(72, 28);
            lblGmail.TabIndex = 11;
            lblGmail.Text = "Gmail:";
            // 
            // ListStudent
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(251, 236, 240);
            ClientSize = new Size(1278, 794);
            Controls.Add(dgvListStudent);
            Controls.Add(gbAction);
            Controls.Add(gbStudentInformation);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ListStudent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Danh sách học viên";
            gbStudentInformation.ResumeLayout(false);
            gbStudentInformation.PerformLayout();
            gbAction.ResumeLayout(false);
            gbAction.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListStudent).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbStudentInformation;
        private DateTimePicker dtpDateOfBirth;
        private TextBox txtGender;
        private TextBox txtAddress;
        private TextBox txtNameStudent;
        private Label lblDateOfBirth;
        private Label lblGender;
        private Label lblPhoneNumber;
        private Label lblNameStudent;
        private GroupBox gbAction;
        private CLASSROOM.RoundedButton btnSave;
        private CLASSROOM.RoundedButton btnDelete;
        private CLASSROOM.RoundedButton btnUpdate;
        private TextBox txtSearch;
        private Label lblSearch;
        private DataGridView dgvListStudent;
        private TextBox txtGmail;
        private Label lblGmail;
    }
}
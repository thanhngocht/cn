namespace THE_COOKY_APP.GUI.STUDENT
{
    partial class CreateStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateStudent));
            gbStudentInformation = new GroupBox();
            dtpDateOfBirth = new DateTimePicker();
            txtGender = new TextBox();
            txtAddress = new TextBox();
            txtNameStudent = new TextBox();
            lblDateOfBirth = new Label();
            lblGender = new Label();
            lblPhoneNumber = new Label();
            lblNameStudent = new Label();
            btnAdd = new CLASSROOM.RoundedButton();
            gbStudentInformation.SuspendLayout();
            SuspendLayout();
            // 
            // gbStudentInformation
            // 
            gbStudentInformation.BackColor = Color.FromArgb(255, 227, 232);
            gbStudentInformation.Controls.Add(dtpDateOfBirth);
            gbStudentInformation.Controls.Add(txtGender);
            gbStudentInformation.Controls.Add(txtAddress);
            gbStudentInformation.Controls.Add(txtNameStudent);
            gbStudentInformation.Controls.Add(lblDateOfBirth);
            gbStudentInformation.Controls.Add(lblGender);
            gbStudentInformation.Controls.Add(lblPhoneNumber);
            gbStudentInformation.Controls.Add(lblNameStudent);
            gbStudentInformation.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            gbStudentInformation.Location = new Point(50, 68);
            gbStudentInformation.Name = "gbStudentInformation";
            gbStudentInformation.Size = new Size(505, 421);
            gbStudentInformation.TabIndex = 1;
            gbStudentInformation.TabStop = false;
            gbStudentInformation.Text = "Thông tin học viên";
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.CustomFormat = "dd/MM/yyyy";
            dtpDateOfBirth.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpDateOfBirth.Format = DateTimePickerFormat.Custom;
            dtpDateOfBirth.Location = new Point(213, 212);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(256, 34);
            dtpDateOfBirth.TabIndex = 10;
            // 
            // txtGender
            // 
            txtGender.BorderStyle = BorderStyle.FixedSingle;
            txtGender.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtGender.Location = new Point(213, 304);
            txtGender.Name = "txtGender";
            txtGender.Size = new Size(256, 34);
            txtGender.TabIndex = 9;
            // 
            // txtAddress
            // 
            txtAddress.BorderStyle = BorderStyle.FixedSingle;
            txtAddress.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtAddress.Location = new Point(213, 133);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(256, 34);
            txtAddress.TabIndex = 8;
            // 
            // txtNameStudent
            // 
            txtNameStudent.BorderStyle = BorderStyle.FixedSingle;
            txtNameStudent.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNameStudent.Location = new Point(213, 57);
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
            lblDateOfBirth.Location = new Point(40, 217);
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
            lblGender.Location = new Point(40, 306);
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
            lblPhoneNumber.Location = new Point(40, 136);
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
            lblNameStudent.Location = new Point(40, 60);
            lblNameStudent.Name = "lblNameStudent";
            lblNameStudent.Size = new Size(136, 28);
            lblNameStudent.TabIndex = 3;
            lblNameStudent.Text = "Tên học viên:";
            // 
            // btnAdd
            // 
            btnAdd.BorderRadius = 40;
            btnAdd.ButtonColor = Color.DarkRed;
            btnAdd.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(443, 534);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 39);
            btnAdd.TabIndex = 19;
            btnAdd.Text = "Thêm";
            btnAdd.TextColor = Color.White;
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // CreateStudent
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(251, 236, 240);
            ClientSize = new Size(608, 594);
            Controls.Add(btnAdd);
            Controls.Add(gbStudentInformation);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CreateStudent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thêm học viên";
            gbStudentInformation.ResumeLayout(false);
            gbStudentInformation.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbStudentInformation;
        private TextBox txtGender;
        private TextBox txtAddress;
        private TextBox txtNameStudent;
        private Label lblDateOfBirth;
        private Label lblGender;
        private Label lblPhoneNumber;
        private Label lblNameStudent;
        private CLASSROOM.RoundedButton btnAdd;
        private DateTimePicker dtpDateOfBirth;
    }
}
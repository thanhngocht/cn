namespace THE_COOKY_APP.GUI.CHEF
{
    partial class CreateChef
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateChef));
            gbChefInformation = new GroupBox();
            txtGmail = new TextBox();
            dtpStartDate = new DateTimePicker();
            txtPhoneNumber = new TextBox();
            txtFullName = new TextBox();
            lblGmail = new Label();
            lblStartDate = new Label();
            lblPhoneNumber = new Label();
            lblFullName = new Label();
            gbPersonalProfile = new GroupBox();
            txtAddress = new TextBox();
            lblAddress = new Label();
            dtpDateOfBirth = new DateTimePicker();
            txtNativePlace = new TextBox();
            txtCCCD = new TextBox();
            lblDateOfBirth = new Label();
            lblNativePlace = new Label();
            lblCCCD = new Label();
            btnAdd = new CLASSROOM.RoundedButton();
            lblSpeciality = new Label();
            txtSpeciality = new TextBox();
            gbChefInformation.SuspendLayout();
            gbPersonalProfile.SuspendLayout();
            SuspendLayout();
            // 
            // gbChefInformation
            // 
            gbChefInformation.BackColor = Color.FromArgb(255, 227, 232);
            gbChefInformation.Controls.Add(txtSpeciality);
            gbChefInformation.Controls.Add(lblSpeciality);
            gbChefInformation.Controls.Add(txtGmail);
            gbChefInformation.Controls.Add(dtpStartDate);
            gbChefInformation.Controls.Add(txtPhoneNumber);
            gbChefInformation.Controls.Add(txtFullName);
            gbChefInformation.Controls.Add(lblGmail);
            gbChefInformation.Controls.Add(lblStartDate);
            gbChefInformation.Controls.Add(lblPhoneNumber);
            gbChefInformation.Controls.Add(lblFullName);
            gbChefInformation.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            gbChefInformation.Location = new Point(50, 63);
            gbChefInformation.Name = "gbChefInformation";
            gbChefInformation.Size = new Size(505, 450);
            gbChefInformation.TabIndex = 3;
            gbChefInformation.TabStop = false;
            gbChefInformation.Text = "Thông tin giáo viên";
            // 
            // txtGmail
            // 
            txtGmail.BorderStyle = BorderStyle.FixedSingle;
            txtGmail.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtGmail.Location = new Point(213, 395);
            txtGmail.Name = "txtGmail";
            txtGmail.Size = new Size(256, 34);
            txtGmail.TabIndex = 10;
            // 
            // dtpStartDate
            // 
            dtpStartDate.CustomFormat = "dd/MM/yyyy";
            dtpStartDate.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpStartDate.Format = DateTimePickerFormat.Custom;
            dtpStartDate.Location = new Point(213, 224);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(256, 34);
            dtpStartDate.TabIndex = 9;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.BorderStyle = BorderStyle.FixedSingle;
            txtPhoneNumber.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPhoneNumber.Location = new Point(213, 140);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(256, 34);
            txtPhoneNumber.TabIndex = 8;
            // 
            // txtFullName
            // 
            txtFullName.BorderStyle = BorderStyle.FixedSingle;
            txtFullName.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtFullName.Location = new Point(213, 57);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(256, 34);
            txtFullName.TabIndex = 7;
            // 
            // lblGmail
            // 
            lblGmail.AutoSize = true;
            lblGmail.BackColor = Color.FromArgb(255, 227, 232);
            lblGmail.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblGmail.ForeColor = Color.DarkRed;
            lblGmail.Location = new Point(40, 397);
            lblGmail.Name = "lblGmail";
            lblGmail.Size = new Size(72, 28);
            lblGmail.TabIndex = 6;
            lblGmail.Text = "Gmail:";
            // 
            // lblStartDate
            // 
            lblStartDate.AutoSize = true;
            lblStartDate.BackColor = Color.FromArgb(255, 227, 232);
            lblStartDate.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblStartDate.ForeColor = Color.DarkRed;
            lblStartDate.Location = new Point(40, 229);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new Size(148, 28);
            lblStartDate.TabIndex = 5;
            lblStartDate.Text = "Ngày vào làm:";
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.BackColor = Color.FromArgb(255, 227, 232);
            lblPhoneNumber.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPhoneNumber.ForeColor = Color.DarkRed;
            lblPhoneNumber.Location = new Point(40, 142);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(143, 28);
            lblPhoneNumber.TabIndex = 4;
            lblPhoneNumber.Text = "Số điện thoại:";
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.BackColor = Color.FromArgb(255, 227, 232);
            lblFullName.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblFullName.ForeColor = Color.DarkRed;
            lblFullName.Location = new Point(40, 59);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(143, 28);
            lblFullName.TabIndex = 3;
            lblFullName.Text = "Tên giáo viên:";
            // 
            // gbPersonalProfile
            // 
            gbPersonalProfile.BackColor = Color.FromArgb(255, 227, 232);
            gbPersonalProfile.Controls.Add(txtAddress);
            gbPersonalProfile.Controls.Add(lblAddress);
            gbPersonalProfile.Controls.Add(dtpDateOfBirth);
            gbPersonalProfile.Controls.Add(txtNativePlace);
            gbPersonalProfile.Controls.Add(txtCCCD);
            gbPersonalProfile.Controls.Add(lblDateOfBirth);
            gbPersonalProfile.Controls.Add(lblNativePlace);
            gbPersonalProfile.Controls.Add(lblCCCD);
            gbPersonalProfile.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            gbPersonalProfile.Location = new Point(631, 63);
            gbPersonalProfile.Name = "gbPersonalProfile";
            gbPersonalProfile.Size = new Size(505, 450);
            gbPersonalProfile.TabIndex = 4;
            gbPersonalProfile.TabStop = false;
            gbPersonalProfile.Text = "Thông tin cá nhân";
            // 
            // txtAddress
            // 
            txtAddress.BorderStyle = BorderStyle.FixedSingle;
            txtAddress.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtAddress.Location = new Point(213, 359);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(256, 34);
            txtAddress.TabIndex = 12;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.BackColor = Color.FromArgb(255, 227, 232);
            lblAddress.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblAddress.ForeColor = Color.DarkRed;
            lblAddress.Location = new Point(40, 363);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(83, 28);
            lblAddress.TabIndex = 11;
            lblAddress.Text = "Địa chỉ:";
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.CustomFormat = "dd/MM/yyyy";
            dtpDateOfBirth.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpDateOfBirth.Format = DateTimePickerFormat.Custom;
            dtpDateOfBirth.Location = new Point(213, 261);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(256, 34);
            dtpDateOfBirth.TabIndex = 9;
            // 
            // txtNativePlace
            // 
            txtNativePlace.BorderStyle = BorderStyle.FixedSingle;
            txtNativePlace.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNativePlace.Location = new Point(213, 162);
            txtNativePlace.Name = "txtNativePlace";
            txtNativePlace.Size = new Size(256, 34);
            txtNativePlace.TabIndex = 8;
            // 
            // txtCCCD
            // 
            txtCCCD.BorderStyle = BorderStyle.FixedSingle;
            txtCCCD.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCCCD.Location = new Point(213, 57);
            txtCCCD.Name = "txtCCCD";
            txtCCCD.Size = new Size(256, 34);
            txtCCCD.TabIndex = 7;
            // 
            // lblDateOfBirth
            // 
            lblDateOfBirth.AutoSize = true;
            lblDateOfBirth.BackColor = Color.FromArgb(255, 227, 232);
            lblDateOfBirth.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDateOfBirth.ForeColor = Color.DarkRed;
            lblDateOfBirth.Location = new Point(40, 266);
            lblDateOfBirth.Name = "lblDateOfBirth";
            lblDateOfBirth.Size = new Size(112, 28);
            lblDateOfBirth.TabIndex = 5;
            lblDateOfBirth.Text = "Ngày sinh:";
            // 
            // lblNativePlace
            // 
            lblNativePlace.AutoSize = true;
            lblNativePlace.BackColor = Color.FromArgb(255, 227, 232);
            lblNativePlace.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNativePlace.ForeColor = Color.DarkRed;
            lblNativePlace.Location = new Point(40, 164);
            lblNativePlace.Name = "lblNativePlace";
            lblNativePlace.Size = new Size(144, 28);
            lblNativePlace.TabIndex = 4;
            lblNativePlace.Text = "Nguyên quán:";
            // 
            // lblCCCD
            // 
            lblCCCD.AutoSize = true;
            lblCCCD.BackColor = Color.FromArgb(255, 227, 232);
            lblCCCD.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCCCD.ForeColor = Color.DarkRed;
            lblCCCD.Location = new Point(40, 59);
            lblCCCD.Name = "lblCCCD";
            lblCCCD.Size = new Size(66, 28);
            lblCCCD.TabIndex = 3;
            lblCCCD.Text = "CCCD:";
            // 
            // btnAdd
            // 
            btnAdd.BorderRadius = 40;
            btnAdd.ButtonColor = Color.DarkRed;
            btnAdd.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAdd.Location = new Point(1024, 529);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 39);
            btnAdd.TabIndex = 19;
            btnAdd.Text = "Thêm";
            btnAdd.TextColor = Color.White;
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // lblSpeciality
            // 
            lblSpeciality.AutoSize = true;
            lblSpeciality.BackColor = Color.FromArgb(255, 227, 232);
            lblSpeciality.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSpeciality.ForeColor = Color.DarkRed;
            lblSpeciality.Location = new Point(40, 314);
            lblSpeciality.Name = "lblSpeciality";
            lblSpeciality.Size = new Size(135, 28);
            lblSpeciality.TabIndex = 11;
            lblSpeciality.Text = "Chuyên môn:";
            // 
            // txtSpeciality
            // 
            txtSpeciality.BorderStyle = BorderStyle.FixedSingle;
            txtSpeciality.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSpeciality.Location = new Point(213, 312);
            txtSpeciality.Name = "txtSpeciality";
            txtSpeciality.Size = new Size(256, 34);
            txtSpeciality.TabIndex = 12;
            // 
            // CreateChef
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(251, 236, 240);
            ClientSize = new Size(1178, 594);
            Controls.Add(btnAdd);
            Controls.Add(gbPersonalProfile);
            Controls.Add(gbChefInformation);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CreateChef";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tạo giáo viên";
            gbChefInformation.ResumeLayout(false);
            gbChefInformation.PerformLayout();
            gbPersonalProfile.ResumeLayout(false);
            gbPersonalProfile.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox gbChefInformation;
        private TextBox txtPhoneNumber;
        private TextBox txtFullName;
        private Label lblGmail;
        private Label lblStartDate;
        private Label lblPhoneNumber;
        private Label lblFullName;
        private DateTimePicker dtpStartDate;
        private TextBox txtGmail;
        private GroupBox gbPersonalProfile;
        private DateTimePicker dtpDateOfBirth;
        private TextBox txtNativePlace;
        private TextBox txtCCCD;
        private Label lblDateOfBirth;
        private Label lblNativePlace;
        private Label lblCCCD;
        private CLASSROOM.RoundedButton btnAdd;
        private Label lblAddress;
        private TextBox txtAddress;
        private TextBox txtSpeciality;
        private Label lblSpeciality;
    }
}
namespace THE_COOKY_APP.GUI.ACCOUNT
{
    partial class CreateAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateAccount));
            gbAccountInformation = new GroupBox();
            cmbNameRole = new ComboBox();
            lblNameRole = new Label();
            txtPassword = new TextBox();
            txtPhoneNumber = new TextBox();
            lblPhoneNumber = new Label();
            txtGmail = new TextBox();
            txtUsername = new TextBox();
            txtFullName = new TextBox();
            lblGmail = new Label();
            lblPassword = new Label();
            lblUsername = new Label();
            lblFullName = new Label();
            gbProfileInformation = new GroupBox();
            txtAddress = new TextBox();
            lblAddress = new Label();
            dtpDateOfBirth = new DateTimePicker();
            txtNativePlace = new TextBox();
            txtCCCD = new TextBox();
            lblDateOfBirth = new Label();
            lblNativePlace = new Label();
            lblCCCD = new Label();
            btnAdd = new CLASSROOM.RoundedButton();
            gbAccountInformation.SuspendLayout();
            gbProfileInformation.SuspendLayout();
            SuspendLayout();
            // 
            // gbAccountInformation
            // 
            gbAccountInformation.BackColor = Color.FromArgb(255, 227, 232);
            gbAccountInformation.Controls.Add(cmbNameRole);
            gbAccountInformation.Controls.Add(lblNameRole);
            gbAccountInformation.Controls.Add(txtPassword);
            gbAccountInformation.Controls.Add(txtPhoneNumber);
            gbAccountInformation.Controls.Add(lblPhoneNumber);
            gbAccountInformation.Controls.Add(txtGmail);
            gbAccountInformation.Controls.Add(txtUsername);
            gbAccountInformation.Controls.Add(txtFullName);
            gbAccountInformation.Controls.Add(lblGmail);
            gbAccountInformation.Controls.Add(lblPassword);
            gbAccountInformation.Controls.Add(lblUsername);
            gbAccountInformation.Controls.Add(lblFullName);
            gbAccountInformation.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            gbAccountInformation.Location = new Point(64, 67);
            gbAccountInformation.Name = "gbAccountInformation";
            gbAccountInformation.Size = new Size(1152, 332);
            gbAccountInformation.TabIndex = 4;
            gbAccountInformation.TabStop = false;
            gbAccountInformation.Text = "Thông tin nhân viên";
            // 
            // cmbNameRole
            // 
            cmbNameRole.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbNameRole.FormattingEnabled = true;
            cmbNameRole.Items.AddRange(new object[] { "Nhân viên", "Giám đốc" });
            cmbNameRole.Location = new Point(813, 259);
            cmbNameRole.Name = "cmbNameRole";
            cmbNameRole.Size = new Size(256, 36);
            cmbNameRole.TabIndex = 15;
            // 
            // lblNameRole
            // 
            lblNameRole.AutoSize = true;
            lblNameRole.BackColor = Color.FromArgb(255, 227, 232);
            lblNameRole.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNameRole.ForeColor = Color.DarkRed;
            lblNameRole.Location = new Point(640, 264);
            lblNameRole.Name = "lblNameRole";
            lblNameRole.Size = new Size(93, 28);
            lblNameRole.TabIndex = 14;
            lblNameRole.Text = "Chức vụ:";
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(249, 261);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(256, 34);
            txtPassword.TabIndex = 13;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.BorderStyle = BorderStyle.FixedSingle;
            txtPhoneNumber.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPhoneNumber.Location = new Point(813, 153);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(256, 34);
            txtPhoneNumber.TabIndex = 12;
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.BackColor = Color.FromArgb(255, 227, 232);
            lblPhoneNumber.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPhoneNumber.ForeColor = Color.DarkRed;
            lblPhoneNumber.Location = new Point(640, 157);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(149, 28);
            lblPhoneNumber.TabIndex = 11;
            lblPhoneNumber.Text = "Số Điện Thoại:";
            // 
            // txtGmail
            // 
            txtGmail.BorderStyle = BorderStyle.FixedSingle;
            txtGmail.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtGmail.Location = new Point(813, 57);
            txtGmail.Name = "txtGmail";
            txtGmail.Size = new Size(256, 34);
            txtGmail.TabIndex = 10;
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(249, 154);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(256, 34);
            txtUsername.TabIndex = 8;
            // 
            // txtFullName
            // 
            txtFullName.BorderStyle = BorderStyle.FixedSingle;
            txtFullName.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtFullName.Location = new Point(249, 58);
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
            lblGmail.Location = new Point(640, 60);
            lblGmail.Name = "lblGmail";
            lblGmail.Size = new Size(72, 28);
            lblGmail.TabIndex = 6;
            lblGmail.Text = "Gmail:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.BackColor = Color.FromArgb(255, 227, 232);
            lblPassword.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPassword.ForeColor = Color.DarkRed;
            lblPassword.Location = new Point(76, 263);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(107, 28);
            lblPassword.TabIndex = 5;
            lblPassword.Text = "Mật khẩu:";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.BackColor = Color.FromArgb(255, 227, 232);
            lblUsername.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblUsername.ForeColor = Color.DarkRed;
            lblUsername.Location = new Point(76, 156);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(145, 28);
            lblUsername.TabIndex = 4;
            lblUsername.Text = "Tên tài khoản:";
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.BackColor = Color.FromArgb(255, 227, 232);
            lblFullName.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblFullName.ForeColor = Color.DarkRed;
            lblFullName.Location = new Point(76, 60);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(109, 28);
            lblFullName.TabIndex = 3;
            lblFullName.Text = "Họ và tên:";
            // 
            // gbProfileInformation
            // 
            gbProfileInformation.BackColor = Color.FromArgb(255, 227, 232);
            gbProfileInformation.Controls.Add(txtAddress);
            gbProfileInformation.Controls.Add(lblAddress);
            gbProfileInformation.Controls.Add(dtpDateOfBirth);
            gbProfileInformation.Controls.Add(txtNativePlace);
            gbProfileInformation.Controls.Add(txtCCCD);
            gbProfileInformation.Controls.Add(lblDateOfBirth);
            gbProfileInformation.Controls.Add(lblNativePlace);
            gbProfileInformation.Controls.Add(lblCCCD);
            gbProfileInformation.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            gbProfileInformation.Location = new Point(64, 455);
            gbProfileInformation.Name = "gbProfileInformation";
            gbProfileInformation.Size = new Size(1152, 200);
            gbProfileInformation.TabIndex = 5;
            gbProfileInformation.TabStop = false;
            gbProfileInformation.Text = "Thông tin cá nhân";
            // 
            // txtAddress
            // 
            txtAddress.BorderStyle = BorderStyle.FixedSingle;
            txtAddress.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtAddress.Location = new Point(813, 144);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(256, 34);
            txtAddress.TabIndex = 11;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.BackColor = Color.FromArgb(255, 227, 232);
            lblAddress.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblAddress.ForeColor = Color.DarkRed;
            lblAddress.Location = new Point(640, 146);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(83, 28);
            lblAddress.TabIndex = 10;
            lblAddress.Text = "Địa chỉ:";
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.CustomFormat = "dd/MM/yyyy";
            dtpDateOfBirth.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpDateOfBirth.Format = DateTimePickerFormat.Custom;
            dtpDateOfBirth.Location = new Point(249, 141);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(256, 34);
            dtpDateOfBirth.TabIndex = 9;
            // 
            // txtNativePlace
            // 
            txtNativePlace.BorderStyle = BorderStyle.FixedSingle;
            txtNativePlace.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNativePlace.Location = new Point(813, 57);
            txtNativePlace.Name = "txtNativePlace";
            txtNativePlace.Size = new Size(256, 34);
            txtNativePlace.TabIndex = 8;
            // 
            // txtCCCD
            // 
            txtCCCD.BorderStyle = BorderStyle.FixedSingle;
            txtCCCD.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCCCD.Location = new Point(249, 57);
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
            lblDateOfBirth.Location = new Point(76, 146);
            lblDateOfBirth.Name = "lblDateOfBirth";
            lblDateOfBirth.Size = new Size(112, 28);
            lblDateOfBirth.TabIndex = 5;
            lblDateOfBirth.Text = "Ngày sinh:";
            lblDateOfBirth.Click += label2_Click;
            // 
            // lblNativePlace
            // 
            lblNativePlace.AutoSize = true;
            lblNativePlace.BackColor = Color.FromArgb(255, 227, 232);
            lblNativePlace.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNativePlace.ForeColor = Color.DarkRed;
            lblNativePlace.Location = new Point(640, 59);
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
            lblCCCD.Location = new Point(76, 59);
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
            btnAdd.Location = new Point(1104, 697);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 39);
            btnAdd.TabIndex = 20;
            btnAdd.Text = "Thêm";
            btnAdd.TextColor = Color.White;
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // CreateAccount
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(251, 236, 240);
            ClientSize = new Size(1278, 794);
            Controls.Add(btnAdd);
            Controls.Add(gbProfileInformation);
            Controls.Add(gbAccountInformation);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CreateAccount";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tạo tài khoản";
            gbAccountInformation.ResumeLayout(false);
            gbAccountInformation.PerformLayout();
            gbProfileInformation.ResumeLayout(false);
            gbProfileInformation.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbAccountInformation;
        private TextBox txtGmail;
        private TextBox txtUsername;
        private TextBox txtFullName;
        private Label lblGmail;
        private Label lblPassword;
        private Label lblUsername;
        private Label lblFullName;
        private GroupBox gbProfileInformation;
        private DateTimePicker dtpDateOfBirth;
        private TextBox txtNativePlace;
        private TextBox txtCCCD;
        private Label lblDateOfBirth;
        private Label lblNativePlace;
        private Label lblCCCD;
        private TextBox txtPhoneNumber;
        private Label lblPhoneNumber;
        private TextBox txtPassword;
        private CLASSROOM.RoundedButton btnAdd;
        private Label lblNameRole;
        private ComboBox cmbNameRole;
        private TextBox txtAddress;
        private Label lblAddress;
    }
}
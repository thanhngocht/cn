namespace THE_COOKY_APP.GUI.ACCOUNT
{
    partial class ListAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListAccount));
            gbAction = new GroupBox();
            btnSave = new CLASSROOM.RoundedButton();
            btnSetUpFunction = new CLASSROOM.RoundedButton();
            btnDelete = new CLASSROOM.RoundedButton();
            btnPersonalProfile = new CLASSROOM.RoundedButton();
            btnUpdate = new CLASSROOM.RoundedButton();
            btnAdd = new CLASSROOM.RoundedButton();
            txtSearch = new TextBox();
            lblSearch = new Label();
            dgvListAccount = new DataGridView();
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
            gbAction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListAccount).BeginInit();
            gbAccountInformation.SuspendLayout();
            SuspendLayout();
            // 
            // gbAction
            // 
            gbAction.BackColor = Color.FromArgb(255, 227, 232);
            gbAction.Controls.Add(btnSave);
            gbAction.Controls.Add(btnSetUpFunction);
            gbAction.Controls.Add(btnDelete);
            gbAction.Controls.Add(btnPersonalProfile);
            gbAction.Controls.Add(btnUpdate);
            gbAction.Controls.Add(btnAdd);
            gbAction.Controls.Add(txtSearch);
            gbAction.Controls.Add(lblSearch);
            gbAction.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            gbAction.Location = new Point(35, 28);
            gbAction.Name = "gbAction";
            gbAction.Size = new Size(505, 253);
            gbAction.TabIndex = 10;
            gbAction.TabStop = false;
            gbAction.Text = "Thao tác";
            // 
            // btnSave
            // 
            btnSave.BorderRadius = 40;
            btnSave.ButtonColor = Color.DarkRed;
            btnSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSave.Location = new Point(369, 187);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 39);
            btnSave.TabIndex = 25;
            btnSave.Text = "Lưu";
            btnSave.TextColor = Color.White;
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnSetUpFunction
            // 
            btnSetUpFunction.BorderRadius = 40;
            btnSetUpFunction.ButtonColor = Color.DarkRed;
            btnSetUpFunction.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSetUpFunction.Location = new Point(200, 187);
            btnSetUpFunction.Name = "btnSetUpFunction";
            btnSetUpFunction.Size = new Size(122, 39);
            btnSetUpFunction.TabIndex = 24;
            btnSetUpFunction.Text = "Phân quyền";
            btnSetUpFunction.TextColor = Color.White;
            btnSetUpFunction.UseVisualStyleBackColor = true;
            btnSetUpFunction.Click += btnSetUpFunction_Click;
            // 
            // btnDelete
            // 
            btnDelete.BorderRadius = 40;
            btnDelete.ButtonColor = Color.DarkRed;
            btnDelete.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDelete.Location = new Point(204, 106);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 39);
            btnDelete.TabIndex = 23;
            btnDelete.Text = "Xóa";
            btnDelete.TextColor = Color.White;
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnPersonalProfile
            // 
            btnPersonalProfile.BorderRadius = 40;
            btnPersonalProfile.ButtonColor = Color.DarkRed;
            btnPersonalProfile.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnPersonalProfile.Location = new Point(31, 187);
            btnPersonalProfile.Name = "btnPersonalProfile";
            btnPersonalProfile.Size = new Size(112, 39);
            btnPersonalProfile.TabIndex = 22;
            btnPersonalProfile.Text = "Hồ sơ";
            btnPersonalProfile.TextColor = Color.White;
            btnPersonalProfile.UseVisualStyleBackColor = true;
            btnPersonalProfile.Click += btnPersonalProfile_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BorderRadius = 40;
            btnUpdate.ButtonColor = Color.DarkRed;
            btnUpdate.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnUpdate.Location = new Point(369, 106);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(112, 39);
            btnUpdate.TabIndex = 21;
            btnUpdate.Text = "Sửa";
            btnUpdate.TextColor = Color.White;
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.BorderRadius = 40;
            btnAdd.ButtonColor = Color.DarkRed;
            btnAdd.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAdd.Location = new Point(31, 106);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 39);
            btnAdd.TabIndex = 20;
            btnAdd.Text = "Thêm";
            btnAdd.TextColor = Color.White;
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
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
            // dgvListAccount
            // 
            dgvListAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListAccount.Location = new Point(574, 28);
            dgvListAccount.Name = "dgvListAccount";
            dgvListAccount.RowHeadersWidth = 62;
            dgvListAccount.Size = new Size(682, 772);
            dgvListAccount.TabIndex = 11;
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
            gbAccountInformation.Location = new Point(35, 308);
            gbAccountInformation.Name = "gbAccountInformation";
            gbAccountInformation.Size = new Size(505, 492);
            gbAccountInformation.TabIndex = 12;
            gbAccountInformation.TabStop = false;
            gbAccountInformation.Text = "Thông tin nhân viên";
            // 
            // cmbNameRole
            // 
            cmbNameRole.Enabled = false;
            cmbNameRole.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbNameRole.FormattingEnabled = true;
            cmbNameRole.Items.AddRange(new object[] { "Nhân viên", "Giám đốc" });
            cmbNameRole.Location = new Point(213, 435);
            cmbNameRole.Name = "cmbNameRole";
            cmbNameRole.Size = new Size(256, 36);
            cmbNameRole.TabIndex = 16;
            // 
            // lblNameRole
            // 
            lblNameRole.AutoSize = true;
            lblNameRole.BackColor = Color.FromArgb(255, 227, 232);
            lblNameRole.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNameRole.ForeColor = Color.DarkRed;
            lblNameRole.Location = new Point(40, 438);
            lblNameRole.Name = "lblNameRole";
            lblNameRole.Size = new Size(93, 28);
            lblNameRole.TabIndex = 14;
            lblNameRole.Text = "Chức vụ:";
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Enabled = false;
            txtPassword.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(213, 206);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(256, 34);
            txtPassword.TabIndex = 13;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.BorderStyle = BorderStyle.FixedSingle;
            txtPhoneNumber.Enabled = false;
            txtPhoneNumber.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPhoneNumber.Location = new Point(213, 356);
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
            lblPhoneNumber.Location = new Point(40, 358);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(149, 28);
            lblPhoneNumber.TabIndex = 11;
            lblPhoneNumber.Text = "Số Điện Thoại:";
            // 
            // txtGmail
            // 
            txtGmail.BorderStyle = BorderStyle.FixedSingle;
            txtGmail.Enabled = false;
            txtGmail.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtGmail.Location = new Point(213, 284);
            txtGmail.Name = "txtGmail";
            txtGmail.Size = new Size(256, 34);
            txtGmail.TabIndex = 10;
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Enabled = false;
            txtUsername.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(213, 133);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(256, 34);
            txtUsername.TabIndex = 8;
            // 
            // txtFullName
            // 
            txtFullName.BorderStyle = BorderStyle.FixedSingle;
            txtFullName.Enabled = false;
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
            lblGmail.Location = new Point(40, 286);
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
            lblPassword.Location = new Point(40, 208);
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
            lblUsername.Location = new Point(40, 135);
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
            lblFullName.Location = new Point(40, 59);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(109, 28);
            lblFullName.TabIndex = 3;
            lblFullName.Text = "Họ và tên:";
            // 
            // ListAccount
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(251, 236, 240);
            ClientSize = new Size(1278, 824);
            Controls.Add(gbAccountInformation);
            Controls.Add(dgvListAccount);
            Controls.Add(gbAction);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ListAccount";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Danh sách tài khoản";
            gbAction.ResumeLayout(false);
            gbAction.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListAccount).EndInit();
            gbAccountInformation.ResumeLayout(false);
            gbAccountInformation.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox gbAction;
        private CLASSROOM.RoundedButton btnDelete;
        private CLASSROOM.RoundedButton btnPersonalProfile;
        private CLASSROOM.RoundedButton btnUpdate;
        private CLASSROOM.RoundedButton btnAdd;
        private TextBox txtSearch;
        private Label lblSearch;
        private DataGridView dgvListAccount;
        private GroupBox gbAccountInformation;
        private Label lblNameRole;
        private TextBox txtPassword;
        private TextBox txtPhoneNumber;
        private Label lblPhoneNumber;
        private TextBox txtGmail;
        private TextBox txtUsername;
        private TextBox txtFullName;
        private Label lblGmail;
        private Label lblPassword;
        private Label lblUsername;
        private Label lblFullName;
        private CLASSROOM.RoundedButton btnSetUpFunction;
        private ComboBox cmbNameRole;
        private CLASSROOM.RoundedButton btnSave;
    }
}
namespace THE_COOKY_APP.GUI.CHEF
{
    partial class ListChef
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListChef));
            gbChefInformation = new GroupBox();
            txtSpeciality = new TextBox();
            lblSpeciality = new Label();
            txtGmail = new TextBox();
            dtpStartDate = new DateTimePicker();
            txtPhoneNumber = new TextBox();
            txtFullname = new TextBox();
            lblGmail = new Label();
            lblStartDate = new Label();
            lblPhoneNumber = new Label();
            lblFullName = new Label();
            dgvListChef = new DataGridView();
            gbAction = new GroupBox();
            btnSave = new CLASSROOM.RoundedButton();
            btnDelete = new CLASSROOM.RoundedButton();
            btnPersonalProfile = new CLASSROOM.RoundedButton();
            btnUpdate = new CLASSROOM.RoundedButton();
            btnAdd = new CLASSROOM.RoundedButton();
            txtSearch = new TextBox();
            lblSearch = new Label();
            gbChefInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListChef).BeginInit();
            gbAction.SuspendLayout();
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
            gbChefInformation.Controls.Add(txtFullname);
            gbChefInformation.Controls.Add(lblGmail);
            gbChefInformation.Controls.Add(lblStartDate);
            gbChefInformation.Controls.Add(lblPhoneNumber);
            gbChefInformation.Controls.Add(lblFullName);
            gbChefInformation.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            gbChefInformation.Location = new Point(25, 354);
            gbChefInformation.Name = "gbChefInformation";
            gbChefInformation.Size = new Size(505, 418);
            gbChefInformation.TabIndex = 6;
            gbChefInformation.TabStop = false;
            gbChefInformation.Text = "Thông tin giáo viên";
            // 
            // txtSpeciality
            // 
            txtSpeciality.BorderStyle = BorderStyle.FixedSingle;
            txtSpeciality.Enabled = false;
            txtSpeciality.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSpeciality.Location = new Point(213, 276);
            txtSpeciality.Name = "txtSpeciality";
            txtSpeciality.Size = new Size(256, 34);
            txtSpeciality.TabIndex = 14;
            // 
            // lblSpeciality
            // 
            lblSpeciality.AutoSize = true;
            lblSpeciality.BackColor = Color.FromArgb(255, 227, 232);
            lblSpeciality.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSpeciality.ForeColor = Color.DarkRed;
            lblSpeciality.Location = new Point(40, 278);
            lblSpeciality.Name = "lblSpeciality";
            lblSpeciality.Size = new Size(135, 28);
            lblSpeciality.TabIndex = 13;
            lblSpeciality.Text = "Chuyên môn:";
            // 
            // txtGmail
            // 
            txtGmail.BorderStyle = BorderStyle.FixedSingle;
            txtGmail.Enabled = false;
            txtGmail.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtGmail.Location = new Point(213, 347);
            txtGmail.Name = "txtGmail";
            txtGmail.Size = new Size(256, 34);
            txtGmail.TabIndex = 10;
            // 
            // dtpStartDate
            // 
            dtpStartDate.CustomFormat = "dd/MM/yyyy";
            dtpStartDate.Enabled = false;
            dtpStartDate.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpStartDate.Format = DateTimePickerFormat.Custom;
            dtpStartDate.Location = new Point(213, 202);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(256, 34);
            dtpStartDate.TabIndex = 9;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.BorderStyle = BorderStyle.FixedSingle;
            txtPhoneNumber.Enabled = false;
            txtPhoneNumber.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPhoneNumber.Location = new Point(213, 131);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(256, 34);
            txtPhoneNumber.TabIndex = 8;
            // 
            // txtFullname
            // 
            txtFullname.BorderStyle = BorderStyle.FixedSingle;
            txtFullname.Enabled = false;
            txtFullname.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtFullname.Location = new Point(213, 58);
            txtFullname.Name = "txtFullname";
            txtFullname.Size = new Size(256, 34);
            txtFullname.TabIndex = 7;
            // 
            // lblGmail
            // 
            lblGmail.AutoSize = true;
            lblGmail.BackColor = Color.FromArgb(255, 227, 232);
            lblGmail.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblGmail.ForeColor = Color.DarkRed;
            lblGmail.Location = new Point(40, 349);
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
            lblStartDate.Location = new Point(40, 207);
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
            lblPhoneNumber.Location = new Point(40, 133);
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
            lblFullName.Location = new Point(40, 60);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(143, 28);
            lblFullName.TabIndex = 3;
            lblFullName.Text = "Tên giáo viên:";
            // 
            // dgvListChef
            // 
            dgvListChef.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListChef.Location = new Point(572, 69);
            dgvListChef.Name = "dgvListChef";
            dgvListChef.RowHeadersWidth = 62;
            dgvListChef.Size = new Size(682, 703);
            dgvListChef.TabIndex = 8;
            // 
            // gbAction
            // 
            gbAction.BackColor = Color.FromArgb(255, 227, 232);
            gbAction.Controls.Add(btnSave);
            gbAction.Controls.Add(btnDelete);
            gbAction.Controls.Add(btnPersonalProfile);
            gbAction.Controls.Add(btnUpdate);
            gbAction.Controls.Add(btnAdd);
            gbAction.Controls.Add(txtSearch);
            gbAction.Controls.Add(lblSearch);
            gbAction.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            gbAction.Location = new Point(25, 69);
            gbAction.Name = "gbAction";
            gbAction.Size = new Size(505, 253);
            gbAction.TabIndex = 11;
            gbAction.TabStop = false;
            gbAction.Text = "Thao tác";
            // 
            // btnSave
            // 
            btnSave.BorderRadius = 40;
            btnSave.ButtonColor = Color.DarkRed;
            btnSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSave.Location = new Point(197, 147);
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
            btnDelete.Location = new Point(324, 106);
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
            btnPersonalProfile.Location = new Point(58, 187);
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
            btnUpdate.Location = new Point(324, 187);
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
            btnAdd.Location = new Point(58, 106);
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
            // ListChef
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(251, 236, 240);
            ClientSize = new Size(1278, 794);
            Controls.Add(gbAction);
            Controls.Add(dgvListChef);
            Controls.Add(gbChefInformation);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ListChef";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Danh sách đầu bếp";
            gbChefInformation.ResumeLayout(false);
            gbChefInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListChef).EndInit();
            gbAction.ResumeLayout(false);
            gbAction.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox gbChefInformation;
        private TextBox txtGmail;
        private DateTimePicker dtpStartDate;
        private TextBox txtPhoneNumber;
        private TextBox txtFullname;
        private Label lblGmail;
        private Label lblStartDate;
        private Label lblPhoneNumber;
        private Label lblFullName;
        private DataGridView dgvListChef;
        private GroupBox gbAction;
        private CLASSROOM.RoundedButton btnDelete;
        private CLASSROOM.RoundedButton btnPersonalProfile;
        private CLASSROOM.RoundedButton btnUpdate;
        private CLASSROOM.RoundedButton btnAdd;
        private TextBox txtSearch;
        private Label lblSearch;
        private CLASSROOM.RoundedButton btnSave;
        private TextBox txtSpeciality;
        private Label lblSpeciality;
    }
}
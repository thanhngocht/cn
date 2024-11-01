namespace THE_COOKY_APP.GUI.STUDENT
{
    partial class ListStudentInClass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListStudentInClass));
            gpClassroomInformation = new GroupBox();
            cmbChef = new ComboBox();
            lblChef = new Label();
            txtRealQuantity = new TextBox();
            label1 = new Label();
            txtFee = new TextBox();
            lblFee = new Label();
            cmbLocation = new ComboBox();
            lblLocation = new Label();
            txtNameClass = new TextBox();
            lblNameClass = new Label();
            gpRegisterInformation = new GroupBox();
            txtNameStudent = new TextBox();
            txtAddress = new TextBox();
            lblNameStudent = new Label();
            lblPhoneNumber = new Label();
            cmbFormPayment = new ComboBox();
            txtQuantityRegister = new TextBox();
            lblFormPayment = new Label();
            lblQuantityRegister = new Label();
            groupBox1 = new GroupBox();
            txtCodeMember = new TextBox();
            txtVoucher = new TextBox();
            txtCredit = new TextBox();
            txtApp = new TextBox();
            lblApp = new Label();
            lblCodeMember = new Label();
            lblVoucher = new Label();
            lblCredit = new Label();
            dataGridView1 = new DataGridView();
            gbAction = new GroupBox();
            btnCancel = new CLASSROOM.RoundedButton();
            btnUpdate = new CLASSROOM.RoundedButton();
            btnAdd = new CLASSROOM.RoundedButton();
            txtSearch = new TextBox();
            lblSearch = new Label();
            gpClassroomInformation.SuspendLayout();
            gpRegisterInformation.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            gbAction.SuspendLayout();
            SuspendLayout();
            // 
            // gpClassroomInformation
            // 
            gpClassroomInformation.BackColor = Color.FromArgb(255, 227, 232);
            gpClassroomInformation.Controls.Add(cmbChef);
            gpClassroomInformation.Controls.Add(lblChef);
            gpClassroomInformation.Controls.Add(txtRealQuantity);
            gpClassroomInformation.Controls.Add(label1);
            gpClassroomInformation.Controls.Add(txtFee);
            gpClassroomInformation.Controls.Add(lblFee);
            gpClassroomInformation.Controls.Add(cmbLocation);
            gpClassroomInformation.Controls.Add(lblLocation);
            gpClassroomInformation.Controls.Add(txtNameClass);
            gpClassroomInformation.Controls.Add(lblNameClass);
            gpClassroomInformation.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gpClassroomInformation.Location = new Point(61, 25);
            gpClassroomInformation.Name = "gpClassroomInformation";
            gpClassroomInformation.Size = new Size(531, 417);
            gpClassroomInformation.TabIndex = 3;
            gpClassroomInformation.TabStop = false;
            gpClassroomInformation.Text = "Thông tin lớp học";
            // 
            // cmbChef
            // 
            cmbChef.Enabled = false;
            cmbChef.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbChef.FormattingEnabled = true;
            cmbChef.Location = new Point(246, 130);
            cmbChef.Name = "cmbChef";
            cmbChef.Size = new Size(256, 36);
            cmbChef.TabIndex = 30;
            // 
            // lblChef
            // 
            lblChef.AutoSize = true;
            lblChef.BackColor = Color.FromArgb(255, 227, 232);
            lblChef.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblChef.ForeColor = Color.DarkRed;
            lblChef.Location = new Point(43, 133);
            lblChef.Name = "lblChef";
            lblChef.Size = new Size(106, 28);
            lblChef.TabIndex = 29;
            lblChef.Text = "Giáo viên:";
            // 
            // txtRealQuantity
            // 
            txtRealQuantity.BackColor = Color.White;
            txtRealQuantity.BorderStyle = BorderStyle.FixedSingle;
            txtRealQuantity.Enabled = false;
            txtRealQuantity.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtRealQuantity.Location = new Point(246, 359);
            txtRealQuantity.Name = "txtRealQuantity";
            txtRealQuantity.Size = new Size(256, 34);
            txtRealQuantity.TabIndex = 28;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 227, 232);
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(43, 361);
            label1.Name = "label1";
            label1.Size = new Size(180, 28);
            label1.TabIndex = 27;
            label1.Text = "Số lượng hiện tại:";
            // 
            // txtFee
            // 
            txtFee.BackColor = Color.White;
            txtFee.BorderStyle = BorderStyle.FixedSingle;
            txtFee.Enabled = false;
            txtFee.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtFee.Location = new Point(246, 287);
            txtFee.Name = "txtFee";
            txtFee.Size = new Size(256, 34);
            txtFee.TabIndex = 24;
            // 
            // lblFee
            // 
            lblFee.AutoSize = true;
            lblFee.BackColor = Color.FromArgb(255, 227, 232);
            lblFee.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblFee.ForeColor = Color.DarkRed;
            lblFee.Location = new Point(43, 289);
            lblFee.Name = "lblFee";
            lblFee.Size = new Size(83, 28);
            lblFee.TabIndex = 23;
            lblFee.Text = "Chi phí:";
            // 
            // cmbLocation
            // 
            cmbLocation.Enabled = false;
            cmbLocation.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbLocation.FormattingEnabled = true;
            cmbLocation.Location = new Point(246, 207);
            cmbLocation.Name = "cmbLocation";
            cmbLocation.Size = new Size(256, 36);
            cmbLocation.TabIndex = 9;
            // 
            // lblLocation
            // 
            lblLocation.AutoSize = true;
            lblLocation.BackColor = Color.FromArgb(255, 227, 232);
            lblLocation.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblLocation.ForeColor = Color.DarkRed;
            lblLocation.Location = new Point(43, 210);
            lblLocation.Name = "lblLocation";
            lblLocation.Size = new Size(103, 28);
            lblLocation.TabIndex = 8;
            lblLocation.Text = "Địa điểm:";
            // 
            // txtNameClass
            // 
            txtNameClass.BackColor = Color.White;
            txtNameClass.BorderStyle = BorderStyle.FixedSingle;
            txtNameClass.Enabled = false;
            txtNameClass.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNameClass.Location = new Point(246, 53);
            txtNameClass.Name = "txtNameClass";
            txtNameClass.Size = new Size(256, 34);
            txtNameClass.TabIndex = 5;
            // 
            // lblNameClass
            // 
            lblNameClass.AutoSize = true;
            lblNameClass.BackColor = Color.FromArgb(255, 227, 232);
            lblNameClass.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNameClass.ForeColor = Color.DarkRed;
            lblNameClass.Location = new Point(43, 55);
            lblNameClass.Name = "lblNameClass";
            lblNameClass.Size = new Size(127, 28);
            lblNameClass.TabIndex = 4;
            lblNameClass.Text = "Tên lớp học:";
            // 
            // gpRegisterInformation
            // 
            gpRegisterInformation.BackColor = Color.FromArgb(255, 227, 232);
            gpRegisterInformation.Controls.Add(txtNameStudent);
            gpRegisterInformation.Controls.Add(txtAddress);
            gpRegisterInformation.Controls.Add(lblNameStudent);
            gpRegisterInformation.Controls.Add(lblPhoneNumber);
            gpRegisterInformation.Controls.Add(cmbFormPayment);
            gpRegisterInformation.Controls.Add(txtQuantityRegister);
            gpRegisterInformation.Controls.Add(lblFormPayment);
            gpRegisterInformation.Controls.Add(lblQuantityRegister);
            gpRegisterInformation.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gpRegisterInformation.Location = new Point(61, 465);
            gpRegisterInformation.Name = "gpRegisterInformation";
            gpRegisterInformation.Size = new Size(531, 346);
            gpRegisterInformation.TabIndex = 4;
            gpRegisterInformation.TabStop = false;
            gpRegisterInformation.Text = "Thông tin học viên ghi danh";
            // 
            // txtNameStudent
            // 
            txtNameStudent.BorderStyle = BorderStyle.FixedSingle;
            txtNameStudent.Enabled = false;
            txtNameStudent.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNameStudent.Location = new Point(246, 54);
            txtNameStudent.Name = "txtNameStudent";
            txtNameStudent.Size = new Size(256, 34);
            txtNameStudent.TabIndex = 34;
            // 
            // txtAddress
            // 
            txtAddress.BorderStyle = BorderStyle.FixedSingle;
            txtAddress.Enabled = false;
            txtAddress.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtAddress.Location = new Point(246, 130);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(256, 34);
            txtAddress.TabIndex = 35;
            // 
            // lblNameStudent
            // 
            lblNameStudent.AutoSize = true;
            lblNameStudent.BackColor = Color.FromArgb(255, 227, 232);
            lblNameStudent.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNameStudent.ForeColor = Color.DarkRed;
            lblNameStudent.Location = new Point(31, 54);
            lblNameStudent.Name = "lblNameStudent";
            lblNameStudent.Size = new Size(136, 28);
            lblNameStudent.TabIndex = 32;
            lblNameStudent.Text = "Tên học viên:";
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.BackColor = Color.FromArgb(255, 227, 232);
            lblPhoneNumber.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPhoneNumber.ForeColor = Color.DarkRed;
            lblPhoneNumber.Location = new Point(31, 130);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(143, 28);
            lblPhoneNumber.TabIndex = 33;
            lblPhoneNumber.Text = "Số điện thoại:";
            // 
            // cmbFormPayment
            // 
            cmbFormPayment.Enabled = false;
            cmbFormPayment.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbFormPayment.FormattingEnabled = true;
            cmbFormPayment.Location = new Point(246, 284);
            cmbFormPayment.Name = "cmbFormPayment";
            cmbFormPayment.Size = new Size(256, 36);
            cmbFormPayment.TabIndex = 31;
            // 
            // txtQuantityRegister
            // 
            txtQuantityRegister.BackColor = Color.White;
            txtQuantityRegister.BorderStyle = BorderStyle.FixedSingle;
            txtQuantityRegister.Enabled = false;
            txtQuantityRegister.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtQuantityRegister.Location = new Point(246, 206);
            txtQuantityRegister.Name = "txtQuantityRegister";
            txtQuantityRegister.Size = new Size(256, 34);
            txtQuantityRegister.TabIndex = 30;
            // 
            // lblFormPayment
            // 
            lblFormPayment.AutoSize = true;
            lblFormPayment.BackColor = Color.FromArgb(255, 227, 232);
            lblFormPayment.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblFormPayment.ForeColor = Color.DarkRed;
            lblFormPayment.Location = new Point(31, 287);
            lblFormPayment.Name = "lblFormPayment";
            lblFormPayment.Size = new Size(125, 28);
            lblFormPayment.TabIndex = 29;
            lblFormPayment.Text = "Thanh toán:";
            // 
            // lblQuantityRegister
            // 
            lblQuantityRegister.AutoSize = true;
            lblQuantityRegister.BackColor = Color.FromArgb(255, 227, 232);
            lblQuantityRegister.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblQuantityRegister.ForeColor = Color.DarkRed;
            lblQuantityRegister.Location = new Point(31, 208);
            lblQuantityRegister.Name = "lblQuantityRegister";
            lblQuantityRegister.Size = new Size(179, 28);
            lblQuantityRegister.TabIndex = 28;
            lblQuantityRegister.Text = "Số lượng đăng kí:";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(255, 227, 232);
            groupBox1.Controls.Add(txtCodeMember);
            groupBox1.Controls.Add(txtVoucher);
            groupBox1.Controls.Add(txtCredit);
            groupBox1.Controls.Add(txtApp);
            groupBox1.Controls.Add(lblApp);
            groupBox1.Controls.Add(lblCodeMember);
            groupBox1.Controls.Add(lblVoucher);
            groupBox1.Controls.Add(lblCredit);
            groupBox1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(61, 832);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(531, 290);
            groupBox1.TabIndex = 25;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ưu đãi";
            // 
            // txtCodeMember
            // 
            txtCodeMember.BackColor = Color.White;
            txtCodeMember.BorderStyle = BorderStyle.FixedSingle;
            txtCodeMember.Enabled = false;
            txtCodeMember.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCodeMember.Location = new Point(246, 238);
            txtCodeMember.Name = "txtCodeMember";
            txtCodeMember.Size = new Size(256, 34);
            txtCodeMember.TabIndex = 38;
            // 
            // txtVoucher
            // 
            txtVoucher.BackColor = Color.White;
            txtVoucher.BorderStyle = BorderStyle.FixedSingle;
            txtVoucher.Enabled = false;
            txtVoucher.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtVoucher.Location = new Point(246, 171);
            txtVoucher.Name = "txtVoucher";
            txtVoucher.Size = new Size(256, 34);
            txtVoucher.TabIndex = 37;
            // 
            // txtCredit
            // 
            txtCredit.BackColor = Color.White;
            txtCredit.BorderStyle = BorderStyle.FixedSingle;
            txtCredit.Enabled = false;
            txtCredit.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCredit.Location = new Point(246, 101);
            txtCredit.Name = "txtCredit";
            txtCredit.Size = new Size(256, 34);
            txtCredit.TabIndex = 36;
            // 
            // txtApp
            // 
            txtApp.BackColor = Color.White;
            txtApp.BorderStyle = BorderStyle.FixedSingle;
            txtApp.Enabled = false;
            txtApp.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtApp.Location = new Point(246, 32);
            txtApp.Name = "txtApp";
            txtApp.Size = new Size(256, 34);
            txtApp.TabIndex = 32;
            // 
            // lblApp
            // 
            lblApp.AutoSize = true;
            lblApp.BackColor = Color.FromArgb(255, 227, 232);
            lblApp.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblApp.ForeColor = Color.DarkRed;
            lblApp.Location = new Point(58, 34);
            lblApp.Name = "lblApp";
            lblApp.Size = new Size(55, 28);
            lblApp.TabIndex = 29;
            lblApp.Text = "APP:";
            // 
            // lblCodeMember
            // 
            lblCodeMember.AutoSize = true;
            lblCodeMember.BackColor = Color.FromArgb(255, 227, 232);
            lblCodeMember.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCodeMember.ForeColor = Color.DarkRed;
            lblCodeMember.Location = new Point(58, 240);
            lblCodeMember.Name = "lblCodeMember";
            lblCodeMember.Size = new Size(129, 28);
            lblCodeMember.TabIndex = 35;
            lblCodeMember.Text = "CODE / THẺ:";
            // 
            // lblVoucher
            // 
            lblVoucher.AutoSize = true;
            lblVoucher.BackColor = Color.FromArgb(255, 227, 232);
            lblVoucher.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblVoucher.ForeColor = Color.DarkRed;
            lblVoucher.Location = new Point(58, 173);
            lblVoucher.Name = "lblVoucher";
            lblVoucher.Size = new Size(110, 28);
            lblVoucher.TabIndex = 34;
            lblVoucher.Text = "VOUCHER:";
            // 
            // lblCredit
            // 
            lblCredit.AutoSize = true;
            lblCredit.BackColor = Color.FromArgb(255, 227, 232);
            lblCredit.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCredit.ForeColor = Color.DarkRed;
            lblCredit.Location = new Point(58, 103);
            lblCredit.Name = "lblCredit";
            lblCredit.Size = new Size(86, 28);
            lblCredit.TabIndex = 33;
            lblCredit.Text = "CREDIT:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(628, 232);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(614, 858);
            dataGridView1.TabIndex = 26;
            // 
            // gbAction
            // 
            gbAction.BackColor = Color.FromArgb(255, 227, 232);
            gbAction.Controls.Add(btnCancel);
            gbAction.Controls.Add(btnUpdate);
            gbAction.Controls.Add(btnAdd);
            gbAction.Controls.Add(txtSearch);
            gbAction.Controls.Add(lblSearch);
            gbAction.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            gbAction.Location = new Point(628, 25);
            gbAction.Name = "gbAction";
            gbAction.Size = new Size(614, 179);
            gbAction.TabIndex = 27;
            gbAction.TabStop = false;
            gbAction.Text = "Thao tác";
            // 
            // btnCancel
            // 
            btnCancel.BorderRadius = 40;
            btnCancel.ButtonColor = Color.DarkRed;
            btnCancel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCancel.Location = new Point(259, 106);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 39);
            btnCancel.TabIndex = 23;
            btnCancel.Text = "Xóa";
            btnCancel.TextColor = Color.White;
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.BorderRadius = 40;
            btnUpdate.ButtonColor = Color.DarkRed;
            btnUpdate.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnUpdate.Location = new Point(456, 106);
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
            btnAdd.Location = new Point(53, 106);
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
            txtSearch.Location = new Point(252, 50);
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
            lblSearch.Location = new Point(76, 52);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(105, 28);
            lblSearch.TabIndex = 7;
            lblSearch.Text = "Tìm kiếm:";
            // 
            // ListStudentInClass
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(251, 236, 240);
            ClientSize = new Size(1278, 1050);
            Controls.Add(gbAction);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Controls.Add(gpRegisterInformation);
            Controls.Add(gpClassroomInformation);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ListStudentInClass";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Danh sách học viên trong lớp";
            gpClassroomInformation.ResumeLayout(false);
            gpClassroomInformation.PerformLayout();
            gpRegisterInformation.ResumeLayout(false);
            gpRegisterInformation.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            gbAction.ResumeLayout(false);
            gbAction.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gpClassroomInformation;
        private ComboBox cmbChef;
        private Label lblChef;
        private TextBox txtRealQuantity;
        private Label label1;
        private TextBox txtFee;
        private Label lblFee;
        private ComboBox cmbLocation;
        private Label lblLocation;
        private TextBox txtNameClass;
        private Label lblNameClass;
        private GroupBox gpRegisterInformation;
        private ComboBox cmbFormPayment;
        private TextBox txtQuantityRegister;
        private Label lblFormPayment;
        private Label lblQuantityRegister;
        private GroupBox groupBox1;
        private TextBox txtCodeMember;
        private TextBox txtVoucher;
        private TextBox txtCredit;
        private TextBox txtApp;
        private Label lblApp;
        private Label lblCodeMember;
        private Label lblVoucher;
        private Label lblCredit;
        private TextBox txtNameStudent;
        private TextBox txtAddress;
        private Label lblNameStudent;
        private Label lblPhoneNumber;
        private DataGridView dataGridView1;
        private GroupBox gbAction;
        private CLASSROOM.RoundedButton btnCancel;
        private CLASSROOM.RoundedButton btnUpdate;
        private CLASSROOM.RoundedButton btnAdd;
        private TextBox txtSearch;
        private Label lblSearch;
    }
}
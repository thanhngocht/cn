namespace THE_COOKY_APP.GUI.LOCATION
{
    partial class ListLocation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListLocation));
            gbLocationInformation = new GroupBox();
            txtDiscription = new TextBox();
            txtQuantity = new TextBox();
            txtAddress = new TextBox();
            txtNameLocation = new TextBox();
            lblDiscription = new Label();
            lblQuantity = new Label();
            lblAddress = new Label();
            lblNameLocation = new Label();
            dgvListLocation = new DataGridView();
            gbAction = new GroupBox();
            btnCancel = new CLASSROOM.RoundedButton();
            btnUpdate = new CLASSROOM.RoundedButton();
            btnAdd = new CLASSROOM.RoundedButton();
            txtSearch = new TextBox();
            lblSearch = new Label();
            gbLocationInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListLocation).BeginInit();
            gbAction.SuspendLayout();
            SuspendLayout();
            // 
            // gbLocationInformation
            // 
            gbLocationInformation.BackColor = Color.FromArgb(255, 227, 232);
            gbLocationInformation.Controls.Add(txtDiscription);
            gbLocationInformation.Controls.Add(txtQuantity);
            gbLocationInformation.Controls.Add(txtAddress);
            gbLocationInformation.Controls.Add(txtNameLocation);
            gbLocationInformation.Controls.Add(lblDiscription);
            gbLocationInformation.Controls.Add(lblQuantity);
            gbLocationInformation.Controls.Add(lblAddress);
            gbLocationInformation.Controls.Add(lblNameLocation);
            gbLocationInformation.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            gbLocationInformation.Location = new Point(31, 282);
            gbLocationInformation.Name = "gbLocationInformation";
            gbLocationInformation.Size = new Size(505, 475);
            gbLocationInformation.TabIndex = 9;
            gbLocationInformation.TabStop = false;
            gbLocationInformation.Text = "Thông tin địa điểm";
            // 
            // txtDiscription
            // 
            txtDiscription.BorderStyle = BorderStyle.FixedSingle;
            txtDiscription.Enabled = false;
            txtDiscription.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDiscription.Location = new Point(213, 342);
            txtDiscription.Multiline = true;
            txtDiscription.Name = "txtDiscription";
            txtDiscription.Size = new Size(256, 96);
            txtDiscription.TabIndex = 10;
            // 
            // txtQuantity
            // 
            txtQuantity.BorderStyle = BorderStyle.FixedSingle;
            txtQuantity.Enabled = false;
            txtQuantity.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtQuantity.Location = new Point(213, 247);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(256, 34);
            txtQuantity.TabIndex = 9;
            // 
            // txtAddress
            // 
            txtAddress.BorderStyle = BorderStyle.FixedSingle;
            txtAddress.Enabled = false;
            txtAddress.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtAddress.Location = new Point(213, 150);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(256, 34);
            txtAddress.TabIndex = 8;
            // 
            // txtNameLocation
            // 
            txtNameLocation.BorderStyle = BorderStyle.FixedSingle;
            txtNameLocation.Enabled = false;
            txtNameLocation.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNameLocation.Location = new Point(213, 58);
            txtNameLocation.Name = "txtNameLocation";
            txtNameLocation.Size = new Size(256, 34);
            txtNameLocation.TabIndex = 7;
            // 
            // lblDiscription
            // 
            lblDiscription.AutoSize = true;
            lblDiscription.BackColor = Color.FromArgb(255, 227, 232);
            lblDiscription.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDiscription.ForeColor = Color.DarkRed;
            lblDiscription.Location = new Point(40, 344);
            lblDiscription.Name = "lblDiscription";
            lblDiscription.Size = new Size(73, 28);
            lblDiscription.TabIndex = 6;
            lblDiscription.Text = "Mô tả:";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.BackColor = Color.FromArgb(255, 227, 232);
            lblQuantity.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblQuantity.ForeColor = Color.DarkRed;
            lblQuantity.Location = new Point(40, 249);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(103, 28);
            lblQuantity.TabIndex = 5;
            lblQuantity.Text = "Sức chứa:";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.BackColor = Color.FromArgb(255, 227, 232);
            lblAddress.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblAddress.ForeColor = Color.DarkRed;
            lblAddress.Location = new Point(40, 152);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(83, 28);
            lblAddress.TabIndex = 4;
            lblAddress.Text = "Địa chỉ:";
            // 
            // lblNameLocation
            // 
            lblNameLocation.AutoSize = true;
            lblNameLocation.BackColor = Color.FromArgb(255, 227, 232);
            lblNameLocation.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNameLocation.ForeColor = Color.DarkRed;
            lblNameLocation.Location = new Point(40, 60);
            lblNameLocation.Name = "lblNameLocation";
            lblNameLocation.Size = new Size(140, 28);
            lblNameLocation.TabIndex = 3;
            lblNameLocation.Text = "Tên địa điểm:";
            // 
            // dgvListLocation
            // 
            dgvListLocation.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListLocation.Location = new Point(571, 46);
            dgvListLocation.Name = "dgvListLocation";
            dgvListLocation.RowHeadersWidth = 62;
            dgvListLocation.Size = new Size(682, 711);
            dgvListLocation.TabIndex = 11;
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
            gbAction.Location = new Point(31, 46);
            gbAction.Name = "gbAction";
            gbAction.Size = new Size(505, 189);
            gbAction.TabIndex = 12;
            gbAction.TabStop = false;
            gbAction.Text = "Thao tác";
            // 
            // btnCancel
            // 
            btnCancel.BorderRadius = 40;
            btnCancel.ButtonColor = Color.DarkRed;
            btnCancel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCancel.Location = new Point(192, 110);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 39);
            btnCancel.TabIndex = 28;
            btnCancel.Text = "Xóa";
            btnCancel.TextColor = Color.White;
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.BorderRadius = 40;
            btnUpdate.ButtonColor = Color.DarkRed;
            btnUpdate.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnUpdate.Location = new Point(347, 110);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(112, 39);
            btnUpdate.TabIndex = 27;
            btnUpdate.Text = "Sửa";
            btnUpdate.TextColor = Color.White;
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.BorderRadius = 40;
            btnAdd.ButtonColor = Color.DarkRed;
            btnAdd.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAdd.Location = new Point(39, 110);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 39);
            btnAdd.TabIndex = 26;
            btnAdd.Text = "Thêm";
            btnAdd.TextColor = Color.White;
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(215, 43);
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
            lblSearch.Location = new Point(39, 45);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(105, 28);
            lblSearch.TabIndex = 7;
            lblSearch.Text = "Tìm kiếm:";
            // 
            // ListLocation
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(251, 236, 240);
            ClientSize = new Size(1278, 794);
            Controls.Add(gbAction);
            Controls.Add(dgvListLocation);
            Controls.Add(gbLocationInformation);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ListLocation";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Danh sách địa điểm";
            gbLocationInformation.ResumeLayout(false);
            gbLocationInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListLocation).EndInit();
            gbAction.ResumeLayout(false);
            gbAction.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox gbLocationInformation;
        private TextBox txtDiscription;
        private TextBox txtQuantity;
        private TextBox txtAddress;
        private TextBox txtNameLocation;
        private Label lblDiscription;
        private Label lblQuantity;
        private Label lblAddress;
        private Label lblNameLocation;
        private DataGridView dgvListLocation;
        private GroupBox gbAction;
        private CLASSROOM.RoundedButton btnCancel;
        private CLASSROOM.RoundedButton btnUpdate;
        private CLASSROOM.RoundedButton btnAdd;
        private TextBox txtSearch;
        private Label lblSearch;
    }
}
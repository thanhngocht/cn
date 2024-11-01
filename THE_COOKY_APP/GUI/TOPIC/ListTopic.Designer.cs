namespace THE_COOKY_APP.GUI.TOPIC
{
    partial class ListTopic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListTopic));
            dgvListTopic = new DataGridView();
            gbTopicInformation = new GroupBox();
            txtTopic = new TextBox();
            lblTopic = new Label();
            gbAction = new GroupBox();
            btnSave = new CLASSROOM.RoundedButton();
            btnDelete = new CLASSROOM.RoundedButton();
            btnUpdate = new CLASSROOM.RoundedButton();
            btnAdd = new CLASSROOM.RoundedButton();
            txtSearch = new TextBox();
            lblSearch = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvListTopic).BeginInit();
            gbTopicInformation.SuspendLayout();
            gbAction.SuspendLayout();
            SuspendLayout();
            // 
            // dgvListTopic
            // 
            dgvListTopic.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListTopic.Location = new Point(568, 56);
            dgvListTopic.Name = "dgvListTopic";
            dgvListTopic.RowHeadersWidth = 62;
            dgvListTopic.Size = new Size(682, 419);
            dgvListTopic.TabIndex = 11;
            // 
            // gbTopicInformation
            // 
            gbTopicInformation.BackColor = Color.FromArgb(255, 227, 232);
            gbTopicInformation.Controls.Add(txtTopic);
            gbTopicInformation.Controls.Add(lblTopic);
            gbTopicInformation.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            gbTopicInformation.Location = new Point(26, 344);
            gbTopicInformation.Name = "gbTopicInformation";
            gbTopicInformation.Size = new Size(505, 131);
            gbTopicInformation.TabIndex = 24;
            gbTopicInformation.TabStop = false;
            gbTopicInformation.Text = "Thông tin chủ đề";
            // 
            // txtTopic
            // 
            txtTopic.BackColor = Color.White;
            txtTopic.BorderStyle = BorderStyle.FixedSingle;
            txtTopic.Enabled = false;
            txtTopic.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTopic.Location = new Point(213, 55);
            txtTopic.Name = "txtTopic";
            txtTopic.Size = new Size(256, 34);
            txtTopic.TabIndex = 4;
            // 
            // lblTopic
            // 
            lblTopic.AutoSize = true;
            lblTopic.BackColor = Color.FromArgb(255, 227, 232);
            lblTopic.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTopic.ForeColor = Color.DarkRed;
            lblTopic.Location = new Point(27, 57);
            lblTopic.Name = "lblTopic";
            lblTopic.Size = new Size(120, 28);
            lblTopic.TabIndex = 3;
            lblTopic.Text = "Tên chủ đề:";
            // 
            // gbAction
            // 
            gbAction.BackColor = Color.FromArgb(255, 227, 232);
            gbAction.Controls.Add(btnSave);
            gbAction.Controls.Add(btnDelete);
            gbAction.Controls.Add(btnUpdate);
            gbAction.Controls.Add(btnAdd);
            gbAction.Controls.Add(txtSearch);
            gbAction.Controls.Add(lblSearch);
            gbAction.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            gbAction.Location = new Point(26, 56);
            gbAction.Name = "gbAction";
            gbAction.Size = new Size(505, 239);
            gbAction.TabIndex = 25;
            gbAction.TabStop = false;
            gbAction.Text = "Thao tác";
            // 
            // btnSave
            // 
            btnSave.BorderRadius = 40;
            btnSave.ButtonColor = Color.DarkRed;
            btnSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSave.Location = new Point(319, 175);
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
            btnDelete.Location = new Point(319, 106);
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
            btnUpdate.Location = new Point(70, 175);
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
            btnAdd.Location = new Point(70, 106);
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
            // ListTopic
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(251, 236, 240);
            ClientSize = new Size(1278, 544);
            Controls.Add(gbAction);
            Controls.Add(gbTopicInformation);
            Controls.Add(dgvListTopic);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ListTopic";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Danh sách chủ đề";
            ((System.ComponentModel.ISupportInitialize)dgvListTopic).EndInit();
            gbTopicInformation.ResumeLayout(false);
            gbTopicInformation.PerformLayout();
            gbAction.ResumeLayout(false);
            gbAction.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgvListTopic;
        private GroupBox gbTopicInformation;
        private TextBox txtTopic;
        private Label lblTopic;
        private GroupBox gbAction;
        private CLASSROOM.RoundedButton btnDelete;
        private CLASSROOM.RoundedButton btnUpdate;
        private CLASSROOM.RoundedButton btnAdd;
        private TextBox txtSearch;
        private Label lblSearch;
        private CLASSROOM.RoundedButton btnSave;
    }
}
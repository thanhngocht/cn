using System.Security.Principal;

namespace THE_COOKY_APP.GUI.CLASSROOM
{
    partial class CreateClassroom
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateClassroom));
            gbBasicInformation = new GroupBox();
            cmbChef = new ComboBox();
            cmbSponsor = new ComboBox();
            lblSponsor = new Label();
            cmbTopic = new ComboBox();
            lblTopic = new Label();
            txtQuantity = new TextBox();
            lblQuantity = new Label();
            cmbForm = new ComboBox();
            lblForm = new Label();
            txtFee = new TextBox();
            lblFee = new Label();
            cmbLocation = new ComboBox();
            lblLocation = new Label();
            lblChef = new Label();
            txtNameClass = new TextBox();
            lblNameClass = new Label();
            txtDiscription = new TextBox();
            lblDiscription = new Label();
            gbClassTimer = new GroupBox();
            txtOrganizationDay = new ListBox();
            lblOrganizationDay = new Label();
            mcOrganizationDay = new MonthCalendar();
            txtDurationHour = new TextBox();
            dtpEndHour = new DateTimePicker();
            dtpStartHour = new DateTimePicker();
            lblDurationHour = new Label();
            lblEndHour = new Label();
            lblStartHour = new Label();
            gbDiscriptionPicture = new GroupBox();
            rpbPicture = new RoundedPictureBox();
            btnLoadPicture = new RoundedButton();
            lblPicture = new Label();
            btnAdd = new RoundedButton();
            gbBasicInformation.SuspendLayout();
            gbClassTimer.SuspendLayout();
            gbDiscriptionPicture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)rpbPicture).BeginInit();
            SuspendLayout();
            // 
            // gbBasicInformation
            // 
            gbBasicInformation.BackColor = Color.FromArgb(255, 227, 232);
            gbBasicInformation.Controls.Add(cmbChef);
            gbBasicInformation.Controls.Add(cmbSponsor);
            gbBasicInformation.Controls.Add(lblSponsor);
            gbBasicInformation.Controls.Add(cmbTopic);
            gbBasicInformation.Controls.Add(lblTopic);
            gbBasicInformation.Controls.Add(txtQuantity);
            gbBasicInformation.Controls.Add(lblQuantity);
            gbBasicInformation.Controls.Add(cmbForm);
            gbBasicInformation.Controls.Add(lblForm);
            gbBasicInformation.Controls.Add(txtFee);
            gbBasicInformation.Controls.Add(lblFee);
            gbBasicInformation.Controls.Add(cmbLocation);
            gbBasicInformation.Controls.Add(lblLocation);
            gbBasicInformation.Controls.Add(lblChef);
            gbBasicInformation.Controls.Add(txtNameClass);
            gbBasicInformation.Controls.Add(lblNameClass);
            gbBasicInformation.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            gbBasicInformation.Location = new Point(59, 36);
            gbBasicInformation.Name = "gbBasicInformation";
            gbBasicInformation.Size = new Size(1162, 384);
            gbBasicInformation.TabIndex = 1;
            gbBasicInformation.TabStop = false;
            gbBasicInformation.Text = "Thông tin cơ bản";
            // 
            // cmbChef
            // 
            cmbChef.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbChef.FormattingEnabled = true;
            cmbChef.Location = new Point(278, 135);
            cmbChef.Name = "cmbChef";
            cmbChef.Size = new Size(256, 36);
            cmbChef.TabIndex = 20;
            // 
            // cmbSponsor
            // 
            cmbSponsor.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbSponsor.FormattingEnabled = true;
            cmbSponsor.Location = new Point(858, 138);
            cmbSponsor.Name = "cmbSponsor";
            cmbSponsor.Size = new Size(256, 36);
            cmbSponsor.TabIndex = 19;
            // 
            // lblSponsor
            // 
            lblSponsor.AutoSize = true;
            lblSponsor.BackColor = Color.FromArgb(255, 227, 232);
            lblSponsor.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSponsor.ForeColor = Color.DarkRed;
            lblSponsor.Location = new Point(665, 138);
            lblSponsor.Name = "lblSponsor";
            lblSponsor.Size = new Size(122, 28);
            lblSponsor.TabIndex = 18;
            lblSponsor.Text = "Nhà tài trợ:";
            // 
            // cmbTopic
            // 
            cmbTopic.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbTopic.FormattingEnabled = true;
            cmbTopic.Location = new Point(858, 309);
            cmbTopic.Name = "cmbTopic";
            cmbTopic.Size = new Size(256, 36);
            cmbTopic.TabIndex = 17;
            // 
            // lblTopic
            // 
            lblTopic.AutoSize = true;
            lblTopic.BackColor = Color.FromArgb(255, 227, 232);
            lblTopic.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTopic.ForeColor = Color.DarkRed;
            lblTopic.Location = new Point(665, 312);
            lblTopic.Name = "lblTopic";
            lblTopic.Size = new Size(83, 28);
            lblTopic.TabIndex = 16;
            lblTopic.Text = "Chủ đề:";
            // 
            // txtQuantity
            // 
            txtQuantity.BackColor = Color.White;
            txtQuantity.BorderStyle = BorderStyle.FixedSingle;
            txtQuantity.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtQuantity.Location = new Point(278, 310);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(256, 34);
            txtQuantity.TabIndex = 15;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.BackColor = Color.FromArgb(255, 227, 232);
            lblQuantity.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblQuantity.ForeColor = Color.DarkRed;
            lblQuantity.Location = new Point(75, 317);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(102, 28);
            lblQuantity.TabIndex = 14;
            lblQuantity.Text = "Số lượng:";
            // 
            // cmbForm
            // 
            cmbForm.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbForm.FormattingEnabled = true;
            cmbForm.Items.AddRange(new object[] { "Có phí", "Miễn Phí" });
            cmbForm.Location = new Point(858, 57);
            cmbForm.Name = "cmbForm";
            cmbForm.Size = new Size(256, 36);
            cmbForm.TabIndex = 11;
            // 
            // lblForm
            // 
            lblForm.AutoSize = true;
            lblForm.BackColor = Color.FromArgb(255, 227, 232);
            lblForm.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblForm.ForeColor = Color.DarkRed;
            lblForm.Location = new Point(665, 60);
            lblForm.Name = "lblForm";
            lblForm.Size = new Size(111, 28);
            lblForm.TabIndex = 10;
            lblForm.Text = "Hình thức:";
            // 
            // txtFee
            // 
            txtFee.BackColor = Color.White;
            txtFee.BorderStyle = BorderStyle.FixedSingle;
            txtFee.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtFee.Location = new Point(858, 221);
            txtFee.Name = "txtFee";
            txtFee.Size = new Size(256, 34);
            txtFee.TabIndex = 9;
            // 
            // lblFee
            // 
            lblFee.AutoSize = true;
            lblFee.BackColor = Color.FromArgb(255, 227, 232);
            lblFee.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblFee.ForeColor = Color.DarkRed;
            lblFee.Location = new Point(665, 223);
            lblFee.Name = "lblFee";
            lblFee.Size = new Size(83, 28);
            lblFee.TabIndex = 8;
            lblFee.Text = "Chi phí:";
            // 
            // cmbLocation
            // 
            cmbLocation.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbLocation.FormattingEnabled = true;
            cmbLocation.Location = new Point(278, 220);
            cmbLocation.Name = "cmbLocation";
            cmbLocation.Size = new Size(256, 36);
            cmbLocation.TabIndex = 7;
            // 
            // lblLocation
            // 
            lblLocation.AutoSize = true;
            lblLocation.BackColor = Color.FromArgb(255, 227, 232);
            lblLocation.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblLocation.ForeColor = Color.DarkRed;
            lblLocation.Location = new Point(75, 223);
            lblLocation.Name = "lblLocation";
            lblLocation.Size = new Size(103, 28);
            lblLocation.TabIndex = 6;
            lblLocation.Text = "Địa điểm:";
            // 
            // lblChef
            // 
            lblChef.AutoSize = true;
            lblChef.BackColor = Color.FromArgb(255, 227, 232);
            lblChef.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblChef.ForeColor = Color.DarkRed;
            lblChef.Location = new Point(75, 138);
            lblChef.Name = "lblChef";
            lblChef.Size = new Size(106, 28);
            lblChef.TabIndex = 4;
            lblChef.Text = "Giáo viên:";
            // 
            // txtNameClass
            // 
            txtNameClass.BackColor = Color.White;
            txtNameClass.BorderStyle = BorderStyle.FixedSingle;
            txtNameClass.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNameClass.Location = new Point(278, 58);
            txtNameClass.Name = "txtNameClass";
            txtNameClass.Size = new Size(256, 34);
            txtNameClass.TabIndex = 3;
            // 
            // lblNameClass
            // 
            lblNameClass.AutoSize = true;
            lblNameClass.BackColor = Color.FromArgb(255, 227, 232);
            lblNameClass.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNameClass.ForeColor = Color.DarkRed;
            lblNameClass.Location = new Point(75, 60);
            lblNameClass.Name = "lblNameClass";
            lblNameClass.Size = new Size(127, 28);
            lblNameClass.TabIndex = 2;
            lblNameClass.Text = "Tên lớp học:";
            // 
            // txtDiscription
            // 
            txtDiscription.BorderStyle = BorderStyle.FixedSingle;
            txtDiscription.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDiscription.Location = new Point(75, 79);
            txtDiscription.Multiline = true;
            txtDiscription.Name = "txtDiscription";
            txtDiscription.Size = new Size(342, 160);
            txtDiscription.TabIndex = 13;
            // 
            // lblDiscription
            // 
            lblDiscription.AutoSize = true;
            lblDiscription.BackColor = Color.FromArgb(255, 227, 232);
            lblDiscription.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDiscription.ForeColor = Color.DarkRed;
            lblDiscription.Location = new Point(75, 36);
            lblDiscription.Name = "lblDiscription";
            lblDiscription.Size = new Size(73, 28);
            lblDiscription.TabIndex = 12;
            lblDiscription.Text = "Mô tả:";
            // 
            // gbClassTimer
            // 
            gbClassTimer.BackColor = Color.FromArgb(255, 227, 232);
            gbClassTimer.Controls.Add(txtOrganizationDay);
            gbClassTimer.Controls.Add(lblOrganizationDay);
            gbClassTimer.Controls.Add(mcOrganizationDay);
            gbClassTimer.Controls.Add(txtDurationHour);
            gbClassTimer.Controls.Add(dtpEndHour);
            gbClassTimer.Controls.Add(dtpStartHour);
            gbClassTimer.Controls.Add(lblDurationHour);
            gbClassTimer.Controls.Add(lblEndHour);
            gbClassTimer.Controls.Add(lblStartHour);
            gbClassTimer.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            gbClassTimer.Location = new Point(59, 456);
            gbClassTimer.Name = "gbClassTimer";
            gbClassTimer.Size = new Size(1162, 377);
            gbClassTimer.TabIndex = 2;
            gbClassTimer.TabStop = false;
            gbClassTimer.Text = "Thời gian lớp học";
            // 
            // txtOrganizationDay
            // 
            txtOrganizationDay.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtOrganizationDay.FormattingEnabled = true;
            txtOrganizationDay.ItemHeight = 28;
            txtOrganizationDay.Location = new Point(373, 268);
            txtOrganizationDay.Name = "txtOrganizationDay";
            txtOrganizationDay.Size = new Size(256, 88);
            txtOrganizationDay.TabIndex = 11;
            // 
            // lblOrganizationDay
            // 
            lblOrganizationDay.AutoSize = true;
            lblOrganizationDay.BackColor = Color.FromArgb(255, 227, 232);
            lblOrganizationDay.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblOrganizationDay.ForeColor = Color.DarkRed;
            lblOrganizationDay.Location = new Point(75, 268);
            lblOrganizationDay.Name = "lblOrganizationDay";
            lblOrganizationDay.Size = new Size(179, 28);
            lblOrganizationDay.TabIndex = 10;
            lblOrganizationDay.Text = "Các ngày tổ chức:";
            // 
            // mcOrganizationDay
            // 
            mcOrganizationDay.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mcOrganizationDay.Location = new Point(776, 72);
            mcOrganizationDay.Name = "mcOrganizationDay";
            mcOrganizationDay.TabIndex = 9;
            // 
            // txtDurationHour
            // 
            txtDurationHour.BorderStyle = BorderStyle.FixedSingle;
            txtDurationHour.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDurationHour.Location = new Point(373, 189);
            txtDurationHour.Name = "txtDurationHour";
            txtDurationHour.Size = new Size(256, 34);
            txtDurationHour.TabIndex = 8;
            // 
            // dtpEndHour
            // 
            dtpEndHour.CalendarFont = new Font("Segoe UI", 10F, FontStyle.Bold);
            dtpEndHour.CalendarForeColor = Color.Black;
            dtpEndHour.CalendarMonthBackground = Color.White;
            dtpEndHour.CalendarTitleForeColor = Color.Black;
            dtpEndHour.CustomFormat = "HH:mm";
            dtpEndHour.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpEndHour.Format = DateTimePickerFormat.Custom;
            dtpEndHour.Location = new Point(373, 114);
            dtpEndHour.Name = "dtpEndHour";
            dtpEndHour.ShowUpDown = true;
            dtpEndHour.Size = new Size(256, 34);
            dtpEndHour.TabIndex = 7;
            dtpEndHour.Value = new DateTime(2024, 10, 5, 0, 0, 0, 0);
            // 
            // dtpStartHour
            // 
            dtpStartHour.CalendarForeColor = Color.Black;
            dtpStartHour.CalendarMonthBackground = Color.White;
            dtpStartHour.CalendarTitleForeColor = Color.Black;
            dtpStartHour.CustomFormat = "HH:mm";
            dtpStartHour.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpStartHour.Format = DateTimePickerFormat.Custom;
            dtpStartHour.Location = new Point(373, 43);
            dtpStartHour.Name = "dtpStartHour";
            dtpStartHour.ShowUpDown = true;
            dtpStartHour.Size = new Size(256, 34);
            dtpStartHour.TabIndex = 6;
            dtpStartHour.Value = new DateTime(2024, 10, 5, 0, 0, 0, 0);
            // 
            // lblDurationHour
            // 
            lblDurationHour.AutoSize = true;
            lblDurationHour.BackColor = Color.FromArgb(255, 227, 232);
            lblDurationHour.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDurationHour.ForeColor = Color.DarkRed;
            lblDurationHour.Location = new Point(75, 191);
            lblDurationHour.Name = "lblDurationHour";
            lblDurationHour.Size = new Size(199, 28);
            lblDurationHour.TabIndex = 5;
            lblDurationHour.Text = "Thời lượng lớp học:";
            // 
            // lblEndHour
            // 
            lblEndHour.AutoSize = true;
            lblEndHour.BackColor = Color.FromArgb(255, 227, 232);
            lblEndHour.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblEndHour.ForeColor = Color.DarkRed;
            lblEndHour.Location = new Point(75, 114);
            lblEndHour.Name = "lblEndHour";
            lblEndHour.Size = new Size(191, 28);
            lblEndHour.TabIndex = 4;
            lblEndHour.Text = "Thời gian kết thúc:";
            // 
            // lblStartHour
            // 
            lblStartHour.AutoSize = true;
            lblStartHour.BackColor = Color.FromArgb(255, 227, 232);
            lblStartHour.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblStartHour.ForeColor = Color.DarkRed;
            lblStartHour.Location = new Point(75, 43);
            lblStartHour.Name = "lblStartHour";
            lblStartHour.Size = new Size(186, 28);
            lblStartHour.TabIndex = 3;
            lblStartHour.Text = "Thời gian bắt đầu:";
            // 
            // gbDiscriptionPicture
            // 
            gbDiscriptionPicture.BackColor = Color.FromArgb(255, 227, 232);
            gbDiscriptionPicture.Controls.Add(rpbPicture);
            gbDiscriptionPicture.Controls.Add(btnLoadPicture);
            gbDiscriptionPicture.Controls.Add(lblPicture);
            gbDiscriptionPicture.Controls.Add(txtDiscription);
            gbDiscriptionPicture.Controls.Add(lblDiscription);
            gbDiscriptionPicture.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            gbDiscriptionPicture.Location = new Point(59, 865);
            gbDiscriptionPicture.Name = "gbDiscriptionPicture";
            gbDiscriptionPicture.Size = new Size(1162, 262);
            gbDiscriptionPicture.TabIndex = 3;
            gbDiscriptionPicture.TabStop = false;
            gbDiscriptionPicture.Text = "Hình ảnh_Mô tả";
            // 
            // rpbPicture
            // 
            rpbPicture.BorderRadius = 40;
            rpbPicture.Location = new Point(801, 79);
            rpbPicture.Name = "rpbPicture";
            rpbPicture.Size = new Size(165, 160);
            rpbPicture.TabIndex = 17;
            rpbPicture.TabStop = false;
            // 
            // btnLoadPicture
            // 
            btnLoadPicture.BorderRadius = 40;
            btnLoadPicture.ButtonColor = Color.DarkRed;
            btnLoadPicture.Location = new Point(954, 33);
            btnLoadPicture.Name = "btnLoadPicture";
            btnLoadPicture.Size = new Size(112, 34);
            btnLoadPicture.TabIndex = 16;
            btnLoadPicture.Text = "Tải ảnh";
            btnLoadPicture.TextColor = Color.White;
            btnLoadPicture.UseVisualStyleBackColor = true;
            // 
            // lblPicture
            // 
            lblPicture.AutoSize = true;
            lblPicture.BackColor = Color.FromArgb(255, 227, 232);
            lblPicture.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPicture.ForeColor = Color.DarkRed;
            lblPicture.Location = new Point(711, 36);
            lblPicture.Name = "lblPicture";
            lblPicture.Size = new Size(103, 28);
            lblPicture.TabIndex = 14;
            lblPicture.Text = "Hình ảnh:";
            // 
            // btnAdd
            // 
            btnAdd.BorderRadius = 40;
            btnAdd.ButtonColor = Color.DarkRed;
            btnAdd.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAdd.Location = new Point(1109, 1167);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 39);
            btnAdd.TabIndex = 19;
            btnAdd.Text = "Thêm";
            btnAdd.TextColor = Color.White;
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // CreateClassroom
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(251, 236, 240);
            ClientSize = new Size(1278, 1050);
            Controls.Add(btnAdd);
            Controls.Add(gbDiscriptionPicture);
            Controls.Add(gbClassTimer);
            Controls.Add(gbBasicInformation);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CreateClassroom";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tạo lớp học";
            gbBasicInformation.ResumeLayout(false);
            gbBasicInformation.PerformLayout();
            gbClassTimer.ResumeLayout(false);
            gbClassTimer.PerformLayout();
            gbDiscriptionPicture.ResumeLayout(false);
            gbDiscriptionPicture.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)rpbPicture).EndInit();
            ResumeLayout(false);
        }

        #endregion


        private GroupBox gbBasicInformation;
        private Label lblNameClass;
        private TextBox txtNameClass;
        private Label lblChef;
        private ComboBox cmbLocation;
        private Label lblLocation;
        private TextBox txtFee;
        private Label lblFee;
        private ComboBox cmbForm;
        private Label lblForm;
        private GroupBox gbClassTimer;
        private Label lblStartHour;
        private TextBox txtDiscription;
        private Label lblDiscription;
        private Label lblDurationHour;
        private Label lblEndHour;
        private GroupBox gbDiscriptionPicture;
        private TextBox txtQuantity;
        private Label lblQuantity;
        private DateTimePicker dtpStartHour;
        private DateTimePicker dtpEndHour;
        private Label lblPicture;
        private THE_COOKY_APP.GUI.CLASSROOM.RoundedButton btnLoadPicture;
        private TextBox txtDurationHour;
        private Label lblTopic;
        private MonthCalendar mcOrganizationDay;
        private ComboBox cmbTopic;
        private Label lblOrganizationDay;
        private ListBox txtOrganizationDay;
        private THE_COOKY_APP.GUI.CLASSROOM.RoundedPictureBox rpbPicture;
        private ComboBox cmbSponsor;
        private Label lblSponsor;
        private RoundedButton btnAdd;
        private ComboBox cmbChef;
    }
}
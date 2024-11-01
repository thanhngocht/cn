namespace THE_COOKY_APP.GUI.HOME
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            panel1 = new Panel();
            pSide = new Panel();
            btnTimeTable = new Button();
            btnCategory = new Button();
            btnReport = new Button();
            btnHome = new Button();
            panel2 = new Panel();
            pbExit = new PictureBox();
            pbProfile = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            lblLogo = new Label();
            rpbLogo = new LOGIN.RoundedPictureBox();
            pCategory = new CATEGORY.PageCategory();
            pHome = new PageHome();
            pReport = new REPORT.PageReport();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbExit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbProfile).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rpbLogo).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(251, 236, 240);
            panel1.Controls.Add(pSide);
            panel1.Controls.Add(btnTimeTable);
            panel1.Controls.Add(btnCategory);
            panel1.Controls.Add(btnReport);
            panel1.Controls.Add(btnHome);
            panel1.Location = new Point(0, 134);
            panel1.Name = "panel1";
            panel1.Size = new Size(290, 809);
            panel1.TabIndex = 0;
            // 
            // pSide
            // 
            pSide.BackColor = Color.DarkRed;
            pSide.Location = new Point(0, 56);
            pSide.Name = "pSide";
            pSide.Size = new Size(15, 80);
            pSide.TabIndex = 7;
            // 
            // btnTimeTable
            // 
            btnTimeTable.FlatAppearance.BorderSize = 0;
            btnTimeTable.FlatStyle = FlatStyle.Flat;
            btnTimeTable.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTimeTable.ForeColor = Color.DarkRed;
            btnTimeTable.Image = Properties.Resources.icons8_timetable_50;
            btnTimeTable.ImageAlign = ContentAlignment.MiddleLeft;
            btnTimeTable.Location = new Point(12, 527);
            btnTimeTable.Name = "btnTimeTable";
            btnTimeTable.Size = new Size(278, 74);
            btnTimeTable.TabIndex = 3;
            btnTimeTable.Text = "LỊCH HỌC";
            btnTimeTable.UseVisualStyleBackColor = true;
            btnTimeTable.Click += btnTimeTable_Click;
            // 
            // btnCategory
            // 
            btnCategory.FlatAppearance.BorderSize = 0;
            btnCategory.FlatStyle = FlatStyle.Flat;
            btnCategory.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCategory.ForeColor = Color.DarkRed;
            btnCategory.Image = (Image)resources.GetObject("btnCategory.Image");
            btnCategory.ImageAlign = ContentAlignment.MiddleLeft;
            btnCategory.Location = new Point(12, 367);
            btnCategory.Name = "btnCategory";
            btnCategory.Size = new Size(278, 74);
            btnCategory.TabIndex = 2;
            btnCategory.Text = "PHỤ LỤC";
            btnCategory.UseVisualStyleBackColor = true;
            btnCategory.Click += btnCategory_Click;
            // 
            // btnReport
            // 
            btnReport.FlatAppearance.BorderSize = 0;
            btnReport.FlatStyle = FlatStyle.Flat;
            btnReport.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReport.ForeColor = Color.DarkRed;
            btnReport.Image = Properties.Resources.icons8_report_50;
            btnReport.ImageAlign = ContentAlignment.MiddleLeft;
            btnReport.Location = new Point(12, 215);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(278, 74);
            btnReport.TabIndex = 1;
            btnReport.Text = "BÁO CÁO";
            btnReport.UseVisualStyleBackColor = true;
            btnReport.Click += btnReport_Click;
            // 
            // btnHome
            // 
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHome.ForeColor = Color.DarkRed;
            btnHome.Image = (Image)resources.GetObject("btnHome.Image");
            btnHome.ImageAlign = ContentAlignment.MiddleLeft;
            btnHome.Location = new Point(12, 62);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(278, 74);
            btnHome.TabIndex = 0;
            btnHome.Text = "TRANG CHỦ";
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(pbExit);
            panel2.Controls.Add(pbProfile);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(lblLogo);
            panel2.Controls.Add(rpbLogo);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1729, 136);
            panel2.TabIndex = 1;
            // 
            // pbExit
            // 
            pbExit.BackgroundImage = (Image)resources.GetObject("pbExit.BackgroundImage");
            pbExit.BackgroundImageLayout = ImageLayout.Stretch;
            pbExit.Location = new Point(1614, 48);
            pbExit.Name = "pbExit";
            pbExit.Size = new Size(50, 50);
            pbExit.TabIndex = 6;
            pbExit.TabStop = false;
            // 
            // pbProfile
            // 
            pbProfile.BackgroundImage = Properties.Resources.icons8_male_user_50;
            pbProfile.BackgroundImageLayout = ImageLayout.Stretch;
            pbProfile.Location = new Point(1524, 48);
            pbProfile.Name = "pbProfile";
            pbProfile.Size = new Size(50, 50);
            pbProfile.TabIndex = 5;
            pbProfile.TabStop = false;
            pbProfile.Click += pbProfile_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(1295, 72);
            label2.Name = "label2";
            label2.Size = new Size(160, 30);
            label2.TabIndex = 3;
            label2.Text = "Nguyễn Văn A";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(1295, 31);
            label1.Name = "label1";
            label1.Size = new Size(106, 30);
            label1.TabIndex = 2;
            label1.Text = "Giám đốc";
            // 
            // lblLogo
            // 
            lblLogo.AutoSize = true;
            lblLogo.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogo.ForeColor = Color.DarkRed;
            lblLogo.Location = new Point(119, 48);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(171, 38);
            lblLogo.TabIndex = 1;
            lblLogo.Text = "THE COOKY";
            // 
            // rpbLogo
            // 
            rpbLogo.BackgroundImage = Properties.Resources.logo;
            rpbLogo.BackgroundImageLayout = ImageLayout.Stretch;
            rpbLogo.BorderRadius = 40;
            rpbLogo.Location = new Point(12, 21);
            rpbLogo.Name = "rpbLogo";
            rpbLogo.Size = new Size(90, 90);
            rpbLogo.TabIndex = 0;
            rpbLogo.TabStop = false;
            // 
            // pCategory
            // 
            pCategory.BackColor = Color.FromArgb(251, 236, 240);
            pCategory.Location = new Point(369, 137);
            pCategory.Name = "pCategory";
            pCategory.Size = new Size(1300, 806);
            pCategory.TabIndex = 2;
            // 
            // pHome
            // 
            pHome.BackColor = Color.FromArgb(251, 236, 240);
            pHome.Location = new Point(369, 137);
            pHome.Name = "pHome";
            pHome.Size = new Size(1300, 806);
            pHome.TabIndex = 3;
            // 
            // pReport
            // 
            pReport.BackColor = Color.FromArgb(251, 236, 240);
            pReport.Location = new Point(369, 137);
            pReport.Name = "pReport";
            pReport.Size = new Size(1300, 806);
            pReport.TabIndex = 4;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1728, 944);
            Controls.Add(pReport);
            Controls.Add(pHome);
            Controls.Add(pCategory);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Trang chủ";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbExit).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbProfile).EndInit();
            ((System.ComponentModel.ISupportInitialize)rpbLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private LOGIN.RoundedPictureBox rpbLogo;
        private Label lblLogo;
        private Label label2;
        private Label label1;
        private Button btnHome;
        private Button btnReport;
        private Button btnTimeTable;
        private Button btnCategory;
        private PictureBox pbProfile;
        private PictureBox pbExit;
        private Panel pSide;
        private CATEGORY.PageCategory pCategory;
        private PageHome pHome;
        private REPORT.PageReport pReport;
    }
}
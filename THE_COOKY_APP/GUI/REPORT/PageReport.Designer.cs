namespace THE_COOKY_APP.GUI.REPORT
{
    partial class PageReport
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PageReport));
            btnReportData = new Button();
            btnReportOverall = new Button();
            btnReportKPI = new Button();
            btnReportLocation = new Button();
            btnReportClassroom = new Button();
            btnReportMonth = new Button();
            SuspendLayout();
            // 
            // btnReportData
            // 
            btnReportData.BackColor = Color.LightCoral;
            btnReportData.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReportData.ForeColor = Color.White;
            btnReportData.Image = (Image)resources.GetObject("btnReportData.Image");
            btnReportData.ImageAlign = ContentAlignment.MiddleLeft;
            btnReportData.Location = new Point(932, 485);
            btnReportData.Name = "btnReportData";
            btnReportData.Padding = new Padding(5, 0, 0, 0);
            btnReportData.Size = new Size(195, 93);
            btnReportData.TabIndex = 11;
            btnReportData.Text = "DỮ LIỆU   ";
            btnReportData.TextAlign = ContentAlignment.MiddleRight;
            btnReportData.UseVisualStyleBackColor = false;
            // 
            // btnReportOverall
            // 
            btnReportOverall.BackColor = Color.LightCoral;
            btnReportOverall.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReportOverall.ForeColor = Color.White;
            btnReportOverall.Image = Properties.Resources.icons8_report_50__1_;
            btnReportOverall.ImageAlign = ContentAlignment.MiddleLeft;
            btnReportOverall.Location = new Point(545, 485);
            btnReportOverall.Name = "btnReportOverall";
            btnReportOverall.Padding = new Padding(3, 0, 0, 0);
            btnReportOverall.Size = new Size(195, 93);
            btnReportOverall.TabIndex = 10;
            btnReportOverall.Text = "TỔNG HỢP";
            btnReportOverall.TextAlign = ContentAlignment.MiddleRight;
            btnReportOverall.UseVisualStyleBackColor = false;
            // 
            // btnReportKPI
            // 
            btnReportKPI.BackColor = Color.LightCoral;
            btnReportKPI.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReportKPI.ForeColor = Color.White;
            btnReportKPI.Image = (Image)resources.GetObject("btnReportKPI.Image");
            btnReportKPI.ImageAlign = ContentAlignment.MiddleLeft;
            btnReportKPI.Location = new Point(139, 485);
            btnReportKPI.Name = "btnReportKPI";
            btnReportKPI.Padding = new Padding(5, 0, 0, 0);
            btnReportKPI.Size = new Size(195, 93);
            btnReportKPI.TabIndex = 9;
            btnReportKPI.Text = "CHỈ TIÊU  ";
            btnReportKPI.TextAlign = ContentAlignment.MiddleRight;
            btnReportKPI.UseVisualStyleBackColor = false;
            // 
            // btnReportLocation
            // 
            btnReportLocation.BackColor = Color.LightCoral;
            btnReportLocation.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReportLocation.ForeColor = Color.White;
            btnReportLocation.Image = (Image)resources.GetObject("btnReportLocation.Image");
            btnReportLocation.ImageAlign = ContentAlignment.MiddleLeft;
            btnReportLocation.Location = new Point(932, 228);
            btnReportLocation.Name = "btnReportLocation";
            btnReportLocation.Padding = new Padding(5, 0, 0, 0);
            btnReportLocation.Size = new Size(195, 93);
            btnReportLocation.TabIndex = 8;
            btnReportLocation.Text = "ĐỊA ĐIỂM  ";
            btnReportLocation.TextAlign = ContentAlignment.MiddleRight;
            btnReportLocation.UseVisualStyleBackColor = false;
            // 
            // btnReportClassroom
            // 
            btnReportClassroom.BackColor = Color.LightCoral;
            btnReportClassroom.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReportClassroom.ForeColor = Color.White;
            btnReportClassroom.Image = Properties.Resources.icons8_classroom_50;
            btnReportClassroom.ImageAlign = ContentAlignment.MiddleLeft;
            btnReportClassroom.Location = new Point(545, 228);
            btnReportClassroom.Name = "btnReportClassroom";
            btnReportClassroom.Padding = new Padding(5, 0, 0, 0);
            btnReportClassroom.Size = new Size(195, 93);
            btnReportClassroom.TabIndex = 7;
            btnReportClassroom.Text = "LỚP HỌC  ";
            btnReportClassroom.TextAlign = ContentAlignment.MiddleRight;
            btnReportClassroom.UseVisualStyleBackColor = false;
            // 
            // btnReportMonth
            // 
            btnReportMonth.BackColor = Color.LightCoral;
            btnReportMonth.FlatAppearance.BorderColor = Color.DarkRed;
            btnReportMonth.FlatAppearance.BorderSize = 0;
            btnReportMonth.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReportMonth.ForeColor = Color.White;
            btnReportMonth.Image = Properties.Resources.icons8_calendar_50;
            btnReportMonth.ImageAlign = ContentAlignment.MiddleLeft;
            btnReportMonth.Location = new Point(139, 228);
            btnReportMonth.Name = "btnReportMonth";
            btnReportMonth.Padding = new Padding(5, 0, 0, 0);
            btnReportMonth.Size = new Size(195, 93);
            btnReportMonth.TabIndex = 6;
            btnReportMonth.Text = "THÁNG   ";
            btnReportMonth.TextAlign = ContentAlignment.MiddleRight;
            btnReportMonth.UseVisualStyleBackColor = false;
            // 
            // PageReport
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(251, 236, 240);
            Controls.Add(btnReportData);
            Controls.Add(btnReportOverall);
            Controls.Add(btnReportKPI);
            Controls.Add(btnReportLocation);
            Controls.Add(btnReportClassroom);
            Controls.Add(btnReportMonth);
            Name = "PageReport";
            Size = new Size(1300, 806);
            ResumeLayout(false);
        }

        #endregion

        private Button btnReportData;
        private Button btnReportOverall;
        private Button btnReportKPI;
        private Button btnReportLocation;
        private Button btnReportClassroom;
        private Button btnReportMonth;
    }
}

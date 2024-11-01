namespace THE_COOKY_APP.GUI.TOPIC
{
    partial class CreateTopic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTopic));
            btnAdd = new CLASSROOM.RoundedButton();
            gbTopicInformation = new GroupBox();
            txtTopic = new TextBox();
            lblTopic = new Label();
            gbTopicInformation.SuspendLayout();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.BorderRadius = 40;
            btnAdd.ButtonColor = Color.DarkRed;
            btnAdd.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAdd.Location = new Point(447, 222);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 39);
            btnAdd.TabIndex = 19;
            btnAdd.Text = "Thêm mới";
            btnAdd.TextColor = Color.White;
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // gbTopicInformation
            // 
            gbTopicInformation.BackColor = Color.FromArgb(255, 227, 232);
            gbTopicInformation.Controls.Add(txtTopic);
            gbTopicInformation.Controls.Add(lblTopic);
            gbTopicInformation.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            gbTopicInformation.Location = new Point(54, 67);
            gbTopicInformation.Name = "gbTopicInformation";
            gbTopicInformation.Size = new Size(505, 123);
            gbTopicInformation.TabIndex = 20;
            gbTopicInformation.TabStop = false;
            gbTopicInformation.Text = "Thông tin chủ đề";
            // 
            // txtTopic
            // 
            txtTopic.BackColor = Color.White;
            txtTopic.BorderStyle = BorderStyle.FixedSingle;
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
            // CreateTopic
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(251, 236, 240);
            ClientSize = new Size(608, 304);
            Controls.Add(gbTopicInformation);
            Controls.Add(btnAdd);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CreateTopic";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tạo chủ đề";
            gbTopicInformation.ResumeLayout(false);
            gbTopicInformation.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private CLASSROOM.RoundedButton btnAdd;
        private GroupBox gbTopicInformation;
        private TextBox txtTopic;
        private Label lblTopic;
    }
}
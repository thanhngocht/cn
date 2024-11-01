namespace THE_COOKY_APP.GUI.LOCATION
{
    partial class CreateLocation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateLocation));
            gbLocationInformation = new GroupBox();
            txtDiscription = new TextBox();
            txtQuantity = new TextBox();
            txtAddress = new TextBox();
            txtNameLocation = new TextBox();
            lblDiscription = new Label();
            lblQuantity = new Label();
            lblAddress = new Label();
            lblNameLocation = new Label();
            btnAdd = new CLASSROOM.RoundedButton();
            gbLocationInformation.SuspendLayout();
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
            gbLocationInformation.Location = new Point(52, 60);
            gbLocationInformation.Name = "gbLocationInformation";
            gbLocationInformation.Size = new Size(505, 421);
            gbLocationInformation.TabIndex = 0;
            gbLocationInformation.TabStop = false;
            gbLocationInformation.Text = "Thông tin địa điểm";
            // 
            // txtDiscription
            // 
            txtDiscription.BorderStyle = BorderStyle.FixedSingle;
            txtDiscription.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDiscription.Location = new Point(213, 304);
            txtDiscription.Multiline = true;
            txtDiscription.Name = "txtDiscription";
            txtDiscription.Size = new Size(256, 96);
            txtDiscription.TabIndex = 10;
            // 
            // txtQuantity
            // 
            txtQuantity.BorderStyle = BorderStyle.FixedSingle;
            txtQuantity.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtQuantity.Location = new Point(213, 215);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(256, 34);
            txtQuantity.TabIndex = 9;
            // 
            // txtAddress
            // 
            txtAddress.BorderStyle = BorderStyle.FixedSingle;
            txtAddress.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtAddress.Location = new Point(213, 133);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(256, 34);
            txtAddress.TabIndex = 8;
            // 
            // txtNameLocation
            // 
            txtNameLocation.BorderStyle = BorderStyle.FixedSingle;
            txtNameLocation.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNameLocation.Location = new Point(213, 57);
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
            lblDiscription.Location = new Point(40, 306);
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
            lblQuantity.Location = new Point(40, 218);
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
            lblAddress.Location = new Point(40, 136);
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
            // btnAdd
            // 
            btnAdd.BorderRadius = 40;
            btnAdd.ButtonColor = Color.DarkRed;
            btnAdd.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(445, 522);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 39);
            btnAdd.TabIndex = 18;
            btnAdd.Text = "Thêm";
            btnAdd.TextColor = Color.White;
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // CreateLocation
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(251, 236, 240);
            ClientSize = new Size(608, 624);
            Controls.Add(btnAdd);
            Controls.Add(gbLocationInformation);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CreateLocation";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tạo địa điểm ";
            gbLocationInformation.ResumeLayout(false);
            gbLocationInformation.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbLocationInformation;
        private Label lblNameLocation;
        private Label lblDiscription;
        private Label lblQuantity;
        private Label lblAddress;
        private TextBox txtDiscription;
        private TextBox txtAddress;
        private TextBox txtNameLocation;
        private CLASSROOM.RoundedButton btnAdd;
        private TextBox txtQuantity;
    }
}
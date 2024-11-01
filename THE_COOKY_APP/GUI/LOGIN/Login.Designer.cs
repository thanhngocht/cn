using System.Security.Principal;

namespace THE_COOKY_APP.GUI.LOGIN
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pLogin = new RoundedPanel();
            cbShowPassword = new CustomCheckBox();
            rpbPicture = new RoundedPictureBox();
            llForgetPassword = new LinkLabel();
            btnLogin = new RoundedButton();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            lblPassword = new Label();
            lblUsername = new Label();
            lblLogin = new Label();
            pLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)rpbPicture).BeginInit();
            SuspendLayout();
            // 
            // pLogin
            // 
            pLogin.BackColor = Color.White;
            pLogin.BorderRadius = 40;
            pLogin.Controls.Add(cbShowPassword);
            pLogin.Controls.Add(rpbPicture);
            pLogin.Controls.Add(llForgetPassword);
            pLogin.Controls.Add(btnLogin);
            pLogin.Controls.Add(txtPassword);
            pLogin.Controls.Add(txtUsername);
            pLogin.Controls.Add(lblPassword);
            pLogin.Controls.Add(lblUsername);
            pLogin.Controls.Add(lblLogin);
            pLogin.Location = new Point(312, 165);
            pLogin.Name = "pLogin";
            pLogin.Size = new Size(356, 392);
            pLogin.TabIndex = 0;
            // 
            // cbShowPassword
            // 
            cbShowPassword.AutoSize = true;
            cbShowPassword.CheckBoxSize = 20;
            cbShowPassword.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbShowPassword.Location = new Point(21, 297);
            cbShowPassword.Name = "cbShowPassword";
            cbShowPassword.Size = new Size(159, 25);
            cbShowPassword.TabIndex = 9;
            cbShowPassword.Text = "Hiển thị mật khẩu";
            cbShowPassword.UseVisualStyleBackColor = true;
            cbShowPassword.CheckedChanged += chk_HienThi_CheckedChanged;
            // 
            // rpbPicture
            // 
            rpbPicture.BackgroundImage = Properties.Resources.logo;
            rpbPicture.BackgroundImageLayout = ImageLayout.Stretch;
            rpbPicture.BorderRadius = 40;
            rpbPicture.Location = new Point(134, 7);
            rpbPicture.Name = "rpbPicture";
            rpbPicture.Size = new Size(90, 90);
            rpbPicture.TabIndex = 8;
            rpbPicture.TabStop = false;
            // 
            // llForgetPassword
            // 
            llForgetPassword.ActiveLinkColor = Color.Red;
            llForgetPassword.AutoSize = true;
            llForgetPassword.BackColor = Color.White;
            llForgetPassword.Font = new Font("Arial", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            llForgetPassword.ForeColor = Color.Red;
            llForgetPassword.LinkColor = Color.DarkRed;
            llForgetPassword.Location = new Point(220, 300);
            llForgetPassword.Name = "llForgetPassword";
            llForgetPassword.Size = new Size(124, 19);
            llForgetPassword.TabIndex = 7;
            llForgetPassword.TabStop = true;
            llForgetPassword.Text = "Quên mật khẩu";
            llForgetPassword.VisitedLinkColor = Color.DarkRed;
            llForgetPassword.LinkClicked += llForgetPassword_LinkClicked;
            // 
            // btnLogin
            // 
            btnLogin.BorderRadius = 40;
            btnLogin.ButtonColor = Color.DarkRed;
            btnLogin.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(26, 340);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(305, 39);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Đăng nhập";
            btnLogin.TextColor = Color.White;
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(26, 255);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(305, 31);
            txtPassword.TabIndex = 4;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(26, 177);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(305, 31);
            txtUsername.TabIndex = 3;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.BackColor = Color.White;
            lblPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblPassword.ForeColor = Color.DarkRed;
            lblPassword.Location = new Point(14, 220);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(93, 25);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Mật khẩu";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.BackColor = Color.White;
            lblUsername.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsername.ForeColor = Color.DarkRed;
            lblUsername.Location = new Point(14, 137);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(138, 25);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Tên đăng nhập";
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.BackColor = Color.White;
            lblLogin.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogin.ForeColor = Color.DarkRed;
            lblLogin.Location = new Point(101, 90);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(161, 38);
            lblLogin.TabIndex = 0;
            lblLogin.Text = "Đăng nhập";
            lblLogin.TextAlign = ContentAlignment.TopCenter;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Account;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(978, 644);
            Controls.Add(pLogin);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            pLogin.ResumeLayout(false);
            pLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)rpbPicture).EndInit();
            ResumeLayout(false);
        }

        private void llForgetPassword_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private THE_COOKY_APP.GUI.LOGIN.RoundedPanel pLogin;
        private Label lblLogin;
        private Label lblPassword;
        private Label lblUsername;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private THE_COOKY_APP.GUI.LOGIN.RoundedButton btnLogin;
        private LinkLabel llForgetPassword;
        private THE_COOKY_APP.GUI.LOGIN.RoundedPictureBox rpbPicture;
        private THE_COOKY_APP.GUI.LOGIN.CustomCheckBox cbShowPassword;
    }
}
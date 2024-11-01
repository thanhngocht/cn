using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using THE_COOKY_APP.BLL;
using THE_COOKY_APP.GUI.HOME;

namespace THE_COOKY_APP.GUI.LOGIN
{
    public partial class Login : Form
    {
        private AccountBLL accountBLL;
        public Login()
        {
            InitializeComponent();
            // Mặc định ẩn mật khẩu bằng dấu •
            txtPassword.PasswordChar = '•'; // Thay * bằng •
            accountBLL = new AccountBLL(); // Khởi tạo AccountBLL
        }

        private void chk_HienThi_CheckedChanged(object sender, EventArgs e)
        {
            //Nếu CheckBox được tick, hiển thị mật khẩu, ngược lại ẩn mật khẩu
            if (cbShowPassword.Checked)
            {
                txtPassword.PasswordChar = '\0'; // Hiển thị mật khẩu
            }
            else
            {
                txtPassword.PasswordChar = '•'; // Ẩn mật khẩu bằng dấu •
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            int failedAttempts = accountBLL.LoadFailedAttempts(username);
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                return;
            }

            try
            {
                string accountId = accountBLL.Login(username, password);

                if (accountId == "locked")
                {
                    MessageBox.Show("Tài khoản của bạn đã bị khóa do nhập sai quá 5 lần. Vui lòng liên hệ quản trị viên.");
                    return;
                }
                if (accountId == "not found")
                {
                    MessageBox.Show("Tên tài khoản không tồn tại");
                    return;

                }

                if (accountId == null)
                {


                    int maxAttempts = 5;
                    if (failedAttempts >= maxAttempts)
                    {
                        MessageBox.Show("Bạn đã nhập sai quá 5 lần. Tài khoản sẽ bị khóa.");
                        accountBLL.LockAccount(username); // Gọi logic khóa tài khoản ở đây
                        return;
                    }

                    else
                    {
                        // Thông báo số lần nhập sai còn lại
                        int remainingAttempts = maxAttempts - failedAttempts;
                        MessageBox.Show($"Tên đăng nhập hoặc mật khẩu không đúng. Bạn còn {remainingAttempts} lần thử.");
                        return;
                    }

                }
                if (accountId != null)
                {


                    MessageBox.Show("Đăng nhập thành công!");
                    Home home = new Home();
                    this.Hide();
                    home.ShowDialog();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }










        private void llForgetPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgetPassword f = new ForgetPassword();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

       
    }
}

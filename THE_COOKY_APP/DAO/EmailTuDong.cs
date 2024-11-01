using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace THE_COOKY_APP.DAO
{
    internal class EmailTuDong
    {
        private string nguoiGui = "thanhngocbao0304@gmail.com";
        private string nguoiNhan;
        private string matKhau = "sbkw dnkr imlk faku"; // Sử dụng mật khẩu ứng dụng nếu cần
        private string chuDe;
        private string noiDung;

        public EmailTuDong()
        {
            this.nguoiNhan = "";
            this.chuDe = "";
            this.noiDung = "";
        }

        public EmailTuDong(string nguoiNhan, string chuDe, string noiDung)
        {
            this.nguoiNhan = nguoiNhan;
            this.chuDe = chuDe;
            this.noiDung = noiDung;
        }

        public void ThuGuiMail(string html = null)
        {
          

            // Tạo và cấu hình đối tượng MailMessage
            MailMessage mail = new MailMessage();
            mail.To.Add(nguoiNhan);
            mail.From = new MailAddress(nguoiGui);
            mail.Subject = chuDe;
            mail.Body = noiDung;
            mail.IsBodyHtml = !string.IsNullOrEmpty(html);

            // Cấu hình SmtpClient và gửi email
            using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
            {
                smtp.EnableSsl = true;
                smtp.Credentials = new NetworkCredential(nguoiGui, matKhau);
                smtp.Send(mail);
            }

            
        }

       



    }
}

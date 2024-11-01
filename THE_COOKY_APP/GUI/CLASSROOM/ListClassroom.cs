using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using THE_COOKY_APP.GUI.STUDENT;

namespace THE_COOKY_APP.GUI.CLASSROOM
{
    public partial class ListClassroom : Form
    {
        public ListClassroom()
        {
            InitializeComponent();
            this.Size = new Size(1300, 880);
            this.AutoScroll = true;
            this.Load += new EventHandler(SetUpFunction_Load);
        }

        private void SetUpFunction_Load(object? sender, EventArgs e)
        {
            // Tính chiều cao tổng của tất cả các điều khiển sau khi form được tải
            int totalHeight = 0;
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl.Visible)
                {
                    totalHeight = Math.Max(totalHeight, ctrl.Bottom);  // Lấy vị trí thấp nhất của phần tử cuối cùng
                }
            }

            // Tăng vùng cuộn bằng cách đặt AutoScrollMinSize, thêm khoảng cách 40px
            this.AutoScrollMinSize = new Size(0, totalHeight + 40); // Thêm khoảng trống sau phần tử cuối cùng
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CreateClassroom createClassroom = new CreateClassroom();
            createClassroom.ShowDialog();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            CreateStudentInClass createStudentInClass = new CreateStudentInClass();
            createStudentInClass.ShowDialog();
        }

    }
}

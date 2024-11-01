﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THE_COOKY_APP.GUI.CLASSROOM
{
    public partial class CreateClassroom : Form
    {
        public CreateClassroom()
        {
            InitializeComponent();
            this.Size = new Size(1300, 850);
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

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using THE_COOKY_APP.GUI.ACCOUNT;
using THE_COOKY_APP.GUI.CHEF;
using THE_COOKY_APP.GUI.CLASSROOM;
using THE_COOKY_APP.GUI.LOCATION;
using THE_COOKY_APP.GUI.STUDENT;
using THE_COOKY_APP.GUI.TOPIC;

namespace THE_COOKY_APP.GUI.CATEGORY
{
    public partial class PageCategory : UserControl
    {
        public PageCategory()
        {
            InitializeComponent();
        }

        private void btnChef_Click(object sender, EventArgs e)
        {
            ListChef listChef = new ListChef();
            listChef.ShowDialog();
        }

        private void btnLocation_Click(object sender, EventArgs e)
        {
            ListLocation listLocation = new ListLocation();
            listLocation.ShowDialog();
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            ListAccount listAccount = new ListAccount();
            listAccount.ShowDialog();
        }

        private void btnTopic_Click(object sender, EventArgs e)
        {
            ListTopic listTopic = new ListTopic();
            listTopic.ShowDialog();
        }

        private void btnClassroom_Click(object sender, EventArgs e)
        {
            ListClassroom listClassroom = new ListClassroom();
            listClassroom.ShowDialog();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            ListStudent listStudent = new ListStudent();
            listStudent.ShowDialog();
        }
    }
}

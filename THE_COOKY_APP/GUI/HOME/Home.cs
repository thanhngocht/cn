using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using THE_COOKY_APP.GUI.LOGIN;
using THE_COOKY_APP.GUI.PROFILE;

namespace THE_COOKY_APP.GUI.HOME
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            pSide.Height = btnHome.Height;
            pSide.Top = btnHome.Top;
            pHome.BringToFront();

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            pSide.Height = btnHome.Height;
            pSide.Top = btnHome.Top;
            pHome.BringToFront();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            pSide.Height = btnReport.Height;
            pSide.Top = btnReport.Top;
            pReport.BringToFront();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            pSide.Height = btnCategory.Height;
            pSide.Top = btnCategory.Top;
            pCategory.BringToFront();
        }

        private void btnTimeTable_Click(object sender, EventArgs e)
        {
            pSide.Height = btnTimeTable.Height;
            pSide.Top = btnTimeTable.Top;
        }

        private void pbProfile_Click(object sender, EventArgs e)
        {
            AccountProfile accountProfile = new AccountProfile();
            accountProfile.ShowDialog();
        }
    }
}

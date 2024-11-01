using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using THE_COOKY_APP.GUI.PROFILE;

namespace THE_COOKY_APP.GUI.CHEF
{
    public partial class ListChef : Form
    {
        public ListChef()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CreateChef createChef = new CreateChef();
            createChef.ShowDialog();
        }

        private void btnPersonalProfile_Click(object sender, EventArgs e)
        {
            ChefProfile createChef = new ChefProfile();
            createChef.ShowDialog();
        }


    }
}

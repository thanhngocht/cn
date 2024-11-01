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

namespace THE_COOKY_APP.GUI.ACCOUNT
{
    public partial class ListAccount : Form
    {
        public ListAccount()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CreateAccount createAccount = new CreateAccount();
            createAccount.ShowDialog();
        }

        private void btnSetUpFunction_Click(object sender, EventArgs e)
        {
            SetUpFunction setUpFunction = new SetUpFunction();
            setUpFunction.ShowDialog();
        }

        private void btnPersonalProfile_Click(object sender, EventArgs e)
        {
            AccountProfile profile = new AccountProfile();
            profile.ShowDialog();
        }
    }
}

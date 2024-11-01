using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THE_COOKY_APP.GUI.TOPIC
{
    public partial class ListTopic : Form
    {
        public ListTopic()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CreateTopic createTopic = new CreateTopic();
            createTopic.ShowDialog();
        }
    }
}

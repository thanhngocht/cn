using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THE_COOKY_APP.GUI.LOCATION
{
    public partial class ListLocation : Form
    {
        public ListLocation()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CreateLocation createLocation = new CreateLocation();
            createLocation.ShowDialog();
        }
    }
}

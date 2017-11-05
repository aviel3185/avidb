using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace imdb
{
    public partial class continueasadmin : Form
    {
        public continueasadmin()
        {
            InitializeComponent();
        }

        private void yes_Click(object sender, EventArgs e)
        {
            openingwindow.userlvl = 2;
            Close();
        }

        private void no_Click(object sender, EventArgs e)
        {
            openingwindow.userlvl = 1;
            Close();
        }
    }
}

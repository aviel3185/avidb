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
    public partial class logged : Form
    {
        
        public logged()
        {
            InitializeComponent();
            FormClosed += Logged_FormClosed;
            BackColor = Color.LightSlateGray;
            usermenu.BackColor = BackColor;
           
            if (openingwindow.userlvl == 2)
                adminPanelToolStripMenuItem.Visible = true;
            
        }

        private void Logged_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

       

        private void logged_Load(object sender, EventArgs e)
        {
           
        }

        private void userPanelToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void adminPanelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adminpanel ap = new adminpanel();
            ap.ShowDialog();
        }
    }
}

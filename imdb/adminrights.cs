using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace imdb
{
    public partial class adminrights : Form
    {
        public adminrights()
        {

            InitializeComponent();
        }

        private void toggler_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;
            int _out;
            bool success = int.TryParse(input, out _out);

            if (success)
            {
                if (usermethods.exists(int.Parse(input)))
                {
                    usermethods.viaid(int.Parse(input));
                    progressl.Text = "Successfully toggled!";
                }
                else
                    progressl.Text = "User does not exist!";
            }
            else
            {
                if (usermethods.exists(input))
                {
                    usermethods.viamail(input);
                    progressl.Text = "Successfully toggled!";
                }
                else
                    progressl.Text = "User does not exist!";
            }




        }
    }
}

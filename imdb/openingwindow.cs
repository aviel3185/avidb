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
    public partial class openingwindow : Form
    {
        static public int loggeduserid , userlvl=0;
        static public bool successfullogin = false;
        private loginform login = new loginform();
        private registerform register = new registerform();
        public static logged logged = new logged();

        public openingwindow()
        {
            InitializeComponent();

            //Continue as a guest
            Button guestB = new Button();
            guestB.Text = "Continue as guest";
            guestB.Location = new Point(50, 200);
            guestB.Width = 250;
            guestB.Height = 30;
            Controls.Add(guestB);
            guestB.Click += guestB_Click;

            //continue as a member
            Button memberB = new Button();
            memberB.Text = "Login";
            memberB.Location = new Point(50, 60);
            memberB.Width = 250;
            memberB.Height = 30;
            Controls.Add(memberB);
            memberB.Click += MemberB_Click;

            //register
            Button register = new Button();
            register.Text = "Register Now!";
            register.Location = new Point(50, 130);
            register.Width = 250;
            register.Height = 30;
            Controls.Add(register);
            register.Click += Register_Click;

        }

        private void Register_Click(object sender, EventArgs e)
        {
            register.ShowDialog();
            if (userlvl == 1)
            {
                Hide();
                logged.ShowDialog();
            }
        }

        private void MemberB_Click(object sender, EventArgs e)
        {
            login.ShowDialog();
            if (successfullogin)
            {
                continueasadmin caa = new continueasadmin();
                Hide();
                logged.ShowDialog();
            }
        }

        private void guestB_Click(object sender, EventArgs e)
        {

            Hide();
            logged.ShowDialog();

        }
    }


}

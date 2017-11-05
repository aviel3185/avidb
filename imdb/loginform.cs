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
    public partial class loginform : Form
    {
        private TextBox usernbox = new TextBox();
        private Label pass = new Label();
        private Label usern = new Label();
        private TextBox passbox = new TextBox();
        private Button loginbutton = new Button();
        public int logid = 0;
        public loginform()
        {
            InitializeComponent();

            //username label
            usern.Text = "email: ";
            usern.Location = new Point(60, 60);
            usern.Width = 40;
            usern.Height = 30;
            Controls.Add(usern);

            //username textbox
            usernbox.Location = new Point(100, 57);
            usernbox.Width = 130;
            usernbox.Height = 30;
            Controls.Add(usernbox);

            //password label
            pass.Text = "Password: ";
            pass.Location = new Point(60, 120);
            pass.Width = 60;
            pass.Height = 30;
            Controls.Add(pass);

            //password textbox
            passbox.Location = new Point(120, 120);
            passbox.Width = 100;
            passbox.Height = 30;
            passbox.PasswordChar = '*';
            Controls.Add(passbox);

            //login button
            loginbutton.Location = new Point(110, 170);
            loginbutton.Text = "Login!";
            loginbutton.Width = 70;
            loginbutton.Height = 30;
            loginbutton.Click += Loginbutton_Click;
            Controls.Add(loginbutton);
        }

        private void Loginbutton_Click(object sender, EventArgs e)
        {
            string mail = usernbox.Text;
            string password = passbox.Text;
            if (usermethods.validation(mail, password))
            {
                openingwindow.loggeduserid = usermethods.getUser(mail);
                openingwindow.successfullogin = true;
                continueasadmin con = new continueasadmin();
                if (usermethods.isadmin(mail))
                    con.ShowDialog();
                logged logged = new logged();
                logged.ShowDialog();
                Close();
            }
            else
                MessageBox.Show("Mail or password is incorrect!");
        }

        
    }
}


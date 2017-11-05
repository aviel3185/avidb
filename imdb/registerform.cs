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
    public partial class registerform : Form
    {
        private Button register = new Button();
        private DateTimePicker birthdatet = new DateTimePicker();
        private TextBox firstnbox = new TextBox();
        private TextBox lastnbox = new TextBox();
        private TextBox passbox = new TextBox();
        private TextBox mailbox = new TextBox();
        public registerform()
        {
            InitializeComponent();
            //firstname label
            Label firstn = new Label();
            firstn.Text = "First Name:";
            firstn.Location = new Point(80, 60);
            firstn.Width = 70;
            firstn.Height = 30;
            Controls.Add(firstn);

            //firstname textbox
            firstnbox.Location = new Point(170, 57);
            firstnbox.Width = 100;
            firstnbox.Height = 30;
            Controls.Add(firstnbox);

            //last name label
            Label lastn = new Label();
            lastn.Text = "Last Name:";
            lastn.Location = new Point(80, 100);
            lastn.Width = 70;
            lastn.Height=30;
            Controls.Add(lastn);

            //last name textbox
            lastnbox.Location = new Point(170, 100);
            lastnbox.Width = 100;
            lastnbox.Height = 30;
            Controls.Add(lastnbox);

            //password label
            Label pass = new Label();
            pass.Text = "Password:";
            pass.Location = new Point(85, 147);
            pass.Width = 60;
            pass.Height = 30;
            Controls.Add(pass);

            //password textbox
            passbox.Location = new Point(170, 145);
            passbox.Width = 100;
            passbox.Height = 30;
            Controls.Add(passbox);

            //mail label
            Label maill = new Label();
            maill.Text = "Mail:";
            maill.Location = new Point(102, 185);
            maill.Width = 40;
            maill.Height = 30;
            Controls.Add(maill);

            //mail textbox
            mailbox.Location = new Point(160,185);
            mailbox.Width = 120;
            mailbox.Height = 30;
            Controls.Add(mailbox);
           
            //birthdate label
            Label birthdatel = new Label();
            birthdatel.Text = "Birthdate: ";
            birthdatel.Location = new Point(70, 230);
            birthdatel.Width = 60;
            birthdatel.Height = 30;
            Controls.Add(birthdatel);

            //birthdate picker
            birthdatet.Location = new Point(145, 230);
            birthdatet.Width = 200;
            birthdatet.Height = 30;
            Controls.Add(birthdatet);

            //register button
            register.Text = "Register!";
            register.Location = new Point(100, 600);
            register.Width = 70;
            register.Height = 40;
            Controls.Add(register);
            register.Click += Register_Click;
        }

        private void Register_Click(object sender, EventArgs e)
        {
            string firstname = firstnbox.Text;
            string lastname = lastnbox.Text;
            string password = passbox.Text;
            string mail = mailbox.Text;
            string birthdate = birthdatet.Text;
            usermethods.adduser(firstname, lastname, password, 0, 0, mail, birthdate);
            openingwindow.loggeduserid = usermethods.getUser(mail);
            openingwindow.userlvl = 1;
            MessageBox.Show("Successfuly registered!");
        }
    }
}

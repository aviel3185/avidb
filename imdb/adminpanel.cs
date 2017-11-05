using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using DAL;

namespace imdb
{
    public partial class adminpanel : Form
    {
        public static OleDbConnection cn = new OleDbConnection(oledbhelper.ConnectionString);
        public static OleDbCommand command = new OleDbCommand();
        public static OleDbDataAdapter da = new OleDbDataAdapter(command);
        
        public adminpanel()
        {
            command.Connection = cn;
            InitializeComponent();
            
        }

        private void tblusers_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            cn.Open();
            command.CommandText = "SELECT * FROM Users";
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            cn.Close();
        }

        private void setadmins_Click(object sender, EventArgs e)
        {
            adminrights ar = new adminrights();
            ar.ShowDialog();
            
        }

        private void actorstbl_Click(object sender, EventArgs e)
        {
            
            DataTable dt = new DataTable();
            cn.Open();
            command.CommandText = "SELECT * FROM Actors";
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            cn.Close();
        }
    }
}

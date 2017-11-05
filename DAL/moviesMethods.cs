using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
//using DAL;

namespace DAL
{
    class moviesMethods
    {
        //get all users
        public static DataTable getAll()
        {
            string com = "SELECT * FROM Movies";
            return oledbhelper.GetTable(com);
        }

        //checks if exists
        public static bool exists(string moviename)
        {
            DataTable d = getAll();
            for (int i = 0; i < d.Rows.Count; i++)
                if ((string)d.Rows[i]["Mname"] == moviename)
                    return true;
            return false;
        }

        //get 1 user
        public static DataTable getUser(string moviename)
        {
            string com = "select * from Movies WHERE Mname='" + moviename + "'";
            return oledbhelper.GetTable(com);
        }

        //add
        public static void addmovie(string moviename, string desc, string airdate)
        {
            string com = "INSERT into Movies (Mname,Description,AirDate) VALUES ('" + moviename.Replace("'", "''") + "','" + desc.Replace("'", "''") + "','" +airdate.Replace("'", "''")+ "')";
            oledbhelper.Execute(com);
        }

        //update
        public static void updatemovie(string fieldname, string fieldvalue, string moviename)
        {
            string com = "UPDATE Movies SET " + fieldname + " = '" + fieldvalue + "' WHERE Mname = '" + moviename + "'";
            oledbhelper.Execute(com);
        }

        //delete
        public static void deletemovie(string moviename)
        {
            string com = "DELETE * FROM Users WHERE [Mname]='" + moviename + "'";
            oledbhelper.Execute(com);
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace DAL
{
    public class usermethods
    {
        //get all users
        public static DataTable getAll()
        {
            string com = "SELECT * FROM Users";
            return oledbhelper.GetTable(com);
        }
        //checks if exists via first&last name
        public static bool exists(string firstname, string lastname, string mail)
        {
            DataTable d = getAll();
            for (int i = 0; i < d.Rows.Count; i++)
            {
                if ((string)d.Rows[i]["FirstName"] == firstname && (string)d.Rows[i]["LastName"] == lastname)
                    return true;
                if ((string)d.Rows[i]["Mail"] == mail)
                    return true;
            }
            return false;
        }

        //checks if exists via id
        public static bool exists(int id)
        {
            DataTable d = getAll();
            for (int i = 0; i < d.Rows.Count; i++)
                if ((int)d.Rows[i]["ID"] == id)
                    return true;
            return false;
        }
        public static bool exists(string mail)
        {
            DataTable d = getAll();
            for (int i = 0; i < d.Rows.Count; i++)
                if ((string)d.Rows[i]["Mail"] == mail)
                    return true;
            return false;
        }
        
        //checks if the user is an admin
        public static bool isadmin(string mail)
        {
            string com = "select * from Users WHERE Mail='" + mail + "'";

            DataTable d = oledbhelper.GetTable(com);
            bool output= (bool)d.Rows[0]["isAdmin"];
            if (!output)
            return false;
            return true;
        }

        //Validation
        public static bool validation(string mail, string password)
        {
            DataTable d = getAll();
            for (int i = 0; i < d.Rows.Count; i++)
                if ((string)d.Rows[i]["UserPassword"] == password && (string)d.Rows[i]["Mail"] == mail)
                    return true;
            return false;
        }
        //get 1 user
        public static int getUser(string mail)
        {
            string com = "select * from Users WHERE Mail='" + mail + "'";

            DataTable d = oledbhelper.GetTable(com);
            return (int)d.Rows[0]["ID"];
        }
        //add
        public static void adduser(string firstname, string lastname, string password, int isadmin, int activitylvl, string mail, string birthdate)
        {
            string com = "INSERT into Users (FirstName,LastName,UserPassword,isAdmin, ActivityLevel, Mail, BirthDate) VALUES ('" + firstname.Replace("'", "''") + "','" + lastname.Replace("'", "''") + "','" + password.Replace("'", "''") + "'," + isadmin + "," + activitylvl + ",'" + mail.Replace("'", "''") + "','" + birthdate + "')";
            oledbhelper.Execute(com);
        }
        //update
        public static void updateuser(string fieldname, string fieldvalue, string mail)
        {
            string com = "UPDATE Users SET " + fieldname + " = '" + fieldvalue + "' WHERE Mail = '" + mail + "'";
            oledbhelper.Execute(com);
        }
        //toggle admin rights via ID
        public static void viaid(int id)
        {
            string com = "UPDATE Users SET isAdmin  = NOT isAdmin WHERE ID = " + id;
            oledbhelper.Execute(com);

        }

        public static void viamail(string mail)
        {
            string com = "UPDATE Users SET isAdmin  = NOT isAdmin WHERE Mail = '" + mail+"'";
            oledbhelper.Execute(com);

        }
        //delete
        public static void deleteuser(string mail)
        {
            string com = "DELETE * FROM Users WHERE [mail]='" + mail + "'";
            oledbhelper.Execute(com);
        }
        //mark userid of all comments as deleted
        public static void deleted(int userid)
        {
            string com = "UPDATE SeriesC SET userID = -1 WHERE userID =" + userid;
            oledbhelper.Execute(com);
            com = "UPDATE MovieC SET userID = -1 WHERE userID =" + userid;
            oledbhelper.Execute(com);
        }
        
        
    }
}

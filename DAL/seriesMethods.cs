using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL
{
    class seriesMethods
    {
        //get all series
        public static DataTable getAll()
        {
            string com = "SELECT * FROM Series";
            return oledbhelper.GetTable(com);
        }

        //checks if exists
        public static bool exists(string seriename)
        {
            DataTable d = getAll();
            for (int i = 0; i < d.Rows.Count; i++)
                if ((string)d.Rows[i]["SerieName"] == seriename)
                    return true;
            return false;
        }

        //get 1 Serie
        public static DataTable getserie(string seriename)
        {
            string com = "select * from Series WHERE SerieName='" + seriename + "'";
            return oledbhelper.GetTable(com);
        }

        //add
        public static void addserie(string seriename, string desc, string airdate, int episodes)
        {
            string com = "INSERT into Series (SerieName,desc,AirDate,Episodes) VALUES ('" + seriename.Replace("'", "''") + "','" + desc.Replace("'", "''") + "','" + airdate.Replace("'", "''") + "',"+episodes+")";
            oledbhelper.Execute(com);
        }

        //update
        public static void updateserie(string fieldname, string fieldvalue, string seriename)
        {
            string com = "UPDATE Series SET " + fieldname + " = '" + fieldvalue + "' WHERE SerieName = '" + seriename + "'";
            oledbhelper.Execute(com);
        }

        //delete
        public static void deleteserie(string seriename)
        {
            string com = "DELETE * FROM Series WHERE SerieName='" + seriename + "'";
            oledbhelper.Execute(com);
        }
        
        
    }
}

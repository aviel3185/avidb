using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL
{
    class SeriesCmethods
    {
        //get all comments
        public static DataTable getAll()
        {
            string com = "SELECT * FROM SeriesC";
            return oledbhelper.GetTable(com);
        }
        //post
        public static void post(int id, string comment, int serieid)
        {
            string time= DateTime.Now.ToString();
            string com = "INSERT into SeriesC (userID,Comment,SerieId,PostTime) VALUES (" + id + ",'" + comment + "'," + serieid + ",'" + time.Replace("'", "''") + "')";
            oledbhelper.Execute(com);
        }
        
        //edit comment
        public static void edit(int id, string comment)
        {
            string com = "UPDATE SeriesC SET Comment = '" + comment + "' WHERE ID ="+id;
            oledbhelper.Execute(com);
            com="UPDATE SeriesC Set EditTime = '"+DateTime.Now.ToString()+"' WHERE ID = " + id;
            oledbhelper.Execute(com);
        }
        //delete all comments of a user
        public static void deletecomments(int userid)
        {
            string com = "DELETE * FROM SeriesC WHERE userID=" + userid;
            oledbhelper.Execute(com);
        }
        //delete a comment
        public static void deletecomment(int id)
        {
            string com = "DELETE * FROM SeriesC WHERE ID=" + id;
            oledbhelper.Execute(com);
        }
    }
}

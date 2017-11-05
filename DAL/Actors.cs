using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL
{
    class Actors
    {
        //get all users
        public static DataTable getAll()
        {
            string com = "SELECT * FROM Actors";
            return oledbhelper.GetTable(com);
        }

        //checks if exists
        public static bool exists(string fname, string lname)
        {
            DataTable d = getAll();
            for (int i = 0; i < d.Rows.Count; i++)
                if ((string)d.Rows[i]["FName"] == fname && (string)d.Rows[i]["LName"] == lname)
                    return true;
            return false;
        }

        //get 1 user
        public static DataTable getactor(int id)
        {
            string com = "select * from Actors WHERE ID='" + id + "'";

            return oledbhelper.GetTable(com);
        }

        //add
        public static void addactor(string fname, string lname, string birthdate)
        {
            string com = "INSERT into Actors (FName,LName,Bdate) VALUES ('" + fname.Replace("'", "''") + "','" + lname.Replace("'", "''") + "','" + birthdate.Replace("'", "''") + "')";
            oledbhelper.Execute(com);
        }

        //update
        public static void updateactor(string fieldname, string fieldvalue, string fname, string lname)
        {
            string com = "UPDATE Actors SET " + fieldname + " = '" + fieldvalue + "' WHERE FName = '" + fname + "' AND " + "LName = '" + lname + "'";
            oledbhelper.Execute(com);
        }

        //delete
        public static void deleteactor(string fname, string lname)
        {
            string com = "DELETE * FROM Users WHERE FName='" + fname + "' AND LName =" + lname + "'";
            oledbhelper.Execute(com);
        }
        //add actor to a serie
        public static void addtoserie(int actorid, int serieid)
        {
            string com = "INSERT into CastToSerie (ActorId,SerieId) VALUES (" + actorid + "," + serieid + ")";
            oledbhelper.Execute(com);
        }
        //add actor to a movie
        public static void addtomovie(int actorid, int movieid)
        {
            string com = "INSERT into CastToMovie (ActorId,MovieId) VALUES (" + actorid + "," + movieid + ")";
            oledbhelper.Execute(com);
        }
    }
}


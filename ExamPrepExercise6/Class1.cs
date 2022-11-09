using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;
using System.Data.OleDb;
using System.Data;

namespace ExamPrepExercise6
{
    public class Class1
    {
        OleDbConnection conn;

        public void ConnectToDatabase()
        {
            string relativePath = HttpContext.Current.Server.MapPath("Nominations.mdb");
            conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + relativePath);
            conn.Open();
        }
        public void DisconnectFromDatabase()
        {
            conn.Close();
        }
        public OleDbDataReader Query(String query)
        {
            try 
            {

                OleDbCommand cmd = conn.CreateCommand();
                cmd.CommandText = query;
                return cmd.ExecuteReader();
            }
            catch
            {
                return null;
            }
        }
        public bool ExecuteCommand(String query)                                                                 
        {
            try                                                                                                
            {
                OleDbCommand cmd = conn.CreateCommand();                                                  
                cmd.CommandText = query;                                                                        
                cmd.ExecuteNonQuery();                                                                          
                return true;                                                                                     
            }
            catch
            {
                return false;                                                                                    
            }
        }
       public DataTable Data()
        {
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT heroName, COUNT(heroName) AS voteAmount FROM [Votes] GROUP BY heroName;", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }
    }
   
}
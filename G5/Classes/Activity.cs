using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G5
{
    public class Activity
    {
        public string activityID { get; set; }
        public DateTime creationDate { get; set; }
        public string title { get; set; }
        public string content { get; set; }
        public double? totalRank { get; set; }
        public string writerID { get; set; }


        public Activity(
            string activityID,
            DateTime creationDate,
            string title,
            string content,
            string writerID,
            double? totalRank = null,
            bool isNew = false
        )
        {
            this.activityID = activityID;
            this.creationDate = creationDate;
            this.title = title;
            this.content = content;
            this.writerID = writerID;
            this.totalRank = totalRank;

            if (isNew)
            {
                CreateActivity();
                Program.Activities.Add(this); // אם קיימת רשימה כזו
            }
        }

        public void CreateActivity()
        {
            var cmd = new SqlCommand("CreateActivity")
            {
                CommandType = CommandType.StoredProcedure
            };

            cmd.Parameters.AddWithValue("@activityID", this.activityID);
            cmd.Parameters.AddWithValue("@creationDate", this.creationDate);
            cmd.Parameters.AddWithValue("@title", this.title);
            cmd.Parameters.AddWithValue("@content", this.content);
            cmd.Parameters.AddWithValue("@writerID", this.writerID);
            cmd.Parameters.AddWithValue("@totalRank", (object)this.totalRank ?? DBNull.Value);

            var sc = new SQL_CON();
            sc.execute_non_query(cmd);
        }

        public void DeleteActivity()
        {
            SqlCommand cmd = new SqlCommand("dbo.DeleteActivity")
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("@activityID", this.activityID);

            SQL_CON sc = new SQL_CON();
            sc.execute_non_query(cmd);

            Program.Activities.Remove(this);
        }

        public void UpdateActivity()
        {
            SqlCommand cmd = new SqlCommand("dbo.UpdateActivity")
            {
                CommandType = CommandType.StoredProcedure
            };

            cmd.Parameters.AddWithValue("@activityID", this.activityID);
            cmd.Parameters.AddWithValue("@creationDate", this.creationDate);
            cmd.Parameters.AddWithValue("@title", this.title);
            cmd.Parameters.AddWithValue("@content", this.content);
            cmd.Parameters.AddWithValue("@totalRank", this.totalRank);
            cmd.Parameters.AddWithValue("@writerID", this.writerID);

            SQL_CON sc = new SQL_CON();
            sc.execute_non_query(cmd);
        }

        public static Activity GetActivityByID(string id)
        {
            SqlCommand cmd = new SqlCommand("dbo.GetActivityByID")
            {
                CommandType = CommandType.StoredProcedure
            };

            cmd.Parameters.AddWithValue("@activityID", id);
            SQL_CON sc = new SQL_CON();
            SqlDataReader rdr = sc.execute_query(cmd);

            if (rdr.Read())
            {
                DateTime creationDate = (DateTime)rdr["creationDate"];
                string title = rdr["title"].ToString();
                string content = rdr["content"].ToString();
                double totalRank = rdr["totalRank"] != DBNull.Value ? Convert.ToDouble(rdr["totalRank"]) : 0;
                string writerID = rdr["writerID"].ToString();

                rdr.Close();
                return new Activity(id, creationDate, title, content, writerID, totalRank);
            }

            rdr.Close();
            return null;
        }


        public string GetID()
        {
            return this.activityID;
        }
    }
}

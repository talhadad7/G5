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
        private string activityID;
        private DateTime creationDate;
        private string title;
        private string content;
        private int? totalRank;
        private Member writer;

        public Activity(
            string activityID,
            DateTime creationDate,
            string title,
            string content,
            Member writer,
            int? totalRank = null,
            bool isNew = false
        )
        {
            this.activityID = activityID;
            this.creationDate = creationDate;
            this.title = title;
            this.content = content;
            this.writer = writer;
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
            cmd.Parameters.AddWithValue("@writerID", this.writer.GetID());
            cmd.Parameters.AddWithValue("@totalRank", (object)this.totalRank ?? DBNull.Value);

            var sc = new SQL_CON();
            sc.execute_non_query(cmd);
        }

        public string GetID()
        {
            return this.activityID;
        }
    }
}

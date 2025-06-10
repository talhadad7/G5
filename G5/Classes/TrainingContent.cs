using System;
using System.Data;
using System.Data.SqlClient;

namespace G5
{
    public class TrainingContent
    {
        private string handoverID;
        private string title;
        private MemberTypeLookup targetAudience;
        private DateTime creationDate;
        private string content;

        public TrainingContent(
            string handoverID,
            string title,
            MemberTypeLookup targetAudience,
            DateTime creationDate,
            string content,
            bool isNew = false
        )
        {
            this.handoverID = handoverID;
            this.title = title;
            this.targetAudience = targetAudience;
            this.creationDate = creationDate;
            this.content = content;

            if (isNew)
            {
                CreateTrainingContent();
                Program.TrainingContents.Add(this); // אם קיימת רשימה מרכזית
            }
        }

        public void CreateTrainingContent()
        {
            var cmd = new SqlCommand("CreateTrainingContent")
            {
                CommandType = CommandType.StoredProcedure
            };

            cmd.Parameters.AddWithValue("@handoverID", this.handoverID);
            cmd.Parameters.AddWithValue("@title", this.title);
            cmd.Parameters.AddWithValue("@targetAudience", this.targetAudience.ToString());
            cmd.Parameters.AddWithValue("@creationDate", this.creationDate);
            cmd.Parameters.AddWithValue("@content", this.content);

            var sc = new SQL_CON();
            sc.execute_non_query(cmd);
        }

        public string GetID()
        {
            return this.handoverID;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace G5
{
    public class Proposal
    {
        // שדות מהטבלה
        public string proposalID { get; set; }
        public string senderComments { get; set; }
        public int? numOfParticipants { get; set; }
        public bool? approvalStatus { get; set; }
        public string coordinatorComments { get; set; }

        public string activityID { get; set; }
        public string areaID { get; set; }
        public DateTime activityDate { get; set; }

        public Group group { get; set; }

        // שדות נוספים להצגה (לא קיימים ב-SQL)
        public string areaName { get; private set; }
        public string activityName { get; private set; }

        // בנאי עם אתחול ושליפת שמות
        public Proposal(
            string proposalID,
            string senderComments,
            int? numOfParticipants,
            bool? approvalStatus,
            string coordinatorComments,
            string activityID,
            string areaID,
            DateTime activityDate,
            Group group
        )
        {
            if (numOfParticipants < 0)
                throw new ArgumentException("numOfParticipants must be non-negative.");

            this.proposalID = proposalID;
            this.senderComments = senderComments;
            this.numOfParticipants = numOfParticipants;
            this.approvalStatus = approvalStatus;
            this.coordinatorComments = coordinatorComments;
            this.activityID = activityID;
            this.areaID = areaID;
            this.activityDate = activityDate;
            this.group = group ?? throw new ArgumentNullException(nameof(group));

            // שליפות אוטומטיות לשמות
            FetchAreaName();
            FetchActivityName();
        }

        // בנאי ריק (לשימוש גמיש)
        public Proposal() { }

        // שליפה מהירה של שם אזור לפי areaID
        public void FetchAreaName()
        {
            if (string.IsNullOrEmpty(this.areaID))
            {
                // רק מציין שאין אזור – לא שומר בטבלה
                areaName = "ללא אזור";
                return;
            }

            SqlCommand cmd = new SqlCommand("SELECT areaName FROM dbo.Areas WHERE areaID = @areaID");
            cmd.Parameters.AddWithValue("@areaID", this.areaID);

            SQL_CON sql = new SQL_CON();
            SqlDataReader rdr = sql.execute_query(cmd);

            if (rdr != null && rdr.Read())
                areaName = rdr["areaName"].ToString();
            else
                areaName = "אזור לא נמצא";

            rdr?.Close();
        }



        // שליפה מהירה של שם פעילות לפי activityID
        public void FetchActivityName()
        {
            SqlCommand cmd = new SqlCommand("SELECT title FROM dbo.Activity WHERE activityID = @activityID");
            cmd.Parameters.AddWithValue("@activityID", this.activityID);

            SQL_CON sql = new SQL_CON();
            SqlDataReader rdr = sql.execute_query(cmd);

            if (rdr.Read())
                activityName = rdr["title"].ToString();
            else
                activityName = "פעילות לא נמצאה";

            rdr.Close();
        }

        // תצוגה נחמדה לאובייקט
        public override string ToString()
        {
            return $"ProposalID: {proposalID}, Group: {group}, Activity: {activityName} on {activityDate:yyyy-MM-dd}, Area: {areaName}, Participants: {numOfParticipants ?? 0}, Approved: {(approvalStatus.HasValue ? (approvalStatus.Value ? "Yes" : "No") : "Pending")}";
        }
    }
}

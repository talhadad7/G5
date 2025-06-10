EVENTFILES
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G5
{
    public class EventFile
    {
        private string eventID;
        private EventTypeLookup eventType;
        private double durationInDays;
        private DateTime startDate;
        private int? numOfBuses;
        private int? numOfParticipants;
        private int? budget;
        private AgeGroupLookup targetAudience;
        private EventLocationLookup location;
        private double? totalMoneySpent;

        public EventFile(
            string eventID,
            EventTypeLookup eventType,
            double durationInDays,
            DateTime startDate,
            AgeGroupLookup targetAudience,
            EventLocationLookup location,
            int? numOfBuses = null,
            int? numOfParticipants = null,
            int? budget = null,
            double? totalMoneySpent = null,
            bool isNew = false
        )
        {
            this.eventID = eventID;
            this.eventType = eventType;
            this.durationInDays = durationInDays;
            this.startDate = startDate;
            this.numOfBuses = numOfBuses;
            this.numOfParticipants = numOfParticipants;
            this.budget = budget;
            this.targetAudience = targetAudience;
            this.location = location;
            this.totalMoneySpent = totalMoneySpent;

            if (isNew)
            {
                CreateEventFile();
                Program.EventFiles.Add(this); // אם יש רשימה כזו כמו ב־Member
            }
        }

        public void CreateEventFile()
        {
            var cmd = new SqlCommand("CreateEventFile")  // חשוב שתהיה לך פרוצדורה כזו ב-SQL
            {
                CommandType = CommandType.StoredProcedure
            };

            cmd.Parameters.AddWithValue("@eventID", this.eventID);
            cmd.Parameters.AddWithValue("@eventType", this.eventType.ToString());
            cmd.Parameters.AddWithValue("@durationInDays", this.durationInDays);
            cmd.Parameters.AddWithValue("@startDate", this.startDate);
            cmd.Parameters.AddWithValue("@targetAudience", this.targetAudience.ToString());
            cmd.Parameters.AddWithValue("@location", this.location.ToString());
            cmd.Parameters.AddWithValue("@numOfBuses", (object)this.numOfBuses ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@numOfParticipants", (object)this.numOfParticipants ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@budget", (object)this.budget ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@totalMoneySpent", (object)this.totalMoneySpent ?? DBNull.Value);

            var sc = new SQL_CON();
            sc.execute_non_query(cmd);
        }

        public string GetEventID()
        {
            return this.eventID;
        }
    }
}

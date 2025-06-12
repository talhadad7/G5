// Participant.cs
using G5;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
namespace G5
{
    public class Participant
    {
        public string participantID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public DateTime birthDate { get; set; }
        public GenderLookup genderName { get; set; }
        public string address { get; set; }
        public string school { get; set; }
        public AgeGroupLookup ageGroupName { get; set; }
        public bool paymentStatus { get; set; }
        public DateTime joinDate { get; set; }
        public string emergencyContact { get; set; }
        public string medicalNotes { get; set; }

        // Primary constructor
        public Participant(
            string id,
            string firstName,
            string lastName,
            DateTime birthDate,
            GenderLookup genderName,
            DateTime joinDate,
            AgeGroupLookup ageGroupName,
            bool paymentStatus = false,
            string address = null,
            string school = null,
            string emergencyContact = null,
            string medicalNotes = null,
            bool isNew = false
        )
        {
            this.participantID = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.birthDate = birthDate;
            this.genderName = genderName;
            this.address = address;
            this.school = school;
            this.ageGroupName = ageGroupName;
            this.paymentStatus = paymentStatus;
            this.joinDate = joinDate;
            this.emergencyContact = emergencyContact;
            this.medicalNotes = medicalNotes;

            if (isNew)
            {
                CreateParticipant();
                Program.Participants.Add(this);
            }
        }

        // Insert into DB via stored proc
        public void CreateParticipant()
        {
            var cmd = new SqlCommand("CreateParticipant")
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("@participantID", this.participantID);
            cmd.Parameters.AddWithValue("@firstName", this.firstName);
            cmd.Parameters.AddWithValue("@lastName", this.lastName);
            cmd.Parameters.AddWithValue("@birthDate", this.birthDate);
            cmd.Parameters.AddWithValue("@gender", this.genderName.ToString());
            cmd.Parameters.AddWithValue("@address", (object)this.address ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@school", (object)this.school ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@ageGroupID", this.ageGroupName.ToString());
            cmd.Parameters.AddWithValue("@paymentStatus", this.paymentStatus);
            cmd.Parameters.AddWithValue("@joinDate", this.joinDate);
            cmd.Parameters.AddWithValue("@emergencyContact", (object)this.emergencyContact ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@medicalNotes", (object)this.medicalNotes ?? DBNull.Value);

            var sc = new SQL_CON();
            sc.execute_non_query(cmd);
        }
        public void DeleteParticipant()
        {
            SqlCommand cmd = new SqlCommand("dbo.DeleteParticipant")
            {
                CommandType = CommandType.StoredProcedure
            };

            cmd.Parameters.AddWithValue("@participantID", this.participantID);

            SQL_CON sc = new SQL_CON();
            sc.execute_non_query(cmd);

            // הסרה מהזיכרון, אם קיים
            Program.Participants.Remove(this);
        }
        public void UpdateParticipant()
        {
            SqlCommand cmd = new SqlCommand("dbo.UpdateParticipant")
            {
                CommandType = CommandType.StoredProcedure
            };

            cmd.Parameters.AddWithValue("@ParticipantID", this.participantID);
            cmd.Parameters.AddWithValue("@firstName", this.firstName);
            cmd.Parameters.AddWithValue("@lastName", this.lastName);
            cmd.Parameters.AddWithValue("@birthDate", this.birthDate);
            cmd.Parameters.AddWithValue("@gender", this.genderName.ToString());
            cmd.Parameters.AddWithValue("@address", string.IsNullOrEmpty(this.address) ? DBNull.Value : (object)this.address);
            cmd.Parameters.AddWithValue("@school", string.IsNullOrEmpty(this.school) ? DBNull.Value : (object)this.school);
            cmd.Parameters.AddWithValue("@ageGroupID", this.ageGroupName.ToString());
            // כאן אנו שולחים BINARY(1)
            cmd.Parameters.AddWithValue("@paymentStatus", this.paymentStatus ? new byte[] { 1 } : new byte[] { 0 });
            cmd.Parameters.AddWithValue("@joinDate", this.joinDate);
            cmd.Parameters.AddWithValue("@emergencyContact", string.IsNullOrEmpty(this.emergencyContact) ? DBNull.Value : (object)this.emergencyContact);
            cmd.Parameters.AddWithValue("@medicalNotes", string.IsNullOrEmpty(this.medicalNotes) ? DBNull.Value : (object)this.medicalNotes);

            SQL_CON sc = new SQL_CON();
            sc.execute_non_query(cmd);
        }


        public string GetID() => this.participantID;
    }
}
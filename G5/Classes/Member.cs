// Constructors and CreateMember method for Member.cs

using G5;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;

namespace G5
{
    public class Member
    {
        private string memberID;
        private string firstName;
        private string lastName;
        private MemberTypeLookup memberTypeName;
        private DateTime birthDate;
        private GenderLookup genderName;
        private string address;
        private string emergencyContact;
        private bool paymentStatus;
        private DateTime joinDate;
        private TrainingStatusLookup trainingStatusName;
        private int seniority;

        // Primary constructor (for new or existing members)
        public Member(
            string id,
            string firstName,
            string lastName,
            MemberTypeLookup memberTypeName,
            DateTime birthDate,
            GenderLookup genderName,
            DateTime joinDate,
            int seniority,
            bool isNew = false,
            string address = null,
            string emergencyContact = null,
            bool paymentStatus = false,
            TrainingStatusLookup trainingStatusName = TrainingStatusLookup.FirstInterview
        )
        {
            this.memberID = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.memberTypeName = memberTypeName;
            this.birthDate = birthDate;
            this.genderName = genderName;
            this.address = address;
            this.emergencyContact = emergencyContact;
            this.paymentStatus = paymentStatus;
            this.joinDate = joinDate;
            this.trainingStatusName = trainingStatusName;
            this.seniority = seniority;

            if (isNew)
            {
                CreateMember();
                Program.Members.Add(this);
            }
        }

        // CreateMember: calls stored procedure to insert into database
        public void CreateMember()
        {
            var cmd = new SqlCommand("CreateMember")
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("@memberID", this.memberID);
            cmd.Parameters.AddWithValue("@firstName", this.firstName);
            cmd.Parameters.AddWithValue("@lastName", this.lastName);
            cmd.Parameters.AddWithValue("@memberTypeName", this.memberTypeName);
            cmd.Parameters.AddWithValue("@birthDate", this.birthDate);
            cmd.Parameters.AddWithValue("@genderName", this.genderName);
            cmd.Parameters.AddWithValue("@address", (object)this.address ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@emergencyContact", (object)this.emergencyContact ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@paymentStatus", this.paymentStatus);
            cmd.Parameters.AddWithValue("@joinDate", this.joinDate);
            cmd.Parameters.AddWithValue("@trainingStatusName", (object)this.trainingStatusName ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@seniority", this.seniority);

            var sc = new SQL_CON();
            sc.execute_non_query(cmd);
        }
        public String GetID()
        {
            return this.memberID;
        }
    }
   

}
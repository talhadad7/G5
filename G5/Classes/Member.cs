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
        public string memberID { get; private set; }
        public string firstName { get; private set; }
        public string lastName { get; private set; }
        public MemberTypeLookup memberTypeName { get; private set; }
        public DateTime birthDate { get; private set; }
        public GenderLookup genderName { get; private set; }
        public string address { get; private set; }
        public string emergencyContact { get; private set; }
        public bool paymentStatus { get; private set; }
        public DateTime joinDate { get; private set; }
        public TrainingStatusLookup trainingStatusName { get; private set; }
        public int seniority { get; private set; }
        public string phoneNumber { get; private set; }
        public string emailAddress { get; private set; }


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
            string phoneNumber,
            string emailAddress,
            bool isNew = false,
            string address = null,
            string emergencyContact = null,
            bool paymentStatus = false,
            TrainingStatusLookup trainingStatusName = TrainingStatusLookup.FirstInterview
        )
        {
            if (phoneNumber is null) throw new ArgumentNullException(nameof(phoneNumber));
            if (emailAddress is null) throw new ArgumentNullException(nameof(emailAddress));

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
            this.phoneNumber = phoneNumber;
            this.emailAddress = emailAddress;

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
            cmd.Parameters.AddWithValue("@memberTypeName", this.memberTypeName.ToString());
            cmd.Parameters.AddWithValue("@birthDate", this.birthDate);
            cmd.Parameters.AddWithValue("@genderName", this.genderName.ToString());
            cmd.Parameters.AddWithValue("@address", (object)this.address ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@emergencyContact", (object)this.emergencyContact ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@paymentStatus", this.paymentStatus);
            cmd.Parameters.AddWithValue("@joinDate", this.joinDate);
            cmd.Parameters.AddWithValue("@trainingStatusName", this.trainingStatusName.ToString());
            cmd.Parameters.AddWithValue("@seniority", this.seniority);
            cmd.Parameters.AddWithValue("@phoneNumber", this.phoneNumber);
            cmd.Parameters.AddWithValue("@emailAddress", this.emailAddress);

            var sc = new SQL_CON();
            sc.execute_non_query(cmd);
        }
        public static Member GetMemberByID(string id)
        {
            if (id is null) throw new ArgumentNullException(nameof(id));

            SqlCommand cmd = new SqlCommand("dbo.GetMemberByID") { CommandType = CommandType.StoredProcedure };
            cmd.Parameters.AddWithValue("@memberID", id);

            SQL_CON sql = new SQL_CON();
            SqlDataReader reader = sql.execute_query(cmd);

            if (reader == null)
            {
                Console.WriteLine("שגיאה בקריאה מהמסד.");
                return null;
            }

            Member result = null;

            if (reader.Read())
            {
                result = new Member(
                    reader["memberID"].ToString(),
                    reader["firstName"].ToString(),
                    reader["lastName"].ToString(),
                    (MemberTypeLookup)Enum.Parse(typeof(MemberTypeLookup), reader["memberTypeName"].ToString()),
                    (DateTime)reader["birthDate"],
                    (GenderLookup)Enum.Parse(typeof(GenderLookup), reader["genderName"].ToString()),
                    (DateTime)reader["joinDate"],
                    Convert.ToInt32(reader["seniority"]),
                    reader["phone"].ToString(),
                    reader["email"].ToString(),
                    isNew: false,
                    address: reader["address"] != DBNull.Value ? reader["address"].ToString() : null,
                    emergencyContact: reader["emergencyContact"] != DBNull.Value ? reader["emergencyContact"].ToString() : null,
                    paymentStatus: reader["paymentStatus"] != DBNull.Value && (bool)reader["paymentStatus"],
                    trainingStatusName: reader["trainingStatusName"] != DBNull.Value
                        ? (TrainingStatusLookup)Enum.Parse(typeof(TrainingStatusLookup), reader["trainingStatusName"].ToString())
                        : TrainingStatusLookup.FirstInterview
                );
            }

            // סגור את ה־Reader וה־Connection
            reader.Close();
            cmd.Connection.Close();

            if (result == null)
                Console.WriteLine($"Member with ID {id} not found.");

            return result;
        }
        public String GetID()
        {
            return this.memberID;
        }
        public void UpdateMember()
        {
            var cmd = new SqlCommand("UpdateMember")
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("@memberID", this.memberID);
            cmd.Parameters.AddWithValue("@firstName", this.firstName);
            cmd.Parameters.AddWithValue("@lastName", this.lastName);
            cmd.Parameters.AddWithValue("@memberTypeName", this.memberTypeName.ToString());
            cmd.Parameters.AddWithValue("@birthDate", this.birthDate);
            cmd.Parameters.AddWithValue("@genderName", this.genderName.ToString());
            cmd.Parameters.AddWithValue("@address", (object)this.address ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@emergencyContact", (object)this.emergencyContact ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@paymentStatus", this.paymentStatus);
            cmd.Parameters.AddWithValue("@joinDate", this.joinDate);
            cmd.Parameters.AddWithValue("@trainingStatusName", this.trainingStatusName.ToString());
            cmd.Parameters.AddWithValue("@seniority", this.seniority);
            cmd.Parameters.AddWithValue("@phoneNumber", this.phoneNumber);
            cmd.Parameters.AddWithValue("@emailAddress", this.emailAddress);

            var sc = new SQL_CON();
            sc.execute_non_query(cmd);
        }
        public void DeleteMember()
        {
            var cmd = new SqlCommand("DeleteMember")
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("@memberID", this.memberID);

            var sc = new SQL_CON();
            sc.execute_non_query(cmd);

            Program.Members.Remove(this);
        }

    }


}
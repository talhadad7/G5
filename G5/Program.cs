using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;//חשוב!
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting;
using System.Text;
using System.Windows.Forms;//עבור ההודעות!


namespace G5
{
    public static class Program
    {
        public static System.Collections.Generic.List<Member> Members;
        public static System.Collections.Generic.List<Equipment> Equimpents;
        public static System.Collections.Generic.List<EventFile> EventFiles;
        public static System.Collections.Generic.List<Activity> Activities;
        public static System.Collections.Generic.List<Participant> Participants;

        public static void InitMembers()
        {
            // בנייה של הפקודה לקריאת כל ה־Members
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_Members";  
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            Members = new List<Member>();

            while (rdr.Read())
            {
                // המרת מחרוזות לערכי enum בהתאם לטבלאות ה-Lookup :contentReference[oaicite:1]{index=1}
                MemberTypeLookup mType = (MemberTypeLookup)Enum.Parse(typeof(MemberTypeLookup), rdr.GetValue(3).ToString());
                GenderLookup gender = (GenderLookup)Enum.Parse(typeof(GenderLookup), rdr.GetValue(5).ToString());

                // שדות אופציונליים
                string address = rdr.IsDBNull(6) ? null : rdr.GetValue(6).ToString();
                string emergencyContact = rdr.IsDBNull(7) ? null : rdr.GetValue(7).ToString();
                bool paymentStatus = rdr.GetBoolean(8);
                TrainingStatusLookup? TrainingStatus = rdr.IsDBNull(10)
                    ? (TrainingStatusLookup?)null
                    : (TrainingStatusLookup)Enum.Parse(typeof(TrainingStatusLookup), rdr.GetValue(10).ToString());

                // יצירת מופע Member (ה-isNew יתמלא כברירת מחדל כ-false)
                Member m = new Member(
         rdr.GetValue(0).ToString(),   // id
         rdr.GetValue(1).ToString(),   // firstName
         rdr.GetValue(2).ToString(),   // lastName
         mType,                        // memberType
         rdr.GetDateTime(4),           // birthDate
         gender,                       // gender
         rdr.GetDateTime(9),           // joinDate  <–– כאן
         rdr.GetInt32(11),             // seniority <–– וכאן
         false,                        // isNew
         address,                      // address
         emergencyContact,             // emergencyContact
         paymentStatus,                // paymentStatus
         (TrainingStatusLookup) TrainingStatus                // trainingStatus
     );

                Members.Add(m);
            }

            rdr.Close();
        }

        public static void InitEventFiles()
        {
            // בנייה של הפקודה לקריאת כל ה־EventFiles
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_EventFiles";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            EventFiles = new List<EventFile>();

            while (rdr.Read())
            {
                // המרת מחרוזות לערכי enum בהתאם לטבלאות ה-Lookup
                EventTypeLookup eventType = (EventTypeLookup)Enum.Parse(typeof(EventTypeLookup), rdr.GetValue(1).ToString());
                AgeGroupLookup targetAudience = (AgeGroupLookup)Enum.Parse(typeof(AgeGroupLookup), rdr.GetValue(4).ToString());
                EventLocationLookup location = (EventLocationLookup)Enum.Parse(typeof(EventLocationLookup), rdr.GetValue(5).ToString());

                // שדות אופציונליים
                int? numOfBuses = rdr.IsDBNull(6) ? null : (int?)rdr.GetValue(6);
                int? numOfParticipants = rdr.IsDBNull(7) ? null : (int?)rdr.GetValue(7);
                int? budget = rdr.IsDBNull(8) ? null : (int?)rdr.GetValue(8);
                double? totalMoneySpent = rdr.IsDBNull(9) ? null : (double?)rdr.GetValue(9);

                // יצירת מופע EventFile
                EventFile ef = new EventFile(
                    rdr.GetValue(0).ToString(),    // eventID
                    eventType,                     // eventType
                    (double)rdr.GetValue(2),       // durationInDays
                    (DateTime)rdr.GetValue(3),     // startDate
                    targetAudience,                // targetAudience
                    location,                      // location
                    numOfBuses,                    // numOfBuses
                    numOfParticipants,             // numOfParticipants
                    budget,                        // budget
                    totalMoneySpent,               // totalMoneySpent
                    false                          // isNew
                );

                EventFiles.Add(ef);
            }

            rdr.Close();
        }

        public static void InitParticipants()
        {
            // בנייה של הפקודה לקריאת כל ה־Participants
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_Participants";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            Participants = new List<Participant>();

            while (rdr.Read())
            {
                // המרת מחרוזות לערכי enum בהתאם לטבלאות ה-Lookup
                GenderLookup genderName = (GenderLookup)Enum.Parse(typeof(GenderLookup), rdr.GetValue(4).ToString());
                AgeGroupLookup ageGroupName = (AgeGroupLookup)Enum.Parse(typeof(AgeGroupLookup), rdr.GetValue(7).ToString());

                // שדות אופציונליים
                string address = rdr.IsDBNull(5) ? null : rdr.GetValue(5).ToString();
                string school = rdr.IsDBNull(6) ? null : rdr.GetValue(6).ToString();
                string emergencyContact = rdr.IsDBNull(9) ? null : rdr.GetValue(9).ToString();
                string medicalNotes = rdr.IsDBNull(10) ? null : rdr.GetValue(10).ToString();
                bool paymentStatus = rdr.IsDBNull(8) ? false : rdr.GetBoolean(8);

                // יצירת מופע Participant
                Participant p = new Participant(
                    rdr.GetValue(0).ToString(),    // participantID
                    rdr.GetValue(1).ToString(),    // firstName
                    rdr.GetValue(2).ToString(),    // lastName
                    (DateTime)rdr.GetValue(3),     // birthDate
                    genderName,                    // genderName
                    (DateTime)rdr.GetValue(8),     // joinDate
                    ageGroupName,                  // ageGroupName
                    paymentStatus,                 // paymentStatus
                    address,                       // address
                    school,                        // school
                    emergencyContact,              // emergencyContact
                    medicalNotes,                  // medicalNotes
                    false                          // isNew
                );

                Participants.Add(p);
            }

            rdr.Close();
        }

        public static void InitActivities()
        {
            // בנייה של הפקודה לקריאת כל ה־Activities
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_Activities";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            Activities = new List<Activity>();

            while (rdr.Read())
            {
                // מציאת ה־Member (הכותב) לפי ה־ID
                string writerID = rdr.GetValue(4).ToString();
                Member writer = Program.Members.FirstOrDefault(m => m.GetID() == writerID);

                if (writer == null)
                {
                    // אפשר להוסיף כאן הודעת שגיאה או להמשיך ללא כותב
                    continue;
                }

                // שדה אופציונלי
                int? totalRank = rdr.IsDBNull(5) ? null : (int?)rdr.GetValue(5);

                // יצירת מופע Activity
                Activity a = new Activity(
                    rdr.GetValue(0).ToString(),    // activityID
                    (DateTime)rdr.GetValue(1),     // creationDate
                    rdr.GetValue(2).ToString(),    // title
                    rdr.GetValue(3).ToString(),    // content
                    writer,                        // writer
                    totalRank,                     // totalRank
                    false                          // isNew
                );

                Activities.Add(a);
            }

            rdr.Close();
        }



        [STAThread]
        static void Main()
        {
            InitMembers();
            InitEventFiles();
            InitParticipants();
            InitActivities();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            foreach (Member m in Members)
                Debug.WriteLine($"{m.GetID()}");
            Console.WriteLine("hello");
            Console.WriteLine("hello2");
            Console.WriteLine("hello3");
            Console.WriteLine("hello3");
            Console.WriteLine("hello4");
        }
    }
}


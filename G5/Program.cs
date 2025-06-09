using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;//חשוב!
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;//עבור ההודעות!


namespace G5
{
    public static class Program
    {
        public static System.Collections.Generic.List<Member> Members;
        public static System.Collections.Generic.List<EventFile> EventFiles;
        public static System.Collections.Generic.List<Activity> Activity;

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
        [STAThread]
        static void Main()
        {
            InitMembers();
            InitParticipants();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            foreach (Member m in Members)
                Debug.WriteLine($"{m.GetID()}");
            Console.WriteLine("hello");
            Console.WriteLine("hello2");


        }
        public static List<Participant> Participants;
        // 2. Add this method (you’ll need `using System.Data.SqlClient;` at top)
        public static void InitParticipants()
        {
            var cmd = new SqlCommand("EXECUTE dbo.Get_all_Participants");
            var sc = new SQL_CON();
            SqlDataReader rdr = sc.execute_query(cmd);

            Participants = new List<Participant>();

            while (rdr.Read())
            {
                var gender = (GenderLookup)Enum.Parse(typeof(GenderLookup), rdr.GetValue(4).ToString());
                var ageGroup = (AgeGroupLookup)Enum.Parse(typeof(AgeGroupLookup), rdr.GetValue(7).ToString());

                Participants.Add(new Participant(
                    rdr.GetValue(0).ToString(),   // participantID
                    rdr.GetValue(1).ToString(),   // firstName
                    rdr.GetValue(2).ToString(),   // lastName
                    rdr.GetDateTime(3),           // birthDate
                    gender,                       // gender
                    rdr.GetDateTime(9),           // joinDate
                    ageGroup,                     // ageGroup
                    rdr.GetBoolean(8),            // paymentStatus
                    rdr.IsDBNull(5) ? null : rdr.GetValue(5).ToString(),  // address
                    rdr.GetValue(6).ToString(),                            // school
                    rdr.IsDBNull(10) ? null : rdr.GetValue(10).ToString(), // emergencyContact
                    rdr.IsDBNull(11) ? null : rdr.GetValue(11).ToString(), // medicalNotes
                    false                         // isNew
                ));
            }

            rdr.Close();
        }
    }
}


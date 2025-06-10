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
        [STAThread]
        static void Main()
        {
            InitMembers();

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


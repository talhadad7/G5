using G5.Forms;
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
        public static System.Collections.Generic.List<TrainingContent> TrainingContents;
        public static List<Area> Areas = new List<Area>();
        public static List<Announcement> Announcements = new List<Announcement>();
        public static System.Collections.Generic.List<Tag> Tags;
        public static Member CurrentUser { get; set; }


        /// <summary>
        /// Which MemberTypeLookup values are considered coordinators
        /// </summary>
        public static readonly MemberTypeLookup[] CoordinatorTypes = new[]
        {
             MemberTypeLookup.InstructorCoordinator,
             MemberTypeLookup.TechnicalCoordinator,
             MemberTypeLookup.BranchCoordinator
        };


        public static void InitTags()
        {
            var cmd = new System.Data.SqlClient.SqlCommand("SELECT tagType FROM Tags");
            SQL_CON sc = new SQL_CON();
            var rdr = sc.execute_query(cmd);

            Program.Tags = new List<Tag>();

            while (rdr.Read())
            {
                Tag t = new Tag(rdr.GetString(0));
                Program.Tags.Add(t);
            }

            rdr.Close();
            cmd.Connection?.Close();
        }
        public static void InitMembers()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_Members";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            Program.Members = new List<Member>();

            while (rdr.Read())
            {
                // המרת מחרוזות לערכי enum
                MemberTypeLookup mType = (MemberTypeLookup)Enum.Parse(typeof(MemberTypeLookup), rdr["memberTypeName"].ToString());
                GenderLookup gender = (GenderLookup)Enum.Parse(typeof(GenderLookup), rdr["genderName"].ToString());

                // שדות אופציונליים
                string address = rdr["address"] != DBNull.Value ? rdr["address"].ToString() : null;
                string emergencyContact = rdr["emergencyContact"] != DBNull.Value ? rdr["emergencyContact"].ToString() : null;
                bool paymentStatus = rdr["paymentStatus"] != DBNull.Value && (bool)rdr["paymentStatus"];

                TrainingStatusLookup trainingStatus = rdr["trainingStatusName"] != DBNull.Value
                    ? (TrainingStatusLookup)Enum.Parse(typeof(TrainingStatusLookup), rdr["trainingStatusName"].ToString())
                    : TrainingStatusLookup.FirstInterview;

                // שדות חדשים (NOT NULL)
                string phoneNumber = rdr["phoneNumber"].ToString();
                string emailAddress = rdr["emailAddress"].ToString();

                // יצירת מופע Member
                Member m = new Member(
                    rdr["memberID"].ToString(),
                    rdr["firstName"].ToString(),
                    rdr["lastName"].ToString(),
                    mType,
                    (DateTime)rdr["birthDate"],
                    gender,
                    (DateTime)rdr["joinDate"],
                    Convert.ToInt32(rdr["seniority"]),
                    phoneNumber,
                    emailAddress,
                    isNew: false,
                    address,
                    emergencyContact,
                    paymentStatus,
                    trainingStatus
                );

                Program.Members.Add(m);
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
                AgeGroupLookup ageGroup = (AgeGroupLookup)Enum.Parse(typeof(AgeGroupLookup), rdr.GetValue(7).ToString());


                // שדות אופציונליים
                string address = rdr.IsDBNull(5) ? null : rdr.GetValue(5).ToString();
                string school = rdr.IsDBNull(6) ? null : rdr.GetValue(6).ToString();
                string emergencyContact = rdr.IsDBNull(9) ? null : rdr.GetValue(9).ToString();
                string medicalNotes = rdr.IsDBNull(10) ? null : rdr.GetValue(10).ToString();
                bool paymentStatus = rdr.IsDBNull(8) ? false : rdr.GetBoolean(8);
                int birthDateIdx = rdr.GetOrdinal("birthDate");
                int joinDateIdx = rdr.GetOrdinal("joinDate");

                // 2. בדיקת DBNull ואז קריאה בטוחה
                DateTime birthDate = rdr.IsDBNull(birthDateIdx)
                    ? default(DateTime)
                    : rdr.GetDateTime(birthDateIdx);

                DateTime joinDate = rdr.IsDBNull(joinDateIdx)
                    ? default(DateTime)
                    : rdr.GetDateTime(joinDateIdx);
                // יצירת מופע Participant
                Participant p = new Participant(
        rdr.GetValue(0).ToString(),    // participantID
        rdr.GetValue(1).ToString(),    // firstName
        rdr.GetValue(2).ToString(),    // lastName
        birthDate,                     // birthDate
        genderName,                    // genderName
        joinDate,                      // joinDate
        ageGroup,                      // ageGroupName
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
            SqlCommand c = new SqlCommand("EXECUTE dbo.Get_all_Activity");
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            Program.Activities = new List<Activity>();

            while (rdr.Read())
            {
                string activityID = rdr.GetValue(0).ToString();
                DateTime creationDate = (DateTime)rdr.GetValue(1);
                string title = rdr.GetValue(2).ToString();
                string content = rdr.GetValue(3).ToString();

                // totalRank יכול להיות NULL, נשתמש ב־Nullable
                double? totalRank = rdr.IsDBNull(4) ? (double?)null : Convert.ToDouble(rdr.GetValue(4));
                string writerID = rdr.GetValue(5).ToString();

                Activity a = new Activity(activityID, creationDate, title, content,  writerID, totalRank);
                Program.Activities.Add(a);
            }

            rdr.Close();
            c.Connection?.Close();
        }

        public static void InitTrainingContent()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_TrainingContent";  // ודאי שפרוצדורה כזו קיימת
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            TrainingContents = new List<TrainingContent>();

            while (rdr.Read())
            {
                // המרת הטקסט לערך enum לפי הטבלה MemberTypeLookup
                MemberTypeLookup targetAudience = (MemberTypeLookup)Enum.Parse(
                    typeof(MemberTypeLookup),
                    rdr.GetValue(2).ToString()
                );

                // יצירת מופע TrainingContent
                TrainingContent tc = new TrainingContent(
                    rdr.GetValue(0).ToString(),       // handoverID
                    rdr.GetValue(1).ToString(),       // title
                    targetAudience,                   // targetAudience (enum)
                    rdr.GetDateTime(3),               // creationDate
                    rdr.GetValue(4).ToString(),       // content
                    false                             // isNew = false
                );

                TrainingContents.Add(tc);
            }

            rdr.Close();
        }

        public static void InitAreas()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_Areas";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            Areas = new List<Area>();

            while (rdr.Read())
            {
                int size = rdr.IsDBNull(2) ? 0 : Convert.ToInt32(rdr.GetValue(2));
                bool isAvailable = rdr.IsDBNull(3) ? true : (bool)rdr.GetValue(3);

                Area a = new Area(
                    rdr.GetValue(0).ToString(),
                    rdr.GetValue(1).ToString(),
                    size,
                    isAvailable
                );

                Areas.Add(a);
            }

            rdr.Close();
            c.Connection?.Close();  // מומלץ
        }

        public static void InitAnnouncements()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_Announcements";  // ודאי שה-SP קיים
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            Announcements = new List<Announcement>();

            while (rdr.Read())
            {
                string messageID = rdr.GetValue(0).ToString();
                string title = rdr.GetValue(1).ToString();
                string content = rdr.GetValue(2).ToString();
                DateTime publishDate = rdr.GetDateTime(3);
                string audience = rdr.GetValue(4).ToString();
                string writerID = rdr.GetValue(5).ToString();

                // שליפת האובייקט Member לפי ה-ID
                Member writer = Program.Members.FirstOrDefault(m => m.GetID() == writerID);

                // יצירת מופע Announcement
                Announcement a = new Announcement(
                    messageID,
                    title,
                    content,
                    publishDate,
                    writer
                );

                Announcements.Add(a);
            }

            rdr.Close();
            c.Connection?.Close();  // סגירת connection אם נדרש
        }
        
        public static Member FindMemberInMemory(string id)
        {
            return Program.Members.FirstOrDefault(m => m.memberID == id);
        }
        
        public static bool DeleteMemberFromList(string id)
        {
            Member m = Members.FirstOrDefault(mem => mem.memberID == id);
            if (m != null)
            {
                Members.Remove(m);
                return true;
            }
            return false;
        }


        [STAThread]
        static void Main()
        {
            InitMembers();
            InitEventFiles();
            InitParticipants();
           InitActivities();
            InitTrainingContent();
            InitAreas();
            InitTags();
        
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            //Application.Run(new GetMemberByIDcs());
            //Application.Run(new DeleteMemberForm());
            //Application.Run(new NewMemberForm());
            // Application.Run(new UpdateMember());
            //Application.Run(new DeleteParticipant());     
            // Application.Run(new NewParticipantForm1());
            // Application.Run(new UpdateParticpant());
            //  Application.Run(new ViewParticipant());
            //   Application.Run(new CreateActivityForm());
            Application.Run(new LogInForm()); // ⬅️ טופס ההתחברות
            // Application.Run(new CreateActivityForm());
            //Application.Run(new NewAnnouncementForm());
            //Application.Run(new ViewActivity());

            Application.Run(new DeleteMemberNew());

            // Application.Run(new ViewActivity());
            Application.Run(new NewProposal());



        }
    }
}


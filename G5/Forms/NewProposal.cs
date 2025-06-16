using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G5
{
    public partial class NewProposal : Form
    {
        private DateTime defaultValidDate;

        private void LoadGroups(string memberID)
        {
            SqlCommand cmd = new SqlCommand(
                "SELECT groupName FROM dbo.MemberGroups WHERE memberID = @id AND groupYear = @year");
            cmd.Parameters.AddWithValue("@id", memberID);
            cmd.Parameters.AddWithValue("@year", DateTime.Now.Year);

            SQL_CON con = new SQL_CON();
            SqlDataReader rdr = con.execute_query(cmd);

            while (rdr.Read())
            {
                GroupComboBox.Items.Add(rdr["groupName"].ToString());
            }

            rdr.Close();
        }


        private void LoadActivities()
        {
            SqlCommand cmd = new SqlCommand("SELECT activityID, title FROM dbo.Activity");

            SQL_CON con = new SQL_CON();
            SqlDataReader rdr = con.execute_query(cmd);

            Dictionary<string, string> activities = new Dictionary<string, string>();

            while (rdr.Read())
            {
                string id = rdr["activityID"].ToString();
                string name = rdr["title"].ToString();
                activities.Add(id, name);
                ActivityComboBox.Items.Add(name);
            }

            rdr.Close();

            // שמירת המילון בתוך Tag
            ActivityComboBox.Tag = activities;
        }
        private void LoadAreas()
        {
            SqlCommand cmd = new SqlCommand("SELECT areaID, areaName FROM dbo.Areas");

            SQL_CON con = new SQL_CON();
            SqlDataReader rdr = con.execute_query(cmd);

            Dictionary<string, string> areas = new Dictionary<string, string>();

            while (rdr.Read())
            {
                string id = rdr["areaID"].ToString();
                string name = rdr["areaName"].ToString();
                areas.Add(id, name);
                AreaComboBox.Items.Add(name);
            }

            rdr.Close();

            // שמירת המילון בתוך Tag
            AreaComboBox.Tag = areas;
            AreaComboBox.Items.Insert(0, "--- ללא אזור ---");
            AreaComboBox.SelectedIndex = 0;
        }
        private void NewProposal_Load(object sender, EventArgs e)
        {
            LoadGroups(Program.CurrentUser.memberID);
            LoadActivities();
            LoadAreas();
            ActivityDatePick.MinDate = DateTime.Today;
            ActivityDatePick.MaxDate = DateTime.Today.AddDays(7);
            defaultValidDate = DateTime.Today;
            while (defaultValidDate <= DateTime.Today.AddDays(7) &&
                   defaultValidDate.DayOfWeek != DayOfWeek.Tuesday &&
                   defaultValidDate.DayOfWeek != DayOfWeek.Thursday)
            {
                defaultValidDate = defaultValidDate.AddDays(1);
            }

            ActivityDatePick.Value = defaultValidDate;

            ActivityDatePick.ValueChanged += ActivityDatePick_ValueChanged;

        }
        public NewProposal()
        {
            InitializeComponent();
            this.Load += new EventHandler(NewProposal_Load);
        }

        private void SendProposalButton_Click(object sender, EventArgs e)
        {
            // בדיקה שהמשתמש בחר את כל השדות הנדרשים
            if (GroupComboBox.SelectedItem == null ||
      ActivityComboBox.SelectedItem == null)
            {
                MessageBox.Show("אנא בחר קבוצה ופעילות לפני שליחה.", "חסר מידע", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // קבוצה
            string selectedGroupName = GroupComboBox.SelectedItem.ToString();
            int currentYear = DateTime.Now.Year;
            Group group = new Group(selectedGroupName, currentYear);

            // שליפת activityID לפי שם
            string selectedActivityName = ActivityComboBox.SelectedItem.ToString();
            string activityID = ((Dictionary<string, string>)ActivityComboBox.Tag)
                .FirstOrDefault(x => x.Value == selectedActivityName).Key;

            // שליפת areaID לפי שם
            string areaID = null;
            if (AreaComboBox.SelectedItem != null)
            {
                string selectedAreaName = AreaComboBox.SelectedItem.ToString();
                areaID = ((Dictionary<string, string>)AreaComboBox.Tag)
                    .FirstOrDefault(x => x.Value == selectedAreaName).Key;
            }
            // תאריך פעילות
            DateTime activityDate = ActivityDatePick.Value;
            activityDate = activityDate.Date;

            // יצירת ActivityDay אם לא קיים עבור התאריך
            SqlCommand checkActivityDayCmd = new SqlCommand(
                "SELECT 1 FROM dbo.ActivityDay WHERE activityDate = @activityDate");
            checkActivityDayCmd.Parameters.AddWithValue("@activityDate", activityDate);

            SQL_CON conCheck = new SQL_CON();
            SqlDataReader rdrCheck = conCheck.execute_query(checkActivityDayCmd);

            bool activityDayExists = rdrCheck.Read();
            rdrCheck.Close();

            if (!activityDayExists)
            {
                SqlCommand insertActivityDayCmd = new SqlCommand(
                    "INSERT INTO dbo.ActivityDay (activityDate) VALUES (@activityDate)");
                insertActivityDayCmd.Parameters.AddWithValue("@activityDate", activityDate);

                SQL_CON conInsert = new SQL_CON();
                conInsert.execute_non_query(insertActivityDayCmd);
            }

            // לא ניתן לבחור תאריך עבר
            if (activityDate < DateTime.Today)
            {
                MessageBox.Show("לא ניתן לבחור תאריך שכבר עבר.", "תאריך לא חוקי", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // לא ניתן לבחור תאריך יותר משבוע קדימה
            if (activityDate > DateTime.Today.AddDays(7))
            {
                MessageBox.Show("לא ניתן להציע פעילות לתאריך שהוא מעבר לשבוע מהיום.", "תאריך לא חוקי", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!string.IsNullOrEmpty(areaID))
            {
                SqlCommand checkCmd = new SqlCommand(
                    "SELECT 1 FROM dbo.AreaActivityDay WHERE areaID = @areaID AND activityDate = @activityDate");

                checkCmd.Parameters.AddWithValue("@areaID", areaID);
                checkCmd.Parameters.AddWithValue("@activityDate", activityDate);

                SQL_CON con = new SQL_CON();
                SqlDataReader rdr = con.execute_query(checkCmd);

                if (rdr.Read()) // אם יש לפחות תוצאה אחת – האזור תפוס
                {
                    MessageBox.Show("האזור שבחרת כבר תפוס בתאריך הזה. נא לבחור אזור אחר או תאריך אחר.",
                                    "אזור תפוס", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    rdr.Close(); // לסגור את הקורא
                    return;
                }

                rdr.Close(); // אם לא תפוס – לסגור בכל מקרה
            }

            // הערות מדריך
            string senderComments = NotesTxtBox.Text;

            // יצירת מזהה ייחודי באורך 20
            string proposalID = Guid.NewGuid().ToString("N").Substring(0, 20);

            // יצירת האובייקט Proposal
            Proposal proposal = new Proposal(
                proposalID,
                senderComments,
                numOfParticipants: null,
                approvalStatus: null,
                coordinatorComments: null,
                activityID,
                areaID,
                activityDate,
                group
            );
            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO dbo.Proposal " +
                    "(proposalID, senderComments, numOfParticipants, approvalStatus, coordinatorComments, activityID, areaID, activityDate, groupName, groupYear) " +
                    "VALUES (@proposalID, @senderComments, @numOfParticipants, @approvalStatus, @coordinatorComments, @activityID, @areaID, @activityDate, @groupName, @groupYear)");

                cmd.Parameters.AddWithValue("@proposalID", proposal.proposalID);
                cmd.Parameters.AddWithValue("@senderComments", (object)proposal.senderComments ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@numOfParticipants", (object)proposal.numOfParticipants ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@approvalStatus", (object)proposal.approvalStatus ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@coordinatorComments", (object)proposal.coordinatorComments ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@activityID", proposal.activityID);
                cmd.Parameters.AddWithValue("@areaID", string.IsNullOrEmpty(proposal.areaID) ? (object)DBNull.Value : proposal.areaID);
                cmd.Parameters.AddWithValue("@activityDate", proposal.activityDate);
                cmd.Parameters.AddWithValue("@groupName", proposal.group.groupName);
                cmd.Parameters.AddWithValue("@groupYear", proposal.group.groupYear);

                SQL_CON con = new SQL_CON();
                con.execute_non_query(cmd); // פונקציה שמריצה שאילתה ללא תוצאה (INSERT, UPDATE, DELETE)
                if (!string.IsNullOrEmpty(proposal.areaID))
                {
                    SqlCommand insertAreaDay = new SqlCommand(
                        "INSERT INTO dbo.AreaActivityDay (activityDate, areaID) VALUES (@date, @areaID)");

                    insertAreaDay.Parameters.AddWithValue("@date", proposal.activityDate);
                    insertAreaDay.Parameters.AddWithValue("@areaID", proposal.areaID);

                    SQL_CON conInsert = new SQL_CON();
                    conInsert.execute_non_query(insertAreaDay);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("אירעה שגיאה בשמירת ההצעה:\n" + ex.Message, "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // לא נסגור את הטופס במקרה של שגיאה
            }

            // הודעה למשתמש
            MessageBox.Show("ההצעה נוצרה בהצלחה:\n\n" + proposal.ToString(), "נשלח", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();

            // TODO: שמירה למסד נתונים תוכל להתבצע כאן בהמשך
        }


        private void CancelButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                "האם אתה בטוח שברצונך לבטל את יצירת ההצעה?",
                "אישור ביטול",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void ActivityDatePick_ValueChanged(object sender, EventArgs e)
        {
            DateTime selected = ActivityDatePick.Value.Date;

            if (selected.DayOfWeek != DayOfWeek.Tuesday && selected.DayOfWeek != DayOfWeek.Thursday)
            {
                MessageBox.Show("אפשר לבחור רק ימי שלישי או חמישי.", "תאריך לא חוקי", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // חזרה לתאריך ברירת מחדל חוקי שנשמר מראש
                ActivityDatePick.Value = defaultValidDate;
            }
        }
    }
}

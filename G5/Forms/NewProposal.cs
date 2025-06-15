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
        }
        private void NewProposal_Load(object sender, EventArgs e)
        {
            LoadGroups(Program.CurrentUser.memberID);
            LoadActivities();
            LoadAreas();
            ActivityDatePick.MinDate = DateTime.Today;
            ActivityDatePick.MaxDate = DateTime.Today.AddDays(7);
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
                ActivityComboBox.SelectedItem == null ||
                AreaComboBox.SelectedItem == null)
            {
                MessageBox.Show("אנא בחר קבוצה, פעילות ואזור לפני שליחה.", "חסר מידע", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            string selectedAreaName = AreaComboBox.SelectedItem.ToString();
            string areaID = ((Dictionary<string, string>)AreaComboBox.Tag)
                .FirstOrDefault(x => x.Value == selectedAreaName).Key;

            // תאריך פעילות
            DateTime activityDate = ActivityDatePick.Value;
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
                cmd.Parameters.AddWithValue("@areaID", proposal.areaID);
                cmd.Parameters.AddWithValue("@activityDate", proposal.activityDate);
                cmd.Parameters.AddWithValue("@groupName", proposal.group.groupName);
                cmd.Parameters.AddWithValue("@groupYear", proposal.group.groupYear);

                SQL_CON con = new SQL_CON();
                con.execute_non_query(cmd); // פונקציה שמריצה שאילתה ללא תוצאה (INSERT, UPDATE, DELETE)
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
    }
}

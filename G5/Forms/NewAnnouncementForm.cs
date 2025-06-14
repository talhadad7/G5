// NewAnnouncementForm.cs - יצירת הודעה חדשה עם קהל יעד
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace G5
{
    public partial class NewAnnouncementForm : Form
    {
        public NewAnnouncementForm()
        {
            InitializeComponent();
            AudienceCheckList.DataSource = Enum.GetValues(typeof(MemberTypeLookup));
        }

        private void PublishButton_Click(object sender, EventArgs e)
        {
            string title = TitleTextBox.Text.Trim();
            string content = ContentTextBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(content))
            {
                MessageBox.Show("יש למלא כותרת ותוכן.", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<MemberTypeLookup> selectedAudiences = AudienceCheckList.CheckedItems.Cast<MemberTypeLookup>().ToList();

            if (selectedAudiences.Count == 0)
            {
                MessageBox.Show("יש לבחור לפחות קהל יעד אחד.", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string id = Guid.NewGuid().ToString();
                DateTime now = DateTime.Now;
                string writerID = Program.CurrentUser.memberID;

                // הכנסה לטבלת ההודעות
                SqlCommand cmd = new SqlCommand("INSERT INTO dbo.Announcement (messageID, title, content, publishDate, writerID) VALUES (@id, @title, @content, @date, @writerID)");
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@title", title);
                cmd.Parameters.AddWithValue("@content", content);
                cmd.Parameters.AddWithValue("@date", now);
                cmd.Parameters.AddWithValue("@writerID", writerID);
                new SQL_CON().execute_non_query(cmd);

                // הכנסת קהלי יעד לטבלה המקשרת
                foreach (var audience in selectedAudiences)
                {
                    SqlCommand audienceCmd = new SqlCommand("dbo.InsertAnnouncementAudience")
                    {
                        CommandType = System.Data.CommandType.StoredProcedure
                    };
                    audienceCmd.Parameters.AddWithValue("@messageID", id);
                    audienceCmd.Parameters.AddWithValue("@memberTypeName", audience.ToString());

                    new SQL_CON().execute_non_query(audienceCmd);
                }

                MessageBox.Show("ההודעה פורסמה בהצלחה!", "הצלחה", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"שגיאה בפרסום ההודעה: {ex.Message}", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PublishButton_Click_1(object sender, EventArgs e)
        {
            string title = TitleTextBox.Text.Trim();
            string content = ContentTextBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(content))
            {
                MessageBox.Show("יש למלא כותרת ותוכן.", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<MemberTypeLookup> selectedAudiences = AudienceCheckList.CheckedItems.Cast<MemberTypeLookup>().ToList();

            if (selectedAudiences.Count == 0)
            {
                MessageBox.Show("יש לבחור לפחות קהל יעד אחד.", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string id = Guid.NewGuid().ToString();
                DateTime now = DateTime.Now;
                string writerID = Program.CurrentUser.memberID;

                // שלב 1: הכנסה לטבלת ההודעות
                SqlCommand cmd = new SqlCommand("INSERT INTO dbo.Announcement (messageID, title, content, publishDate, writerID) " +
                                                "VALUES (@id, @title, @content, @date, @writerID)");
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@title", title);
                cmd.Parameters.AddWithValue("@content", content);
                cmd.Parameters.AddWithValue("@date", now);
                cmd.Parameters.AddWithValue("@writerID", writerID);
                new SQL_CON().execute_non_query(cmd);

                // שלב 2: הכנסת קהלי יעד לטבלה המקשרת
                foreach (var audience in selectedAudiences)
                {
                    SqlCommand audienceCmd = new SqlCommand("dbo.InsertAnnouncementAudience")
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    audienceCmd.Parameters.AddWithValue("@messageID", id);
                    audienceCmd.Parameters.AddWithValue("@memberType", audience.ToString());

                    new SQL_CON().execute_non_query(audienceCmd);
                }

                MessageBox.Show("ההודעה פורסמה בהצלחה!", "הצלחה", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"שגיאה בפרסום ההודעה:\n{ex.Message}", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CancelButton_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}

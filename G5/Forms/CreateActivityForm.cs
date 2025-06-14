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
    public partial class CreateActivityForm : Form
    {
        public CreateActivityForm()
        {
            InitializeComponent();
            Program.InitTags();
            Program.InitAreas();
          //  MessageBox.Show($"תגיות: {Program.Tags.Count}, אזורים: {Program.Areas.Count}");

            // מילוי רשימות CheckBox מתוך הנתונים הקיימים
            TagCheckList.Items.AddRange(Program.Tags.Select(t => t.tagType).ToArray());
            AreaCheckList.Items.AddRange(Program.Areas.Select(a => a.AreaName).ToArray());
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            string title = TitleTxtBox.Text.Trim();
            string content = ContentTxtBox.Text.Trim();


        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click_1(object sender, EventArgs e)
        {
            string title = TitleTxtBox.Text.Trim();
            string content = ContentTxtBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(content))
            {
                MessageBox.Show("יש למלא את כל השדות הנדרשים.", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<string> selectedTags = TagCheckList.CheckedItems.Cast<string>().ToList();
            List<string> selectedAreas = AreaCheckList.CheckedItems.Cast<string>().ToList();

            try
            {
                // יצירת מזהה חדש לפעילות
                string id = Guid.NewGuid().ToString();

                // יצירת פעילות חדשה
                Activity a = new Activity(
                    id,
                    DateTime.Today,
                    title,
                    content,
                    Program.CurrentUser.memberID, // ודא שזה קיים
                    0.0, // דירוג התחלתי
                    isNew: true
                );

                // שמירת תגיות בפועל
                foreach (string tag in selectedTags)
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO TagsForActivities (activityID, tagType) VALUES (@activityID, @tagType)");
                    cmd.Parameters.AddWithValue("@activityID", id);
                    cmd.Parameters.AddWithValue("@tagType", tag);

                    SQL_CON sc = new SQL_CON();
                    sc.execute_non_query(cmd);
                }

                // שמירת אזורים בפועל
                foreach (string area in selectedAreas)
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO AreasForActivities (activityID, areaName) VALUES (@activityID, @areaName)");
                    cmd.Parameters.AddWithValue("@activityID", id);
                    cmd.Parameters.AddWithValue("@areaName", area);

                    SQL_CON sc = new SQL_CON();
                    sc.execute_non_query(cmd);
                }
                MessageBox.Show("הפעולה נוצרה בהצלחה!", "הצלחה", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"שגיאה: {ex.Message}", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CancelButton_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}

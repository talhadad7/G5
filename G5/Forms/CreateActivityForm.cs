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
            TagCheckList.DataSource = Program.Tags;
            TagCheckList.DisplayMember = "tagType";
            TagCheckList.ValueMember = "tagType";
            AreaCheckList.DataSource = Program.Areas;
            AreaCheckList.DisplayMember = "areaName"; // מה יוצג למשתמש
            AreaCheckList.ValueMember = "areaID";    // מה נשמר ברקע        }
        }
        

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

            List<string> selectedTags = TagCheckList.CheckedItems.Cast<Tag>().Select(t => t.tagType).ToList();
            List<string> selectedAreas = AreaCheckList.CheckedItems.Cast<Area>().Select(a => a.AreaID).ToList();

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
                    SqlCommand cmd = new SqlCommand("InsertTagForActivity")
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.AddWithValue("@activityID", id);
                    cmd.Parameters.AddWithValue("@tagType", tag);

                    SQL_CON sc = new SQL_CON();
                    sc.execute_non_query(cmd);
                }

                // שמירת אזורים בפועל
                foreach (Area area in AreaCheckList.CheckedItems)
                {
                    SqlCommand cmd = new SqlCommand("InsertAreaForActivity")
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.AddWithValue("@activityID", id);
                    cmd.Parameters.AddWithValue("@areaID", area.AreaID); // שימוש ב-ID מתוך האובייקט Area

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

        private void CreateActivityForm_Load(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace G5
{
    public partial class DeleteActivity : Form
    {
        public DeleteActivity()
        {
            InitializeComponent();
            //MessageBox.Show($"מספר פעולות טעונות: {Program.Activities?.Count}");


            // Placeholder לשדה החיפוש
            txtSearchActivityTitle.Text = "הכנס שם פעולה";
            txtSearchActivityTitle.ForeColor = Color.Gray;
            txtSearchActivityTitle.Enter += txtSearchActivityTitle_Enter;
            txtSearchActivityTitle.Leave += txtSearchActivityTitle_Leave;
        }

        // חיפוש לפי שם פעולה מתוך Program.Activities
        private void SearchActivities()
        {
            string title = txtSearchActivityTitle.Text.Trim();

            var results = Program.Activities
                .Where(a => a.title.IndexOf(title, StringComparison.OrdinalIgnoreCase) >= 0)
                .ToList();

            if (results.Count == 0)
            {
                MessageBox.Show("לא נמצאו פעולות עם השם הזה.", "אין תוצאות", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ActivityListViewForDelete.DataSource = null;
                return;
            }

            // ניקוי קודם
            ActivityListViewForDelete.Columns.Clear();
            ActivityListViewForDelete.Rows.Clear();

            // יצירת עמודות
            ActivityListViewForDelete.Columns.Add("activityID", "ID פעולה");
            ActivityListViewForDelete.Columns.Add("title", "כותרת");
            ActivityListViewForDelete.Columns.Add("content", "תוכן");
            ActivityListViewForDelete.Columns.Add("creationDate", "תאריך יצירה");
            ActivityListViewForDelete.Columns.Add("totalRank", "ציון כולל");
            ActivityListViewForDelete.Columns.Add("writerID", "מזהה כותב");

            // הוספת שורות עם אובייקט activity כ־Tag
            foreach (var a in results)
            {
                int rowIndex = ActivityListViewForDelete.Rows.Add(
                    a.GetID(),
                    a.title,
                    a.content,
                    a.creationDate.ToShortDateString(),
                    a.totalRank?.ToString() ?? "ללא",
                    a.writerID
                );

                ActivityListViewForDelete.Rows[rowIndex].Tag = a;
            }

            ActivityListViewForDelete.ReadOnly = true;
            ActivityListViewForDelete.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ActivityListViewForDelete.MultiSelect = false;
            ActivityListViewForDelete.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }




        // כפתור חיפוש
        private void btnActivitySearch_Click(object sender, EventArgs e)
        {
            SearchActivities();
        }

        // כפתור מחיקה
        private void btnDeleteActivity_Click(object sender, EventArgs e)
        {
            if (ActivityListViewForDelete.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = ActivityListViewForDelete.SelectedRows[0];
                Activity act = selectedRow.Tag as Activity;

                if (act != null)
                {
                    DialogResult confirm = MessageBox.Show(
                        "האם את בטוחה שברצונך למחוק את הפעולה?",
                        "אישור מחיקה",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                    if (confirm == DialogResult.Yes)
                    {
                        try
                        {
                            act.DeleteActivity();
                            MessageBox.Show("הפעולה נמחקה בהצלחה!");
                            SearchActivities(); // ריענון הרשימה
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("שגיאה במחיקה:\n" + ex.Message, "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("הפעולה לא אותרה ברשימת האובייקטים.", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("יש לבחור פעולה מהרשימה למחיקה.", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        // Placeholder - כניסה לשדה
        private void txtSearchActivityTitle_Enter(object sender, EventArgs e)
        {
            if (txtSearchActivityTitle.Text == "הכנס שם פעולה")
            {
                txtSearchActivityTitle.Text = "";
                txtSearchActivityTitle.ForeColor = Color.Black;
            }
        }

        // Placeholder - עזיבה של השדה
        private void txtSearchActivityTitle_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearchActivityTitle.Text))
            {
                txtSearchActivityTitle.Text = "הכנס שם פעולה";
                txtSearchActivityTitle.ForeColor = Color.Gray;
            }
        }
    }
}

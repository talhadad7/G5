using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace G5
{
    public partial class ViewActivity : Form
    {
        private Activity currentActivity;

        public ViewActivity()
        {
            InitializeComponent();
            cmbActivityResults.Enabled = false;

            // חיבור לאירועים
            btnSearchActivity.Click += btnSearchActivity_Click;
            cmbActivityResults.SelectedIndexChanged += cmbActivityResults_SelectedIndexChanged;
        }

        private void btnSearchActivity_Click(object sender, EventArgs e)
        {
            string title = txtSearchTitle.Text.Trim();

            if (string.IsNullOrEmpty(title))
            {
                MessageBox.Show("אנא הזן שם פעולה.", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var matchingActivities = Program.Activities
                .Where(a => a.title.Equals(title, StringComparison.OrdinalIgnoreCase))
                .ToList();

            if (matchingActivities.Count == 0)
            {
                MessageBox.Show("לא נמצאה פעולה עם השם הזה.", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (matchingActivities.Count == 1)
            {
                DisplayActivity(matchingActivities[0]);
                cmbActivityResults.Enabled = false;
            }
            else
            {
                cmbActivityResults.DataSource = matchingActivities;
                cmbActivityResults.DisplayMember = "activityID"; // שדה ייחודי, אפשר לשנות ל-title + ID יחד
                cmbActivityResults.ValueMember = "activityID";
                cmbActivityResults.Enabled = true;
            }
        }

        private void cmbActivityResults_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbActivityResults.SelectedItem is Activity selectedActivity)
            {
                DisplayActivity(selectedActivity);
            }
        }

        private void DisplayActivity(Activity a)
        {
            currentActivity = a;

            txtTitle.Text = a.title;
            txtContent.Text = a.content;
            txtWriterID.Text = a.writerID;
            txtTotalRank.Text = a.totalRank?.ToString("0.00") ?? "לא דורג";
            dptCreationDate.Value = a.creationDate;
        }
    }
}

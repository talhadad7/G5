using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
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

            SqlCommand cmd = new SqlCommand("dbo.GetActivitiesByTitle")
            {
                CommandType = System.Data.CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("@title", title);

            SQL_CON sc = new SQL_CON();
            SqlDataReader rdr = sc.execute_query(cmd);

            List<Activity> matchingActivities = new List<Activity>();

            while (rdr.Read())
            {
                string activityID = rdr["activityID"].ToString();
                DateTime creationDate = (DateTime)rdr["creationDate"];
                string foundTitle = rdr["title"].ToString();
                string content = rdr["content"].ToString();
                double? totalRank = rdr["totalRank"] != DBNull.Value ? Convert.ToDouble(rdr["totalRank"]) : (double?)null;
                string writerID = rdr["writerID"].ToString();

                matchingActivities.Add(new Activity(activityID, creationDate, foundTitle, content, writerID, totalRank));
            }

            rdr.Close();
            cmd.Connection?.Close();

            if (matchingActivities.Count == 0)
            {
                MessageBox.Show("לא נמצאה פעולה עם השם הזה.", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (matchingActivities.Count == 1)
            {
                DisplayActivity(matchingActivities[0]);
                cmbActivityResults.DataSource = null;
                cmbActivityResults.Enabled = false;
            }
            else
            {
                cmbActivityResults.DataSource = matchingActivities;
                cmbActivityResults.DisplayMember = "title";
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

using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace G5
{
    public partial class DeleteMemberNew : Form
    {
        public DeleteMemberNew()
        {
            InitializeComponent();

            // חיבור לאירועים
            txtEnterID.TextChanged += TxtEnterID_TextChanged;
            btnDeleteMember.Click += BtnDeleteMember_Click;

            dgvListOfMembers.ReadOnly = true;
            dgvListOfMembers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvListOfMembers.MultiSelect = false;
            dgvListOfMembers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void TxtEnterID_TextChanged(object sender, EventArgs e)
        {
            string partialID = txtEnterID.Text.Trim();
            if (string.IsNullOrEmpty(partialID))
            {
                dgvListOfMembers.DataSource = null;
                return;
            }

            SqlCommand cmd = new SqlCommand("dbo.Get_Members_By_Partial_ID")
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("@partialID", partialID);

            SQL_CON sc = new SQL_CON();
            SqlDataReader rdr = sc.execute_query(cmd);

            DataTable table = new DataTable();
            table.Load(rdr);
            rdr.Close();

            dgvListOfMembers.DataSource = table;

            if (table.Rows.Count == 0)
            {
                MessageBox.Show("לא נמצאו בוגרים עם התעודת זהות הזו.", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnDeleteMember_Click(object sender, EventArgs e)
        {
            if (dgvListOfMembers.SelectedRows.Count == 0)
            {
                MessageBox.Show("יש לבחור בוגר למחיקה מהרשימה.", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string memberID = dgvListOfMembers.SelectedRows[0].Cells["memberID"].Value.ToString();

            DialogResult result = MessageBox.Show(
                $"האם את בטוחה שברצונך למחוק את הבוגר עם ת\"ז {memberID}?",
                "אישור מחיקה",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand("dbo.DeleteMember")
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@memberID", memberID);

                SQL_CON sc = new SQL_CON();
                sc.execute_non_query(cmd);

                MessageBox.Show("הבוגר נמחק בהצלחה!", "הצלחה", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEnterID.Clear();
                dgvListOfMembers.DataSource = null;
            }
        }
    }
}

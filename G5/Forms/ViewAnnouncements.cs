using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using G5;


namespace G5.Forms
{
    public partial class ViewAnnouncements : Form
    {
        public ViewAnnouncements()
        {
            InitializeComponent();
        }


        private void ViewAnnouncements_Load(object sender, EventArgs e)
        {
            LoadAnnouncements();
        }

        /// <summary>
        /// Fetches from dbo.Announcement ⋈ dbo.AnnouncementAudience
        /// only the rows matching the logged-in user’s memberType,
        /// and binds them to the grid.
        /// </summary>
        private void LoadAnnouncements()
        {
            // 1) Convert enum → string
            string myType = Program.CurrentUser.memberTypeName.ToString();

            // 2) Build the SQL
            var cmd = new SqlCommand(@"
        SELECT 
            A.messageID, 
            A.title, 
            A.content, 
            A.publishDate
        FROM dbo.Announcement AS A
        INNER JOIN dbo.AnnouncementAudience AS AA
            ON A.messageID = AA.messageID
        WHERE AA.memberType = @memberType
        ORDER BY A.publishDate DESC
    ");
            cmd.Parameters.AddWithValue("@memberType", myType);

            // 3) Execute & bind
            var sc = new SQL_CON();
            using (SqlDataReader rdr = sc.execute_query(cmd))
            {
                var dt = new DataTable();
                dt.Load(rdr);
                dgvAnnouncements.DataSource = dt;
            }
        }

    }



}




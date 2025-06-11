using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G5
{
    public partial class GetMemberByIDcs : Form
    {
        public GetMemberByIDcs()
        {
            InitializeComponent();
        }

        private void GetMemberByIDcs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'g5DataSet.Members' table. You can move, or remove it, as needed.
            this.membersTableAdapter.Fill(this.g5DataSet.Members);
            // TODO: This line of code loads data into the 'g5DataSet.Participants' table. You can move, or remove it, as needed.
            this.participantsTableAdapter.Fill(this.g5DataSet.Participants);

        }

        private void IDInserted(object sender, EventArgs e)
        {

        }

        private void ButtonClicked(object sender, EventArgs e)
        {
            string id = MemberIDTXTBox.Text.Trim();
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("אנא הכנס ת\"ז תקין.", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // 2. קריאה לשיטה שמרימה את ה-Member מהמסד
                Member m = Member.GetMemberByID(id);

                // 3. בדיקה האם נמצא Member
                if (m != null)
                {
                    // 4. הצגת מידע כלשהו (כאן – השם המלא, טלפון ומייל)
                    MessageBox.Show(
                        $"שם: {m.firstName} {m.lastName}\n" +
                        $"טלפון: {m.phoneNumber}\n" +
                        $"אימייל: {m.emailAddress}",
                        "פרטי הבוגר",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
                else
                {
                    MessageBox.Show(
                        $"לא נמצאה רשומה עבור ת\"ז {id}.",
                        "לא נמצא",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation
                    );
                }
            }
            catch (Exception ex)
            {
                // 5. טיפול בשגיאות חיבור / SP / המרת נתונים
                MessageBox.Show(
                    $"אירעה שגיאה במהלך החיפוש:\n{ex.Message}",
                    "שגיאה",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void ShowParticipant_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

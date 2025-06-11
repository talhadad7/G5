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
        
            // מבטלים כל Fill אוטומטי
            dgvMembers.Rows.Clear();
        
        }

        private void IDInserted(object sender, EventArgs e)
        {

        }

        private void ButtonClicked(object sender, EventArgs e)
        {
            string id = MemberIDTXTBox.Text.Trim();
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("אנא הכנס ת\"ז תקין.", "שגיאה",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // 1. חיפוש מתוך הרשימה בזיכרון (בלי SQL!)
                Member m = Program.Members.FirstOrDefault(mem => mem.memberID == id);

                // 2. מנקים את הטבלה
                dgvMembers.Rows.Clear();

                if (m != null)
                {
                    // 3. מוסיפים שורה אחת עם כל השדות
                    dgvMembers.Rows.Add(
                        m.memberID,
                        m.firstName,
                        m.lastName,
                        m.memberTypeName.ToString(),
                        m.birthDate.ToShortDateString(),
                        m.genderName.ToString(),
                        m.joinDate.ToShortDateString(),
                        m.seniority,
                        m.phoneNumber,
                        m.emailAddress,
                            m.address,
    m.emergencyContact,
    m.paymentStatus,
    m.trainingStatusName.ToString()
                    );
                }
                else
                {
                    MessageBox.Show($"לא נמצאה רשומה עבור ת\"ז {id}.",
                                    "לא נמצא", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"אירעה שגיאה במהלך החיפוש:\n{ex.Message}",
                                "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void ShowParticipant_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvMembers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

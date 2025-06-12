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
    public partial class DeleteParticipant : Form
    {
        public DeleteParticipant()
        {
            InitializeComponent();

            // הגדרת placeholder כברירת מחדל
            IDTXTBox.Text = "הכנס ת\"ז";
            IDTXTBox.ForeColor = Color.Gray;

            // חיבור לאירועים (אם לא חיברת מה-Designer)
            IDTXTBox.Enter += IDTXTBox_Enter;
            IDTXTBox.Leave += IDTXTBox_Leave;
        }

        private void IDTXTBox_Enter(object sender, EventArgs e)
        {
            if (IDTXTBox.Text == "הכנס ת\"ז")
            {
                IDTXTBox.Text = "";
                IDTXTBox.ForeColor = Color.Black;
            }
        }

        private void IDTXTBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(IDTXTBox.Text))
            {
                IDTXTBox.Text = "הכנס ת\"ז";
                IDTXTBox.ForeColor = Color.Gray;
            }
        }

        private void IDTXTBox_TextChanged(object sender, EventArgs e)
        {
            // לא חייב לממש משהו כאן
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            string id = IDTXTBox.Text.Trim();

            if (string.IsNullOrEmpty(id) || id == "הכנס ת\"ז")
            {
                MessageBox.Show("אנא הזן תעודת זהות.", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Participant p = Program.Participants.FirstOrDefault(part => part.GetID() == id);

            if (p == null)
            {
                MessageBox.Show("משתתף לא נמצא.", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // ביצוע מחיקה
            try
            {
                p.DeleteParticipant();
                MessageBox.Show("המשתתף נמחק בהצלחה!", "מחיקה", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // סגור את הטופס אחרי מחיקה
            }
            catch (Exception ex)
            {
                MessageBox.Show($"אירעה שגיאה במחיקה: {ex.Message}", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

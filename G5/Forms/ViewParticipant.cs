// ViewParticipant.cs - תצוגת משתתף בלבד (ללא אפשרות עריכה)
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace G5
{
    public partial class ViewParticipant : Form
    {
        private Participant currentParticipant;

        public ViewParticipant()
        {
            InitializeComponent();

            GenderCombo.DataSource = Enum.GetValues(typeof(GenderLookup));
            AgeGroupCombo.DataSource = Enum.GetValues(typeof(AgeGroupLookup));

            // הפיכת כל השדות לקריאה בלבד
            FirstNameTxtBox.ReadOnly = true;
            LastNameTxtBox.ReadOnly = true;
            AddressTxtBox.ReadOnly = true;
            SchoolTxtBox.ReadOnly = true;
            EmergencyTxtBox.ReadOnly = true;
            MedicalNotesTxtBox.ReadOnly = true;

            GenderCombo.Enabled = false;
            AgeGroupCombo.Enabled = false;
            BirthDatePick.Enabled = false;
            JoinDatePick.Enabled = false;
            PaymentCheck.Enabled = false;

            IDtxtbox.Text = "הכנס ת\"ז";
            IDtxtbox.ForeColor = Color.Gray;
            IDtxtbox.Enter += IDtxtbox_Enter;
            IDtxtbox.Leave += IDtxtbox_Leave;
        }

        private void IDtxtbox_Enter(object sender, EventArgs e)
        {
            if (IDtxtbox.Text == "הכנס ת\"ז")
            {
                IDtxtbox.Text = "";
                IDtxtbox.ForeColor = Color.Black;
            }
        }

        private void IDtxtbox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(IDtxtbox.Text))
            {
                IDtxtbox.Text = "הכנס ת\"ז";
                IDtxtbox.ForeColor = Color.Gray;
            }
        }

     

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ViewParticipant_Load(object sender, EventArgs e)
        {
            // אפשר להשאיר ריק, או לשים כאן טעינה כלשהי
        }

        private void SearchButton_Click_1(object sender, EventArgs e)
        {
            string id = IDtxtbox.Text.Trim();
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("אנא הזן תעודת זהות.", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            currentParticipant = Program.Participants.FirstOrDefault(p => p.GetID() == id);
            if (currentParticipant == null)
            {
                MessageBox.Show("משתתף לא נמצא.", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FirstNameTxtBox.Text = currentParticipant.firstName;
            LastNameTxtBox.Text = currentParticipant.lastName;
            BirthDatePick.Value = currentParticipant.birthDate;
            GenderCombo.SelectedItem = currentParticipant.genderName;
            JoinDatePick.Value = currentParticipant.joinDate;
            AddressTxtBox.Text = currentParticipant.address;
            SchoolTxtBox.Text = currentParticipant.school; // נניח שזה טלפון
            EmergencyTxtBox.Text = currentParticipant.emergencyContact;
            AgeGroupCombo.SelectedItem = currentParticipant.ageGroupName;
            MedicalNotesTxtBox.Text = currentParticipant.medicalNotes;
            PaymentCheck.Checked = currentParticipant.paymentStatus;

        }
    }
}

using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace G5
{
    public partial class UpdateParticpant : Form
    {
        private Participant currentParticipant;

        public UpdateParticpant()
        {
            InitializeComponent();

            // הגדרת placeholder כברירת מחדל
            IDtxtbox.Text = "הכנס ת\"ז";
            IDtxtbox.ForeColor = Color.Gray;

            // חיבור לאירועים (אם לא חיברת דרך ה־Designer)
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


        private void UpdateParticpant_Load(object sender, EventArgs e)
        {
            GenderCombo.DataSource = Enum.GetValues(typeof(GenderLookup));
            AgeGroupCombo.DataSource = Enum.GetValues(typeof(AgeGroupLookup));
        }

        private void SearchButton_Click(object sender, EventArgs e)
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

            // מילוי השדות
            FirstNameTxtBox.Text = currentParticipant.firstName;
            LastNameTxtBox.Text = currentParticipant.lastName;
            BirthDatePick.Value = currentParticipant.birthDate;
            GenderCombo.SelectedItem = currentParticipant.genderName;
            JoinDatePick.Value = currentParticipant.joinDate;
            AddressTxtBox.Text = currentParticipant.address;
            PhoneTxtBox.Text = currentParticipant.school; // שדה טלפון
            EmergencyTxtBox.Text = currentParticipant.emergencyContact;
            AgeGroupCombo.SelectedItem = currentParticipant.ageGroupName;
            MedicalNotesTxtBox.Text = currentParticipant.medicalNotes;
            PaymentCheck.Checked = currentParticipant.paymentStatus;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (currentParticipant == null)
            {
                MessageBox.Show("יש לבצע חיפוש תחילה.", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                currentParticipant.firstName = FirstNameTxtBox.Text.Trim();
                currentParticipant.lastName = LastNameTxtBox.Text.Trim();
                currentParticipant.birthDate = BirthDatePick.Value.Date;
                currentParticipant.genderName = (GenderLookup)GenderCombo.SelectedItem;
                currentParticipant.joinDate = JoinDatePick.Value.Date;
                currentParticipant.address = string.IsNullOrWhiteSpace(AddressTxtBox.Text) ? null : AddressTxtBox.Text.Trim();
                currentParticipant.school = string.IsNullOrWhiteSpace(PhoneTxtBox.Text) ? null : PhoneTxtBox.Text.Trim();
                currentParticipant.emergencyContact = string.IsNullOrWhiteSpace(EmergencyTxtBox.Text) ? null : EmergencyTxtBox.Text.Trim();
                currentParticipant.ageGroupName = (AgeGroupLookup)AgeGroupCombo.SelectedItem;
                currentParticipant.medicalNotes = string.IsNullOrWhiteSpace(MedicalNotesTxtBox.Text) ? null : MedicalNotesTxtBox.Text.Trim();
                currentParticipant.paymentStatus = PaymentCheck.Checked;

                currentParticipant.UpdateParticipant();
                MessageBox.Show("המשתתף עודכן בהצלחה!", "הצלחה", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"שגיאה בעת עדכון: {ex.Message}", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void PaymentCheck_CheckedChanged(object sender, EventArgs e)
        {
            // אם אתה לא צריך לטפל בשינוי – אפשר להשאיר ריק
        }

        private void GenderCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // עדכון לפי מגדר נבחר
        }

        private void AgeGroupCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // עדכון לפי קבוצת גיל
        }

        private void IDtxtbox_TextChanged(object sender, EventArgs e)
        {
            // פעולה ברגע שת"ז משתנה (לרוב לא חובה)
        }

        private void FirstNameTxtBox_TextChanged(object sender, EventArgs e) { }

        private void LastNameTxtBox_TextChanged(object sender, EventArgs e) { }

        private void BirthDatePick_ValueChanged(object sender, EventArgs e) { }

        private void JoinDatePick_ValueChanged(object sender, EventArgs e) { }

        private void AddressTxtBox_TextChanged(object sender, EventArgs e) { }

        private void PhoneTxtBox_TextChanged(object sender, EventArgs e) { }

        private void EmergencyTxtBox_TextChanged(object sender, EventArgs e) { }

        private void MedicalNotesTxtBox_TextChanged(object sender, EventArgs e) { }

        private void searchButton_Click(object sender, EventArgs e)
        {
            // כאן תממש את החיפוש לפי ת"ז ומילוי השדות
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            // כאן תממש את השמירה וה־UpdateParticipant
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close(); // סגירת הטופס
        }

    

    }
}

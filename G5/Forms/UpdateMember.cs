// UpdateMember.cs - טופס עריכה
using System;
using System.Linq;
using System.Windows.Forms;

namespace G5
{
    public partial class UpdateMember : Form
    {
        private Member currentMember;

        public UpdateMember()
        {
            InitializeComponent();

            GenderCombo.DataSource = Enum.GetValues(typeof(GenderLookup));
            MemberTypeCombo.DataSource = Enum.GetValues(typeof(MemberTypeLookup));
            TrainingStatusCombo.DataSource = Enum.GetValues(typeof(TrainingStatusLookup));
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string id = IDTXTBox.Text.Trim();
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("יש להזין ת\"ז.", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            currentMember = Program.Members.FirstOrDefault(m => m.memberID == id);
            if (currentMember == null)
            {
                MessageBox.Show("הבוגר לא נמצא.", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // מילוי השדות בטופס
            FirstNameTXTBox.Text = currentMember.firstName;
            LastNameTXTBox.Text = currentMember.lastName;
            BirthDatePick.Value = currentMember.birthDate;
            GenderCombo.SelectedItem = currentMember.genderName;
            AddressTXTBox.Text = currentMember.address;
            PhoneTXTBox.Text = currentMember.phoneNumber;
            EmergencyTXTBox.Text = currentMember.emergencyContact;
            EmailTXTBox.Text = currentMember.emailAddress;
            JoinDatePick.Value = currentMember.joinDate;
            MemberTypeCombo.SelectedItem = currentMember.memberTypeName;
            TrainingStatusCombo.SelectedItem = currentMember.trainingStatusName;
            SeniorityNumeric.Value = currentMember.seniority;
            PaymentCheckBox.Checked = currentMember.paymentStatus;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (currentMember == null)
            {
                MessageBox.Show("יש לבצע חיפוש לפני שמירה.", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // עדכון האובייקט בזיכרון
                currentMember.firstName = FirstNameTXTBox.Text.Trim();
                currentMember.lastName = LastNameTXTBox.Text.Trim();
                currentMember.birthDate = BirthDatePick.Value.Date;
                currentMember.genderName = (GenderLookup)GenderCombo.SelectedItem;
                currentMember.address = string.IsNullOrWhiteSpace(AddressTXTBox.Text) ? null : AddressTXTBox.Text.Trim();
                currentMember.phoneNumber = PhoneTXTBox.Text.Trim();
                currentMember.emergencyContact = string.IsNullOrWhiteSpace(EmergencyTXTBox.Text) ? null : EmergencyTXTBox.Text.Trim();
                currentMember.emailAddress = EmailTXTBox.Text.Trim();
                currentMember.joinDate = JoinDatePick.Value.Date;
                currentMember.memberTypeName = (MemberTypeLookup)MemberTypeCombo.SelectedItem;
                currentMember.trainingStatusName = (TrainingStatusLookup)TrainingStatusCombo.SelectedItem;
                currentMember.seniority = (int)SeniorityNumeric.Value;
                currentMember.paymentStatus = PaymentCheckBox.Checked;

                currentMember.UpdateMember();
                MessageBox.Show("הבוגר עודכן בהצלחה!", "הצלחה", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"שגיאה בעדכון: {ex.Message}", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

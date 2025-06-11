using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G5.Forms
{
    public partial class NewParticiapant : Form
    {
        public NewParticiapant()
        {
            InitializeComponent();
            this.Load += NewParticiapant_Load;
        }

        private void NewParticiapant_Load(object sender, EventArgs e)
        {
            // Bind Gender dropdown to your enum
            ParticipantGenderCombo.DataSource = Enum.GetValues(typeof(GenderLookup));

            // Bind Age-Group dropdown to your enum
            AgeGroupCombo.DataSource = Enum.GetValues(typeof(AgeGroupLookup));
        }

        private void ParticipantId_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void ParticipantId_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ParticipantGenderCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void AgeGroupCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void PatricipantMedicalNotes_TextChanged(object sender, EventArgs e)
        {

        }

        private void CancelParticipantCreation_Click(object sender, EventArgs e)
        {

        }

        private void SaveParticipantCreation_Click(object sender, EventArgs e)
        {
            // 2.1 VALIDATION: now *all* fields except MedicalNotes must be non-empty
            if (string.IsNullOrWhiteSpace(ParticipantId.Text) ||
                string.IsNullOrWhiteSpace(ParticipantFirstName.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text) ||               // last name
                ParticipantGenderCombo.SelectedItem == null ||
                AgeGroupCombo.SelectedItem == null ||
                string.IsNullOrWhiteSpace(ParticipantAdress.Text) ||
                string.IsNullOrWhiteSpace(textBox1.Text) ||              // emergency contact
                string.IsNullOrWhiteSpace(ParticipantSchool.Text))   // ← your new school box
            {
                MessageBox.Show(
                    "אנא מלא/י את כל השדות (חוץ מהערות רפואיות).",
                    "שגיאת אימות",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            try
            {
                // 2.2 READ & NORMALIZE
                var id = ParticipantId.Text.Trim();
                var firstName = ParticipantFirstName.Text.Trim();
                var lastName = textBox3.Text.Trim();
                var birthDate = ParticipantBirthDate.Value.Date;
                var gender = (GenderLookup)ParticipantGenderCombo.SelectedItem;
                var joinDate = ParticipantJoinDATE.Value.Date;
                var ageGroup = (AgeGroupLookup)AgeGroupCombo.SelectedItem;
                var paymentStatus = ParticipantPaymentStatusCheckBox.Checked;
                var address = ParticipantAdress.Text.Trim();
                var emergencyContact = textBox1.Text.Trim();

                // **School** ← now comes from your new SchoolNameParticipant textbox
                var school = ParticipantSchool.Text.Trim();

                // 2.2.1 Medical notes still optional
                var medicalNotes = string.IsNullOrWhiteSpace(PatricipantMedicalNotes.Text)
                                        ? null
                                        : PatricipantMedicalNotes.Text.Trim();

                // 2.3 CREATE & PERSIST
                var newParticipant = new Participant(
                    id,
                    firstName,
                    lastName,
                    birthDate,
                    gender,
                    joinDate,
                    ageGroup,
                    paymentStatus,
                    address,
                    school,          // ← wired in
                    emergencyContact,
                    medicalNotes,
                    isNew: true
                );

                // 2.4 FEEDBACK & CLOSE
                MessageBox.Show(
                    "המשתתף נשמר בהצלחה!",
                    "הצלחה",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "אירעה שגיאה בשמירה: " + ex.Message,
                    "שגיאה",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    ///
                );
            }
        }

        private void NewParticiapant_Load(object sender, EventArgs e)
        {

        }

        private void NewParticiapant_Load_1(object sender, EventArgs e)
        {

        }
    }
}

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

        }

        private void NewParticiapant_Load(object sender, EventArgs e)
        {

        }
    }
}

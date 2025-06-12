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
    public partial class NewMemberForm : Form
    {
        public NewMemberForm()
        {
            InitializeComponent();
            GenderCombo.DataSource = Enum.GetValues(typeof(GenderLookup));
            MemberTypeCOMBOX.DataSource = Enum.GetValues(typeof(MemberTypeLookup));
            TrainingProccessCombox.DataSource = Enum.GetValues(typeof(TrainingStatusLookup));
        }
        private void label2_Click(object sender, EventArgs e) { }
        private void Form1_Load(object sender, EventArgs e) { }
        private void label10_Click(object sender, EventArgs e) { }
        private void label13_Click(object sender, EventArgs e) { }
        private void FirstNameTXT_TextChanged(object sender, EventArgs e) { }
        private void LastNameTXT_TextChanged(object sender, EventArgs e) { }
        private void IDTXT_TextChanged(object sender, EventArgs e) { }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) { }
        private void GenderCombo_SelectedIndexChanged(object sender, EventArgs e) { }
        private void AddressTXT_TextChanged(object sender, EventArgs e) { }
        private void PhoneTXT_TextChanged(object sender, EventArgs e) { }
        private void EmerConTXT_TextChanged(object sender, EventArgs e) { }
        private void checkBox1_CheckedChanged(object sender, EventArgs e) { }
        private void JoinDatePCK_ValueChanged(object sender, EventArgs e) { }
        private void MemberTypeCOMBOX_SelectedIndexChanged(object sender, EventArgs e) { }
        private void TrainingProccessCombox_SelectedIndexChanged(object sender, EventArgs e) { }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e) { }
        private void textBox6_TextChanged(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }

        private void ReturnFromCreateMember_Click(object sender, EventArgs e)
        {
            this.Close(); // סוגר את הטופס
        }

        private void CreateMemberButton_Click(object sender, EventArgs e)
        {
            // ולידציה בסיסית
            if (string.IsNullOrWhiteSpace(IDTXT.Text) ||
                string.IsNullOrWhiteSpace(FirstNameTXT.Text) ||
                string.IsNullOrWhiteSpace(LastNameTXT.Text) ||
                GenderCombo.SelectedItem == null ||
                MemberTypeCOMBOX.SelectedItem == null ||
                TrainingProccessCombox.SelectedItem == null ||
                string.IsNullOrWhiteSpace(PhoneTXT.Text) ||
                string.IsNullOrWhiteSpace(MailTXT.Text))
            {
                MessageBox.Show("אנא מלא/י את כל השדות החובה.", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var member = new Member(
                    id: IDTXT.Text.Trim(),
                    firstName: FirstNameTXT.Text.Trim(),
                    lastName: LastNameTXT.Text.Trim(),
                    memberTypeName: (MemberTypeLookup)MemberTypeCOMBOX.SelectedItem,
                    birthDate: BirthDatePicker.Value.Date,
                    genderName: (GenderLookup)GenderCombo.SelectedItem,
                    joinDate: JoinDatePCK.Value.Date,
                    seniority: (int)SeniorityNum.Value,
                    phoneNumber: PhoneTXT.Text.Trim(),
                    emailAddress: MailTXT.Text.Trim(),
                    isNew: true,
                    address: string.IsNullOrWhiteSpace(AddressTXT.Text) ? null : AddressTXT.Text.Trim(),
                    emergencyContact: string.IsNullOrWhiteSpace(EmerConTXT.Text) ? null : EmerConTXT.Text.Trim(),
                    paymentStatus: PaymentCheckBox.Checked,
                    trainingStatusName: (TrainingStatusLookup)TrainingProccessCombox.SelectedItem
                );

                MessageBox.Show("הבוגר נשמר בהצלחה!", "הצלחה", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"אירעה שגיאה:\n{ex.Message}", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      
    }
}

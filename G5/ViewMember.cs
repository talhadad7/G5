using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G5
{
    public partial class ViewMember : Form
    {
        public ViewMember()
        {
            InitializeComponent();
        }

        private void UpdateLabel_Click(object sender, EventArgs e)
        {

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string id = IDTXTBox.Text.Trim();

            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("אנא הזן תעודת זהות לחיפוש.", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SqlCommand cmd = new SqlCommand(
                @"SELECT 
        memberID,
        firstName,
        lastName,
        genderName,
        birthDate,
        address,
        phoneNumber,
        emailAddress,
        joinDate,
        emergencyContact,
        paymentStatus,
        trainingStatusName,
        memberTypeName,
        seniority
      FROM dbo.Members
      WHERE memberID = @memberID"
            );

            cmd.Parameters.AddWithValue("@memberID", id);

            SQL_CON sql = new SQL_CON();
            SqlDataReader reader = sql.execute_query(cmd);

            if (reader.Read())
            {
                FirstNameTXTBox.Text = reader["firstName"].ToString();
                LastNameTXTBox.Text = reader["lastName"].ToString();
                GenderCombo.SelectedItem = Enum.Parse(typeof(GenderLookup), reader["genderName"].ToString());
                MemberTypeCombo.SelectedItem = Enum.Parse(typeof(MemberTypeLookup), reader["memberTypeName"].ToString());
                TrainingStatusCombo.SelectedItem = Enum.Parse(typeof(TrainingStatusLookup), reader["trainingStatusName"].ToString());
                PhoneTXTBox.Text = reader["phoneNumber"].ToString();
                AddressTXTBox.Text = reader["address"].ToString();
                EmailTXTBox.Text = reader["emailAddress"].ToString();
                EmergencyTXTBox.Text = reader["emergencyContact"].ToString();
                PaymentCheckBox.Checked = Convert.ToBoolean(reader["paymentStatus"]);
                BirthDatePick.Value = (DateTime)reader["birthDate"];
                JoinDatePick.Value = (DateTime)reader["joinDate"];
                SeniorityNumeric.Value = Convert.ToInt32(reader["seniority"]);

             //   SetReadOnlyMode(); // הופך את השדות ל-ReadOnly
            }
            else
            {
                MessageBox.Show("החבר לא נמצא.", "תוצאה ריקה", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            reader.Close();
        }
        private void IDSearchBox_Enter(object sender, EventArgs e)
        {
            if (IDTXTBox.Text == "נא להזין ת\"ז")
            {
                IDTXTBox.Text = "";
                IDTXTBox.ForeColor = Color.Black;
            }
        }

        private void IDSearchBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(IDTXTBox.Text))
            {
                IDTXTBox.Text = "נא להזין ת\"ז";
                IDTXTBox.ForeColor = Color.Gray;
            }
        }

        private void ViewMember_Load(object sender, EventArgs e)
        {
            GenderCombo.DataSource = Enum.GetValues(typeof(GenderLookup));
            MemberTypeCombo.DataSource = Enum.GetValues(typeof(MemberTypeLookup));
            TrainingStatusCombo.DataSource = Enum.GetValues(typeof(TrainingStatusLookup));

            // טקסט ברירת מחדל לשדה החיפוש
            IDTXTBox.Text = "נא להזין ת\"ז";
            IDTXTBox.ForeColor = Color.Gray;

            // מחברים את האירועים
            IDTXTBox.Enter += IDTXTBox_Enter;
            IDTXTBox.Leave += IDTXTBox_Leave;
        }
        private void IDTXTBox_Enter(object sender, EventArgs e)
        {
            if (IDTXTBox.Text == "נא להזין ת\"ז")
            {
                IDTXTBox.Text = "";
                IDTXTBox.ForeColor = Color.Black;
            }
        }

        private void IDTXTBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(IDTXTBox.Text))
            {
                IDTXTBox.Text = "נא להזין ת\"ז";
                IDTXTBox.ForeColor = Color.Gray;
            }
        }

    }
}

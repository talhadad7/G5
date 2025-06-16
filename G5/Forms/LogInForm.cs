using G5.Forms;
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
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }
        private void LoginButton_Click(object sender, EventArgs e)
        {
            string email = UserNameTxtBox.Text.Trim();
            string password = PasswordTxtBox.Text.Trim(); // ת"ז

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("יש להזין שם משתמש וסיסמה.", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // חיפוש ב־Program.Members
            Member found = Program.Members.FirstOrDefault(m =>
                m.emailAddress == email && m.memberID == password);

            if (found == null)
            {
                MessageBox.Show("שם משתמש או סיסמה שגויים.", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Program.CurrentUser = found;

            MessageBox.Show($"שלום, {found.firstName}!", "התחברת בהצלחה", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // כאן אפשר לפתוח טופס ראשי ולסגור את טופס ההתחברות:
            //  this.Hide();
            // new MainForm().Show(); // החלף ב־Form הראשי שלך
            MessageBox.Show("התחברת בהצלחה!");
            this.Close(); // אם אתה רוצה לסגור את הטופס

        }

        private void LogInForm_Load(object sender, EventArgs e)
        {

        }

        private void LogInButton_Click_1(object sender, EventArgs e)
        {
            // 1) Read and trim user inputs
            string email = UserNameTxtBox.Text.Trim();
            string password = PasswordTxtBox.Text.Trim();

            // 2) Basic non-empty check
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show(
                    "יש להזין שם משתמש וסיסמה.",    // "Please enter username & password."
                    "שגיאה",                        // "Error"
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            // 3) Attempt to find matching Member by email & password
            Member found = Program.Members
                .FirstOrDefault(m =>
                    m.emailAddress == email &&
                    m.memberID == password  // using memberID as password
                );

            // 4) If not found, notify and stay on login
            if (found == null)
            {
                MessageBox.Show(
                    "שם משתמש או סיסמה שגויים.",   // "Username or password incorrect."
                    "שגיאה",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            // 5) Save the logged-in user globally
            Program.CurrentUser = found;

            // 6) Greet the user
            MessageBox.Show(
                $"שלום, {found.firstName}!\nהתחברת בהצלחה.",  // two lines in one box
                "התחברת בהצלחה",               // "Login successful"
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            this.Hide();
            using (var main = new MainPageForm())
            {
                main.StartPosition = FormStartPosition.CenterScreen;
                main.ShowDialog();
            }              // open it modally
            this.Close();                      // once HomePage closes, end the app
        }

        private void UserNameTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

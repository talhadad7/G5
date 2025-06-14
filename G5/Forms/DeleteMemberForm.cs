using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G5
{
    public class DeleteMemberForm : Form
    {
        private TextBox idTextBox;
        private Button deleteButton;

        public DeleteMemberForm()
        {
            this.Text = "מחיקת בוגר";
            this.Width = 300;
            this.Height = 150;

            Label label = new Label();
            label.Text = "ת\"ז של הבוגר למחיקה:";
            label.Top = 20;
            label.Left = 10;
            label.Width = 200;

            idTextBox = new TextBox();
            idTextBox.Top = 45;
            idTextBox.Left = 10;
            idTextBox.Width = 250;

            deleteButton = new Button();
            deleteButton.Text = "מחק";
            deleteButton.Top = 75;
            deleteButton.Left = 10;
            deleteButton.Click += DeleteButton_Click;

            this.Controls.Add(label);
            this.Controls.Add(idTextBox);
            this.Controls.Add(deleteButton);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            string id = idTextBox.Text.Trim();

            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("יש להזין ת\"ז.", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool removed = Program.DeleteMemberFromList(id);
            if (removed)
            {
                MessageBox.Show("הבוגר נמחק מהרשימה.", "הצלחה", MessageBoxButtons.OK, MessageBoxIcon.Information);
                idTextBox.Clear();
            }
            else
            {
                MessageBox.Show("לא נמצא בוגר עם ת\"ז זו.", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // DeleteMemberForm
            // 
            this.ClientSize = new System.Drawing.Size(913, 544);
            this.Name = "DeleteMemberForm";
            this.Load += new System.EventHandler(this.DeleteMemberForm_Load);
            this.ResumeLayout(false);

        }

        private void DeleteMemberForm_Load(object sender, EventArgs e)
        {

        }
    }
}

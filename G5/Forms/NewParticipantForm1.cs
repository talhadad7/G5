using System;
using System.Windows.Forms;

namespace G5.Forms
{
    public class NewParticipantForm1 : Form
    {
        private TextBox idTextBox, firstNameTextBox, lastNameTextBox, addressTextBox,
                        emergencyContactTextBox, medicalNotesTextBox, schoolTextBox;
        private DateTimePicker birthDatePicker, joinDatePicker;
        private ComboBox genderCombo, ageGroupCombo;
        private CheckBox paymentCheckBox;
        private Button saveButton, cancelButton;

        public NewParticipantForm1()
        {
            this.Text = "יצירת משתתף חדש";
            this.Width = 500;
            this.Height = 750;
            this.StartPosition = FormStartPosition.CenterScreen;

            int y = 20;
            int spacing = 40;
            int labelWidth = 140;
            int controlWidth = 250;

            void AddLabeled(Control control, string text)
            {
                Label label = new Label { Text = text, Top = y + 5, Left = 20, Width = labelWidth, TextAlign = System.Drawing.ContentAlignment.MiddleRight };
                control.Top = y;
                control.Left = label.Right + 10;
                control.Width = controlWidth;
                this.Controls.Add(label);
                this.Controls.Add(control);
                y += spacing;
            }

            idTextBox = new TextBox();
            firstNameTextBox = new TextBox();
            lastNameTextBox = new TextBox();
            birthDatePicker = new DateTimePicker();
            genderCombo = new ComboBox { DropDownStyle = ComboBoxStyle.DropDownList };
            addressTextBox = new TextBox();
            ageGroupCombo = new ComboBox { DropDownStyle = ComboBoxStyle.DropDownList };
            joinDatePicker = new DateTimePicker();
            emergencyContactTextBox = new TextBox();
            schoolTextBox = new TextBox();
            medicalNotesTextBox = new TextBox();
            paymentCheckBox = new CheckBox { Text = "שולמו דמי חבר" };

            AddLabeled(idTextBox, "תעודת זהות:");
            AddLabeled(firstNameTextBox, "שם פרטי:");
            AddLabeled(lastNameTextBox, "שם משפחה:");
            AddLabeled(birthDatePicker, "תאריך לידה:");
            AddLabeled(genderCombo, "מגדר:");
            AddLabeled(addressTextBox, "כתובת:");
            AddLabeled(ageGroupCombo, "קבוצת גיל:");
            AddLabeled(joinDatePicker, "תאריך הצטרפות:");
            AddLabeled(emergencyContactTextBox, "טלפון איש קשר:");
            AddLabeled(schoolTextBox, "בית ספר:");
            AddLabeled(medicalNotesTextBox, "הערות רפואיות:");

            paymentCheckBox.Top = y;
            paymentCheckBox.Left = 20;
            this.Controls.Add(paymentCheckBox);
            y += spacing + 10;

            saveButton = new Button { Text = "שמור", Width = 100, Left = 70, Top = y };
            cancelButton = new Button { Text = "בטל", Width = 100, Left = 200, Top = y };

            saveButton.Click += SaveParticipant;
            cancelButton.Click += (s, e) => this.Close();

            this.Controls.Add(saveButton);
            this.Controls.Add(cancelButton);

            genderCombo.DataSource = Enum.GetValues(typeof(GenderLookup));
            ageGroupCombo.DataSource = Enum.GetValues(typeof(AgeGroupLookup));
        }

        private void SaveParticipant(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(idTextBox.Text) ||
                string.IsNullOrWhiteSpace(firstNameTextBox.Text) ||
                string.IsNullOrWhiteSpace(lastNameTextBox.Text) ||
                genderCombo.SelectedItem == null ||
                ageGroupCombo.SelectedItem == null ||
                string.IsNullOrWhiteSpace(addressTextBox.Text) ||
                string.IsNullOrWhiteSpace(emergencyContactTextBox.Text) ||
                string.IsNullOrWhiteSpace(schoolTextBox.Text))
            {
                MessageBox.Show("אנא מלא את כל השדות החובה (חוץ מהערות רפואיות)", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var participant = new Participant(
                    idTextBox.Text.Trim(),
                    firstNameTextBox.Text.Trim(),
                    lastNameTextBox.Text.Trim(),
                    birthDatePicker.Value.Date,
                    (GenderLookup)genderCombo.SelectedItem,
                    joinDatePicker.Value.Date,
                    (AgeGroupLookup)ageGroupCombo.SelectedItem,
                    paymentCheckBox.Checked,
                    addressTextBox.Text.Trim(),
                    schoolTextBox.Text.Trim(),
                    emergencyContactTextBox.Text.Trim(),
                    string.IsNullOrWhiteSpace(medicalNotesTextBox.Text) ? null : medicalNotesTextBox.Text.Trim(),
                    isNew: true
                );

                MessageBox.Show("המשתתף נשמר בהצלחה!", "הצלחה", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("שגיאה בשמירה: " + ex.Message, "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
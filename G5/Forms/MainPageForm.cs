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
    public partial class MainPageForm : Form
    {
        // 1) field for the participants dropdown
        private ContextMenuStrip _participantMenu;

        public MainPageForm()
        {
            InitializeComponent();
            InitializeParticipantMenu();

            // ensure the button's Click is hooked
            ParticipantsButton.Click -= ParticipantsButton_Click;
            ParticipantsButton.Click += ParticipantsButton_Click;
        }

        /// <summary>
        /// Build the "חניכים" menu and attach it to ParticipantsButton.
        /// </summary>
        private void InitializeParticipantMenu()
        {
            _participantMenu = new ContextMenuStrip();

            // header (disabled)
            _participantMenu.Items.Add(new ToolStripMenuItem("חניכים") { Enabled = false });

            // CRUD entries
            _participantMenu.Items.Add(new ToolStripMenuItem("צור", null, CreateParticipant_Click));
            _participantMenu.Items.Add(new ToolStripMenuItem("צפה", null, ViewParticipant_Click));
            _participantMenu.Items.Add(new ToolStripMenuItem("עדכן", null, UpdateParticipant_Click));
            _participantMenu.Items.Add(new ToolStripMenuItem("מחק", null, DeleteParticipant_Click));

            // attach to button
            ParticipantsButton.ContextMenuStrip = _participantMenu;
        }

        /// <summary>
        /// On left-click, drop the menu right under the button.
        /// </summary>
        private void ParticipantsButton_Click(object sender, EventArgs e)
        {
            _participantMenu.Show(
                ParticipantsButton,
                new Point(0, ParticipantsButton.Height)
            );
        }

        // ─── CRUD Handlers ───

        private void CreateParticipant_Click(object sender, EventArgs e)
        {
            using (var f = new NewParticipantForm1())
                f.ShowDialog();
        }

        private void ViewParticipant_Click(object sender, EventArgs e)
        {
            using (var f = new ViewParticipant())
                f.ShowDialog();
        }

        private void UpdateParticipant_Click(object sender, EventArgs e)
        {
            using (var f = new UpdateParticpant())
                f.ShowDialog();
        }

        private void DeleteParticipant_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "טופס מחיקת משתתף עדיין לא קיים.",
                "מחק משתתף",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        // ─── Stubs for the other buttons ───

        private void MembersButton_Click(object sender, EventArgs e)
        {
            // TODO: implement Members logic
        }

        private void ActivitiesButton_Click(object sender, EventArgs e)
        {
            // TODO: implement Activities logic
        }

        private void MessagesButton_Click(object sender, EventArgs e)
        {
            // TODO: implement Messages logic
        }
    }
}


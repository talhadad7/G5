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
    public partial class HomePage : Form
    {
        // Context menu for Participants CRUD
        private ContextMenuStrip _participantMenu;

        public HomePage()
        {
            InitializeComponent();
            InitializeParticipantMenu();

            // Wire the Participants button click event to the handler
            // (in case it wasn't set in the Designer)
            ParticipantsButtonHomeScreen.Click += ParticipantsButtonHomeScreen_Click;
        }

        private void InitializeParticipantMenu()
        {
            // build the dropdown menu
            _participantMenu = new ContextMenuStrip();

            // header (disabled)
            _participantMenu.Items.Add(new ToolStripMenuItem("חניכים") { Enabled = false });

            // CRUD items
            _participantMenu.Items.Add(new ToolStripMenuItem("צור", null, CreateParticipant_Click));
            _participantMenu.Items.Add(new ToolStripMenuItem("צפה", null, ViewParticipant_Click));
            _participantMenu.Items.Add(new ToolStripMenuItem("עדכן", null, UpdateParticipant_Click));
            _participantMenu.Items.Add(new ToolStripMenuItem("מחק", null, DeleteParticipant_Click));

            // attach to the Participants button
            ParticipantsButtonHomeScreen.ContextMenuStrip = _participantMenu;
        }

        private void ParticipantsButtonHomeScreen_Click(object sender, EventArgs e)
        {
            // show the menu under the Participants button
            _participantMenu.Show(
                ParticipantsButtonHomeScreen,
                new Point(0, ParticipantsButtonHomeScreen.Height)
            );
        }

        // Menu-item handlers
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

        // Existing stubs for other controls
        private void label1_Click(object sender, EventArgs e) { }
        private void label6_Click(object sender, EventArgs e) { }
        private void button1_Click(object sender, EventArgs e) { }
        private void MessegesButtonHomeScreen_Click(object sender, EventArgs e) { }
        private void ActivitiesButtonHomeScreen_Click(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
        private void createParticipantToolStripMenuItemToolStripMenuItem_Click(object sender, EventArgs e) { }
        private void viewParticipantToolStripMenuItemToolStripMenuItem_Click(object sender, EventArgs e) { }
        private void updateParticipantToolStripMenuItemToolStripMenuItem_Click(object sender, EventArgs e) { }
        private void HomePage_Load(object sender, EventArgs e) { }
        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e) { }
        private void מחקToolStripMenuItem_Click(object sender, EventArgs e) { }
        private void toolStripMenuItem2_Click(object sender, EventArgs e) { }
        private void deleteParticipantToolStripMenuItemToolStripMenuItem_Click(object sender, EventArgs e) { }

        // Rename Bogrim button stub changed to Members
        private void MembersButtonHomeScreen_Click(object sender, EventArgs e)
        {
            // implementation for Members button
        }
    }
}

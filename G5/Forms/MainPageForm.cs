using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using G5;   // <-- add this so DeleteParticipant is in scope

namespace G5.Forms
{
    public partial class MainPageForm : Form
    {
        // 1) field for the participants dropdown
        private ContextMenuStrip _participantMenu;

        // dropdown menu for Members CRUD
        private ContextMenuStrip _membersMenu;

        // dropdown menu for Announcements
        private ContextMenuStrip _announcementsMenu;

        private ContextMenuStrip _activityMenu;


        public MainPageForm()
        {
            InitializeComponent();

            // existing participant menu
            InitializeParticipantMenu();

            // new members menu
            InitializeMembersMenu();

            InitializeAnnouncementsMenu();

            InitializeActivityMenu();

            ActivityButton.ContextMenuStrip = _activityMenu;


            // ensure the buttons fire the right handlers
            ParticipantsButton.Click -= ParticipantsButton_Click;
            ParticipantsButton.Click += ParticipantsButton_Click;

            MembersButton.Click -= MembersButton_Click;
            MembersButton.Click += MembersButton_Click;
        }

        /// <summary>
        /// Builds the “Announcements” menu and hooks it to MessagesButton.
        /// </summary>


        private void InitializeActivityMenu()
        {
            _activityMenu = new ContextMenuStrip();

            // Create "Create Activity" option
            ToolStripMenuItem createItem = new ToolStripMenuItem("צור פעילות חדש");
            createItem.Click += (sender, e) =>
            {
                CreateActivityForm form = new CreateActivityForm();
                form.ShowDialog();
            };

            // Create "View Activities" option
            ToolStripMenuItem viewItem = new ToolStripMenuItem("צפה במאגר הפעילויות");
            viewItem.Click += (sender, e) =>
            {
                ViewActivity form = new ViewActivity();
                form.ShowDialog();
            };

            // Create "Delete Activity" option
            ToolStripMenuItem deleteItem = new ToolStripMenuItem("מחק פעולה");
            deleteItem.Click += (sender, e) =>
            {
                DeleteActivity form = new DeleteActivity();
                form.ShowDialog();
            };

            // Add all items to the context menu
            _activityMenu.Items.Add(createItem);
            _activityMenu.Items.Add(viewItem);
            _activityMenu.Items.Add(deleteItem);
        }

        private void InitializeAnnouncementsMenu()
        {
            _announcementsMenu = new ContextMenuStrip();

            // Disabled header
            _announcementsMenu.Items.Add(new ToolStripMenuItem("Announcements") { Enabled = false });

            // 1) Everyone can view
            _announcementsMenu.Items.Add(
                "View Announcements",
                null,
                (s, e) =>
                {
                    using (var f = new ViewAnnouncements())
                        f.ShowDialog(this);
                }
            );

            // 2) Everyone sees “New Announcement” – but click does different things
            var newItem = new ToolStripMenuItem("New Announcement");
            newItem.Click += (s, e) =>
            {
                bool isCoordinator = Program.CoordinatorTypes
                    .Contains(Program.CurrentUser.memberTypeName);

                if (isCoordinator)
                {
                    // coordinators open the form
                    using (var f = new NewAnnouncementForm())
                        f.ShowDialog(this);
                }
                else
                {
                    // non-coordinators get this Hebrew message:
                    MessageBox.Show(
                        "אין לך גישה – רק רכזים מורשים לפרסם הודעות.",
                        "אין הרשאה",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
            };
            _announcementsMenu.Items.Add(newItem);

            // 3) Attach to your Messages button
            MessagesButton.ContextMenuStrip = _announcementsMenu;
            MessagesButton.Click += (s, e) =>
                _announcementsMenu.Show(
                    MessagesButton,
                    new Point(0, MessagesButton.Height)
                );
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
        /// Builds & attaches the “בוגרים” CRUD menu to MembersButton.
        /// </summary>
        private void InitializeMembersMenu()
        {
            _membersMenu = new ContextMenuStrip();

            // disabled header
            _membersMenu.Items.Add(new ToolStripMenuItem("בוגרים") { Enabled = false });

            // CRUD items
            _membersMenu.Items.Add(new ToolStripMenuItem("צור", null, CreateMember_Click));
            _membersMenu.Items.Add(new ToolStripMenuItem("צפה", null, ViewMember_Click));
            _membersMenu.Items.Add(new ToolStripMenuItem("עדכן", null, UpdateMember_Click));
            _membersMenu.Items.Add(new ToolStripMenuItem("מחק", null, DeleteMember_Click));

            // attach to the button
            MembersButton.ContextMenuStrip = _membersMenu;
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
            // instantiate and show your real DeleteParticipant form
            using (var dlg = new DeleteParticipant())
            {
                dlg.StartPosition = FormStartPosition.CenterParent;
                dlg.ShowDialog(this);
            }
        }


        // ─── Stubs for the other buttons ───

        private void MembersButton_Click(object sender, EventArgs e)
        {
            // grab the logged-in user’s type
            var type = Program.CurrentUser.memberTypeName;


            // only coordinators allowed
            if (!Program.CoordinatorTypes.Contains(type))
            {
                MessageBox.Show(
                    "אינך מורשה - הגישה אפשרית לרכזים בלבד",
                    "אין הרשאה",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            // authorized → show the members CRUD menu
            _membersMenu.Show(
                MembersButton,
                new Point(0, MembersButton.Height)
            );
        }


        private void CreateMember_Click(object sender, EventArgs e)
        {
            using (var f = new NewMemberForm())
                f.ShowDialog();
        }

        private void ViewMember_Click(object sender, EventArgs e)
        {
            using (var f = new ViewMemberForm())
                f.ShowDialog();
        }

        private void UpdateMember_Click(object sender, EventArgs e)
        {
            using (var f = new UpdateMemberForm())
               f.ShowDialog();
        }

        private void DeleteMember_Click(object sender, EventArgs e)
        {
            using (var f = new DeleteMemberNew())
            {
                f.StartPosition = FormStartPosition.CenterParent;
                f.ShowDialog(this);
            }
        }



       // private void ActivitiesButton_Click(object sender, EventArgs e)
        //{
           // _activityMenu.Show(
             ///   ActivityButton,
              //  new Point(0, ActivityButton.Height)
          //  );
       // }






        private void MainPageForm_Load(object sender, EventArgs e)
        {

        }

        private void ActivityButton_Click(object sender, EventArgs e)
        {
            _activityMenu.Show(
                ActivityButton,
                new Point(0, ActivityButton.Height)
            );
        }
    }
}


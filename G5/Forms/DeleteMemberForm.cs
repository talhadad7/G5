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
        private Label lblEnterID;
        private Label lblTitle;
        private TextBox txtEnterID;
        private DataGridView dgvListOfMembers;
        private BindingSource g5DataSetBindingSource;
        private System.ComponentModel.IContainer components;
        private G5DataSet g5DataSet;
        private Button btnDeleteMember;
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
            this.components = new System.ComponentModel.Container();
            this.lblEnterID = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtEnterID = new System.Windows.Forms.TextBox();
            this.dgvListOfMembers = new System.Windows.Forms.DataGridView();
            this.g5DataSet = new G5.G5DataSet();
            this.g5DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnDeleteMember = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListOfMembers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.g5DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.g5DataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEnterID
            // 
            this.lblEnterID.AutoSize = true;
            this.lblEnterID.Location = new System.Drawing.Point(663, 140);
            this.lblEnterID.Name = "lblEnterID";
            this.lblEnterID.Size = new System.Drawing.Size(100, 16);
            this.lblEnterID.TabIndex = 0;
            this.lblEnterID.Text = "הזן תעודת זהות ";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(414, 47);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(93, 25);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "מחק בוגר";
            // 
            // txtEnterID
            // 
            this.txtEnterID.Location = new System.Drawing.Point(468, 136);
            this.txtEnterID.Name = "txtEnterID";
            this.txtEnterID.Size = new System.Drawing.Size(161, 22);
            this.txtEnterID.TabIndex = 2;
            // 
            // dgvListOfMembers
            // 
            this.dgvListOfMembers.AutoGenerateColumns = false;
            this.dgvListOfMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListOfMembers.DataSource = this.g5DataSetBindingSource;
            this.dgvListOfMembers.Location = new System.Drawing.Point(111, 218);
            this.dgvListOfMembers.Name = "dgvListOfMembers";
            this.dgvListOfMembers.RowHeadersWidth = 51;
            this.dgvListOfMembers.RowTemplate.Height = 24;
            this.dgvListOfMembers.Size = new System.Drawing.Size(689, 151);
            this.dgvListOfMembers.TabIndex = 3;
            // 
            // g5DataSet
            // 
            this.g5DataSet.DataSetName = "G5DataSet";
            this.g5DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // g5DataSetBindingSource
            // 
            this.g5DataSetBindingSource.DataSource = this.g5DataSet;
            this.g5DataSetBindingSource.Position = 0;
            // 
            // btnDeleteMember
            // 
            this.btnDeleteMember.Location = new System.Drawing.Point(111, 406);
            this.btnDeleteMember.Name = "btnDeleteMember";
            this.btnDeleteMember.Size = new System.Drawing.Size(148, 35);
            this.btnDeleteMember.TabIndex = 4;
            this.btnDeleteMember.Text = "מחק";
            this.btnDeleteMember.UseVisualStyleBackColor = true;
            // 
            // DeleteMemberForm
            // 
            this.ClientSize = new System.Drawing.Size(913, 544);
            this.Controls.Add(this.btnDeleteMember);
            this.Controls.Add(this.dgvListOfMembers);
            this.Controls.Add(this.txtEnterID);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblEnterID);
            this.Name = "DeleteMemberForm";
            this.Load += new System.EventHandler(this.DeleteMemberForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListOfMembers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.g5DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.g5DataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void DeleteMemberForm_Load(object sender, EventArgs e)
        {

        }
    }
}

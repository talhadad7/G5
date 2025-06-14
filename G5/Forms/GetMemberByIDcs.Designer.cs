﻿namespace G5
{
    partial class GetMemberByIDcs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.MemberIDTXTBox = new System.Windows.Forms.TextBox();
            this.MemberByIDLabel = new System.Windows.Forms.Label();
            this.MemberSearchButton = new System.Windows.Forms.Button();
            this.g5DataSet = new G5.G5DataSet();
            this.participantsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.participantsTableAdapter = new G5.G5DataSetTableAdapters.ParticipantsTableAdapter();
            this.membersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.membersTableAdapter = new G5.G5DataSetTableAdapters.MembersTableAdapter();
            this.dgvMembers = new System.Windows.Forms.DataGridView();
            this.colMemberID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBirthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colJoinDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSeniority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmergencyContact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPaymentStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrainingStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.g5DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.participantsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.membersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).BeginInit();
            this.SuspendLayout();
            // 
            // MemberIDTXTBox
            // 
            this.MemberIDTXTBox.Location = new System.Drawing.Point(183, 228);
            this.MemberIDTXTBox.Margin = new System.Windows.Forms.Padding(4);
            this.MemberIDTXTBox.Name = "MemberIDTXTBox";
            this.MemberIDTXTBox.Size = new System.Drawing.Size(191, 31);
            this.MemberIDTXTBox.TabIndex = 0;
            this.MemberIDTXTBox.Text = "נא להכניס תז";
            this.MemberIDTXTBox.TextChanged += new System.EventHandler(this.IDInserted);
            // 
            // MemberByIDLabel
            // 
            this.MemberByIDLabel.AutoSize = true;
            this.MemberByIDLabel.Location = new System.Drawing.Point(773, 60);
            this.MemberByIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MemberByIDLabel.Name = "MemberByIDLabel";
            this.MemberByIDLabel.Size = new System.Drawing.Size(110, 25);
            this.MemberByIDLabel.TabIndex = 1;
            this.MemberByIDLabel.Text = "חיפוש בוגר";
            // 
            // MemberSearchButton
            // 
            this.MemberSearchButton.Location = new System.Drawing.Point(1275, 208);
            this.MemberSearchButton.Margin = new System.Windows.Forms.Padding(4);
            this.MemberSearchButton.Name = "MemberSearchButton";
            this.MemberSearchButton.Size = new System.Drawing.Size(152, 74);
            this.MemberSearchButton.TabIndex = 2;
            this.MemberSearchButton.Text = "חיפוש";
            this.MemberSearchButton.UseVisualStyleBackColor = true;
            this.MemberSearchButton.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // g5DataSet
            // 
            this.g5DataSet.DataSetName = "G5DataSet";
            this.g5DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // participantsBindingSource
            // 
            this.participantsBindingSource.DataMember = "Participants";
            this.participantsBindingSource.DataSource = this.g5DataSet;
            // 
            // participantsTableAdapter
            // 
            this.participantsTableAdapter.ClearBeforeFill = true;
            // 
            // membersBindingSource
            // 
            this.membersBindingSource.DataMember = "Members";
            this.membersBindingSource.DataSource = this.g5DataSet;
            // 
            // membersTableAdapter
            // 
            this.membersTableAdapter.ClearBeforeFill = true;
            // 
            // dgvMembers
            // 
            this.dgvMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMembers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMemberID,
            this.colFirstName,
            this.colLastName,
            this.colType,
            this.colBirthDate,
            this.colGender,
            this.colJoinDate,
            this.colSeniority,
            this.colPhone,
            this.colEmail,
            this.colAddress,
            this.colEmergencyContact,
            this.colPaymentStatus,
            this.colTrainingStatus});
            this.dgvMembers.Location = new System.Drawing.Point(43, 319);
            this.dgvMembers.Margin = new System.Windows.Forms.Padding(4);
            this.dgvMembers.Name = "dgvMembers";
            this.dgvMembers.RowHeadersWidth = 62;
            this.dgvMembers.RowTemplate.Height = 28;
            this.dgvMembers.Size = new System.Drawing.Size(1516, 136);
            this.dgvMembers.TabIndex = 3;
            this.dgvMembers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMembers_CellContentClick);
            // 
            // colMemberID
            // 
            this.colMemberID.HeaderText = "Member Id";
            this.colMemberID.MinimumWidth = 8;
            this.colMemberID.Name = "colMemberID";
            this.colMemberID.Width = 150;
            // 
            // colFirstName
            // 
            this.colFirstName.HeaderText = "First Name";
            this.colFirstName.MinimumWidth = 8;
            this.colFirstName.Name = "colFirstName";
            this.colFirstName.Width = 150;
            // 
            // colLastName
            // 
            this.colLastName.HeaderText = "Last Name";
            this.colLastName.MinimumWidth = 8;
            this.colLastName.Name = "colLastName";
            this.colLastName.ReadOnly = true;
            this.colLastName.Width = 150;
            // 
            // colType
            // 
            this.colType.HeaderText = "Type";
            this.colType.MinimumWidth = 8;
            this.colType.Name = "colType";
            this.colType.ReadOnly = true;
            this.colType.Width = 150;
            // 
            // colBirthDate
            // 
            this.colBirthDate.HeaderText = "Birth Date";
            this.colBirthDate.MinimumWidth = 8;
            this.colBirthDate.Name = "colBirthDate";
            this.colBirthDate.ReadOnly = true;
            this.colBirthDate.Width = 150;
            // 
            // colGender
            // 
            this.colGender.HeaderText = "Gender";
            this.colGender.MinimumWidth = 8;
            this.colGender.Name = "colGender";
            this.colGender.ReadOnly = true;
            this.colGender.Width = 150;
            // 
            // colJoinDate
            // 
            this.colJoinDate.HeaderText = "Join Date";
            this.colJoinDate.MinimumWidth = 8;
            this.colJoinDate.Name = "colJoinDate";
            this.colJoinDate.ReadOnly = true;
            this.colJoinDate.Width = 150;
            // 
            // colSeniority
            // 
            this.colSeniority.HeaderText = "Seniority";
            this.colSeniority.MinimumWidth = 8;
            this.colSeniority.Name = "colSeniority";
            this.colSeniority.ReadOnly = true;
            this.colSeniority.Width = 150;
            // 
            // colPhone
            // 
            this.colPhone.HeaderText = "Phone";
            this.colPhone.MinimumWidth = 8;
            this.colPhone.Name = "colPhone";
            this.colPhone.ReadOnly = true;
            this.colPhone.Width = 150;
            // 
            // colEmail
            // 
            this.colEmail.HeaderText = "Email";
            this.colEmail.MinimumWidth = 8;
            this.colEmail.Name = "colEmail";
            this.colEmail.ReadOnly = true;
            this.colEmail.Width = 150;
            // 
            // colAddress
            // 
            this.colAddress.HeaderText = "Address";
            this.colAddress.MinimumWidth = 8;
            this.colAddress.Name = "colAddress";
            this.colAddress.ReadOnly = true;
            this.colAddress.Width = 150;
            // 
            // colEmergencyContact
            // 
            this.colEmergencyContact.HeaderText = "Emergency Contact";
            this.colEmergencyContact.MinimumWidth = 8;
            this.colEmergencyContact.Name = "colEmergencyContact";
            this.colEmergencyContact.ReadOnly = true;
            this.colEmergencyContact.Width = 150;
            // 
            // colPaymentStatus
            // 
            this.colPaymentStatus.HeaderText = "Payment Status";
            this.colPaymentStatus.MinimumWidth = 8;
            this.colPaymentStatus.Name = "colPaymentStatus";
            this.colPaymentStatus.ReadOnly = true;
            this.colPaymentStatus.Width = 150;
            // 
            // colTrainingStatus
            // 
            this.colTrainingStatus.HeaderText = "Training Status";
            this.colTrainingStatus.MinimumWidth = 8;
            this.colTrainingStatus.Name = "colTrainingStatus";
            this.colTrainingStatus.ReadOnly = true;
            this.colTrainingStatus.Width = 150;
            // 
            // GetMemberByIDcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1601, 562);
            this.Controls.Add(this.dgvMembers);
            this.Controls.Add(this.MemberSearchButton);
            this.Controls.Add(this.MemberByIDLabel);
            this.Controls.Add(this.MemberIDTXTBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GetMemberByIDcs";
            this.Text = "GetMemberByIDcs";
            this.Load += new System.EventHandler(this.GetMemberByIDcs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.g5DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.participantsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.membersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MemberIDTXTBox;
        private System.Windows.Forms.Label MemberByIDLabel;
        private System.Windows.Forms.Button MemberSearchButton;
        private G5DataSet g5DataSet;
        private System.Windows.Forms.BindingSource participantsBindingSource;
        private G5DataSetTableAdapters.ParticipantsTableAdapter participantsTableAdapter;
        private System.Windows.Forms.BindingSource membersBindingSource;
        private G5DataSetTableAdapters.MembersTableAdapter membersTableAdapter;
        private System.Windows.Forms.DataGridView dgvMembers;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMemberID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBirthDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn colJoinDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSeniority;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmergencyContact;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPaymentStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrainingStatus;
    }
}
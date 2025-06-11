namespace G5
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
            ((System.ComponentModel.ISupportInitialize)(this.g5DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.participantsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.membersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // MemberIDTXTBox
            // 
            this.MemberIDTXTBox.Location = new System.Drawing.Point(137, 182);
            this.MemberIDTXTBox.Name = "MemberIDTXTBox";
            this.MemberIDTXTBox.Size = new System.Drawing.Size(144, 26);
            this.MemberIDTXTBox.TabIndex = 0;
            this.MemberIDTXTBox.Text = "נא להכניס תז";
            this.MemberIDTXTBox.TextChanged += new System.EventHandler(this.IDInserted);
            // 
            // MemberByIDLabel
            // 
            this.MemberByIDLabel.AutoSize = true;
            this.MemberByIDLabel.Location = new System.Drawing.Point(314, 39);
            this.MemberByIDLabel.Name = "MemberByIDLabel";
            this.MemberByIDLabel.Size = new System.Drawing.Size(82, 20);
            this.MemberByIDLabel.TabIndex = 1;
            this.MemberByIDLabel.Text = "חיפוש בוגר";
            // 
            // MemberSearchButton
            // 
            this.MemberSearchButton.Location = new System.Drawing.Point(536, 173);
            this.MemberSearchButton.Name = "MemberSearchButton";
            this.MemberSearchButton.Size = new System.Drawing.Size(114, 59);
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
            // GetMemberByIDcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MemberSearchButton);
            this.Controls.Add(this.MemberByIDLabel);
            this.Controls.Add(this.MemberIDTXTBox);
            this.Name = "GetMemberByIDcs";
            this.Text = "GetMemberByIDcs";
            this.Load += new System.EventHandler(this.GetMemberByIDcs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.g5DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.participantsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.membersBindingSource)).EndInit();
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
    }
}
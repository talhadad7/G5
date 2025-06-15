namespace G5
{
    partial class DeleteMemberNew
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
            this.btnDeleteMember = new System.Windows.Forms.Button();
            this.dgvListOfMembers = new System.Windows.Forms.DataGridView();
            this.txtEnterID = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblEnterID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListOfMembers)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeleteMember
            // 
            this.btnDeleteMember.Location = new System.Drawing.Point(56, 387);
            this.btnDeleteMember.Name = "btnDeleteMember";
            this.btnDeleteMember.Size = new System.Drawing.Size(148, 35);
            this.btnDeleteMember.TabIndex = 9;
            this.btnDeleteMember.Text = "מחק";
            this.btnDeleteMember.UseVisualStyleBackColor = true;
            // 
            // dgvListOfMembers
            // 
            this.dgvListOfMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListOfMembers.Location = new System.Drawing.Point(56, 199);
            this.dgvListOfMembers.Name = "dgvListOfMembers";
            this.dgvListOfMembers.RowHeadersWidth = 51;
            this.dgvListOfMembers.RowTemplate.Height = 24;
            this.dgvListOfMembers.Size = new System.Drawing.Size(689, 151);
            this.dgvListOfMembers.TabIndex = 8;
            // 
            // txtEnterID
            // 
            this.txtEnterID.Location = new System.Drawing.Point(413, 117);
            this.txtEnterID.Name = "txtEnterID";
            this.txtEnterID.Size = new System.Drawing.Size(161, 22);
            this.txtEnterID.TabIndex = 7;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(359, 28);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(93, 25);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "מחק בוגר";
            // 
            // lblEnterID
            // 
            this.lblEnterID.AutoSize = true;
            this.lblEnterID.Location = new System.Drawing.Point(608, 121);
            this.lblEnterID.Name = "lblEnterID";
            this.lblEnterID.Size = new System.Drawing.Size(100, 16);
            this.lblEnterID.TabIndex = 5;
            this.lblEnterID.Text = "הזן תעודת זהות ";
            // 
            // DeleteMemberNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDeleteMember);
            this.Controls.Add(this.dgvListOfMembers);
            this.Controls.Add(this.txtEnterID);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblEnterID);
            this.Name = "DeleteMemberNew";
            this.Text = "DeleteMemberNew";
            //this.Load += new System.EventHandler(this.DeleteMemberNew_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListOfMembers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteMember;
        private System.Windows.Forms.DataGridView dgvListOfMembers;
        private System.Windows.Forms.TextBox txtEnterID;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblEnterID;
    }
}
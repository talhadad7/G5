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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteMemberNew));
            this.btnDeleteMember = new System.Windows.Forms.Button();
            this.dgvListOfMembers = new System.Windows.Forms.DataGridView();
            this.txtEnterID = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblEnterID = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListOfMembers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeleteMember
            // 
            this.btnDeleteMember.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteMember.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnDeleteMember.Location = new System.Drawing.Point(32, 430);
            this.btnDeleteMember.Name = "btnDeleteMember";
            this.btnDeleteMember.Size = new System.Drawing.Size(148, 45);
            this.btnDeleteMember.TabIndex = 9;
            this.btnDeleteMember.Text = "מחק";
            this.btnDeleteMember.UseVisualStyleBackColor = true;
            this.btnDeleteMember.Click += new System.EventHandler(this.btnDeleteMember_Click_1);
            // 
            // dgvListOfMembers
            // 
            this.dgvListOfMembers.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dgvListOfMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListOfMembers.Location = new System.Drawing.Point(78, 218);
            this.dgvListOfMembers.Name = "dgvListOfMembers";
            this.dgvListOfMembers.RowHeadersWidth = 51;
            this.dgvListOfMembers.RowTemplate.Height = 24;
            this.dgvListOfMembers.Size = new System.Drawing.Size(689, 151);
            this.dgvListOfMembers.TabIndex = 8;
            // 
            // txtEnterID
            // 
            this.txtEnterID.Location = new System.Drawing.Point(250, 131);
            this.txtEnterID.Name = "txtEnterID";
            this.txtEnterID.Size = new System.Drawing.Size(161, 22);
            this.txtEnterID.TabIndex = 7;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblTitle.Location = new System.Drawing.Point(349, 32);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(180, 34);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "מחיקת בוגר";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // lblEnterID
            // 
            this.lblEnterID.AutoSize = true;
            this.lblEnterID.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterID.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblEnterID.Location = new System.Drawing.Point(478, 132);
            this.lblEnterID.Name = "lblEnterID";
            this.lblEnterID.Size = new System.Drawing.Size(128, 21);
            this.lblEnterID.TabIndex = 5;
            this.lblEnterID.Text = "הזן תעודת זהות ";
            this.lblEnterID.Click += new System.EventHandler(this.lblEnterID_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 101);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // DeleteMemberNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(882, 503);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnDeleteMember);
            this.Controls.Add(this.dgvListOfMembers);
            this.Controls.Add(this.txtEnterID);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblEnterID);
            this.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Name = "DeleteMemberNew";
            this.Text = "DeleteMemberNew";
            this.Load += new System.EventHandler(this.DeleteMemberNew_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListOfMembers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteMember;
        private System.Windows.Forms.DataGridView dgvListOfMembers;
        private System.Windows.Forms.TextBox txtEnterID;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblEnterID;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
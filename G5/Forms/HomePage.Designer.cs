namespace G5.Forms
{
    partial class HomePage
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
            this.label6 = new System.Windows.Forms.Label();
            this.MembersButtonHomeScreen = new System.Windows.Forms.Button();
            this.ParticipantsButtonHomeScreen = new System.Windows.Forms.Button();
            this.ActivitiesButtonHomeScreen = new System.Windows.Forms.Button();
            this.MessegesButtonHomeScreen = new System.Windows.Forms.Button();
            this.getMemberByIDTableAdapter1 = new G5.G5DataSetTableAdapters.GetMemberByIDTableAdapter();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(792, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "ברוך הבא";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // MembersButtonHomeScreen
            // 
            this.MembersButtonHomeScreen.Location = new System.Drawing.Point(617, 149);
            this.MembersButtonHomeScreen.Name = "MembersButtonHomeScreen";
            this.MembersButtonHomeScreen.Size = new System.Drawing.Size(272, 122);
            this.MembersButtonHomeScreen.TabIndex = 6;
            this.MembersButtonHomeScreen.Text = "בוגרים";
            this.MembersButtonHomeScreen.UseVisualStyleBackColor = true;
            this.MembersButtonHomeScreen.Click += new System.EventHandler(this.button1_Click);
            // 
            // ParticipantsButtonHomeScreen
            // 
            this.ParticipantsButtonHomeScreen.Location = new System.Drawing.Point(282, 149);
            this.ParticipantsButtonHomeScreen.Name = "ParticipantsButtonHomeScreen";
            this.ParticipantsButtonHomeScreen.Size = new System.Drawing.Size(282, 122);
            this.ParticipantsButtonHomeScreen.TabIndex = 7;
            this.ParticipantsButtonHomeScreen.Text = "חניגים";
            this.ParticipantsButtonHomeScreen.UseVisualStyleBackColor = true;
            this.ParticipantsButtonHomeScreen.Click += new System.EventHandler(this.ParticipantsButtonHomeScreen_Click);
            // 
            // ActivitiesButtonHomeScreen
            // 
            this.ActivitiesButtonHomeScreen.Location = new System.Drawing.Point(292, 335);
            this.ActivitiesButtonHomeScreen.Name = "ActivitiesButtonHomeScreen";
            this.ActivitiesButtonHomeScreen.Size = new System.Drawing.Size(272, 111);
            this.ActivitiesButtonHomeScreen.TabIndex = 8;
            this.ActivitiesButtonHomeScreen.Text = "פעולות";
            this.ActivitiesButtonHomeScreen.UseVisualStyleBackColor = true;
            this.ActivitiesButtonHomeScreen.Click += new System.EventHandler(this.ActivitiesButtonHomeScreen_Click);
            // 
            // MessegesButtonHomeScreen
            // 
            this.MessegesButtonHomeScreen.Location = new System.Drawing.Point(617, 335);
            this.MessegesButtonHomeScreen.Name = "MessegesButtonHomeScreen";
            this.MessegesButtonHomeScreen.Size = new System.Drawing.Size(261, 111);
            this.MessegesButtonHomeScreen.TabIndex = 9;
            this.MessegesButtonHomeScreen.Text = "הודעות";
            this.MessegesButtonHomeScreen.UseVisualStyleBackColor = true;
            this.MessegesButtonHomeScreen.Click += new System.EventHandler(this.MessegesButtonHomeScreen_Click);
            // 
            // getMemberByIDTableAdapter1
            // 
            this.getMemberByIDTableAdapter1.ClearBeforeFill = true;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 591);
            this.Controls.Add(this.MessegesButtonHomeScreen);
            this.Controls.Add(this.ActivitiesButtonHomeScreen);
            this.Controls.Add(this.ParticipantsButtonHomeScreen);
            this.Controls.Add(this.MembersButtonHomeScreen);
            this.Controls.Add(this.label6);
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button MembersButtonHomeScreen;
        private System.Windows.Forms.Button ParticipantsButtonHomeScreen;
        private System.Windows.Forms.Button ActivitiesButtonHomeScreen;
        private System.Windows.Forms.Button MessegesButtonHomeScreen;
        private G5DataSetTableAdapters.GetMemberByIDTableAdapter getMemberByIDTableAdapter1;
    }
}
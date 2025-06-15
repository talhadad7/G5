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
            this.ParticipantsButtonHomeScreen = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.MembersButtonHomeScreen = new System.Windows.Forms.Button();
            this.ActivitiesButtonHomeScreen = new System.Windows.Forms.Button();
            this.MessegesButtonHomeScreen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ParticipantsButtonHomeScreen
            // 
            this.ParticipantsButtonHomeScreen.Location = new System.Drawing.Point(29, 115);
            this.ParticipantsButtonHomeScreen.Name = "ParticipantsButtonHomeScreen";
            this.ParticipantsButtonHomeScreen.Size = new System.Drawing.Size(247, 110);
            this.ParticipantsButtonHomeScreen.TabIndex = 0;
            this.ParticipantsButtonHomeScreen.Text = "חניכים";
            this.ParticipantsButtonHomeScreen.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(665, 213);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(9, 12);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // MembersButtonHomeScreen
            // 
            this.MembersButtonHomeScreen.Location = new System.Drawing.Point(320, 115);
            this.MembersButtonHomeScreen.Name = "MembersButtonHomeScreen";
            this.MembersButtonHomeScreen.Size = new System.Drawing.Size(241, 111);
            this.MembersButtonHomeScreen.TabIndex = 2;
            this.MembersButtonHomeScreen.Text = "בוגרים";
            this.MembersButtonHomeScreen.UseVisualStyleBackColor = true;
            // 
            // ActivitiesButtonHomeScreen
            // 
            this.ActivitiesButtonHomeScreen.Location = new System.Drawing.Point(582, 123);
            this.ActivitiesButtonHomeScreen.Name = "ActivitiesButtonHomeScreen";
            this.ActivitiesButtonHomeScreen.Size = new System.Drawing.Size(252, 103);
            this.ActivitiesButtonHomeScreen.TabIndex = 3;
            this.ActivitiesButtonHomeScreen.Text = "פעולות";
            this.ActivitiesButtonHomeScreen.UseVisualStyleBackColor = true;
            // 
            // MessegesButtonHomeScreen
            // 
            this.MessegesButtonHomeScreen.Location = new System.Drawing.Point(866, 123);
            this.MessegesButtonHomeScreen.Name = "MessegesButtonHomeScreen";
            this.MessegesButtonHomeScreen.Size = new System.Drawing.Size(262, 105);
            this.MessegesButtonHomeScreen.TabIndex = 4;
            this.MessegesButtonHomeScreen.Text = "הודועות";
            this.MessegesButtonHomeScreen.UseVisualStyleBackColor = true;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 663);
            this.Controls.Add(this.MessegesButtonHomeScreen);
            this.Controls.Add(this.ActivitiesButtonHomeScreen);
            this.Controls.Add(this.MembersButtonHomeScreen);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ParticipantsButtonHomeScreen);
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ParticipantsButtonHomeScreen;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button MembersButtonHomeScreen;
        private System.Windows.Forms.Button ActivitiesButtonHomeScreen;
        private System.Windows.Forms.Button MessegesButtonHomeScreen;
    }
}
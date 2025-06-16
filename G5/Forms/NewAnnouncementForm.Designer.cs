namespace G5
{
    partial class NewAnnouncementForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PublishButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.ContentTextBox = new System.Windows.Forms.TextBox();
            this.AudienceCheckList = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(405, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "פרסום הודעה חדשה";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(859, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "כותרת";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(961, 184);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "תוכן";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(351, 210);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "קהל יעד";
            // 
            // PublishButton
            // 
            this.PublishButton.Location = new System.Drawing.Point(128, 422);
            this.PublishButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PublishButton.Name = "PublishButton";
            this.PublishButton.Size = new System.Drawing.Size(225, 75);
            this.PublishButton.TabIndex = 4;
            this.PublishButton.Text = "פרסום";
            this.PublishButton.UseVisualStyleBackColor = true;
            this.PublishButton.Click += new System.EventHandler(this.PublishButton_Click_1);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(771, 422);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(191, 84);
            this.CancelButton.TabIndex = 5;
            this.CancelButton.Text = "ביטול";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click_1);
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(655, 119);
            this.TitleTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(167, 31);
            this.TitleTextBox.TabIndex = 6;
            // 
            // ContentTextBox
            // 
            this.ContentTextBox.Location = new System.Drawing.Point(560, 184);
            this.ContentTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ContentTextBox.Name = "ContentTextBox";
            this.ContentTextBox.Size = new System.Drawing.Size(328, 31);
            this.ContentTextBox.TabIndex = 7;
            // 
            // AudienceCheckList
            // 
            this.AudienceCheckList.FormattingEnabled = true;
            this.AudienceCheckList.Location = new System.Drawing.Point(85, 161);
            this.AudienceCheckList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AudienceCheckList.Name = "AudienceCheckList";
            this.AudienceCheckList.Size = new System.Drawing.Size(237, 172);
            this.AudienceCheckList.TabIndex = 8;
            // 
            // NewAnnouncementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 562);
            this.Controls.Add(this.AudienceCheckList);
            this.Controls.Add(this.ContentTextBox);
            this.Controls.Add(this.TitleTextBox);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.PublishButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "NewAnnouncementForm";
            this.Text = "NewAnnouncementForm";
            this.Load += new System.EventHandler(this.NewAnnouncementForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button PublishButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.TextBox ContentTextBox;
        private System.Windows.Forms.CheckedListBox AudienceCheckList;
    }
}
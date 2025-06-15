namespace G5
{
    partial class NewProposal
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
            this.ActivityDatePick = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.ActivityComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.AreaComboBox = new System.Windows.Forms.ComboBox();
            this.SendProposalButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.NotesTxtBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.GroupComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(324, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "הצעה חדשה לפעילות";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(724, 140);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "קבוצה:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(324, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "תאריך";
            // 
            // ActivityDatePick
            // 
            this.ActivityDatePick.Location = new System.Drawing.Point(71, 135);
            this.ActivityDatePick.Name = "ActivityDatePick";
            this.ActivityDatePick.Size = new System.Drawing.Size(204, 26);
            this.ActivityDatePick.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(724, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "פעולה";
            // 
            // ActivityComboBox
            // 
            this.ActivityComboBox.FormattingEnabled = true;
            this.ActivityComboBox.Location = new System.Drawing.Point(488, 226);
            this.ActivityComboBox.Name = "ActivityComboBox";
            this.ActivityComboBox.Size = new System.Drawing.Size(186, 28);
            this.ActivityComboBox.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(324, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "איזור פעילות";
            // 
            // AreaComboBox
            // 
            this.AreaComboBox.FormattingEnabled = true;
            this.AreaComboBox.Location = new System.Drawing.Point(56, 226);
            this.AreaComboBox.Name = "AreaComboBox";
            this.AreaComboBox.Size = new System.Drawing.Size(219, 28);
            this.AreaComboBox.TabIndex = 8;
            // 
            // SendProposalButton
            // 
            this.SendProposalButton.Location = new System.Drawing.Point(71, 355);
            this.SendProposalButton.Name = "SendProposalButton";
            this.SendProposalButton.Size = new System.Drawing.Size(156, 56);
            this.SendProposalButton.TabIndex = 9;
            this.SendProposalButton.Text = "שליחת הצעה";
            this.SendProposalButton.UseVisualStyleBackColor = true;
            this.SendProposalButton.Click += new System.EventHandler(this.SendProposalButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(528, 365);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(163, 57);
            this.CancelButton.TabIndex = 10;
            this.CancelButton.Text = "ביטול";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // NotesTxtBox
            // 
            this.NotesTxtBox.Location = new System.Drawing.Point(55, 310);
            this.NotesTxtBox.Name = "NotesTxtBox";
            this.NotesTxtBox.Size = new System.Drawing.Size(645, 26);
            this.NotesTxtBox.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(724, 316);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "הערות";
            // 
            // GroupComboBox
            // 
            this.GroupComboBox.FormattingEnabled = true;
            this.GroupComboBox.Location = new System.Drawing.Point(488, 140);
            this.GroupComboBox.Name = "GroupComboBox";
            this.GroupComboBox.Size = new System.Drawing.Size(186, 28);
            this.GroupComboBox.TabIndex = 13;
            // 
            // NewProposal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GroupComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.NotesTxtBox);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SendProposalButton);
            this.Controls.Add(this.AreaComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ActivityComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ActivityDatePick);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NewProposal";
            this.Text = "NewProposal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker ActivityDatePick;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ActivityComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox AreaComboBox;
        private System.Windows.Forms.Button SendProposalButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.TextBox NotesTxtBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox GroupComboBox;
    }
}
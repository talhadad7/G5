namespace G5.Forms
{
    partial class MainPageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPageForm));
            this.MembersButton = new System.Windows.Forms.Button();
            this.ProposalButton = new System.Windows.Forms.Button();
            this.ParticipantsButton = new System.Windows.Forms.Button();
            this.MessagesButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MembersButton
            // 
            this.MembersButton.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MembersButton.ForeColor = System.Drawing.Color.RoyalBlue;
            this.MembersButton.Location = new System.Drawing.Point(306, 242);
            this.MembersButton.Margin = new System.Windows.Forms.Padding(2);
            this.MembersButton.Name = "MembersButton";
            this.MembersButton.Size = new System.Drawing.Size(147, 77);
            this.MembersButton.TabIndex = 0;
            this.MembersButton.Text = "בוגרים";
            this.MembersButton.UseVisualStyleBackColor = true;
            this.MembersButton.Click += new System.EventHandler(this.MembersButton_Click);
            // 
            // ProposalButton
            // 
            this.ProposalButton.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProposalButton.ForeColor = System.Drawing.Color.RoyalBlue;
            this.ProposalButton.Location = new System.Drawing.Point(471, 242);
            this.ProposalButton.Margin = new System.Windows.Forms.Padding(2);
            this.ProposalButton.Name = "ProposalButton";
            this.ProposalButton.Size = new System.Drawing.Size(155, 77);
            this.ProposalButton.TabIndex = 1;
            this.ProposalButton.Text = "הגשת בקשה לפעילות";
            this.ProposalButton.UseVisualStyleBackColor = true;
            this.ProposalButton.Click += new System.EventHandler(this.ProposalButton_Click);
            // 
            // ParticipantsButton
            // 
            this.ParticipantsButton.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ParticipantsButton.ForeColor = System.Drawing.Color.RoyalBlue;
            this.ParticipantsButton.Location = new System.Drawing.Point(153, 242);
            this.ParticipantsButton.Margin = new System.Windows.Forms.Padding(2);
            this.ParticipantsButton.Name = "ParticipantsButton";
            this.ParticipantsButton.Size = new System.Drawing.Size(135, 77);
            this.ParticipantsButton.TabIndex = 2;
            this.ParticipantsButton.Text = "חניכים";
            this.ParticipantsButton.UseVisualStyleBackColor = true;
            this.ParticipantsButton.Click += new System.EventHandler(this.ParticipantsButton_Click);
            // 
            // MessagesButton
            // 
            this.MessagesButton.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessagesButton.ForeColor = System.Drawing.Color.RoyalBlue;
            this.MessagesButton.Location = new System.Drawing.Point(656, 240);
            this.MessagesButton.Margin = new System.Windows.Forms.Padding(2);
            this.MessagesButton.Name = "MessagesButton";
            this.MessagesButton.Size = new System.Drawing.Size(146, 79);
            this.MessagesButton.TabIndex = 3;
            this.MessagesButton.Text = "הודעות";
            this.MessagesButton.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(14, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 126);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // MainPageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(992, 629);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.MessagesButton);
            this.Controls.Add(this.ParticipantsButton);
            this.Controls.Add(this.ProposalButton);
            this.Controls.Add(this.MembersButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainPageForm";
            this.Text = "MainPageForm";
            this.Load += new System.EventHandler(this.MainPageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button MembersButton;
        private System.Windows.Forms.Button ProposalButton;
        private System.Windows.Forms.Button ParticipantsButton;
        private System.Windows.Forms.Button MessagesButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
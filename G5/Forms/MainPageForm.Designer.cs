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
            this.ActivityButton = new System.Windows.Forms.Button();
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
            this.MembersButton.Location = new System.Drawing.Point(408, 303);
            this.MembersButton.Name = "MembersButton";
            this.MembersButton.Size = new System.Drawing.Size(196, 67);
            this.MembersButton.TabIndex = 0;
            this.MembersButton.Text = "בוגרים";
            this.MembersButton.UseVisualStyleBackColor = true;
            this.MembersButton.Click += new System.EventHandler(this.MembersButton_Click);
            // 
            // ActivityButton
            // 
            this.ActivityButton.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActivityButton.ForeColor = System.Drawing.Color.RoyalBlue;
            this.ActivityButton.Location = new System.Drawing.Point(628, 303);
            this.ActivityButton.Name = "ActivityButton";
            this.ActivityButton.Size = new System.Drawing.Size(207, 67);
            this.ActivityButton.TabIndex = 1;
            this.ActivityButton.Text = "פעולות";
            this.ActivityButton.UseVisualStyleBackColor = true;
//            this.ActivityButton.ContextMenuStripChanged += new System.EventHandler(this.ActivitiesButton_Click);
            this.ActivityButton.Click += new System.EventHandler(this.ActivityButton_Click);
            // 
            // ParticipantsButton
            // 
            this.ParticipantsButton.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ParticipantsButton.ForeColor = System.Drawing.Color.RoyalBlue;
            this.ParticipantsButton.Location = new System.Drawing.Point(204, 303);
            this.ParticipantsButton.Name = "ParticipantsButton";
            this.ParticipantsButton.Size = new System.Drawing.Size(180, 67);
            this.ParticipantsButton.TabIndex = 2;
            this.ParticipantsButton.Text = "חניכים";
            this.ParticipantsButton.UseVisualStyleBackColor = true;
            this.ParticipantsButton.Click += new System.EventHandler(this.ParticipantsButton_Click);
            // 
            // MessagesButton
            // 
            this.MessagesButton.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessagesButton.ForeColor = System.Drawing.Color.RoyalBlue;
            this.MessagesButton.Location = new System.Drawing.Point(874, 300);
            this.MessagesButton.Name = "MessagesButton";
            this.MessagesButton.Size = new System.Drawing.Size(195, 70);
            this.MessagesButton.TabIndex = 3;
            this.MessagesButton.Text = "הודעות";
            this.MessagesButton.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(18, 19);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(190, 158);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // MainPageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(1323, 786);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.MessagesButton);
            this.Controls.Add(this.ParticipantsButton);
            this.Controls.Add(this.ActivityButton);
            this.Controls.Add(this.MembersButton);
            this.Name = "MainPageForm";
            this.Text = "MainPageForm";
            this.Load += new System.EventHandler(this.MainPageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button MembersButton;
        private System.Windows.Forms.Button ActivityButton;
        private System.Windows.Forms.Button ParticipantsButton;
        private System.Windows.Forms.Button MessagesButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
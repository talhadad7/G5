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
            this.button2 = new System.Windows.Forms.Button();
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
            this.MembersButton.Location = new System.Drawing.Point(272, 194);
            this.MembersButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MembersButton.Name = "MembersButton";
            this.MembersButton.Size = new System.Drawing.Size(131, 43);
            this.MembersButton.TabIndex = 0;
            this.MembersButton.Text = "בוגרים";
            this.MembersButton.UseVisualStyleBackColor = true;
            this.MembersButton.Click += new System.EventHandler(this.MembersButton_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.button2.Location = new System.Drawing.Point(419, 194);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 43);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // ParticipantsButton
            // 
            this.ParticipantsButton.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ParticipantsButton.ForeColor = System.Drawing.Color.RoyalBlue;
            this.ParticipantsButton.Location = new System.Drawing.Point(136, 194);
            this.ParticipantsButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ParticipantsButton.Name = "ParticipantsButton";
            this.ParticipantsButton.Size = new System.Drawing.Size(120, 43);
            this.ParticipantsButton.TabIndex = 2;
            this.ParticipantsButton.Text = "חניכים";
            this.ParticipantsButton.UseVisualStyleBackColor = true;
            this.ParticipantsButton.Click += new System.EventHandler(this.ParticipantsButton_Click);
            // 
            // MessagesButton
            // 
            this.MessagesButton.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessagesButton.ForeColor = System.Drawing.Color.RoyalBlue;
            this.MessagesButton.Location = new System.Drawing.Point(583, 192);
            this.MessagesButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MessagesButton.Name = "MessagesButton";
            this.MessagesButton.Size = new System.Drawing.Size(130, 45);
            this.MessagesButton.TabIndex = 3;
            this.MessagesButton.Text = "הודעות";
            this.MessagesButton.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 101);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // MainPageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(882, 503);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.MessagesButton);
            this.Controls.Add(this.ParticipantsButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.MembersButton);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainPageForm";
            this.Text = "MainPageForm";
            this.Load += new System.EventHandler(this.MainPageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button MembersButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button ParticipantsButton;
        private System.Windows.Forms.Button MessagesButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
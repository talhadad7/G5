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
            this.MembersButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ParticipantsButton = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MembersButton
            // 
            this.MembersButton.Location = new System.Drawing.Point(173, 80);
            this.MembersButton.Name = "MembersButton";
            this.MembersButton.Size = new System.Drawing.Size(183, 78);
            this.MembersButton.TabIndex = 0;
            this.MembersButton.Text = "בוגרים";
            this.MembersButton.UseVisualStyleBackColor = true;
            this.MembersButton.Click += new System.EventHandler(this.MembersButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(362, 84);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(198, 76);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // ParticipantsButton
            // 
            this.ParticipantsButton.Location = new System.Drawing.Point(12, 77);
            this.ParticipantsButton.Name = "ParticipantsButton";
            this.ParticipantsButton.Size = new System.Drawing.Size(149, 90);
            this.ParticipantsButton.TabIndex = 2;
            this.ParticipantsButton.Text = "חניכים";
            this.ParticipantsButton.UseVisualStyleBackColor = true;
            this.ParticipantsButton.Click += new System.EventHandler(this.ParticipantsButton_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(612, 84);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(195, 70);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // MainPageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.ParticipantsButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.MembersButton);
            this.Name = "MainPageForm";
            this.Text = "MainPageForm";
            this.Load += new System.EventHandler(this.MainPageForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button MembersButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button ParticipantsButton;
        private System.Windows.Forms.Button button4;
    }
}
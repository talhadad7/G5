namespace G5.Forms
{
    partial class NewParticiapant
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
                components.Dispose();//
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
            this.SaveParticipantCreation = new System.Windows.Forms.Button();
            this.CancelParticipantCreation = new System.Windows.Forms.Button();
            this.ParticipantIdLable = new System.Windows.Forms.Label();
            this.FirstNameLable = new System.Windows.Forms.Label();
            this.ParticipantLastName = new System.Windows.Forms.Label();
            this.ParticipantId = new System.Windows.Forms.TextBox();
            this.ParticipantAdress = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.ParticipantFirstName = new System.Windows.Forms.TextBox();
            this.ParticipantBirthDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.ParticipantGenderCombo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.AgeGroupCombo = new System.Windows.Forms.ComboBox();
            this.ParticipantPaymentStatusCheckBox = new System.Windows.Forms.CheckBox();
            this.ParticipantJoinDATE = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.PatricipantMedicalNotes = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SaveParticipantCreation
            // 
            this.SaveParticipantCreation.Location = new System.Drawing.Point(21, 294);
            this.SaveParticipantCreation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SaveParticipantCreation.Name = "SaveParticipantCreation";
            this.SaveParticipantCreation.Size = new System.Drawing.Size(92, 43);
            this.SaveParticipantCreation.TabIndex = 0;
            this.SaveParticipantCreation.Text = "שמור";
            this.SaveParticipantCreation.UseVisualStyleBackColor = true;
            this.SaveParticipantCreation.Click += new System.EventHandler(this.SaveParticipantCreation_Click);
            // 
            // CancelParticipantCreation
            // 
            this.CancelParticipantCreation.Location = new System.Drawing.Point(132, 294);
            this.CancelParticipantCreation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CancelParticipantCreation.Name = "CancelParticipantCreation";
            this.CancelParticipantCreation.Size = new System.Drawing.Size(130, 43);
            this.CancelParticipantCreation.TabIndex = 1;
            this.CancelParticipantCreation.Text = "בטל ";
            this.CancelParticipantCreation.UseVisualStyleBackColor = true;
            this.CancelParticipantCreation.Click += new System.EventHandler(this.CancelParticipantCreation_Click);
            // 
            // ParticipantIdLable
            // 
            this.ParticipantIdLable.AutoSize = true;
            this.ParticipantIdLable.Location = new System.Drawing.Point(488, 68);
            this.ParticipantIdLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ParticipantIdLable.Name = "ParticipantIdLable";
            this.ParticipantIdLable.Size = new System.Drawing.Size(87, 20);
            this.ParticipantIdLable.TabIndex = 2;
            this.ParticipantIdLable.Text = "תעודת זהות";
            // 
            // FirstNameLable
            // 
            this.FirstNameLable.AutoSize = true;
            this.FirstNameLable.Location = new System.Drawing.Point(488, 105);
            this.FirstNameLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FirstNameLable.Name = "FirstNameLable";
            this.FirstNameLable.Size = new System.Drawing.Size(65, 20);
            this.FirstNameLable.TabIndex = 3;
            this.FirstNameLable.Text = "שם פרטי";
            // 
            // ParticipantLastName
            // 
            this.ParticipantLastName.AutoSize = true;
            this.ParticipantLastName.Location = new System.Drawing.Point(488, 142);
            this.ParticipantLastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ParticipantLastName.Name = "ParticipantLastName";
            this.ParticipantLastName.Size = new System.Drawing.Size(81, 20);
            this.ParticipantLastName.TabIndex = 4;
            this.ParticipantLastName.Text = "שם משפחה";
            // 
            // ParticipantId
            // 
            this.ParticipantId.Location = new System.Drawing.Point(325, 68);
            this.ParticipantId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ParticipantId.Name = "ParticipantId";
            this.ParticipantId.Size = new System.Drawing.Size(139, 26);
            this.ParticipantId.TabIndex = 5;
            this.ParticipantId.Click += new System.EventHandler(this.ParticipantId_Click);
            this.ParticipantId.TextChanged += new System.EventHandler(this.ParticipantId_TextChanged);
            // 
            // ParticipantAdress
            // 
            this.ParticipantAdress.Location = new System.Drawing.Point(325, 261);
            this.ParticipantAdress.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ParticipantAdress.Name = "ParticipantAdress";
            this.ParticipantAdress.Size = new System.Drawing.Size(138, 26);
            this.ParticipantAdress.TabIndex = 6;
            this.ParticipantAdress.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(325, 142);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(139, 26);
            this.textBox3.TabIndex = 7;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // ParticipantFirstName
            // 
            this.ParticipantFirstName.Location = new System.Drawing.Point(325, 105);
            this.ParticipantFirstName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ParticipantFirstName.Name = "ParticipantFirstName";
            this.ParticipantFirstName.Size = new System.Drawing.Size(139, 26);
            this.ParticipantFirstName.TabIndex = 8;
            this.ParticipantFirstName.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // ParticipantBirthDate
            // 
            this.ParticipantBirthDate.Location = new System.Drawing.Point(325, 181);
            this.ParticipantBirthDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ParticipantBirthDate.Name = "ParticipantBirthDate";
            this.ParticipantBirthDate.Size = new System.Drawing.Size(138, 26);
            this.ParticipantBirthDate.TabIndex = 10;
            this.ParticipantBirthDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(489, 185);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "תאריך לידה";
            this.label1.Click += new System.EventHandler(this.ParticipantId_TextChanged);
            // 
            // ParticipantGenderCombo
            // 
            this.ParticipantGenderCombo.FormattingEnabled = true;
            this.ParticipantGenderCombo.Location = new System.Drawing.Point(324, 220);
            this.ParticipantGenderCombo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ParticipantGenderCombo.Name = "ParticipantGenderCombo";
            this.ParticipantGenderCombo.Size = new System.Drawing.Size(139, 28);
            this.ParticipantGenderCombo.TabIndex = 12;
            this.ParticipantGenderCombo.SelectedIndexChanged += new System.EventHandler(this.ParticipantGenderCombo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(489, 222);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "מגדר";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(488, 306);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "קבוצת גיל";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(489, 263);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "כתובת";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(190, 207);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "דמי חבר שולמו";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(182, 70);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "תאריך הצטפרות";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(164, 116);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "מספר טלפון - איש קשר";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // AgeGroupCombo
            // 
            this.AgeGroupCombo.FormattingEnabled = true;
            this.AgeGroupCombo.Location = new System.Drawing.Point(325, 300);
            this.AgeGroupCombo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AgeGroupCombo.Name = "AgeGroupCombo";
            this.AgeGroupCombo.Size = new System.Drawing.Size(138, 28);
            this.AgeGroupCombo.TabIndex = 20;
            this.AgeGroupCombo.SelectedIndexChanged += new System.EventHandler(this.AgeGroupCombo_SelectedIndexChanged);
            // 
            // ParticipantPaymentStatusCheckBox
            // 
            this.ParticipantPaymentStatusCheckBox.AutoSize = true;
            this.ParticipantPaymentStatusCheckBox.Location = new System.Drawing.Point(103, 207);
            this.ParticipantPaymentStatusCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ParticipantPaymentStatusCheckBox.Name = "ParticipantPaymentStatusCheckBox";
            this.ParticipantPaymentStatusCheckBox.Size = new System.Drawing.Size(22, 21);
            this.ParticipantPaymentStatusCheckBox.TabIndex = 21;
            this.ParticipantPaymentStatusCheckBox.UseVisualStyleBackColor = true;
            // 
            // ParticipantJoinDATE
            // 
            this.ParticipantJoinDATE.Location = new System.Drawing.Point(9, 70);
            this.ParticipantJoinDATE.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ParticipantJoinDATE.Name = "ParticipantJoinDATE";
            this.ParticipantJoinDATE.Size = new System.Drawing.Size(151, 26);
            this.ParticipantJoinDATE.TabIndex = 22;
            this.ParticipantJoinDATE.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 114);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(151, 26);
            this.textBox1.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(128, 162);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(188, 20);
            this.label8.TabIndex = 24;
            this.label8.Text = "הערות רפואיות - אם קיימות";
            // 
            // PatricipantMedicalNotes
            // 
            this.PatricipantMedicalNotes.Location = new System.Drawing.Point(9, 158);
            this.PatricipantMedicalNotes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PatricipantMedicalNotes.Name = "PatricipantMedicalNotes";
            this.PatricipantMedicalNotes.Size = new System.Drawing.Size(116, 26);
            this.PatricipantMedicalNotes.TabIndex = 25;
            this.PatricipantMedicalNotes.TextChanged += new System.EventHandler(this.PatricipantMedicalNotes_TextChanged);
            // 
            // NewParticiapant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 360);
            this.Controls.Add(this.PatricipantMedicalNotes);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ParticipantJoinDATE);
            this.Controls.Add(this.ParticipantPaymentStatusCheckBox);
            this.Controls.Add(this.AgeGroupCombo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ParticipantGenderCombo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ParticipantBirthDate);
            this.Controls.Add(this.ParticipantFirstName);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.ParticipantAdress);
            this.Controls.Add(this.ParticipantId);
            this.Controls.Add(this.ParticipantLastName);
            this.Controls.Add(this.FirstNameLable);
            this.Controls.Add(this.ParticipantIdLable);
            this.Controls.Add(this.CancelParticipantCreation);
            this.Controls.Add(this.SaveParticipantCreation);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "NewParticiapant";
            this.Text = "NewParticiapant";
            this.Load += new System.EventHandler(this.NewParticiapant_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveParticipantCreation;
        private System.Windows.Forms.Button CancelParticipantCreation;
        private System.Windows.Forms.Label ParticipantIdLable;
        private System.Windows.Forms.Label FirstNameLable;
        private System.Windows.Forms.Label ParticipantLastName;
        private System.Windows.Forms.TextBox ParticipantId;
        private System.Windows.Forms.TextBox ParticipantAdress;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox ParticipantFirstName;
        private System.Windows.Forms.DateTimePicker ParticipantBirthDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ParticipantGenderCombo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox AgeGroupCombo;
        private System.Windows.Forms.CheckBox ParticipantPaymentStatusCheckBox;
        private System.Windows.Forms.DateTimePicker ParticipantJoinDATE;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox PatricipantMedicalNotes;
    }
}
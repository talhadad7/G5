namespace G5
{
    partial class Form1
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
            this.EmergencyContact = new System.Windows.Forms.Label();
            this.Payment = new System.Windows.Forms.Label();
            this.JoinDate = new System.Windows.Forms.Label();
            this.MemberType = new System.Windows.Forms.Label();
            this.TrainingProccess = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.Label();
            this.PrivateName = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.BirthDate = new System.Windows.Forms.Label();
            this.Seniority = new System.Windows.Forms.Label();
            this.Gender = new System.Windows.Forms.Label();
            this.Address = new System.Windows.Forms.Label();
            this.FirstNameTXT = new System.Windows.Forms.TextBox();
            this.LastNameTXT = new System.Windows.Forms.TextBox();
            this.IDTXT = new System.Windows.Forms.TextBox();
            this.AddressTXT = new System.Windows.Forms.TextBox();
            this.BirthDatePICK = new System.Windows.Forms.DateTimePicker();
            this.JoinDatePCK = new System.Windows.Forms.DateTimePicker();
            this.GenderCombo = new System.Windows.Forms.ComboBox();
            this.MemberTypeCOMBOX = new System.Windows.Forms.ComboBox();
            this.TrainingProccessCombox = new System.Windows.Forms.ComboBox();
            this.EmerConTXT = new System.Windows.Forms.TextBox();
            this.PaymentCHK = new System.Windows.Forms.CheckBox();
            this.SeniorityNumeric = new System.Windows.Forms.NumericUpDown();
            this.Email = new System.Windows.Forms.Label();
            this.Phone = new System.Windows.Forms.Label();
            this.EmailTXT = new System.Windows.Forms.TextBox();
            this.PhoneTXT = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.SeniorityNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(299, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "צור בוגר חדש";
            // 
            // EmergencyContact
            // 
            this.EmergencyContact.AutoSize = true;
            this.EmergencyContact.Location = new System.Drawing.Point(254, 76);
            this.EmergencyContact.Name = "EmergencyContact";
            this.EmergencyContact.Size = new System.Drawing.Size(91, 16);
            this.EmergencyContact.TabIndex = 1;
            this.EmergencyContact.Text = "איש קשר חירום";
            this.EmergencyContact.Click += new System.EventHandler(this.label2_Click);
            // 
            // Payment
            // 
            this.Payment.AutoSize = true;
            this.Payment.Location = new System.Drawing.Point(299, 112);
            this.Payment.Name = "Payment";
            this.Payment.Size = new System.Drawing.Size(46, 16);
            this.Payment.TabIndex = 2;
            this.Payment.Text = "תשלום";
            // 
            // JoinDate
            // 
            this.JoinDate.AutoSize = true;
            this.JoinDate.Location = new System.Drawing.Point(254, 154);
            this.JoinDate.Name = "JoinDate";
            this.JoinDate.Size = new System.Drawing.Size(98, 16);
            this.JoinDate.TabIndex = 3;
            this.JoinDate.Text = "תאריך הצטרפות";
            // 
            // MemberType
            // 
            this.MemberType.AutoSize = true;
            this.MemberType.Location = new System.Drawing.Point(280, 191);
            this.MemberType.Name = "MemberType";
            this.MemberType.Size = new System.Drawing.Size(65, 16);
            this.MemberType.TabIndex = 4;
            this.MemberType.Text = "סוג תפקיד";
            // 
            // TrainingProccess
            // 
            this.TrainingProccess.AutoSize = true;
            this.TrainingProccess.Location = new System.Drawing.Point(258, 226);
            this.TrainingProccess.Name = "TrainingProccess";
            this.TrainingProccess.Size = new System.Drawing.Size(87, 16);
            this.TrainingProccess.TabIndex = 5;
            this.TrainingProccess.Text = "תהליך הכשרה";
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.Location = new System.Drawing.Point(616, 115);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(67, 16);
            this.LastName.TabIndex = 6;
            this.LastName.Text = "שם משפחה";
            // 
            // PrivateName
            // 
            this.PrivateName.AutoSize = true;
            this.PrivateName.Location = new System.Drawing.Point(629, 79);
            this.PrivateName.Name = "PrivateName";
            this.PrivateName.Size = new System.Drawing.Size(54, 16);
            this.PrivateName.TabIndex = 7;
            this.PrivateName.Text = "שם פרטי";
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(607, 151);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(76, 16);
            this.ID.TabIndex = 8;
            this.ID.Text = "תעודת זהות";
            // 
            // BirthDate
            // 
            this.BirthDate.AutoSize = true;
            this.BirthDate.Location = new System.Drawing.Point(608, 185);
            this.BirthDate.Name = "BirthDate";
            this.BirthDate.Size = new System.Drawing.Size(76, 16);
            this.BirthDate.TabIndex = 9;
            this.BirthDate.Text = "תאריך לידה";
            this.BirthDate.Click += new System.EventHandler(this.label10_Click);
            // 
            // Seniority
            // 
            this.Seniority.AutoSize = true;
            this.Seniority.Location = new System.Drawing.Point(317, 262);
            this.Seniority.Name = "Seniority";
            this.Seniority.Size = new System.Drawing.Size(28, 16);
            this.Seniority.TabIndex = 10;
            this.Seniority.Text = "ותק";
            // 
            // Gender
            // 
            this.Gender.AutoSize = true;
            this.Gender.Location = new System.Drawing.Point(647, 226);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(36, 16);
            this.Gender.TabIndex = 11;
            this.Gender.Text = "מגדר";
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Location = new System.Drawing.Point(638, 265);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(45, 16);
            this.Address.TabIndex = 12;
            this.Address.Text = "כתובת";
            this.Address.Click += new System.EventHandler(this.label13_Click);
            // 
            // FirstNameTXT
            // 
            this.FirstNameTXT.Location = new System.Drawing.Point(366, 73);
            this.FirstNameTXT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FirstNameTXT.Name = "FirstNameTXT";
            this.FirstNameTXT.Size = new System.Drawing.Size(204, 22);
            this.FirstNameTXT.TabIndex = 13;
            // 
            // LastNameTXT
            // 
            this.LastNameTXT.Location = new System.Drawing.Point(366, 109);
            this.LastNameTXT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LastNameTXT.Name = "LastNameTXT";
            this.LastNameTXT.Size = new System.Drawing.Size(204, 22);
            this.LastNameTXT.TabIndex = 14;
            // 
            // IDTXT
            // 
            this.IDTXT.Location = new System.Drawing.Point(366, 148);
            this.IDTXT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IDTXT.Name = "IDTXT";
            this.IDTXT.Size = new System.Drawing.Size(204, 22);
            this.IDTXT.TabIndex = 15;
            // 
            // AddressTXT
            // 
            this.AddressTXT.Location = new System.Drawing.Point(366, 259);
            this.AddressTXT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddressTXT.Name = "AddressTXT";
            this.AddressTXT.Size = new System.Drawing.Size(204, 22);
            this.AddressTXT.TabIndex = 16;
            // 
            // BirthDatePICK
            // 
            this.BirthDatePICK.Location = new System.Drawing.Point(366, 185);
            this.BirthDatePICK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BirthDatePICK.Name = "BirthDatePICK";
            this.BirthDatePICK.Size = new System.Drawing.Size(225, 22);
            this.BirthDatePICK.TabIndex = 17;
            this.BirthDatePICK.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // JoinDatePCK
            // 
            this.JoinDatePCK.Location = new System.Drawing.Point(21, 149);
            this.JoinDatePCK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.JoinDatePCK.Name = "JoinDatePCK";
            this.JoinDatePCK.Size = new System.Drawing.Size(227, 22);
            this.JoinDatePCK.TabIndex = 18;
            // 
            // GenderCombo
            // 
            this.GenderCombo.FormattingEnabled = true;
            this.GenderCombo.Location = new System.Drawing.Point(366, 223);
            this.GenderCombo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GenderCombo.Name = "GenderCombo";
            this.GenderCombo.Size = new System.Drawing.Size(204, 24);
            this.GenderCombo.TabIndex = 19;
            // 
            // MemberTypeCOMBOX
            // 
            this.MemberTypeCOMBOX.FormattingEnabled = true;
            this.MemberTypeCOMBOX.Location = new System.Drawing.Point(21, 191);
            this.MemberTypeCOMBOX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MemberTypeCOMBOX.Name = "MemberTypeCOMBOX";
            this.MemberTypeCOMBOX.Size = new System.Drawing.Size(227, 24);
            this.MemberTypeCOMBOX.TabIndex = 20;
            // 
            // TrainingProccessCombox
            // 
            this.TrainingProccessCombox.FormattingEnabled = true;
            this.TrainingProccessCombox.Location = new System.Drawing.Point(21, 226);
            this.TrainingProccessCombox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TrainingProccessCombox.Name = "TrainingProccessCombox";
            this.TrainingProccessCombox.Size = new System.Drawing.Size(227, 24);
            this.TrainingProccessCombox.TabIndex = 21;
            // 
            // EmerConTXT
            // 
            this.EmerConTXT.Location = new System.Drawing.Point(21, 73);
            this.EmerConTXT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EmerConTXT.Name = "EmerConTXT";
            this.EmerConTXT.Size = new System.Drawing.Size(220, 22);
            this.EmerConTXT.TabIndex = 22;
            // 
            // PaymentCHK
            // 
            this.PaymentCHK.AutoSize = true;
            this.PaymentCHK.Location = new System.Drawing.Point(223, 112);
            this.PaymentCHK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PaymentCHK.Name = "PaymentCHK";
            this.PaymentCHK.Size = new System.Drawing.Size(18, 17);
            this.PaymentCHK.TabIndex = 23;
            this.PaymentCHK.UseVisualStyleBackColor = true;
            this.PaymentCHK.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // SeniorityNumeric
            // 
            this.SeniorityNumeric.Location = new System.Drawing.Point(150, 265);
            this.SeniorityNumeric.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SeniorityNumeric.Name = "SeniorityNumeric";
            this.SeniorityNumeric.Size = new System.Drawing.Size(98, 22);
            this.SeniorityNumeric.TabIndex = 24;
            this.SeniorityNumeric.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(312, 303);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(33, 16);
            this.Email.TabIndex = 25;
            this.Email.Text = "מייל";
            // 
            // Phone
            // 
            this.Phone.AutoSize = true;
            this.Phone.Location = new System.Drawing.Point(607, 300);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(73, 16);
            this.Phone.TabIndex = 26;
            this.Phone.Text = "מספר טלפון";
            // 
            // EmailTXT
            // 
            this.EmailTXT.Location = new System.Drawing.Point(21, 294);
            this.EmailTXT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EmailTXT.Name = "EmailTXT";
            this.EmailTXT.Size = new System.Drawing.Size(227, 22);
            this.EmailTXT.TabIndex = 27;
            this.EmailTXT.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // PhoneTXT
            // 
            this.PhoneTXT.Location = new System.Drawing.Point(366, 300);
            this.PhoneTXT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PhoneTXT.Name = "PhoneTXT";
            this.PhoneTXT.Size = new System.Drawing.Size(204, 22);
            this.PhoneTXT.TabIndex = 28;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.PhoneTXT);
            this.Controls.Add(this.EmailTXT);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.SeniorityNumeric);
            this.Controls.Add(this.PaymentCHK);
            this.Controls.Add(this.EmerConTXT);
            this.Controls.Add(this.TrainingProccessCombox);
            this.Controls.Add(this.MemberTypeCOMBOX);
            this.Controls.Add(this.GenderCombo);
            this.Controls.Add(this.JoinDatePCK);
            this.Controls.Add(this.BirthDatePICK);
            this.Controls.Add(this.AddressTXT);
            this.Controls.Add(this.IDTXT);
            this.Controls.Add(this.LastNameTXT);
            this.Controls.Add(this.FirstNameTXT);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.Seniority);
            this.Controls.Add(this.BirthDate);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.PrivateName);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.TrainingProccess);
            this.Controls.Add(this.MemberType);
            this.Controls.Add(this.JoinDate);
            this.Controls.Add(this.Payment);
            this.Controls.Add(this.EmergencyContact);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SeniorityNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label EmergencyContact;
        private System.Windows.Forms.Label Payment;
        private System.Windows.Forms.Label JoinDate;
        private System.Windows.Forms.Label MemberType;
        private System.Windows.Forms.Label TrainingProccess;
        private System.Windows.Forms.Label LastName;
        private System.Windows.Forms.Label PrivateName;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label BirthDate;
        private System.Windows.Forms.Label Seniority;
        private System.Windows.Forms.Label Gender;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.TextBox FirstNameTXT;
        private System.Windows.Forms.TextBox LastNameTXT;
        private System.Windows.Forms.TextBox IDTXT;
        private System.Windows.Forms.TextBox AddressTXT;
        private System.Windows.Forms.DateTimePicker BirthDatePICK;
        private System.Windows.Forms.DateTimePicker JoinDatePCK;
        private System.Windows.Forms.ComboBox GenderCombo;
        private System.Windows.Forms.ComboBox MemberTypeCOMBOX;
        private System.Windows.Forms.ComboBox TrainingProccessCombox;
        private System.Windows.Forms.TextBox EmerConTXT;
        private System.Windows.Forms.CheckBox PaymentCHK;
        private System.Windows.Forms.NumericUpDown SeniorityNumeric;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label Phone;
        private System.Windows.Forms.TextBox EmailTXT;
        private System.Windows.Forms.TextBox PhoneTXT;
    }
}
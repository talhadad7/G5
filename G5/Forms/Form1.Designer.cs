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
            this.CreateMemberButton = new System.Windows.Forms.Button();
            this.ReturnFromCreateMember = new System.Windows.Forms.Button();
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
            this.EmergencyContact.Location = new System.Drawing.Point(252, 63);
            this.EmergencyContact.Name = "EmergencyContact";
            this.EmergencyContact.Size = new System.Drawing.Size(91, 16);
            this.EmergencyContact.TabIndex = 1;
            this.EmergencyContact.Text = "איש קשר חירום";
            this.EmergencyContact.Click += new System.EventHandler(this.label2_Click);
            // 
            // Payment
            // 
            this.Payment.AutoSize = true;
            this.Payment.Location = new System.Drawing.Point(297, 87);
            this.Payment.Name = "Payment";
            this.Payment.Size = new System.Drawing.Size(46, 16);
            this.Payment.TabIndex = 2;
            this.Payment.Text = "תשלום";
            // 
            // JoinDate
            // 
            this.JoinDate.AutoSize = true;
            this.JoinDate.Location = new System.Drawing.Point(245, 116);
            this.JoinDate.Name = "JoinDate";
            this.JoinDate.Size = new System.Drawing.Size(98, 16);
            this.JoinDate.TabIndex = 3;
            this.JoinDate.Text = "תאריך הצטרפות";
            // 
            // MemberType
            // 
            this.MemberType.AutoSize = true;
            this.MemberType.Location = new System.Drawing.Point(278, 148);
            this.MemberType.Name = "MemberType";
            this.MemberType.Size = new System.Drawing.Size(65, 16);
            this.MemberType.TabIndex = 4;
            this.MemberType.Text = "סוג תפקיד";
            // 
            // TrainingProccess
            // 
            this.TrainingProccess.AutoSize = true;
            this.TrainingProccess.Location = new System.Drawing.Point(256, 174);
            this.TrainingProccess.Name = "TrainingProccess";
            this.TrainingProccess.Size = new System.Drawing.Size(87, 16);
            this.TrainingProccess.TabIndex = 5;
            this.TrainingProccess.Text = "תהליך הכשרה";
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.Location = new System.Drawing.Point(632, 87);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(67, 16);
            this.LastName.TabIndex = 6;
            this.LastName.Text = "שם משפחה";
            // 
            // PrivateName
            // 
            this.PrivateName.AutoSize = true;
            this.PrivateName.Location = new System.Drawing.Point(645, 60);
            this.PrivateName.Name = "PrivateName";
            this.PrivateName.Size = new System.Drawing.Size(54, 16);
            this.PrivateName.TabIndex = 7;
            this.PrivateName.Text = "שם פרטי";
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(623, 119);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(76, 16);
            this.ID.TabIndex = 8;
            this.ID.Text = "תעודת זהות";
            // 
            // BirthDate
            // 
            this.BirthDate.AutoSize = true;
            this.BirthDate.Location = new System.Drawing.Point(623, 148);
            this.BirthDate.Name = "BirthDate";
            this.BirthDate.Size = new System.Drawing.Size(76, 16);
            this.BirthDate.TabIndex = 9;
            this.BirthDate.Text = "תאריך לידה";
            this.BirthDate.Click += new System.EventHandler(this.label10_Click);
            // 
            // Seniority
            // 
            this.Seniority.AutoSize = true;
            this.Seniority.Location = new System.Drawing.Point(315, 198);
            this.Seniority.Name = "Seniority";
            this.Seniority.Size = new System.Drawing.Size(28, 16);
            this.Seniority.TabIndex = 10;
            this.Seniority.Text = "ותק";
            // 
            // Gender
            // 
            this.Gender.AutoSize = true;
            this.Gender.Location = new System.Drawing.Point(663, 174);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(36, 16);
            this.Gender.TabIndex = 11;
            this.Gender.Text = "מגדר";
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Location = new System.Drawing.Point(654, 198);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(45, 16);
            this.Address.TabIndex = 12;
            this.Address.Text = "כתובת";
            this.Address.Click += new System.EventHandler(this.label13_Click);
            // 
            // FirstNameTXT
            // 
            this.FirstNameTXT.Location = new System.Drawing.Point(393, 57);
            this.FirstNameTXT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FirstNameTXT.Name = "FirstNameTXT";
            this.FirstNameTXT.Size = new System.Drawing.Size(192, 22);
            this.FirstNameTXT.TabIndex = 13;
            this.FirstNameTXT.TextChanged += new System.EventHandler(this.FirstNameTXT_TextChanged);
            // 
            // LastNameTXT
            // 
            this.LastNameTXT.Location = new System.Drawing.Point(393, 83);
            this.LastNameTXT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LastNameTXT.Name = "LastNameTXT";
            this.LastNameTXT.Size = new System.Drawing.Size(192, 22);
            this.LastNameTXT.TabIndex = 14;
            this.LastNameTXT.TextChanged += new System.EventHandler(this.LastNameTXT_TextChanged);
            // 
            // IDTXT
            // 
            this.IDTXT.Location = new System.Drawing.Point(393, 113);
            this.IDTXT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IDTXT.Name = "IDTXT";
            this.IDTXT.Size = new System.Drawing.Size(192, 22);
            this.IDTXT.TabIndex = 15;
            this.IDTXT.TextChanged += new System.EventHandler(this.IDTXT_TextChanged);
            // 
            // AddressTXT
            // 
            this.AddressTXT.Location = new System.Drawing.Point(390, 200);
            this.AddressTXT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddressTXT.Name = "AddressTXT";
            this.AddressTXT.Size = new System.Drawing.Size(195, 22);
            this.AddressTXT.TabIndex = 16;
            this.AddressTXT.TextChanged += new System.EventHandler(this.AddressTXT_TextChanged);
            // 
            // BirthDatePICK
            // 
            this.BirthDatePICK.Location = new System.Drawing.Point(367, 143);
            this.BirthDatePICK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BirthDatePICK.Name = "BirthDatePICK";
            this.BirthDatePICK.Size = new System.Drawing.Size(238, 22);
            this.BirthDatePICK.TabIndex = 17;
            this.BirthDatePICK.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // JoinDatePCK
            // 
            this.JoinDatePCK.Location = new System.Drawing.Point(12, 111);
            this.JoinDatePCK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.JoinDatePCK.Name = "JoinDatePCK";
            this.JoinDatePCK.Size = new System.Drawing.Size(227, 22);
            this.JoinDatePCK.TabIndex = 18;
            this.JoinDatePCK.ValueChanged += new System.EventHandler(this.JoinDatePCK_ValueChanged);
            // 
            // GenderCombo
            // 
            this.GenderCombo.FormattingEnabled = true;
            this.GenderCombo.Location = new System.Drawing.Point(390, 171);
            this.GenderCombo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GenderCombo.Name = "GenderCombo";
            this.GenderCombo.Size = new System.Drawing.Size(195, 24);
            this.GenderCombo.TabIndex = 19;
            this.GenderCombo.SelectedIndexChanged += new System.EventHandler(this.GenderCombo_SelectedIndexChanged);
            // 
            // MemberTypeCOMBOX
            // 
            this.MemberTypeCOMBOX.FormattingEnabled = true;
            this.MemberTypeCOMBOX.Location = new System.Drawing.Point(36, 143);
            this.MemberTypeCOMBOX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MemberTypeCOMBOX.Name = "MemberTypeCOMBOX";
            this.MemberTypeCOMBOX.Size = new System.Drawing.Size(186, 24);
            this.MemberTypeCOMBOX.TabIndex = 20;
            this.MemberTypeCOMBOX.SelectedIndexChanged += new System.EventHandler(this.MemberTypeCOMBOX_SelectedIndexChanged);
            // 
            // TrainingProccessCombox
            // 
            this.TrainingProccessCombox.FormattingEnabled = true;
            this.TrainingProccessCombox.Location = new System.Drawing.Point(36, 171);
            this.TrainingProccessCombox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TrainingProccessCombox.Name = "TrainingProccessCombox";
            this.TrainingProccessCombox.Size = new System.Drawing.Size(186, 24);
            this.TrainingProccessCombox.TabIndex = 21;
            this.TrainingProccessCombox.SelectedIndexChanged += new System.EventHandler(this.TrainingProccessCombox_SelectedIndexChanged);
            // 
            // EmerConTXT
            // 
            this.EmerConTXT.Location = new System.Drawing.Point(36, 57);
            this.EmerConTXT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EmerConTXT.Name = "EmerConTXT";
            this.EmerConTXT.Size = new System.Drawing.Size(186, 22);
            this.EmerConTXT.TabIndex = 22;
            this.EmerConTXT.TextChanged += new System.EventHandler(this.EmerConTXT_TextChanged);
            // 
            // PaymentCHK
            // 
            this.PaymentCHK.AutoSize = true;
            this.PaymentCHK.Location = new System.Drawing.Point(204, 86);
            this.PaymentCHK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PaymentCHK.Name = "PaymentCHK";
            this.PaymentCHK.Size = new System.Drawing.Size(18, 17);
            this.PaymentCHK.TabIndex = 23;
            this.PaymentCHK.UseVisualStyleBackColor = true;
            this.PaymentCHK.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // SeniorityNumeric
            // 
            this.SeniorityNumeric.Location = new System.Drawing.Point(36, 201);
            this.SeniorityNumeric.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SeniorityNumeric.Name = "SeniorityNumeric";
            this.SeniorityNumeric.Size = new System.Drawing.Size(186, 22);
            this.SeniorityNumeric.TabIndex = 24;
            this.SeniorityNumeric.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(310, 226);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(33, 16);
            this.Email.TabIndex = 25;
            this.Email.Text = "מייל";
            // 
            // Phone
            // 
            this.Phone.AutoSize = true;
            this.Phone.Location = new System.Drawing.Point(623, 226);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(73, 16);
            this.Phone.TabIndex = 26;
            this.Phone.Text = "מספר טלפון";
            // 
            // EmailTXT
            // 
            this.EmailTXT.Location = new System.Drawing.Point(36, 226);
            this.EmailTXT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EmailTXT.Name = "EmailTXT";
            this.EmailTXT.Size = new System.Drawing.Size(186, 22);
            this.EmailTXT.TabIndex = 27;
            this.EmailTXT.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // PhoneTXT
            // 
            this.PhoneTXT.Location = new System.Drawing.Point(390, 226);
            this.PhoneTXT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PhoneTXT.Name = "PhoneTXT";
            this.PhoneTXT.Size = new System.Drawing.Size(195, 22);
            this.PhoneTXT.TabIndex = 28;
            this.PhoneTXT.TextChanged += new System.EventHandler(this.PhoneTXT_TextChanged);
            // 
            // CreateMemberButton
            // 
            this.CreateMemberButton.Location = new System.Drawing.Point(32, 309);
            this.CreateMemberButton.Name = "CreateMemberButton";
            this.CreateMemberButton.Size = new System.Drawing.Size(172, 33);
            this.CreateMemberButton.TabIndex = 29;
            this.CreateMemberButton.Text = "צור";
            this.CreateMemberButton.UseVisualStyleBackColor = true;
            this.CreateMemberButton.Click += new System.EventHandler(this.CreateMemberButton_Click);
            // 
            // ReturnFromCreateMember
            // 
            this.ReturnFromCreateMember.Location = new System.Drawing.Point(225, 313);
            this.ReturnFromCreateMember.Name = "ReturnFromCreateMember";
            this.ReturnFromCreateMember.Size = new System.Drawing.Size(165, 28);
            this.ReturnFromCreateMember.TabIndex = 30;
            this.ReturnFromCreateMember.Text = "חזור";
            this.ReturnFromCreateMember.UseVisualStyleBackColor = true;
            this.ReturnFromCreateMember.Click += new System.EventHandler(this.ReturnFromCreateMember_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.ReturnFromCreateMember);
            this.Controls.Add(this.CreateMemberButton);
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
        private System.Windows.Forms.Button CreateMemberButton;
        private System.Windows.Forms.Button ReturnFromCreateMember;
    }
}
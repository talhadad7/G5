namespace G5
{
    partial class CreateActivityForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TagCheckList = new System.Windows.Forms.CheckedListBox();
            this.AreaCheckList = new System.Windows.Forms.CheckedListBox();
            this.TitleTxtBox = new System.Windows.Forms.TextBox();
            this.ContentTxtBox = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(371, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "יצירת פעולה";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(594, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "כותרת הפעולה";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(660, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "תוכן";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(290, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "תגיות";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(290, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "איזורים מומלצים";
            // 
            // TagCheckList
            // 
            this.TagCheckList.FormattingEnabled = true;
            this.TagCheckList.HorizontalScrollbar = true;
            this.TagCheckList.IntegralHeight = false;
            this.TagCheckList.Location = new System.Drawing.Point(77, 80);
            this.TagCheckList.Name = "TagCheckList";
            this.TagCheckList.Size = new System.Drawing.Size(160, 115);
            this.TagCheckList.TabIndex = 6;
            // 
            // AreaCheckList
            // 
            this.AreaCheckList.FormattingEnabled = true;
            this.AreaCheckList.HorizontalScrollbar = true;
            this.AreaCheckList.IntegralHeight = false;
            this.AreaCheckList.Location = new System.Drawing.Point(77, 223);
            this.AreaCheckList.Name = "AreaCheckList";
            this.AreaCheckList.Size = new System.Drawing.Size(156, 121);
            this.AreaCheckList.TabIndex = 7;
            // 
            // TitleTxtBox
            // 
            this.TitleTxtBox.Location = new System.Drawing.Point(422, 80);
            this.TitleTxtBox.Name = "TitleTxtBox";
            this.TitleTxtBox.Size = new System.Drawing.Size(138, 26);
            this.TitleTxtBox.TabIndex = 8;
            // 
            // ContentTxtBox
            // 
            this.ContentTxtBox.Location = new System.Drawing.Point(442, 157);
            this.ContentTxtBox.Name = "ContentTxtBox";
            this.ContentTxtBox.Size = new System.Drawing.Size(182, 26);
            this.ContentTxtBox.TabIndex = 9;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(115, 366);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(162, 56);
            this.SaveButton.TabIndex = 10;
            this.SaveButton.Text = "יצירה";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click_1);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(511, 356);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(160, 66);
            this.CancelButton.TabIndex = 11;
            this.CancelButton.Text = "ביטול";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click_1);
            // 
            // CreateActivityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.ContentTxtBox);
            this.Controls.Add(this.TitleTxtBox);
            this.Controls.Add(this.AreaCheckList);
            this.Controls.Add(this.TagCheckList);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CreateActivityForm";
            this.Text = "CreateActivityForm";
            this.Load += new System.EventHandler(this.CreateActivityForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckedListBox TagCheckList;
        private System.Windows.Forms.CheckedListBox AreaCheckList;
        private System.Windows.Forms.TextBox TitleTxtBox;
        private System.Windows.Forms.TextBox ContentTxtBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button CancelButton;
    }
}
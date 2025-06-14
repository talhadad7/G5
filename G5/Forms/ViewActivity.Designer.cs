namespace G5
{
    partial class ViewActivity
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
            this.lblSearchTitle = new System.Windows.Forms.Label();
            this.txtSearchTitle = new System.Windows.Forms.TextBox();
            this.btnSearchActivity = new System.Windows.Forms.Button();
            this.lblResults = new System.Windows.Forms.Label();
            this.cmbActivityResults = new System.Windows.Forms.ComboBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblContent = new System.Windows.Forms.Label();
            this.lblCreationDate = new System.Windows.Forms.Label();
            this.lblWriter = new System.Windows.Forms.Label();
            this.lblRank = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.txtWriterID = new System.Windows.Forms.TextBox();
            this.txtTotalRank = new System.Windows.Forms.TextBox();
            this.dptCreationDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lblSearchTitle
            // 
            this.lblSearchTitle.AutoSize = true;
            this.lblSearchTitle.Location = new System.Drawing.Point(650, 49);
            this.lblSearchTitle.Name = "lblSearchTitle";
            this.lblSearchTitle.Size = new System.Drawing.Size(122, 16);
            this.lblSearchTitle.TabIndex = 0;
            this.lblSearchTitle.Text = "הקלד פעולה לחיפוש";
            //this.lblSearchTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtSearchTitle
            // 
            this.txtSearchTitle.Location = new System.Drawing.Point(477, 47);
            this.txtSearchTitle.Name = "txtSearchTitle";
            this.txtSearchTitle.Size = new System.Drawing.Size(156, 22);
            this.txtSearchTitle.TabIndex = 1;
            // 
            // btnSearchActivity
            // 
            this.btnSearchActivity.Location = new System.Drawing.Point(366, 46);
            this.btnSearchActivity.Name = "btnSearchActivity";
            this.btnSearchActivity.Size = new System.Drawing.Size(92, 23);
            this.btnSearchActivity.TabIndex = 2;
            this.btnSearchActivity.Text = "חפש";
            this.btnSearchActivity.UseVisualStyleBackColor = true;
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Location = new System.Drawing.Point(669, 106);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(103, 16);
            this.lblResults.TabIndex = 3;
            this.lblResults.Text = "תוצאות אפשריות";
            // 
            // cmbActivityResults
            // 
            this.cmbActivityResults.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbActivityResults.FormattingEnabled = true;
            this.cmbActivityResults.Location = new System.Drawing.Point(418, 102);
            this.cmbActivityResults.Name = "cmbActivityResults";
            this.cmbActivityResults.Size = new System.Drawing.Size(227, 24);
            this.cmbActivityResults.TabIndex = 4;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(681, 164);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(91, 16);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "כותרת הפעולה";
            // 
            // lblContent
            // 
            this.lblContent.AutoSize = true;
            this.lblContent.Location = new System.Drawing.Point(692, 207);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(80, 16);
            this.lblContent.TabIndex = 6;
            this.lblContent.Text = "תוכן הפעולה";
            // 
            // lblCreationDate
            // 
            this.lblCreationDate.AutoSize = true;
            this.lblCreationDate.Location = new System.Drawing.Point(379, 207);
            this.lblCreationDate.Name = "lblCreationDate";
            this.lblCreationDate.Size = new System.Drawing.Size(79, 16);
            this.lblCreationDate.TabIndex = 7;
            this.lblCreationDate.Text = "תאריך יצירה";
            // 
            // lblWriter
            // 
            this.lblWriter.AutoSize = true;
            this.lblWriter.Location = new System.Drawing.Point(375, 164);
            this.lblWriter.Name = "lblWriter";
            this.lblWriter.Size = new System.Drawing.Size(83, 16);
            this.lblWriter.TabIndex = 8;
            this.lblWriter.Text = "כותב הפעולה";
            // 
            // lblRank
            // 
            this.lblRank.AutoSize = true;
            this.lblRank.Location = new System.Drawing.Point(398, 247);
            this.lblRank.Name = "lblRank";
            this.lblRank.Size = new System.Drawing.Size(60, 16);
            this.lblRank.TabIndex = 9;
            this.lblRank.Text = "ציון כולל";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(504, 158);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.ReadOnly = true;
            this.txtTitle.Size = new System.Drawing.Size(159, 22);
            this.txtTitle.TabIndex = 10;
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(504, 237);
            this.txtContent.Name = "txtContent";
            this.txtContent.ReadOnly = true;
            this.txtContent.Size = new System.Drawing.Size(269, 22);
            this.txtContent.TabIndex = 11;
            // 
            // txtWriterID
            // 
            this.txtWriterID.Location = new System.Drawing.Point(161, 158);
            this.txtWriterID.Name = "txtWriterID";
            this.txtWriterID.ReadOnly = true;
            this.txtWriterID.Size = new System.Drawing.Size(194, 22);
            this.txtWriterID.TabIndex = 12;
            // 
            // txtTotalRank
            // 
            this.txtTotalRank.Location = new System.Drawing.Point(229, 241);
            this.txtTotalRank.Name = "txtTotalRank";
            this.txtTotalRank.ReadOnly = true;
            this.txtTotalRank.Size = new System.Drawing.Size(126, 22);
            this.txtTotalRank.TabIndex = 13;
            // 
            // dptCreationDate
            // 
            this.dptCreationDate.Enabled = false;
            this.dptCreationDate.Location = new System.Drawing.Point(125, 201);
            this.dptCreationDate.Name = "dptCreationDate";
            this.dptCreationDate.Size = new System.Drawing.Size(230, 22);
            this.dptCreationDate.TabIndex = 14;
            // 
            // ViewActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dptCreationDate);
            this.Controls.Add(this.txtTotalRank);
            this.Controls.Add(this.txtWriterID);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblRank);
            this.Controls.Add(this.lblWriter);
            this.Controls.Add(this.lblCreationDate);
            this.Controls.Add(this.lblContent);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.cmbActivityResults);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.btnSearchActivity);
            this.Controls.Add(this.txtSearchTitle);
            this.Controls.Add(this.lblSearchTitle);
            this.Name = "ViewActivity";
            this.Text = "ViewActivity";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSearchTitle;
        private System.Windows.Forms.TextBox txtSearchTitle;
        private System.Windows.Forms.Button btnSearchActivity;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.ComboBox cmbActivityResults;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblContent;
        private System.Windows.Forms.Label lblCreationDate;
        private System.Windows.Forms.Label lblWriter;
        private System.Windows.Forms.Label lblRank;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.TextBox txtWriterID;
        private System.Windows.Forms.TextBox txtTotalRank;
        private System.Windows.Forms.DateTimePicker dptCreationDate;
    }
}
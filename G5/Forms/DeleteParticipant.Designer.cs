namespace G5
{
    partial class DeleteParticipant
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
            this.DeleteButton = new System.Windows.Forms.Button();
            this.IDTXTBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(357, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "מחיקת חניך";
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(499, 108);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(167, 68);
            this.DeleteButton.TabIndex = 1;
            this.DeleteButton.Text = "מחיקה";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // IDTXTBox
            // 
            this.IDTXTBox.Location = new System.Drawing.Point(97, 129);
            this.IDTXTBox.Name = "IDTXTBox";
            this.IDTXTBox.Size = new System.Drawing.Size(201, 26);
            this.IDTXTBox.TabIndex = 2;
            this.IDTXTBox.Text = "נא להזין ת\"ז";
            this.IDTXTBox.TextChanged += new System.EventHandler(this.IDTXTBox_TextChanged);
            // 
            // DeleteParticipant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.IDTXTBox);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.label1);
            this.Name = "DeleteParticipant";
            this.Text = "DeleteParticipant";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.TextBox IDTXTBox;
    }
}
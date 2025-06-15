namespace G5.Forms
{
    partial class ViewAnnouncements
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
            this.dgvAnnouncements = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnnouncements)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAnnouncements
            // 
            this.dgvAnnouncements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnnouncements.Location = new System.Drawing.Point(68, 57);
            this.dgvAnnouncements.Name = "dgvAnnouncements";
            this.dgvAnnouncements.RowHeadersWidth = 82;
            this.dgvAnnouncements.RowTemplate.Height = 33;
            this.dgvAnnouncements.Size = new System.Drawing.Size(670, 369);
            this.dgvAnnouncements.TabIndex = 0;
            // 
            // ViewAnnouncements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvAnnouncements);
            this.Name = "ViewAnnouncements";
            this.Text = "ViewAnnouncements";
            this.Load += new System.EventHandler(this.ViewAnnouncements_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnnouncements)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAnnouncements;
    }
}
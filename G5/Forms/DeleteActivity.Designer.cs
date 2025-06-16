namespace G5
{
    partial class DeleteActivity
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteActivity));
            this.txtSearchActivityTitle = new System.Windows.Forms.TextBox();
            this.btnActivitySearch = new System.Windows.Forms.Button();
            this.ActivityListViewForDelete = new System.Windows.Forms.DataGridView();
            this.g5DataSet = new G5.G5DataSet();
            this.g5DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnDeleteActivity = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ActivityListViewForDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.g5DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.g5DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearchActivityTitle
            // 
            this.txtSearchActivityTitle.Location = new System.Drawing.Point(387, 130);
            this.txtSearchActivityTitle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearchActivityTitle.Name = "txtSearchActivityTitle";
            this.txtSearchActivityTitle.Size = new System.Drawing.Size(329, 28);
            this.txtSearchActivityTitle.TabIndex = 0;
            // 
            // btnActivitySearch
            // 
            this.btnActivitySearch.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActivitySearch.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnActivitySearch.Location = new System.Drawing.Point(210, 116);
            this.btnActivitySearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnActivitySearch.Name = "btnActivitySearch";
            this.btnActivitySearch.Size = new System.Drawing.Size(117, 42);
            this.btnActivitySearch.TabIndex = 1;
            this.btnActivitySearch.Text = "חפש פעולה";
            this.btnActivitySearch.UseVisualStyleBackColor = true;
            this.btnActivitySearch.Click += new System.EventHandler(this.btnActivitySearch_Click);
            // 
            // ActivityListViewForDelete
            // 
            this.ActivityListViewForDelete.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.ActivityListViewForDelete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ActivityListViewForDelete.Location = new System.Drawing.Point(65, 198);
            this.ActivityListViewForDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ActivityListViewForDelete.Name = "ActivityListViewForDelete";
            this.ActivityListViewForDelete.RowHeadersWidth = 51;
            this.ActivityListViewForDelete.RowTemplate.Height = 24;
            this.ActivityListViewForDelete.Size = new System.Drawing.Size(767, 136);
            this.ActivityListViewForDelete.TabIndex = 2;
            // 
            // g5DataSet
            // 
            this.g5DataSet.DataSetName = "G5DataSet";
            this.g5DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // g5DataSetBindingSource
            // 
            this.g5DataSetBindingSource.DataSource = this.g5DataSet;
            this.g5DataSetBindingSource.Position = 0;
            // 
            // btnDeleteActivity
            // 
            this.btnDeleteActivity.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteActivity.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnDeleteActivity.Location = new System.Drawing.Point(26, 371);
            this.btnDeleteActivity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDeleteActivity.Name = "btnDeleteActivity";
            this.btnDeleteActivity.Size = new System.Drawing.Size(217, 52);
            this.btnDeleteActivity.TabIndex = 3;
            this.btnDeleteActivity.Text = "מחק פעולה";
            this.btnDeleteActivity.UseVisualStyleBackColor = true;
            this.btnDeleteActivity.Click += new System.EventHandler(this.btnDeleteActivity_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(324, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 34);
            this.label1.TabIndex = 4;
            this.label1.Text = "מחיקת פעולה";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 101);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // DeleteActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(882, 503);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeleteActivity);
            this.Controls.Add(this.ActivityListViewForDelete);
            this.Controls.Add(this.btnActivitySearch);
            this.Controls.Add(this.txtSearchActivityTitle);
            this.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DeleteActivity";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ActivityListViewForDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.g5DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.g5DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearchActivityTitle;
        private System.Windows.Forms.Button btnActivitySearch;
        private System.Windows.Forms.DataGridView ActivityListViewForDelete;
        private System.Windows.Forms.BindingSource g5DataSetBindingSource;
        private G5DataSet g5DataSet;
        private System.Windows.Forms.Button btnDeleteActivity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
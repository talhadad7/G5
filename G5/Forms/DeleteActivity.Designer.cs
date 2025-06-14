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
            this.txtSearchActivityTitle = new System.Windows.Forms.TextBox();
            this.btnActivitySearch = new System.Windows.Forms.Button();
            this.ActivityListViewForDelete = new System.Windows.Forms.DataGridView();
            this.g5DataSet = new G5.G5DataSet();
            this.g5DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnDeleteActivity = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ActivityListViewForDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.g5DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.g5DataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearchActivityTitle
            // 
            this.txtSearchActivityTitle.Location = new System.Drawing.Point(114, 109);
            this.txtSearchActivityTitle.Name = "txtSearchActivityTitle";
            this.txtSearchActivityTitle.Size = new System.Drawing.Size(293, 22);
            this.txtSearchActivityTitle.TabIndex = 0;
            // 
            // btnActivitySearch
            // 
            this.btnActivitySearch.Location = new System.Drawing.Point(444, 104);
            this.btnActivitySearch.Name = "btnActivitySearch";
            this.btnActivitySearch.Size = new System.Drawing.Size(280, 27);
            this.btnActivitySearch.TabIndex = 1;
            this.btnActivitySearch.Text = "חפש פעילות";
            this.btnActivitySearch.UseVisualStyleBackColor = true;
            this.btnActivitySearch.Click += new System.EventHandler(this.btnActivitySearch_Click);

            // 
            // ActivityListViewForDelete
            // 
            this.ActivityListViewForDelete.AutoGenerateColumns = true;
            this.ActivityListViewForDelete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ActivityListViewForDelete.Location = new System.Drawing.Point(72, 220);
            this.ActivityListViewForDelete.Name = "ActivityListViewForDelete";
            this.ActivityListViewForDelete.RowHeadersWidth = 51;
            this.ActivityListViewForDelete.RowTemplate.Height = 24;
            this.ActivityListViewForDelete.Size = new System.Drawing.Size(689, 171);
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
            this.btnDeleteActivity.Location = new System.Drawing.Point(567, 416);
            this.btnDeleteActivity.Name = "btnDeleteActivity";
            this.btnDeleteActivity.Size = new System.Drawing.Size(193, 28);
            this.btnDeleteActivity.TabIndex = 3;
            this.btnDeleteActivity.Text = "מחק פעולה";
            this.btnDeleteActivity.UseVisualStyleBackColor = true;
            this.btnDeleteActivity.Click += new System.EventHandler(this.btnDeleteActivity_Click);

            // 
            // DeleteActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 520);
            this.Controls.Add(this.btnDeleteActivity);
            this.Controls.Add(this.ActivityListViewForDelete);
            this.Controls.Add(this.btnActivitySearch);
            this.Controls.Add(this.txtSearchActivityTitle);
            this.Name = "DeleteActivity";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ActivityListViewForDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.g5DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.g5DataSetBindingSource)).EndInit();
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
    }
}
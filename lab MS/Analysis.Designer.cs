namespace lab_MS
{
    partial class Analysis
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.test = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.category = new System.Windows.Forms.Label();
            this.details = new System.Windows.Forms.Label();
            this.deleteCategory = new System.Windows.Forms.Button();
            this.savecategory = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.test,
            this.NR,
            this.mu,
            this.cost});
            this.dataGridView1.Location = new System.Drawing.Point(120, 87);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(647, 331);
            this.dataGridView1.TabIndex = 0;
            // 
            // test
            // 
            this.test.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.test.HeaderText = "TEST NAME";
            this.test.Name = "test";
            // 
            // NR
            // 
            this.NR.HeaderText = "NR";
            this.NR.Name = "NR";
            // 
            // mu
            // 
            this.mu.HeaderText = "Measuring Units";
            this.mu.Name = "mu";
            // 
            // cost
            // 
            this.cost.HeaderText = "COST";
            this.cost.Name = "cost";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(120, 36);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(648, 31);
            this.comboBox1.TabIndex = 1;
            // 
            // category
            // 
            this.category.AutoSize = true;
            this.category.Font = new System.Drawing.Font("Lucida Console", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category.Location = new System.Drawing.Point(8, 38);
            this.category.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(105, 19);
            this.category.TabIndex = 2;
            this.category.Text = "Category";
            // 
            // details
            // 
            this.details.AutoSize = true;
            this.details.Font = new System.Drawing.Font("Lucida Console", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.details.Location = new System.Drawing.Point(8, 102);
            this.details.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.details.Name = "details";
            this.details.Size = new System.Drawing.Size(93, 19);
            this.details.TabIndex = 3;
            this.details.Text = "Details";
            // 
            // deleteCategory
            // 
            this.deleteCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteCategory.Font = new System.Drawing.Font("Lucida Console", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteCategory.Location = new System.Drawing.Point(485, 423);
            this.deleteCategory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.deleteCategory.Name = "deleteCategory";
            this.deleteCategory.Size = new System.Drawing.Size(135, 36);
            this.deleteCategory.TabIndex = 4;
            this.deleteCategory.Text = "Delete Category";
            this.deleteCategory.UseVisualStyleBackColor = true;
            // 
            // savecategory
            // 
            this.savecategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.savecategory.Font = new System.Drawing.Font("Lucida Console", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savecategory.Location = new System.Drawing.Point(632, 423);
            this.savecategory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.savecategory.Name = "savecategory";
            this.savecategory.Size = new System.Drawing.Size(135, 36);
            this.savecategory.TabIndex = 5;
            this.savecategory.Text = "Save";
            this.savecategory.UseVisualStyleBackColor = true;
            // 
            // Analysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 468);
            this.Controls.Add(this.savecategory);
            this.Controls.Add(this.deleteCategory);
            this.Controls.Add(this.details);
            this.Controls.Add(this.category);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Analysis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Analysis";
            this.Load += new System.EventHandler(this.Analysis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label category;
        private System.Windows.Forms.Label details;
        private System.Windows.Forms.DataGridViewTextBoxColumn test;
        private System.Windows.Forms.DataGridViewTextBoxColumn NR;
        private System.Windows.Forms.DataGridViewTextBoxColumn mu;
        private System.Windows.Forms.DataGridViewTextBoxColumn cost;
        private System.Windows.Forms.Button deleteCategory;
        private System.Windows.Forms.Button savecategory;
    }
}
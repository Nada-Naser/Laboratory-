namespace WindowsFormsApplication2
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
            this.components = new System.ComponentModel.Container();
            this.savecategory = new System.Windows.Forms.Button();
            this.deleteCategory = new System.Windows.Forms.Button();
            this.details = new System.Windows.Forms.Label();
            this.category = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.analysiscatigoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.laboratoryDataSet = new WindowsFormsApplication2.laboratoryDataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.test = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.analysiscatigoryTableAdapter = new WindowsFormsApplication2.laboratoryDataSetTableAdapters.analysiscatigoryTableAdapter();
            this.laboratoryDataSet1 = new WindowsFormsApplication2.laboratoryDataSet1();
            this.analysisdetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.analysisdetailTableAdapter = new WindowsFormsApplication2.laboratoryDataSet1TableAdapters.analysisdetailTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.analysiscatigoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laboratoryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laboratoryDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.analysisdetailBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // savecategory
            // 
            this.savecategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.savecategory.Font = new System.Drawing.Font("Lucida Console", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savecategory.Location = new System.Drawing.Point(472, 360);
            this.savecategory.Margin = new System.Windows.Forms.Padding(2);
            this.savecategory.Name = "savecategory";
            this.savecategory.Size = new System.Drawing.Size(135, 36);
            this.savecategory.TabIndex = 11;
            this.savecategory.Text = "Save";
            this.savecategory.UseVisualStyleBackColor = true;
            this.savecategory.Click += new System.EventHandler(this.savecategory_Click);
            // 
            // deleteCategory
            // 
            this.deleteCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteCategory.Font = new System.Drawing.Font("Lucida Console", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteCategory.Location = new System.Drawing.Point(325, 360);
            this.deleteCategory.Margin = new System.Windows.Forms.Padding(2);
            this.deleteCategory.Name = "deleteCategory";
            this.deleteCategory.Size = new System.Drawing.Size(135, 36);
            this.deleteCategory.TabIndex = 10;
            this.deleteCategory.Text = "Delete Category";
            this.deleteCategory.UseVisualStyleBackColor = true;
            this.deleteCategory.Click += new System.EventHandler(this.deleteCategory_Click);
            // 
            // details
            // 
            this.details.AutoSize = true;
            this.details.Font = new System.Drawing.Font("Lucida Console", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.details.Location = new System.Drawing.Point(16, 100);
            this.details.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.details.Name = "details";
            this.details.Size = new System.Drawing.Size(93, 19);
            this.details.TabIndex = 9;
            this.details.Text = "Details";
            // 
            // category
            // 
            this.category.AutoSize = true;
            this.category.Font = new System.Drawing.Font("Lucida Console", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category.Location = new System.Drawing.Point(16, 36);
            this.category.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(105, 19);
            this.category.TabIndex = 8;
            this.category.Text = "Category";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(128, 34);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(498, 31);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // analysiscatigoryBindingSource
            // 
            this.analysiscatigoryBindingSource.DataMember = "analysiscatigory";
            this.analysiscatigoryBindingSource.DataSource = this.laboratoryDataSet;
            // 
            // laboratoryDataSet
            // 
            this.laboratoryDataSet.DataSetName = "laboratoryDataSet";
            this.laboratoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.dataGridView1.Location = new System.Drawing.Point(128, 85);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(498, 258);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // test
            // 
            this.test.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.test.DataPropertyName = "dename";
            this.test.HeaderText = "TEST NAME";
            this.test.Name = "test";
            // 
            // NR
            // 
            this.NR.DataPropertyName = "normalValue";
            this.NR.HeaderText = "NR";
            this.NR.Name = "NR";
            // 
            // mu
            // 
            this.mu.DataPropertyName = "measuringUnit";
            this.mu.HeaderText = "Measuring Units";
            this.mu.Name = "mu";
            // 
            // cost
            // 
            this.cost.DataPropertyName = "cost";
            this.cost.HeaderText = "COST";
            this.cost.Name = "cost";
            // 
            // analysiscatigoryTableAdapter
            // 
            this.analysiscatigoryTableAdapter.ClearBeforeFill = true;
            // 
            // laboratoryDataSet1
            // 
            this.laboratoryDataSet1.DataSetName = "laboratoryDataSet1";
            this.laboratoryDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // analysisdetailBindingSource
            // 
            this.analysisdetailBindingSource.DataMember = "analysisdetail";
            this.analysisdetailBindingSource.DataSource = this.laboratoryDataSet1;
            // 
            // analysisdetailTableAdapter
            // 
            this.analysisdetailTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Lucida Console", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(179, 360);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 36);
            this.button1.TabIndex = 12;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Analysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 436);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.savecategory);
            this.Controls.Add(this.deleteCategory);
            this.Controls.Add(this.details);
            this.Controls.Add(this.category);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Analysis";
            this.Text = "Analysis";
            this.Load += new System.EventHandler(this.Analysis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.analysiscatigoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laboratoryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laboratoryDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.analysisdetailBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button savecategory;
        private System.Windows.Forms.Button deleteCategory;
        private System.Windows.Forms.Label details;
        private System.Windows.Forms.Label category;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private laboratoryDataSet laboratoryDataSet;
        private System.Windows.Forms.BindingSource analysiscatigoryBindingSource;
        private laboratoryDataSetTableAdapters.analysiscatigoryTableAdapter analysiscatigoryTableAdapter;
        private laboratoryDataSet1 laboratoryDataSet1;
        private System.Windows.Forms.BindingSource analysisdetailBindingSource;
        private laboratoryDataSet1TableAdapters.analysisdetailTableAdapter analysisdetailTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn test;
        private System.Windows.Forms.DataGridViewTextBoxColumn NR;
        private System.Windows.Forms.DataGridViewTextBoxColumn mu;
        private System.Windows.Forms.DataGridViewTextBoxColumn cost;
        private System.Windows.Forms.Button button1;
    }
}
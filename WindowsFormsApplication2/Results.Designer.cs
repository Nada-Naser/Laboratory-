namespace WindowsFormsApplication2
{
    partial class Results
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
            this.Categories = new System.Windows.Forms.Label();
            this.Pcategories = new System.Windows.Forms.ListBox();
            this.Addresults = new System.Windows.Forms.DataGridView();
            this.details = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Presults = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.patientname = new System.Windows.Forms.TextBox();
            this.Psex = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.PID = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.Comment = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Addresults)).BeginInit();
            this.SuspendLayout();
            // 
            // Categories
            // 
            this.Categories.AutoSize = true;
            this.Categories.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Categories.Location = new System.Drawing.Point(21, 163);
            this.Categories.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Categories.Name = "Categories";
            this.Categories.Size = new System.Drawing.Size(217, 16);
            this.Categories.TabIndex = 25;
            this.Categories.Text = "Analysis Categories";
            // 
            // Pcategories
            // 
            this.Pcategories.FormattingEnabled = true;
            this.Pcategories.Location = new System.Drawing.Point(17, 181);
            this.Pcategories.Margin = new System.Windows.Forms.Padding(2);
            this.Pcategories.Name = "Pcategories";
            this.Pcategories.Size = new System.Drawing.Size(220, 290);
            this.Pcategories.TabIndex = 24;
            this.Pcategories.SelectedIndexChanged += new System.EventHandler(this.Pcategories_SelectedIndexChanged);
            // 
            // Addresults
            // 
            this.Addresults.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Addresults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.details,
            this.Presults,
            this.NV,
            this.MU});
            this.Addresults.Location = new System.Drawing.Point(242, 163);
            this.Addresults.Margin = new System.Windows.Forms.Padding(2);
            this.Addresults.Name = "Addresults";
            this.Addresults.RowTemplate.Height = 29;
            this.Addresults.Size = new System.Drawing.Size(497, 308);
            this.Addresults.TabIndex = 23;
            this.Addresults.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Addresults_CellContentClick);
            // 
            // details
            // 
            this.details.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.details.DataPropertyName = "dename";
            this.details.HeaderText = "Analysis Details ";
            this.details.Name = "details";
            // 
            // Presults
            // 
            this.Presults.DataPropertyName = "results";
            this.Presults.HeaderText = "RESULTS";
            this.Presults.Name = "Presults";
            // 
            // NV
            // 
            this.NV.DataPropertyName = "normalValue";
            this.NV.HeaderText = "Normal Value";
            this.NV.Name = "NV";
            // 
            // MU
            // 
            this.MU.DataPropertyName = "measuringUnit";
            this.MU.HeaderText = "Measuring units";
            this.MU.Name = "MU";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(473, 99);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(83, 25);
            this.textBox2.TabIndex = 22;
            // 
            // patientname
            // 
            this.patientname.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientname.Location = new System.Drawing.Point(173, 99);
            this.patientname.Margin = new System.Windows.Forms.Padding(2);
            this.patientname.Name = "patientname";
            this.patientname.Size = new System.Drawing.Size(224, 25);
            this.patientname.TabIndex = 21;
            // 
            // Psex
            // 
            this.Psex.AutoSize = true;
            this.Psex.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Psex.Location = new System.Drawing.Point(432, 99);
            this.Psex.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Psex.Name = "Psex";
            this.Psex.Size = new System.Drawing.Size(41, 16);
            this.Psex.TabIndex = 20;
            this.Psex.Text = "SEX";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 99);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Patient Name ";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(409, 25);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(173, 23);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(224, 27);
            this.textBox1.TabIndex = 17;
            // 
            // PID
            // 
            this.PID.AutoSize = true;
            this.PID.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PID.Location = new System.Drawing.Point(33, 29);
            this.PID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PID.Name = "PID";
            this.PID.Size = new System.Drawing.Size(129, 16);
            this.PID.TabIndex = 16;
            this.PID.Text = "Patient ID ";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(573, 508);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(166, 106);
            this.button2.TabIndex = 29;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(24, 508);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(537, 107);
            this.textBox4.TabIndex = 27;
            // 
            // Comment
            // 
            this.Comment.AutoSize = true;
            this.Comment.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Comment.Location = new System.Drawing.Point(26, 489);
            this.Comment.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Comment.Name = "Comment";
            this.Comment.Size = new System.Drawing.Size(85, 16);
            this.Comment.TabIndex = 26;
            this.Comment.Text = "Comment";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(621, 99);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(118, 25);
            this.textBox3.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(580, 99);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 30;
            this.label3.Text = "AGE";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(633, 23);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(91, 44);
            this.button4.TabIndex = 32;
            this.button4.Text = "Back";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Results
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 627);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.Comment);
            this.Controls.Add(this.Categories);
            this.Controls.Add(this.Pcategories);
            this.Controls.Add(this.Addresults);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.patientname);
            this.Controls.Add(this.Psex);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.PID);
            this.Name = "Results";
            this.Text = "Results";
            this.Load += new System.EventHandler(this.Results_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Addresults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Categories;
        private System.Windows.Forms.ListBox Pcategories;
        private System.Windows.Forms.DataGridView Addresults;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox patientname;
        private System.Windows.Forms.Label Psex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label PID;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label Comment;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn details;
        private System.Windows.Forms.DataGridViewTextBoxColumn Presults;
        private System.Windows.Forms.DataGridViewTextBoxColumn NV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MU;
        private System.Windows.Forms.Button button4;
    }
}
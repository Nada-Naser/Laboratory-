namespace lab_MS
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
            this.PID = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Psex = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Pname = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Addresults = new System.Windows.Forms.DataGridView();
            this.details = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Presults = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pcategories = new System.Windows.Forms.ListBox();
            this.Categories = new System.Windows.Forms.Label();
            this.Comment = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Addresults)).BeginInit();
            this.SuspendLayout();
            // 
            // PID
            // 
            this.PID.AutoSize = true;
            this.PID.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PID.Location = new System.Drawing.Point(29, 44);
            this.PID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PID.Name = "PID";
            this.PID.Size = new System.Drawing.Size(129, 16);
            this.PID.TabIndex = 0;
            this.PID.Text = "Patient ID ";
            this.PID.Click += new System.EventHandler(this.PID_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(169, 38);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(224, 27);
            this.textBox1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(405, 40);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "search";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 114);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Patient Name ";
            // 
            // Psex
            // 
            this.Psex.AutoSize = true;
            this.Psex.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Psex.Location = new System.Drawing.Point(428, 114);
            this.Psex.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Psex.Name = "Psex";
            this.Psex.Size = new System.Drawing.Size(41, 16);
            this.Psex.TabIndex = 8;
            this.Psex.Text = "SEX";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(574, 114);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "AGE";
            // 
            // Pname
            // 
            this.Pname.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pname.Location = new System.Drawing.Point(169, 114);
            this.Pname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Pname.Name = "Pname";
            this.Pname.Size = new System.Drawing.Size(233, 25);
            this.Pname.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(469, 114);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(83, 25);
            this.textBox2.TabIndex = 11;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(615, 114);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(118, 25);
            this.textBox3.TabIndex = 12;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
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
            this.Addresults.Location = new System.Drawing.Point(243, 165);
            this.Addresults.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Addresults.Name = "Addresults";
            this.Addresults.RowTemplate.Height = 29;
            this.Addresults.Size = new System.Drawing.Size(616, 324);
            this.Addresults.TabIndex = 13;
            // 
            // details
            // 
            this.details.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.details.HeaderText = "Analysis Details ";
            this.details.Name = "details";
            // 
            // Presults
            // 
            this.Presults.HeaderText = "RESULTS";
            this.Presults.Name = "Presults";
            // 
            // NV
            // 
            this.NV.HeaderText = "Normal Value";
            this.NV.Name = "NV";
            // 
            // MU
            // 
            this.MU.HeaderText = "Measuring units";
            this.MU.Name = "MU";
            // 
            // Pcategories
            // 
            this.Pcategories.FormattingEnabled = true;
            this.Pcategories.Location = new System.Drawing.Point(13, 196);
            this.Pcategories.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Pcategories.Name = "Pcategories";
            this.Pcategories.Size = new System.Drawing.Size(220, 290);
            this.Pcategories.TabIndex = 14;
            // 
            // Categories
            // 
            this.Categories.AutoSize = true;
            this.Categories.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Categories.Location = new System.Drawing.Point(17, 178);
            this.Categories.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Categories.Name = "Categories";
            this.Categories.Size = new System.Drawing.Size(217, 16);
            this.Categories.TabIndex = 15;
            this.Categories.Text = "Analysis Categories";
            // 
            // Comment
            // 
            this.Comment.AutoSize = true;
            this.Comment.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Comment.Location = new System.Drawing.Point(29, 502);
            this.Comment.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Comment.Name = "Comment";
            this.Comment.Size = new System.Drawing.Size(85, 16);
            this.Comment.TabIndex = 16;
            this.Comment.Text = "Comment";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(27, 521);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(537, 107);
            this.textBox4.TabIndex = 17;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(673, 521);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(93, 106);
            this.button3.TabIndex = 19;
            this.button3.Text = "Save and Print";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(576, 521);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 106);
            this.button2.TabIndex = 20;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Results
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 655);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.Comment);
            this.Controls.Add(this.Categories);
            this.Controls.Add(this.Pcategories);
            this.Controls.Add(this.Addresults);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Pname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Psex);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.PID);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Results";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Results";
            this.Load += new System.EventHandler(this.Results_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Addresults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PID;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Psex;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Pname;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DataGridView Addresults;
        private System.Windows.Forms.DataGridViewTextBoxColumn details;
        private System.Windows.Forms.DataGridViewTextBoxColumn Presults;
        private System.Windows.Forms.DataGridViewTextBoxColumn NV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MU;
        private System.Windows.Forms.ListBox Pcategories;
        private System.Windows.Forms.Label Categories;
        private System.Windows.Forms.Label Comment;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}
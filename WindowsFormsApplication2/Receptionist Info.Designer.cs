namespace WindowsFormsApplication2
{
    partial class Receptionist_Info
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
            this.dId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name_re = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age_re = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gendr_re = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.national_re = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone_re = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City_re = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adress_re = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.drpassword = new System.Windows.Forms.Label();
            this.drgender = new System.Windows.Forms.Label();
            this.drnationalId = new System.Windows.Forms.Label();
            this.drcity = new System.Windows.Forms.Label();
            this.draddress = new System.Windows.Forms.Label();
            this.drphone = new System.Windows.Forms.Label();
            this.drage = new System.Windows.Forms.Label();
            this.drname = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dId,
            this.Name_re,
            this.Age_re,
            this.Gendr_re,
            this.national_re,
            this.Phone_re,
            this.City_re,
            this.Adress_re,
            this.Column2,
            this.Column1});
            this.dataGridView1.Location = new System.Drawing.Point(286, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1072, 330);
            this.dataGridView1.TabIndex = 6;
            // 
            // dId
            // 
            this.dId.DataPropertyName = "rId";
            this.dId.HeaderText = "ID";
            this.dId.Name = "dId";
            // 
            // Name_re
            // 
            this.Name_re.DataPropertyName = "rName";
            this.Name_re.HeaderText = "Name";
            this.Name_re.Name = "Name_re";
            // 
            // Age_re
            // 
            this.Age_re.DataPropertyName = "age";
            this.Age_re.HeaderText = "Age";
            this.Age_re.Name = "Age_re";
            // 
            // Gendr_re
            // 
            this.Gendr_re.DataPropertyName = "gender";
            this.Gendr_re.HeaderText = "Gender";
            this.Gendr_re.Name = "Gendr_re";
            // 
            // national_re
            // 
            this.national_re.DataPropertyName = "nationalId";
            this.national_re.HeaderText = "National ID";
            this.national_re.Name = "national_re";
            // 
            // Phone_re
            // 
            this.Phone_re.DataPropertyName = "phone";
            this.Phone_re.HeaderText = "Phone";
            this.Phone_re.Name = "Phone_re";
            // 
            // City_re
            // 
            this.City_re.DataPropertyName = "city";
            this.City_re.HeaderText = "City";
            this.City_re.Name = "City_re";
            // 
            // Adress_re
            // 
            this.Adress_re.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Adress_re.DataPropertyName = "address";
            this.Adress_re.HeaderText = "Address";
            this.Adress_re.Name = "Adress_re";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "rpassword";
            this.Column2.HeaderText = "Password";
            this.Column2.Name = "Column2";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Recptype";
            this.Column1.HeaderText = "Type";
            this.Column1.Name = "Column1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(14, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 39);
            this.label1.TabIndex = 10;
            this.label1.Text = "Receptionist information";
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.LavenderBlush;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(1117, 417);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 34);
            this.button3.TabIndex = 9;
            this.button3.Text = "UPDATE";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.LavenderBlush;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(988, 417);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 34);
            this.button2.TabIndex = 8;
            this.button2.Text = "DELETE";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.LavenderBlush;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(853, 417);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 34);
            this.button1.TabIndex = 7;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(174, 360);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 20);
            this.textBox9.TabIndex = 29;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(174, 325);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 20);
            this.textBox8.TabIndex = 28;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(174, 252);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 26;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(174, 212);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 25;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(174, 173);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 24;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(174, 137);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 23;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(174, 104);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 22;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(174, 69);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 355);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 26);
            this.label2.TabIndex = 38;
            this.label2.Text = "Recption type";
            // 
            // drpassword
            // 
            this.drpassword.AutoSize = true;
            this.drpassword.Font = new System.Drawing.Font("Palatino Linotype", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drpassword.Location = new System.Drawing.Point(11, 325);
            this.drpassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.drpassword.Name = "drpassword";
            this.drpassword.Size = new System.Drawing.Size(96, 26);
            this.drpassword.TabIndex = 37;
            this.drpassword.Text = "Password";
            // 
            // drgender
            // 
            this.drgender.AutoSize = true;
            this.drgender.Font = new System.Drawing.Font("Palatino Linotype", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drgender.Location = new System.Drawing.Point(16, 290);
            this.drgender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.drgender.Name = "drgender";
            this.drgender.Size = new System.Drawing.Size(80, 26);
            this.drgender.TabIndex = 36;
            this.drgender.Text = "Gender";
            // 
            // drnationalId
            // 
            this.drnationalId.AutoSize = true;
            this.drnationalId.Font = new System.Drawing.Font("Palatino Linotype", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drnationalId.Location = new System.Drawing.Point(11, 253);
            this.drnationalId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.drnationalId.Name = "drnationalId";
            this.drnationalId.Size = new System.Drawing.Size(118, 26);
            this.drnationalId.TabIndex = 35;
            this.drnationalId.Text = "National ID";
            // 
            // drcity
            // 
            this.drcity.AutoSize = true;
            this.drcity.Font = new System.Drawing.Font("Palatino Linotype", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drcity.Location = new System.Drawing.Point(16, 213);
            this.drcity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.drcity.Name = "drcity";
            this.drcity.Size = new System.Drawing.Size(50, 26);
            this.drcity.TabIndex = 34;
            this.drcity.Text = "City";
            // 
            // draddress
            // 
            this.draddress.AutoSize = true;
            this.draddress.Font = new System.Drawing.Font("Palatino Linotype", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.draddress.Location = new System.Drawing.Point(11, 174);
            this.draddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.draddress.Name = "draddress";
            this.draddress.Size = new System.Drawing.Size(85, 26);
            this.draddress.TabIndex = 33;
            this.draddress.Text = "Address";
            // 
            // drphone
            // 
            this.drphone.AutoSize = true;
            this.drphone.Font = new System.Drawing.Font("Palatino Linotype", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drphone.Location = new System.Drawing.Point(11, 138);
            this.drphone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.drphone.Name = "drphone";
            this.drphone.Size = new System.Drawing.Size(69, 26);
            this.drphone.TabIndex = 32;
            this.drphone.Text = "Phone";
            // 
            // drage
            // 
            this.drage.AutoSize = true;
            this.drage.Font = new System.Drawing.Font("Palatino Linotype", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drage.Location = new System.Drawing.Point(13, 105);
            this.drage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.drage.Name = "drage";
            this.drage.Size = new System.Drawing.Size(48, 26);
            this.drage.TabIndex = 31;
            this.drage.Text = "Age";
            // 
            // drname
            // 
            this.drname.AutoSize = true;
            this.drname.Font = new System.Drawing.Font("Palatino Linotype", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drname.Location = new System.Drawing.Point(11, 70);
            this.drname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.drname.Name = "drname";
            this.drname.Size = new System.Drawing.Size(66, 26);
            this.drname.TabIndex = 30;
            this.drname.Text = "Name";
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.BackColor = System.Drawing.Color.LavenderBlush;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(1239, 417);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(105, 34);
            this.button4.TabIndex = 39;
            this.button4.Text = "Back";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.BackColor = System.Drawing.Color.LavenderBlush;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(727, 417);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(105, 34);
            this.button5.TabIndex = 76;
            this.button5.Text = "Help";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(174, 290);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 77;
            // 
            // Receptionist_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 464);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.drpassword);
            this.Controls.Add(this.drgender);
            this.Controls.Add(this.drnationalId);
            this.Controls.Add(this.drcity);
            this.Controls.Add(this.draddress);
            this.Controls.Add(this.drphone);
            this.Controls.Add(this.drage);
            this.Controls.Add(this.drname);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Receptionist_Info";
            this.Text = "Receptionist_Info";
            this.Load += new System.EventHandler(this.Receptionist_Info_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label drpassword;
        private System.Windows.Forms.Label drgender;
        private System.Windows.Forms.Label drnationalId;
        private System.Windows.Forms.Label drcity;
        private System.Windows.Forms.Label draddress;
        private System.Windows.Forms.Label drphone;
        private System.Windows.Forms.Label drage;
        private System.Windows.Forms.Label drname;
        private System.Windows.Forms.DataGridViewTextBoxColumn dId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_re;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age_re;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gendr_re;
        private System.Windows.Forms.DataGridViewTextBoxColumn national_re;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone_re;
        private System.Windows.Forms.DataGridViewTextBoxColumn City_re;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adress_re;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
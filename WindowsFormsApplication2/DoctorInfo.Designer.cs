namespace WindowsFormsApplication2
{
    partial class DoctorInfo
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.doctorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.laboratoryDataSet2 = new WindowsFormsApplication2.laboratoryDataSet2();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.doctorTableAdapter = new WindowsFormsApplication2.laboratoryDataSet2TableAdapters.doctorTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.drpassword = new System.Windows.Forms.Label();
            this.drgender = new System.Windows.Forms.Label();
            this.drnationalId = new System.Windows.Forms.Label();
            this.drmail = new System.Windows.Forms.Label();
            this.drcity = new System.Windows.Forms.Label();
            this.draddress = new System.Windows.Forms.Label();
            this.drphone = new System.Windows.Forms.Label();
            this.drage = new System.Windows.Forms.Label();
            this.drname = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age_re = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gendr_re = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone_re = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City_re = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.national_re = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adress_re = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laboratoryDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dId,
            this.dName,
            this.Age_re,
            this.Gendr_re,
            this.Phone_re,
            this.City_re,
            this.national_re,
            this.Adress_re,
            this.Column9,
            this.Column1});
            this.dataGridView1.DataSource = this.doctorBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(314, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(930, 330);
            this.dataGridView1.TabIndex = 6;
            // 
            // doctorBindingSource
            // 
            this.doctorBindingSource.DataMember = "doctor";
            this.doctorBindingSource.DataSource = this.laboratoryDataSet2;
            // 
            // laboratoryDataSet2
            // 
            this.laboratoryDataSet2.DataSetName = "laboratoryDataSet2";
            this.laboratoryDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.BackColor = System.Drawing.Color.LavenderBlush;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(488, 445);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(105, 34);
            this.button4.TabIndex = 11;
            this.button4.Text = "ADD";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 39);
            this.label1.TabIndex = 10;
            this.label1.Text = "Doctors information";
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.LavenderBlush;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(742, 445);
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
            this.button2.Location = new System.Drawing.Point(618, 445);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 34);
            this.button2.TabIndex = 8;
            this.button2.Text = "DELETE";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // doctorTableAdapter
            // 
            this.doctorTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(173, 89);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 12;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(173, 118);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 13;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(173, 150);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 14;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(173, 183);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 15;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(173, 215);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 16;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(173, 247);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 17;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(173, 279);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 18;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(173, 343);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 20);
            this.textBox9.TabIndex = 20;
            // 
            // drpassword
            // 
            this.drpassword.AutoSize = true;
            this.drpassword.Font = new System.Drawing.Font("Palatino Linotype", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drpassword.Location = new System.Drawing.Point(27, 337);
            this.drpassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.drpassword.Name = "drpassword";
            this.drpassword.Size = new System.Drawing.Size(96, 26);
            this.drpassword.TabIndex = 29;
            this.drpassword.Text = "Password";
            // 
            // drgender
            // 
            this.drgender.AutoSize = true;
            this.drgender.Font = new System.Drawing.Font("Palatino Linotype", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drgender.Location = new System.Drawing.Point(27, 305);
            this.drgender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.drgender.Name = "drgender";
            this.drgender.Size = new System.Drawing.Size(80, 26);
            this.drgender.TabIndex = 28;
            this.drgender.Text = "Gender";
            // 
            // drnationalId
            // 
            this.drnationalId.AutoSize = true;
            this.drnationalId.Font = new System.Drawing.Font("Palatino Linotype", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drnationalId.Location = new System.Drawing.Point(27, 273);
            this.drnationalId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.drnationalId.Name = "drnationalId";
            this.drnationalId.Size = new System.Drawing.Size(118, 26);
            this.drnationalId.TabIndex = 27;
            this.drnationalId.Text = "National ID";
            // 
            // drmail
            // 
            this.drmail.AutoSize = true;
            this.drmail.Font = new System.Drawing.Font("Palatino Linotype", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drmail.Location = new System.Drawing.Point(27, 241);
            this.drmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.drmail.Name = "drmail";
            this.drmail.Size = new System.Drawing.Size(53, 26);
            this.drmail.TabIndex = 26;
            this.drmail.Text = "Mail";
            // 
            // drcity
            // 
            this.drcity.AutoSize = true;
            this.drcity.Font = new System.Drawing.Font("Palatino Linotype", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drcity.Location = new System.Drawing.Point(27, 209);
            this.drcity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.drcity.Name = "drcity";
            this.drcity.Size = new System.Drawing.Size(50, 26);
            this.drcity.TabIndex = 25;
            this.drcity.Text = "City";
            // 
            // draddress
            // 
            this.draddress.AutoSize = true;
            this.draddress.Font = new System.Drawing.Font("Palatino Linotype", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.draddress.Location = new System.Drawing.Point(27, 177);
            this.draddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.draddress.Name = "draddress";
            this.draddress.Size = new System.Drawing.Size(85, 26);
            this.draddress.TabIndex = 24;
            this.draddress.Text = "Address";
            // 
            // drphone
            // 
            this.drphone.AutoSize = true;
            this.drphone.Font = new System.Drawing.Font("Palatino Linotype", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drphone.Location = new System.Drawing.Point(27, 144);
            this.drphone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.drphone.Name = "drphone";
            this.drphone.Size = new System.Drawing.Size(69, 26);
            this.drphone.TabIndex = 23;
            this.drphone.Text = "Phone";
            // 
            // drage
            // 
            this.drage.AutoSize = true;
            this.drage.Font = new System.Drawing.Font("Palatino Linotype", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drage.Location = new System.Drawing.Point(27, 112);
            this.drage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.drage.Name = "drage";
            this.drage.Size = new System.Drawing.Size(48, 26);
            this.drage.TabIndex = 22;
            this.drage.Text = "Age";
            // 
            // drname
            // 
            this.drname.AutoSize = true;
            this.drname.Font = new System.Drawing.Font("Palatino Linotype", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drname.Location = new System.Drawing.Point(27, 83);
            this.drname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.drname.Name = "drname";
            this.drname.Size = new System.Drawing.Size(66, 26);
            this.drname.TabIndex = 21;
            this.drname.Text = "Name";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.LavenderBlush;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(865, 445);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 34);
            this.button1.TabIndex = 30;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // dId
            // 
            this.dId.DataPropertyName = "dId";
            this.dId.HeaderText = "ID";
            this.dId.Name = "dId";
            this.dId.Width = 50;
            // 
            // dName
            // 
            this.dName.DataPropertyName = "dName";
            this.dName.HeaderText = "Name";
            this.dName.Name = "dName";
            // 
            // Age_re
            // 
            this.Age_re.DataPropertyName = "dage";
            this.Age_re.HeaderText = "Age";
            this.Age_re.Name = "Age_re";
            this.Age_re.Width = 50;
            // 
            // Gendr_re
            // 
            this.Gendr_re.DataPropertyName = "gender";
            this.Gendr_re.HeaderText = "Gender";
            this.Gendr_re.Name = "Gendr_re";
            this.Gendr_re.Width = 60;
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
            // national_re
            // 
            this.national_re.DataPropertyName = "nationalId";
            this.national_re.HeaderText = "National ID";
            this.national_re.Name = "national_re";
            // 
            // Adress_re
            // 
            this.Adress_re.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Adress_re.DataPropertyName = "address";
            this.Adress_re.HeaderText = "Address";
            this.Adress_re.Name = "Adress_re";
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "dpassword";
            this.Column9.HeaderText = "Password";
            this.Column9.Name = "Column9";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "mail";
            this.Column1.HeaderText = "E_mail";
            this.Column1.Name = "Column1";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(173, 310);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 31;
            // 
            // DoctorInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1256, 502);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.drpassword);
            this.Controls.Add(this.drgender);
            this.Controls.Add(this.drnationalId);
            this.Controls.Add(this.drmail);
            this.Controls.Add(this.drcity);
            this.Controls.Add(this.draddress);
            this.Controls.Add(this.drphone);
            this.Controls.Add(this.drage);
            this.Controls.Add(this.drname);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Name = "DoctorInfo";
            this.Text = "DoctorInfo";
            this.Load += new System.EventHandler(this.DoctorInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laboratoryDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private laboratoryDataSet2 laboratoryDataSet2;
        private System.Windows.Forms.BindingSource doctorBindingSource;
        private laboratoryDataSet2TableAdapters.doctorTableAdapter doctorTableAdapter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label drpassword;
        private System.Windows.Forms.Label drgender;
        private System.Windows.Forms.Label drnationalId;
        private System.Windows.Forms.Label drmail;
        private System.Windows.Forms.Label drcity;
        private System.Windows.Forms.Label draddress;
        private System.Windows.Forms.Label drphone;
        private System.Windows.Forms.Label drage;
        private System.Windows.Forms.Label drname;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age_re;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gendr_re;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone_re;
        private System.Windows.Forms.DataGridViewTextBoxColumn City_re;
        private System.Windows.Forms.DataGridViewTextBoxColumn national_re;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adress_re;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.ComboBox comboBox1;
        // private System.Windows.Forms.Button button5;
    }
}
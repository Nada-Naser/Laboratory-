namespace WindowsFormsApplication2
{
    partial class HR_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HR_form));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Add_Receptionist = new System.Windows.Forms.Button();
            this.Add_Doctor = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 10);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(88, 90);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // Add_Receptionist
            // 
            this.Add_Receptionist.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Add_Receptionist.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Receptionist.ForeColor = System.Drawing.SystemColors.Control;
            this.Add_Receptionist.Location = new System.Drawing.Point(117, 396);
            this.Add_Receptionist.Margin = new System.Windows.Forms.Padding(2);
            this.Add_Receptionist.Name = "Add_Receptionist";
            this.Add_Receptionist.Size = new System.Drawing.Size(240, 54);
            this.Add_Receptionist.TabIndex = 8;
            this.Add_Receptionist.Text = "Add Receptionist";
            this.Add_Receptionist.UseVisualStyleBackColor = false;
            this.Add_Receptionist.Click += new System.EventHandler(this.Add_Receptionist_Click);
            // 
            // Add_Doctor
            // 
            this.Add_Doctor.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Add_Doctor.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Doctor.ForeColor = System.Drawing.SystemColors.Control;
            this.Add_Doctor.Location = new System.Drawing.Point(117, 338);
            this.Add_Doctor.Margin = new System.Windows.Forms.Padding(2);
            this.Add_Doctor.Name = "Add_Doctor";
            this.Add_Doctor.Size = new System.Drawing.Size(240, 54);
            this.Add_Doctor.TabIndex = 7;
            this.Add_Doctor.Text = "Add Doctor";
            this.Add_Doctor.UseVisualStyleBackColor = false;
            this.Add_Doctor.Click += new System.EventHandler(this.Add_Doctor_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(117, 70);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 237);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // HR_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(464, 493);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Add_Receptionist);
            this.Controls.Add(this.Add_Doctor);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "HR_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HR_form";
            this.Load += new System.EventHandler(this.HR_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button Add_Receptionist;
        private System.Windows.Forms.Button Add_Doctor;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
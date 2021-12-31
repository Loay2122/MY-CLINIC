namespace MY_CLINIC
{
    partial class AddPatient
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnExitPatient = new System.Windows.Forms.Button();
            this.BtnAddPatient = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtAge = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtPhone1 = new System.Windows.Forms.TextBox();
            this.BtnAddPatientclear = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.Txtmedichistory = new System.Windows.Forms.TextBox();
            this.comboGender = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MY_CLINIC.Properties.Resources.logo11;
            this.pictureBox1.Location = new System.Drawing.Point(224, -2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(224, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // BtnExitPatient
            // 
            this.BtnExitPatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.BtnExitPatient.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnExitPatient.FlatAppearance.BorderSize = 0;
            this.BtnExitPatient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.BtnExitPatient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BtnExitPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExitPatient.ForeColor = System.Drawing.Color.White;
            this.BtnExitPatient.Location = new System.Drawing.Point(-1, -2);
            this.BtnExitPatient.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnExitPatient.Name = "BtnExitPatient";
            this.BtnExitPatient.Size = new System.Drawing.Size(50, 32);
            this.BtnExitPatient.TabIndex = 14;
            this.BtnExitPatient.Text = "X";
            this.BtnExitPatient.UseVisualStyleBackColor = false;
            this.BtnExitPatient.Click += new System.EventHandler(this.BtnExitPatient_Click);
            // 
            // BtnAddPatient
            // 
            this.BtnAddPatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.BtnAddPatient.FlatAppearance.BorderSize = 0;
            this.BtnAddPatient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.BtnAddPatient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.BtnAddPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddPatient.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnAddPatient.ForeColor = System.Drawing.Color.White;
            this.BtnAddPatient.Location = new System.Drawing.Point(386, 510);
            this.BtnAddPatient.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnAddPatient.Name = "BtnAddPatient";
            this.BtnAddPatient.Size = new System.Drawing.Size(224, 44);
            this.BtnAddPatient.TabIndex = 15;
            this.BtnAddPatient.Text = "Add Patient";
            this.BtnAddPatient.UseVisualStyleBackColor = false;
            this.BtnAddPatient.Click += new System.EventHandler(this.BtnAddPatient_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(196, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 31);
            this.label1.TabIndex = 16;
            this.label1.Text = "New Patient Registration";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(96, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Patient Name";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(129, 174);
            this.TxtName.Name = "TxtName";
            this.TxtName.PlaceholderText = "Full Name";
            this.TxtName.Size = new System.Drawing.Size(481, 27);
            this.TxtName.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(91, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Patient Address";
            // 
            // TxtAddress
            // 
            this.TxtAddress.Location = new System.Drawing.Point(129, 343);
            this.TxtAddress.Name = "TxtAddress";
            this.TxtAddress.PlaceholderText = "Address Line 1";
            this.TxtAddress.Size = new System.Drawing.Size(481, 27);
            this.TxtAddress.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(86, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 20);
            this.label6.TabIndex = 24;
            this.label6.Text = "Patient Age\'s";
            // 
            // TxtAge
            // 
            this.TxtAge.Location = new System.Drawing.Point(129, 290);
            this.TxtAge.Name = "TxtAge";
            this.TxtAge.PlaceholderText = "Patient AGE\'S";
            this.TxtAge.Size = new System.Drawing.Size(224, 27);
            this.TxtAge.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(91, 373);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 20);
            this.label7.TabIndex = 26;
            this.label7.Text = "Patient Phones";
            // 
            // TxtPhone1
            // 
            this.TxtPhone1.Location = new System.Drawing.Point(129, 396);
            this.TxtPhone1.Name = "TxtPhone1";
            this.TxtPhone1.PlaceholderText = "Phone 1";
            this.TxtPhone1.Size = new System.Drawing.Size(481, 27);
            this.TxtPhone1.TabIndex = 27;
            // 
            // BtnAddPatientclear
            // 
            this.BtnAddPatientclear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.BtnAddPatientclear.FlatAppearance.BorderSize = 0;
            this.BtnAddPatientclear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.BtnAddPatientclear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.BtnAddPatientclear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddPatientclear.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnAddPatientclear.ForeColor = System.Drawing.Color.White;
            this.BtnAddPatientclear.Location = new System.Drawing.Point(86, 510);
            this.BtnAddPatientclear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnAddPatientclear.Name = "BtnAddPatientclear";
            this.BtnAddPatientclear.Size = new System.Drawing.Size(224, 44);
            this.BtnAddPatientclear.TabIndex = 29;
            this.BtnAddPatientclear.Text = "Clear ";
            this.BtnAddPatientclear.UseVisualStyleBackColor = false;
            this.BtnAddPatientclear.Click += new System.EventHandler(this.BtnAddPatientclear_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(91, 426);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(173, 20);
            this.label8.TabIndex = 30;
            this.label8.Text = "Patient Medical History";
            // 
            // Txtmedichistory
            // 
            this.Txtmedichistory.Location = new System.Drawing.Point(96, 449);
            this.Txtmedichistory.Multiline = true;
            this.Txtmedichistory.Name = "Txtmedichistory";
            this.Txtmedichistory.PlaceholderText = "Patient Medical History........";
            this.Txtmedichistory.Size = new System.Drawing.Size(514, 54);
            this.Txtmedichistory.TabIndex = 31;
            // 
            // comboGender
            // 
            this.comboGender.FormattingEnabled = true;
            this.comboGender.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.comboGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboGender.Location = new System.Drawing.Point(398, 289);
            this.comboGender.Name = "comboGender";
            this.comboGender.Size = new System.Drawing.Size(212, 28);
            this.comboGender.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(377, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 33;
            this.label3.Text = "Patient Gender";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(91, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 20);
            this.label4.TabIndex = 34;
            this.label4.Text = "Patient E-mail";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(129, 227);
            this.txtemail.Name = "txtemail";
            this.txtemail.PlaceholderText = "PPPPPPP@gmail.com";
            this.txtemail.Size = new System.Drawing.Size(481, 27);
            this.txtemail.TabIndex = 35;
            // 
            // AddPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(751, 567);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboGender);
            this.Controls.Add(this.Txtmedichistory);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BtnAddPatientclear);
            this.Controls.Add(this.TxtPhone1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtAge);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtAddress);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnAddPatient);
            this.Controls.Add(this.BtnExitPatient);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddPatient";
            this.Text = "AddPatient";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Button BtnExitPatient;
        private Button BtnAddPatient;
        private Label label1;
        private Label label2;
        private TextBox TxtName;
        private Label label5;
        private TextBox TxtAddress;
        private Label label6;
        private TextBox TxtAge;
        private Label label7;
        private TextBox TxtPhone1;
        private Button BtnAddPatientclear;
        private Label label8;
        private TextBox Txtmedichistory;
        private ComboBox comboGender;
        private Label label3;
        private Label label4;
        private TextBox txtemail;
    }
}
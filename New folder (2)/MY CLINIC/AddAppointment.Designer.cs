namespace MY_CLINIC
{
    partial class AddAppointment
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
            this.BtnExitAppointment = new System.Windows.Forms.Button();
            this.BtnAddAppointment = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboPatient = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MY_CLINIC.Properties.Resources.logo11;
            this.pictureBox1.Location = new System.Drawing.Point(224, -1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(224, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // BtnExitAppointment
            // 
            this.BtnExitAppointment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.BtnExitAppointment.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnExitAppointment.FlatAppearance.BorderSize = 0;
            this.BtnExitAppointment.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.BtnExitAppointment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BtnExitAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExitAppointment.ForeColor = System.Drawing.Color.White;
            this.BtnExitAppointment.Location = new System.Drawing.Point(0, -1);
            this.BtnExitAppointment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnExitAppointment.Name = "BtnExitAppointment";
            this.BtnExitAppointment.Size = new System.Drawing.Size(50, 32);
            this.BtnExitAppointment.TabIndex = 15;
            this.BtnExitAppointment.Text = "X";
            this.BtnExitAppointment.UseVisualStyleBackColor = false;
            this.BtnExitAppointment.Click += new System.EventHandler(this.BtnExitAppointment_Click);
            // 
            // BtnAddAppointment
            // 
            this.BtnAddAppointment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.BtnAddAppointment.FlatAppearance.BorderSize = 0;
            this.BtnAddAppointment.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.BtnAddAppointment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.BtnAddAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddAppointment.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnAddAppointment.ForeColor = System.Drawing.Color.White;
            this.BtnAddAppointment.Location = new System.Drawing.Point(224, 454);
            this.BtnAddAppointment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnAddAppointment.Name = "BtnAddAppointment";
            this.BtnAddAppointment.Size = new System.Drawing.Size(224, 44);
            this.BtnAddAppointment.TabIndex = 16;
            this.BtnAddAppointment.Text = "Add Appointment";
            this.BtnAddAppointment.UseVisualStyleBackColor = false;
            this.BtnAddAppointment.Click += new System.EventHandler(this.BtnAddAppointment_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Select the patient";
            // 
            // comboPatient
            // 
            this.comboPatient.FormattingEnabled = true;
            this.comboPatient.Location = new System.Drawing.Point(224, 172);
            this.comboPatient.Name = "comboPatient";
            this.comboPatient.Size = new System.Drawing.Size(224, 28);
            this.comboPatient.TabIndex = 18;
            // 
            // AddAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(686, 553);
            this.Controls.Add(this.comboPatient);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnAddAppointment);
            this.Controls.Add(this.BtnExitAppointment);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddAppointment";
            this.Text = "AddAppointment";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Button BtnExitAppointment;
        private Button BtnAddAppointment;
        private Label label1;
        private ComboBox comboPatient;
    }
}
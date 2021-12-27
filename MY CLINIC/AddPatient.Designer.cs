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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MY_CLINIC.Properties.Resources.logo11;
            this.pictureBox1.Location = new System.Drawing.Point(225, -2);
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
            this.BtnAddPatient.Location = new System.Drawing.Point(225, 459);
            this.BtnAddPatient.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnAddPatient.Name = "BtnAddPatient";
            this.BtnAddPatient.Size = new System.Drawing.Size(224, 44);
            this.BtnAddPatient.TabIndex = 15;
            this.BtnAddPatient.Text = "Add Patient";
            this.BtnAddPatient.UseVisualStyleBackColor = false;
            this.BtnAddPatient.Click += new System.EventHandler(this.BtnAddPatient_Click);
            // 
            // AddPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(686, 553);
            this.Controls.Add(this.BtnAddPatient);
            this.Controls.Add(this.BtnExitPatient);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddPatient";
            this.Text = "AddPatient";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox1;
        private Button BtnExitPatient;
        private Button BtnAddPatient;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MY_CLINIC
{
    public partial class AddPatient : Form
    {
        public AddPatient()
        {
            InitializeComponent();
        }

        private void BtnExitPatient_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAddPatient_Click(object sender, EventArgs e)
        {
            try
            {
                
                Register_Patient();


                string firstname = TxtName.Text;
              
                int age = int.Parse(TxtAge.Text);
                string address = TxtAddress.Text;
                string phones = TxtPhone1.Text;
                string medical_history = Txtmedichistory.Text;
                string gender = comboGender.Text;
                string email = txtemail.Text;
                DataBase.Register_Patient(firstname, age, phones, gender, email, medical_history);
                this.Close();
            }
            catch
            {
                MessageBox.Show("Please fill the form and enter the correct data type!");
            }
        }

        private void Register_Patient()
        {
            

            throw new NotImplementedException();
        }

        private void BtnAddPatientclear_Click(object sender, EventArgs e)
        {
            TxtName.Text = "";
            comboGender.Text = "";
            TxtPhone1.Text = "";
            
            TxtAge.Text = "";
            TxtAddress.Text = "";
            Txtmedichistory.Text = "";
        }
    }
}

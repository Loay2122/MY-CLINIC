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
    public partial class Regestration : Form
    {
        public Regestration()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Btnregister_Click(object sender, EventArgs e)
        {
            DataBase.Register_Emp(Txtusername.Text,Txtpassword.Text,Txtname.Text,Txtphone.Text,float.Parse(Txtsalary.Text));
            if (string.IsNullOrEmpty(Txtusername.Text) || string.IsNullOrEmpty(Txtpassword.Text) || string.IsNullOrEmpty(Txtname.Text) || string.IsNullOrEmpty(Txtphone.Text) || string.IsNullOrEmpty(Txtsalary.Text
                ))
            {
                MessageBox.Show("please fill the form");
            }
            else
            {
                MessageBox.Show("Registertion successful");
            }
        }

        private void BtnExitreg_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void Btnregister_MouseEnter(object sender, EventArgs e)
        {
            Btnregister.BackColor = Color.Red;
        }

        private void BtnExitreg_MouseEnter(object sender, EventArgs e)
        {
            BtnExitreg.BackColor = Color.Red;
        }

        private void Btnregister_MouseMove(object sender, MouseEventArgs e)
        {
            Btnregister.BackColor = Color.Red;
        }

        private void BtnExitreg_MouseMove(object sender, MouseEventArgs e)
        {
            BtnExitreg.BackColor = Color.Red;
        }
    }
}

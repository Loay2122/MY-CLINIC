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
                //Put
                //Your Code
                //Here
                this.Close();
            }
            catch
            {
                MessageBox.Show("Please fill the form and enter the correct data type!");
            }
        }
    }
}

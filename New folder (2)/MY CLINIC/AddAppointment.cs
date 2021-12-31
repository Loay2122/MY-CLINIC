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
    public partial class AddAppointment : Form
    {
        public AddAppointment()
        {
            InitializeComponent();
            int count = DataBase.Get_AllPatient().Rows.Count;
            for (int i = 0; i < count; i++)

            {
                comboPatient.Items.Add(DataBase.Get_AllPatient().Rows[i][0]);
            }
        }

        private void BtnExitAppointment_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAddAppointment_Click(object sender, EventArgs e)
        {
            try
            {
                //Put
                //Your code
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

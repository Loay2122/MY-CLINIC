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
            int count1 = DataBase.Get_AllServices().Rows.Count;
            for (int i = 0; i < count1; i++)

            {
                comboServ1.Items.Add(DataBase.Get_AllServices().Rows[i][0]);
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
                if (GlobalVar.Date != DataBase.Get_ScheduleDate())
                {
                    DataBase.Delete_Schedule();
                    DataBase.Register_Appointment(GlobalVar.Generate_ID(comboServ1.SelectedItem.ToString()), comboPatient.SelectedItem.ToString()
                    , GlobalVar.n, comboServ1.SelectedItem.ToString(), DataBase.Get_ServPrice(comboServ1.SelectedItem.ToString()),
                    GlobalVar.Date, GlobalVar.Generate_Hours(GlobalVar.Start, 3));
                    DataBase.Add_toSchedule(GlobalVar.Generate_ID(comboServ1.SelectedItem.ToString()), comboPatient.SelectedItem.ToString()
                    , GlobalVar.n, comboServ1.SelectedItem.ToString(), DataBase.Get_ServPrice(comboServ1.SelectedItem.ToString()),
                    GlobalVar.Date, GlobalVar.Generate_Hours(GlobalVar.Start, DataBase.Get_ServiceTime(comboServ1.SelectedItem.ToString())));
                }
                else
                {
                    DataBase.Register_Appointment(GlobalVar.Generate_ID(comboServ1.SelectedItem.ToString()), comboPatient.SelectedItem.ToString()
                    , GlobalVar.n, comboServ1.SelectedItem.ToString(), DataBase.Get_ServPrice(comboServ1.SelectedItem.ToString()),
                    GlobalVar.Date, GlobalVar.Generate_Hours(GlobalVar.Start, 3));
                    DataBase.Add_toSchedule(GlobalVar.Generate_ID(comboServ1.SelectedItem.ToString()), comboPatient.SelectedItem.ToString()
                    , GlobalVar.n, comboServ1.SelectedItem.ToString(), DataBase.Get_ServPrice(comboServ1.SelectedItem.ToString()),
                    GlobalVar.Date, GlobalVar.Generate_Hours(GlobalVar.Start, DataBase.Get_ServiceTime(comboServ1.SelectedItem.ToString())));
                }
                this.Close();
            }
            catch
            {
                MessageBox.Show("Please fill the form and enter the correct data type!");
            }
        }
    }
}

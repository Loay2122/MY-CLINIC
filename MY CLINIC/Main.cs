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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            if (!GlobalVar.b)
            {
                BtnFinancialReport.Visible = false;
                BtnManageEmp.Visible = false;
                panelEmpSubMenu.Visible = false;
                panelReportSubMenu.Visible = false;
            }
            if (GlobalVar.hour <= 11 && GlobalVar.hour >= 4)
            {
                labelMsg.Text = "Good Morning, " + GlobalVar.n + ".";
            }
            else if(GlobalVar.hour >= 11 && GlobalVar.hour <= 16)
            {
                labelMsg.Text = "Good Afternoon, " + GlobalVar.n + ".";
            }
            else labelMsg.Text = "Good Evening, " + GlobalVar.n + ".";
        }
        private void HideSubMenu()
        {
            if (panelAppointmentSubMenu.Visible == true)
            {
                panelAppointmentSubMenu.Visible = false;
            }
            if (panelEmpSubMenu.Visible == true)
            {
                panelEmpSubMenu.Visible = false;
            }
            if (panelReportSubMenu.Visible == true)
            {
                panelReportSubMenu.Visible = false;
            }
            if (panelSettingsSubMenu.Visible == true)
            {
                panelSettingsSubMenu.Visible = false;
            }
        }
        private void ShowSubMenu(Panel SubMenu)
        {
            if (SubMenu.Visible == false)
            {
                HideSubMenu();
                SubMenu.Visible = true;
            }
            else
            {
                SubMenu.Visible = false;
            }
        }

        private Form ActiveForm = null;
        private void OpenChildForm(Form childForm)
        {
            if(ActiveForm != null)
            {
                ActiveForm.Close();
            }
            ActiveForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock= DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void BtnAppointmentSubMenu_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelAppointmentSubMenu);
        }

        private void BtnAddEmp_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelEmpSubMenu);
        }

        private void BtnFinancialReport_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelReportSubMenu);
        }

        private void BtnWorkSettings_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelSettingsSubMenu);
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnHelp_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void BtnSignOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form login = new LogIn();
            login.Closed += (s, args) => this.Close();
            login.ShowDialog();
        }
    }
}

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
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
            TxtPass.PasswordChar = '*';
        }


        private void BtnLogIn_Click(object sender, EventArgs e)
        {
            bool i = DataBase.Login(TxtUser.Text, TxtPass.Text);
            if (i)
            {
                GlobalVar.b = DataBase.IsAdmin(TxtUser.Text, TxtPass.Text);
                GlobalVar.n = DataBase.Get_Empname(TxtUser.Text, TxtPass.Text);
                this.Hide();
                Form main = new Main();
                main.ShowDialog();
                this.Close();
            }
            else MessageBox.Show("Incorrect username or password!");
            //try
            //{
            //    DataBase.register(textBox1.Text,textBox2.Text,textBox3.Text);
            //    this.Hide();
            //    Form main = new Main();
            //    main.ShowDialog();
            //    this.Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void checkBoxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            TxtPass.PasswordChar = checkBoxShowPass.Checked ? '\0' : '*';
        }
    }
}

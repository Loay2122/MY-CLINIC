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
        }


        private void BtnLogIn_Click(object sender, EventArgs e)
        {
            bool i = DataBase.Login(TxtUser.Text, TxtPass.Text);
            if (i)
            {
                this.Hide();
                Form main = new Main();
                main.ShowDialog();
                this.Close();
            }
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
    }
}

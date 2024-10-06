using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SE_BBMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox_Show_Hide_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Show_Hide.Checked)
            {
                txtpassword.UseSystemPasswordChar = true;
            }
            else
            {
                txtpassword.UseSystemPasswordChar = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtUserName.Text=="bbms" && txtpassword.Text=="123456")
            {
                new Form2().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Check Your UserName or Password, Try Again");
                txtUserName.Clear();
                txtpassword.Clear();
                txtUserName.Focus();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            txtUserName.Clear();
            txtpassword.Clear();
            txtUserName.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

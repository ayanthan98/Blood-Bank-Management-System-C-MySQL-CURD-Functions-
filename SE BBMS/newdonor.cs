using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SE_BBMS
{
    public partial class newdonor : Form
    {
        public newdonor()
        {
            InitializeComponent();
        }
        db o = new db();
     

        private void newdonor_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Save
            try
            {
                o.con.Open();
                string query = "INSERT INTO new donor (dname,fname,mname,dob,mobile,gender,email,bloodgroup,city,daddress) values ('"+this.txtname.Text+ "','" + this.txtfname.Text + "','" + this.txtmname.Text + "','" + this.txtdob.Text + "','" + this.txtmobile.Text + "','" + this.txtgender.Text + "','" + this.txtemail.Text + "','" + this.txtbloodgroup.Text + "','" + this.txtcity.Text + "','" + this.txtaddress.Text + "',)";
                MySqlCommand cmd = new MySqlCommand(query, o.con);
                MySqlDataReader dataReader;
                dataReader = cmd.ExecuteReader();
                MessageBox.Show("Save Sucessfully");
                o.con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

            }
        }
    }
}

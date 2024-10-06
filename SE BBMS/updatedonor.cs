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
    public partial class updatedonor : Form
    {
        public updatedonor()
        {
            InitializeComponent();
            dispalyrollnumber();
        }
        db o = new db(); // conetect from db 

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        public void dispalyrollnumber()
        {
            // combo box roll number 
            try
            {
                o.con.Open();
                String dispalyrollnumberquery = "SELECT * FROM bbms.newdonor;";
                MySqlCommand cmd = new MySqlCommand(dispalyrollnumberquery, o.con);
                MySqlDataReader dataReader;
                dataReader = cmd.ExecuteReader();
                //loop to read the data
                while (dataReader.Read())
                {
                    string rollno = dataReader.GetString("did");
                    comboBoxrollno.Items.Add(rollno);
                    
                }
                //o.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                o.con.Close();
            }
        }
        
        private void comboBoxrollno_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                o.con.Open();
                String query = "SELECT * FROM bbms.newdonor where did='" + comboBoxrollno.Text + "'";
                MySqlCommand cmd = new MySqlCommand(query, o.con);
                MySqlDataReader dataReader;
                dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    string donorname = dataReader.GetString("dname");
                    txtname.Text = donorname;

                    string fathername = dataReader.GetString("fname");
                    txtfname.Text = fathername;

                    string mothername = dataReader.GetString("mname");
                    txtmname.Text = mothername;

                    string dateofbirth = dataReader.GetString("dob");
                    txtdob.Text = dateofbirth;

                    string phono = dataReader.GetString("mobile");
                    txtmobile.Text = phono;

                    string gend = dataReader.GetString("gender");
                    txtgender.Text = gend;

                    string mail = dataReader.GetString("email");
                    txtemail.Text = mail;

                    string bloodg = dataReader.GetString("bloodgroup");
                    txtbloodgroup.Text = bloodg;

                    string cit = dataReader.GetString("city");
                    txtcity.Text = cit;

                    string addres = dataReader.GetString("daddress");
                    txtaddress.Text = addres;





                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                o.con.Close();
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //update button
            try
            {
                
                o.con.Open();
                string updatequery = "UPDATE bbms.newdonor SET dname='"+txtname.Text+ "',fname='"+txtfname.Text+ "',mname='"+txtmname.Text+ "',dob='"+txtdob.Text+ "',mobile='"+txtmobile.Text+ "',email='"+txtemail.Text+ "',bloodgroup='"+txtbloodgroup.Text+ "',city='"+txtcity.Text+ "',daddress='"+txtaddress.Text+ "' where did='"+comboBoxrollno.Text +"' ";

                
                MySqlCommand cmd = new MySqlCommand(updatequery, o.con);
                MySqlDataReader dataReader;
                dataReader = cmd.ExecuteReader();
                MessageBox.Show("Update Sucessfully");
                o.con.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                o.con.Close();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtname.Clear();
            txtfname.Clear();
            txtmname.Clear();
            //dob
            txtmobile.Clear();
            //gender
            txtemail.Clear();
            //bloodgroup
            txtcity.Clear();
            txtaddress.Clear();
            txtname.Focus();
        }
    }
}

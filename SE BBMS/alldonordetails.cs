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
    public partial class alldonordetails : Form
    {
        public alldonordetails()
        {
            InitializeComponent();
        }
        db o = new db();
        db ob = new db();
        

        private void button2_Click(object sender, EventArgs e)
        {
            //CLOSE
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void alldonordetails_Load(object sender, EventArgs e)
        {
          try
            {
                o.con.Open();
                 string query = "SELECT * FROM bbms.newdonor;";
                //note my all donor
                MySqlCommand cmd = new MySqlCommand(query, o.con);
                MySqlDataAdapter myadapter = new MySqlDataAdapter();
                myadapter.SelectCommand = cmd;
                DataTable dtable = new DataTable();
                myadapter.Fill(dtable);
                dataGridView1.DataSource = dtable;
                o.con.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
    }
}

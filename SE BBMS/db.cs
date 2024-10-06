using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Threading.Tasks;


namespace SE_BBMS
{
    class db
    {
        public MySqlConnection con;
        public db()
        {
            try
            {
                string str = "server=localhost;username=root;password=123456;database=bbms" ;
                con = new MySqlConnection(str);
                //con.Open();
                //MessageBox.Show("Database Coneted"); 
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

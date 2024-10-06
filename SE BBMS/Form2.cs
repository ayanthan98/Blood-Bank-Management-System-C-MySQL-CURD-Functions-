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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Add New Donor Menu
            new newdonor().Show();
        }

        private void updateDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Open Update Donor Menu
            new updatedonor().Show();
        }

        private void softwareUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Update
            MessageBox.Show("Still no updates, Contact the Developers");
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Logout
            new Form1().Show();
            this.Hide();
           
        }

        private void allDonorDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // all donor deatils menu
            new alldonordetails().Show();
        }

        private void bloodGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //search blood doner  by blood  group
            new sbloodgroup().Show();
        }

        private void locationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //search blood doner by location
            new slocation().Show();
        }

        private void increaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // stock increase
            new stockin().Show();
        }

        private void decreaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //stock decrease
            new stockdec().Show();
        }

        private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Blood deatails
            new stockdetails().Show();
        }

        private void deleteDonorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //delete donor
            new deletedonor().Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //about
            new about().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBapplication
{
    public partial class Admin_Addition : Form
    {
        Controller controllerObj;
        public Admin_Addition()
        {  
            controllerObj = new Controller();

           InitializeComponent();
            DataTable dt = controllerObj.ShowAllAdmins();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Make_Admin_Click(object sender, EventArgs e)
        {   if (textBox1.Text == "")
                MessageBox.Show("User_ID is not empty");
            int r=controllerObj.AddAdmin(Convert.ToInt32(textBox1.Text));
            if(r==0)
            {
             MessageBox.Show("User is an Organizer or no user with that UserID");
             return;   
            }
            DataTable dt = controllerObj.ShowAllAdmins();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void Admin_Addition_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}

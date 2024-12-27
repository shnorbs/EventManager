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
    public partial class ChangePassword : Form
    { Controller cont;
        public ChangePassword()
        {
            cont = new Controller();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Change_Password_Click(object sender, EventArgs e)
        {if(emailBox.Text==""||passwordBox.Text==""||NewPasswordbox.Text==""||ConfirmPasswordbox.Text=="")
            {
                MessageBox.Show("Please enter all information");
                return; 
            }
            if(!(cont.LogIn(emailBox.Text, passwordBox.Text)>0) )
            {
                MessageBox.Show("Please enter an existing email and password\n if you don't have an account you can sign up");
                return;
            }
            if(NewPasswordbox.Text!=ConfirmPasswordbox.Text)
            {
                MessageBox.Show("Confirmed Password does not match the new one,Please try agian.");
                return;

            }
            int r =cont.ChangePassword(emailBox.Text, NewPasswordbox.Text);
            if(r>0)
                MessageBox.Show("Successfully changed password");
            else
                MessageBox.Show("Failed to change password");
        }
    }
}

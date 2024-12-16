using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBapplication
{
    public partial class Welcome : Form
    {
        Controller cont = new Controller();
        public Welcome()
        {
            InitializeComponent();
        }

        private void regBtn_Click(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {

            if (cont.LogIn(emailBox.Text, passwordBox.Text) > 0)
            {
                if (cont.getUserType(emailBox.Text, passwordBox.Text) == "Admin")
                {
                    AdminModeSelect f = new AdminModeSelect(cont.getUserID(emailBox.Text, passwordBox.Text));
                    f.Show();
                }
                else
                {
                    Event_Calendar f = new Event_Calendar(cont.getUserID(emailBox.Text, passwordBox.Text), cont.getUserType(emailBox.Text, passwordBox.Text));
                    f.Show();                  
                }
            }

            else
            {
                MessageBox.Show("Please enter a correct Email and Password!");
            }

        }

        private void Welcome_Load(object sender, EventArgs e)
        {

        }
    }

}



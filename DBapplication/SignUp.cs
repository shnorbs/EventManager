using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace DBapplication
{
    public partial class SignUp : Form
    {
        Controller cont  = new Controller();
        public SignUp()
        {
            InitializeComponent();
            specBox.Enabled = false;
            numberBox.MaxLength = 10;
        }

        private void finishBtn_Click(object sender, EventArgs e)
        {
            if (emailBox.Text == "" && passBox.Text == "" )
            {
                MessageBox.Show("Please enter your information");
                return;
            }

            if (emailBox.Text == "")
            {
                MessageBox.Show("Email field cannot be empty!");
                return;
            }

            if (passBox.Text == "")
            {
                MessageBox.Show("Password field cannot be empty!");
                return;
            }

            if (!IsEmailValid())
            {
                MessageBox.Show("Please enter a valid email!");
                return;
            }

            if (!IsUnique())
            {
                MessageBox.Show("This email already exists!");
                return;
            }


            if (Normal_User.Checked)
            {
                if (lnameBox.Text == "")
                    cont.AddUser(fnameBox.Text, "Normal_User", emailBox.Text, passBox.Text, Int64.Parse(numberBox.Text));
                else
                    cont.AddUserWithLastName(fnameBox.Text, lnameBox.Text, "Normal_User", emailBox.Text, passBox.Text, Int64.Parse(numberBox.Text));

                MessageBox.Show("Success!");
                return;
            }

            if (Organizer.Checked)
            {
                if(lnameBox.Text == "")
                {
                    if (specCombo.SelectedItem.ToString() == "Other")
                        cont.AddOrganzier(fnameBox.Text, "Organizer", emailBox.Text, passBox.Text, Int64.Parse(numberBox.Text), specBox.Text);

                    else
                        cont.AddOrganzier(fnameBox.Text, "Organizer", emailBox.Text, passBox.Text, Int64.Parse(numberBox.Text), specCombo.SelectedItem.ToString());

                }
                else
                {
                    if (specCombo.SelectedItem.ToString() == "Other")
                        cont.AddOrganzierWithLastName(fnameBox.Text, lnameBox.Text, "Organizer", emailBox.Text, passBox.Text, Int64.Parse(numberBox.Text), specBox.Text);

                    else
                        cont.AddOrganzierWithLastName(fnameBox.Text, lnameBox.Text, "Organizer", emailBox.Text, passBox.Text, Int64.Parse(numberBox.Text), specCombo.SelectedItem.ToString());
                }


                MessageBox.Show("Success!");
                return;
            }


        }
        public bool IsUnique() 
        {
            return (cont.CheckUniqueEmail(emailBox.Text) ==  0) ? true : false;
        }

        public bool IsEmailValid()
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            Regex reg = new Regex(pattern,RegexOptions.IgnoreCase);
            return reg.IsMatch(emailBox.Text);
        }

        private void specCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (specCombo.SelectedItem.ToString() == "Other")
            {
                specBox.Enabled = true;
            }
            else
            {
                specBox.Enabled = false;
            }
        }

        private void numberBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void numberBox_TextChanged(object sender, EventArgs e)
        {
            if (numberBox.Text.Length == 10)
            {
                numberBox.ForeColor = Color.Black;
            }
            else
            {
                numberBox.ForeColor = Color.Red;
            }
        }
    }
}


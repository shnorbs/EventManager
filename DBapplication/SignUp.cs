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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

            emailBox.GotFocus += new EventHandler((sender, e) => RemovePlaceholderText(sender, e, "E-Mail"));
            emailBox.LostFocus += new EventHandler((sender, e) => SetPlaceholderText(sender, e, "E-Mail"));

            passBox.GotFocus += new EventHandler((sender, e) => RemovePlaceholderText(sender, e, "Password"));
            passBox.LostFocus += new EventHandler((sender, e) => SetPlaceholderText(sender, e, "Password"));

            fnameBox.GotFocus += new EventHandler((sender, e) => RemovePlaceholderText(sender, e, "First Name"));
            fnameBox.LostFocus += new EventHandler((sender, e) => SetPlaceholderText(sender, e, "First Name"));

            lastnameBox.GotFocus += new EventHandler((sender, e) => RemovePlaceholderText(sender, e, "Last Name"));
            lastnameBox.LostFocus += new EventHandler((sender, e) => SetPlaceholderText(sender, e, "Last Name"));

            numberBox.GotFocus += new EventHandler((sender, e) => RemovePlaceholderText(sender, e, "Phone Number"));
            numberBox.LostFocus += new EventHandler((sender, e) => SetPlaceholderText(sender, e, "Phone Number"));
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
                if (lastnameBox.Text == "")
                    cont.AddUser(fnameBox.Text, "Normal_User", emailBox.Text, passBox.Text, Int64.Parse(numberBox.Text));
                else
                    cont.AddUserWithLastName(fnameBox.Text, lastnameBox.Text, "Normal_User", emailBox.Text, passBox.Text, Int64.Parse(numberBox.Text));

                MessageBox.Show("Success!");
                return;
            }

            if (Organizer.Checked)
            {
                if(lastnameBox.Text == "")
                {
                    if (specCombo.SelectedItem.ToString() == "Other")
                        cont.AddOrganzier(fnameBox.Text, "Organizer", emailBox.Text, passBox.Text, Int64.Parse(numberBox.Text), specBox.Text);

                    else
                        cont.AddOrganzier(fnameBox.Text, "Organizer", emailBox.Text, passBox.Text, Int64.Parse(numberBox.Text), specCombo.SelectedItem.ToString());

                }
                else
                {
                    if (specCombo.SelectedItem.ToString() == "Other")
                        cont.AddOrganzierWithLastName(fnameBox.Text, lastnameBox.Text, "Organizer", emailBox.Text, passBox.Text, Int64.Parse(numberBox.Text), specBox.Text);

                    else
                        cont.AddOrganzierWithLastName(fnameBox.Text, lastnameBox.Text, "Organizer", emailBox.Text, passBox.Text, Int64.Parse(numberBox.Text), specCombo.SelectedItem.ToString());
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
            if (specCombo.Text != "Specialization")
            {
                specCombo.ForeColor = Color.Black;
            }

            if (specCombo.SelectedItem.ToString() == "Other (Enter Manually)")
            {
                specBox.Enabled = true;
                specBox.BackColor = Color.White;
            }
            else
            {
                specBox.Enabled = false;
                specBox.BackColor = Color.Silver;
                specBox.Text = "";
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
        private void SetPlaceholderText(object sender, EventArgs e, string placeholder) 
        {
            System.Windows.Forms.TextBox textBox = sender as System.Windows.Forms.TextBox;
            if (string.IsNullOrEmpty(textBox.Text)) 
            {
                textBox.Text = placeholder; 
                textBox.ForeColor = Color.Gray; 
            } 
        }

        private void RemovePlaceholderText(object sender, EventArgs e, string placeholder) 
        {
            System.Windows.Forms.TextBox textBox = sender as System.Windows.Forms.TextBox; 
            if (textBox.Text == placeholder) 
            { 
                textBox.Text = ""; 
                textBox.ForeColor = Color.Black; 
            } 
        }

        private void Organizer_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Normal_User_CheckedChanged(object sender, EventArgs e)
        {
        
        }

        private void emailBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


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
    public partial class AddVenue : Form
    {
        Controller controllerObj = new Controller();
        int uID = 0;
        public AddVenue(int userID)
        {
            InitializeComponent();
        }

        private void AddVenue_button_Click(object sender, EventArgs e)
        {
            if(VenueName_textbox.Text.Length==0)
            {
                MessageBox.Show("Please Enter Venue Name");
                return;
            }
            if(int.TryParse(Capacity_textbox.Text,out int check)==false&&check>0)
            {
                MessageBox.Show("Please Enter a positive capacity number");
                return;
            }
            if(Capacity_textbox.Text.Length==0)
            {
                MessageBox.Show("Please Enter Capacity");
                return;
            }
            if (int.TryParse(BookingPrice_textbox.Text, out int check1) == false && check1 > 0)
            {
                MessageBox.Show("Please Enter a positive booking price number");
                return;
            }
            string VenueAddress = VenueAddress_textbox.Text;
            string VenueName= VenueName_textbox.Text;
            int Capacity = Convert.ToInt32(Capacity_textbox.Text);
            int BookingPrice=Convert.ToInt32(BookingPrice_textbox.Text);
            controllerObj.AddVenue(VenueAddress,VenueName,Capacity,BookingPrice);
        }

        private void Return_button_Click(object sender, EventArgs e)
        {
            AddEvent Av = new AddEvent(uID);
            Av.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            if (Regex.IsMatch(VenueName_textbox.Text, @"^[a-zA-Z]+$") == false)
            {
                MessageBox.Show("Please Enter only letters in venue name");
                return;
            }
            if (int.TryParse(Capacity_textbox.Text,out int check)==false||check<0)
            {
                MessageBox.Show("Please Enter a positive capacity number");
                return;
            }
            if(Capacity_textbox.Text.Length==0)
            {
                MessageBox.Show("Please Enter Capacity");
                return;
            }
            if (double.TryParse(BookingPrice_textbox.Text, out double check1) == false || check1 < 0)
            {
                MessageBox.Show("Please Enter a positive booking price number");
                return;
            }
            string FacilityType;
            string VenueAddress = VenueAddress_textbox.Text;
            string VenueName= VenueName_textbox.Text;
            int Capacity = Convert.ToInt32(Capacity_textbox.Text);
            float BookingPrice=(float)Convert.ToDouble(BookingPrice_textbox.Text);
            for (int i = 0; i < FacilityTypeDataGrid.Rows.Count - 1; i++)
            {
                if(FacilityTypeDataGrid.Rows[i].Cells[0].Value.ToString().Length==0)
                {
                    MessageBox.Show("Please Enter Facility type");
                    return;
                }
                if (Regex.IsMatch(FacilityTypeDataGrid.Rows[i].Cells[0].Value.ToString(), @"^[a-zA-Z]+$")==false)
                {
                    MessageBox.Show("Please Enter only letters in facility type");
                    return;
                }
            }
            controllerObj.AddVenue(VenueAddress, VenueName, Capacity, BookingPrice);
            for (int i = 0; i < FacilityTypeDataGrid.Rows.Count - 1; i++)
            {
                FacilityType= FacilityTypeDataGrid.Rows[i].Cells[0].Value.ToString();
                controllerObj.AddFacility(VenueName, FacilityType);
            }
        }

        private void FacilityType_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddVenue_Load(object sender, EventArgs e)
        {

        }
    }
}

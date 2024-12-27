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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DBapplication
{
    public partial class AddEvent : Form
    {
        Controller controllerObj = new Controller();

        int userID = 0;
        public AddEvent(int uID)
        {
            InitializeComponent();
            userID = uID;
            DataTable dt1 = controllerObj.SelectLocation();
            Location_combobox.DataSource = dt1;
            Location_combobox.DisplayMember = "Venue_Name";
            Location_combobox.ValueMember = "Venue_ID";
        }

        private void AddEvent_Load(object sender, EventArgs e)
        {

        }

        private void AddEvent_button_Click(object sender, EventArgs e)
        {

            if(EventName_textbox.Text.Length==0)
            {
                MessageBox.Show("Please Enter Event Name");
                return;
            }
            string EventName=EventName_textbox.Text;
            string EventDate = Convert.ToString(EventDate_picker.Value);
            string Description = Description_textbox.Text;
            string EventType =EventType_combobox.Text;
            string StartTime = Convert.ToString(StartTime_picker.Text);
            string EndTime = Convert.ToString(EndTime_picker.Text);
            int Privacy = 0;
            if(Private_checkbox.Checked)
            {
                Privacy = 1;
            }
            else
            {
                Privacy = 0;
            }
            int Location =Convert.ToInt32(Location_combobox.SelectedValue);

            for (int i = 0; i < TicketsDataGrid.Rows.Count - 1; i++)
            {
                if (TicketsDataGrid.Rows[i].Cells[0].Value.ToString().Length==0&& TicketsDataGrid.Rows[i].Cells[1].Value.ToString().Length==0&& TicketsDataGrid.Rows[i].Cells[2].Value.ToString().Length==0)
                {
                    MessageBox.Show("Please Enter all fields");
                    return;
                }
                if (Regex.IsMatch(TicketsDataGrid.Rows[i].Cells[0].Value.ToString(), @"^[a-zA-Z]+$") == false)
                {
                    MessageBox.Show("Please enter only letters in ticket type");
                    return;
                }
                if (double.TryParse(TicketsDataGrid.Rows[i].Cells[1].Value.ToString(),out double check)==false||check<0)
                {
                    MessageBox.Show("Please enter the price as a positive number");
                    return;
                }
                if(int.TryParse(TicketsDataGrid.Rows[i].Cells[2].Value.ToString(),out int check2)==false||check2<0)
                {
                    MessageBox.Show("Please enter the number of tickets as a positive number");
                    return;
                }
            }
            controllerObj.AddEvent(EventName, userID, EventDate, Description, EventType, StartTime, EndTime, Privacy, Location);
            for (int i = 0; i < TicketsDataGrid.Rows.Count-1; i++)
            {
                string TicketType = TicketsDataGrid.Rows[i].Cells[0].Value.ToString();
                float price =(float)Convert.ToDouble(TicketsDataGrid.Rows[i].Cells[1].Value); 
                int NumberofTickets=Convert.ToInt32(TicketsDataGrid.Rows[i].Cells[2].Value);
                controllerObj.AddTickets(TicketType,price,NumberofTickets,EventName);
            }

            for (int i = 0; i < TicketsDataGrid.Rows.Count - 1; i++)
            {
                if (ServicesDataGrid.Rows[i].Cells[0].Value.ToString().Length == 0 && ServicesDataGrid.Rows[i].Cells[1].Value.ToString().Length == 0 && ServicesDataGrid.Rows[i].Cells[2].Value.ToString().Length == 0)
                {
                    MessageBox.Show("Please Enter all fields");
                    return;
                }
                if(Regex.IsMatch(ServicesDataGrid.Rows[i].Cells[0].Value.ToString(), @"^[a-zA-Z]+$")==false)
                {
                    MessageBox.Show("Please enter only letters in service name");
                    return;
                }
                if (Regex.IsMatch(ServicesDataGrid.Rows[i].Cells[1].Value.ToString(), @"^[a-zA-Z]+$") == false)
                {
                    MessageBox.Show("Please enter only letters in service type");
                    return;
                }
                if (double.TryParse(ServicesDataGrid.Rows[i].Cells[2].Value.ToString(), out double check3) == false || check3 < 0)
                {
                    MessageBox.Show("Please enter the price as a positive number");
                    return;
                }
            }

            for (int i = 0;i < ServicesDataGrid.Rows.Count-1;i++)
            {
                string ServiceName = ServicesDataGrid.Rows[i].Cells[0].Value.ToString();
                string ServiceType = ServicesDataGrid.Rows[i].Cells[1].Value.ToString();
                float Sprice = (float)Convert.ToDouble(ServicesDataGrid.Rows[i].Cells[2].Value);
                controllerObj.AddService(ServiceName, ServiceType, Sprice);
                controllerObj.BookService(ServiceName,EventName,EventDate,Sprice);
            }

            if(Private_checkbox.Checked)
            {
                Invites Fi = new Invites(EventName);
                Fi.Show();
            }
        }

        private void AddVenue_button_Click(object sender, EventArgs e)
        {
            AddVenue Fv = new AddVenue(userID);
            Fv.Show();
        }

        private void Refresh_Button_Click(object sender, EventArgs e)
        {
            DataTable dt1 = controllerObj.SelectLocation();
            Location_combobox.DataSource = dt1;
            Location_combobox.DisplayMember = "Venue_Name";
            Location_combobox.ValueMember = "Venue_ID";

        }

        private void EventName_label_Click(object sender, EventArgs e)
        {

        }
    }
}

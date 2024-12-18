using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            DataTable dt = controllerObj.SelectEventType();
            EventType_combobox.DataSource = dt;
            EventType_combobox.DisplayMember = "Etype";
            EventType_combobox.ValueMember = "Etype";
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
            string EventType = Convert.ToString(EventType_combobox.SelectedValue);
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
            controllerObj.AddEvent(EventName,userID,EventDate,Description,EventType,StartTime,EndTime,Privacy,Location);
        }

        private void AddVenue_button_Click(object sender, EventArgs e)
        {
            AddVenue Fv = new AddVenue(userID);
            Fv.Show();
        }
    }
}

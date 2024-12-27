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
    public partial class PublicEventDetails : Form
    {
        Controller cont = new Controller();
        public PublicEventDetails(string EventName, string StartTime, string EndTime, string VenueName, int EventID, int UserID)
        {
            InitializeComponent();
            eventName.Text = EventName;
            startTimeLbl.Text = StartTime;
            endTimeLbl.Text = EndTime;
            venueName.Text = VenueName;
            description.Text = cont.GetEventDescription(EventID);
            eventType.Text = "(Event Type: " + cont.GetEventType(EventID) + ")";
        }

        private void EventDetails_Load(object sender, EventArgs e)
        {

        }

        private void reminderBtn_Click(object sender, EventArgs e)
        {

        }
    }
}

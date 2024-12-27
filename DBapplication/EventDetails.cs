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

        static DateTime currentDay = DateTime.Now;
        string correctFormat = currentDay.ToString("yyyy-MM-dd");
        
        int UserID;
        int EventID;
        public PublicEventDetails(string EventName, string StartTime, string EndTime, string VenueName, int eID, int uID)
        {
            InitializeComponent();
            eventName.Text = EventName;
            startTimeLbl.Text = StartTime;
            endTimeLbl.Text = EndTime;
            venueName.Text = VenueName;
            description.Text = cont.GetEventDescription(eID);
            eventType.Text = "(Event Type: " + cont.GetEventType(eID) + ")";
            UserID = uID;
            EventID = eID;
         
        }

        private void EventDetails_Load(object sender, EventArgs e)
        {

        }

        private void reminderBtn_Click(object sender, EventArgs e)
        {
            int created = cont.AddReminder(correctFormat, EventID, UserID);
        }

        private void feedbackBtn_Click(object sender, EventArgs e)
        {
            Feedback feedback = new Feedback(UserID, EventID);
            feedback.Show();
        }

        private void reportBtn_Click(object sender, EventArgs e)
        {
            Report f = new Report(UserID, EventID);
            f.Show();
        }
    }
}

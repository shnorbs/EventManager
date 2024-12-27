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
        int ticketcount;
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
            DataTable dt = cont.SelectTicketType(eID);
            Ticket_Type.DisplayMember ="Ticket_Type";
            Ticket_Type.ValueMember = "Ticket_Type";
            Ticket_Type.DataSource = dt;

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

        private void Buy_Click(object sender, EventArgs e)
        {  if(Convert.ToInt32(Number.Text)<0)
            {
                MessageBox.Show("Must buy at least one ticket");
                return;

            }
            DateTime today = DateTime.Today;
            DateTime date = DateTime.Today;
            string ticketType = Ticket_Type.SelectedValue.ToString();
           int r= cont.InsertIntoBuys(ticketType,EventID,UserID,date,Convert.ToInt32(Number.Text));
            if (r > 0)
            { MessageBox.Show("Tickets" + Number.Text + "bought");

                cont.UpdateTicketCount(ticketType, EventID,ticketcount- Convert.ToInt32(Number.Text));
            }
            else
            {
                MessageBox.Show("Transaction failed");
            }
        }

        private void Ticket_Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            ticketcount=cont.GetTicketCount(Ticket_Type.SelectedValue.ToString(), EventID);
        }

        private void button2_Click(object sender, EventArgs e)
        {  
            int updated=Convert.ToInt32(Number.Text)+1;
            if (updated > 10)
            {
                MessageBox.Show("Can only buy 10 at most");
                return;
            }
            Number.Text = updated.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int updated = Convert.ToInt32(Number.Text) -1;
            if (updated < 0)
                return;
            Number.Text = updated.ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Number_Click(object sender, EventArgs e)
        {

        }
    }
}

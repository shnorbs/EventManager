using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
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
            Invites.Enabled = false;
            Invites.Visible = false;
            ViewLink.Visible = false;


            if (cont.GetEventOrganizer(EventID) == UserID)
            {
                Invites.Enabled = true;
                Invites.Visible = true;
                Buy.Enabled = false;
                Buy.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                Number.Visible = false;
                Ticket_Type.Enabled = false;
                Ticket_Type.Visible = false;
                button2.Enabled = false;
                button2.Visible = false;
                button1.Enabled = false;
                button1.Visible = false;
                ViewLink.Visible = true;
            }

            DataTable dt = cont.SelectTicketType(eID);
            bool ticketsExist =cont.Find_if_tickets(EventID);
            if(!ticketsExist)
            {
                string type = cont.getUserTypeByUserID(uID);
                
                Buy.Enabled = false;
                Buy.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                Number.Visible = false;
                Ticket_Type.Enabled = false;
                Ticket_Type.Visible = false;
                button2.Enabled = false;
                button2.Visible = false;
                button1.Enabled = false;
                button1.Visible = false;
                return;
                
            }
         
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
        {  if(Convert.ToInt32(Number.Text)<=0)
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
                int newcount = ticketcount - Convert.ToInt32(Number.Text);
                if (newcount < 0)
                    newcount = 0;
                cont.UpdateTicketCount(ticketType, EventID,newcount);
            }
            else
            {
                MessageBox.Show("Transaction failed");
            }
        }

        private void Ticket_Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            ticketcount=cont.GetTicketCount(Ticket_Type.SelectedValue.ToString(), EventID);
          
            if (ticketcount == 0)
            {
                Buy.Text = "Out of Stock";
                Buy.Enabled = false;

            }
            else
            {
                Buy.Text = "Buy Tickets";
                Buy.Enabled = true;
            }

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

        private void description_Click(object sender, EventArgs e)
        {

        }

        private void Invites_Click(object sender, EventArgs e)
        {
            Invites table = new Invites(eventName.Text);
            table.Show();

        }

        private void ViewLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AllFeedback form = new AllFeedback(UserID, EventID);
            form.Show();
        }
    }
}

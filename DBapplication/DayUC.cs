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
    public partial class DayUC : UserControl
    {
        
        string current_day, current_month, current_year;
        int ID;
        public DayUC(string d, string m, string y,int UserID ,Controller cont)
        {
            InitializeComponent();

            label1.Text = d;

            current_day = d;
            current_month = m;
            current_year = y;
            ID = UserID;
            

            if (d == "")
            {
                this.BackColor = Color.FromArgb(40, 44, 52);
                panel1.Hide();
            }
            else
            {
                int day = int.Parse(d);
                int month = int.Parse(m);
                int year = int.Parse(y);

                string Today = year.ToString() + "-" + month.ToString() + "-" + day.ToString();

                int EventsToday = cont.FindCountPrivateToday(UserID, Today) + cont.FindCountPublicToday(Today);

                if (EventsToday > 1)
                    NoOfEvents.Text = EventsToday.ToString() + " Events";
                else
                    if (EventsToday == 1)
                    NoOfEvents.Text = "1 Event";
                else
                    NoOfEvents.Text = "";

            }

        }

        private void DayUC_Load(object sender, EventArgs e)
        {
            
        }

        private void day_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
        }

        private void DayUC_MouseEnter(object sender, EventArgs e)
        {
           // this.BackColor = Color.FromArgb(40, 0, 52);

        }

        private void DayUC_MouseClick(object sender, EventArgs e)
        {
            if (NoOfEvents.Text != "")
            {
                ViewEventsToday f = new ViewEventsToday(current_day, current_month, current_year, ID);
                f.Show();
            }
        }

        private void NoOfEvents_Click(object sender, EventArgs e)
        {
            if (NoOfEvents.Text != "")
            {
                ViewEventsToday f = new ViewEventsToday(current_day, current_month, current_year, ID);
                f.Show();
            }
        }
    }
}

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
        

        public DayUC(string d, string m, string y,int UserID ,Controller cont)
        {
            InitializeComponent();

            label1.Text = d;
            

            if (d == "")
            {
                this.BackColor = Color.FromArgb(240, 240, 240);
                panel1.Hide();
            }
            else
            {
                int day = int.Parse(d);
                int month = int.Parse(m);
                int year = int.Parse(y);

                string Today = year.ToString() + "-" + month.ToString() + "-" + day.ToString();

                int EventsToday = cont.FindEventsPrivateToday(UserID, Today) + cont.FindPublicEventsToday(Today);

                NoOfEvents.Text = EventsToday.ToString() + " Events";
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

        private void DayUC_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}

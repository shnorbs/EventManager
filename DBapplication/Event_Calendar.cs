using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBapplication
{
    public partial class Event_Calendar : Form
    {
        Controller cont = new Controller();
        public static int current_year, current_month, uID;

        public Event_Calendar(int UserID, string UserType)
        {
            InitializeComponent();
            current_year = 2024;
            current_month = 12;
            uID = UserID;

            if (UserType == "Normal_User") addEventBtn.Hide();
        }

        private void Event_Calendar_Load(object sender, EventArgs e)
        {
            calcDays(current_month, current_year);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void next_Click(object sender, EventArgs e)
        {
            if (current_month == 12)
            {
                current_month = 1;
                current_year++;
                calcDays(current_month, current_year);
            }

            else
            {
                current_month++;
                calcDays(current_month, current_year);
            }
        }

        private void addEventBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void addEventBtn_Click_1(object sender, EventArgs e)
        {
            AddEvent Fevent = new AddEvent(uID);
            Fevent.Show();
        }

        private void panel32_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel20_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void remindersBtn_Click(object sender, EventArgs e)
        {
            RemindersList form = new RemindersList(uID);
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                Form form = Application.OpenForms[i];


                if (form.Name != "Welcome")
                {
                    form.Close();
                }
            }
        }

        private void prev_Click(object sender, EventArgs e)
        {
            if (current_month == 1)
            {
                current_month = 12;
                current_year--;
                calcDays(current_month, current_year);
            }
            else
            {
                current_month--;
                calcDays(current_month, current_year);
            }
        }

        public void calcDays(int mm, int yy)
        {
            flowLayoutPanel1.Controls.Clear(); //clear panels from last month
            string monthName = new DateTimeFormatInfo().GetMonthName(mm); //get month name to put it in the label
            monthLabel.Text = monthName +" \n" +current_year.ToString();
            DateTime first_day = new DateTime(yy, mm, 1); //make a date for the first of the month

            int month_days = DateTime.DaysInMonth(yy, mm); //calculate how many days in the current month
            int month_start = Convert.ToInt32(first_day.DayOfWeek); // find which day the current month starts at

            for (int i = 0; i < month_start; i++)
            {
                DayUC emptyday = new DayUC("", "", "", uID, cont); //add empty panels for days of last month
                flowLayoutPanel1.Controls.Add(emptyday);
            }

            for (int i = 1; i <= month_days; i++)
            {
                DayUC dayPanel = new DayUC(i.ToString(), mm.ToString(), yy.ToString(), uID, cont);  //add day panels of the current month
                flowLayoutPanel1.Controls.Add(dayPanel);
            }
        }
    }
}

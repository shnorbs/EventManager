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
    public partial class Statstics : Form
    {
        Controller controllerObj;
        public Statstics()
        {
            controllerObj = new Controller();
            InitializeComponent();
        }

        private void Organizer_Events_Click(object sender, EventArgs e)
        {
            DataTable dt=  controllerObj.Total_Events_by_Organizer();
            Managerial.DataSource = dt;
            Managerial.Refresh();

        }

        private void EventOrganizers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Popular_Venues_button_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.Most_Popular_Venues();
            Statstical.DataSource = dt;
            Statstical.Refresh();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Statstics_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.Total_Revenue_By_Event();
            Managerial.DataSource = dt;
            Managerial.Refresh();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.Average_Feedback_Rating();
            Statstical.DataSource = dt;
            Statstical.Refresh();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.Attendance_Trends_By_Month();
            Statstical.DataSource = dt;
            Statstical.Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.Ticket_Price_Variance();
            Statstical.DataSource = dt;
            Statstical.Refresh();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.Most_Profitable_Organizer();
            Managerial.DataSource = dt;
            Managerial.Refresh();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.Profit_Gained_By_Organizer();
            Managerial.DataSource = dt;
            Managerial.Refresh();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Statstical_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.Total_Users_Registered();
            Managerial.DataSource = dt;
            Managerial.Refresh();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.Total_Events_By_Type();
            Managerial.DataSource = dt;
            Managerial.Refresh();

        }

        private void button10_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.Feedback_Summary_By_Event();
            Statstical.DataSource = dt;
            Statstical.Refresh();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.Average_Feedback_Rating();
            Statstical.DataSource = dt;
            Statstical.Refresh();
        }
    }
}

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
            EventOrganizers.DataSource = dt;
            EventOrganizers.Refresh();

        }

        private void EventOrganizers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Popular_Venues_button_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.Most_Popular_Venues();
            PopularVenues.DataSource = dt;
            PopularVenues.Refresh();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Statstics_Load(object sender, EventArgs e)
        {

        }
    }
}

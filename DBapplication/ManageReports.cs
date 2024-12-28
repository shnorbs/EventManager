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
    public partial class ManageReports : Form
    {
        Controller controller;
        int ID;
        public ManageReports(int adminID)
        {
            InitializeComponent();
            controller = new Controller();
            ID = adminID;
        }

        private void FeedbackButton_Click(object sender, EventArgs e)
        {
            AdminMode2 form = new AdminMode2(ID);
            form.Show();
        }

        private void EventButton_Click(object sender, EventArgs e)
        {
            AdminMode form = new AdminMode(ID);
            form.Show();
        }
    }
}

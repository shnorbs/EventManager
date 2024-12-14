﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Internal;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBapplication
{
    public partial class ViewEventsToday : Form
    {
        Controller controllerObj = new Controller();

        string Today;
        int ID;
        public ViewEventsToday(string d, string m, string y, int UserID)
        {
            InitializeComponent();
            Today = y + "-" + m + "-" + d;
            ID = UserID;
        }

        private void ViewEventsToday_Load(object sender, EventArgs e)
        {
            DataTable PublicEvents = controllerObj.FindPublicEventsToday(Today);
            DataTable PrivateEvents = controllerObj.FindPrivateEventsToday(ID, Today);

            if (PublicEvents == null)
            {
                dataGridView2.Height = 389;
                dataGridView1.Hide();
                label1.Visible = false;
                label2.Location = new Point(24, 10);
                dataGridView2.Location = new Point(12, 58);
            }
            else
            {
                dataGridView1.DataSource = PublicEvents;
                dataGridView1.Refresh();
            }

            if (PrivateEvents == null)
            {
                dataGridView1.Height = 389;
                dataGridView2.Hide();
                label2.Hide();
            }
            else
            {
                dataGridView2.DataSource = PrivateEvents;
                dataGridView2.Refresh();
            }


        }
    }
}

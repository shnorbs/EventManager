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
    public partial class Report : Form
    {
        Controller cont = new Controller();

        int UserID;
        int EventID;
        public Report(int uID, int eID)
        {
            InitializeComponent();
            UserID = uID;
            EventID = eID;
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            if (commentBox.Text == "")
            {
                MessageBox.Show("Description cannot empty!");
                return;
            }

            cont.AddReport(commentBox.Text, UserID, EventID);
            MessageBox.Show("Report Added!");
        }
    }
}

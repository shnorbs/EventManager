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
    public partial class ReportDetails : Form
    {
        Controller controllerObj;
        int reportID;
        bool isHandled;
        public ReportDetails(int rID, bool handledValue)
        {
            InitializeComponent();
            controllerObj = new Controller();
            reportID = rID;
            isHandled = handledValue;
        }

        private void ReportDetails_Load(object sender, EventArgs e)
        {
            string eventName = controllerObj.getReportedEventName(reportID);
            EventNameBox.Text = eventName;

            string reportDescription = controllerObj.getReportDescription(reportID);
            ReportDescriptionBox.Text = reportDescription;

            if (isHandled)
            {
                BanOrganizerButton.Enabled = false;
                DeleteEventButton.Enabled = false;
                IgnoreButton.Enabled = false;

                AdminReplyBox.ReadOnly = true;
                string adminReply = controllerObj.getAdminReply(reportID);
                AdminReplyBox.Text = adminReply;
            }
        }

        private void BanOrganizerButton_Click(object sender, EventArgs e)
        {
            if (AdminReplyBox.Text == "" || AdminReplyBox.Text == "Enter your response...")
            {
                MessageBox.Show("Please enter your reply/response");
            }
            else
            {
                int result = controllerObj.BanOrganizer(reportID);
                if (result == 0)
                {
                    MessageBox.Show("No rows were deleted");
                }
                else MessageBox.Show("Organizer banned successfully");
                IgnoreButton.Enabled = false;
            }
        }

        private void DeleteEventButton_Click(object sender, EventArgs e)
        {
            if (AdminReplyBox.Text == "" ||  AdminReplyBox.Text == "Enter your response...")
            {
                MessageBox.Show("Please enter your reply/response");
            }
            else
            {
                int result1 = controllerObj.setAdminReply(reportID, AdminReplyBox.Text);
                int result2 = controllerObj.DeleteEvent(reportID);

                if (result1 == 0 || result2 == 0)
                {
                    MessageBox.Show("No rows were deleted");
                }
                else MessageBox.Show("Event deleted successfully");
                IgnoreButton.Enabled = false;
            }
        }

        private void IgnoreButton_Click(object sender, EventArgs e)
        {

        }
    }
}

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

        private bool isPlaceholderVisible = true;
        private readonly string placeholderText = "Enter your response...";
        public ReportDetails(int rID, bool handledValue)
        {
            InitializeComponent();
            controllerObj = new Controller();
            reportID = rID;
            isHandled = handledValue;

            AdminReplyBox.ForeColor = Color.Gray;
            AdminReplyBox.Text = placeholderText;
            AdminReplyBox.GotFocus += AdminReplyBox_GotFocus;
            AdminReplyBox.LostFocus += AdminReplyBox_LostFocus;
        }

        private void AdminReplyBox_GotFocus(object sender, EventArgs e)
        {
            if (isPlaceholderVisible)
            {
                AdminReplyBox.Text = "";
                AdminReplyBox.ForeColor = Color.Black;
                isPlaceholderVisible = false;
            }
        }

        private void AdminReplyBox_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(AdminReplyBox.Text))
            {
                AdminReplyBox.Text = placeholderText;
                AdminReplyBox.ForeColor = Color.Gray;
                isPlaceholderVisible = true;
            }
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

                AdminReplyBox.ForeColor = Color.Black;
                isPlaceholderVisible = false;
            }
        }

        private void BanOrganizerButton_Click(object sender, EventArgs e)
        {
            if (isPlaceholderVisible || AdminReplyBox.Text == "")
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
            if (isPlaceholderVisible || AdminReplyBox.Text == "")
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
            if (isPlaceholderVisible || AdminReplyBox.Text == "")
            {
                MessageBox.Show("Please enter your reply/response");
            }
            else
            {
                int result = controllerObj.setAdminReply(reportID, AdminReplyBox.Text);
                if(result == 0)
                {
                    MessageBox.Show("No rows were deleted");
                }
                else MessageBox.Show("Report handled successfully");
                BanOrganizerButton.Enabled = false;
                DeleteEventButton.Enabled = false;
            }
        }
    }
}

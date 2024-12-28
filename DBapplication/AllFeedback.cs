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
    public partial class AllFeedback : Form
    {
        Controller controller;
        int EventID;
        int UserID;
        DataGridViewRow selectedFeedbackRow = null;
        public AllFeedback(int userID, int eventID)
        {
            InitializeComponent();
            controller = new Controller();
            EventID = eventID;
            UserID = userID;

            FeedbackGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ReportButton.Enabled = false;
            FeedbackGrid.SelectionChanged += FeedbackGrid_SelectionChanged;
        }

        private void FeedbackGrid_SelectionChanged(object sender, EventArgs e)
        {
            // Check if any row is selected
            if (FeedbackGrid.SelectedRows.Count > 0)
            {
                selectedFeedbackRow = FeedbackGrid.SelectedRows[0];
                ReportButton.Enabled = true;
            }
            else
            {
                selectedFeedbackRow = null;
                ReportButton.Enabled = false;
            }
        }

        private void AllFeedback_Load(object sender, EventArgs e)
        {
            DataTable dt = controller.getFeedback(EventID);
            FeedbackGrid.DataSource = dt;

            FeedbackGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            FeedbackGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            FeedbackGrid.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            FeedbackGrid.Refresh();
        }

        private void FeedbackGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ReportButton_Click(object sender, EventArgs e)
        {
            if (selectedFeedbackRow != null)
            {
                string feedbackID = selectedFeedbackRow.Cells["Feedback_ID"].Value.ToString();
                string feedbackComment = selectedFeedbackRow.Cells["Comment"].Value.ToString();

                int result = controller.ReportFeedback(Convert.ToInt16(feedbackID), Description.Text, UserID);

                if (result == 0)
                {
                    MessageBox.Show(" Operation failed");
                }
                else
                {
                    MessageBox.Show("Feedback reported successfully");
                }
            }
        }
    }
}

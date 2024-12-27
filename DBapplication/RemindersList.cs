using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBapplication
{
    public partial class RemindersList : Form
    {
        Controller controller = new Controller();
        int userID;
        DataGridViewRow selectedInviteRow = null;
        
        // PROPER USE ==> 1. Select row
        //                2. Choose Accept/Reject
        //                3. That's it ;)
        public RemindersList(int uID)
        {
            InitializeComponent();
            userID = uID;

            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            AcceptButton.Enabled = false;
            RejectButton.Enabled = false;

            dataGridView2.SelectionChanged += DataGridView2_SelectionChanged;
        }

        private void DataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                selectedInviteRow = dataGridView2.SelectedRows[0];
                AcceptButton.Enabled = true;
                RejectButton.Enabled = true;
            }
            else
            {
                selectedInviteRow = null;
                AcceptButton.Enabled = false;
                RejectButton.Enabled = false;
            }
        }

        private void RemindersList_Load(object sender, EventArgs e)
        {
            DataTable reminders = controller.LoadReminders(userID);
            DataTable invites = controller.LoadInvites(userID);

            if (reminders == null && invites == null)
            {
                dataGridView1.Visible = false;
                dataGridView2.Visible = false;
                InvitationLabel.Visible = false;
                ReminderLabel.Text = "Oops! Looks like you don't have any reminders or invitations yet!";
            }
            else
            {
                if (reminders == null)
                {
                    dataGridView2.Height = 300;
                    dataGridView1.Hide();
                    ReminderLabel.Visible = false;
                    InvitationLabel.Location = new Point(9, 9);
                    dataGridView2.Location = new Point(12, 59);
                }
                else
                {
                    dataGridView1.DataSource = reminders;
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                    dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                    dataGridView1.Refresh();
                    dataGridView1.Show();
                    ReminderLabel.Visible = true;
                }

                if (invites == null)
                {
                    dataGridView1.Height = 300;
                    dataGridView2.Hide();
                    InvitationLabel.Hide();
                    AcceptButton.Visible = false;
                    RejectButton.Visible = false;
                }
                else
                {
                    dataGridView2.DataSource = invites;
                    dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                    dataGridView2.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                    dataGridView2.Refresh();
                    dataGridView2.Show();
                    InvitationLabel.Visible = true;
                }
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            if (selectedInviteRow != null)
            {
                string eventName = selectedInviteRow.Cells["EventName"].Value.ToString();
                string date = Convert.ToDateTime(selectedInviteRow.Cells["Edate"].Value).ToString("yyyy-MM-dd");
                string startTime = selectedInviteRow.Cells["Start_Time"].Value.ToString();

                int eventID = controller.GetEventID(eventName, startTime, date);
                int result = controller.AcceptInvitation(userID, eventID);

                if (result == 0)
                {
                    MessageBox.Show("Operation Failed!!");
                }
                else MessageBox.Show("Invite Accepted!!");
            }
            RemindersList_Load(sender, e);
        }

        private void RejectButton_Click(object sender, EventArgs e)
        {
            if (selectedInviteRow != null)
            {
                string eventName = selectedInviteRow.Cells["EventName"].Value.ToString();
                string date = Convert.ToDateTime(selectedInviteRow.Cells["Edate"].Value).ToString("yyyy-MM-dd");
                string startTime = selectedInviteRow.Cells["Start_Time"].Value.ToString();

                int eventID = controller.GetEventID(eventName, startTime, date);
                int result = controller.RejectInvitation(userID, eventID);

                if (result == 0)
                {
                    MessageBox.Show("Operation Failed!!");
                }
                else MessageBox.Show("invited Rejected");
            }
            RemindersList_Load(sender, e);
        }
    }
}

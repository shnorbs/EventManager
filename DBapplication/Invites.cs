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
    public partial class Invites : Form
    {
        Controller controllerObj = new Controller();
        string Ename;
        int RSVP = 0;
        public Invites(string EventName)
        {
            InitializeComponent();
            Ename = EventName;
            UserDataGrid.DataSource = controllerObj.GetUsers();
        }

        private void Invites_Load(object sender, EventArgs e)
        {

        }

        

        private void Done_button_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < UserInvitedDataGrid.Rows.Count - 1; i++)
            {
                string email = UserInvitedDataGrid.Rows[i].Cells[2].Value.ToString();
                controllerObj.AddInvite(email, Ename, RSVP);
            }
        }

        private void Invite_button_Click_1(object sender, EventArgs e)
        {
            if (UserDataGrid.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow selectedRow in UserDataGrid.SelectedRows)
                {
                    int newRowIndex = UserInvitedDataGrid.Rows.Add();

                    for (int i = 0; i < selectedRow.Cells.Count; i++)
                    {
                        UserInvitedDataGrid.Rows[newRowIndex].Cells[i].Value = selectedRow.Cells[i].Value;
                    }

                    UserDataGrid.Rows.Remove(selectedRow);
                }
            }
            else
            {
                MessageBox.Show("Please select rows to transfer.");
            }
        }

        private void Remove_button_Click_1(object sender, EventArgs e)
        {
            if (UserInvitedDataGrid.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show(
                    "Are you sure you want to remove the selected user?",
                    "Confirm Removal",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    DataGridViewRow selectedRow = UserInvitedDataGrid.SelectedRows[0];
                    UserInvitedDataGrid.Rows.Remove(selectedRow);
                    MessageBox.Show("User has been removed successfully.");
                }
            }
            else
            {
                MessageBox.Show("Please select a user to remove.");
            }
        }
    }
}

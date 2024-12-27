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
    public partial class Feedback : Form
    {
        Controller cont = new Controller();

        string date;
        int uID;
        int eID;
        public Feedback(int UserID, int EventID)
        {
            InitializeComponent();
            DateTime today = DateTime.Today;
            date = today.ToString("yyyy-MM-dd");
            uID = UserID;
            eID = EventID;
        }

        private void Feedback_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            string comments = "";
            if (commentBox.Text != "")
            {
                comments = commentBox.Text;
            }

            if (radioButton1.Checked)
            {
                cont.AddFeedback(1, date, comments, uID, eID);
            }

            if (radioButton2.Checked)
            {
                cont.AddFeedback(2, date, comments, uID, eID);
            }

            if (radioButton3.Checked)
            {
                cont.AddFeedback(3, date, comments, uID, eID);
            }

            if (radioButton4.Checked)
            {
                cont.AddFeedback(4, date, comments, uID, eID);
            }

            if (radioButton5.Checked)
            {
                cont.AddFeedback(5, date, comments, uID, eID);
            }


            MessageBox.Show("Feedback Submitted!");
        }
    }
}

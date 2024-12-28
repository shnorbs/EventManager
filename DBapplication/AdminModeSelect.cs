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
    public partial class AdminModeSelect : Form
    {
        Controller cont = new Controller();
        int ID;
        public AdminModeSelect(int AdminID)
        {
            InitializeComponent();
            ID = AdminID;
        }

        private void UserMode_Click(object sender, EventArgs e)
        {
            Event_Calendar f = new Event_Calendar(ID, "Admin");
            f.Show();
        }

        private void AdminMode_Click(object sender, EventArgs e)
        {
            ManageReports form = new ManageReports(ID);
            form.Show();
        }

        private void AdminModeSelect_Load(object sender, EventArgs e)
        {

        }

        private void Add_Admin_Click(object sender, EventArgs e)
        {
            Admin_Addition form = new Admin_Addition();
            form.Show();

        }
    }
}

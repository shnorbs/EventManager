using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBapplication
{
    public partial class Sponsor : Form
    {
        string Ename;
        Controller controllerObj = new Controller();
        public Sponsor(string EventName)
        {
            InitializeComponent();
            Ename = EventName;
        }

        private void Sponsor_Load(object sender, EventArgs e)
        {

        }

        private void AddSponsor_button_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < SponsorDataGrid.Rows.Count-1; i++)
            {
                if (SponsorDataGrid.Rows[i].Cells[0] == null || SponsorDataGrid.Rows[i].Cells[1] == null)
                {
                    MessageBox.Show("Please fill all the fields");
                    return;
                }
                if (Regex.IsMatch(SponsorDataGrid.Rows[i].Cells[0].Value.ToString(), @"^[a-zA-Z]+$") == false)
                {
                    MessageBox.Show("Please enter only letters in company name");
                    return;
                }
                if (double.TryParse(SponsorDataGrid.Rows[i].Cells[1].Value.ToString(), out double result) == false||result<0)
                {
                    MessageBox.Show("Please Enter a positive number in amount sponsored");
                    return ;
                }
                string CompanyName = SponsorDataGrid.Rows[i].Cells[0].Value.ToString();
                float AmountSponsored = (float)Convert.ToDouble(SponsorDataGrid.Rows[i].Cells[1].Value);
                controllerObj.AddSponsor(CompanyName,Ename);
                controllerObj.AddSponsored(CompanyName,AmountSponsored,Ename);
            }
        }
    }
}

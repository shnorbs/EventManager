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
    public partial class AdminMode2 : Form
    {
        Controller controller;
        int ID;
        public AdminMode2(int adminID)
        {
            InitializeComponent();
            ID = adminID;
        }

        private void AdminMode2_Load(object sender, EventArgs e)
        {
            controller = new Controller();
            DataTable dt = controller.LoadFeedbackReports();

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            dataGridView1.DataSource = dt;
        }

        private void filterBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int reportId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Report_ID"].Value);
            bool handledValue = Convert.ToBoolean(dataGridView1.Rows[e.RowIndex].Cells["Handled"].Value);
            FeedbackReports form = new FeedbackReports(reportId, handledValue, ID);
            form.Show();
        }

        private void filterBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            DataTable dt = controller.ShowFeedbackReports(filterBox.Text);

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }
    }
}

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
    public partial class AdminMode : Form
    {
        Controller controllerObj;
        public AdminMode()
        {
            InitializeComponent();
        }

        private void AdminMode_Load(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            DataTable dt = controllerObj.LoadReports();

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            dataGridView1.DataSource = dt;
        }

        private void filterBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.ShowReports(filterBox.Text);

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int reportId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Report_ID"].Value);
            bool handledValue = Convert.ToBoolean(dataGridView1.Rows[e.RowIndex].Cells["Handled"].Value);
            ReportDetails form = new ReportDetails(reportId, handledValue);
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin_Addition table = new Admin_Addition();
            table.Show();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Statstics form = new Statstics();
            form.Show();

        }
    }
}

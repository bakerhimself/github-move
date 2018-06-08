using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sa3at_Al3amal
{
    public partial class WorkHoursClient : Form
    {
        public WorkHoursClient()
        {
            InitializeComponent();
            Fillcombo();
            /* //Calculate and add total to last row!
             decimal sum = 0;
             int rc = 0;
             for (int i = 0; i < dataGridView1.Rows.Count; ++i)
             {
                 sum += Convert.ToDecimal(dataGridView1.Rows[i].Cells[5].Value);
                 rc = dataGridView1.Rows.Count;
             }
             DataTable d = dataGridView1.DataSource as DataTable;
             DataRow drToAdd = d.NewRow();
             //drToAdd["الساعات"] = rc;
             d.Rows.Add(drToAdd);
             d.AcceptChanges();
             dataGridView1.DataSource = d;
             dataGridView1.Rows[rc].Cells[5].Value = sum.ToString();
             dataGridView1.Rows[rc].Cells[4].Value = "مجموع الساعات:";*/
        }
        void Fillcombo()
        {
            string constring = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\whdb.mdf;Integrated Security=True";
            string Query = "SELECT * FROM Clients ORDER BY Client_Name";
            SqlConnection conDataBase = new SqlConnection(constring);
            SqlCommand cmdDataBase = new SqlCommand(Query, conDataBase);
            SqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    string sName = myReader.GetString(myReader.GetOrdinal("Client_Name"));
                    comboBox1.Items.Add(sName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void WorkHoursClient_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'whdbDataSet.WorkHours' table. You can move, or remove it, as needed.
            // this.WorkHoursTableAdapter.FillWH(this.whdbDataSet.WorkHours);
            // this.reportViewer1.RefreshReport();
            // label13.Text = DateTime.Now.Date.ToString("MMM dd, yyyy");

            // The ToolTip for the PictureBoxes.
            new ToolTip().SetToolTip(addIcon, "إضافة ساعات عمل");
            new ToolTip().SetToolTip(refreshIcon, "تحديث الجدول");
            new ToolTip().SetToolTip(deleteIcon, "حذف ساعات عمل");
            new ToolTip().SetToolTip(searchIcon, "بحث");
            new ToolTip().SetToolTip(homeIcon, "الصفحة الرئيسية");
        }

        private void addIcon_Click(object sender, EventArgs e)
        {
            LogAJob LogAJob = new LogAJob();
            LogAJob.Show();
        }

        private void refreshIcon_Click(object sender, EventArgs e)
        {
            try
            {
                whdbDataSetTableAdapters.WorkHoursTableAdapter adapter = new whdbDataSetTableAdapters.WorkHoursTableAdapter();
                whdbDataSet.WorkHoursDataTable table = new whdbDataSet.WorkHoursDataTable();
                adapter.FillByClient(table, comboBox1.SelectedItem.ToString(), dateTimePicker1.Text, dateTimePicker2.Text);
                ReportDataSource MyNewDataSource = new ReportDataSource("DataSet1", (DataTable)table);
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(MyNewDataSource);
                this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
                this.reportViewer1.RefreshReport();

                ReportParameter[] param = new ReportParameter[3];
                param[0] = new ReportParameter("Txtbox1", comboBox1.SelectedItem.ToString());
                param[1] = new ReportParameter("DatePicker1", dateTimePicker1.Value.Date.ToString("dd/MM/yyyy"));
                param[2] = new ReportParameter("DatePicker2", dateTimePicker2.Value.Date.ToString("dd/MM/yyyy"));
                reportViewer1.LocalReport.SetParameters(param);
                reportViewer1.PrinterSettings.DefaultPageSettings.Landscape = true;
                this.reportViewer1.RefreshReport();
            }
            catch (Exception)
            {
                MessageBox.Show("اختر اسم عميل والفترة المحددة");
            }
        }

        private void deleteIcon_Click(object sender, EventArgs e)
        {
            DelJob EditJob = new DelJob();
            EditJob.Show();
        }

        private void searchIcon_Click(object sender, EventArgs e)
        {
            try
            {
                whdbDataSetTableAdapters.WorkHoursTableAdapter adapter = new whdbDataSetTableAdapters.WorkHoursTableAdapter();
                whdbDataSet.WorkHoursDataTable table = new whdbDataSet.WorkHoursDataTable();
                adapter.FillByClient(table, comboBox1.SelectedItem.ToString(), dateTimePicker1.Text, dateTimePicker2.Text);
                ReportDataSource MyNewDataSource = new ReportDataSource("DataSet1", (DataTable)table);
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(MyNewDataSource);
                this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
                this.reportViewer1.RefreshReport();

                ReportParameter[] param = new ReportParameter[3];
                param[0] = new ReportParameter("Txtbox1", comboBox1.SelectedItem.ToString());
                param[1] = new ReportParameter("DatePicker1", dateTimePicker1.Value.Date.ToString("dd/MM/yyyy"));
                param[2] = new ReportParameter("DatePicker2", dateTimePicker2.Value.Date.ToString("dd/MM/yyyy"));
                reportViewer1.LocalReport.SetParameters(param);
                reportViewer1.PrinterSettings.DefaultPageSettings.Landscape = true;
                this.reportViewer1.RefreshReport();
            }
            catch (Exception)
            {
                MessageBox.Show("اختر اسم عميل والفترة المحددة");
            }
        }

        private void homeIcon_Click(object sender, EventArgs e)
        {
            this.Hide();
            var mf = new MainForm();
            mf.Closed += (s, args) => this.Close();
            mf.Show();
        }

        private void fetchNameBtn_Click(object sender, EventArgs e)
        {
            string constring = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\whdb.mdf;Integrated Security=True";
            string Query = "SELECT * FROM Clients WHERE Client_ID='" + codeTxtBox.Text + "'";
            SqlConnection conDataBase = new SqlConnection(constring);
            SqlCommand cmdDataBase = new SqlCommand(Query, conDataBase);
            SqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                while (myReader.Read())
                {
                    string Client_Name = myReader.GetString(myReader.GetOrdinal("Client_Name"));
                    comboBox1.Text = Client_Name;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime fromDate = dateTimePicker1.Value;
            DateTime toDate = fromDate.AddDays(15);
            DateTime toDate2 = fromDate.AddDays(13);

            if (fromDate.Day < 16) {
                dateTimePicker2.Value = toDate;
            }
            else {
                dateTimePicker2.Value = toDate2;
            }
        }
    }
}
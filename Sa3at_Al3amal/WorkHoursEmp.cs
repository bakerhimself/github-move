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
    public partial class WorkHoursEmp : Form
    {
        public WorkHoursEmp()
        {
            InitializeComponent();
            Fillcombo();
        }
        void Fillcombo()
        {
            string constring = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\whdb.mdf;Integrated Security=True";
            string Query = "SELECT * FROM Employees ORDER BY Emp_Name";
            SqlConnection conDataBase = new SqlConnection(constring);
            SqlCommand cmdDataBase = new SqlCommand(Query, conDataBase);
            SqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    string sName = myReader.GetString(myReader.GetOrdinal("Emp_Name"));
                    comboBox1.Items.Add(sName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void WorkHoursEmp_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'whdbDataSet.WorkHours' table. You can move, or remove it, as needed.
           // this.WorkHoursTableAdapter.FillWH(this.whdbDataSet.WorkHours);
           // this.reportViewer1.RefreshReport();
            //show today's date
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
                adapter.FillByEmp(table, comboBox1.SelectedItem.ToString(), dateTimePicker1.Text, dateTimePicker2.Text);
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
                MessageBox.Show("اختر اسم مُراجع والفترة المحددة");
            }
        }

        private void deleteIcon_Click(object sender, EventArgs e)
        {
            DelJob dj = new DelJob();
            dj.Show();
        }

        private void searchIcon_Click(object sender, EventArgs e)
        {
            try
            {
                whdbDataSetTableAdapters.WorkHoursTableAdapter adapter = new whdbDataSetTableAdapters.WorkHoursTableAdapter();
                whdbDataSet.WorkHoursDataTable table = new whdbDataSet.WorkHoursDataTable();
                adapter.FillByEmp(table, comboBox1.SelectedItem.ToString(), dateTimePicker1.Text, dateTimePicker2.Text);
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
                MessageBox.Show("اختر اسم مراجع والفترة المحددة");
                //.Show(ex.ToString());
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
            string Query = "SELECT * FROM Employees WHERE Emp_ID='" + codeTxtBox.Text + "'";
            SqlConnection conDataBase = new SqlConnection(constring);
            SqlCommand cmdDataBase = new SqlCommand(Query, conDataBase);
            SqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                while (myReader.Read())
                {
                    string Emp_Name = myReader.GetString(myReader.GetOrdinal("Emp_Name"));
                    comboBox1.Text = Emp_Name;
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

            if (fromDate.Day < 16)
            {
                dateTimePicker2.Value = toDate;
            }
            else
            {
                dateTimePicker2.Value = toDate2;
            }
        }
    }
}

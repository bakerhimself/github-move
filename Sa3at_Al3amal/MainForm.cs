using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sa3at_Al3amal
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //EmployeeForm EmpForm = new EmployeeForm();
           // EmpForm.Show();
            this.Hide();
            var EmpForm = new EmployeeForm();
            EmpForm.Closed += (s, args) => this.Close();
            EmpForm.Show();
        }

        private void ClientButton_Click(object sender, EventArgs e)
        {
          //  ClientsForm ClientsForm = new ClientsForm();
           // ClientsForm.Show();
            this.Hide();
            var ClientsForm = new ClientsForm();
            ClientsForm.Closed += (s, args) => this.Close();
            ClientsForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           // WorkHoursClient whc = new WorkHoursClient();
           // whc.Show();
            this.Hide();
            var whc = new WorkHoursClient();
            whc.Closed += (s, args) => this.Close();
            whc.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //WorkHoursEmp whe = new WorkHoursEmp();
            //whe.Show();
            this.Hide();
            var whe = new WorkHoursEmp();
            whe.Closed += (s, args) => this.Close();
            whe.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //SQLBackup sqlB = new SQLBackup();
            //sqlB.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //SQLRestore sqlR = new SQLRestore();
            //sqlR.Show();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            SQLBackup sqlB = new SQLBackup();
            sqlB.Show();
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            SQLRestore sqlR = new SQLRestore();
            sqlR.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // The ToolTip for the PictureBoxes.
            new ToolTip().SetToolTip(pictureBox2, "عمل نسخة إحتياطية لقاعدة البيانات");
            new ToolTip().SetToolTip(pictureBox3, "إستعادة بيانات من نسخة إحتياطية");
        }
    }
}

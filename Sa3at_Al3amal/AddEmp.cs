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
    public partial class AddEmp : Form
    {
        public AddEmp()
        {
            InitializeComponent();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\whdb.mdf;Integrated Security=True");
                SqlCommand sqlCommand = new SqlCommand("");
                sqlCommand.Connection = sqlConnection;
                sqlConnection.Open();
                sqlCommand.CommandText = "INSERT INTO Employees VALUES (@Emp_Name, @Emp_Role)";
                sqlCommand.Parameters.Add("@Emp_Name", SqlDbType.NVarChar).Value = textBox1.Text;
                sqlCommand.Parameters.Add("@Emp_Role", SqlDbType.NVarChar).Value = comboBox1.SelectedItem;
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("تم الحفظ!", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information); 
            }
            catch (Exception ex)
            {
               // MessageBox.Show("حدث خطأ عند الإدخال", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.Message);
            }
        }
    }
}

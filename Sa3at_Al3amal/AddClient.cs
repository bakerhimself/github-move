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
    public partial class AddClient : Form
    {
        public AddClient()
        {
            InitializeComponent();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try {
                SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\whdb.mdf;Integrated Security=True");
                SqlCommand sqlCommand = new SqlCommand("");
                sqlCommand.Connection = sqlConnection;
                sqlConnection.Open();
                sqlCommand.CommandText = "INSERT INTO Clients VALUES (@Client_Name, @Client_Status, @Service, @Job_Date)";
                sqlCommand.Parameters.Add("@Client_Name", SqlDbType.NVarChar).Value = textBox1.Text;
                sqlCommand.Parameters.Add("@Client_Status", SqlDbType.NVarChar).Value = comboBox1.SelectedItem;
                sqlCommand.Parameters.Add("@Service", SqlDbType.NVarChar).Value = comboBox2.SelectedItem;
                sqlCommand.Parameters.Add("@Job_Date", SqlDbType.Date).Value = dateTimePicker1.Value.Date.ToString("dd/MM/yyyy");
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("تم الحفظ!", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("حدث خطأ عند الإدخال","خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

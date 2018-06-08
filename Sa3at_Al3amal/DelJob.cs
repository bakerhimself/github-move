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
    public partial class DelJob : Form
    {
        public DelJob()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("هل حقاً ترغب بحذف الساعات في الكود\"" + textBox1.Text + "\"؟", "تأكيد حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\whdb.mdf;Integrated Security=True");
                    SqlCommand sqlCommand = new SqlCommand("");
                    sqlCommand.Connection = sqlConnection;
                    sqlConnection.Open();
                    sqlCommand.CommandText = "DELETE FROM EmpJobs WHERE EmpJob_ID = @EmpJob_ID";
                    sqlCommand.Parameters.Add("@EmpJob_ID", SqlDbType.Int).Value = textBox1.Text;
                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();
                    MessageBox.Show("تم حذف الساعات!!", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("حدث خطأ، لم يتم الحذف", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } 
                
            } 
        }
    }
}

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
    public partial class DelEmp : Form
    {
        public DelEmp()
        {
            InitializeComponent();
            Fillcombo();
        }
        void Fillcombo()
        {
            string constring = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\whdb.mdf;Integrated Security=True";
            string Query = "SELECT * FROM Employees ; ";
            SqlConnection conDataBase = new SqlConnection(constring);
            SqlCommand cmdDataBase = new SqlCommand(Query, conDataBase);
            SqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    int sName = myReader.GetInt32(myReader.GetOrdinal("Emp_ID"));
                    comboBox1.Items.Add(sName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("هل حقاً ترغب بحذف  \"" + comboBox1.SelectedItem + "\"؟", "تأكيد حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\whdb.mdf;Integrated Security=True");
                    SqlCommand sqlCommand = new SqlCommand("");
                    sqlCommand.Connection = sqlConnection;
                    sqlConnection.Open();
                    sqlCommand.CommandText = "DELETE FROM Employees WHERE Emp_ID = @Emp_ID";
                    sqlCommand.Parameters.Add("@Emp_ID", SqlDbType.Int).Value = comboBox1.SelectedItem;
                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();
                    MessageBox.Show("تم حذف الموظف!", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("حدث خطأ، لم يتم الحذف", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } 
            } 
        }
    }
}

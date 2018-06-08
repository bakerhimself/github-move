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
    public partial class EditEmp : Form
    {
        public EditEmp()
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string constring = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\whdb.mdf;Integrated Security=True";
            string Query = "SELECT * FROM Employees WHERE Emp_ID='" + comboBox1.SelectedItem + "'";
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
                    string Emp_Role = myReader.GetString(myReader.GetOrdinal("Emp_Role"));
                    textBox1.Text = Emp_Name;
                    comboBox3.Text = Emp_Role;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("هل أنت مُتأكّد من تعديلك للمُوظّف رقم  \"" + comboBox1.SelectedItem + "\" ؟ ", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\whdb.mdf;Integrated Security=True");
                    SqlCommand sqlCommand = new SqlCommand("");
                    sqlCommand.Connection = sqlConnection;
                    sqlConnection.Open();
                    sqlCommand.CommandText = "UPDATE Employees SET Emp_Role=@Emp_Role, Emp_Name=@Emp_Name WHERE Emp_ID=@Emp_ID";
                    sqlCommand.Parameters.Add("@Emp_Role", SqlDbType.NVarChar).Value = comboBox3.SelectedItem;
                    sqlCommand.Parameters.Add("@Emp_Name", SqlDbType.NVarChar).Value = textBox1.Text;
                    sqlCommand.Parameters.Add("@Emp_ID", SqlDbType.Int).Value = comboBox1.SelectedItem;
                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();
                    MessageBox.Show("تم التحديث !", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("حدث خطأ، لم يتم التحديث، تأكد من صحة البيانات المدخلة ", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } 

            } 
        }

        private void EditEmp_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

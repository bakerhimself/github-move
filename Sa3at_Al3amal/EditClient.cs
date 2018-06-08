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
    public partial class EditClient : Form
    {
        public EditClient()
        {
            InitializeComponent();
            Fillcombo();
        }
        void Fillcombo()
        {
            string constring = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\whdb.mdf;Integrated Security=True";
            string Query = "SELECT * FROM Clients ; ";
            SqlConnection conDataBase = new SqlConnection(constring);
            SqlCommand cmdDataBase = new SqlCommand(Query, conDataBase);
            SqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    int sName = myReader.GetInt32(myReader.GetOrdinal("Client_ID"));
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
            DialogResult result = MessageBox.Show("هل أنت مُتأكّد من تعديلك للعميل رقم  \"" + comboBox1.SelectedItem + "\" ؟ ", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\whdb.mdf;Integrated Security=True");
                    SqlCommand sqlCommand = new SqlCommand("");
                    sqlCommand.Connection = sqlConnection;
                    sqlConnection.Open();
                    sqlCommand.CommandText = "UPDATE Clients SET Client_Name=@Client_Name, Client_Status=@Client_Status, Service=@Service, Join_Date=@Join_Date WHERE Client_ID=@Client_ID";
                    sqlCommand.Parameters.Add("@Client_Name", SqlDbType.NVarChar).Value = textBox1.Text;
                    sqlCommand.Parameters.Add("@Client_Status", SqlDbType.NVarChar).Value = comboBox2.SelectedItem;
                    sqlCommand.Parameters.Add("@Service", SqlDbType.NVarChar).Value = comboBox3.SelectedItem;
                    sqlCommand.Parameters.Add("@Client_ID", SqlDbType.Int).Value = comboBox1.SelectedItem;
                    sqlCommand.Parameters.Add("@Join_Date", SqlDbType.Date).Value = dateTimePicker1.Value.Date.ToString("dd/MM/yyyy");
                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();
                    MessageBox.Show("تم التعديل !", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("حدث خطأ، لم يتم التعديل، الرجاء التأكد من البيانات المدخلة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } 

            } 
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string constring = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\whdb.mdf;Integrated Security=True";
            string Query = "SELECT * FROM Clients WHERE Client_ID='" + comboBox1.SelectedItem + "'";
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
                    string Client_Status = myReader.GetString(myReader.GetOrdinal("Client_Status"));
                    string Service = myReader.GetString(myReader.GetOrdinal("Service"));
                    //  string Join_Date = myReader.GetDateTime(myReader.GetOrdinal("Join_Date"));
                    textBox1.Text = Client_Name;
                    comboBox2.Text = Client_Status;
                    comboBox3.Text = Service;
                    dateTimePicker1.Text = Convert.ToDateTime(myReader["Join_Date"]).ToString("MMM/dd/yyyy");
                    //dateTimePicker1.Text = Join_Date.ToString("MMM/dd/yyyy");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EditClient_Load(object sender, EventArgs e)
        {

        }
    }
}

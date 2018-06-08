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
    public partial class LogAJob : Form
    {
        public LogAJob()
        {
            InitializeComponent();
            Fillcombo();
            Fillcombo2();
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
        void Fillcombo2()
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
                    comboBox2.Items.Add(sName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string constring = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\whdb.mdf;Integrated Security=True";
            string sqlQuery = (@"INSERT INTO EmpJobs (Emp_ID, Client_ID, Hours_Spent, Service, Job_Date)
                                SELECT e.Emp_ID, c.Client_ID, @Hours_Spent, @Service, @Job_Date 
                                FROM Clients c JOIN
                                Employees e
                                ON c.Client_Name = @Client_Name AND e.Emp_Name = @Emp_Name;");
            try {
                SqlConnection conDataBase = new SqlConnection(constring);
                SqlCommand sqlCommand = new SqlCommand(sqlQuery, conDataBase);
                conDataBase.Open();
                sqlCommand.CommandText = sqlQuery;
                sqlCommand.Parameters.Add("@Hours_Spent", SqlDbType.Decimal).Value = comboBox3.SelectedItem;
                sqlCommand.Parameters.Add("@Service", SqlDbType.NVarChar).Value = comboBox4.SelectedItem;
                sqlCommand.Parameters.Add("@Job_Date", SqlDbType.Date).Value = dateTimePicker1.Value.Date.ToString("dd/MM/yyyy");
                sqlCommand.Parameters.Add("@Client_Name", SqlDbType.NVarChar).Value = comboBox1.SelectedItem;
                sqlCommand.Parameters.Add("@Emp_Name", SqlDbType.NVarChar).Value = comboBox2.SelectedItem;
                sqlCommand.ExecuteNonQuery();
                conDataBase.Close();
                MessageBox.Show("تم الحفظ!", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information); 
            }
            catch (Exception)
            {
                MessageBox.Show("حدث خطأ، لم يتم حفظ الساعات، تأكد من سلامة البيانات المدخلة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 


            
        }

        private void LogAJob_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
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
                    string Client_Status = myReader.GetString(myReader.GetOrdinal("Client_Status"));
                    string Service = myReader.GetString(myReader.GetOrdinal("Service"));
                    //  string Join_Date = myReader.GetDateTime(myReader.GetOrdinal("Join_Date"));
                    comboBox1.Text = Client_Name;
                    //comboBox2.Text = Client_Status;
                    //comboBox3.Text = Service;
                    //dateTimePicker1.Text = Convert.ToDateTime(myReader["Join_Date"]).ToString("MMM/dd/yyyy");
                    //dateTimePicker1.Text = Join_Date.ToString("MMM/dd/yyyy");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

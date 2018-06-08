using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sa3at_Al3amal
{
    public partial class SQLBackup : Form
    {
        public SQLBackup()
        {
            InitializeComponent();
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            progressBar.Value = 0;
            SaveFileDialog sfd = new SaveFileDialog();
            string stringCon = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\whdb.mdf;Initial catalog=whdb;Integrated Security=True;multipleactiveresultsets=True";
            sfd.Filter = "Database backup files (*.bak)|*.bak";
            sfd.Title = "Create Database Backup";
            sfd.FileName = DateTime.Today.ToString("ddMMMyyyy") + ".bak";
            SqlConnection.ClearAllPools();
            if (sfd.ShowDialog() == DialogResult.OK)
            try {
            {
                using (SqlConnection conn = new SqlConnection(stringCon))
                {
                    string backupStmt = string.Format(@"backup database whdb to disk='{0}' WITH INIT ", sfd.FileName);
                    using (SqlCommand sqlComm = new SqlCommand(backupStmt, conn))
                    {
                    conn.Open();
                    sqlComm.ExecuteNonQuery();
                    //notify user
                    progressBar.Value = 100;
                    lblStatus.Text = "الحالة: تم حفظ نسخة احتياطية بنجاح!";
                    lblPercent.Text = "100%";
                    }
                    conn.Close();
                }
            }
        }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
/////////////////// using SMO //////////////////
/*progressBar.Value = 0;
SaveFileDialog sfd = new SaveFileDialog();
// string ConString = @"data source=(LocalDB)\MSSQLLocalDB;attachdbfilename=|DataDirectory|\TCdb.mdf;initial catalog=TCdb;integrated security=True;multipleactiveresultsets=True";
string stringCon = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\whdb.mdf;Initial catalog=whdb;Integrated Security=True;multipleactiveresultsets=True";
sfd.Filter = "Database backup files (*.bak)|*.bak";
sfd.Title = "Create Database Backup";
sfd.FileName = DateTime.Today.ToString("ddMMMyyyy") + ".bak";
if (sfd.ShowDialog() == DialogResult.OK)
{
    using (SqlConnection conn = new SqlConnection(stringCon))
    {
        ServerConnection servConn = new ServerConnection(conn);
        conn.Open();
        servConn.Connect();
        //string myDatabase = Application.StartupPath + "\\whdb.mdf";
        string myDatabase = "whdb";
        try {
            Server serverdb = new Server(servConn);
            Backup backupdb = new Backup() { Action = BackupActionType.Database, Database = myDatabase };
            backupdb.Devices.AddDevice(sfd.FileName, DeviceType.File);
            backupdb.Initialize = true;
            backupdb.Incremental = false;
            backupdb.SqlBackup(serverdb);
            progressBar.Value = 100;
            lblStatus.Text = "الحالة: تم حفظ نسخة احتياطية بنجاح!";
            lblPercent.Text = "100%";
           }
           catch (Exception ex)
           {
               MessageBox.Show(ex.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
        conn.Close();
        servConn.Disconnect();
    }
}*/
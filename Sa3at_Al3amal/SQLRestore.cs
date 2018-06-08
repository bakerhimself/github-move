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
    public partial class SQLRestore : Form
    {
        public SQLRestore()
        {
            InitializeComponent();
        }
        private void btnRestore_Click(object sender, EventArgs e)
        {
                progressBar.Value = 0;
                OpenFileDialog ofd = new OpenFileDialog();
                string stringCon = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\whdb.mdf;Initial catalog=whdb;Integrated Security=True;multipleactiveresultsets=True";
                ofd.Filter = "Database backup files (*.bak)|*.bak";
                ofd.Title = "Restore Database Backup";
                try
                {
                        SqlConnection.ClearAllPools(); 
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        using (SqlConnection conn = new SqlConnection(stringCon))
                        {
                            DialogResult result = MessageBox.Show("هل أنت متأكد من استعادة بيانات من هذه النسخة الإحتياطية؟ سوف يتم مسح البيانات الموجودة حالياً لديك وإستبدالها بالموجودة في النسخة الإحتياطية", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if (result == DialogResult.Yes)
                            {
                                conn.Open();
                                string sqlStmt1 = string.Format(@"ALTER DATABASE whdb SET SINGLE_USER WITH ROLLBACK IMMEDIATE");
                                SqlCommand sqlComm1 = new SqlCommand(sqlStmt1, conn);
                                sqlComm1.ExecuteNonQuery();

                                string sqlStmt2 = string.Format(@"USE MASTER RESTORE DATABASE whdb FROM DISK='{0}' WITH REPLACE", ofd.FileName);
                                SqlCommand sqlComm2 = new SqlCommand(sqlStmt2, conn);
                                sqlComm2.ExecuteNonQuery();

                                string sqlStmt3 = string.Format(@"ALTER DATABASE whdb SET MULTI_USER");
                                SqlCommand sqlComm3 = new SqlCommand(sqlStmt3, conn);
                                sqlComm3.ExecuteNonQuery();
                                //notify user
                                progressBar.Value = 100;
                                lblStatus.Text = "الحالة: تم استعادة البيانات من النسخة الإحتياطية بنجاح!";
                                lblPercent.Text = "100%";
                            }
                            conn.Close();
                        }
                    }
                }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}


/*
/////////////////// using SMO //////////////////
            progressBar.Value = 0;
            OpenFileDialog ofd = new OpenFileDialog();
           string stringCon = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\whdb.mdf;Initial catalog=whdb;Integrated Security=True;multipleactiveresultsets=True";
            ofd.Filter = "Database backup files (*.bak)|*.bak";
            ofd.Title = "Restore Database Backup";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                using (SqlConnection conn = new SqlConnection(stringCon))
                {
                    DialogResult result = MessageBox.Show("هل أنت متأكد من استعادة بيانات من هذه النسخة الإحتياطية؟ سوف يتم مسح البيانات الموجودة حالياً لديك وإستبدالها بالموجودة في النسخة الإحتياطية", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        ServerConnection servConn = new ServerConnection(conn);
                        conn.Open();
                        servConn.Connect();
                       string myDatabase = "whdb";
                         try {
                            Server dbServer = new Server(servConn); //local using windows athuentication 
                            Restore dbRestore = new Restore() { Database = myDatabase, Action = RestoreActionType.Database, ReplaceDatabase = true, NoRecovery = false };
                            dbRestore.Devices.AddDevice(ofd.FileName, DeviceType.File);

                            // Kill all processes
                            dbServer.KillAllProcesses(dbRestore.Database);
                            // Set single-user mode
                            Database db = dbServer.Databases[dbRestore.Database];
                            // db.DatabaseOptions.UserAccess=true;
                            db.Alter(TerminationClause.RollbackTransactionsImmediately);
                            // Detach database
                            dbServer.DetachDatabase(dbRestore.Database, false);

                            dbRestore.SqlRestore(dbServer);
                            progressBar.Value = 100;
                            lblStatus.Text = "الحالة: تم استعادة البيانات من النسخة الإحتياطية بنجاح!";
                            lblPercent.Text = "100%";

                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                         conn.Close();
                         servConn.Disconnect();
                    }
                }
            }
 * */

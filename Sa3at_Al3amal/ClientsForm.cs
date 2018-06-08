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
using Excel = Microsoft.Office.Interop.Excel;
using Word = Microsoft.Office.Interop.Word;

namespace Sa3at_Al3amal
{
    public partial class ClientsForm : Form
    {
        public ClientsForm()
        {
            InitializeComponent();
        }

        private void ClientsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'whdbDataSet.Clients' table. You can move, or remove it, as needed.
            this.clientsTableAdapter.Fill(this.whdbDataSet.Clients);
            // The ToolTip for the PictureBoxes.
            new ToolTip().SetToolTip(addIcon, "إضافة عميل");
            new ToolTip().SetToolTip(editIcon, "تعديل عميل");
            new ToolTip().SetToolTip(deleteIcon, "حذف عميل");
            new ToolTip().SetToolTip(refreshIcon, "تحديث الجدول");
            new ToolTip().SetToolTip(excelIcon, "حفظ بملف إكسل");
            new ToolTip().SetToolTip(wordIcon, "حفظ بملف وورد");
            new ToolTip().SetToolTip(homeIcon, "الصفحة الرئيسية");

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.HeaderCell.Value = String.Format("{0}", row.Index + 1);
                //dataGridView1.Columns[0].Width = 20;

                int firstDisplayedCellIndex = dataGridView1.FirstDisplayedCell.RowIndex;
                int lastDisplayedCellIndex = firstDisplayedCellIndex + dataGridView1.DisplayedRowCount(true);

                Graphics Graphics = dataGridView1.CreateGraphics();
                int measureFirstDisplayed = (int)(Graphics.MeasureString(firstDisplayedCellIndex.ToString(), dataGridView1.Font).Width);
                int measureLastDisplayed = (int)(Graphics.MeasureString(lastDisplayedCellIndex.ToString(), dataGridView1.Font).Width);

                int rowHeaderWitdh = System.Math.Max(measureFirstDisplayed, measureLastDisplayed);
                dataGridView1.RowHeadersWidth = rowHeaderWitdh + 50;
            }
            dataGridView1.Columns[4].DefaultCellStyle.Format = "yyyy/MM/dd";
            //((DataGridViewTextBoxColumn)dataGridView1.Columns[1]).m;
        }

        private void addIcon_Click(object sender, EventArgs e)
        {
            AddClient AddClient = new AddClient();
            AddClient.Show();
        }

        private void editIcon_Click(object sender, EventArgs e)
        {
            string cell = dataGridView1.CurrentCell.Value.ToString();
            EditClient ec = new EditClient();
            ec.comboBox1.Text = cell;
            ec.Show();
        }

        private void deleteIcon_Click(object sender, EventArgs e)
        {
            DelClient DelClient = new DelClient();
            DelClient.Show();
        }

        private void refreshIcon_Click(object sender, EventArgs e)
        {
            string constring = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\whdb.mdf;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand((@"
                SELECT * FROM Clients"), con))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            dt.Clear();
                            sda.Fill(dt);
                            dataGridView1.DataSource = dt;

                            foreach (DataGridViewRow row in dataGridView1.Rows)
                            {
                                row.HeaderCell.Value = String.Format("{0}", row.Index + 1);
                                //dataGridView1.Columns[0].Width = 20;

                                int firstDisplayedCellIndex = dataGridView1.FirstDisplayedCell.RowIndex;
                                int lastDisplayedCellIndex = firstDisplayedCellIndex + dataGridView1.DisplayedRowCount(true);

                                Graphics Graphics = dataGridView1.CreateGraphics();
                                int measureFirstDisplayed = (int)(Graphics.MeasureString(firstDisplayedCellIndex.ToString(), dataGridView1.Font).Width);
                                int measureLastDisplayed = (int)(Graphics.MeasureString(lastDisplayedCellIndex.ToString(), dataGridView1.Font).Width);

                                int rowHeaderWitdh = System.Math.Max(measureFirstDisplayed, measureLastDisplayed);
                                dataGridView1.RowHeadersWidth = rowHeaderWitdh + 50;
                            }
                            dataGridView1.Columns[4].DefaultCellStyle.Format = "yyyy/MM/dd";
                        }
                    }
                }
            }
        }
        private void copyAlltoClipboard()
        {
            //dataGridView1.SelectAll();
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridView1.MultiSelect = true;
            dataGridView1.SelectAll();
            DataObject dataObj = dataGridView1.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }
        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occurred while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        private void excelIcon_Click(object sender, EventArgs e)
        {
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Excel Documents (*.xls)|*.xls";
                sfd.FileName = "قائمة العملاء.xls";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    // Copy DataGridView results to clipboard
                    copyAlltoClipboard();

                    object misValue = System.Reflection.Missing.Value;
                    Excel.Application xlexcel = new Excel.Application();

                    xlexcel.DisplayAlerts = false; // Without this you will get two confirm overwrite prompts
                    Excel.Workbook xlWorkBook = xlexcel.Workbooks.Add(misValue);
                    Excel.Worksheet xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

                    //make all columns and rows fitting instead of squeezed in
                    int i = 0;
                    for (i = 1; i <= 10; i++) // this will aply it form col 1 to 10
                    {
                        xlWorkSheet.Columns[i].ColumnWidth = 18;
                    }

                    // Format column D as text before pasting results, this was required for my data
                    Excel.Range rng = xlWorkSheet.get_Range("D:D").Cells;
                    rng.NumberFormat = "@";

                    // Paste clipboard results to worksheet range
                    Excel.Range CR = (Excel.Range)xlWorkSheet.Cells[1, 1];
                    CR.Select();
                    xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);

                    // For some reason column A is always blank in the worksheet. ¯\_(ツ)_/¯
                    // Delete blank column A and select cell A1
                    //Excel.Range delRng = xlWorkSheet.get_Range("A:A").Cells;
                    //delRng.Delete(Type.Missing);
                    // xlWorkSheet.get_Range("A1").Select();

                    // Save the excel file under the captured location from the SaveFileDialog
                    xlWorkBook.SaveAs(sfd.FileName, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                    xlexcel.DisplayAlerts = true;
                    xlWorkBook.Close(true, misValue, misValue);
                    xlexcel.Quit();

                    releaseObject(xlWorkSheet);
                    releaseObject(xlWorkBook);
                    releaseObject(xlexcel);

                    // Clear Clipboard and DataGridView selection
                    Clipboard.Clear();
                    dataGridView1.ClearSelection();

                    MessageBox.Show("تم حفظ قائمة العملاء في المسار المحدد", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Open the newly saved excel file
                    // if (File.Exists(sfd.FileName))
                    //  System.Diagnostics.Process.Start(sfd.FileName);
                }
            }
        }
        public void Export_Data_To_Word(DataGridView DGV, string filename)
        {
            if (DGV.Rows.Count != 0)
            {
                int RowCount = DGV.Rows.Count;
                int ColumnCount = DGV.Columns.Count;
                Object[,] DataArray = new object[RowCount + 1, ColumnCount + 1];
                //add rows
                int r = 0;
                for (int c = 0; c <= ColumnCount - 1; c++)
                {
                    for (r = 0; r <= RowCount - 1; r++)
                    {
                        DataArray[r, c] = DGV.Rows[r].Cells[c].Value;
                    } //end row loop
                } //end column loop
                Word.Document oDoc = new Word.Document();
                oDoc.Application.Visible = true;
                //page orintation
                oDoc.PageSetup.Orientation = Word.WdOrientation.wdOrientLandscape;
                dynamic oRange = oDoc.Content.Application.Selection.Range;
                string oTemp = "";
                for (r = 0; r <= RowCount - 1; r++)
                {
                    for (int c = 0; c <= ColumnCount - 1; c++)
                    {
                        oTemp = oTemp + DataArray[r, c] + "\t";
                    }
                }
                //table format
                oRange.Text = oTemp;
                object Separator = Word.WdTableFieldSeparator.wdSeparateByTabs;
                object ApplyBorders = true;
                object AutoFit = true;
                object AutoFitBehavior = Word.WdAutoFitBehavior.wdAutoFitContent;
                oRange.ConvertToTable(ref Separator, ref RowCount, ref ColumnCount,
                                      Type.Missing, Type.Missing, ref ApplyBorders,
                                      Type.Missing, Type.Missing, Type.Missing,
                                      Type.Missing, Type.Missing, Type.Missing,
                                      Type.Missing, ref AutoFit, ref AutoFitBehavior, Type.Missing);
                oRange.Select();
                oDoc.Application.Selection.Tables[1].Select();
                oDoc.Application.Selection.Tables[1].Rows.AllowBreakAcrossPages = 0;
                oDoc.Application.Selection.Tables[1].Rows.Alignment = 0;
                oDoc.Application.Selection.Tables[1].Rows[1].Select();
                oDoc.Application.Selection.InsertRowsAbove(1);
                oDoc.Application.Selection.Tables[1].Rows[1].Select();
                //header row style
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Bold = 1;
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Name = "Tahoma";
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Size = 14;
                //add header row manually
                for (int c = 0; c <= ColumnCount - 1; c++)
                {
                    oDoc.Application.Selection.Tables[1].Cell(1, c + 1).Range.Text = DGV.Columns[c].HeaderText;
                }
                //table style 
                oDoc.Application.Selection.Tables[1].set_Style("Grid Table 4 - Accent 5");
                oDoc.Application.Selection.Tables[1].Rows[1].Select();
                oDoc.Application.Selection.Cells.VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                //header text
                foreach (Word.Section section in oDoc.Application.ActiveDocument.Sections)
                {
                    Word.Range headerRange = section.Headers[Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                    headerRange.Fields.Add(headerRange, Word.WdFieldType.wdFieldPage);
                    headerRange.Text = "قائمة العملاء";
                    headerRange.Font.Size = 25;
                    headerRange.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                }
                //save the file
                oDoc.SaveAs2(filename);
            }
        }

        private void wordIcon_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Word Documents (*.docx)|*.docx";
            sfd.FileName = "ClientsList.docx";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Export_Data_To_Word(dataGridView1, sfd.FileName);
            }
        }

        private void homeIcon_Click(object sender, EventArgs e)
        {
            this.Hide();
            var mf = new MainForm();
            mf.Closed += (s, args) => this.Close();
            mf.Show();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {

        }

        private void searchByIdBtn_Click(object sender, EventArgs e)
        {

        }

        private void searchId_Click(object sender, EventArgs e)
        {
            string constring = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\whdb.mdf;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand((@"
                SELECT * FROM Clients
                WHERE Clients.Client_ID=@Client_ID"), con))
                {
                    cmd.Parameters.AddWithValue("@Client_ID", SqlDbType.Int).Value = codeTxtBox.Text;
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            dt.Clear();
                            sda.Fill(dt);
                            dataGridView1.DataSource = dt;
                        }
                    }
                }
            }
        }

        private void searchName_Click(object sender, EventArgs e)
        {
            string constring = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\whdb.mdf;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand((@"
                SELECT * FROM Clients
                WHERE Clients.Client_Name like '%'+@Client_Name+'%'"), con))
                {
                    cmd.Parameters.AddWithValue("@Client_Name", SqlDbType.NVarChar).Value = nameTxtBox.Text;
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            dt.Clear();
                            sda.Fill(dt);
                            dataGridView1.DataSource = dt;
                        }
                    }
                }
            }
        }
    }
}

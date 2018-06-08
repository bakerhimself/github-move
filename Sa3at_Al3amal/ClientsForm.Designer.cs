namespace Sa3at_Al3amal
{
    partial class ClientsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientsForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.joinDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.whdbDataSet = new Sa3at_Al3amal.whdbDataSet();
            this.clientsTableAdapter = new Sa3at_Al3amal.whdbDataSetTableAdapters.ClientsTableAdapter();
            this.wordIcon = new System.Windows.Forms.PictureBox();
            this.excelIcon = new System.Windows.Forms.PictureBox();
            this.refreshIcon = new System.Windows.Forms.PictureBox();
            this.deleteIcon = new System.Windows.Forms.PictureBox();
            this.editIcon = new System.Windows.Forms.PictureBox();
            this.addIcon = new System.Windows.Forms.PictureBox();
            this.homeIcon = new System.Windows.Forms.PictureBox();
            this.codeTxtBox = new System.Windows.Forms.TextBox();
            this.nameTxtBox = new System.Windows.Forms.TextBox();
            this.searchId = new System.Windows.Forms.PictureBox();
            this.searchName = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.whdbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wordIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.excelIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refreshIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deleteIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchName)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Traditional Arabic", 12F, System.Drawing.FontStyle.Bold);
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Traditional Arabic", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clientIDDataGridViewTextBoxColumn,
            this.clientNameDataGridViewTextBoxColumn,
            this.clientStatusDataGridViewTextBoxColumn,
            this.serviceDataGridViewTextBoxColumn,
            this.joinDateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.clientsBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Traditional Arabic", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Location = new System.Drawing.Point(12, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(1168, 544);
            this.dataGridView1.TabIndex = 64;
            // 
            // clientIDDataGridViewTextBoxColumn
            // 
            this.clientIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clientIDDataGridViewTextBoxColumn.DataPropertyName = "Client_ID";
            this.clientIDDataGridViewTextBoxColumn.HeaderText = "كود العميل";
            this.clientIDDataGridViewTextBoxColumn.Name = "clientIDDataGridViewTextBoxColumn";
            this.clientIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.clientIDDataGridViewTextBoxColumn.Width = 102;
            // 
            // clientNameDataGridViewTextBoxColumn
            // 
            this.clientNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clientNameDataGridViewTextBoxColumn.DataPropertyName = "Client_Name";
            this.clientNameDataGridViewTextBoxColumn.HeaderText = "إسم العميل";
            this.clientNameDataGridViewTextBoxColumn.MaxInputLength = 99767;
            this.clientNameDataGridViewTextBoxColumn.Name = "clientNameDataGridViewTextBoxColumn";
            this.clientNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.clientNameDataGridViewTextBoxColumn.Width = 101;
            // 
            // clientStatusDataGridViewTextBoxColumn
            // 
            this.clientStatusDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clientStatusDataGridViewTextBoxColumn.DataPropertyName = "Client_Status";
            this.clientStatusDataGridViewTextBoxColumn.HeaderText = "الحالة";
            this.clientStatusDataGridViewTextBoxColumn.Name = "clientStatusDataGridViewTextBoxColumn";
            this.clientStatusDataGridViewTextBoxColumn.ReadOnly = true;
            this.clientStatusDataGridViewTextBoxColumn.Width = 67;
            // 
            // serviceDataGridViewTextBoxColumn
            // 
            this.serviceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.serviceDataGridViewTextBoxColumn.DataPropertyName = "Service";
            this.serviceDataGridViewTextBoxColumn.HeaderText = "نوع الخدمة";
            this.serviceDataGridViewTextBoxColumn.Name = "serviceDataGridViewTextBoxColumn";
            this.serviceDataGridViewTextBoxColumn.ReadOnly = true;
            this.serviceDataGridViewTextBoxColumn.Width = 97;
            // 
            // joinDateDataGridViewTextBoxColumn
            // 
            this.joinDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.joinDateDataGridViewTextBoxColumn.DataPropertyName = "Join_Date";
            this.joinDateDataGridViewTextBoxColumn.HeaderText = "تاريخ الإنضمام";
            this.joinDateDataGridViewTextBoxColumn.Name = "joinDateDataGridViewTextBoxColumn";
            this.joinDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.joinDateDataGridViewTextBoxColumn.Width = 121;
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "Clients";
            this.clientsBindingSource.DataSource = this.whdbDataSet;
            // 
            // whdbDataSet
            // 
            this.whdbDataSet.DataSetName = "whdbDataSet";
            this.whdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // wordIcon
            // 
            this.wordIcon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.wordIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.wordIcon.Image = global::Sa3at_Al3amal.Properties.Resources.word;
            this.wordIcon.Location = new System.Drawing.Point(1195, 333);
            this.wordIcon.Name = "wordIcon";
            this.wordIcon.Size = new System.Drawing.Size(24, 24);
            this.wordIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.wordIcon.TabIndex = 70;
            this.wordIcon.TabStop = false;
            this.wordIcon.Click += new System.EventHandler(this.wordIcon_Click);
            // 
            // excelIcon
            // 
            this.excelIcon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.excelIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.excelIcon.Image = global::Sa3at_Al3amal.Properties.Resources.excel;
            this.excelIcon.Location = new System.Drawing.Point(1195, 293);
            this.excelIcon.Name = "excelIcon";
            this.excelIcon.Size = new System.Drawing.Size(24, 24);
            this.excelIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.excelIcon.TabIndex = 69;
            this.excelIcon.TabStop = false;
            this.excelIcon.Click += new System.EventHandler(this.excelIcon_Click);
            // 
            // refreshIcon
            // 
            this.refreshIcon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.refreshIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshIcon.Image = global::Sa3at_Al3amal.Properties.Resources.refresh;
            this.refreshIcon.Location = new System.Drawing.Point(1195, 254);
            this.refreshIcon.Name = "refreshIcon";
            this.refreshIcon.Size = new System.Drawing.Size(24, 24);
            this.refreshIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.refreshIcon.TabIndex = 68;
            this.refreshIcon.TabStop = false;
            this.refreshIcon.Click += new System.EventHandler(this.refreshIcon_Click);
            // 
            // deleteIcon
            // 
            this.deleteIcon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deleteIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteIcon.Image = global::Sa3at_Al3amal.Properties.Resources.delete;
            this.deleteIcon.Location = new System.Drawing.Point(1195, 214);
            this.deleteIcon.Name = "deleteIcon";
            this.deleteIcon.Size = new System.Drawing.Size(24, 24);
            this.deleteIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.deleteIcon.TabIndex = 67;
            this.deleteIcon.TabStop = false;
            this.deleteIcon.Click += new System.EventHandler(this.deleteIcon_Click);
            // 
            // editIcon
            // 
            this.editIcon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.editIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editIcon.Image = global::Sa3at_Al3amal.Properties.Resources.edit;
            this.editIcon.Location = new System.Drawing.Point(1195, 169);
            this.editIcon.Name = "editIcon";
            this.editIcon.Size = new System.Drawing.Size(24, 24);
            this.editIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.editIcon.TabIndex = 66;
            this.editIcon.TabStop = false;
            this.editIcon.Click += new System.EventHandler(this.editIcon_Click);
            // 
            // addIcon
            // 
            this.addIcon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addIcon.Image = global::Sa3at_Al3amal.Properties.Resources.add;
            this.addIcon.Location = new System.Drawing.Point(1195, 128);
            this.addIcon.Name = "addIcon";
            this.addIcon.Size = new System.Drawing.Size(24, 24);
            this.addIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.addIcon.TabIndex = 65;
            this.addIcon.TabStop = false;
            this.addIcon.Click += new System.EventHandler(this.addIcon_Click);
            // 
            // homeIcon
            // 
            this.homeIcon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.homeIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homeIcon.Image = global::Sa3at_Al3amal.Properties.Resources.home;
            this.homeIcon.Location = new System.Drawing.Point(1195, 85);
            this.homeIcon.Name = "homeIcon";
            this.homeIcon.Size = new System.Drawing.Size(24, 24);
            this.homeIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.homeIcon.TabIndex = 96;
            this.homeIcon.TabStop = false;
            this.homeIcon.Click += new System.EventHandler(this.homeIcon_Click);
            // 
            // codeTxtBox
            // 
            this.codeTxtBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.codeTxtBox.Font = new System.Drawing.Font("Traditional Arabic", 12F, System.Drawing.FontStyle.Bold);
            this.codeTxtBox.Location = new System.Drawing.Point(988, 29);
            this.codeTxtBox.Name = "codeTxtBox";
            this.codeTxtBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.codeTxtBox.Size = new System.Drawing.Size(108, 38);
            this.codeTxtBox.TabIndex = 1;
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameTxtBox.Font = new System.Drawing.Font("Traditional Arabic", 12F, System.Drawing.FontStyle.Bold);
            this.nameTxtBox.Location = new System.Drawing.Point(642, 29);
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nameTxtBox.Size = new System.Drawing.Size(193, 38);
            this.nameTxtBox.TabIndex = 3;
            // 
            // searchId
            // 
            this.searchId.AccessibleDescription = "";
            this.searchId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchId.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchId.Image = global::Sa3at_Al3amal.Properties.Resources.search;
            this.searchId.Location = new System.Drawing.Point(949, 35);
            this.searchId.Name = "searchId";
            this.searchId.Size = new System.Drawing.Size(24, 24);
            this.searchId.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.searchId.TabIndex = 101;
            this.searchId.TabStop = false;
            this.searchId.Tag = "";
            this.searchId.Click += new System.EventHandler(this.searchId_Click);
            // 
            // searchName
            // 
            this.searchName.AccessibleDescription = "";
            this.searchName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchName.Image = global::Sa3at_Al3amal.Properties.Resources.search;
            this.searchName.Location = new System.Drawing.Point(603, 35);
            this.searchName.Name = "searchName";
            this.searchName.Size = new System.Drawing.Size(24, 24);
            this.searchName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.searchName.TabIndex = 102;
            this.searchName.TabStop = false;
            this.searchName.Tag = "";
            this.searchName.Click += new System.EventHandler(this.searchName_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Traditional Arabic", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(1102, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 31);
            this.label1.TabIndex = 103;
            this.label1.Text = "بحث بالكود";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Traditional Arabic", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(841, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 31);
            this.label2.TabIndex = 104;
            this.label2.Text = "بحث بالإسم";
            // 
            // ClientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1231, 581);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchName);
            this.Controls.Add(this.searchId);
            this.Controls.Add(this.nameTxtBox);
            this.Controls.Add(this.codeTxtBox);
            this.Controls.Add(this.homeIcon);
            this.Controls.Add(this.wordIcon);
            this.Controls.Add(this.excelIcon);
            this.Controls.Add(this.refreshIcon);
            this.Controls.Add(this.deleteIcon);
            this.Controls.Add(this.editIcon);
            this.Controls.Add(this.addIcon);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ClientsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "العملاء";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ClientsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.whdbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wordIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.excelIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refreshIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deleteIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox wordIcon;
        private System.Windows.Forms.PictureBox excelIcon;
        private System.Windows.Forms.PictureBox refreshIcon;
        private System.Windows.Forms.PictureBox deleteIcon;
        private System.Windows.Forms.PictureBox editIcon;
        private System.Windows.Forms.PictureBox addIcon;
        private System.Windows.Forms.DataGridView dataGridView1;
        private whdbDataSet whdbDataSet;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private whdbDataSetTableAdapters.ClientsTableAdapter clientsTableAdapter;
        private System.Windows.Forms.PictureBox homeIcon;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn joinDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox codeTxtBox;
        private System.Windows.Forms.TextBox nameTxtBox;
        private System.Windows.Forms.PictureBox searchId;
        private System.Windows.Forms.PictureBox searchName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
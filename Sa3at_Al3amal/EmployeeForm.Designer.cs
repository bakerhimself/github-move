namespace Sa3at_Al3amal
{
    partial class EmployeeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.empIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empRoleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.whdbDataSet = new Sa3at_Al3amal.whdbDataSet();
            this.wordIcon = new System.Windows.Forms.PictureBox();
            this.refreshIcon = new System.Windows.Forms.PictureBox();
            this.deleteIcon = new System.Windows.Forms.PictureBox();
            this.editIcon = new System.Windows.Forms.PictureBox();
            this.addIcon = new System.Windows.Forms.PictureBox();
            this.excelIcon = new System.Windows.Forms.PictureBox();
            this.homeIcon = new System.Windows.Forms.PictureBox();
            this.codeTxtBox = new System.Windows.Forms.TextBox();
            this.nameTxtBox = new System.Windows.Forms.TextBox();
            this.employeesTableAdapter = new Sa3at_Al3amal.whdbDataSetTableAdapters.EmployeesTableAdapter();
            this.searchId = new System.Windows.Forms.PictureBox();
            this.searchName = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.whdbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wordIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refreshIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deleteIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.excelIcon)).BeginInit();
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
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
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
            this.empIDDataGridViewTextBoxColumn,
            this.empNameDataGridViewTextBoxColumn,
            this.empRoleDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.employeesBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Traditional Arabic", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Location = new System.Drawing.Point(10, 95);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(623, 503);
            this.dataGridView1.TabIndex = 59;
            // 
            // empIDDataGridViewTextBoxColumn
            // 
            this.empIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.empIDDataGridViewTextBoxColumn.DataPropertyName = "Emp_ID";
            this.empIDDataGridViewTextBoxColumn.HeaderText = "كود الموظف";
            this.empIDDataGridViewTextBoxColumn.Name = "empIDDataGridViewTextBoxColumn";
            this.empIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.empIDDataGridViewTextBoxColumn.Width = 108;
            // 
            // empNameDataGridViewTextBoxColumn
            // 
            this.empNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.empNameDataGridViewTextBoxColumn.DataPropertyName = "Emp_Name";
            this.empNameDataGridViewTextBoxColumn.HeaderText = "إسم الموظف";
            this.empNameDataGridViewTextBoxColumn.Name = "empNameDataGridViewTextBoxColumn";
            this.empNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.empNameDataGridViewTextBoxColumn.Width = 107;
            // 
            // empRoleDataGridViewTextBoxColumn
            // 
            this.empRoleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.empRoleDataGridViewTextBoxColumn.DataPropertyName = "Emp_Role";
            this.empRoleDataGridViewTextBoxColumn.HeaderText = "الوظيفة";
            this.empRoleDataGridViewTextBoxColumn.Name = "empRoleDataGridViewTextBoxColumn";
            this.empRoleDataGridViewTextBoxColumn.Width = 79;
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.whdbDataSet;
            // 
            // whdbDataSet
            // 
            this.whdbDataSet.DataSetName = "whdbDataSet";
            this.whdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // wordIcon
            // 
            this.wordIcon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.wordIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.wordIcon.Image = global::Sa3at_Al3amal.Properties.Resources.word;
            this.wordIcon.Location = new System.Drawing.Point(649, 343);
            this.wordIcon.Name = "wordIcon";
            this.wordIcon.Size = new System.Drawing.Size(24, 24);
            this.wordIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.wordIcon.TabIndex = 70;
            this.wordIcon.TabStop = false;
            this.wordIcon.Click += new System.EventHandler(this.wordIcon_Click);
            // 
            // refreshIcon
            // 
            this.refreshIcon.AccessibleDescription = "";
            this.refreshIcon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.refreshIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshIcon.Image = global::Sa3at_Al3amal.Properties.Resources.refresh;
            this.refreshIcon.Location = new System.Drawing.Point(649, 262);
            this.refreshIcon.Name = "refreshIcon";
            this.refreshIcon.Size = new System.Drawing.Size(24, 24);
            this.refreshIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.refreshIcon.TabIndex = 69;
            this.refreshIcon.TabStop = false;
            this.refreshIcon.Tag = "";
            this.refreshIcon.Click += new System.EventHandler(this.refreshIcon_Click);
            // 
            // deleteIcon
            // 
            this.deleteIcon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deleteIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteIcon.Image = global::Sa3at_Al3amal.Properties.Resources.delete;
            this.deleteIcon.Location = new System.Drawing.Point(649, 220);
            this.deleteIcon.Name = "deleteIcon";
            this.deleteIcon.Size = new System.Drawing.Size(24, 24);
            this.deleteIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.deleteIcon.TabIndex = 68;
            this.deleteIcon.TabStop = false;
            this.deleteIcon.Click += new System.EventHandler(this.deleteIcon_Click);
            // 
            // editIcon
            // 
            this.editIcon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.editIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editIcon.Image = global::Sa3at_Al3amal.Properties.Resources.edit;
            this.editIcon.Location = new System.Drawing.Point(649, 176);
            this.editIcon.Name = "editIcon";
            this.editIcon.Size = new System.Drawing.Size(24, 24);
            this.editIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.editIcon.TabIndex = 67;
            this.editIcon.TabStop = false;
            this.editIcon.Click += new System.EventHandler(this.editIcon_Click);
            // 
            // addIcon
            // 
            this.addIcon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addIcon.Image = global::Sa3at_Al3amal.Properties.Resources.add;
            this.addIcon.Location = new System.Drawing.Point(649, 134);
            this.addIcon.Name = "addIcon";
            this.addIcon.Size = new System.Drawing.Size(24, 24);
            this.addIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.addIcon.TabIndex = 66;
            this.addIcon.TabStop = false;
            this.addIcon.Click += new System.EventHandler(this.addIcon_Click);
            // 
            // excelIcon
            // 
            this.excelIcon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.excelIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.excelIcon.Image = global::Sa3at_Al3amal.Properties.Resources.excel;
            this.excelIcon.Location = new System.Drawing.Point(649, 302);
            this.excelIcon.Name = "excelIcon";
            this.excelIcon.Size = new System.Drawing.Size(24, 24);
            this.excelIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.excelIcon.TabIndex = 65;
            this.excelIcon.TabStop = false;
            this.excelIcon.Click += new System.EventHandler(this.excelIcon_Click);
            // 
            // homeIcon
            // 
            this.homeIcon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.homeIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homeIcon.Image = global::Sa3at_Al3amal.Properties.Resources.home;
            this.homeIcon.Location = new System.Drawing.Point(649, 95);
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
            this.codeTxtBox.Location = new System.Drawing.Point(449, 45);
            this.codeTxtBox.Name = "codeTxtBox";
            this.codeTxtBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.codeTxtBox.Size = new System.Drawing.Size(100, 38);
            this.codeTxtBox.TabIndex = 1;
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameTxtBox.Font = new System.Drawing.Font("Traditional Arabic", 12F, System.Drawing.FontStyle.Bold);
            this.nameTxtBox.Location = new System.Drawing.Point(192, 45);
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nameTxtBox.Size = new System.Drawing.Size(127, 38);
            this.nameTxtBox.TabIndex = 3;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // searchId
            // 
            this.searchId.AccessibleDescription = "";
            this.searchId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchId.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchId.Image = global::Sa3at_Al3amal.Properties.Resources.search;
            this.searchId.Location = new System.Drawing.Point(419, 52);
            this.searchId.Name = "searchId";
            this.searchId.Size = new System.Drawing.Size(24, 24);
            this.searchId.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.searchId.TabIndex = 102;
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
            this.searchName.Location = new System.Drawing.Point(162, 52);
            this.searchName.Name = "searchName";
            this.searchName.Size = new System.Drawing.Size(24, 24);
            this.searchName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.searchName.TabIndex = 103;
            this.searchName.TabStop = false;
            this.searchName.Tag = "";
            this.searchName.Click += new System.EventHandler(this.searchName_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Traditional Arabic", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(555, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 31);
            this.label1.TabIndex = 104;
            this.label1.Text = "بحث بالكود";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Traditional Arabic", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(325, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 31);
            this.label2.TabIndex = 105;
            this.label2.Text = "بحث بالإسم";
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(687, 634);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchName);
            this.Controls.Add(this.searchId);
            this.Controls.Add(this.nameTxtBox);
            this.Controls.Add(this.codeTxtBox);
            this.Controls.Add(this.homeIcon);
            this.Controls.Add(this.wordIcon);
            this.Controls.Add(this.refreshIcon);
            this.Controls.Add(this.deleteIcon);
            this.Controls.Add(this.editIcon);
            this.Controls.Add(this.addIcon);
            this.Controls.Add(this.excelIcon);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الموظفون";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.whdbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wordIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refreshIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deleteIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.excelIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox wordIcon;
        private System.Windows.Forms.PictureBox refreshIcon;
        private System.Windows.Forms.PictureBox deleteIcon;
        private System.Windows.Forms.PictureBox editIcon;
        private System.Windows.Forms.PictureBox addIcon;
        private System.Windows.Forms.PictureBox excelIcon;
        private whdbDataSet whdbDataSet;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private whdbDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.PictureBox homeIcon;
        private System.Windows.Forms.DataGridViewTextBoxColumn empIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empRoleDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox codeTxtBox;
        private System.Windows.Forms.TextBox nameTxtBox;
        private System.Windows.Forms.PictureBox searchId;
        private System.Windows.Forms.PictureBox searchName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
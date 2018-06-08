namespace Sa3at_Al3amal
{
    partial class WorkHoursEmp
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkHoursEmp));
            this.WorkHoursBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.whdbDataSet = new Sa3at_Al3amal.whdbDataSet();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.searchIcon = new System.Windows.Forms.PictureBox();
            this.refreshIcon = new System.Windows.Forms.PictureBox();
            this.deleteIcon = new System.Windows.Forms.PictureBox();
            this.addIcon = new System.Windows.Forms.PictureBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.WorkHoursTableAdapter = new Sa3at_Al3amal.whdbDataSetTableAdapters.WorkHoursTableAdapter();
            this.homeIcon = new System.Windows.Forms.PictureBox();
            this.codeTxtBox = new System.Windows.Forms.TextBox();
            this.fetchNameBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.WorkHoursBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.whdbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refreshIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deleteIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // WorkHoursBindingSource
            // 
            this.WorkHoursBindingSource.DataMember = "WorkHours";
            this.WorkHoursBindingSource.DataSource = this.whdbDataSet;
            // 
            // whdbDataSet
            // 
            this.whdbDataSet.DataSetName = "whdbDataSet";
            this.whdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Traditional Arabic", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(426, 74);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(34, 31);
            this.label6.TabIndex = 90;
            this.label6.Text = "إلى:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker2.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker2.Font = new System.Drawing.Font("Traditional Arabic", 12F, System.Drawing.FontStyle.Bold);
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(241, 68);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(179, 38);
            this.dateTimePicker2.TabIndex = 85;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Traditional Arabic", 12F, System.Drawing.FontStyle.Bold);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(478, 68);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(179, 38);
            this.dateTimePicker1.TabIndex = 84;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Traditional Arabic", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(654, 71);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(35, 31);
            this.label5.TabIndex = 89;
            this.label5.Text = "من:";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox1.Font = new System.Drawing.Font("Traditional Arabic", 12F, System.Drawing.FontStyle.Bold);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(695, 68);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBox1.Size = new System.Drawing.Size(254, 39);
            this.comboBox1.TabIndex = 83;
            this.comboBox1.Text = "إسم المُراجع";
            // 
            // searchIcon
            // 
            this.searchIcon.AccessibleDescription = "";
            this.searchIcon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchIcon.Image = global::Sa3at_Al3amal.Properties.Resources.search;
            this.searchIcon.Location = new System.Drawing.Point(200, 74);
            this.searchIcon.Name = "searchIcon";
            this.searchIcon.Size = new System.Drawing.Size(24, 24);
            this.searchIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.searchIcon.TabIndex = 92;
            this.searchIcon.TabStop = false;
            this.searchIcon.Tag = "";
            this.searchIcon.Click += new System.EventHandler(this.searchIcon_Click);
            // 
            // refreshIcon
            // 
            this.refreshIcon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.refreshIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshIcon.Image = global::Sa3at_Al3amal.Properties.Resources.refresh;
            this.refreshIcon.Location = new System.Drawing.Point(995, 70);
            this.refreshIcon.Name = "refreshIcon";
            this.refreshIcon.Size = new System.Drawing.Size(24, 24);
            this.refreshIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.refreshIcon.TabIndex = 88;
            this.refreshIcon.TabStop = false;
            this.refreshIcon.Click += new System.EventHandler(this.refreshIcon_Click);
            // 
            // deleteIcon
            // 
            this.deleteIcon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deleteIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteIcon.Image = global::Sa3at_Al3amal.Properties.Resources.delete;
            this.deleteIcon.Location = new System.Drawing.Point(1025, 70);
            this.deleteIcon.Name = "deleteIcon";
            this.deleteIcon.Size = new System.Drawing.Size(24, 24);
            this.deleteIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.deleteIcon.TabIndex = 87;
            this.deleteIcon.TabStop = false;
            this.deleteIcon.Click += new System.EventHandler(this.deleteIcon_Click);
            // 
            // addIcon
            // 
            this.addIcon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addIcon.Image = global::Sa3at_Al3amal.Properties.Resources.add;
            this.addIcon.Location = new System.Drawing.Point(965, 70);
            this.addIcon.Name = "addIcon";
            this.addIcon.Size = new System.Drawing.Size(24, 24);
            this.addIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.addIcon.TabIndex = 86;
            this.addIcon.TabStop = false;
            this.addIcon.Click += new System.EventHandler(this.addIcon_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.reportViewer1.Font = new System.Drawing.Font("Calibri", 10.2F);
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.WorkHoursBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Sa3at_Al3amal.reportByEmp.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 114);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1074, 662);
            this.reportViewer1.TabIndex = 93;
            // 
            // WorkHoursTableAdapter
            // 
            this.WorkHoursTableAdapter.ClearBeforeFill = true;
            // 
            // homeIcon
            // 
            this.homeIcon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.homeIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homeIcon.Image = global::Sa3at_Al3amal.Properties.Resources.home;
            this.homeIcon.Location = new System.Drawing.Point(1055, 71);
            this.homeIcon.Name = "homeIcon";
            this.homeIcon.Size = new System.Drawing.Size(24, 24);
            this.homeIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.homeIcon.TabIndex = 94;
            this.homeIcon.TabStop = false;
            this.homeIcon.Click += new System.EventHandler(this.homeIcon_Click);
            // 
            // codeTxtBox
            // 
            this.codeTxtBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.codeTxtBox.Font = new System.Drawing.Font("Traditional Arabic", 12F, System.Drawing.FontStyle.Bold);
            this.codeTxtBox.Location = new System.Drawing.Point(761, 22);
            this.codeTxtBox.Name = "codeTxtBox";
            this.codeTxtBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.codeTxtBox.Size = new System.Drawing.Size(102, 38);
            this.codeTxtBox.TabIndex = 1;
            // 
            // fetchNameBtn
            // 
            this.fetchNameBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fetchNameBtn.Font = new System.Drawing.Font("Traditional Arabic", 12F, System.Drawing.FontStyle.Bold);
            this.fetchNameBtn.Location = new System.Drawing.Point(695, 22);
            this.fetchNameBtn.Name = "fetchNameBtn";
            this.fetchNameBtn.Size = new System.Drawing.Size(60, 36);
            this.fetchNameBtn.TabIndex = 2;
            this.fetchNameBtn.Text = "بحث";
            this.fetchNameBtn.UseVisualStyleBackColor = true;
            this.fetchNameBtn.Click += new System.EventHandler(this.fetchNameBtn_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Traditional Arabic", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(869, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 31);
            this.label1.TabIndex = 99;
            this.label1.Text = "كود المراجع";
            // 
            // WorkHoursEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1098, 732);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fetchNameBtn);
            this.Controls.Add(this.codeTxtBox);
            this.Controls.Add(this.homeIcon);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.searchIcon);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.refreshIcon);
            this.Controls.Add(this.deleteIcon);
            this.Controls.Add(this.addIcon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WorkHoursEmp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ساعات العمل: مُراجعين";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.WorkHoursEmp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WorkHoursBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.whdbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refreshIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deleteIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox searchIcon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox refreshIcon;
        private System.Windows.Forms.PictureBox deleteIcon;
        private System.Windows.Forms.PictureBox addIcon;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource WorkHoursBindingSource;
        private whdbDataSet whdbDataSet;
        private whdbDataSetTableAdapters.WorkHoursTableAdapter WorkHoursTableAdapter;
        private System.Windows.Forms.PictureBox homeIcon;
        private System.Windows.Forms.TextBox codeTxtBox;
        private System.Windows.Forms.Button fetchNameBtn;
        private System.Windows.Forms.Label label1;
    }
}
﻿namespace Sa3at_Al3amal
{
    partial class AddClient
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
            this.saveBtn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // saveBtn
            // 
            this.saveBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.saveBtn.Font = new System.Drawing.Font("Traditional Arabic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Location = new System.Drawing.Point(262, 285);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(86, 36);
            this.saveBtn.TabIndex = 26;
            this.saveBtn.Text = "حفظ";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox1.Font = new System.Drawing.Font("Traditional Arabic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "عميل سنة حالية",
            "عميل مُرحّل من السنة الماضية",
            "عميل تسويق لم يتم التوقيع معه بعد",
            "عميل مُرحّل من سنين سابقة",
            "جرد للعُملاء"});
            this.comboBox1.Location = new System.Drawing.Point(57, 99);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBox1.Size = new System.Drawing.Size(291, 39);
            this.comboBox1.TabIndex = 23;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Font = new System.Drawing.Font("Traditional Arabic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(57, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(291, 38);
            this.textBox1.TabIndex = 22;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Traditional Arabic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(366, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 31);
            this.label2.TabIndex = 28;
            this.label2.Text = "الحالة";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Traditional Arabic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(354, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 31);
            this.label1.TabIndex = 27;
            this.label1.Text = "إسم العميل";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Traditional Arabic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(148, 221);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 38);
            this.dateTimePicker1.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Traditional Arabic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(348, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 31);
            this.label4.TabIndex = 30;
            this.label4.Text = "تاريخ الإنضمام";
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox2.Font = new System.Drawing.Font("Traditional Arabic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "مراجعة",
            "تسجيل حسابات",
            "قضايا",
            "تقارير مالية",
            "دراسة جدوى",
            "خدمات زكوية وضريبية",
            "استشارات مالية",
            "تصفية شركات",
            "أخرى"});
            this.comboBox2.Location = new System.Drawing.Point(57, 163);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBox2.Size = new System.Drawing.Size(291, 39);
            this.comboBox2.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Traditional Arabic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(348, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 31);
            this.label3.TabIndex = 29;
            this.label3.Text = " نوع الخدمة";
            // 
            // AddClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 387);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label3);
            this.Name = "AddClient";
            this.Text = "إضافة عميل";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label3;
    }
}
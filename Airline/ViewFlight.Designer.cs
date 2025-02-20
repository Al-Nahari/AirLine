namespace Airline
{
    partial class ViewFlight
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
            this.DGVFlight = new System.Windows.Forms.DataGridView();
            this.Col1F = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col2F = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col3F = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col4F = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col5F = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Report = new System.Windows.Forms.Button();
            this.ReseltF = new System.Windows.Forms.Button();
            this.RecordF = new System.Windows.Forms.Button();
            this.txtFlightTakeOfDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFlightNumOfSeach = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmboFlightDestination = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CmboFlightSource = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFlightCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AddFli = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVFlight)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGVFlight
            // 
            this.DGVFlight.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVFlight.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DGVFlight.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVFlight.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col1F,
            this.Col2F,
            this.Col3F,
            this.Col4F,
            this.Col5F});
            this.DGVFlight.Location = new System.Drawing.Point(0, 0);
            this.DGVFlight.Name = "DGVFlight";
            this.DGVFlight.RowTemplate.Height = 26;
            this.DGVFlight.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVFlight.Size = new System.Drawing.Size(898, 291);
            this.DGVFlight.TabIndex = 73;
            this.DGVFlight.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Col1F
            // 
            this.Col1F.HeaderText = "كود الرحلة";
            this.Col1F.Name = "Col1F";
            // 
            // Col2F
            // 
            this.Col2F.HeaderText = "الرحلة من";
            this.Col2F.Name = "Col2F";
            // 
            // Col3F
            // 
            this.Col3F.HeaderText = "الرحلة إلى";
            this.Col3F.Name = "Col3F";
            // 
            // Col4F
            // 
            this.Col4F.HeaderText = "تاريخ الرحلة";
            this.Col4F.Name = "Col4F";
            // 
            // Col5F
            // 
            this.Col5F.HeaderText = "عدد المقاعد";
            this.Col5F.Name = "Col5F";
            // 
            // Report
            // 
            this.Report.BackColor = System.Drawing.Color.MediumBlue;
            this.Report.ForeColor = System.Drawing.SystemColors.Info;
            this.Report.Location = new System.Drawing.Point(551, 322);
            this.Report.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Report.Name = "Report";
            this.Report.Size = new System.Drawing.Size(132, 51);
            this.Report.TabIndex = 71;
            this.Report.Text = "التقارير";
            this.Report.UseVisualStyleBackColor = false;
            this.Report.Click += new System.EventHandler(this.button1_Click);
            // 
            // ReseltF
            // 
            this.ReseltF.BackColor = System.Drawing.Color.MediumBlue;
            this.ReseltF.ForeColor = System.Drawing.SystemColors.Info;
            this.ReseltF.Location = new System.Drawing.Point(380, 322);
            this.ReseltF.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ReseltF.Name = "ReseltF";
            this.ReseltF.Size = new System.Drawing.Size(132, 51);
            this.ReseltF.TabIndex = 64;
            this.ReseltF.Text = "حذف";
            this.ReseltF.UseVisualStyleBackColor = false;
            this.ReseltF.Click += new System.EventHandler(this.ReseltF_Click);
            // 
            // RecordF
            // 
            this.RecordF.BackColor = System.Drawing.Color.MediumBlue;
            this.RecordF.ForeColor = System.Drawing.SystemColors.Info;
            this.RecordF.Location = new System.Drawing.Point(35, 322);
            this.RecordF.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.RecordF.Name = "RecordF";
            this.RecordF.Size = new System.Drawing.Size(132, 51);
            this.RecordF.TabIndex = 63;
            this.RecordF.Text = "تعديل";
            this.RecordF.UseVisualStyleBackColor = false;
            this.RecordF.Click += new System.EventHandler(this.RecordF_Click);
            // 
            // txtFlightTakeOfDate
            // 
            this.txtFlightTakeOfDate.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFlightTakeOfDate.Location = new System.Drawing.Point(620, 183);
            this.txtFlightTakeOfDate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtFlightTakeOfDate.Name = "txtFlightTakeOfDate";
            this.txtFlightTakeOfDate.Size = new System.Drawing.Size(266, 28);
            this.txtFlightTakeOfDate.TabIndex = 83;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.MediumBlue;
            this.label7.Location = new System.Drawing.Point(470, 186);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 24);
            this.label7.TabIndex = 82;
            this.label7.Text = "تاريخ الرحلة";
            // 
            // txtFlightNumOfSeach
            // 
            this.txtFlightNumOfSeach.Location = new System.Drawing.Point(399, 238);
            this.txtFlightNumOfSeach.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtFlightNumOfSeach.Name = "txtFlightNumOfSeach";
            this.txtFlightNumOfSeach.Size = new System.Drawing.Size(239, 32);
            this.txtFlightNumOfSeach.TabIndex = 81;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.MediumBlue;
            this.label6.Location = new System.Drawing.Point(259, 241);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 24);
            this.label6.TabIndex = 80;
            this.label6.Text = "عدد المقاعد";
            // 
            // cmboFlightDestination
            // 
            this.cmboFlightDestination.FormattingEnabled = true;
            this.cmboFlightDestination.Items.AddRange(new object[] {
            "اليمن",
            "السعودية",
            "مصر",
            "العراق",
            "الأردن",
            "سوريا"});
            this.cmboFlightDestination.Location = new System.Drawing.Point(188, 178);
            this.cmboFlightDestination.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmboFlightDestination.Name = "cmboFlightDestination";
            this.cmboFlightDestination.Size = new System.Drawing.Size(245, 32);
            this.cmboFlightDestination.TabIndex = 79;
            this.cmboFlightDestination.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.MediumBlue;
            this.label5.Location = new System.Drawing.Point(13, 178);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 24);
            this.label5.TabIndex = 78;
            this.label5.Text = "وجهة الرحلة إلى";
            // 
            // CmboFlightSource
            // 
            this.CmboFlightSource.FormattingEnabled = true;
            this.CmboFlightSource.Items.AddRange(new object[] {
            "اليمن",
            "السعودية",
            "مصر",
            "العراق",
            "الأردن",
            "سوريا"});
            this.CmboFlightSource.Location = new System.Drawing.Point(620, 116);
            this.CmboFlightSource.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CmboFlightSource.Name = "CmboFlightSource";
            this.CmboFlightSource.Size = new System.Drawing.Size(266, 32);
            this.CmboFlightSource.TabIndex = 77;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.MediumBlue;
            this.label4.Location = new System.Drawing.Point(445, 119);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 24);
            this.label4.TabIndex = 76;
            this.label4.Text = "وجهة الرحلة من ";
            // 
            // txtFlightCode
            // 
            this.txtFlightCode.Location = new System.Drawing.Point(188, 119);
            this.txtFlightCode.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtFlightCode.Name = "txtFlightCode";
            this.txtFlightCode.Size = new System.Drawing.Size(245, 32);
            this.txtFlightCode.TabIndex = 75;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.MediumBlue;
            this.label3.Location = new System.Drawing.Point(31, 119);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 24);
            this.label3.TabIndex = 74;
            this.label3.Text = "كود الرحلة ";
            // 
            // AddFli
            // 
            this.AddFli.BackColor = System.Drawing.Color.MediumBlue;
            this.AddFli.ForeColor = System.Drawing.SystemColors.Info;
            this.AddFli.Location = new System.Drawing.Point(735, 322);
            this.AddFli.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AddFli.Name = "AddFli";
            this.AddFli.Size = new System.Drawing.Size(132, 51);
            this.AddFli.TabIndex = 84;
            this.AddFli.Text = "إضافة رحلة";
            this.AddFli.UseVisualStyleBackColor = false;
            this.AddFli.Click += new System.EventHandler(this.AddFli_Click);
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.MediumBlue;
            this.Save.ForeColor = System.Drawing.SystemColors.Info;
            this.Save.Location = new System.Drawing.Point(208, 322);
            this.Save.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(132, 51);
            this.Save.TabIndex = 85;
            this.Save.Text = "حفظ";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumBlue;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(898, 77);
            this.panel1.TabIndex = 87;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(390, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 29);
            this.label9.TabIndex = 0;
            this.label9.Text = "الـرحــــلات";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DGVFlight);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 379);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(898, 291);
            this.panel2.TabIndex = 114;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.MediumBlue;
            this.button3.Image = global::Airline.Properties.Resources.back;
            this.button3.Location = new System.Drawing.Point(837, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(61, 48);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ViewFlight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 670);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.AddFli);
            this.Controls.Add(this.txtFlightTakeOfDate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtFlightNumOfSeach);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmboFlightDestination);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CmboFlightSource);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFlightCode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Report);
            this.Controls.Add(this.ReseltF);
            this.Controls.Add(this.RecordF);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "ViewFlight";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewFlight";
            this.Load += new System.EventHandler(this.ViewFlight_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVFlight)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVFlight;
        private System.Windows.Forms.Button Report;
        private System.Windows.Forms.Button ReseltF;
        private System.Windows.Forms.Button RecordF;
        private System.Windows.Forms.DateTimePicker txtFlightTakeOfDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFlightNumOfSeach;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmboFlightDestination;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CmboFlightSource;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFlightCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddFli;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col1F;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col2F;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col3F;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col4F;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col5F;
        private System.Windows.Forms.Button button3;
    }
}
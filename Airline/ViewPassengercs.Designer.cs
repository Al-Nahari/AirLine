namespace Airline
{
    partial class ViewPassengercs
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
            this.Phone = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Address = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Passport = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ReseltF = new System.Windows.Forms.Button();
            this.RecordF = new System.Windows.Forms.Button();
            this.NamePassenger = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Gender = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Nationality = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.DGVPassenger = new System.Windows.Forms.DataGridView();
            this.Col2P = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col3P = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col4P = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col5P = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col6P = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col7P = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Save = new System.Windows.Forms.Button();
            this.AddPassenger = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnToReport = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPassenger)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Phone
            // 
            this.Phone.Location = new System.Drawing.Point(188, 196);
            this.Phone.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(250, 32);
            this.Phone.TabIndex = 50;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.MediumBlue;
            this.label9.Location = new System.Drawing.Point(31, 196);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 24);
            this.label9.TabIndex = 49;
            this.label9.Text = "رقم الهاتف";
            // 
            // Address
            // 
            this.Address.Location = new System.Drawing.Point(606, 71);
            this.Address.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(250, 32);
            this.Address.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.MediumBlue;
            this.label1.Location = new System.Drawing.Point(446, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 24);
            this.label1.TabIndex = 47;
            this.label1.Text = "عنوان المسافر";
            // 
            // Passport
            // 
            this.Passport.Location = new System.Drawing.Point(602, 196);
            this.Passport.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Passport.Name = "Passport";
            this.Passport.Size = new System.Drawing.Size(254, 32);
            this.Passport.TabIndex = 46;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.MediumBlue;
            this.label8.Location = new System.Drawing.Point(472, 196);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 24);
            this.label8.TabIndex = 45;
            this.label8.Text = "رقم الجواز";
            // 
            // ReseltF
            // 
            this.ReseltF.BackColor = System.Drawing.Color.MediumBlue;
            this.ReseltF.ForeColor = System.Drawing.SystemColors.Info;
            this.ReseltF.Location = new System.Drawing.Point(283, 328);
            this.ReseltF.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ReseltF.Name = "ReseltF";
            this.ReseltF.Size = new System.Drawing.Size(132, 51);
            this.ReseltF.TabIndex = 44;
            this.ReseltF.Text = "حذف";
            this.ReseltF.UseVisualStyleBackColor = false;
            this.ReseltF.Click += new System.EventHandler(this.ReseltF_Click);
            // 
            // RecordF
            // 
            this.RecordF.BackColor = System.Drawing.Color.MediumBlue;
            this.RecordF.ForeColor = System.Drawing.SystemColors.Info;
            this.RecordF.Location = new System.Drawing.Point(13, 328);
            this.RecordF.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.RecordF.Name = "RecordF";
            this.RecordF.Size = new System.Drawing.Size(132, 51);
            this.RecordF.TabIndex = 43;
            this.RecordF.Text = "تعديل";
            this.RecordF.UseVisualStyleBackColor = false;
            this.RecordF.Click += new System.EventHandler(this.RecordF_Click);
            // 
            // NamePassenger
            // 
            this.NamePassenger.Location = new System.Drawing.Point(188, 71);
            this.NamePassenger.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.NamePassenger.Name = "NamePassenger";
            this.NamePassenger.Size = new System.Drawing.Size(250, 32);
            this.NamePassenger.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.MediumBlue;
            this.label6.Location = new System.Drawing.Point(31, 71);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 24);
            this.label6.TabIndex = 41;
            this.label6.Text = "اسم المسافر";
            // 
            // Gender
            // 
            this.Gender.FormattingEnabled = true;
            this.Gender.Items.AddRange(new object[] {
            "ذكر",
            "انثى"});
            this.Gender.Location = new System.Drawing.Point(606, 136);
            this.Gender.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(250, 32);
            this.Gender.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.MediumBlue;
            this.label5.Location = new System.Drawing.Point(31, 139);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 24);
            this.label5.TabIndex = 39;
            this.label5.Text = "الجنسية";
            // 
            // Nationality
            // 
            this.Nationality.FormattingEnabled = true;
            this.Nationality.Items.AddRange(new object[] {
            "يمني",
            "مصري",
            "سعودي",
            "عراقي"});
            this.Nationality.Location = new System.Drawing.Point(188, 136);
            this.Nationality.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Nationality.Name = "Nationality";
            this.Nationality.Size = new System.Drawing.Size(250, 32);
            this.Nationality.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.MediumBlue;
            this.label4.Location = new System.Drawing.Point(472, 139);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 24);
            this.label4.TabIndex = 37;
            this.label4.Text = "الـــــنــــــوع";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumBlue;
            this.button1.ForeColor = System.Drawing.SystemColors.Info;
            this.button1.Location = new System.Drawing.Point(423, 328);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 51);
            this.button1.TabIndex = 51;
            this.button1.Text = "إعادة";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DGVPassenger
            // 
            this.DGVPassenger.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVPassenger.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DGVPassenger.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVPassenger.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col2P,
            this.Col3P,
            this.Col4P,
            this.Col5P,
            this.Col6P,
            this.Col7P});
            this.DGVPassenger.Location = new System.Drawing.Point(0, 3);
            this.DGVPassenger.Name = "DGVPassenger";
            this.DGVPassenger.RowTemplate.Height = 26;
            this.DGVPassenger.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVPassenger.Size = new System.Drawing.Size(872, 282);
            this.DGVPassenger.TabIndex = 53;
            this.DGVPassenger.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVPassenger_CellContentClick);
            this.DGVPassenger.Click += new System.EventHandler(this.DGVPassenger_Click);
            // 
            // Col2P
            // 
            this.Col2P.HeaderText = "اسم المسافر";
            this.Col2P.Name = "Col2P";
            // 
            // Col3P
            // 
            this.Col3P.HeaderText = "رقم الجواز";
            this.Col3P.Name = "Col3P";
            // 
            // Col4P
            // 
            this.Col4P.HeaderText = "عنوان المسافر";
            this.Col4P.Name = "Col4P";
            // 
            // Col5P
            // 
            this.Col5P.HeaderText = "الجنسية";
            this.Col5P.Name = "Col5P";
            // 
            // Col6P
            // 
            this.Col6P.HeaderText = "النوع";
            this.Col6P.Name = "Col6P";
            // 
            // Col7P
            // 
            this.Col7P.HeaderText = "رقم الهاتف";
            this.Col7P.Name = "Col7P";
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.MediumBlue;
            this.Save.ForeColor = System.Drawing.SystemColors.Info;
            this.Save.Location = new System.Drawing.Point(143, 328);
            this.Save.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(132, 51);
            this.Save.TabIndex = 54;
            this.Save.Text = "حفظ";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // AddPassenger
            // 
            this.AddPassenger.BackColor = System.Drawing.Color.MediumBlue;
            this.AddPassenger.ForeColor = System.Drawing.SystemColors.Info;
            this.AddPassenger.Location = new System.Drawing.Point(563, 331);
            this.AddPassenger.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AddPassenger.Name = "AddPassenger";
            this.AddPassenger.Size = new System.Drawing.Size(151, 51);
            this.AddPassenger.TabIndex = 88;
            this.AddPassenger.Text = "إضافة مسافر";
            this.AddPassenger.UseVisualStyleBackColor = false;
            this.AddPassenger.Click += new System.EventHandler(this.AddFli_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumBlue;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(872, 68);
            this.panel1.TabIndex = 89;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(350, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(174, 29);
            this.label7.TabIndex = 0;
            this.label7.Text = "الـمســافـــرين";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DGVPassenger);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 385);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(872, 285);
            this.panel2.TabIndex = 114;
            // 
            // btnToReport
            // 
            this.btnToReport.BackColor = System.Drawing.Color.MediumBlue;
            this.btnToReport.ForeColor = System.Drawing.SystemColors.Info;
            this.btnToReport.Location = new System.Drawing.Point(724, 331);
            this.btnToReport.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnToReport.Name = "btnToReport";
            this.btnToReport.Size = new System.Drawing.Size(132, 51);
            this.btnToReport.TabIndex = 115;
            this.btnToReport.Text = "التقرير";
            this.btnToReport.UseVisualStyleBackColor = false;
            this.btnToReport.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.MediumBlue;
            this.button3.Image = global::Airline.Properties.Resources.back;
            this.button3.Location = new System.Drawing.Point(811, -1);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(61, 48);
            this.button3.TabIndex = 3;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ViewPassengercs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 670);
            this.Controls.Add(this.btnToReport);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.AddPassenger);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Passport);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ReseltF);
            this.Controls.Add(this.RecordF);
            this.Controls.Add(this.NamePassenger);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Nationality);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "ViewPassengercs";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewPassengercs";
            this.Load += new System.EventHandler(this.ViewPassengercs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVPassenger)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Phone;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Passport;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button ReseltF;
        private System.Windows.Forms.Button RecordF;
        private System.Windows.Forms.TextBox NamePassenger;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Gender;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Nationality;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView DGVPassenger;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button AddPassenger;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnToReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col2P;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col3P;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col4P;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col5P;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col6P;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col7P;
        private System.Windows.Forms.Button button3;
    }
}
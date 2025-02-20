namespace Airline
{
    partial class Ticket
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
        public void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ticket));
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AddFli = new System.Windows.Forms.Button();
            this.CmboFlightCode = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DGVTickt = new System.Windows.Forms.DataGridView();
            this.Col1Ticket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col2Ticket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col4Ticket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col5Ticket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col6Ticket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col7Ticket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col8T = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancelTicket = new System.Windows.Forms.Button();
            this.ReseltF = new System.Windows.Forms.Button();
            this.Amount = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmboName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTickt)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(390, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 29);
            this.label9.TabIndex = 0;
            this.label9.Text = "التذاكر";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumBlue;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(910, 68);
            this.panel1.TabIndex = 105;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // AddFli
            // 
            this.AddFli.BackColor = System.Drawing.Color.MediumBlue;
            this.AddFli.ForeColor = System.Drawing.SystemColors.Info;
            this.AddFli.Location = new System.Drawing.Point(28, 311);
            this.AddFli.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AddFli.Name = "AddFli";
            this.AddFli.Size = new System.Drawing.Size(132, 51);
            this.AddFli.TabIndex = 103;
            this.AddFli.Text = "إضافة تذكرة";
            this.AddFli.UseVisualStyleBackColor = false;
            this.AddFli.Click += new System.EventHandler(this.AddFli_Click);
            // 
            // CmboFlightCode
            // 
            this.CmboFlightCode.FormattingEnabled = true;
            this.CmboFlightCode.Location = new System.Drawing.Point(621, 144);
            this.CmboFlightCode.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CmboFlightCode.Name = "CmboFlightCode";
            this.CmboFlightCode.Size = new System.Drawing.Size(266, 32);
            this.CmboFlightCode.TabIndex = 96;
            this.CmboFlightCode.SelectedIndexChanged += new System.EventHandler(this.CmboFlightCode_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.MediumBlue;
            this.label4.Location = new System.Drawing.Point(484, 144);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 24);
            this.label4.TabIndex = 95;
            this.label4.Text = "كود الرحلة";
            // 
            // DGVTickt
            // 
            this.DGVTickt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVTickt.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DGVTickt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVTickt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col1Ticket,
            this.Col2Ticket,
            this.col4Ticket,
            this.Col5Ticket,
            this.Col6Ticket,
            this.Col7Ticket,
            this.Col8T});
            this.DGVTickt.Location = new System.Drawing.Point(3, 0);
            this.DGVTickt.Name = "DGVTickt";
            this.DGVTickt.RowTemplate.Height = 26;
            this.DGVTickt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVTickt.Size = new System.Drawing.Size(904, 321);
            this.DGVTickt.TabIndex = 92;
            // 
            // Col1Ticket
            // 
            this.Col1Ticket.HeaderText = "كود التذكرة";
            this.Col1Ticket.Name = "Col1Ticket";
            // 
            // Col2Ticket
            // 
            this.Col2Ticket.HeaderText = "كود الرحلة";
            this.Col2Ticket.Name = "Col2Ticket";
            // 
            // col4Ticket
            // 
            this.col4Ticket.HeaderText = "اسم المسافر";
            this.col4Ticket.Name = "col4Ticket";
            // 
            // Col5Ticket
            // 
            this.Col5Ticket.HeaderText = "جواز السفر";
            this.Col5Ticket.Name = "Col5Ticket";
            // 
            // Col6Ticket
            // 
            this.Col6Ticket.HeaderText = "الجنسية";
            this.Col6Ticket.Name = "Col6Ticket";
            // 
            // Col7Ticket
            // 
            this.Col7Ticket.HeaderText = "سعر التذكرة";
            this.Col7Ticket.Name = "Col7Ticket";
            // 
            // Col8T
            // 
            this.Col8T.HeaderText = "تاريخ الرحلة";
            this.Col8T.Name = "Col8T";
            // 
            // btnCancelTicket
            // 
            this.btnCancelTicket.BackColor = System.Drawing.Color.MediumBlue;
            this.btnCancelTicket.ForeColor = System.Drawing.SystemColors.Info;
            this.btnCancelTicket.Location = new System.Drawing.Point(698, 311);
            this.btnCancelTicket.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCancelTicket.Name = "btnCancelTicket";
            this.btnCancelTicket.Size = new System.Drawing.Size(189, 51);
            this.btnCancelTicket.TabIndex = 90;
            this.btnCancelTicket.Text = "التذاكر المحذوفة";
            this.btnCancelTicket.UseVisualStyleBackColor = false;
            this.btnCancelTicket.Click += new System.EventHandler(this.button1_Click);
            // 
            // ReseltF
            // 
            this.ReseltF.BackColor = System.Drawing.Color.MediumBlue;
            this.ReseltF.ForeColor = System.Drawing.SystemColors.Info;
            this.ReseltF.Location = new System.Drawing.Point(537, 311);
            this.ReseltF.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ReseltF.Name = "ReseltF";
            this.ReseltF.Size = new System.Drawing.Size(132, 51);
            this.ReseltF.TabIndex = 89;
            this.ReseltF.Text = "حذف";
            this.ReseltF.UseVisualStyleBackColor = false;
            this.ReseltF.Click += new System.EventHandler(this.ReseltF_Click);
            // 
            // Amount
            // 
            this.Amount.Location = new System.Drawing.Point(157, 203);
            this.Amount.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(245, 32);
            this.Amount.TabIndex = 111;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.MediumBlue;
            this.label8.Location = new System.Drawing.Point(24, 206);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 24);
            this.label8.TabIndex = 110;
            this.label8.Text = "سعر التذكرة";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MediumBlue;
            this.button2.ForeColor = System.Drawing.SystemColors.Info;
            this.button2.Location = new System.Drawing.Point(194, 311);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 51);
            this.button2.TabIndex = 112;
            this.button2.Text = "طباعة";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DGVTickt);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 368);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(910, 321);
            this.panel2.TabIndex = 113;
            // 
            // cmboName
            // 
            this.cmboName.FormattingEnabled = true;
            this.cmboName.Location = new System.Drawing.Point(157, 136);
            this.cmboName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmboName.Name = "cmboName";
            this.cmboName.Size = new System.Drawing.Size(245, 32);
            this.cmboName.TabIndex = 115;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.MediumBlue;
            this.label2.Location = new System.Drawing.Point(13, 144);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 24);
            this.label2.TabIndex = 114;
            this.label2.Text = "اسم المسافر";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumBlue;
            this.button1.ForeColor = System.Drawing.SystemColors.Info;
            this.button1.Location = new System.Drawing.Point(374, 311);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 51);
            this.button1.TabIndex = 116;
            this.button1.Text = "التقارير";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.MediumBlue;
            this.button3.Image = global::Airline.Properties.Resources.back;
            this.button3.Location = new System.Drawing.Point(849, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(61, 48);
            this.button3.TabIndex = 1;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Ticket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 689);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmboName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Amount);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.AddFli);
            this.Controls.Add(this.CmboFlightCode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCancelTicket);
            this.Controls.Add(this.ReseltF);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "Ticket";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ticket";
            this.Load += new System.EventHandler(this.Ticket_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTickt)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button AddFli;
        public System.Windows.Forms.ComboBox CmboFlightCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView DGVTickt;
        private System.Windows.Forms.Button btnCancelTicket;
        private System.Windows.Forms.Button ReseltF;
        private System.Windows.Forms.TextBox Amount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmboName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col1Ticket;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col2Ticket;
        private System.Windows.Forms.DataGridViewTextBoxColumn col4Ticket;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col5Ticket;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col6Ticket;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col7Ticket;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col8T;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
    }
}
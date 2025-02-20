namespace Airline.Reports
{
    partial class FrmTicket
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnveiwTicket = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DGVTickt = new System.Windows.Forms.DataGridView();
            this.Col1Ticket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col2Ticket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col4Ticket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col5Ticket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col6Ticket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col7Ticket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col8T = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTickt)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnveiwTicket);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1245, 146);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(409, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 32);
            this.label1.TabIndex = 59;
            this.label1.Text = "تــقــــريـــر الــتذاكر";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Airline.Properties.Resources.icons8_forward_arrow_50px;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(1066, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 69);
            this.button1.TabIndex = 57;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnveiwTicket
            // 
            this.btnveiwTicket.BackColor = System.Drawing.Color.MediumBlue;
            this.btnveiwTicket.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnveiwTicket.ForeColor = System.Drawing.SystemColors.Info;
            this.btnveiwTicket.Location = new System.Drawing.Point(13, 44);
            this.btnveiwTicket.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnveiwTicket.Name = "btnveiwTicket";
            this.btnveiwTicket.Size = new System.Drawing.Size(1030, 69);
            this.btnveiwTicket.TabIndex = 56;
            this.btnveiwTicket.Text = "مـــــعـــايــــنـــــــة   الــتـــقــــريــــر";
            this.btnveiwTicket.UseVisualStyleBackColor = false;
            this.btnveiwTicket.Click += new System.EventHandler(this.btnveiwTicket_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DGVTickt);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 146);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1245, 517);
            this.panel2.TabIndex = 3;
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
            this.DGVTickt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVTickt.Location = new System.Drawing.Point(0, 0);
            this.DGVTickt.Name = "DGVTickt";
            this.DGVTickt.RowTemplate.Height = 26;
            this.DGVTickt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVTickt.Size = new System.Drawing.Size(1245, 517);
            this.DGVTickt.TabIndex = 93;
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
            // FrmTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 663);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Name = "FrmTicket";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTicket";
            this.Load += new System.EventHandler(this.FrmTicket_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVTickt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnveiwTicket;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView DGVTickt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col1Ticket;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col2Ticket;
        private System.Windows.Forms.DataGridViewTextBoxColumn col4Ticket;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col5Ticket;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col6Ticket;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col7Ticket;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col8T;
    }
}
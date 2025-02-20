namespace Airline
{
    partial class CancelTicket
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
            this.label9 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DGV_CancelTicket = new System.Windows.Forms.DataGridView();
            this.DGV_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_TicketId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_FlightCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_PassengerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_PassengerPassport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_FlightTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_AmountTicket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_DateCancel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_CancelTicket)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumBlue;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1039, 69);
            this.panel1.TabIndex = 106;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(419, 21);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(195, 29);
            this.label9.TabIndex = 0;
            this.label9.Text = "التذاكر المحذوفة";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DGV_CancelTicket);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 266);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1039, 296);
            this.panel2.TabIndex = 107;
            // 
            // DGV_CancelTicket
            // 
            this.DGV_CancelTicket.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_CancelTicket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_CancelTicket.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DGV_Id,
            this.DGV_TicketId,
            this.DGV_FlightCode,
            this.DGV_PassengerName,
            this.DGV_PassengerPassport,
            this.DGV_FlightTo,
            this.DGV_AmountTicket,
            this.DGV_DateCancel});
            this.DGV_CancelTicket.Location = new System.Drawing.Point(2, 0);
            this.DGV_CancelTicket.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.DGV_CancelTicket.Name = "DGV_CancelTicket";
            this.DGV_CancelTicket.RowTemplate.Height = 26;
            this.DGV_CancelTicket.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_CancelTicket.Size = new System.Drawing.Size(1037, 296);
            this.DGV_CancelTicket.TabIndex = 0;
            // 
            // DGV_Id
            // 
            this.DGV_Id.HeaderText = "رقم الحذف";
            this.DGV_Id.Name = "DGV_Id";
            this.DGV_Id.Visible = false;
            // 
            // DGV_TicketId
            // 
            this.DGV_TicketId.HeaderText = "كود التذكرة";
            this.DGV_TicketId.Name = "DGV_TicketId";
            // 
            // DGV_FlightCode
            // 
            this.DGV_FlightCode.HeaderText = "كود الرحلة";
            this.DGV_FlightCode.Name = "DGV_FlightCode";
            // 
            // DGV_PassengerName
            // 
            this.DGV_PassengerName.HeaderText = "اســم المسافر";
            this.DGV_PassengerName.Name = "DGV_PassengerName";
            // 
            // DGV_PassengerPassport
            // 
            this.DGV_PassengerPassport.HeaderText = "رقـــم الجواز";
            this.DGV_PassengerPassport.Name = "DGV_PassengerPassport";
            // 
            // DGV_FlightTo
            // 
            this.DGV_FlightTo.HeaderText = "الرحـــلة إلـــى";
            this.DGV_FlightTo.Name = "DGV_FlightTo";
            // 
            // DGV_AmountTicket
            // 
            this.DGV_AmountTicket.HeaderText = "سعر التذكرة";
            this.DGV_AmountTicket.Name = "DGV_AmountTicket";
            // 
            // DGV_DateCancel
            // 
            this.DGV_DateCancel.HeaderText = "تـــاريــخ الحذف";
            this.DGV_DateCancel.Name = "DGV_DateCancel";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.MediumBlue;
            this.button3.Image = global::Airline.Properties.Resources.back;
            this.button3.Location = new System.Drawing.Point(978, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(61, 48);
            this.button3.TabIndex = 3;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // CancelTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 562);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "CancelTicket";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CancelTicket";
            this.Load += new System.EventHandler(this.CancelTicket_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_CancelTicket)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView DGV_CancelTicket;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_TicketId;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_FlightCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_PassengerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_PassengerPassport;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_FlightTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_AmountTicket;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_DateCancel;
        private System.Windows.Forms.Button button3;
    }
}
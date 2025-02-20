namespace Airline
{
    partial class FrmPassengers
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnveiwPassenger = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DGVPassenger = new System.Windows.Forms.DataGridView();
            this.Col1P = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col2P = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col3P = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col4P = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col5P = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col6P = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col7P = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPassenger)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnveiwPassenger);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1226, 146);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            // btnveiwPassenger
            // 
            this.btnveiwPassenger.BackColor = System.Drawing.Color.MediumBlue;
            this.btnveiwPassenger.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnveiwPassenger.ForeColor = System.Drawing.SystemColors.Info;
            this.btnveiwPassenger.Location = new System.Drawing.Point(13, 41);
            this.btnveiwPassenger.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnveiwPassenger.Name = "btnveiwPassenger";
            this.btnveiwPassenger.Size = new System.Drawing.Size(1030, 69);
            this.btnveiwPassenger.TabIndex = 56;
            this.btnveiwPassenger.Text = "مـــــعـــايــــنـــــــة   الــتـــقــــريــــر";
            this.btnveiwPassenger.UseVisualStyleBackColor = false;
            this.btnveiwPassenger.Click += new System.EventHandler(this.btnveiwPassenger_Click_1);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DGVPassenger);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 146);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1226, 573);
            this.panel2.TabIndex = 1;
            // 
            // DGVPassenger
            // 
            this.DGVPassenger.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVPassenger.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DGVPassenger.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVPassenger.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col1P,
            this.Col2P,
            this.Col3P,
            this.Col4P,
            this.Col5P,
            this.Col6P,
            this.Col7P});
            this.DGVPassenger.Location = new System.Drawing.Point(0, 0);
            this.DGVPassenger.Name = "DGVPassenger";
            this.DGVPassenger.RowTemplate.Height = 26;
            this.DGVPassenger.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVPassenger.Size = new System.Drawing.Size(1223, 573);
            this.DGVPassenger.TabIndex = 54;
            // 
            // Col1P
            // 
            this.Col1P.HeaderText = "رقم التعريف";
            this.Col1P.Name = "Col1P";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(407, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 32);
            this.label1.TabIndex = 58;
            this.label1.Text = "تــقــــريـــر الــمســافـــريــن";
            // 
            // FrmPassengers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 719);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmPassengers";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPassengers";
            this.Load += new System.EventHandler(this.FrmPassengers_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVPassenger)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnveiwPassenger;
        private System.Windows.Forms.DataGridView DGVPassenger;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col1P;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col2P;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col3P;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col4P;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col5P;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col6P;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col7P;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}
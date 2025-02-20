namespace Airline.Reports
{
    partial class FrmFlight
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
            this.btnveiwFlight = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DGVFlight = new System.Windows.Forms.DataGridView();
            this.Col1F = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col2F = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col3F = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col4F = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col5F = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVFlight)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnveiwFlight);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1238, 146);
            this.panel1.TabIndex = 1;
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
            // btnveiwFlight
            // 
            this.btnveiwFlight.BackColor = System.Drawing.Color.MediumBlue;
            this.btnveiwFlight.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnveiwFlight.ForeColor = System.Drawing.SystemColors.Info;
            this.btnveiwFlight.Location = new System.Drawing.Point(13, 41);
            this.btnveiwFlight.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnveiwFlight.Name = "btnveiwFlight";
            this.btnveiwFlight.Size = new System.Drawing.Size(1030, 69);
            this.btnveiwFlight.TabIndex = 56;
            this.btnveiwFlight.Text = "مـــــعـــايــــنـــــــة   الــتـــقــــريــــر";
            this.btnveiwFlight.UseVisualStyleBackColor = false;
            this.btnveiwFlight.Click += new System.EventHandler(this.btnveiwPassenger_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DGVFlight);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 146);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1238, 483);
            this.panel2.TabIndex = 2;
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
            this.DGVFlight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVFlight.Location = new System.Drawing.Point(0, 0);
            this.DGVFlight.Name = "DGVFlight";
            this.DGVFlight.RowTemplate.Height = 26;
            this.DGVFlight.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVFlight.Size = new System.Drawing.Size(1238, 483);
            this.DGVFlight.TabIndex = 74;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(409, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 32);
            this.label1.TabIndex = 59;
            this.label1.Text = "تــقــــريـــر الــرحـــلات";
            // 
            // FrmFlight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 629);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmFlight";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmFlight";
            this.Load += new System.EventHandler(this.FrmFlight_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVFlight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnveiwFlight;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView DGVFlight;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col1F;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col2F;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col3F;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col4F;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col5F;
        private System.Windows.Forms.Label label1;
    }
}
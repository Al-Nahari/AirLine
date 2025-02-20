namespace Airline.Reports
{
    partial class FrmReportPass
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
            this.CrystallVPassenger = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // CrystallVPassenger
            // 
            this.CrystallVPassenger.ActiveViewIndex = -1;
            this.CrystallVPassenger.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CrystallVPassenger.Cursor = System.Windows.Forms.Cursors.Default;
            this.CrystallVPassenger.DisplayBackgroundEdge = false;
            this.CrystallVPassenger.DisplayStatusBar = false;
            this.CrystallVPassenger.DisplayToolbar = false;
            this.CrystallVPassenger.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CrystallVPassenger.Location = new System.Drawing.Point(0, 0);
            this.CrystallVPassenger.Name = "CrystallVPassenger";
            this.CrystallVPassenger.Size = new System.Drawing.Size(1272, 588);
            this.CrystallVPassenger.TabIndex = 0;
            this.CrystallVPassenger.Load += new System.EventHandler(this.CrystallVPassenger_Load);
            // 
            // FrmReportPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 588);
            this.Controls.Add(this.CrystallVPassenger);
            this.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmReportPass";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmReportPass_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer CrystallVPassenger;
    }
}
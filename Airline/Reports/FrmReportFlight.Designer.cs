namespace Airline.Reports
{
    partial class FrmReportFlight
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
            this.crystalVFlight = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalVFlight
            // 
            this.crystalVFlight.ActiveViewIndex = -1;
            this.crystalVFlight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalVFlight.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalVFlight.DisplayBackgroundEdge = false;
            this.crystalVFlight.DisplayStatusBar = false;
            this.crystalVFlight.DisplayToolbar = false;
            this.crystalVFlight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalVFlight.Location = new System.Drawing.Point(0, 0);
            this.crystalVFlight.Name = "crystalVFlight";
            this.crystalVFlight.Size = new System.Drawing.Size(1051, 598);
            this.crystalVFlight.TabIndex = 0;
            // 
            // FrmReportFlight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 598);
            this.Controls.Add(this.crystalVFlight);
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "FrmReportFlight";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmReportFlight";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmReportFlight_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalVFlight;
    }
}
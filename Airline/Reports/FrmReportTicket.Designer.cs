namespace Airline.Reports
{
    partial class FrmReportTicket
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
            this.crystalVTicket = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalVTicket
            // 
            this.crystalVTicket.ActiveViewIndex = -1;
            this.crystalVTicket.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalVTicket.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalVTicket.DisplayBackgroundEdge = false;
            this.crystalVTicket.DisplayStatusBar = false;
            this.crystalVTicket.DisplayToolbar = false;
            this.crystalVTicket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalVTicket.Location = new System.Drawing.Point(0, 0);
            this.crystalVTicket.Name = "crystalVTicket";
            this.crystalVTicket.Size = new System.Drawing.Size(976, 541);
            this.crystalVTicket.TabIndex = 0;
            // 
            // FrmReportTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 541);
            this.Controls.Add(this.crystalVTicket);
            this.Name = "FrmReportTicket";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmReportTicket_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalVTicket;
    }
}
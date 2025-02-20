using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Airline.DataSet;

namespace Airline.Reports
{
    public partial class FrmReportPass : Form
    {
        public FrmReportPass()
        {
            InitializeComponent();
        }

        private void FrmReportPass_Load(object sender, EventArgs e)
        {

        }

        public void InitPassengerRPT(DataTable Dt)
        {
            DSPassenger DSP = new DSPassenger();

            for (int i = 0; i < Dt.Rows.Count; i++)
            {
               DSP.Tables["InfoPass"].Rows.Add
                (
                  
                    Dt.Rows[i].ItemArray[0].ToString(),
                    Dt.Rows[i].ItemArray[1].ToString(),
                    Dt.Rows[i].ItemArray[2].ToString(),
                    Dt.Rows[i].ItemArray[3].ToString(),
                    Dt.Rows[i].ItemArray[4].ToString(),
                    Dt.Rows[i].ItemArray[5].ToString()
                );
             
            }
            RPTPassengers RPTP = new RPTPassengers();
            RPTP.SetDataSource(DSP);
            CrystallVPassenger.ReportSource = RPTP;
            CrystallVPassenger.Refresh();
        }

        private void CrystallVPassenger_Load(object sender, EventArgs e)
        {

        }
    }
}

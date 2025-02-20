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
    public partial class FrmReportFlight : Form
    {
        public FrmReportFlight()
        {
            InitializeComponent();
        }

        private void FrmReportFlight_Load(object sender, EventArgs e)
        {

        }

        public void InitFlightRPT(DataTable Dt)
        {
            DSFlight DSF = new DSFlight();

            for (int i = 0; i < Dt.Rows.Count; i++)
            {
                DSF.Tables["InfoFlight"].Rows.Add
                 (

                     Dt.Rows[i].ItemArray[0].ToString(),
                     Dt.Rows[i].ItemArray[1].ToString(),
                     Dt.Rows[i].ItemArray[2].ToString(),
                     Dt.Rows[i].ItemArray[3].ToString(),
                     Dt.Rows[i].ItemArray[4].ToString()
                    
                 );

            }
            RPTFlight RPTF = new RPTFlight();
            RPTF.SetDataSource(DSF);
             crystalVFlight.ReportSource = RPTF;
             crystalVFlight.Refresh();
        }
    }
}

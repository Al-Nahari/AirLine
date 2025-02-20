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
    public partial class FrmReportTicket : Form
    {
        public FrmReportTicket()
        {
            InitializeComponent();
        }

        private void FrmReportTicket_Load(object sender, EventArgs e)
        {

        }
        public void InitFlightRPT(DataTable Dt)
        {
            DSTicket DST = new DSTicket();

            for (int i = 0; i < Dt.Rows.Count; i++)
            {
                DST.Tables["InfoTicket"].Rows.Add
                 (

                     Dt.Rows[i].ItemArray[0].ToString(),
                     Dt.Rows[i].ItemArray[1].ToString(),
                     Dt.Rows[i].ItemArray[2].ToString(),
                     Dt.Rows[i].ItemArray[3].ToString(),
                     Dt.Rows[i].ItemArray[4].ToString(),
                     Dt.Rows[i].ItemArray[5].ToString(),
                     Dt.Rows[i].ItemArray[6].ToString()

                 );

            }
            RPTTicket RPTT = new RPTTicket();
            RPTT.SetDataSource(DST);
            crystalVTicket.ReportSource = RPTT;
            crystalVTicket.Refresh();
        }
    }
}

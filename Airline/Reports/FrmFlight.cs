using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Airline.Reports
{
    public partial class FrmFlight : Form
    {
        DataAccessLayer DAL = new DataAccessLayer();
        public FrmFlight()
        {
            InitializeComponent();
            Dt = new DataTable();
        }
        DataTable Dt;

        private void select_Flight()
        {
            // الاستعلام عن الرحلات بواسطة الاجراء
            #region select_Flight
            DAL.Open();
            SqlDataAdapter Adapter = new SqlDataAdapter("Get_Flight", DAL.sqlconnection);
            Dt.Clear();
            Adapter.Fill(Dt);
            for (int i = 0; i < Dt.Rows.Count; i++)
            {
                object[] ob =
                {
                    Dt.Rows[i].ItemArray[0].ToString(),
                    Dt.Rows[i].ItemArray[1].ToString(),
                    Dt.Rows[i].ItemArray[2].ToString(),
                    Dt.Rows[i].ItemArray[3].ToString(),
                    Dt.Rows[i].ItemArray[4].ToString(),

                };
                DGVFlight.Rows.Add(ob);
            }
            DAL.Close();
            #endregion
        }


        private void FrmFlight_Load(object sender, EventArgs e)
        {
            select_Flight();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ViewFlight VF = new ViewFlight();
            VF.Show();
            this.Close();
        }

        private void btnveiwPassenger_Click(object sender, EventArgs e)
        {
            if (Dt.Rows.Count > 0)
            {

                FrmReportFlight FRF = new FrmReportFlight();
                FRF.InitFlightRPT(Dt);
                FRF.Show();
            }
        }
    }
}

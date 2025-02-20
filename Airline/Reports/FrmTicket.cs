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
    public partial class FrmTicket : Form
    {
        DataAccessLayer DAL = new DataAccessLayer();
        public FrmTicket()
        {
            InitializeComponent();
             Dt = new DataTable(); 
        }
        DataTable Dt; 
        private void select_Tickets()
        {
            // الاستعلام عن التذاكر بواسطة الاجراء
            #region select_Tickets
            DAL.Open();
            SqlDataAdapter Adapter = new SqlDataAdapter("select_Tickets", DAL.sqlconnection);
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
                    Dt.Rows[i].ItemArray[5].ToString(),
                    Dt.Rows[i].ItemArray[6].ToString(),
                };
                DGVTickt.Rows.Add(ob);
            }
            DAL.Close();
            #endregion
        }


        private void FrmTicket_Load(object sender, EventArgs e)
        {
            select_Tickets();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ticket T = new Ticket();
            T.Show();
            this.Close();
        }

        private void btnveiwTicket_Click(object sender, EventArgs e)
        {
            if (Dt.Rows.Count > 0)
            {

                FrmReportTicket FRT = new FrmReportTicket();
                FRT.InitFlightRPT(Dt);
                FRT.Show();
            }
        }
    }
}

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
using Airline.Reports;


namespace Airline
{
    public partial class FrmPassengers : Form
    {
        DataAccessLayer DAL = new DataAccessLayer();
        public FrmPassengers()
        {
            InitializeComponent();
            Dt = new DataTable();
        }
        DataTable Dt;

        private void Select_Passenger()
        {
            // الاستعلام عن المسافرين بواسطة الاجراء
            #region select_Passenger
            DAL.Open();
            SqlDataAdapter Adapter = new SqlDataAdapter("Get_Passenger", DAL.sqlconnection);
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
                    
                };
                DGVPassenger.Rows.Add(ob);
            }
            DAL.Close();
            #endregion
        }


        private void Save_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmPassengers_Load(object sender, EventArgs e)
        {
            Select_Passenger();
        }

        private void btnveiwPassenger_Click(object sender, EventArgs e)
        {
           
        }

        private void btnveiwPassenger_Click_1(object sender, EventArgs e)
        {
            if (Dt.Rows.Count > 0)
            {

                FrmReportPass FRP = new FrmReportPass();
                FRP.InitPassengerRPT(Dt);
                FRP.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ViewPassengercs vp = new ViewPassengercs();
            vp.Show();
            this.Close();
        }
    }
}

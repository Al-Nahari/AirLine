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

namespace Airline
{
    public partial class CancelTicket : Form
    {
        DataAccessLayer DAL = new DataAccessLayer();

        public CancelTicket()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Ticket T = new Ticket();
            this.Close();
            T.Show();
        }

        private void CancelTicket_Load(object sender, EventArgs e)
        {
            // تحميل البيانات المحذوفة 
            DAL.Open();
            SqlDataAdapter Adapter = new SqlDataAdapter("select * from Cancel_Ticket", DAL.sqlconnection);
            DataTable Dt = new DataTable();
            Adapter.Fill(Dt);
            DGV_CancelTicket.Rows.Clear();
            for (int i = 0; i < Dt.Rows.Count ; i++)
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
                    Dt.Rows[i].ItemArray[7].ToString(),
                  
                };
                DGV_CancelTicket.Rows.Add(ob);
            }
            DAL.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Ticket T = new Ticket();
            T.Show();
            this.Close();
        }
    }
}

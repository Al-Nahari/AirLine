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
    public partial class ViewFlight : Form
    {
        public ViewFlight()
        {
            InitializeComponent();
        }
        DataAccessLayer DAL = new DataAccessLayer();

        private void button2_Click(object sender, EventArgs e)
        {
            
            
            
        }

        private void ReseltF_Click(object sender, EventArgs e)
        {
            string id = this.DGVFlight.CurrentRow.Cells[0].Value.ToString();
             DAL.Delete_Flight(id);
            select_Flight();
        }

        private void RecordF_Click(object sender, EventArgs e)
        {
            txtFlightCode.Text = this.DGVFlight.CurrentRow.Cells[0].Value.ToString();
            CmboFlightSource.Text = this.DGVFlight.CurrentRow.Cells[1].Value.ToString();
            cmboFlightDestination.Text = this.DGVFlight.CurrentRow.Cells[2].Value.ToString();
            txtFlightTakeOfDate.Text = this.DGVFlight.CurrentRow.Cells[3].Value.ToString();
            txtFlightNumOfSeach.Text = this.DGVFlight.CurrentRow.Cells[4].Value.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            


        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void select_Flight()
        {
            // الاستعلام عن الرحلات بواسطة الاجراء
            #region select_Flight
            DAL.Open();
            SqlDataAdapter Adapter = new SqlDataAdapter("Get_Flight", DAL.sqlconnection);
            DataTable Dt = new DataTable();
            Adapter.Fill(Dt);
            DGVFlight.Rows.Clear();
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

        private void ViewFlight_Load(object sender, EventArgs e)
        {
            select_Flight();
        }

        private void AddFli_Click(object sender, EventArgs e)
        {
            
            try
            {
               
               
                DAL.ADD_Flight(txtFlightCode.Text, CmboFlightSource.Text, cmboFlightDestination.Text, txtFlightTakeOfDate.Text, Convert.ToInt32(txtFlightNumOfSeach.Text));

                select_Flight();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmFlight FF = new FrmFlight();
            FF.Show();
            this.Hide();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            DAL.Update_Flight(txtFlightCode.Text, CmboFlightSource.Text, cmboFlightDestination.Text, txtFlightTakeOfDate.Text, Convert.ToInt32(txtFlightNumOfSeach.Text));
            select_Flight();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            MainFlight MF = new MainFlight();
            MF.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MainFlight MF = new MainFlight();
            MF.Show();
            this.Close();
        }
    }
}

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
    public partial class ViewPassengercs : Form
    {
        public ViewPassengercs()
        {
            InitializeComponent();
        }
        DataAccessLayer DAL = new DataAccessLayer();
        private void ReseltF_Click(object sender, EventArgs e)
        {
            string NameP = this.DGVPassenger.CurrentRow.Cells[0].Value.ToString();
            DAL.Delete_Passenger(NameP);
            select_Passenger();
        }

        private void select_Passenger()
        {
            // الاستعلام عن المسافرين بواسطة الاجراء
            #region select_Passenger
            DAL.Open();
            SqlDataAdapter Adapter = new SqlDataAdapter("Get_Passenger", DAL.sqlconnection);
            DataTable Dt = new DataTable();
            Adapter.Fill(Dt);
            DGVPassenger.Rows.Clear();
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

        private void ViewPassengercs_Load(object sender, EventArgs e)
        {
            select_Passenger();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
           NamePassenger.Text = "";
           Passport.Text = "";
            Address.Text = "";
            Nationality.Text = "";   
            Gender.Text = "";
            Phone.Text = "";
        }

        private void RecordF_Click(object sender, EventArgs e)
        {
            
            NamePassenger.Text = DGVPassenger.CurrentRow.Cells[0].Value.ToString();
            Passport.Text = DGVPassenger.CurrentRow.Cells[1].Value.ToString();
            Address.Text = DGVPassenger.CurrentRow.Cells[2].Value.ToString();
            Nationality.Text = DGVPassenger.CurrentRow.Cells[3].Value.ToString();
            Gender.Text = DGVPassenger.CurrentRow.Cells[4].Value.ToString();
            Phone.Text = DGVPassenger.CurrentRow.Cells[5].Value.ToString();

        }


        private void DGVPassenger_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void DGVPassenger_Click(object sender, EventArgs e)
        {
           
        }

        private void IdPassenger_TextChanged(object sender, EventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {
            DAL.Open();
            DAL.Update_Pass(NamePassenger.Text , Passport.Text , Address.Text , Nationality.Text , Gender.Text , Phone.Text );
            DAL.Close();
            select_Passenger();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AddFli_Click(object sender, EventArgs e)
        {
            DAL.ADD_Pasenger( NamePassenger.Text , Passport.Text , Address.Text , Nationality.Text , Gender.Text , Phone.Text);
            select_Passenger();

        }

        private void label10_Click(object sender, EventArgs e)
        {
            MainFlight MF = new MainFlight();
            MF.Show();
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            FrmPassengers FP = new FrmPassengers();
            FP.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MainFlight MF = new MainFlight();
            MF.Show();
            this.Close();
        }
    }
}

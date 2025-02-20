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
    public partial class Ticket : Form
    {
        public Ticket()
        {
            InitializeComponent();
            
        }
        DataAccessLayer DAL = new DataAccessLayer();

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
            MainFlight MF = new MainFlight();
            MF.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void select_Tickets()
        {
         // الاستعلام عن التذاكر بواسطة الاجراء
            #region select_Tickets
            DAL.Open();
            SqlDataAdapter Adapter = new SqlDataAdapter("select_Tickets", DAL.sqlconnection);
            DataTable Dt = new DataTable();
            Adapter.Fill(Dt);
            DGVTickt.Rows.Clear();
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

        private void Ticket_Load(object sender, EventArgs e)
        {
            #region Get_All_Rows_Passenger_To_Combobox
            //   يجلب اسم المسافر لكي يختارها 
            DAL.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("Passenger_To_Ticket", DAL.sqlconnection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows.Count > i)
                {
                    object ob = new object();
                    ob = dt.Rows[i].ItemArray[0].ToString();  
                    cmboName.Items.Add(ob);
                }
                    
            }
            DAL.Close();
            #endregion

            #region Get_All_Rows_Flight_To_Combobox
            //   الرحلات لكي يختارها id يجلب
            DAL.Open();
            SqlDataAdapter adapter2 = new SqlDataAdapter("Flight_To_Ticket", DAL.sqlconnection);
            DataTable dt2 = new DataTable();
            adapter2.Fill(dt2);

            for (int j = 0; j < dt2.Rows.Count; j++)
            {
                if (dt2.Rows.Count > j)
                {
                    object ob2 = new object();
                    ob2 = dt2.Rows[j].ItemArray[0].ToString();
                   CmboFlightCode.Items.Add(ob2);
                }

            }
            DAL.Close();
            #endregion

            select_Tickets();

        }

        private void ReseltF_Click(object sender, EventArgs e)
        {



            //اخذ بيانات التذاكر المحذوفة و إضافتها إلى الجدول 
        

            int idT = Convert.ToInt32(DGVTickt.CurrentRow.Cells[0].Value.ToString());
            string CodeF =(DGVTickt.CurrentRow.Cells[1].Value.ToString());
            string PName = (DGVTickt.CurrentRow.Cells[2].Value.ToString());
            string PPassport = (DGVTickt.CurrentRow.Cells[3].Value.ToString());
            string FlightTo = (DGVTickt.CurrentRow.Cells[4].Value.ToString());
            int AmountT = Convert.ToInt32(DGVTickt.CurrentRow.Cells[5].Value.ToString());

            string DateC =  DateTime.Now.ToString();
            DAL.Add_CancelTicket( idT , CodeF , PName , PPassport , FlightTo , AmountT , DateC );

 // ثــم يحذف التذكرة بعد حفظ بياناتها

            // حذف التذكرة
            int id = Convert.ToInt32( this.DGVTickt.CurrentRow.Cells[0].Value.ToString());
            DAL.Delete_Tickets(id);
            select_Tickets();

        }

        private void AddFli_Click(object sender, EventArgs e)
        {
            try
            {
                DAL.ADD_Tickets(CmboFlightCode.Text, cmboName.Text, Convert.ToInt32(Amount.Text));
                select_Tickets();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //return;
            }
            
        }

        private void CmboFlightCode_SelectedIndexChanged(object sender, EventArgs e)
        {
                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CancelTicket CT = new CancelTicket();
            CT.Show();
            this.Hide();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
           
            
        }

        private void RecordF_Click(object sender, EventArgs e)
        {
            
            CmboFlightCode.Text = this.DGVTickt.CurrentRow.Cells[1].Value.ToString();
            cmboName.Text = this.DGVTickt.CurrentRow.Cells[2].Value.ToString();
            Amount.Text = this.DGVTickt.CurrentRow.Cells[3].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           //  التعامل مع ملف الطباعة كـ واجهة و تشغيلها بكامل الشاشة
            ((Form)printPreviewDialog1).WindowState = FormWindowState.Maximized;
            if(printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            #region items DGV_Tickt
            // العناصر المراد طباعتها في التذكرة
            string IdT       =" Code Tickt       "+ DGVTickt.CurrentRow.Cells[0].Value.ToString();
            string CodeF     = " Flight Code  :  " + DGVTickt.CurrentRow.Cells[1].Value.ToString();
            
            string NameP     = " Name         :  " + DGVTickt.CurrentRow.Cells[2].Value.ToString();
            string PassportP = " Passport     :  " + DGVTickt.CurrentRow.Cells[3].Value.ToString();
            string FlightTo  = " Flight To    :  " + DGVTickt.CurrentRow.Cells[4].Value.ToString();
            string AmountT   = " Amount       :  " + DGVTickt.CurrentRow.Cells[5].Value.ToString();
            string FlightDate =  DGVTickt.CurrentRow.Cells[6].Value.ToString();
            #endregion

            #region FontSize Items

            // متغيرات نوع الخط للعناصر
            Font F = new Font("Arial", 13, FontStyle.Bold);       
            Font F2 = new Font("Arial", 20, FontStyle.Bold);
            #endregion

            #region Graphics 
            //(Document)الرسم في الـ

            e.Graphics.FillRectangle(Brushes.Blue, 0, 0, e.PageBounds.Width, 38);
            e.Graphics.DrawString("F l i g h t       T i c k e t  " , F2 , Brushes.White , 40 , 6 );
            e.Graphics.DrawImage(Properties.Resources.up11, 350 ,0 , 40 ,40);
            e.Graphics.DrawImage(Properties.Resources.line, 50 , 30 , 150 , 150);

         // موقعة   ,   لون النص , حجم ونوع النص ,  النص ) إسقاط عنصر من نوع نص  )
            e.Graphics.DrawString(IdT      ,     F           , Brushes.Red, 160 , 45);

            e.Graphics.DrawString(CodeF, F, Brushes.Black ,  10 , 65);
            e.Graphics.DrawString(NameP, F, Brushes.Black ,  250  ,  65);

            e.Graphics.DrawString(PassportP, F, Brushes.Black, 10 ,95 );
            e.Graphics.DrawString(FlightTo, F, Brushes.Black, 250 ,95 );

            e.Graphics.DrawString(AmountT, F, Brushes.Black,10 ,125 );
            e.Graphics.DrawString(FlightDate, F, Brushes.Black, 250, 125 );
            

            e.Graphics.FillRectangle(Brushes.Blue, 0, 180, e.PageBounds.Width,38 );

            #endregion

            #region Boarding pass
            // رسم على يمين التذكرة

            //  ( Boarding pass ) اولآ __  رسم خط يقسم التذكرة ليكن فية 
            Point p1 = new Point( 590, 0);
            Point p2 = new Point(590, 218);
            e.Graphics.DrawLine(Pens.Red, p1, p2);

            // متغيرات نوع الخط للعناصر
            Font F1 = new Font("Arial", 14, FontStyle.Bold);
            Font F0 = new Font("Arial", 10, FontStyle.Bold);

            // ثم إضافة نفس البيانات ليتم الاحتفاظ بها
            e.Graphics.DrawString("Boarding pass", F1, Brushes.White, 620 , 6);

            e.Graphics.DrawString(IdT, F0, Brushes.Red, 620, 40);

            e.Graphics.DrawString(CodeF, F0, Brushes.Black, 600, 60);
            e.Graphics.DrawString(NameP, F0, Brushes.Black, 600, 75);

            e.Graphics.DrawString(PassportP, F0, Brushes.Black, 600, 90);
            e.Graphics.DrawString(FlightTo, F0, Brushes.Black, 600, 105);

            e.Graphics.DrawString(AmountT, F0, Brushes.Black, 600, 120);
            e.Graphics.DrawString(FlightDate, F0, Brushes.Black, 600, 135);
            #endregion


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FrmTicket FT = new FrmTicket();
            FT.Show();
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

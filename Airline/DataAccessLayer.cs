using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Airline
{
    class DataAccessLayer
    {
        #region ConnectionSQl
        public SqlConnection sqlconnection;

        //مكتبة لأستنساخ الاتصال 
        public DataAccessLayer()
        {
            sqlconnection = new SqlConnection(@"Data Source = MOHAMMEDAREF; Initial Catalog = AirlineDB ; Integrated Security = True");
        }

        // لفتح الاتصال
        public void Open()
        {
            if (sqlconnection.State != System.Data.ConnectionState.Open)
            {
                sqlconnection.Open();
            }
        }

        // لأغلاق الاتصال 
        public void Close()
        {
            if (sqlconnection.State != System.Data.ConnectionState.Closed)
            {
                sqlconnection.Close();
            }
        }
        #endregion

        #region Select All
        //دالة القراءة لجميع الواجهات
        public DataTable GET_Data(string pro)
        {
            DataAccessLayer DAL = new DataAccessLayer();

            DAL.Open();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData(pro, null);
            return Dt;
            // DAL.close();
        }
        #endregion

        #region Read Data for SQL
        // دالة لقراءة البيانات من قاعدة البيانات
        public DataTable SelectData(string stored_procedure, SqlParameter[] param)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = stored_procedure;
            sqlcmd.Connection = sqlconnection;

            if (param != null)
            {
                for (int i = 0; i < param.Length; i++)
                {
                    sqlcmd.Parameters.Add(param[i]);
                }
            }

            SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
            // dataadapter مكلف بتنفيذ ال sqlcmd
            // dataadapter ثم يضع النتيجة في ال
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        #endregion

        #region ExecuteCommand for stored_procedure
        // دالة لأدخال البيانات و تحديثها في قاعدة البيانات
        public void ExecuteCommand(string stored_procedure, SqlParameter[] param)
        {
            Open();
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = stored_procedure;
            sqlcmd.Connection = sqlconnection;


            if (param != null)
            {
                sqlcmd.Parameters.AddRange(param);
            }

            sqlcmd.ExecuteNonQuery();

        }
        #endregion

//--------------------------------
        #region Update_Flight
        //  دالة التعديل للرحلات
        public void Update_Flight(string Flight_Code, string Flight_Source, string Flight_Destination, string Flight_TakeOfDate, int @Flight_NumOfSeach)
        {
            DataAccessLayer DAL = new DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@Flight_Code", SqlDbType.NVarChar, 50);
            param[0].Value = Flight_Code;

            param[1] = new SqlParameter("@Flight_Source", SqlDbType.NVarChar, 50);
            param[1].Value = Flight_Source;

            param[2] = new SqlParameter("@Flight_Destination", SqlDbType.NVarChar, 50);
            param[2].Value = Flight_Destination;

            param[3] = new SqlParameter("@Flight_TakeOfDate", SqlDbType.NVarChar, 50);
            param[3].Value = Flight_TakeOfDate;

            param[4] = new SqlParameter("@Flight_NumOfSeach", SqlDbType.Int);
            param[4].Value = @Flight_NumOfSeach;

            DAL.Open();
            DAL.ExecuteCommand("Update_Flight", param);
            //  DAL.Close();
        }
        #endregion

        #region ADD_Flight
        public void ADD_Flight(string Flight_Code, string Flight_Source, string Flight_Destination, string Flight_TakeOfDate, int Flight_NumOfSeach)
        {
         // دالة إضافة رحلة

            DataAccessLayer DAL = new DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@Flight_Code", SqlDbType.NVarChar, 50);
            param[0].Value =  Flight_Code;

            param[1] = new SqlParameter("@Flight_Source", SqlDbType.NVarChar, 50);
            param[1].Value = Flight_Source;

            param[2] = new SqlParameter("@Flight_Destination", SqlDbType.NVarChar, 50);
            param[2].Value = Flight_Destination;

            param[3] = new SqlParameter("@Flight_TakeOfDate", SqlDbType.NVarChar, 50);
            param[3].Value = Flight_TakeOfDate;

            param[4] = new SqlParameter("@Flight_NumOfSeach", SqlDbType.Int);
            param[4].Value = Flight_NumOfSeach;
            DAL.Open();
            DAL.ExecuteCommand("Add_Flight", param);
            //  DAL.Close();
        }
        #endregion

        #region Delete_Flight
        // دالة الحذف للرحلات
        public void Delete_Flight(string Flight_Code)
        {
            DataAccessLayer DAL = new DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Flight_Code",SqlDbType.NVarChar , 50 );
            param[0].Value = Flight_Code;
            DAL.ExecuteCommand("Delete_Flight", param);
            DAL.Close();
        }
        #endregion

//---------------------------------

        #region ADD_Pasenger
        public void ADD_Pasenger( string passenger_Name, string passenger_passport, string Passenger_Address, string passenger_Nationality ,string passenger_Gender , string passenger_phone)
        {
            // دالة إضافة مسافر

            DataAccessLayer DAL = new DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[6];
           
            param[0] = new SqlParameter("@passenger_Name", SqlDbType.NVarChar, 50);
            param[0].Value = passenger_Name;

            param[1] = new SqlParameter("@passenger_passport", SqlDbType.NVarChar, 50);
            param[1].Value = @passenger_passport;

            param[2] = new SqlParameter("@Passenger_Address", SqlDbType.NVarChar, 50);
            param[2].Value = Passenger_Address;

            param[3] = new SqlParameter("@passenger_Nationality", SqlDbType.NVarChar , 50);
            param[3].Value = passenger_Nationality;

            param[4] = new SqlParameter("@passenger_Gender", SqlDbType.NVarChar, 50);
            param[4].Value = passenger_Gender;

            param[5] = new SqlParameter("@passenger_phone", SqlDbType.NVarChar, 50);
            param[5].Value = passenger_phone;

            DAL.Open();
            DAL.ExecuteCommand("Add_Pasenger", param);
            //  DAL.Close();
        }
        #endregion

        #region Update_Passenger
        //  دالة التعديل للمسافرين
        public void Update_Pass(string passenger_Name, string passenger_passport, string Passenger_Address, string passenger_Nationality, string passenger_Gender, string passenger_phone)
        {
            DataAccessLayer DAL = new DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@passenger_Name", SqlDbType.NVarChar, 50);
            param[0].Value = passenger_Name;

            param[1] = new SqlParameter("@passenger_passport", SqlDbType.NVarChar, 50);
            param[1].Value = passenger_passport;

            param[2] = new SqlParameter("@Passenger_Address", SqlDbType.NVarChar, 50);
            param[2].Value = Passenger_Address;

            param[3] = new SqlParameter("@passenger_Nationality", SqlDbType.NVarChar, 50);
            param[3].Value = passenger_Nationality;

            param[4] = new SqlParameter("@passenger_Gender", SqlDbType.NVarChar, 50);
            param[4].Value = passenger_Gender;

            param[5] = new SqlParameter("@passenger_phone", SqlDbType.NVarChar,50);
            param[5].Value = passenger_phone;


            DAL.Open();
            DAL.ExecuteCommand("Update_Passenger", param);
            //  DAL.Close();
        }
        #endregion

        #region Delete_Flight
        // دالة الحذف للرحلات
        public void Delete_Passenger(string passenger_Name)
        {
            DataAccessLayer DAL = new DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@passenger_Name", SqlDbType.NVarChar , 50);
            param[0].Value = passenger_Name;
            DAL.ExecuteCommand("Delete_Passenger", param);
            DAL.Close();
        }
        #endregion


 //---------------------------------

        #region ADD_Tickets
        public void ADD_Tickets( string Flight_Code,string passenger_Name, int Amount)
        {
            // دالة إضافة تذكرة

            DataAccessLayer DAL = new DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[3];

            param[0] = new SqlParameter("@Flight_Code", SqlDbType.NVarChar, 50);
            param[0].Value = Flight_Code;

            param[1] = new SqlParameter("@passenger_Name", SqlDbType.NVarChar , 50);
            param[1].Value = passenger_Name;

            param[2] = new SqlParameter("@Amount", SqlDbType.Int);
            param[2].Value = Amount;

            DAL.Open();
            DAL.ExecuteCommand("ADD_Tickets", param);
            //  DAL.Close();
        }
        #endregion

        #region Delete_Tickets
        // دالة الحذف للتذاكر
        public void Delete_Tickets(int Ticket_Id)
        {
            DataAccessLayer DAL = new DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Ticket_Id", SqlDbType.Int);
            param[0].Value = Ticket_Id;
            DAL.ExecuteCommand("Delete_Tickets", param);
            DAL.Close();
        }
        #endregion




        #region Add_CancelTicket
        public void Add_CancelTicket( int Ticket_Id, string Flight_Code,  string Passenger_Name , string @Passenger_Passport , string Flight_To , int Amount_Ticjet , string Data_Cancel)
        {
            // دالة إضافة التذاكر المحذوفة

            DataAccessLayer DAL = new DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[7];
           

            param[0] = new SqlParameter("@Ticket_Id", SqlDbType.Int);
            param[0].Value = Ticket_Id;

            param[1] = new SqlParameter("@Flight_Code", SqlDbType.NVarChar , 50);
            param[1].Value = Flight_Code;

            param[2] = new SqlParameter("@Passenger_Name", SqlDbType.NVarChar, 50);
            param[2].Value = Passenger_Name;

            param[3] = new SqlParameter("@Passenger_Passport", SqlDbType.NVarChar, 50);
            param[3].Value = Passenger_Passport;

            param[4] = new SqlParameter("@Flight_To", SqlDbType.NVarChar, 50);
            param[4].Value = Flight_To;

            param[5] = new SqlParameter("@Amount_Ticjet", SqlDbType.Int);
            param[5].Value = Amount_Ticjet;

            param[6] = new SqlParameter("@Data_Cancel", SqlDbType.NVarChar, 50);
            param[6].Value = Data_Cancel;

            DAL.Open();
            DAL.ExecuteCommand("Add_CancelTicket", param);
            //  DAL.Close();
        }
        #endregion


    }
}

using Project_SCD.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace Project_SCD.DL
{
    class RegistrationDL
    {
        private DB_Connection dB_Connection;
        private RegistrationDTO registrationDTO;
        public RegistrationDL()
        {
            dB_Connection = new DB_Connection();
        }
        public void InputIntoDB(RegistrationDTO registrationDTO)
        {
            try
            {
                dB_Connection.Con.Open();
                string queryString1 = "INSERT INTO customer VALUES(@roomid, @cname , @mobile, @nationality, @gender, @idproof);";

                SqlCommand com = new SqlCommand(queryString1, dB_Connection.Con);
                com.Parameters.AddWithValue("@roomid", registrationDTO.Roomno);
                com.Parameters.AddWithValue("@cname", registrationDTO.Name);
                com.Parameters.AddWithValue("@mobile", registrationDTO.Mobile);
                com.Parameters.AddWithValue("@nationality", registrationDTO.Nationality);
                com.Parameters.AddWithValue("@gender", registrationDTO.Gender);
                com.Parameters.AddWithValue("@idproof", registrationDTO.Idproof);

                int rowAffected = com.ExecuteNonQuery();
                MessageBox.Show("Added");
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dB_Connection.Con.Close();
            }

        }
        public DataTable GetAvailableRoomNo()
        {
            DataTable dt = new DataTable();
            try
            {
                dB_Connection.Con.Open();
                string queryString = "SELECT * from room where booked=@booked";
                SqlCommand com = new SqlCommand(queryString, dB_Connection.Con);
                com.Parameters.AddWithValue("@booked", "Available");
                SqlDataReader reader = com.ExecuteReader();
                dt.Load(reader);
                
                return dt;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                dB_Connection.Con.Close();
            }
        }
    }
    
}

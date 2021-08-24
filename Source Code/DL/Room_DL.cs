using Project_SCD.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace Project_SCD.DL
{
    class Room_DL
    {
        private DB_Connection dB_Connection;
        private Room_DTO room_DTO;
        public Room_DL()
        {
            dB_Connection = new DB_Connection();
        }
        public void add_room_to_db(Room_DTO room_DTO)
        {
            try
            {
                dB_Connection.Con.Open();
                string queryString1 = "INSERT INTO room VALUES(@roomno, @roomtype , @bed, @price, @booked);";

                SqlCommand com = new SqlCommand(queryString1, dB_Connection.Con);
                com.Parameters.AddWithValue("@roomno", room_DTO.Roomno);
                com.Parameters.AddWithValue("@roomtype", room_DTO.Roomtype);
                com.Parameters.AddWithValue("@bed", room_DTO.Bed);
                com.Parameters.AddWithValue("@price", room_DTO.Price);
                com.Parameters.AddWithValue("@booked", room_DTO.Booked);

                int rowAffected = com.ExecuteNonQuery();
                MessageBox.Show("Added");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dB_Connection.Con.Close();
            }
        }
    }
}

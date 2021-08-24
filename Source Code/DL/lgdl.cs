using Project_SCD.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace Project_SCD.DL
{
    class lgdl
    {
        DB_Connection dbCon;
        public lgdl()
        {
            dbCon = new DB_Connection();
        }
        public LoginDTO check_user_from_DB(LoginDTO lg)
        {
             LoginDTO retDTO = new LoginDTO();
             try
             {
                
                 dbCon.Con.Open();

                //string queryString = "SELECT * FROM user WHERE username=@username AND password =@password";
                string queryString = "SELECT * FROM myUser WHERE username=@username AND password=@password;";
                SqlCommand com = new SqlCommand(queryString, dbCon.Con);
                com.Parameters.AddWithValue("@username", lg.Username);
                com.Parameters.AddWithValue("@password", lg.Password);
                SqlDataReader reader = com.ExecuteReader();
                
                
                 while(reader.Read())
                 {
      
                    retDTO.Username = reader["username"].ToString();
                    retDTO.Password = reader["password"].ToString();
                    retDTO.Role = reader["role"].ToString();
                    
                    return retDTO;
                 }
                
             }catch(SqlException ex)
             {
                MessageBox.Show(ex.Message);
                return null;
             }finally
            {
                dbCon.Con.Close();
            }
            return null;
      
        }
    }
}

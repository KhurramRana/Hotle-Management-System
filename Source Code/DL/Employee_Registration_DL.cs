using Project_SCD.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace Project_SCD.DL
{
    class Employee_Registration_DL
    {

        private DB_Connection dB_Connection;
        private Employee_Registraion_DTO employee_Registration_DTO;
        public Employee_Registration_DL()
        {
            dB_Connection = new DB_Connection();
        }
        public void input_employee_to_DB(Employee_Registraion_DTO employee_Registraion_DTO)
        {
            try
            {
                dB_Connection.Con.Open();
                string queryString2 = "INSERT INTO myuser values(@username, @password, @role);";

                SqlCommand com = new SqlCommand(queryString2, dB_Connection.Con);
                com.Parameters.AddWithValue("@username", employee_Registraion_DTO.Username);
                com.Parameters.AddWithValue("@password", employee_Registraion_DTO.Password);
                com.Parameters.AddWithValue("@role", "employee");
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
        
        public void delete_employee_from_DB(string str)
        {
            try
            {
                dB_Connection.Con.Open();
                string queryString2 = "DELETE FROM myuser WHERE username='@username'";

                SqlCommand com = new SqlCommand(queryString2, dB_Connection.Con);
                com.Parameters.AddWithValue("@username", str);
                int rowAffected = com.ExecuteNonQuery();
                MessageBox.Show("Deleted");
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

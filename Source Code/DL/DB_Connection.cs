using DocumentFormat.OpenXml.Spreadsheet;
using java.awt;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Project_SCD.DL
{
    class DB_Connection
    {
        private SqlConnection con;
        public DB_Connection()
        {
            //Create object of SQL connection and pass con string to it 
            //string conString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = C:\\Users\\Dell\\Desktop\\Project SCD\\Database1.mdf; Integrated Security = True";
            string Path = Environment.CurrentDirectory;
            string[] appPath = Path.Split(new string[] { "bin" }, StringSplitOptions.None);
            AppDomain.CurrentDomain.SetData("DataDirectory", appPath[0]);
            string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + appPath[0] + @"Database1.mdf;Integrated Security=True";

            con = new SqlConnection(conString);
        }

        public SqlConnection Con { get => con;  }
    }
}
 
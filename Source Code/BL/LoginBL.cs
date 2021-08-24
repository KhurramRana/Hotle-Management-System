using Project_SCD.DL;
using Project_SCD.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Project_SCD.BL
{
    class LoginBL
    {
        private lgdl LGDL;
        public LoginBL()
        {
            LGDL = new lgdl();
        }
       
        public Form Checkuser(LoginDTO lg)
        {

            LoginDTO login = LGDL.check_user_from_DB(lg);
            if (login == null)
            {
                return new WrongUserGUI();
            }
            if (login.Role == "admin")
            {
                return new Register_Employee_GUI();
            }
            
            else if (login.Role == "employee")
            {
                return new DashboardGUI(login);
            }
            else
            {
                return new WrongUserGUI();
            }
            
        }
    }
}
/*
          if (lg.Username.Equals("admin") && lg.Password.Equals("admin"))
              return true;
          return false;*/
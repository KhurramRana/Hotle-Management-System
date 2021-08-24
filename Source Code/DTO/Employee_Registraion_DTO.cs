using System;
using System.Collections.Generic;
using System.Text;

namespace Project_SCD.DTO
{
    class Employee_Registraion_DTO
    {
        private string _username;
        private string _password;
        private string _retypepassword;
        public Employee_Registraion_DTO()
        {

        }

        public string Username { get => _username; set => _username = value; }
        public string Password { get => _password; set => _password = value; }
        public string Retypepassword { get => _retypepassword; set => _retypepassword = value; }
    }
}

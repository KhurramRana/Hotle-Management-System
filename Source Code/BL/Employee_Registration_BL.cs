using Project_SCD.DL;
using Project_SCD.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project_SCD.BL
{
    class Employee_Registration_BL
    {
        private Employee_Registration_DL employee_Registration_DL;
        public Employee_Registration_BL()
        {
            employee_Registration_DL = new Employee_Registration_DL();
        }
        public void inputemployeeIntoDL(Employee_Registraion_DTO employee_Registraion_DTO)
        {
            employee_Registration_DL.input_employee_to_DB(employee_Registraion_DTO);
        }
        public void delete_employee_BL(string str)
        {
            employee_Registration_DL.delete_employee_from_DB(str);
        }
    }
}

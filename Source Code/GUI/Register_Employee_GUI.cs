using Project_SCD.BL;
using Project_SCD.DL;
using Project_SCD.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Project_SCD
{
    public partial class Register_Employee_GUI : Form
    {
        private Employee_Registraion_DTO employee_Registraion_DTO;
        private Employee_Registration_BL employee_Registraion_BL;
        private Employee_Registration_DL employee_Registraion_DL;

        public Register_Employee_GUI()
        {
            InitializeComponent();          
            employee_Registraion_DTO = new Employee_Registraion_DTO();
            employee_Registraion_BL = new Employee_Registration_BL();
            employee_Registraion_DL = new Employee_Registration_DL();
            
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            employee_Registraion_DTO.Username = txt_username_employee.Text;
            employee_Registraion_DTO.Password = txt_pass_eployee.Text;
            employee_Registraion_BL.inputemployeeIntoDL(employee_Registraion_DTO);
            combo_delete_emp.Items.Add(txt_username_employee.Text);
        }

        private void btn_delete_empl_Click(object sender, EventArgs e)
        {
            employee_Registraion_BL.delete_employee_BL(combo_delete_emp.Text);
        }

        private void Register_Employee_GUI_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginGUI main = new LoginGUI();
            main.Show();
            this.Hide();
        }
    }
}

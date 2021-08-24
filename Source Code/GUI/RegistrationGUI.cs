using Project_SCD.BL;
using Project_SCD.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Project_SCD
{
    public partial class RegistrationGUI : Form
    {
        private RegistrationDTO registrationDTO;
        private RegistrationBL registrationBL;
        public RegistrationGUI()
        {
            InitializeComponent();
            registrationDTO = new RegistrationDTO();
            registrationBL = new RegistrationBL();
            populate();
        }

        private void btn_allot_Click(object sender, EventArgs e)
        {
            registrationDTO.Name = txt_custname.Text;
            registrationDTO.Mobile = txt_mobile.Text;
            registrationDTO.Idproof = txt_idproof.Text;
            registrationDTO.Nationality = txt_nationality.Text;
            registrationDTO.Gender = txt_gender.Text;
            registrationDTO.CheckIn_day = Int32.Parse(txt_CheckIN_day.Text);
            registrationDTO.CheckIn_month = Int32.Parse(txt_CheckIN_month.Text);
            registrationDTO.CheckIn_year = Int32.Parse(txt_CheckIN_year.Text);
            registrationBL.inputIntoDL(registrationDTO);
            
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            DashboardGUI dashboardGUI = new DashboardGUI();
            dashboardGUI.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        public void populate()
        {
            try
            {
                dataGridView1.DataSource = registrationBL.GetPendingRequests();
              

            }
            catch (SqlException ex)
            {
                MessageBox.Show("No pending requests");
            }

        }
        

        private void RegistrationGUI_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            registrationDTO.Roomno  = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            
        }

        private void RegistrationGUI_FormClosed(object sender, FormClosedEventArgs e)
        {
            DashboardGUI main = new DashboardGUI();
            main.Show();
            this.Hide();
        }
    }
}

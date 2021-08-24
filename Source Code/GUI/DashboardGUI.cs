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
    public partial class DashboardGUI : Form
    {
        private LoginDTO loginDTO;
        public DashboardGUI()
        {
            InitializeComponent();
        }
        public DashboardGUI(LoginDTO login)
        {
            InitializeComponent();
            loginDTO = new LoginDTO();
            loginDTO = login;
        }

        private void btn_customer_registration_Click(object sender, EventArgs e)
        {
             RegistrationGUI registrationGUI = new RegistrationGUI();
             registrationGUI.Show();
            
        }

        private void btn_payment_Click(object sender, EventArgs e)
        {
            PaymentGUI paymentGUI =  new PaymentGUI();
            paymentGUI.Show();
            
        }

        private void btn_room_Click(object sender, EventArgs e)
        {
            RoomGUI roomGUI = new RoomGUI();
            roomGUI.Show();
            
        }

        private void DashboardGUI_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginGUI main = new LoginGUI();
            main.Show();
            this.Hide();
        }
    }
}

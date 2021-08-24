using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Project_SCD
{
    public partial class PaymentGUI : Form
    {
        public PaymentGUI()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            DashboardGUI dashboardGUI = new DashboardGUI();
            dashboardGUI.Show();
        }

        private void PaymentGUI_FormClosed(object sender, FormClosedEventArgs e)
        {
            DashboardGUI main = new DashboardGUI();
            main.Show();
            this.Hide();
        }
    }
}

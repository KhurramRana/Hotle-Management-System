using Project_SCD.BL;
using Project_SCD.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_SCD
{
    public partial class LoginGUI : Form
    {
        private LoginDTO logindto;
        private LoginBL lgbl;
        public LoginGUI()
        {
            InitializeComponent();
            logindto = new LoginDTO();
            lgbl = new LoginBL();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (!(txt_username.Text == "" || txt_password.Text == ""))
            {
                logindto.Username = txt_username.Text;
                logindto.Password = txt_password.Text;
                lgbl.Checkuser(logindto).Show();
                this.Hide();
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_username.Clear();
            txt_password.Clear();
            txt_username.Focus();
        }
    }
}

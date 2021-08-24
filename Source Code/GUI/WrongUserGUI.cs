using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Project_SCD
{
    public partial class WrongUserGUI : Form
    {
        public WrongUserGUI()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginGUI main = new LoginGUI();
            main.Show();
            this.Hide();
        }
    }
}

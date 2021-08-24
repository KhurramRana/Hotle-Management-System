using Project_SCD.BL;
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
    public partial class RoomGUI : Form
    {
        private Room_BL roomBL;
        private Room_DTO room_DTO;

        public RoomGUI()
        {
            InitializeComponent();
            roomBL = new Room_BL();
            room_DTO = new Room_DTO();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            DashboardGUI dashboardGUI = new DashboardGUI();
            dashboardGUI.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_addroom_Click(object sender, EventArgs e)
        {
            room_DTO.Roomno = txt_roomno.Text;
            room_DTO.Bed = txt_bed.Text;
            room_DTO.Roomtype = combo_roomtype.Text;
            room_DTO.Price = txt_room_price.Text;
            room_DTO.Booked = txt_roomStatus.Text;
            roomBL.add_room(room_DTO);

        }

        private void RoomGUI_FormClosed(object sender, FormClosedEventArgs e)
        {
            DashboardGUI main = new DashboardGUI();
            main.Show();
            this.Hide();
        }
    }
}

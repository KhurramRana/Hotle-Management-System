using System;
using System.Collections.Generic;
using System.Text;

namespace Project_SCD.DTO
{
    class Room_DTO
    {
        private string _roomno;
        private string _bed;
        private string _roomtype;
        private string _price;
        private string _booked;
        public Room_DTO()
        {

        }

        public string Roomno { get => _roomno; set => _roomno = value; }
        public string Bed { get => _bed; set => _bed = value; }
        public string Roomtype { get => _roomtype; set => _roomtype = value; }
        public string Price { get => _price; set => _price = value; }
        public string Booked { get => _booked; set => _booked = value; }
    }
}

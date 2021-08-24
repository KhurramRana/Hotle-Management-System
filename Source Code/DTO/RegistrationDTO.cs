using System;
using System.Collections.Generic;
using System.Text;

namespace Project_SCD.DTO
{
    class RegistrationDTO
    {
        private string _name;
        private string _roomid;
        private string _mobile;
        private string _nationality;
        private string _gender;
        private string _idproof;
        private int _checkIn_day;
        private int _checkIn_month;
        private int _checkIn_year;
        private string _roomno;
        private string _roomtype;
        private string _bed;
        private int _price;
        private string _booked;


        public RegistrationDTO()
        {

        }

        public string Name { get => _name; set => _name = value; }
        public string Roomid { get => _roomid; set => _roomid = value; }
        public string Mobile { get => _mobile; set => _mobile = value; }
        public string Nationality { get => _nationality; set => _nationality = value; }
        public string Gender { get => _gender; set => _gender = value; }
        public string Idproof { get => _idproof; set => _idproof = value; }
        public int CheckIn_day { get => _checkIn_day; set => _checkIn_day = value; }
        public int CheckIn_month { get => _checkIn_month; set => _checkIn_month = value; }
        public int CheckIn_year { get => _checkIn_year; set => _checkIn_year = value; }
        public string Roomno { get => _roomno; set => _roomno = value; }
        public string Roomtype { get => _roomtype; set => _roomtype = value; }
        public string Bed { get => _bed; set => _bed = value; }
        public int Price { get => _price; set => _price = value; }
        public string Booked { get => _booked; set => _booked = value; }
    }
}

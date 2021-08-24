using Project_SCD.DL;
using Project_SCD.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project_SCD.BL
{
    class Room_BL
    {
        private Room_DL room_DL;
        public Room_BL()
        {
            room_DL = new Room_DL();
        }
        public void add_room(Room_DTO room_dto)
        {
            room_DL.add_room_to_db(room_dto);

        }

    }
}

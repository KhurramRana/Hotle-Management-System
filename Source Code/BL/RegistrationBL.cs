using Project_SCD.DL;
using Project_SCD.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Project_SCD.BL
{
    class RegistrationBL
    {
        private RegistrationDL registrationDL;
        public RegistrationBL()
        {
            registrationDL = new RegistrationDL();
        }
        public void inputIntoDL(RegistrationDTO registrationDTO)
        {
            registrationDL.InputIntoDB(registrationDTO);
        }
        public DataTable GetPendingRequests()
        {
            return registrationDL.GetAvailableRoomNo();
        }
    }
}

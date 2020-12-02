using Entities.ObjectInterFaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Database
{
    static class RealtorFactory
    {
        public static IRealtor CreateRealtor(IRealtor Realtor = null)
        {

            if (Realtor is Database.Realtor) 
            {
                return new Entities.Realtor(Realtor.RealtorID, Realtor.Name, Realtor.PhoneNR, Realtor.Case);
            }
            if (Realtor is Entities.Realtor)
            {
                return new Database.Realtor(Realtor.RealtorID, Realtor.Name, Realtor.PhoneNR, Realtor.Case);
            }
            else 
            {
                return new Entities.Realtor();
            }

        }

    }
}

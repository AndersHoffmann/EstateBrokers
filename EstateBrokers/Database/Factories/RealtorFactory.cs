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

            }
            if (Realtor is Entities.Realtor)
            {

            }
            if (Realtor is null)
            {

            }

        }

    }
}

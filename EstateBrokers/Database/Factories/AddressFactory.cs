using Entities.ObjectInterFaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Database
{
    static class AddressFactory
    {
        public static IAddress CreateAddress(IAddress Address = null)
        {

            if (Address is Database.Address) 
            {
                return new Entities.Address(Address.PostalCode, Address.AddressLine1, Address.AddressLine2, Address.ExteriorArea, Address.InteriorArea, Address.BuildYear);
            }
            if (Address is Entities.Address)
            {
                return new Database.Address(Address.PostalCode, Address.AddressLine1, Address.AddressLine2, Address.ExteriorArea, Address.InteriorArea, Address.BuildYear);
            }
            if (Address is null)
            {
                return new Entities.Address();
            }

        }

    }
}

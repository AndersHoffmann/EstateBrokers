using Database;
using Entities;
using Gateways;
using System;
using System.Collections.Generic;
using System.Text;

namespace UseCases
{
    class AddressCRUD : IAddressCRUD
    { 
        public void Create(int postalCode, string addressLine1, string addressLine2, double ownershipCost, int exteriorArea, int interiorArea, int buildYear)
        {
            var database = new EstateBrokerContext();

            var address = new Database.Address();
            {
                address.PostalCode = postalCode;
                address.AddressLine1 = addressLine1;
                address.AddressLine2 = addressLine2;
                address.OwnershipCost = ownershipCost;
                address.ExteriorArea = exteriorArea;
                address.InteriorArea = interiorArea;
                address.BuildYear = buildYear;
            };

            database.Addresses.Add(address);
            database.SaveChanges();
        }
        public Address Read(int postalCode, string addressLine1)
        {

        }
        public void Update(int postalCode, string addressLine1, string addressLine2, double ownershipCost, int exteriorArea, int interiorArea, int buildYear)
        {
            using (var database = new EstateBrokerContext())
            {
                Address address = database.Addresses.Find(postalCode,addressLine1); 
                address.PostalCode = postalCode;
                address.AddressLine1 = addressLine1;
                address.AddressLine2 = addressLine2;
                address.OwnershipCost = ownershipCost;
                address.ExteriorArea = exteriorArea;
                address.InteriorArea = interiorArea;
                address.BuildYear = buildYear;
            }
        }
        public void Delete(int postalCode, string addressLine1))
        {

        }

    }
}

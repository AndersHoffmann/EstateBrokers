﻿using Database;
using Gateways;

namespace UseCases
{
    class AddressCRUD : IAddressCRUD
    { 
        public void CreateAddress(int postalCode, string addressLine1, string addressLine2, double ownershipCost, int exteriorArea, int interiorArea, int buildYear)
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
        }
        public Entities.Address ReadAddress(int postalCode, string addressLine1)
        {
            using (var database = new EstateBrokerContext())
            {
                return database.Addresses.Find(postalCode, addressLine1);
             
            }
        }
        public void UpdateAddress(int postalCode, string addressLine1, string addressLine2, double ownershipCost, int exteriorArea, int interiorArea, int buildYear)
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
                database.SaveChanges();
            }
        }
        public void DeleteAddress(int postalCode, string addressLine1)
        {
            using (var database = new EstateBrokerContext())
            {
                Address address = database.Addresses.Find(postalCode, addressLine1);
                database.Addresses.Remove(address);
                database.SaveChanges();
            }
        }

    }
}
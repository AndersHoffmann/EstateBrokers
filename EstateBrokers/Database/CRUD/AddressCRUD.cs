using Database;
using Gateways;

namespace UseCases
{
    public class AddressCRUD : IAddressCRUD
    { 
        public int CreateAddress(int postalCode, string addressLine1, string addressLine2, double ownershipCost, int exteriorArea, int interiorArea, int buildYear)
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
            return address.PostalCode;
        }
        public Entities.Address ReadAddress(int postalCode, string addressLine1)
        {
            using (var database = new EstateBrokerContext())
            {
                return (Entities.Address)AddressFactory.CreateAddress(database.Addresses.Find(postalCode, addressLine1));
             
            }
        }
        public bool UpdateAddress(int postalCode, string addressLine1, string addressLine2, double ownershipCost, int exteriorArea, int interiorArea, int buildYear)
        {
            try
            {
                using (var database = new EstateBrokerContext())
                {
                    Address address = database.Addresses.Find(postalCode, addressLine1);
                    address.PostalCode = postalCode;
                    address.AddressLine1 = addressLine1;
                    address.AddressLine2 = addressLine2;
                    address.OwnershipCost = ownershipCost;
                    address.ExteriorArea = exteriorArea;
                    address.InteriorArea = interiorArea;
                    address.BuildYear = buildYear;
                    database.SaveChanges();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
            
        public void DeleteAddress(int postalCode, string addressLine1)
        {
            using (var database = new EstateBrokerContext())
            {
                database.Addresses.Remove(database.Addresses.Find(postalCode, addressLine1));
                database.SaveChanges();
            }
        }

    }
}

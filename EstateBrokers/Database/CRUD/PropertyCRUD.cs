using Database;
using Gateways;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace UseCases
{
    public class PropertyCRUD : IPropertyCRUD
    {
        public void CreateProperty(int estimatedPrice, Entities.Case Case, int postalCode, string adressLine1 )
        {
            var database = new EstateBrokerContext();

            var property = new Database.Property()
            {
                EstimatedPrice = estimatedPrice,
                Case = (Database.Case)Case,
                PostalCode = postalCode,
                AddressLine1= adressLine1
            };

            database.Properties.Add(property);
            database.SaveChanges();
        }
        public Entities.Property ReadProperty(int ID)
        {
            using (var database = new EstateBrokerContext())
            {
                return database.Properties.Find(ID);
            }
        }
        public void UpdateProperty(int ID, int estimatedPrice, Entities.Case Case, int postalCode, string adressLine1)
        {
            using (var database = new EstateBrokerContext())
            {
                Database.Property property = database.Properties.Find(ID);
                property.EstimatedPrice = estimatedPrice;
                property.Case = (Database.Case)Case;
                property.PostalCode = postalCode;
                property.AddressLine1 = adressLine1;
                database.SaveChanges();
            }
        }
        public void DeleteProperty(int ID)
        {
            var property = new Database.Property()
            {
                PropertyID = ID
            };
            using (var database = new EstateBrokerContext())
            {
                database.Properties.Remove(property);
                database.SaveChanges();
            }
            
        }

    }
    
}

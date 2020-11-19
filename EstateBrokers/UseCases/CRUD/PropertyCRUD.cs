using Database;
using Gateways;
using System;
using System.Collections.Generic;
using System.Text;

namespace UseCases
{
    public class PropertyCRUD : IPropertyCRUD
    {
        public void Create(int estimatedPrice, Case Case, int postalCode, string adressLine1 )
        {
            var database = new EstateBrokerContext();

            var property = new Property()
            {
                EstimatedPrice = estimatedPrice,
                Case = Case,
                PostalCode = postalCode,
                AddressLine1= adressLine1
            };

            database.Properties.Add(property);
            database.SaveChanges();
        }
        public Property Read(int ID)
        {
            using (var database = new EstateBrokerContext())
            {
                return database.Properties.Find(ID);
            }
        }
        public void Update(int ID, int estimatedPrice, Case Case, int postalCode, string adressLine1)
        {
            using (var database = new EstateBrokerContext())
            {
                Property property = database.Properties.Find(ID);
                property.EstimatedPrice = estimatedPrice;
                property.Case = Case;
                property.PostalCode = postalCode;
                property.AddressLine1 = adressLine1;
            }
        }
        public void Delete(int ID)
        {
            var property = new Property()
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

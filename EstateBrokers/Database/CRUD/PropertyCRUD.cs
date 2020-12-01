using Database;
using Gateways;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace UseCases
{
    public class PropertyCRUD : IPropertyCRUD
    {
        public int CreateProperty(double estimatedPrice, Entities.Case Case, int postalCode, string adressLine1 )
        {
            var database = new EstateBrokerContext();
            var property = new Database.Property()
            {
                EstimatedPrice = estimatedPrice,
                Case = database.Cases.FirstOrDefault(a => a.CaseID == Case.CaseID),
                PostalCode = postalCode,
                AddressLine1= adressLine1
            };

            database.Properties.Add(property);
            database.SaveChanges();
            return property.PropertyID;
        }
        public Entities.Property ReadProperty(int ID)
        {
            using (var database = new EstateBrokerContext())
            {
                return database.Properties.Find(ID);
            }
        }
        public List<Entities.Property> GetAllProperties()
        {
            List<Entities.Property> workingList = new List<Entities.Property>();

            using (var database = new EstateBrokerContext())
            {
                foreach (var Property in database.Properties)
                {
                    workingList.Add(Property);
                }
            }
            return workingList;
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

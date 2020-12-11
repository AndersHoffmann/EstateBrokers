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
        public int CreateProperty(double estimatedPrice,int caseID, int postalCode, string adressLine1 )
        {
            var database = new EstateBrokerContext();
            var property = new Database.Property()
            {
                EstimatedPrice = estimatedPrice,
                PostalCode = postalCode,
                AddressLine1= adressLine1,
                CaseID = caseID

            };

            database.Properties.Add(property);
            database.SaveChanges();
            return property.PropertyID;
        }
        public Entities.Property ReadProperty(int ID)
        {
            using (var database = new EstateBrokerContext())
            {
                return (Entities.Property)PropertyFactory.CreateProperty((Entities.ObjectInterFaces.IProperty)database.Properties.Where(a => a.CaseID == ID));

            }
        }

        public Entities.Property ReadPropertyFromCaseID(int ID)
        {
            using (var database = new EstateBrokerContext())
            {
                return (Entities.Property)PropertyFactory.CreateProperty(database.Properties.FirstOrDefault(a => a.CaseID == ID));
            }
        }

        public List<Entities.Property> GetAllProperties()
        {
            List<Entities.Property> workingList = new List<Entities.Property>();

            using (var database = new EstateBrokerContext())
            {
                foreach (var Property in database.Properties)
                {
                    workingList.Add((Entities.Property)PropertyFactory.CreateProperty(Property));
                }
            }
            return workingList;
        }
        public bool UpdateProperty(int ID, double estimatedPrice, int caseID, int postalCode, string adressLine1)
        {
            try
            {
                using (var database = new EstateBrokerContext())
                {
                    Database.Property property = database.Properties.Find(ID);
                    property.EstimatedPrice = estimatedPrice;
                    property.CaseID = caseID;
                    property.PostalCode = postalCode;
                    property.AddressLine1 = adressLine1;
                    database.SaveChanges();
                }
                return true;
            }
            catch 
            {
                return false;
              
            }
            
        }
        public void DeleteProperty(int ID)
        {
            using (var database = new EstateBrokerContext())
            {
               
                database.Properties.Remove(database.Properties.Find(ID));
                database.SaveChanges();
            }
            
        }

    }
    
}

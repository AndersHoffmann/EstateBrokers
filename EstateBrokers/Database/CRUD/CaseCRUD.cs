using Database;
using Gateways;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UseCases
{
    public class CaseCRUD : ICaseCRUD
    {
        public void CreateCase(DateTime creationDate, double price, Entities.Realtor realtor)
        {
            Database.Realtor dbRealtor = (Database.Realtor)realtor;
            var database = new EstateBrokerContext();

            var workingCase = new Database.Case()
            {
                CreationDate = creationDate,
                Price = price,
                Realtor = dbRealtor
            };

            database.Cases.Add(workingCase);
            database.SaveChanges();
        }

        public Entities.Case ReadCase(int ID)
        {
            using (var database = new EstateBrokerContext())
            {
                return database.Cases.Find(ID);
            
            }
         
        }

        public List<Entities.Case> ReadCases(int postalCode)
            {
                using (var database = new EstateBrokerContext())
                {
                List<Entities.Case> cases = new List<Entities.Case>();
                List<Database.Property> properties = new List<Database.Property>();

                    
                properties.Add((Database.Property)(database.Properties.Where(s => s.PostalCode == postalCode)));

                foreach (var item in properties)
                {
                       cases.Add((Database.Case)database.Cases.Where(s => s.Property == database.Properties.Find(item.PropertyID)));      
                }
                
                database.SaveChanges();

                return cases;
              
            }
           
        }

        public void UpdateCase(int ID, DateTime creationDate, DateTime closedDate, double price, Entities.Realtor realtor)
        {
            using (var database = new EstateBrokerContext())
            {
                Database.Case workingCase = database.Cases.Find(ID);
                workingCase.CreationDate = creationDate;
                workingCase.ClosedDate = closedDate;
                workingCase.Price = price;
                workingCase.Realtor = (Database.Realtor)realtor;
                database.SaveChanges();
            }
       
        }
        public void DeleteCase(int ID)
        {
            var workingCase = new Database.Case()
            {
                CaseID = ID
            };
            using (var database = new EstateBrokerContext())
            {
                database.Cases.Remove(workingCase);
                database.SaveChanges();
            }
        }
    }
}

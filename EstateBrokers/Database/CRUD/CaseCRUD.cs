using Database;
using Gateways;
using System;
using System.Collections.Generic;
using System.Linq;

namespace UseCases
{
    public class CaseCRUD : ICaseCRUD
    {
        public int CreateCase(DateTime creationDate, double price, int realtorID)
        {

            var database = new EstateBrokerContext();
            IRealtorCRUD realtorCRUD = new RealtorCRUD();
            

            var workingCase = new Database.Case()
            {
                CreationDate = creationDate,
                Price = price,
            };
            Realtor realtor = database.Realtors.FirstOrDefault(a => a.RealtorID == realtorID);

            workingCase.Realtor = realtor;

            database.Cases.Add(workingCase);
            database.SaveChanges();
            return workingCase.CaseID;
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

                if (database.Properties.Any(s => s.PostalCode == postalCode) == true)
                {
                    properties.Add((Database.Property)(database.Properties.Where(s => s.PostalCode == postalCode)));
                }


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

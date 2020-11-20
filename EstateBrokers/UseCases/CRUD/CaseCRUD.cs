using Database;
using Gateways;
using System;
using System.Collections.Generic;
using System.Text;

namespace UseCases
{
    class CaseCRUD : ICaseCRUD
    {
        public void CreateCaseCase(DateTime creationDate, double price, Realtor realtor)
        {
            var database = new EstateBrokerContext();

            var workingCase = new Case()
            {
                CreationDate = creationDate,
                Price = price,
                Realtor = realtor
            };

            database.Cases.Add(workingCase);
            database.SaveChanges();
        }

        public Case ReadCase(int ID)
        {
            using (var database = new EstateBrokerContext())
            {
                return database.Cases.Find(ID);
            }
        }

        public List<Case> ReadCases(int postalCode)
            {
                using (var database = new EstateBrokerContext())
                {
                   return database.Where(s => s.PostalCode == postalCode).ToList();
                }
            }

        public void UpdateCase(int ID, DateTime creationDate, DateTime closedDate, double price, Realtor realtor)
        {
            using (var database = new EstateBrokerContext())
            {
                Case workingCase = database.Cases.Find(ID);
                workingCase.CreationDate = creationDate;
                workingCase.ClosedDate = closedDate;
                workingCase.Price = price;
                workingCase.Realtor = realtor;
            }
        }
        public void DeleteCase(int ID)
        {
            var workingCase = new Case()
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

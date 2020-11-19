using Database;
using Gateways;
using System;
using System.Collections.Generic;
using System.Text;

namespace UseCases
{
    class CaseCRUD : ICaseCRUD
    {
        public void Create(DateTime creationDate, double price, Realtor realtor)
        {
            var database = new EstateBrokerContext();

            var workingCase = new Database.Case()
            {
                CreationDate = creationDate,
                Price = price,
                Realtor = realtor
            };

            database.Cases.Add(workingCase);
            database.SaveChanges();
        }

        public Case Read(int ID)
        {
            using (var database = new EstateBrokerContext())
            {
                return database.Cases.Find(ID);
            }
        }
        public void Update(int ID, DateTime creationDate, DateTime closedDate, double price, Realtor realtor)
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
        public void Delete(int ID)
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

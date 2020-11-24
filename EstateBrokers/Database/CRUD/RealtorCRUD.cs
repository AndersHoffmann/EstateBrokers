﻿using Database;
using Gateways;
using System;
using System.Collections.Generic;
using System.Text;

namespace UseCases
{
    class RealtorCRUD : IRealtorCRUD
    {
        public void CreateRealtor(string name, string phoneNR)
        {
            var database = new EstateBrokerContext();

            var realtor = new Realtor()
            {
                Name = name,
                PhoneNR = phoneNR
            };

            database.Realtors.Add(realtor);
            database.SaveChanges();
        }
        public Entities.Realtor ReadRealtor(int ID)
        {
            using (var database = new EstateBrokerContext())
            {
                return database.Realtors.Find(ID);
              
            }
        }
        public void UpdateRealtor(int ID, string name, string phoneNR)
        {
            using (var database = new EstateBrokerContext())
            {
                Realtor realtor = database.Realtors.Find(ID);
                realtor.Name = name;
                realtor.PhoneNR = phoneNR;
                database.SaveChanges();
            }
        }
        public void DeleteRealtor(int ID)
        {
            var realtor = new Realtor()
            {
                RealtorID = ID
            };
            using (var database = new EstateBrokerContext())
            {
                database.Realtors.Remove(realtor);
                database.SaveChanges();

            }
        }
    }
}

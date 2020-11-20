using Database;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class SingleFunctionMethods
    {
        public void SaveChanges()
        {
            using (var database = new EstateBrokerContext())
            {
                database.SaveChanges();
            }
        }

        public DbContext AddressCRUDInstance()
        {

        }
        public DbContext CaseCRUDInstance()
        {

        }
        public DbContext PropertyCRUDInstance()
        {

        }
        public DbContext RealtorCRUDInstance()
        {
        private RealtorCRUD()
        {
        }
        private static RealtorCRUD instance = null;
        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Singleton();
                }
                return instance;
            }
        }
    }
    }
}

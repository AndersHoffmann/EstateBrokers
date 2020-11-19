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
    }
}

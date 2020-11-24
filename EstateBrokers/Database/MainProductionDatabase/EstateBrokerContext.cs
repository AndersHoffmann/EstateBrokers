using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;


namespace Database
{
    public class EstateBrokerContext : DbContext
    {
        public EstateBrokerContext() 
        {
          
        }


        //entities        
        public DbSet<Realtor> Realtors { get; set; }
        public DbSet<Property> Properties { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Case> Cases { get; set; }
    }
}

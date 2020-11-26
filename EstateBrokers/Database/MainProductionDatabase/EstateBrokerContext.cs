using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Text;


namespace Database
{
    public class EstateBrokerContext : DbContext
    {
        public EstateBrokerContext() : base()
        { }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Address>().HasKey(p => new { p.PostalCode, p.AddressLine1 });
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source = den1.mssql7.gear.host;
            Initial Catalog = estatebrokerdb; User ID = estatebrokerdb; Password = Sd8a-9E?0B5E");
        }

    
        //entities        
        public DbSet<Realtor> Realtors { get; set; }
        public DbSet<Property> Properties { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Case> Cases { get; set; }
    }
}

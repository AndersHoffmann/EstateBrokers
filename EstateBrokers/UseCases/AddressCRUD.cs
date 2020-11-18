using System;
using System.Collections.Generic;
using System.Text;

namespace UseCases
{
    class AddressCRUD
    {
        public void CreateAdress(int postalCode string addressLine1, string addressLine2, double ownershipCost, int exteriorArea, int exteriorArea, int buildYear)
        {
            var database = new DatabaseEntities();

            var address = new Address;
            {
                PostalCode = postalCode;
                AddressLine1 = addressLine1;
                AddressLine2 = addressLine2
                OwnershipCost = ownershipCost;
                ExteriorArea = exteriorArea;
                InteriorArea = exteriorArea;
                BuildYear = buildYear;
            };

            database.Adress.Add(address);
            database.SaveChanges();
        }
        public Address ReadAdress(int ID)
        {

            
                var query = from st in context.Students
                            where st.StudentName == "Bill"
                            select st;

                var student = query.FirstOrDefault<Student>();
          
        }
    }

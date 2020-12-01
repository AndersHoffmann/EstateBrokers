using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gateways
{
    public interface IPropertyCRUD
    {
        public int CreateProperty(double estimatedPrice, Case Case, int postalCode, string adressLine1);

        public Property ReadProperty(int ID);

        public List<Property> GetAllProperties();

        public void UpdateProperty(int ID, int estimatedPrice, Case Case, int postalCode, string adressLine1);

        public void DeleteProperty(int ID);
    }
}
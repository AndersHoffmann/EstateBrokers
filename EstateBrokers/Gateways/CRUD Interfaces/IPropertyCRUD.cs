using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gateways
{
    public interface IPropertyCRUD
    {
        public void CreateProperty(int estimatedPrice, Case Case, int postalCode, string adressLine1);

        public Property ReadProperty(int ID);

        public void UpdateProperty(int ID, int estimatedPrice, Case Case, int postalCode, string adressLine1);

        public void DeleteProperty(int ID);
    }
}
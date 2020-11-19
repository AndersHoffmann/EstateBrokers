using Database;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gateways
{
    public interface IPropertyCRUD
    {
        public void Create(int estimatedPrice, Case Case, int postalCode, string adressLine1);

        public Property Read(int ID);

        public void Update(int ID, int estimatedPrice, Case Case, int postalCode, string adressLine1);

        public void Delete(int ID);
    }
}
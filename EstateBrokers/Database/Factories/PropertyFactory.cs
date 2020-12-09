using Entities.ObjectInterFaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Database
{
    static class PropertyFactory
    {
        public static IProperty CreateProperty(IProperty Property = null)
        {

            if (Property is Database.Property) 
            {
                return new Entities.Property
                    (Property.PropertyID, Property.EstimatedPrice, Property.Case, Property.CaseID, Property.PostalCode, Property.AddressLine1);
            }
            if (Property is Entities.Property)
            {
                return new Database.Property
                    (Property.PropertyID, Property.EstimatedPrice, Property.Case, Property.CaseID, Property.PostalCode, Property.AddressLine1);
            }
            else
            {
                return new Entities.Property();
            }

        }

    }
}

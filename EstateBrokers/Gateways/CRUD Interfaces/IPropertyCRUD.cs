﻿using Entities;
using Entities.Objects;
using System.Collections.Generic;

namespace Gateways
{
    public interface IPropertyCRUD
    {
        public int CreateProperty(double estimatedPrice, int caseID, int postalCode, string adressLine1);

        public Property ReadProperty(int ID);
        public Property ReadPropertyFromCaseID(int ID);

        public List<Property> GetAllProperties();

        public bool UpdateProperty(int ID, double estimatedPrice, int caseID, int postalCode, string adressLine1);

        public void DeleteProperty(int ID);
    }
}
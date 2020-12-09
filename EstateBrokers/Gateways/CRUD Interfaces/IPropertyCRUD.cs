﻿using Entities;
using System.Collections.Generic;

namespace Gateways
{
    public interface IPropertyCRUD
    {
        public int CreateProperty(double estimatedPrice, Case Case, int postalCode, string adressLine1);

        public Property ReadProperty(int ID);
        public Property ReadPropertyFromCaseID(int ID):

        public List<Property> GetAllProperties();

        public Entities.Property ReadPropertyFromCaseID(int id);

        public bool UpdateProperty(int ID, double estimatedPrice, int caseID, int postalCode, string adressLine1);

        public void DeleteProperty(int ID);
    }
}
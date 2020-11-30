using System;
using System.Collections.Generic;
using System.Text;
using Database;
using Gateways;

namespace UseCases.ShowCases
{
    class ShowEntries
    {
        public void GetEntries()
        {
            IAddressCRUD addressCRUD = new AddressCRUD();
            ICaseCRUD caseCRUD = new CaseCRUD();
            IPropertyCRUD propertyCRUD = new PropertyCRUD();

            List<ShowEntriesRequestModel> entryList = new List<ShowEntriesRequestModel>();
            List<Entities.Case> workingCaseList = caseCRUD.ReadAllCases();

            foreach (var Case in workingCaseList)
            {
                ShowEntriesRequestModel showEntriesRequestModel = new ShowEntriesRequestModel();
                showEntriesRequestModel.realtorID = Case.Realtor.RealtorID;
                showEntriesRequestModel.creationDate = Case.CreationDate;
                if (Case.ClosedDate != null)
                {
                    showEntriesRequestModel.closedDate = Case.ClosedDate;
                }

                showEntriesRequestModel.price = Case.Price;
                Property workingProperty = (Property)propertyCRUD.ReadProperty(Case.Property.PropertyID);
                showEntriesRequestModel.estimatedPrice = workingProperty.EstimatedPrice;
                Address workingAddress = (Address)addressCRUD.ReadAddress(workingProperty.PostalCode, workingProperty.AddressLine1);
                showEntriesRequestModel.postalCode = workingAddress.PostalCode;
                showEntriesRequestModel.AddressLine1 = workingAddress.AddressLine1;
                showEntriesRequestModel.AddressLine2 = workingAddress.AddressLine2;
                showEntriesRequestModel.ownershipCost = workingAddress.OwnershipCost;
                showEntriesRequestModel.exteriorArea = workingAddress.ExteriorArea;
                showEntriesRequestModel.interiorArea = workingAddress.InteriorArea;
                showEntriesRequestModel.buildYear = workingAddress.BuildYear;
                entryList.Add(showEntriesRequestModel);

            }

        }
    }
}

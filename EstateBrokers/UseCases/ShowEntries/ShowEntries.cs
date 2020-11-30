using System;
using System.Collections.Generic;
using System.Text;
using Database;
using Gateways;

namespace UseCases.ShowCases
{
    class ShowEntries : IShowEntryInput
    {
        public IShowEntryOutput showEntryOutput { get; set; }

        public ShowEntries(IShowEntryOutput showentryoutput)
        {
            showEntryOutput = showentryoutput;
        }
        public void GetEntries()
        {
            IAddressCRUD addressCRUD = new AddressCRUD();
            ICaseCRUD caseCRUD = new CaseCRUD();
            IPropertyCRUD propertyCRUD = new PropertyCRUD();

            List<ShowEntriesRequestModel> responseList = new List<ShowEntriesRequestModel>();
            List<Entities.Case> workingCaseList = caseCRUD.ReadAllCases();

            foreach (var Case in workingCaseList)
            {
                ShowEntriesRequestModel showEntriesResponseModel = new ShowEntriesRequestModel();
                showEntriesResponseModel.realtorID = Case.Realtor.RealtorID;
                showEntriesResponseModel.creationDate = Case.CreationDate;
                if (Case.ClosedDate != null)
                {
                    showEntriesResponseModel.closedDate = Case.ClosedDate;
                }

                showEntriesResponseModel.price = Case.Price;
                Property workingProperty = (Property)propertyCRUD.ReadProperty(Case.Property.PropertyID);
                showEntriesResponseModel.estimatedPrice = workingProperty.EstimatedPrice;
                Address workingAddress = (Address)addressCRUD.ReadAddress(workingProperty.PostalCode, workingProperty.AddressLine1);
                showEntriesResponseModel.postalCode = workingAddress.PostalCode;
                showEntriesResponseModel.AddressLine1 = workingAddress.AddressLine1;
                showEntriesResponseModel.AddressLine2 = workingAddress.AddressLine2;
                showEntriesResponseModel.ownershipCost = workingAddress.OwnershipCost;
                showEntriesResponseModel.exteriorArea = workingAddress.ExteriorArea;
                showEntriesResponseModel.interiorArea = workingAddress.InteriorArea;
                showEntriesResponseModel.buildYear = workingAddress.BuildYear;
                responseList.Add(showEntriesResponseModel);

                showEntryOutput.ReturnListOfEntries(responseList);
            }

        }
    }
}

using Database;
using Gateways;
using System.Collections.Generic;

namespace UseCases.ShowCases
{
    public class ShowEntries : IShowEntryInput
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

            List<ShowEntriesResponseModel> responseList = new List<ShowEntriesResponseModel>();
            List<Entities.Case> workingCaseList = caseCRUD.ReadAllCases();

            foreach (var Case in workingCaseList)
            {
                ShowEntriesResponseModel showEntriesResponseModel = new ShowEntriesResponseModel();
                if (Case.Realtor != null)
                {
                    showEntriesResponseModel.realtorID = Case.Realtor.RealtorID;
                }   
                
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

                showEntryOutput.DisplayListOfEntries(responseList);
            }

        }
    }
}

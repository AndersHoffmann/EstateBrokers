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
            List<Entities.Property> workingPropertyList = propertyCRUD.GetAllProperties();

            foreach (var property in workingPropertyList)
            {
                ShowEntriesResponseModel showEntriesResponseModel = new ShowEntriesResponseModel();
                   showEntriesResponseModel.estimatedPrice = property.EstimatedPrice;
                Case workingCase = (Case)caseCRUD.ReadCase(property.Case.CaseID);
                if (workingCase.RealtorID != null)
                {
                    showEntriesResponseModel.realtorID = workingCase.Realtor.RealtorID;
                }   
                
                if (workingCase.ClosedDate != null)
                {
                    showEntriesResponseModel.closedDate = workingCase.ClosedDate;
                }

                showEntriesResponseModel.price = workingCase.Price;
               
             
                Address workingAddress = (Address)addressCRUD.ReadAddress(property.PostalCode, property.AddressLine1);
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

using Database;
using Gateways;
using System.Collections.Generic;

namespace UseCases.ShowCases
{
    public class ShowEntries : IShowEntryInput
    {
        IShowEntryOutput _showEntryOutput;
        IAddressCRUD _addressCRUD;
        ICaseCRUD _caseCRUD;
        IPropertyCRUD _propertyCRUD;

        public ShowEntries(IShowEntryOutput showentryoutput, IAddressCRUD addressCRUD, ICaseCRUD caseCRUD, IPropertyCRUD propertyCRUD)
        {
            _showEntryOutput = showentryoutput;
            _addressCRUD = addressCRUD;
            _caseCRUD = caseCRUD;
            _propertyCRUD = propertyCRUD;

        }
        public void GetEntries()
        {
           
            List<ShowEntriesResponseModel> responseList = new List<ShowEntriesResponseModel>();
            List<Entities.Property> workingPropertyList = _propertyCRUD.GetAllProperties();

            foreach (var property in workingPropertyList)
            {
                ShowEntriesResponseModel showEntriesResponseModel = new ShowEntriesResponseModel();
                showEntriesResponseModel.estimatedPrice = property.EstimatedPrice;

                Entities.Case workingCase = _caseCRUD.ReadCase(property.CaseID);

                if (workingCase.Realtor != null)
                {
                    showEntriesResponseModel.realtorID = workingCase.Realtor.RealtorID;
                }   
                
                if (workingCase.ClosedDate != null)
                {
                    showEntriesResponseModel.closedDate = workingCase.ClosedDate;
                }

                showEntriesResponseModel.price = workingCase.Price;
               
             
                Entities.Address workingAddress = _addressCRUD.ReadAddress(property.PostalCode, property.AddressLine1);

                showEntriesResponseModel.postalCode = workingAddress.PostalCode;
                showEntriesResponseModel.AddressLine1 = workingAddress.AddressLine1;
                showEntriesResponseModel.AddressLine2 = workingAddress.AddressLine2;
                showEntriesResponseModel.ownershipCost = workingAddress.OwnershipCost;
                showEntriesResponseModel.exteriorArea = workingAddress.ExteriorArea;
                showEntriesResponseModel.interiorArea = workingAddress.InteriorArea;
                showEntriesResponseModel.buildYear = workingAddress.BuildYear;
                responseList.Add(showEntriesResponseModel);

                _showEntryOutput.DisplayListOfEntries(responseList);
            }

        }
    }
}

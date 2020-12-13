using Database;
using Gateways;

namespace UseCases.UpdateEntry
{
    public class RunUpdateEntry : IUpdateEntryInput
    {

        IUpdateEntryOutput _updateEntryOutput;
        ICaseCRUD _caseCRUD;
        IPropertyCRUD _propertyCRUD;
        IAddressCRUD _addressCRUD;
        

        public RunUpdateEntry(IUpdateEntryOutput updateEntryOutput, ICaseCRUD caseCRUD, IPropertyCRUD propertyCRUD, IAddressCRUD addressCRUD)
        {
            _updateEntryOutput = updateEntryOutput;
            _caseCRUD = caseCRUD;
            _propertyCRUD = propertyCRUD;
            _addressCRUD = addressCRUD;
        }

        public void UpdateEntry(UpdatedEntryRequestModel request)
        {

            bool caseConfirmed = _caseCRUD.UpdateCase(request.CaseID, request.CreationDate, request.ClosedDate, request.Price, request.RealtorID);

            //  int propertyID = _caseCRUD.ReadCase(request.caseID).PropertyID;
            int propertyID = _propertyCRUD.ReadPropertyFromCaseID(request.CaseID).PropertyID;


            bool propertyConfirmed = _propertyCRUD.UpdateProperty(propertyID, request.EstimatedPrice, request.CaseID, request.PostalCode, request.AddressLine1);

            bool addressConfirmed = _addressCRUD.UpdateAddress(
                request.PostalCode, request.AddressLine1, request.OwnershipCost,
                request.ExteriorArea, request.InteriorArea);


            UpdateEntryResponseModel response = new UpdateEntryResponseModel();

            response.EntryUpdatedSuccesfully = (caseConfirmed && propertyConfirmed && addressConfirmed);
           
            _updateEntryOutput.ConfirmEntryCreation(response);

        }

        public void GetEntryInfo(ShowEntryEditableRequestModel request)
        {

            var response = new ShowEntryEditableResponseModel();

            var selectedCase =_caseCRUD.ReadCase(request.CaseID);

            response.caseID = selectedCase.CaseID;
            response.realtorID = _caseCRUD.ReturnRealtorIDOnCase(request.CaseID);
            response.creationDate = selectedCase.CreationDate;
            response.closedDate = selectedCase.ClosedDate;
            response.price = selectedCase.Price;
            

            var selectedProperty = _propertyCRUD.ReadPropertyFromCaseID(request.CaseID);

            response.estimatedPrice = selectedProperty.EstimatedPrice;
            response.postalCode = selectedProperty.PostalCode;
            response.addressLine1 = selectedProperty.AddressLine1;

            var selectedAddress = _addressCRUD.ReadAddress(selectedProperty.PostalCode, selectedProperty.AddressLine1);

            response.addressLine2 = selectedAddress.AddressLine2;
            response.ownershipCost = selectedAddress.OwnershipCost;
            response.exteriorArea = selectedAddress.ExteriorArea;
            response.interiorArea = selectedAddress.InteriorArea;
            response.buildYear = selectedAddress.BuildYear;


            _updateEntryOutput.ReturnEntryInformation(response);
    }

}
}

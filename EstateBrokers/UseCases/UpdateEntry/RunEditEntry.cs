using Database;
using Gateways;

namespace UseCases.UpdateEntry
{
    public class RunUpdateEntry : IUpdateEntryInput
    {

        public IUpdateEntryOutput _updateEntryOutput;
        public ICaseCRUD _caseCRUD;
        public IPropertyCRUD _propertyCRUD;
        public IAddressCRUD _addressCRUD;
        

        public RunUpdateEntry(IUpdateEntryOutput updateEntryOutput, ICaseCRUD caseCRUD, IPropertyCRUD propertyCRUD, IAddressCRUD addressCRUD)
        {
            _updateEntryOutput = updateEntryOutput;
            _caseCRUD = caseCRUD;
            _propertyCRUD = propertyCRUD;
            _addressCRUD = addressCRUD;
        }

        public void UpdateEntry(UpdatedEntryRequestModel request)
        {

            bool caseConfirmed = _caseCRUD.UpdateCase(request.caseID, request.creationDate, request.closedDate, request.price, request.realtorID);

            int propertyID = _caseCRUD.ReadCase(request.caseID).Property.PropertyID;

            bool propertyConfirmed = _propertyCRUD.UpdateProperty(propertyID, request.estimatedPrice, request.caseID, request.postalCode, request.addressLine1);

            bool addressConfirmed = _addressCRUD.UpdateAddress(
                request.postalCode, request.addressLine1, request.addressLine2, request.ownershipCost,
                request.exteriorArea, request.interiorArea, request.buildYear);


            UpdateEntryResponseModel response = new UpdateEntryResponseModel();

            response.EntryUpdatedSuccesfully = (caseConfirmed && propertyConfirmed && addressConfirmed);
           
            _updateEntryOutput.ConfirmEntryCreation(response);

        }

        public void GetEntryInfo(ShowEntryEditableRequestModel request)
        {

            var response = new ShowEntryEditableResponseModel();

            var selectedCase =_caseCRUD.ReadCase(request.CaseID);

            response.caseID = selectedCase.CaseID;
            response.realtorID = selectedCase.Realtor.RealtorID;
            response.creationDate = selectedCase.CreationDate;
            response.closedDate = selectedCase.ClosedDate;
            response.price = selectedCase.Price;

            var selectedProperty = _propertyCRUD.ReadProperty(selectedCase.Realtor.RealtorID);

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

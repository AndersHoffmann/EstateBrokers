using Database;
using Gateways;

namespace UseCases.CreateEntry
{
    public class RunCreateEntry : ICreateEntryInput
    {

        ICreateEntryOutput _createEntryOutput;
        ICaseCRUD _caseCRUD;
        IPropertyCRUD _propertyCRUD;
        IAddressCRUD _addressCRUD;
        

        public RunCreateEntry(ICreateEntryOutput createentryoutput, ICaseCRUD caseCRUD, IPropertyCRUD propertyCRUD, IAddressCRUD addressCRUD)
        {
            _createEntryOutput = createentryoutput;
            _caseCRUD = caseCRUD;
            _propertyCRUD = propertyCRUD;
            _addressCRUD = addressCRUD;
        }

        public void CreateEntry(CreateEntryRequestModel request)
        {

            int caseID = _caseCRUD.CreateCase(request.CreationDate, request.Price, request.RealtorID);

            int propertyID = _propertyCRUD.CreateProperty(request.EstimatedPrice, caseID, request.PostalCode, request.AddressLine1);

            int postalCodeofAddressObject = _addressCRUD.CreateAddress(
                request.PostalCode, request.AddressLine1, request.AddressLine2, request.OwnershipCost,
                request.ExteriorArea, request.InteriorArea, request.BuildYear);

            CreateEntryResponseModel response = new CreateEntryResponseModel();

            if (caseID != 0 && propertyID != 0 && postalCodeofAddressObject != 0)
            {
                response.EntryCreatedSuccesfully = true;
            }
            else
            {
                response.EntryCreatedSuccesfully = false;
            }
            _createEntryOutput.ConfirmEntryCreation(response);

        }

    }
}

using Database;
using Gateways;

namespace UseCases.CreateEntry
{
    public class RunCreateEntry : ICreateEntryInput
    {

        public ICreateEntryOutput _createEntryOutput;
        public ICaseCRUD _caseCRUD;
        public IPropertyCRUD _propertyCRUD;
        public IAddressCRUD _addressCRUD;
        

        public RunCreateEntry(ICreateEntryOutput createentryoutput, ICaseCRUD caseCRUD, IPropertyCRUD propertyCRUD, IAddressCRUD addressCRUD)
        {
            _createEntryOutput = createentryoutput;
            _caseCRUD = caseCRUD;
            _propertyCRUD = propertyCRUD;
            _addressCRUD = addressCRUD;
        }

        public void Create(CreateEntryRequestModel request)
        {

            int caseID = _caseCRUD.CreateCase(request.creationDate, request.price, request.realtorID);

            int propertyID = _propertyCRUD.CreateProperty(request.estimatedPrice, _caseCRUD.ReadCase(caseID), request.postalCode, request.AddressLine1);

            int postalCodeofAddressObject = _addressCRUD.CreateAddress(
                request.postalCode, request.AddressLine1, request.AddressLine2, request.ownershipCost,
                request.exteriorArea, request.interiorArea, request.buildYear);

            CreateEntryResponseModel response = new CreateEntryResponseModel();

            if (caseID != null && propertyID != null && postalCodeofAddressObject != null)
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

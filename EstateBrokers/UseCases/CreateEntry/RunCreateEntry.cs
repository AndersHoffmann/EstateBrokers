using Database;
using Gateways;

namespace UseCases.CreateEntry
{
    public class RunCreateEntry : ICreateEntryInput
    {

        public ICreateEntryOutput createEntryOutput { get; set; }

        public RunCreateEntry(ICreateEntryOutput createentryoutput)
        {
            createEntryOutput = createentryoutput;
        }

        public void Create(CreateEntryRequestModel request)
        {
            ICaseCRUD caseCrud = new CaseCRUD();
            IPropertyCRUD propertyCrud = new PropertyCRUD();
            IAddressCRUD addressCrud = new AddressCRUD();
            IRealtorCRUD realtorCrud = new RealtorCRUD();

            int caseID = caseCrud.CreateCase(request.creationDate, request.price, request.realtorID);

            int propertyID = propertyCrud.CreateProperty(request.estimatedPrice, caseCrud.ReadCase(caseID), request.postalCode, request.AddressLine1);

            int postalCodeofAddressObject = addressCrud.CreateAddress(
                request.postalCode, request.AddressLine1, request.AddressLine2, request.ownershipCost,
                request.exteriorArea, request.interiorArea, request.buildYear);

            CreateEntryResponseModel response = new CreateEntryResponseModel();

            if (caseID != null && propertyID != null && addressCrud != null)
            {
                response.EntryCreatedSuccesfully = true;
            }
            else
            {
                response.EntryCreatedSuccesfully = false;
            }
            createEntryOutput.ConfirmEntryCreation(response);

        }

    }
}

using Gateways;

namespace UseCases.DeleteEntry
{
    public class DeleteEntry : IDeleteEntryInput
    {

        IDeleteEntryOutput _deleteEntryOutput;
        ICaseCRUD _caseCRUD;
        IPropertyCRUD _propertyCRUD;
        IAddressCRUD _addressCRUD;

        //Dependency injection Abstraction
        public DeleteEntry(IDeleteEntryOutput deleteEntryOutput, ICaseCRUD caseCRUD, IPropertyCRUD propertyCRUD, IAddressCRUD addressCRUD)
        {
            _deleteEntryOutput = deleteEntryOutput;
            _caseCRUD = caseCRUD;
            _propertyCRUD = propertyCRUD;
            _addressCRUD = addressCRUD;
        }
        public void EntryDeletion(DeleteEntryRequestModel request)
        {
            Entities.Property workingProperty = _propertyCRUD.ReadPropertyFromCaseID(request.CaseID);

            DeleteEntryResponseModel response = new DeleteEntryResponseModel();

            _addressCRUD.DeleteAddress(workingProperty.PostalCode, workingProperty.AddressLine1);

            _propertyCRUD.DeleteProperty(workingProperty.PropertyID);

            _caseCRUD.DeleteCase(workingProperty.CaseID);


            response.Confirm = true;



            _deleteEntryOutput.ConfirmDeletion(response);

        }
    }
}

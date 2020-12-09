using Gateways;

namespace UseCases.DeleteEntry
{
    public class DeleteEntry : IDeleteEntryInput
    {

        IDeleteEntryOutput _deleteEntryOutput;
        ICaseCRUD _caseCRUD;
        IPropertyCRUD _propertyCRUD;
        IAddressCRUD _addressCRUD;


        public DeleteEntry(IDeleteEntryOutput deleteEntryOutput, ICaseCRUD caseCRUD, IPropertyCRUD propertyCRUD, IAddressCRUD addressCRUD)
        {
            _deleteEntryOutput = deleteEntryOutput;
            _caseCRUD = caseCRUD;
            _propertyCRUD = propertyCRUD;
            _addressCRUD = addressCRUD;
        }
        public void EntryDeletion(int caseID)
        {
            Entities.Property workingProperty = _propertyCRUD.ReadPropertyFromCaseID(caseID);

            DeleteEntryResponseModel response = new DeleteEntryResponseModel();
            try
            {
                _caseCRUD.DeleteCase(workingProperty.CaseID);

                _addressCRUD.DeleteAddress(workingProperty.PostalCode, workingProperty.AddressLine1);

                _propertyCRUD.DeleteProperty(workingProperty.PropertyID);

                response.confirm = true;
            }
            catch 
            {
                response.confirm = false;
            }

            _deleteEntryOutput.ConfirmDeletion(response);

        }
    }
}

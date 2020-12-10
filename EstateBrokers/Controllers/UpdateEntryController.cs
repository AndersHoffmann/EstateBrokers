using UseCases.UpdateEntry;
using System;
namespace Controllers
{
    public class UpdateEntryController
    {
        IUpdateEntryInput _updateEntryInput;

        public UpdateEntryController(IUpdateEntryInput updateEntryInput)
        {
            _updateEntryInput = updateEntryInput;
        }

        //Get data from a case id
        public void GetEntryEditInfo(decimal caseID)
        {
            ShowEntryEditableRequestModel requeset = new ShowEntryEditableRequestModel();

            requeset.CaseID = Convert.ToInt32(caseID);

            _updateEntryInput.GetEntryInfo(requeset);

        }

        //Update the data
        public void UpdateEntry(decimal CaseID, decimal realtorID, string creationDate, string closedDate, decimal price, decimal estimatedPrice, decimal postalCode, string addressLine1, 
            string addressLine2, decimal ownershipCost, decimal exteriorArea, decimal interiorArea, decimal buildYear)
        {

            UpdatedEntryRequestModel request = new UpdatedEntryRequestModel();

            //Case
            request.caseID = Convert.ToInt32(CaseID);
            request.realtorID = Convert.ToInt32(realtorID);
            request.creationDate = DateTime.Parse(creationDate);
            request.closedDate = DateTime.Parse(closedDate);
            request.price = Convert.ToDouble(price);

            //Property
            request.estimatedPrice = Convert.ToDouble(estimatedPrice);

            //Property and Address
            request.postalCode = Convert.ToInt32(postalCode);
            request.addressLine1 = addressLine1;

            //Address
            request.addressLine2 = addressLine2;
            request.ownershipCost = Convert.ToDouble(ownershipCost);
            request.exteriorArea = Convert.ToInt32(exteriorArea);
            request.interiorArea = Convert.ToInt32(interiorArea);
            request.buildYear = Convert.ToInt32(buildYear);

            _updateEntryInput.UpdateEntry(request);

        }

    }
}

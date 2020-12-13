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
            request.CaseID = Convert.ToInt32(CaseID);
            request.RealtorID = Convert.ToInt32(realtorID);
            request.CreationDate = DateTime.Parse(creationDate);
            if (!string.IsNullOrWhiteSpace(closedDate))
            {
                request.ClosedDate = DateTime.Parse(closedDate);
            }
            else
            {
                request.ClosedDate = null;
            }

            request.Price = Convert.ToDouble(price);

            //Property
            request.EstimatedPrice = Convert.ToDouble(estimatedPrice);

            //Property and Address
            request.PostalCode = Convert.ToInt32(postalCode);
            request.AddressLine1 = addressLine1;

            //Address
            request.AddressLine2 = addressLine2;
            request.OwnershipCost = Convert.ToDouble(ownershipCost);
            request.ExteriorArea = Convert.ToInt32(exteriorArea);
            request.InteriorArea = Convert.ToInt32(interiorArea);
            request.BuildYear = Convert.ToInt32(buildYear);

            _updateEntryInput.UpdateEntry(request);

        }

    }
}

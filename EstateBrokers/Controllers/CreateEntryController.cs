using System;
using UseCases.CreateEntry;

namespace Controllers
{
    public class CreateEntryController
    {
        ICreateEntryInput _createEntryInput;

        public CreateEntryController(ICreateEntryInput createEntryInput)
        {
            _createEntryInput = createEntryInput;

        }

        public void CreateEntry(decimal realtorID, decimal price, decimal estimatedprice, decimal postalCode, string addressLine1, 
            string AddressLine2, decimal ownershipCost, decimal exteriorArea, decimal interiorArea, decimal buildYear )
        {
            CreateEntryRequestModel request = new CreateEntryRequestModel();

            //For Case
            request.RealtorID = Convert.ToInt32(realtorID);

            request.CreationDate = DateTime.Today;
            request.Price = Convert.ToDouble(price);

            //For Property
            request.EstimatedPrice = Convert.ToDouble(estimatedprice);

            //For Property and Address
            request.PostalCode = Convert.ToInt32(postalCode);
            request.AddressLine1 = addressLine1;

            //For Address 
            request.AddressLine2 = AddressLine2;
            request.OwnershipCost = Convert.ToDouble(estimatedprice);
            request.ExteriorArea = Convert.ToInt32(exteriorArea);
            request.InteriorArea = Convert.ToInt32(interiorArea);
            request.BuildYear = Convert.ToInt32(buildYear);


            _createEntryInput.CreateEntry(request);

        }

    }
}

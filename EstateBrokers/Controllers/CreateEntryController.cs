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

        public void CreateEntry(string realtorID, string price, string estimatedprice, string postalCode, string addressLine1, 
            string AddressLine2, string ownershipCost, string exteriorArea, string interiorArea, string buildYear )
        {
            CreateEntryRequestModel request = new CreateEntryRequestModel();

            //For Case
            request.realtorID = Int32.Parse(realtorID);
            request.creationDate = DateTime.Today;
            request.price = Double.Parse(price);

            //For Property
            request.estimatedPrice = Double.Parse(estimatedprice);

            //For Property and Address
            request.postalCode = Int32.Parse(postalCode);
            request.AddressLine1 = addressLine1;

            //For Address 
            request.AddressLine2 = AddressLine2;
            request.ownershipCost = Double.Parse(ownershipCost);
            request.exteriorArea = Int32.Parse(exteriorArea);
            request.interiorArea = Int32.Parse(interiorArea);
            request.buildYear = Int32.Parse(buildYear);


            _createEntryInput.CreateEntry(request);

        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;
using UseCases.UpdateEntry;
using ViewModels;
using Presenters.IFrontEnd;
namespace Presenters.Presenters
{
    public class UpdateEntryPresenter : IUpdateEntryOutput
    {

        IShowEditAbleEntryFrontEnd _frontEnd;


        public UpdateEntryPresenter(IShowEditAbleEntryFrontEnd frontEnd)
        {
            _frontEnd = frontEnd;
        }

        public void ConfirmEntryCreation(UpdateEntryResponseModel response)
        {
            UpdateEntryViewModel updateEntryViewModel = new UpdateEntryViewModel();
            updateEntryViewModel.UpdateSuccess = response.EntryUpdatedSuccesfully;
            _frontEnd.ShowUpdateStatus(updateEntryViewModel);
        }

        public void ReturnEntryInformation(ShowEntryEditableResponseModel response)
        {
            UpdateEntryViewModel updateEntryViewModel = new UpdateEntryViewModel();
            
            //Case
            updateEntryViewModel.caseID = response.caseID.ToString();
            //
            updateEntryViewModel.realtorID = Convert.ToDecimal(response.realtorID.ToString());
            updateEntryViewModel.creationDate = response.creationDate.ToString();
            updateEntryViewModel.closedDate = response.closedDate.ToString();
            updateEntryViewModel.price = Convert.ToDecimal(response.price);

            //Property
            updateEntryViewModel.estimatedPrice = Convert.ToDecimal(response.estimatedPrice);

            //Property and Address
            updateEntryViewModel.postalCode = Convert.ToDecimal(response.postalCode);
            updateEntryViewModel.addressLine1 = response.addressLine1;

            //Address
            updateEntryViewModel.addressLine2 = response.addressLine2;
            updateEntryViewModel.ownershipCost = Convert.ToDecimal(response.ownershipCost);
            updateEntryViewModel.exteriorArea = Convert.ToDecimal(response.exteriorArea);
            updateEntryViewModel.interiorArea = Convert.ToDecimal(response.interiorArea);
            updateEntryViewModel.buildYear = Convert.ToDecimal(response.buildYear);

            _frontEnd.EntryToTextBoxes(updateEntryViewModel);
        }
    }
}

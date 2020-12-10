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
            throw new NotImplementedException();
        }

        public void ReturnEntryInformation(ShowEntryEditableResponseModel response)
        {
            ShowEditAbleEntryViewModel showEditAbleEntryViewModel = new ShowEditAbleEntryViewModel();

            //Case
            showEditAbleEntryViewModel.caseID = response.caseID.ToString();
            showEditAbleEntryViewModel.realtorID = response.realtorID.ToString();
            showEditAbleEntryViewModel.creationDate = response.creationDate.ToString();
            showEditAbleEntryViewModel.closedDate = response.closedDate.ToString();
            showEditAbleEntryViewModel.price = response.price.ToString();

            //Property
            showEditAbleEntryViewModel.estimatedPrice = response.estimatedPrice.ToString();

            //Property and Address
            showEditAbleEntryViewModel.postalCode = response.postalCode.ToString();
            showEditAbleEntryViewModel.addressLine1 = response.addressLine1;

            //Address
            showEditAbleEntryViewModel.addressLine2 = response.addressLine2;
            showEditAbleEntryViewModel.ownershipCost = response.ownershipCost.ToString();
            showEditAbleEntryViewModel.exteriorArea = response.exteriorArea.ToString();
            showEditAbleEntryViewModel.interiorArea = response.interiorArea.ToString();
            showEditAbleEntryViewModel.buildYear = response.buildYear.ToString();

            _frontEnd.EntryToTextBoxes(showEditAbleEntryViewModel);
        }
    }
}

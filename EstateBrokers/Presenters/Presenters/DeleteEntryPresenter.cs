using Presenters.IFrontEnd;
using UseCases.DeleteEntry;
using ViewModels;

namespace Presenters.Presenters
{
    public class DeleteEntryPresenter : IDeleteEntryOutput
    {

        public IDeleteEntryFrontEnd FrontEnd { get; set; }

        public DeleteEntryPresenter(IDeleteEntryFrontEnd deleteEntryFrontEnd)
        {
            FrontEnd = deleteEntryFrontEnd;
        }


        public void ConfirmDeletion(DeleteEntryResponseModel deleteEntryResponseModel)
        {
            DeleteEntryViewModel entryViewModel = new DeleteEntryViewModel();
            entryViewModel.CaseDeleteSucess = deleteEntryResponseModel.confirm;

            FrontEnd.confirmCaseDelete(entryViewModel);
        }
    }

}

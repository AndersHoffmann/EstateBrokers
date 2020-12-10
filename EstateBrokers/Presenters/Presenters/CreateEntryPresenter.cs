using System;
using UseCases.CreateEntry;
using ViewModels;
namespace Presenters
{

    public partial class CreateEntryPresenter : ICreateEntryOutput
    {
        ICreateEntryFrontEnd _frontEnd;

        public CreateEntryPresenter(ICreateEntryFrontEnd frontEnd)
        {
            _frontEnd = frontEnd;
        }

      
        public void ConfirmEntryCreation(CreateEntryResponseModel response)
        {
            CasesViewModel casesviewmodel = new CasesViewModel();

            casesviewmodel.CreateEntrySuccess = response.EntryCreatedSuccesfully;

            _frontEnd.DisplayCreateCasesStatus(casesviewmodel);
        }
    }

}

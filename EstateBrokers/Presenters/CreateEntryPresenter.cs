using System;
using UseCases.CreateEntry;
using ViewModels;
namespace Presenters
{

    public partial class CreateEntryPresenter : ICreateEntryOutput
    {
        public ICreateCaseFontEnd FrontEnd { get; set; }

        public CreateEntryPresenter(ICreateCaseFontEnd frontEnd)
        {
            FrontEnd = frontEnd;
        }

      
        public void ConfirmEntryCreation(CreateEntryResponseModel response)
        {
            CasesViewModel casesviewmodel = new CasesViewModel();

            casesviewmodel.CreateCasesSucess = response.EntryCreatedSuccesfully;

            FrontEnd.DisplayCreateCasesStatus(casesviewmodel);
        }
    }

}

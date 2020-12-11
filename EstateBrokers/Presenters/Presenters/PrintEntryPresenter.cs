using UseCases.PrintEntries;
using ViewModels;

namespace Presenters
{
    public class PrintEntryPresenter : IPrintEntriesOutput
    {
        IPrintEntryFrontEnd FrontEnd { get; set; }

        public PrintEntryPresenter(IPrintEntryFrontEnd frontEnd)
        {
            FrontEnd = frontEnd;
        }

        public void PrintSuccess(PrintEntriesResponseModel responseModel)
        {
            PrintEntryViewModel printviewmodel = new PrintEntryViewModel();
            printviewmodel.PrintEntrySucess = responseModel.success;

            FrontEnd.PrintSucess(printviewmodel);

        }
    }
}
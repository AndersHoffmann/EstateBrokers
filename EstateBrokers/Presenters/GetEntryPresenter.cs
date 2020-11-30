using System.Collections.Generic;
using UseCases.ShowCases;
using ViewModels;

namespace Presenters
{
    public partial class GetEntryPresenter : IShowEntryOutput
    {
        IGetEntryFrontEnd FrontEnd { get; set; }

        public GetEntryPresenter(IGetEntryFrontEnd frontend)
        {
            FrontEnd = frontend;
        }

        public List<ShowEntriesResponseModel> ReturnListOfEntries(List<ShowEntriesResponseModel> inputList)
        {
            ShowEntriesViewModel showEntriesViewModel = new ShowEntriesViewModel();

          //  showEntriesViewModel.Entries =
                return default;
        }
    }
}

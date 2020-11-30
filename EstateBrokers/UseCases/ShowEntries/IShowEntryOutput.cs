using System.Collections.Generic;

namespace UseCases.ShowCases
{
    interface IShowEntryOutput
    {
        public List<ShowEntriesRequestModel> ReturnListOfEntries(List<ShowEntriesRequestModel> inputList);
    }
}

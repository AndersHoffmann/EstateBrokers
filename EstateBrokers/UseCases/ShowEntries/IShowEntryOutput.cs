using System.Collections.Generic;

namespace UseCases.ShowCases
{
    public interface IShowEntryOutput
    {
        public List<ShowEntriesResponseModel> ReturnListOfEntries(List<ShowEntriesResponseModel> inputList);

    }
}

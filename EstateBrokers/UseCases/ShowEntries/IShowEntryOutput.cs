using System.Collections.Generic;

namespace UseCases.ShowCases
{
    public interface IShowEntryOutput
    {
        public void DisplayListOfEntries(List<ShowEntriesResponseModel> inputList);

    }
}

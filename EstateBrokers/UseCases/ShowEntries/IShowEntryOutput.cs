using System;
using System.Collections.Generic;
using System.Text;

namespace UseCases.ShowCases
{
    class IShowEntryOutput
    {
        public List<ShowEntriesRequestModel> ReturnListOfEntries(List<ShowEntriesRequestModel> inputList);
    }
}

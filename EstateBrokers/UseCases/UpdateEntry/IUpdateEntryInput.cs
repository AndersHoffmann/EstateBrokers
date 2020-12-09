using System;
using System.Collections.Generic;
using System.Text;

namespace UseCases.UpdateEntry
{
    public interface IUpdateEntryInput
    {
        public void UpdateEntry(UpdatedEntryRequestModel request);
        public void GetEntryInfo(ShowEntryEditableRequestModel request);
    }
}

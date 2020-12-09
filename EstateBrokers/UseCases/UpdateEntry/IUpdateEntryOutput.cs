using System;
using System.Collections.Generic;
using System.Text;

namespace UseCases.UpdateEntry
{
    public interface IUpdateEntryOutput
    {
        public void ConfirmEntryCreation(UpdateEntryResponseModel response);

        public void ReturnEntryInformation(ShowEntryEditableResponseModel response);
            
    }
}

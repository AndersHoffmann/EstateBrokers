using System;
using System.Collections.Generic;
using System.Text;

namespace UseCases.CreateEntry
{
    public interface ICreateEntryOutput
    {
        public void ConfirmEntryCreation(CreateEntryResponseModel response);
            
    }
}

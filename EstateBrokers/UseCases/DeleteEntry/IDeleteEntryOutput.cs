using System;
using System.Collections.Generic;
using System.Text;

namespace UseCases.DeleteEntry
{
    public interface IDeleteEntryOutput
    {
        public bool ConfirmDeletion(DeleteEntryResponseModel deleteEntryResponseModel);

    }
}

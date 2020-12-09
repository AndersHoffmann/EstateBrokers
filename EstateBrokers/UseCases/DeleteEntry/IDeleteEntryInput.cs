using System;
using System.Collections.Generic;
using System.Text;

namespace UseCases.DeleteEntry
{
    public interface IDeleteEntryInput
    {
        public void EntryDeletion(DeleteEntryRequestModel requestModel);

    }
}

using System;
using UseCases.DeleteEntry;

namespace Controllers
{
    public class DeleteEntryController
    {

        IDeleteEntryInput DeleteEntryInput;

        public DeleteEntryController(IDeleteEntryInput deleteEntryInput)
        {
            DeleteEntryInput = deleteEntryInput;
        }

        public void DeleteEntryID(string CaseID)
        {

            DeleteEntryRequestModel request = new DeleteEntryRequestModel();

            request.CaseID = Int32.Parse(CaseID);

            DeleteEntryInput.EntryDeletion(request);

        }

    }
}

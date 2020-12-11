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

        public void DeleteEntryID(decimal CaseID)
        {

            DeleteEntryRequestModel request = new DeleteEntryRequestModel();

            request.CaseID = Convert.ToInt32(CaseID);

            DeleteEntryInput.EntryDeletion(request);

        }

    }
}

using UseCases.UpdateEntry;
using System;
namespace Controllers
{
    public class GetEntryEditCaseData
    {
        IUpdateEntryInput _updateEntryInput;

        public GetEntryEditCaseData(IUpdateEntryInput updateEntryInput)
        {
            _updateEntryInput = updateEntryInput;
        }

        public void GetEntryEditInfo(string caseID)
        {
            ShowEntryEditableRequestModel requeset = new ShowEntryEditableRequestModel();

            requeset.CaseID = Int32.Parse(caseID);

            _updateEntryInput.GetEntryInfo(requeset);

        }


    }
}

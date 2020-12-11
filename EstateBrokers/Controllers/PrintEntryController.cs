using UseCases.PrintEntries;
using System;

namespace Controllers
{
    public class PrintEntryController
    {

        IPrintEntriesInput PrintInput;

        public PrintEntryController(IPrintEntriesInput printInput)
        {
            PrintInput = printInput;
        }

        public void PrintCases(decimal caseId)
        {
            PrintEntriesRequestModel request = new PrintEntriesRequestModel();
            request.CaseID = Convert.ToInt32(caseId);
            PrintInput.WriteToFile(request);

        }

    }
}

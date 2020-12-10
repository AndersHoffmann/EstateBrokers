using UseCases.PrintEntries;


namespace Controllers
{
    public class PrintEntryController
    {

        IPrintEntriesInput PrintInput;

        public PrintEntryController(IPrintEntriesInput printInput)
        {
            PrintInput = printInput;
        }

        public void PrintCases(int caseId)
        {
            PrintEntriesRequestModel request = new PrintEntriesRequestModel();
            request.CaseID = caseId;
            PrintInput.WriteToFile(request);

        }

    }
}

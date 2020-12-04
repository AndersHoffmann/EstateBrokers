using System;
using System.Collections.Generic;
using System.Text;
using UseCases.PrintEntries;

namespace Controllers
{
    class PrintEntriesController
    {
        public static IPrintEntriesInput PrintEntriesInput;

        public PrintEntriesController(IPrintEntriesInput printEntriesInput)
        {
            PrintEntriesInput = printEntriesInput;
        }
        public void StartPrintEntries()
        {
            PrintEntriesInput.WriteToFile(PrintEntriesRequestModel Reqeust);
        }
    }
}

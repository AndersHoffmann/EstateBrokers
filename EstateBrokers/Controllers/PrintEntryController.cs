﻿using UseCases.PrintEntries;


namespace Controllers
{
    public class PrintEntryController
    {

        public static IPrintEntriesInput PrintInput;

        public PrintEntryController(IPrintEntriesInput printInput)
        {
            PrintInput = printInput;
        }

        public void PrintCases(int caseId)
        {


        }


    }
}
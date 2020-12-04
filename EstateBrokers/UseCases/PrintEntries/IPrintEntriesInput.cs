using System;
using System.Collections.Generic;
using System.Text;

namespace UseCases.PrintEntries
{
    public interface IPrintEntriesInput
    {
        public void WriteToFile(PrintObject printObject);
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace UseCases.PrintEntries
{
    public interface IPrintEntriesOutput
    {
        public bool PrintSuccess(PrintEntriesResponseModel responseModel);
    }
}

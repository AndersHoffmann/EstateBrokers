using System;
using System.Collections.Generic;
using System.Text;

namespace Presenters
{
    class CreateEntryPresenter
    {
        public partial class CreateEntryPresenter : ICreateEntryOutput
        {
            public IFrontEnd FrontEnd { get; set; }
            public CreateEntryPresenter(IFrontEnd frontEnd)
            {
                FrontEnd = frontEnd;
            }

            public void DisplayData(CreateEntryResponseModel response)
            {
               //Martin skriv denne kode please
            }

        }
    }
}

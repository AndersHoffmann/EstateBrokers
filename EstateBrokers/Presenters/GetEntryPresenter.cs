using System.Collections.Generic;
using UseCases.ShowCases;
using ViewModels;
using System.Data;

namespace Presenters
{
    public partial class GetEntryPresenter : IShowEntryOutput
    {
        IGetEntryFrontEnd FrontEnd { get; set; }

        public GetEntryPresenter(IGetEntryFrontEnd frontend)
        {
            FrontEnd = frontend;
        }

        public void DisplayListOfEntries(List<ShowEntriesResponseModel> inputList)
        {
            ShowEntriesViewModel showEntriesViewModel = new ShowEntriesViewModel();

            var columnReference = new ShowEntriesResponseModel();

            foreach (var property in columnReference.GetType().GetProperties())
            {
                var tempColumn = new DataColumn();
                tempColumn.DataType = System.Type.GetType("System.String");
                tempColumn.ColumnName = property.ToString();
                showEntriesViewModel.Entries.Columns.Add(tempColumn);

                foreach (var entry in inputList)
                {
                    var row = showEntriesViewModel.Entries.NewRow();
                    row[$"{property}"] = entry.GetType().GetProperty($"{property}").GetValue(entry, null).ToString() ;
                }

            }

            FrontEnd.EntriesForDataGridView(showEntriesViewModel);
              
        }
    }
}

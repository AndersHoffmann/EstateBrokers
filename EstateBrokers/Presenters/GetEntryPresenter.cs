using System.Collections.Generic;
using UseCases.ShowCases;
using ViewModels;
using System.Data;
using System.Linq;
using System;
using System.Reflection;

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
            showEntriesViewModel.Entries = new DataTable();

            List<String> propertyNames = columnReference.GetType().GetProperties().Select(s => s.Name).ToList();

            foreach (var property in propertyNames)
            {
                var tempColumn = new DataColumn();
                tempColumn.DataType = System.Type.GetType("System.String");
                tempColumn.ColumnName = property;
                
                showEntriesViewModel.Entries.Columns.Add(tempColumn);
            }

            foreach (var entry in inputList)
            {
                var row = showEntriesViewModel.Entries.NewRow();

                var properties = columnReference.GetType().GetProperties();

                for (int i = 0; i < properties.Length; i++)
                {
                    row[i] = properties[i].GetValue(entry, null);
                }
                
                showEntriesViewModel.Entries.Rows.Add(row);
                
            }

            FrontEnd.EntriesForDataGridView(showEntriesViewModel);
              
        }
    }
}

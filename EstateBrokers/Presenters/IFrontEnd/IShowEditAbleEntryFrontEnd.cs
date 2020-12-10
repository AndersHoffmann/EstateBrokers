using ViewModels;
namespace Presenters.IFrontEnd
{
    public interface IShowEditAbleEntryFrontEnd
    {
        public void EntryToTextBoxes(UpdateEntryViewModel updateEntryViewModel);

        public void ShowUpdateStatus(UpdateEntryViewModel updateEntryViewModel);
          
    }
}

using UseCases.ShowCases;
namespace Controllers
{
    public class ShowEntryController
    {

        IShowEntryInput _showEntryInput;

        public ShowEntryController(IShowEntryInput showEntryInput)
        {

            _showEntryInput = showEntryInput;

        }

        public void StartShowEntries()
        {

            _showEntryInput.GetEntries();

        }

    }
}

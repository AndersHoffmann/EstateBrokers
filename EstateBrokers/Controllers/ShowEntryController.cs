using UseCases.ShowCases;
namespace Controllers
{
    public class ShowEntryController
    {

        public static IShowEntryInput ShowEntryInput;
        public ShowEntryController(IShowEntryInput showEntryInput)
        {

            ShowEntryInput = showEntryInput;

        }

        public void StartShowEntries()
        {

            ShowEntryInput.GetEntries();

        }

    }
}

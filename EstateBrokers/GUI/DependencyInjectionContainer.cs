using Bank;
using Controllers;
using Database;
using Database.Login;
using Gateways;
using Presenters;
using Presenters.Presenters;
using UseCases;
using UseCases.CreateEntry;
using UseCases.DeleteEntry;
using UseCases.EvaluateProperty;
using UseCases.Login;
using UseCases.OpenHouse;
using UseCases.PaymentCalculator;
using UseCases.PrintEntries;
using UseCases.ShowCases;
using UseCases.Statistics;
using UseCases.UpdateEntry;

namespace GUI
{
    public class DependencyInjectionContainer
    {
        public static EvaluatePropertyController GetEvaluatePropertyController(PropertyValuationPage propertyValuationPage)
        {
            IEvaluatePropertyOutput estimatesOutput = new EvaluatePropertyPresenter(propertyValuationPage);
            IEvaluatePropertyInput estimatesInput = new EvaluateProperty(estimatesOutput);

            return new EvaluatePropertyController(estimatesInput);
        }

        public static EstimatesController GetEstimatesController(PostalCodeEstimates postalCodeEstimates)
        {
            IEstimatesOutput estimatesOutput = new EstimatesPresenter(postalCodeEstimates);
            ICaseCRUD caseCRUD = new CaseCRUD();
            IEstimatesInput estimatesInput = new CalculateAverageM2PriceForArea(estimatesOutput, caseCRUD);

            return new EstimatesController(estimatesInput);
        }

        public static ShowEntryController GetShowEntryController(GetEntryPage getEntryPage)
        {
            IShowEntryOutput entryOutput = new GetEntryPresenter(getEntryPage);
            IAddressCRUD addressCRUD = new AddressCRUD();
            ICaseCRUD caseCRUD = new CaseCRUD();
            IPropertyCRUD propertyCRUD = new PropertyCRUD();
            IShowEntryInput entryInput = new ShowEntries(entryOutput, addressCRUD, caseCRUD, propertyCRUD);

            return new ShowEntryController(entryInput);
        }

        public static PrintEntryController GetPrintEntryController(GetEntryPage getEntryPage)
        {
            IPrintEntriesOutput printOutput = new PrintEntryPresenter(getEntryPage);
            IAddressCRUD addressCRUD = new AddressCRUD();
            ICaseCRUD caseCRUD = new CaseCRUD();
            IPropertyCRUD propertyCRUD = new PropertyCRUD();
            IRealtorCRUD realtorCRUD = new RealtorCRUD();
            IPrintEntriesInput printInput = new PrintEntry(printOutput, addressCRUD, caseCRUD, propertyCRUD, realtorCRUD);

            return new PrintEntryController(printInput);

        }

        public static DeleteEntryController DeleteEntryController(EntryPage entryPage)
        {

            IDeleteEntryOutput deleteEntryOutput = new DeleteEntryPresenter(entryPage);
            ICaseCRUD caseCRUD = new CaseCRUD();
            IPropertyCRUD propertyCRUD = new PropertyCRUD();
            IAddressCRUD addressCRUD = new AddressCRUD();
            IDeleteEntryInput deleteEntryInput = new DeleteEntry(deleteEntryOutput, caseCRUD, propertyCRUD, addressCRUD);

            return new DeleteEntryController(deleteEntryInput);

        }

        public static OpenHouseController GetOpenHouseController(OpenHousePage openHousePage)
        {
            IOpenHouseOutput openHouseOutput = new OpenHousePresenter(openHousePage);
            ICaseCRUD caseCRUD = new CaseCRUD();
            IRealtorCRUD realtorCRUD = new RealtorCRUD();
            IOpenHouseInput openHouseInput = new OpenHouseLogic(openHouseOutput, caseCRUD, realtorCRUD);

            return new OpenHouseController(openHouseInput);

        }

        public static PaymentCalculatorController GetPaymentCalculatorController(EstimatesPage estimatesPage)
        {
            IBank bank = new SimulatedBankPaymentCalculator();
            IPaymentCalculatorOutput paymentCalculatorOutput = new PaymentCalculatorPresenter(estimatesPage);
            IPaymentCalculatorInput paymentCalculatorInput = new CalculateMonthlyPayment(paymentCalculatorOutput, bank);

            return new PaymentCalculatorController(paymentCalculatorInput);

        }


        public static UpdateEntryController GetEntryEditCaseData(EditEntryPage editEntryPage)
        {
            IUpdateEntryOutput entryOutput = new UpdateEntryPresenter(editEntryPage);
            ICaseCRUD caseCRUD = new CaseCRUD();
            IPropertyCRUD propertyCRUD = new PropertyCRUD();
            IAddressCRUD addressCRUD = new AddressCRUD();

            IUpdateEntryInput updateEntryInput = new RunUpdateEntry(entryOutput, caseCRUD, propertyCRUD, addressCRUD);

            return new UpdateEntryController(updateEntryInput);

        }

        public static CreateEntryController GetCreateEntryController(CreateEntryPage createEntryPage)
        {

            ICreateEntryOutput createcaseOutput = new CreateEntryPresenter(createEntryPage);
            ICaseCRUD caseCRUD = new CaseCRUD();
            IPropertyCRUD propertyCRUD = new PropertyCRUD();
            IAddressCRUD addressCRUD = new AddressCRUD();

            ICreateEntryInput createcaseInput = new RunCreateEntry(createcaseOutput, caseCRUD, propertyCRUD, addressCRUD);

            return new CreateEntryController(createcaseInput);

        }

        public static LoginController GetLoginController(LoginPage loginPage)
        {

            ILogin login = new Login();
            ILoginOutput loginOutput = new LoginPresenter(loginPage);
            ILoginInput loginInput = new AuthLogin(loginOutput, login);

            return new LoginController(loginInput);

        }

    }
}

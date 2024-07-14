using Middle.Steps;
using NUnit.Framework;

namespace Middle.Tests.Tests
{
    public class ScenarioTest : TestRunner
    {
        [TestCase("Scenario 1")]
        public void Check_That_User_Can_Add_New_Currency(string searchQuery)
        {
            string currencyValue = "AED - Utd. Arab Emir. Dirham";
            string minimumSalary = "100";
            string maximumSalary = "1000";

            var login = new LoginSteps();

            login.LoginIntoTheApplication("Admin", "admin123");

            var home = new HomeSteps();
            home.NavigateToJobPayGrades();

            var payGrades = new PayGradesSteps();
            payGrades.AddPayGrade();

            var currency = new CurrencySteps();
            currency.AddNewCurrency(currencyValue, minimumSalary, maximumSalary);

            var viewCurrencies = new ViewCurrenciesSteps();
            Assert.Equals(currencyValue.Substring(6), viewCurrencies.GetCurrencyName());
            Assert.Equals(minimumSalary, viewCurrencies.GetCurrencyMinValue());
            Assert.Equals(maximumSalary, viewCurrencies.GetCurrencyMaxValue());
        }

        [TestCase("Scenario 2")]
        public void Check_That_User_Can_Be_Able_Not_Save_Currencies_Information(string searchQuery)
        {
            string currencyValue = "AED - Utd. Arab Emir. Dirham";
            string minimumSalary = "100";
            string maximumSalary = "1000";

            var login = new LoginSteps();

            login.LoginIntoTheApplication("Admin", "admin123");

            var home = new HomeSteps();
            home.NavigateToJobPayGrades();

            var payGrades = new PayGradesSteps();
            payGrades.AddPayGrade();

            var currency = new CurrencySteps();
            currency.AddNewCurrency(currencyValue, minimumSalary, maximumSalary);

            Assert.That(currency.IsCurrencyDisplayed(), Is.True);
        }
    }
}

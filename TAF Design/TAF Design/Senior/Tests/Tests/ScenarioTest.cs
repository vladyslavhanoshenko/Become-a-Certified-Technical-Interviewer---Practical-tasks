using NUnit.Framework;
using Senior.Data.Builders;
using Senior.Data.Models;
using Senior.Data.Storages;
using Senior.Steps;

namespace Senior.Tests.Tests
{
    public class ScenarioTest : TestRunner
    {
        private Currency? _currencyToBeCreated;
        private LoginSteps? _login;
        private HomeSteps? _home;
        private PayGradesSteps? _payGrades;
        private CurrencySteps? _currencySteps;

        [SetUp]
        public void Setup()
        {
            _currencyToBeCreated = new CurrencyBuilder()
                .WithCurrencyValue("AED - Utd. Arab Emir. Dirham")
                .WithMinimumSalary("100")
                .WithMaximumSalary("1000")
                .Build();

            _login = new LoginSteps();
            _login.LoginIntoTheApplication(UserStorage.AdminUser);

            _home = new HomeSteps();
            _home.NavigateToJobPayGrades();

            _payGrades = new PayGradesSteps();
            _payGrades.AddPayGrade();

            _currencySteps = new CurrencySteps();
            _currencySteps.AddNewCurrency(_currencyToBeCreated);
        }

        [Test]
        public void Check_That_User_Can_Add_New_Currency()
        {
            var viewCurrencies = new ViewCurrenciesSteps();
            Assert.Equals(_currencyToBeCreated!.CurrencyValue.Substring(6), viewCurrencies.GetCurrencyName());
            Assert.Equals(_currencyToBeCreated.MinimumSalary, viewCurrencies.GetCurrencyMinValue());
            Assert.Equals(_currencyToBeCreated.MaximumSalary, viewCurrencies.GetCurrencyMaxValue());
        }

        [Test]
        public void Check_That_User_Can_Be_Able_Not_Save_Currencies_Information()
        {
            Assert.That(_currencySteps!.IsCurrencyDisplayed(), Is.True);
        }
    }
}
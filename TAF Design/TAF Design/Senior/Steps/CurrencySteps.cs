using Senior.Config.Core;
using Senior.Data.Models;
using Senior.Pages;

namespace Senior.Steps
{
    public class CurrencySteps
    {
        private CurrencyPage currencyPage = new CurrencyPage();

        public void AddNewCurrency(Currency currency)
        {
            AddNewCurrency(currency.CurrencyValue, currency.MinimumSalary, currency.MaximumSalary);
        }

        public void AddNewCurrency(string currencyValue,
                                   string minimumSalary,
                                   string maximumSalary)
        {
            DriverHolder.Driver.FindElement(currencyPage.CurrencyCheckBox).Click();
            DriverHolder.Driver.FindElement(currencyPage.CurrencyAddButton).Click();
            DriverHolder.Driver.FindElement(currencyPage.CurrencyDropDown).Click();
            DriverHolder.Driver.FindElement(currencyPage.SetCurrencyValueDropDown(currencyValue)).Click();
            DriverHolder.Driver.FindElement(currencyPage.MinimumSalaryField).SendKeys(minimumSalary);
            DriverHolder.Driver.FindElement(currencyPage.MaximumSalaryField).SendKeys(maximumSalary);
            DriverHolder.Driver.FindElement(currencyPage.AddCurrencySaveButton).Click();
        }

        public void NotSaveNewCurrency(string currencyValue,
                                   string minimumSalary,
                                   string maximumSalary)
        {
            DriverHolder.Driver.FindElement(currencyPage.CurrencyCheckBox).Click();
            DriverHolder.Driver.FindElement(currencyPage.CurrencyAddButton).Click();
            DriverHolder.Driver.FindElement(currencyPage.CurrencyDropDown).Click();
            DriverHolder.Driver.FindElement(currencyPage.SetCurrencyValueDropDown(currencyValue)).Click();
            DriverHolder.Driver.FindElement(currencyPage.MinimumSalaryField).SendKeys(minimumSalary);
            DriverHolder.Driver.FindElement(currencyPage.MaximumSalaryField).SendKeys(maximumSalary);
            DriverHolder.Driver.FindElement(currencyPage.AddCurrencyCancelButton).Click();
        }

        public bool IsCurrencyDisplayed()
        {
            return DriverHolder.Driver.FindElement(currencyPage.NoRecordsFoundLabel).Displayed;
        }
    }
}

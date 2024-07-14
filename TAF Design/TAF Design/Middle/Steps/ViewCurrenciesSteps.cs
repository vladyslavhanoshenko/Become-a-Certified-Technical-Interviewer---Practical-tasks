using Middle.Config.Core;
using Middle.Pages;

namespace Middle.Steps
{
    public class ViewCurrenciesSteps
    {
        private ViewCurrenciesPage viewCurrenciesPage = new ViewCurrenciesPage();

        public string GetCurrencyName()
        {
            return DriverHolder.Driver.FindElement(viewCurrenciesPage.CurrencyName).Text;
        }

        public string GetCurrencyMinValue()
        {
            var actualCurrencyMinValue = DriverHolder.Driver.FindElement(viewCurrenciesPage.CurrencyMinValue).Text;
            return actualCurrencyMinValue.Substring(0, actualCurrencyMinValue.LastIndexOf("."));
        }

        public string GetCurrencyMaxValue()
        {
            var actualCurrencyMinValue = DriverHolder.Driver.FindElement(viewCurrenciesPage.CurrencyMaxValue).Text;
            return actualCurrencyMinValue.Substring(0, actualCurrencyMinValue.LastIndexOf("."));
        }
    }
}

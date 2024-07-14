using OpenQA.Selenium;

namespace Middle.Pages
{
    public class CurrencyPage
    {
        public By CurrencyCheckBox = By.XPath("//input[@type='checkbox']/following-sibling::span/i");
        public By CurrencyAddButton = By.XPath("//button[text()=' Add ']");
        public By CurrencyDropDown = By.XPath("//div[text()='-- Select --']");
        public By MinimumSalaryField = By.XPath("//label[text()='Minimum Salary']/parent::div/following-sibling::div/input");
        public By MaximumSalaryField = By.XPath("//label[text()='Maximum Salary']/parent::div/following-sibling::div/input");
        public By AddCurrencySaveButton = By.XPath("//h6[text()='Add Currency']/parent::div//button[@type='submit']");
        public By AddCurrencyCancelButton = By.XPath("//h6[text()='Add Currency']/parent::div//button[@type='button']");
        public By NoRecordsFoundLabel = By.XPath("//span[text()='No Records Found']");

        public By SetCurrencyValueDropDown(string currencyValue)
        {
            return By.XPath($"//div[@role='listbox']/div[@role='option']/span[text()='{currencyValue}']");
        }
    }
}
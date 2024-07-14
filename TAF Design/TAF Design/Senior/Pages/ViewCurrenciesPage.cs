using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senior.Pages
{
    public class ViewCurrenciesPage
    {
        public By CurrencyName = By.XPath("//div[@class='oxd-table-card']/div/div[2]/div");
        public By CurrencyMinValue = By.XPath("//div[@class='oxd-table-card']/div/div[3]/div");
        public By CurrencyMaxValue = By.XPath("//div[@class='oxd-table-card']/div/div[4]/div");
    }
}

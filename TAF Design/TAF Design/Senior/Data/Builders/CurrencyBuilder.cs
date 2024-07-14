using Senior.Data.Models;

namespace Senior.Data.Builders
{
    internal class CurrencyBuilder
    {
        private Currency _currency = new Currency();

        public CurrencyBuilder WithCurrencyValue(string currencyValue)
        {
            _currency.CurrencyValue = currencyValue;
            return this;
        }

        public CurrencyBuilder WithMinimumSalary(string minimumSalary)
        {
            _currency.MinimumSalary = minimumSalary;
            return this;
        }

        public CurrencyBuilder WithMaximumSalary(string maximumSalary)
        {
            _currency.MaximumSalary = maximumSalary;
            return this;
        }

        public Currency Build()
        {
            return _currency;
        }
    }
}

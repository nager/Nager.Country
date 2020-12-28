namespace Nager.Country.Currencies
{
    public class UsdCurrency : ICurrency
    {
        public string Symbol => "$";

        public string Singular => null;

        public string Plural => null;

        public string IsoCode => "USD";

        public string NumericCode => null;

        public string Name => "US Dollar";
    }
}

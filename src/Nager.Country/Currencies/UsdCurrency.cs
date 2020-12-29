namespace Nager.Country.Currencies
{
    public class UsdCurrency : ICurrency
    {
        public string Symbol => "$";

        public string Singular => null;

        public string Plural => null;

        public string IsoCode => "USD";

        public string NumericCode => "840";

        public string Name => "US Dollar";
    }
}

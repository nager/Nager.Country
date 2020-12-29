namespace Nager.Country.Currencies
{
    public class SgdCurrency : ICurrency
    {
        public string Symbol => "$";

        public string Singular => null;

        public string Plural => null;

        public string IsoCode => "SGD";

        public string NumericCode => "702";

        public string Name => "Singapore Dollar";
    }
}

namespace Nager.Country.Currencies
{
    public class NzdCurrency : ICurrency
    {
        public string Symbol => "$";

        public string Singular => null;

        public string Plural => null;

        public string IsoCode => "NZD";

        public string NumericCode => null;

        public string Name => "New Zealand Dollar";
    }
}

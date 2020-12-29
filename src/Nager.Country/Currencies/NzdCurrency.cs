namespace Nager.Country.Currencies
{
    public class NzdCurrency : ICurrency
    {
        public string Symbol => "$";

        public string Singular => null;

        public string Plural => null;

        public string IsoCode => "NZD";

        public string NumericCode => "554";

        public string Name => "New Zealand Dollar";
    }
}
